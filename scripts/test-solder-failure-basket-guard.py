#!/usr/bin/env python3
"""Regression guard for the *actual* WinForms SOLDER failure path.

Source-level safety net only: this does not claim a completed UI cash sale.
The checkout domain tests and isolated Windows build remain separate gates.
"""
from pathlib import Path
import re

ROOT = Path(__file__).resolve().parents[1]
SOURCE = ROOT / "recovered-source/LOGICA/Form_3_VENTE.cs"


def check(source):
    marker = "CheckoutTransactionFinalizationService.PostAndFinalize("
    start = source.find(marker)
    if start < 0:
        raise AssertionError("Real checkout finalization call missing")
    match = re.search(r"catch\s*\(Exception ex5\)\s*\{", source[start:])
    if not match:
        raise AssertionError("Expected checkout posting failure handler missing")
    open_brace = start + match.end() - 1
    depth = 0
    end = None
    for i in range(open_brace, len(source)):
        if source[i] == "{":
            depth += 1
        elif source[i] == "}":
            depth -= 1
            if depth == 0:
                end = i
                break
    if end is None:
        raise AssertionError("Checkout catch block not closed")
    handler = source[open_brace + 1:end]
    rollback = handler.find("CheckoutTransactionBoundaryService.Rollback(checkoutBoundary);")
    abort = handler.rfind("return;")
    if rollback < 0 or abort < rollback:
        raise AssertionError("Failed SOLDER must roll back and return before basket reset")
    if "Module1.dt1.Clear();" in handler:
        raise AssertionError("Failed SOLDER catch cleared cashier basket")
    next_reset = source.find("Module1.dt1.Clear();", end)
    if next_reset < 0 or next_reset - end > 500:
        raise AssertionError("Expected success-only basket reset missing or moved")
    between = source[end + 1:next_reset]
    if re.search(r"\b(?:catch|finally)\b", between):
        raise AssertionError("Unexpected control flow between failure handler and reset")
    return True


def self_test():
    base = """CheckoutTransactionFinalizationService.PostAndFinalize(
      x);
      catch (Exception ex5) {
        CheckoutTransactionBoundaryService.Rollback(checkoutBoundary);
        try { Log(); } catch (Exception ignored) { }
        ProjectData.ClearProjectError();
        return;
      }
      Module1.dt1.Clear();
    """
    check(base)
    broken = (
        base.replace("return;", ""),
        base.replace("return;", "/* no abort */"),
        base.replace("CheckoutTransactionBoundaryService.Rollback(checkoutBoundary);", ""),
        base.replace("return;", "Module1.dt1.Clear(); return;"),
        base.replace("CheckoutTransactionBoundaryService.Rollback(checkoutBoundary);", "return; CheckoutTransactionBoundaryService.Rollback(checkoutBoundary);"),
        base.replace("Module1.dt1.Clear();", "NoReset();"),
    )
    for n, fixture in enumerate(broken, 1):
        try:
            check(fixture)
        except AssertionError:
            continue
        raise AssertionError(f"Unsafe checkout fixture {n} was accepted")
    print(f"PASS: checkout failure-path guard rejected {len(broken)} unsafe fixtures")


if __name__ == "__main__":
    self_test()
    check(SOURCE.read_text(encoding="utf-8-sig"))
    print("PASS: production SOLDER rollback returns before success-only basket clear")
