#!/usr/bin/env python3
"""Fail closed if extracted Windows smoke is misreported as field acceptance.

This validates the evidence JSON only. It does NOT grant a license, enter a PIN,
post a sale, print, or touch a shop database. CI must remain BLOCKED for field
acceptance until separate authorized, interactive tests exist.
"""
import argparse
import copy
import json
from pathlib import Path

NOT_FIELD_VERIFIED = (
    "licensedCashierScreenVerified",
    "authorizedCashierLoginVerified",
    "settingsScreenOpenedVerified",
    "articleCreatedViaUiVerified",
    "articleImageSavedViaUiVerified",
    "solderCashPaymentVerified",
    "salePostedExactlyOnceVerified",
    "postCommitCloseOutcomeVerified",
    "ambiguousCommitOutcomeReconciledVerified",
    "doubleSolderClickIdempotencyVerified",
    "returnPostedViaUiVerified",
    "stockMovementPostedViaUiVerified",
    "barcodeScannerHardwareVerified",
    "printerHardwareVerified",
    "cashDrawerHardwareVerified",
    "realPrinterAndScannerVerified",
    # No server-side trace links the child EXE to a successful DB authentication.
    "directExeWithoutOverrideDatabaseConnectionVerified",
)
TRANSACTION_FINGERPRINT_TABLES = (
    "TABLE_ARTICLES",
    "TABLE_VENTES_ENTETE",
    "TABLE_VENTES_JOURNAL",
    "TABLE_VENTES_REGLEMENTS",
    "TABLE_MOUVEMENTS_STOCK",
)

STARTUP_VERIFIED = (
    "extractedExeResponsive",
    "extractedExeStartupSoakAllResponsive",
    "extractedLauncherVerified",
    "extractedLauncherActualExeResponsive",
    "extractedStartCmdActualExeResponsive",
    "directExeWithoutConnectionOverrideVerified",
    "directExeWithoutOverrideResponsiveWindow",
    "startupReadOnlyDatabaseCountsVerified",
    "isolatedArticleTicketContentStableAcrossEntrypoints",
    "transactionTableContentsStableAcrossEntrypoints",
    "originalFixtureContentMatchesFirstStartupVerified",
    "temporaryMariaDbClientCredentialsCleaned",
    "launcherLoginPinScreenVisible",
    "startCmdLoginPinScreenVisible",
    "directExeLoginPinScreenVisible",
    "startCmdOfflineMariaDbPreprovisioned",
    "directExeWithoutOverrideAttempted",
    "injectedExecutableProbeRejected",
    "immutableTamperProbeRejected",
    "immutableDeletionProbeRejected",
    "offlineServerPackageAbsent",
)


def validate(report, expected_commit=None):
    if not isinstance(report, dict):
        raise ValueError("Smoke evidence must be a JSON object")
    if report.get("releaseAcceptanceDecision") != "BLOCKED_FIELD_ACCEPTANCE":
        raise ValueError("Headless CI cannot approve field acceptance")
    if report.get("originalShopDatabaseTouched") is not False:
        raise ValueError("No-shop-data invariant missing or violated")
    if type(report.get("isolatedMariaDbPort")) is not int or report["isolatedMariaDbPort"] != 3308:
        raise ValueError("Expected isolated local MariaDB port 3308")
    sha = report.get("sourceCommit")
    if not isinstance(sha, str) or len(sha) != 40 or any(c not in "0123456789abcdefABCDEF" for c in sha):
        raise ValueError("Missing or invalid exact source SHA")
    if expected_commit is not None and sha.lower() != expected_commit.lower():
        raise ValueError("Smoke evidence source SHA differs from checked-out release")
    if type(report.get("isolatedSalesDigestCheckCount")) is not int or report["isolatedSalesDigestCheckCount"] != 3:
        raise ValueError("Expected independent checkout persistence fingerprints after all three entrypoints")
    if report.get("fingerprintedTransactionTables") != list(TRANSACTION_FINGERPRINT_TABLES):
        raise ValueError("Missing or changed full checkout transaction fingerprint coverage")
    for name in NOT_FIELD_VERIFIED:
        if report.get(name) is not False:
            raise ValueError(f"Unproven field acceptance was promoted or omitted: {name}")
    for name in STARTUP_VERIFIED:
        if report.get(name) is not True:
            raise ValueError(f"Missing successful extracted startup evidence: {name}")
    # Each of the three real extracted EXE lifetimes must have shown a
    # stable, responsive window. One successful retry cannot erase a failure.
    trials = report.get("extractedExeStartupTrials")
    if not isinstance(trials, list) or len(trials) != 3:
        raise ValueError("Missing three independent extracted EXE startup attempts")
    for index, trial in enumerate(trials, 1):
        if not isinstance(trial, dict) or type(trial.get("attempt")) is not int or trial["attempt"] != index:
            raise ValueError(f"Invalid extracted EXE startup attempt sequence: {index}")
        if (trial.get("responsive") is not True or trial.get("windowObserved") is not True
                or trial.get("earlyExit") is not False or trial.get("error") is not None):
            raise ValueError(f"Failed extracted EXE startup attempt: {index}")
        elapsed = trial.get("elapsedSeconds")
        if type(elapsed) not in (int, float) or not 0 < elapsed <= 60:
            raise ValueError(f"Invalid extracted EXE startup timing: {index}")
    for name in ("launcherActivationScreenVisible", "startCmdActivationScreenVisible",
                 "directExeWithoutOverrideActivationScreenVisible"):
        if report.get(name) is True:
            raise ValueError(f"Legacy activation panel visible: {name}")
        if name not in report:
            raise ValueError(f"Activation visibility evidence omitted: {name}")
    for name in ("launcherActivationAbsenceConfirmed", "startCmdActivationAbsenceConfirmed",
                 "directExeActivationAbsenceConfirmed"):
        if type(report.get(name)) is not bool:
            raise ValueError(f"Activation absence classification omitted: {name}")
    for prefix, visible_key, absent_key in (
        ("launcher", "launcherActivationScreenVisible", "launcherActivationAbsenceConfirmed"),
        ("startCmd", "startCmdActivationScreenVisible", "startCmdActivationAbsenceConfirmed"),
        ("directExe", "directExeWithoutOverrideActivationScreenVisible", "directExeActivationAbsenceConfirmed"),
    ):
        if report[visible_key] is not None and type(report[visible_key]) is not bool:
            raise ValueError(f"Invalid activation visibility type: {prefix}")
        if report.get(prefix + "ActivationInspectionStatus") != "inspected":
            raise ValueError(f"Activation UI inspection not completed: {prefix}")
        if report[absent_key] is not (report[visible_key] is False):
            raise ValueError(f"Contradictory activation absence evidence: {prefix}")
    for key in ("immutableRuntimeFilesVerified", "packagedCodeFilesVerified"):
        if type(report.get(key)) is not int or not 10 <= report[key] <= 10000:
            raise ValueError(f"Invalid verified runtime inventory: {key}")
    return True


def self_test():
    fixture = dict.fromkeys(NOT_FIELD_VERIFIED, False)
    fixture.update(dict.fromkeys(STARTUP_VERIFIED, True))
    fixture.update({
        "releaseAcceptanceDecision": "BLOCKED_FIELD_ACCEPTANCE",
        "originalShopDatabaseTouched": False,
        "isolatedMariaDbPort": 3308,
        "sourceCommit": "a" * 40,
        "isolatedSalesDigestCheckCount": 3,
        "extractedExeStartupTrials": [
            {"attempt": n, "responsive": True, "windowObserved": True,
             "earlyExit": False, "elapsedSeconds": 5.0, "error": None}
            for n in range(1, 4)
        ],
        "fingerprintedTransactionTables": list(TRANSACTION_FINGERPRINT_TABLES),
        "launcherActivationScreenVisible": None,
        "startCmdActivationScreenVisible": False,
        "directExeWithoutOverrideActivationScreenVisible": None,
        "launcherActivationAbsenceConfirmed": False,
        "startCmdActivationAbsenceConfirmed": True,
        "directExeActivationAbsenceConfirmed": False,
        "immutableRuntimeFilesVerified": 86,
        "packagedCodeFilesVerified": 100,
        "launcherActivationInspectionStatus": "inspected",
        "startCmdActivationInspectionStatus": "inspected",
        "directExeActivationInspectionStatus": "inspected",
    })
    validate(fixture, expected_commit="a" * 40)
    try:
        validate(fixture, expected_commit="b" * 40)
    except ValueError:
        pass
    else:
        raise AssertionError("Validator accepted a stale SHA from another release")
    cases = []
    for key in NOT_FIELD_VERIFIED:
        cases.append((key, True))
        cases.append((key, None))
    for key in STARTUP_VERIFIED:
        cases.append((key, False))
    cases.extend([
        ("releaseAcceptanceDecision", "ACCEPTED"),
        ("originalShopDatabaseTouched", True),
        ("isolatedMariaDbPort", 3306),
        ("sourceCommit", "unknown"),
        ("isolatedSalesDigestCheckCount", 2),
        ("isolatedSalesDigestCheckCount", True),
        ("isolatedSalesDigestCheckCount", None),
        ("extractedExeStartupTrials", None),
        ("extractedExeStartupTrials", []),
        ("extractedExeStartupTrials", [{"attempt": 1, "responsive": True}]),
        ("fingerprintedTransactionTables", None),
        ("fingerprintedTransactionTables", ["TABLE_ARTICLES", "TABLE_VENTES_ENTETE"]),
        ("fingerprintedTransactionTables", list(TRANSACTION_FINGERPRINT_TABLES[:-1])),
        ("fingerprintedTransactionTables", list(reversed(TRANSACTION_FINGERPRINT_TABLES))),
        ("fingerprintedTransactionTables", list(TRANSACTION_FINGERPRINT_TABLES) + ["TABLE_ARTICLES"]),
        ("transactionTableContentsStableAcrossEntrypoints", False),
        ("launcherActivationScreenVisible", True),
        ("startCmdActivationScreenVisible", True),
        ("launcherActivationScreenVisible", "unknown"),
        ("directExeWithoutOverrideActivationScreenVisible", True),
        ("launcherActivationAbsenceConfirmed", None),
        ("immutableRuntimeFilesVerified", 0),
        ("packagedCodeFilesVerified", True),
        ("launcherActivationInspectionStatus", "unavailable"),
        ("startCmdActivationAbsenceConfirmed", False),
        ("directExeActivationAbsenceConfirmed", True),
    ])
    for key, invalid in cases:
        broken = copy.deepcopy(fixture)
        broken[key] = invalid
        try:
            validate(broken)
        except ValueError:
            continue
        raise AssertionError(f"Validator accepted bad evidence: {key}={invalid!r}")
    for key, invalid in (
        ("attempt", 1), ("responsive", False), ("windowObserved", False),
        ("earlyExit", True), ("elapsedSeconds", 0), ("elapsedSeconds", True),
        ("error", "Timeout"),
    ):
        broken = copy.deepcopy(fixture)
        broken["extractedExeStartupTrials"][1][key] = invalid
        try:
            validate(broken)
        except ValueError:
            continue
        raise AssertionError(f"Validator accepted invalid EXE trial {key}={invalid!r}")
    print(f"PASS: acceptance report guard rejects {len(cases) + 7} negative fixtures")


if __name__ == "__main__":
    parser = argparse.ArgumentParser()
    parser.add_argument("--self-test", action="store_true")
    parser.add_argument("--report", type=Path)
    parser.add_argument("--expected-commit")
    args = parser.parse_args()
    if args.self_test:
        self_test()
    if args.report:
        if not args.expected_commit:
            parser.error("--report requires --expected-commit from the checked-out build")
        validate(json.loads(args.report.read_text(encoding="utf-8-sig")), expected_commit=args.expected_commit)
        print("PASS: extracted ZIP startup verified, field acceptance explicitly BLOCKED")
    if not args.self_test and not args.report:
        parser.error("Specify --self-test or --report")
