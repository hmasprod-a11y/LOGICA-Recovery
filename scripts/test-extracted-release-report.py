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
    "returnPostedViaUiVerified",
    "stockMovementPostedViaUiVerified",
    "barcodeScannerHardwareVerified",
    "printerHardwareVerified",
    "cashDrawerHardwareVerified",
    "realPrinterAndScannerVerified",
)
STARTUP_VERIFIED = (
    "extractedExeResponsive",
    "extractedLauncherVerified",
    "extractedLauncherActualExeResponsive",
    "extractedStartCmdActualExeResponsive",
    "directExeWithoutConnectionOverrideVerified",
    "directExeWithoutOverrideResponsiveWindow",
    "startupReadOnlyDatabaseCountsVerified",
    "temporaryMariaDbClientCredentialsCleaned",
    "launcherLoginPinScreenVisible",
    "startCmdLoginPinScreenVisible",
    "directExeLoginPinScreenVisible",
)


def validate(report):
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
    for name in NOT_FIELD_VERIFIED:
        if report.get(name) is not False:
            raise ValueError(f"Unproven field acceptance was promoted or omitted: {name}")
    for name in STARTUP_VERIFIED:
        if report.get(name) is not True:
            raise ValueError(f"Missing successful extracted startup evidence: {name}")
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
    if report.get("immutableRuntimeFilesVerified", 0) < 10:
        raise ValueError("Incomplete immutable runtime verification")
    if report.get("packagedCodeFilesVerified", 0) < 10:
        raise ValueError("Incomplete packaged code verification")
    return True


def self_test():
    fixture = dict.fromkeys(NOT_FIELD_VERIFIED, False)
    fixture.update(dict.fromkeys(STARTUP_VERIFIED, True))
    fixture.update({
        "releaseAcceptanceDecision": "BLOCKED_FIELD_ACCEPTANCE",
        "originalShopDatabaseTouched": False,
        "isolatedMariaDbPort": 3308,
        "sourceCommit": "a" * 40,
        "launcherActivationScreenVisible": None,
        "startCmdActivationScreenVisible": False,
        "directExeWithoutOverrideActivationScreenVisible": None,
        "launcherActivationAbsenceConfirmed": False,
        "startCmdActivationAbsenceConfirmed": True,
        "directExeActivationAbsenceConfirmed": False,
        "immutableRuntimeFilesVerified": 86,
        "packagedCodeFilesVerified": 100,
    })
    validate(fixture)
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
        ("launcherActivationScreenVisible", True),
        ("startCmdActivationScreenVisible", True),
        ("directExeWithoutOverrideActivationScreenVisible", True),
        ("launcherActivationAbsenceConfirmed", None),
        ("immutableRuntimeFilesVerified", 0),
    ])
    for key, invalid in cases:
        broken = copy.deepcopy(fixture)
        broken[key] = invalid
        try:
            validate(broken)
        except ValueError:
            continue
        raise AssertionError(f"Validator accepted bad evidence: {key}={invalid!r}")
    print(f"PASS: acceptance report guard rejects {len(cases)} negative fixtures")


if __name__ == "__main__":
    parser = argparse.ArgumentParser()
    parser.add_argument("--self-test", action="store_true")
    parser.add_argument("--report", type=Path)
    args = parser.parse_args()
    if args.self_test:
        self_test()
    if args.report:
        validate(json.loads(args.report.read_text(encoding="utf-8-sig")))
        print("PASS: extracted ZIP startup verified, field acceptance explicitly BLOCKED")
    if not args.self_test and not args.report:
        parser.error("Specify --self-test or --report")
