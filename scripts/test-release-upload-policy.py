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
    lines = source.splitlines()
    starts = [i for i, line in enumerate(lines)
              if line == '      - uses: actions/upload-artifact@v4']
    result = {}
    for start in starts:
        end = next((i for i in range(start + 1, len(lines))
                    if lines[i].startswith('      - ')), len(lines))
        block = lines[start + 1:end]

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
            'if': field(8, 'if'),
            'if-no-files-found': field(10, 'if-no-files-found', required=False),
        }
    return result


def assert_release_upload_policy(source):
    uploads = upload_steps(source)
    required = {
        'LOGICA-build-diagnostics': {'if': 'always()'},
        'LOGICA-2.0-Beta-RC1-Windows-x86': {'if': 'success()', 'if-no-files-found': 'error'},
        'LOGICA-Windows-complete': {'if': 'success()', 'if-no-files-found': 'error'},
    }
    for name, fields in required.items():
        if name not in uploads:
            raise ValueError(f'Missing required artifact upload: {name}')
        for field, expected in fields.items():
            actual = uploads[name][field]
            if actual != expected:
                raise ValueError(f'{name}: {field} must be {expected!r}, found {actual!r}')
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


if __name__ == '__main__':
    unittest.main(verbosity=2)
