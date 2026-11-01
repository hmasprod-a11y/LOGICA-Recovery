#!/usr/bin/env python3
"""Protect Sprint48H CI against synthetic PR-merge checkout provenance drift.

Uses only the Python standard library. Every required gate must test the
reviewed integration HEAD, and failures must not be ignored.
"""
from pathlib import Path
import re
import unittest

ROOT = Path(__file__).resolve().parents[1]
WORKFLOWS = (
    ".github/workflows/windows-reference-diagnostic.yml",
    ".github/workflows/domain-tests.yml",
    ".github/workflows/portable-core.yml",
    ".github/workflows/hanouty-modern-core-compatibility.yml",
)
HEAD_EXPRESSION = "${{ github.event.pull_request.head.sha || github.sha }}"


def step_blocks(source):
    lines = source.splitlines()
    starts = [i for i, line in enumerate(lines) if line.startswith("      - ")]
    return ["\n".join(lines[i:starts[j + 1] if j + 1 < len(starts) else len(lines)])
            for j, i in enumerate(starts)]


def assert_exact_head_workflow(source):
    if not re.search(r"(?m)^  pull_request:\s*$", source):
        raise ValueError("Missing pull_request trigger")
    blocks = step_blocks(source)
    checkouts = [block for block in blocks if re.search(
        r"(?m)^      - uses: actions/checkout@v4\s*$", block)]
    if len(checkouts) != 1:
        raise ValueError("Exactly one reviewed-head checkout is required")
    checkout = checkouts[0]
    if f"ref: {HEAD_EXPRESSION}" not in checkout:
        raise ValueError("Checkout does not pin exact PR head")
    if not re.search(r"(?m)^\s+persist-credentials:\s*false\s*$", checkout):
        raise ValueError("Checkout must not persist credentials")
    guards = [block for block in blocks if "      - name: Assert exact candidate source SHA" in block]
    if len(guards) != 1:
        raise ValueError("Exactly one source SHA assertion is required")
    guard = guards[0]
    if f"EXPECTED_SHA: {HEAD_EXPRESSION}" not in guard:
        raise ValueError("SHA assertion must use the exact PR head")
    if "git rev-parse HEAD" not in guard or "$actual -ne $env:EXPECTED_SHA" not in guard:
        raise ValueError("SHA assertion does not reject a mismatched checkout")
    if "throw " not in guard:
        raise ValueError("SHA assertion must fail the job")
    if re.search(r"(?m)^\s+continue-on-error:\s*true\s*$", checkout + "\n" + guard):
        raise ValueError("Source provenance check cannot ignore failure")
    if blocks.index(guard) != blocks.index(checkout) + 1:
        raise ValueError("Source provenance must be checked immediately after checkout")
    return True


class ExactHeadWorkflowTests(unittest.TestCase):
    def test_all_four_required_gates(self):
        for path in WORKFLOWS:
            with self.subTest(workflow=path):
                assert_exact_head_workflow((ROOT / path).read_text(encoding="utf-8"))

    def test_negative_mutations(self):
        source = (ROOT / WORKFLOWS[0]).read_text(encoding="utf-8")
        assert_exact_head_workflow(source)
        mutations = {
            "synthetic_merge_checkout": source.replace(
                f"ref: {HEAD_EXPRESSION}", "ref: ${{ github.sha }}", 1),
            "missing_credentials_guard": source.replace(
                "persist-credentials: false", "persist-credentials: true", 1),
            "wrong_expected_commit": source.replace(
                f"EXPECTED_SHA: {HEAD_EXPRESSION}", "EXPECTED_SHA: ${{ github.sha }}", 1),
            "missing_commit_comparison": source.replace(
                "$actual -ne $env:EXPECTED_SHA", "$false", 1),
            "no_assertion": source.replace(
                "- name: Assert exact candidate source SHA", "- name: Skip provenance", 1),
            "ignored_assertion": source.replace(
                "- name: Assert exact candidate source SHA",
                "- name: Assert exact candidate source SHA\n        continue-on-error: true", 1),
        }
        for label, mutated in mutations.items():
            with self.subTest(mutation=label):
                self.assertNotEqual(mutated, source)
                with self.assertRaises(ValueError):
                    assert_exact_head_workflow(mutated)


if __name__ == "__main__":
    unittest.main(verbosity=2)
