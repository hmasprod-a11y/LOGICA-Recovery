#!/usr/bin/env bash
# Fail closed on unreviewed source substitution before executing financial writers.
set -euo pipefail
manifest="${1:?source manifest required}"
expected_qa="${2:?exact QA commit required}"
[[ "$expected_qa" =~ ^[a-f0-9]{40}$ ]] || { echo 'Invalid QA commit'; exit 1; }
[[ -f "$manifest" ]] || { echo 'Source manifest missing'; exit 1; }
[[ "$(wc -l < "$manifest" | tr -d ' ')" == 3 ]] || { echo 'Unexpected source manifest length'; exit 1; }
grep -Fxq "qa=$expected_qa" "$manifest" || { echo 'QA SHA mismatch'; exit 1; }
grep -Fxq 'checkout=2bcdc8c17b81b6391bd4afce3c0aa76a9370337b' "$manifest" || { echo 'Checkout SHA mismatch'; exit 1; }
grep -Fxq 'architecture=f934763edbb0ae15c5e2a449bf6440b0d1bcca39' "$manifest" || { echo 'Architecture SHA mismatch'; exit 1; }
echo 'PASS exact production financial source provenance (not WPF E2E acceptance)'
