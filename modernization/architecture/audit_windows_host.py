#!/usr/bin/env python3
"""Deterministic migration blockers from the real Windows host project.

Read-only: this reports dependencies; it never edits project or shop data.
"""
import argparse
import json
import re
from pathlib import Path
import xml.etree.ElementTree as ET


def audit(root):
    root = Path(root)
    project = root / "recovered-source" / "LOGICA.csproj"
    tree = ET.parse(project)
    nodes = list(tree.iter())
    values = lambda name: [(n.text or "").strip() for n in nodes
                           if n.tag.rsplit("}", 1)[-1] == name]
    refs = sorted({n.attrib.get("Include", "") for n in nodes
                   if n.tag.rsplit("}", 1)[-1] == "Reference"})
    packages = sorted({n.attrib.get("Include", "") for n in nodes
                       if n.tag.rsplit("}", 1)[-1] == "PackageReference"})
    reports = sorted({n.attrib.get("Include", "") for n in nodes
                      if n.tag.rsplit("}", 1)[-1] == "EmbeddedResource"
                      and n.attrib.get("Include", "").lower().endswith(".rdlc")})
    dependency_dir = root / "dependencies"
    dlls = sorted(p.relative_to(root).as_posix() for p in dependency_dir.rglob("*.dll")) if dependency_dir.exists() else []
    source_root = root / "recovered-source"
    sources = sorted(p for p in source_root.rglob("*.cs")
                     if not set(p.relative_to(source_root).parts) & {"obj", "bin"})
    patterns = {
        "vb": re.compile(r"\\b(?:Microsoft\\.VisualBasic|Conversions\\.|Operators\\.|Interaction\\.)"),
        "sql": re.compile(r"\\b(?:MySqlCommand|MySqlConnection|MySqlDataAdapter|MySqlTransaction)\\b"),
    }
    coupling = {key: [] for key in patterns}
    for source in sources:
        lines = source.read_text(encoding="utf-8-sig", errors="replace").splitlines()
        for key, pattern in patterns.items():
            count = sum(bool(pattern.search(line)) for line in lines)
            if count:
                coupling[key].append({"path": source.relative_to(root).as_posix(), "matching_lines": count})
    blockers = []
    if "net48" in values("TargetFramework"):
        blockers.append("legacy_net48_host")
    if "x86" in values("PlatformTarget"):
        blockers.append("x86_host")
    if any("Microsoft.VisualBasic" in x for x in refs):
        blockers.append("visual_basic_runtime")
    if any("*" in x for x in refs):
        blockers.append("wildcard_binary_references")
    if reports:
        blockers.append("rdlc_runtime_validation_required")
    if dlls:
        blockers.append("binary_compatibility_validation_required")
    return {"host_project": project.relative_to(root).as_posix(),
            "target_frameworks": values("TargetFramework"),
            "platform_targets": values("PlatformTarget"),
            "windows_forms": values("UseWindowsForms"),
            "references": refs, "packages": packages,
            "rdlc_count": len(reports), "rdlc_paths": reports,
            "bundled_dll_count": len(dlls), "bundled_dll_paths": dlls,
            "production_source_count": len(sources),
            "production_coupling": coupling,
            "blockers": blockers,
            "net10_windows_host_verified": False,
            "peripheral_compatibility_verified": False}


def main():
    parser = argparse.ArgumentParser()
    parser.add_argument("--repo-root", type=Path, default=Path(__file__).resolve().parents[2])
    parser.add_argument("--json-out", type=Path)
    args = parser.parse_args()
    result = audit(args.repo_root.resolve())
    payload = json.dumps(result, indent=2) + "\n"
    if args.json_out:
        args.json_out.write_text(payload, encoding="utf-8")
    print(payload, end="")


if __name__ == "__main__":
    main()
