#!/usr/bin/env python3
"""Read-only QA integration provenance gate for HANOUTY V3.1.

Usage:
  python modernization/qa/check_integration_provenance.py --qa-ref HEAD \
    --component Architecture=origin/architecture-branch \
    --component WPF=origin/wpf-branch
  python modernization/qa/check_integration_provenance.py --qa-ref HEAD \
    --component Checkout=<sha> --require-contained

This does not merge branches or certify runtime/SQL acceptance.
"""
import argparse
import json
import subprocess
import sys


def git(*args):
    p = subprocess.run(["git", *args], capture_output=True, text=True)
    if p.returncode:
        raise RuntimeError("git " + " ".join(args) + ": " + p.stderr.strip())
    return p.stdout.strip()


def verify_ref(ref):
    return git("rev-parse", "--verify", ref + "^{commit}")


def inspect(qa, label, ref):
    head = verify_ref(ref)
    base = git("merge-base", qa, head)
    counts = git("rev-list", "--left-right", "--count", qa + "..." + head).split()
    if len(counts) != 2:
        raise RuntimeError("Unexpected rev-list output for " + label)
    behind, ahead = map(int, counts)
    paths = git("diff", "--name-only", base, head).splitlines()
    return {
        "component": label, "component_sha": head, "merge_base": base,
        "qa_only_commits": behind, "component_only_commits": ahead,
        "contained_in_qa": ahead == 0,
        "component_changed_paths": paths,
    }


def main():
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--qa-ref", default="HEAD")
    parser.add_argument("--component", action="append", required=True,
                        help="LABEL=GIT_REF; repeat for each component")
    parser.add_argument("--require-contained", action="store_true",
                        help="Fail if any component HEAD is not an ancestor of QA")
    args = parser.parse_args()
    try:
        qa = verify_ref(args.qa_ref)
        results = []
        seen = set()
        for spec in args.component:
            label, sep, ref = spec.partition("=")
            if not sep or not label.strip() or not ref.strip():
                parser.error("--component requires LABEL=GIT_REF")
            if label in seen:
                parser.error("duplicate component label: " + label)
            seen.add(label)
            results.append(inspect(qa, label, ref))
        report = {"qa_sha": qa, "components": results,
                  "all_component_heads_contained": all(
                      r["contained_in_qa"] for r in results)}
        print(json.dumps(report, indent=2, sort_keys=True))
        if args.require_contained and not report["all_component_heads_contained"]:
            print("BLOCKED: QA does not contain every requested component HEAD",
                  file=sys.stderr)
            return 2
        return 0
    except RuntimeError as exc:
        print("PROVENANCE ERROR: " + str(exc), file=sys.stderr)
        return 3


if __name__ == "__main__":
    sys.exit(main())
