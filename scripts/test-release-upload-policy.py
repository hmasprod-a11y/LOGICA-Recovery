#!/usr/bin/env python3
"""Regression gate: never advertise a failed/partial Windows build as a complete artifact.

Only the diagnostic artifact may be uploaded after a failed job. This intentionally
uses the standard library so it runs on the hosted Windows runner without PyYAML.
"""
from pathlib import Path
import re
import unittest

WORKFLOW = Path(__file__).resolve().parents[1] / '.github/workflows/windows-reference-diagnostic.yml'


def upload_steps(source):
    """Discover upload actions regardless of YAML step key ordering.

    A named step can put `uses` below `- name`; ignoring that shape would
    allow a second, unguarded upload to bypass the release policy.
    """
    lines = source.splitlines()
    starts = [i for i, line in enumerate(lines) if line.startswith('      - ')]
    result = {}
    for index, start in enumerate(starts):
        end = starts[index + 1] if index + 1 < len(starts) else len(lines)
        # Normalize either "- uses:" or "- name:" to an ordinary step field.
        block = ['        ' + lines[start][8:]] + lines[start + 1:end]
        actions = [m.group(1) for line in block
                   if (m := re.match(r'^        uses:\s*(\S+)\s*$', line))]
        uploads = [action for action in actions
                   if re.fullmatch(r'actions/upload-artifact@[^\s]+', action)]
        if not uploads:
            continue
        if len(actions) != 1 or len(uploads) != 1:
            raise ValueError(f'Ambiguous artifact upload action at line {start + 1}')

        def field(indent, name, required=True):
            pattern = re.compile(r'^' + ' ' * indent + re.escape(name) + r':\s*(.*?)\s*$')
            values = [m.group(1) for line in block if (m := pattern.match(line))]
            if not values and not required:
                return None
            if len(values) != 1:
                raise ValueError(f'Expected exactly one {name} in upload step at line {start + 1}')
            return values[0]

        name = field(10, 'name')
        if name in result:
            raise ValueError(f'Duplicate artifact upload: {name}')
        result[name] = {
            'path': field(10, 'path'),
            'if': field(8, 'if'),
            'if-no-files-found': field(10, 'if-no-files-found', required=False),
        }
    return result


def assert_release_upload_policy(source):
    uploads = upload_steps(source)
    required = {
        'LOGICA-build-diagnostics': {'if': 'always()', 'path': 'results/'},
        'LOGICA-2.0-Beta-RC1-Windows-x86': {'if': 'success()', 'if-no-files-found': 'error', 'path': 'release/'},
        'LOGICA-Windows-complete': {'if': 'success()', 'if-no-files-found': 'error', 'path': 'dist/'},
    }
    missing = set(required) - set(uploads)
    if missing:
        raise ValueError(f'Missing required artifact upload: {sorted(missing)}')
    unexpected = set(uploads) - set(required)
    if unexpected:
        raise ValueError(f'Unapproved artifact uploads: {sorted(unexpected)}')
    for name, fields in required.items():
        if name not in uploads:
            raise ValueError(f'Missing required artifact upload: {name}')
        for field, expected in fields.items():
            actual = uploads[name][field]
            if actual != expected:
                raise ValueError(f'{name}: {field} must be {expected!r}, found {actual!r}')
    return True



# These files directly affect the runnable Windows package, its isolated database
# or its regression checks. Omitting any from PR/push filters silently skips CI.
REQUIRED_WINDOWS_INPUTS = {
    'scripts/setup-test-db.ps1',
    'scripts/test-recovered-db.ps1',
    'scripts/Launch-LOGICA.ps1',
    'scripts/Start-LOGICA.cmd',
    'scripts/repair-source.py',
    'scripts/test-checkout-core.ps1',
    'scripts/test-release-upload-policy.py',
    'input/original-startup.json',
    'input/LOGICA-dependencies.zip',
    'input/recovered-original.sql',
    'input/mysql-compatibility.sql',
    'business/**',
    'modernization/**',
    'scripts/test-catalogue-core.ps1',
    'scripts/test-domain.ps1',
    'tests/**',
}


def trigger_paths(source, event):
    lines = source.splitlines()
    header = f'  {event}:'
    if header not in lines:
        raise ValueError(f'Missing Windows CI event: {event}')
    start = lines.index(header)
    block = []
    for line in lines[start + 1:]:
        if line and not line.startswith('    '):
            break
        block.append(line)
    if '    paths:' not in block:
        raise ValueError(f'{event}: missing paths filter')
    return {line.strip()[2:].strip("'\"")
            for line in block if re.match(r'^      - ', line)}


def assert_required_windows_triggers(source):
    for event in ('pull_request', 'push'):
        paths = trigger_paths(source, event)
        missing = REQUIRED_WINDOWS_INPUTS - paths
        if missing:
            raise ValueError(f'{event}: missing Windows CI paths: {sorted(missing)}')
    return True


def assert_optional_business_smoke_gate(source):
    """When Track B's smoke project is present, Windows CI must actually run it.

    Conditional execution keeps the legacy release branch working before PR #72
    is merged, while exercising the same production sources once it lands.
    """
    expected = "if: ${{ hashFiles('business/Hanouty.BusinessOperations.Smoke.csproj') != '' }}"
    lines = source.splitlines()
    name = '      - name: Exercise business operations .NET 10 smoke when available'
    if lines.count(name) != 1:
        raise ValueError('Missing or duplicated conditional business smoke step')
    start = lines.index(name)
    end = next((i for i in range(start + 1, len(lines))
                if lines[i].startswith('      - ')), len(lines))
    block = '\n'.join(lines[start + 1:end])
    if '        ' + expected not in block:
        raise ValueError('Business smoke must be conditional on project existence')
    if 'dotnet run --project business/Hanouty.BusinessOperations.Smoke.csproj -c Release' not in block:
        raise ValueError('Business smoke project is not executed')
    return True


def assert_optional_modern_core_gate(source):
    """Release CI must compile Track A's shared production sources on both targets.

    The conditional preserves the legacy release baseline before PR #70 lands;
    after integration a failing netstandard2.0 or net10.0 compile blocks artifacts.
    """
    lines = source.splitlines()
    name = '      - name: Compile shared modern core for dual targets when available'
    if lines.count(name) != 1:
        raise ValueError('Missing or duplicated dual-target modern core gate')
    start = lines.index(name)
    end = next((i for i in range(start + 1, len(lines))
                if lines[i].startswith('      - ')), len(lines))
    block = lines[start + 1:end]
    expected_condition = "        if: ${{ hashFiles('modernization/LOGICA.CoreCompatibility.csproj') != '' }}"
    expected_command = '        run: dotnet build modernization/LOGICA.CoreCompatibility.csproj -c Release --warnaserror'
    if expected_condition not in block:
        raise ValueError('Modern core gate must be conditional on project existence')
    if expected_command not in block:
        raise ValueError('Modern core dual-target compilation is not executed with warnings as errors')
    if any('continue-on-error:' in line for line in block):
        raise ValueError('Modern core gate must fail the release build on compiler errors')
    business = '      - name: Exercise business operations .NET 10 smoke when available'
    if business not in lines or start > lines.index(business):
        raise ValueError('Modern core gate must run before business smoke and packaging')
    return True



def assert_critical_release_gates(source):
    """A successful Windows artifact must imply every mandatory verification ran.

    GitHub Actions `continue-on-error` can turn a failed POS/database/packaging
    check into a successful job. A step-level `if` can skip the same checks.
    Reject both rather than trusting the artifact's upload condition alone.
    """
    lines = source.splitlines()
    if re.search(r'(?m)^\s+continue-on-error\s*:', source):
        raise ValueError('Release job must not suppress failures with continue-on-error')
    mandatory = (
        'Guard release artifact upload policy (including negative fixtures)',
        'Verify committed source is present',
        'Restore original runtime dependencies',
        'Build original project on Windows',
        'Start isolated test database',
        'Exercise original POS on Windows',
        'Verify original recovered Access data on MySQL',
        'Verify portable launcher with original data',
        'Finalize portable runtime package',
        'Gate unified beta candidate and generate file hashes',
        'Test offline release verifier with isolated adversarial fixtures',
        'Build and independently verify beta RC ZIP',
    )
    positions = []
    for name in mandatory:
        marker = '      - name: ' + name
        if lines.count(marker) != 1:
            raise ValueError(f'Missing or duplicated mandatory release step: {name}')
        start = lines.index(marker)
        end = next((i for i in range(start + 1, len(lines))
                    if lines[i].startswith('      - ')), len(lines))
        block = lines[start + 1:end]
        conditions = [line.strip() for line in block
                      if re.match(r'^        if\s*:', line)]
        if name == 'Finalize portable runtime package':
            if conditions != ['if: always()']:
                raise ValueError('Runtime finalizer must run even after failed builds')
        elif conditions:
            raise ValueError(f'Mandatory release step must not be skipped: {name}')
        positions.append(start)
    if positions != sorted(positions):
        raise ValueError('Mandatory release steps must retain verification order')
    last_gate = positions[-1]
    for index, line in enumerate(lines):
        if re.match(r'^\s+uses:\s*actions/upload-artifact@', line) and index < last_gate:
            raise ValueError('Release artifacts must be uploaded after verification')
    return True




FIXTURE = '''      - uses: actions/upload-artifact@v4
        if: always()
        with:
          name: LOGICA-build-diagnostics
          path: results/
          if-no-files-found: warn
      - uses: actions/upload-artifact@v4
        if: success()
        with:
          name: LOGICA-2.0-Beta-RC1-Windows-x86
          path: release/
          if-no-files-found: error
      - uses: actions/upload-artifact@v4
        if: success()
        with:
          name: LOGICA-Windows-complete
          path: dist/
          if-no-files-found: error
'''


class ReleaseUploadPolicyTests(unittest.TestCase):
    def test_repository_workflow(self):
        assert_release_upload_policy(WORKFLOW.read_text(encoding='utf-8'))

    def test_valid_policy(self):
        self.assertTrue(assert_release_upload_policy(FIXTURE))

    def test_partial_windows_artifact_is_rejected(self):
        modified = FIXTURE.replace('        if: success()\n        with:\n          name: LOGICA-Windows-complete',
                                   '        if: always()\n        with:\n          name: LOGICA-Windows-complete')
        with self.assertRaisesRegex(ValueError, 'LOGICA-Windows-complete: if'):
            assert_release_upload_policy(modified)

    def test_missing_complete_artifact_is_rejected(self):
        modified = FIXTURE.replace('name: LOGICA-Windows-complete', 'name: incomplete-runtime')
        with self.assertRaisesRegex(ValueError, 'Missing required artifact'):
            assert_release_upload_policy(modified)

    def test_missing_dist_files_must_fail(self):
        modified = FIXTURE.replace('name: LOGICA-Windows-complete\n          path: dist/\n          if-no-files-found: error',
                                   'name: LOGICA-Windows-complete\n          path: dist/\n          if-no-files-found: warn')
        with self.assertRaisesRegex(ValueError, 'if-no-files-found'):
            assert_release_upload_policy(modified)

    def test_diagnostics_remain_available_after_failure(self):
        modified = FIXTURE.replace('if: always()\n        with:\n          name: LOGICA-build-diagnostics',
                                   'if: success()\n        with:\n          name: LOGICA-build-diagnostics')
        with self.assertRaisesRegex(ValueError, 'LOGICA-build-diagnostics: if'):
            assert_release_upload_policy(modified)


    def test_release_paths_cannot_be_redirected(self):
        modified = FIXTURE.replace('name: LOGICA-Windows-complete\n          path: dist/',
                                   'name: LOGICA-Windows-complete\n          path: results/')
        with self.assertRaisesRegex(ValueError, 'LOGICA-Windows-complete: path'):
            assert_release_upload_policy(modified)

    def test_name_first_upload_cannot_bypass_success_gate(self):
        modified = FIXTURE.replace(
            '      - uses: actions/upload-artifact@v4\n        if: success()\n'
            '        with:\n          name: LOGICA-2.0-Beta-RC1-Windows-x86',
            '      - name: Publish beta\n        uses: actions/upload-artifact@v4\n'
            '        if: always()\n        with:\n'
            '          name: LOGICA-2.0-Beta-RC1-Windows-x86')
        with self.assertRaisesRegex(ValueError, 'LOGICA-2.0-Beta-RC1-Windows-x86: if'):
            assert_release_upload_policy(modified)

    def test_valid_name_first_upload_is_recognized(self):
        modified = FIXTURE.replace(
            '      - uses: actions/upload-artifact@v4\n        if: success()\n'
            '        with:\n          name: LOGICA-2.0-Beta-RC1-Windows-x86',
            '      - name: Publish beta\n        uses: actions/upload-artifact@v4\n'
            '        if: success()\n        with:\n'
            '          name: LOGICA-2.0-Beta-RC1-Windows-x86')
        self.assertTrue(assert_release_upload_policy(modified))

    def test_extra_name_first_upload_is_rejected(self):
        modified = FIXTURE + (
            '      - name: Publish unverified runtime\n'
            '        uses: actions/upload-artifact@v4\n'
            '        if: always()\n'
            '        with:\n'
            '          name: LOGICA-unverified\n'
            '          path: dist/\n')
        with self.assertRaisesRegex(ValueError, 'Unapproved artifact uploads'):
            assert_release_upload_policy(modified)

    def test_extra_upload_with_other_action_version_is_rejected(self):
        modified = FIXTURE + (
            '      - uses: actions/upload-artifact@v3\n'
            '        if: always()\n'
            '        with:\n'
            '          name: LOGICA-unverified\n'
            '          path: dist/\n')
        with self.assertRaisesRegex(ValueError, 'Unapproved artifact uploads'):
            assert_release_upload_policy(modified)

    def test_repository_triggers_cover_release_inputs(self):
        self.assertTrue(assert_required_windows_triggers(WORKFLOW.read_text(encoding='utf-8')))

    def test_missing_pr_database_trigger_is_rejected(self):
        source = WORKFLOW.read_text(encoding='utf-8')
        modified = source.replace("      - 'scripts/setup-test-db.ps1'\n", '', 1)
        with self.assertRaisesRegex(ValueError, 'pull_request: missing Windows CI paths'):
            assert_required_windows_triggers(modified)

    def test_missing_push_launcher_trigger_is_rejected(self):
        source = WORKFLOW.read_text(encoding='utf-8')
        before, after = source.split('  push:\n', 1)
        modified = before + '  push:\n' + after.replace("      - 'scripts/Launch-LOGICA.ps1'\n", '', 1)
        with self.assertRaisesRegex(ValueError, 'push: missing Windows CI paths'):
            assert_required_windows_triggers(modified)

    def test_missing_pr_event_is_rejected(self):
        source = WORKFLOW.read_text(encoding='utf-8')
        modified = source.replace('  pull_request:\n', '  pull_request_disabled:\n', 1)
        with self.assertRaisesRegex(ValueError, 'Missing Windows CI event'):
            assert_required_windows_triggers(modified)

    def test_optional_business_smoke_is_wired(self):
        self.assertTrue(assert_optional_business_smoke_gate(WORKFLOW.read_text(encoding='utf-8')))

    def test_business_smoke_cannot_be_removed(self):
        source = WORKFLOW.read_text(encoding='utf-8')
        modified = source.replace('      - name: Exercise business operations .NET 10 smoke when available',
                                  '      - name: Disabled business smoke', 1)
        with self.assertRaisesRegex(ValueError, 'Missing or duplicated'):
            assert_optional_business_smoke_gate(modified)

    def test_business_smoke_must_remain_conditional(self):
        source = WORKFLOW.read_text(encoding='utf-8')
        modified = source.replace("if: ${{ hashFiles('business/Hanouty.BusinessOperations.Smoke.csproj') != '' }}",
                                  'if: always()', 1)
        with self.assertRaisesRegex(ValueError, 'conditional'):
            assert_optional_business_smoke_gate(modified)

    def test_business_smoke_command_cannot_be_skipped(self):
        source = WORKFLOW.read_text(encoding='utf-8')
        modified = source.replace('dotnet run --project business/Hanouty.BusinessOperations.Smoke.csproj -c Release',
                                  'Write-Host skipped-business-smoke', 1)
        with self.assertRaisesRegex(ValueError, 'not executed'):
            assert_optional_business_smoke_gate(modified)

    def test_missing_pr_business_trigger_is_rejected(self):
        source = WORKFLOW.read_text(encoding='utf-8')
        modified = source.replace("      - 'business/**'\n", '', 1)
        with self.assertRaisesRegex(ValueError, 'pull_request: missing Windows CI paths'):
            assert_required_windows_triggers(modified)

    def test_missing_push_modernization_trigger_is_rejected(self):
        source = WORKFLOW.read_text(encoding='utf-8')
        before, after = source.split('  push:\n', 1)
        modified = before + '  push:\n' + after.replace("      - 'modernization/**'\n", '', 1)
        with self.assertRaisesRegex(ValueError, 'push: missing Windows CI paths'):
            assert_required_windows_triggers(modified)


    def test_optional_modern_core_gate_is_wired(self):
        self.assertTrue(assert_optional_modern_core_gate(WORKFLOW.read_text(encoding='utf-8')))

    def test_modern_core_gate_cannot_be_removed(self):
        source = WORKFLOW.read_text(encoding='utf-8')
        modified = source.replace('      - name: Compile shared modern core for dual targets when available',
                                  '      - name: Disabled modern core gate', 1)
        with self.assertRaisesRegex(ValueError, 'Missing or duplicated'):
            assert_optional_modern_core_gate(modified)

    def test_modern_core_gate_must_remain_conditional(self):
        source = WORKFLOW.read_text(encoding='utf-8')
        modified = source.replace("if: ${{ hashFiles('modernization/LOGICA.CoreCompatibility.csproj') != '' }}",
                                  'if: always()', 1)
        with self.assertRaisesRegex(ValueError, 'conditional'):
            assert_optional_modern_core_gate(modified)

    def test_modern_core_gate_must_compile_with_warnings_as_errors(self):
        source = WORKFLOW.read_text(encoding='utf-8')
        modified = source.replace(
            'dotnet build modernization/LOGICA.CoreCompatibility.csproj -c Release --warnaserror',
            'Write-Host skipped-modern-core-compatibility', 1)
        with self.assertRaisesRegex(ValueError, 'not executed'):
            assert_optional_modern_core_gate(modified)

    def test_modern_core_gate_must_not_ignore_errors(self):
        source = WORKFLOW.read_text(encoding='utf-8')
        modified = source.replace(
            '      - name: Compile shared modern core for dual targets when available',
            '      - name: Compile shared modern core for dual targets when available\n        continue-on-error: true', 1)
        with self.assertRaisesRegex(ValueError, 'must fail'):
            assert_optional_modern_core_gate(modified)



    def test_repository_release_gates_cannot_be_skipped(self):
        self.assertTrue(assert_critical_release_gates(WORKFLOW.read_text(encoding='utf-8')))

    def test_pos_failure_cannot_be_ignored(self):
        source = WORKFLOW.read_text(encoding='utf-8')
        modified = source.replace('      - name: Exercise original POS on Windows',
                                  '      - name: Exercise original POS on Windows\n        continue-on-error: true', 1)
        with self.assertRaisesRegex(ValueError, 'continue-on-error'):
            assert_critical_release_gates(modified)

    def test_database_check_cannot_be_skipped(self):
        source = WORKFLOW.read_text(encoding='utf-8')
        modified = source.replace('      - name: Verify original recovered Access data on MySQL',
                                  '      - name: Verify original recovered Access data on MySQL\n        if: false', 1)
        with self.assertRaisesRegex(ValueError, 'must not be skipped'):
            assert_critical_release_gates(modified)

    def test_job_failure_cannot_be_ignored(self):
        source = WORKFLOW.read_text(encoding='utf-8')
        modified = source.replace('  build-test:\n',
                                  '  build-test:\n    continue-on-error: true\n', 1)
        with self.assertRaisesRegex(ValueError, 'continue-on-error'):
            assert_critical_release_gates(modified)

    def test_release_verifier_cannot_be_removed(self):
        source = WORKFLOW.read_text(encoding='utf-8')
        modified = source.replace('      - name: Test offline release verifier with isolated adversarial fixtures',
                                  '      - name: Disabled release verifier', 1)
        with self.assertRaisesRegex(ValueError, 'Missing or duplicated mandatory'):
            assert_critical_release_gates(modified)

    def test_packaging_must_follow_verification(self):
        source = WORKFLOW.read_text(encoding='utf-8')
        verifier = '      - name: Test offline release verifier with isolated adversarial fixtures'
        package = '      - name: Build and independently verify beta RC ZIP'
        modified = source.replace(verifier, '      - name: PLACEHOLDER', 1).replace(
            package, verifier, 1).replace('      - name: PLACEHOLDER', package, 1)
        with self.assertRaisesRegex(ValueError, 'verification order'):
            assert_critical_release_gates(modified)




if __name__ == '__main__':
    unittest.main(verbosity=2)
