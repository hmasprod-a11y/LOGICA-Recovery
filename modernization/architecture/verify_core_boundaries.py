#!/usr/bin/env python3
"""Check that both portable projects use one explicit set of real production sources."""
import argparse
import json
from pathlib import Path
import sys
import xml.etree.ElementTree as ET

PROJECTS = ("LOGICA.CoreCompatibility.csproj", "LOGICA.CorePortability.csproj")
FORBIDDEN_DIRS = {"forms", "winforms", "bunifu", "obj", "bin"}
FORBIDDEN_IMPORTS = ("System.Windows.Forms", "Bunifu", "MySql.", "Microsoft.VisualBasic")
FORBIDDEN_REFERENCES = ("System.Windows.Forms", "Bunifu", "MySql", "Microsoft.VisualBasic")

def local_name(tag):
    return tag.rsplit("}", 1)[-1]

def is_forbidden_reference(name):
    return any(name.lower() == p.lower() or name.lower().startswith(p.lower() + ".")
               for p in FORBIDDEN_REFERENCES)


def validate(root):
    root = Path(root).resolve()
    directory = root / "modernization"
    source_root = (root / "recovered-source" / "LOGICA").resolve()
    errors, targets, paths = [], {}, []
    for name in PROJECTS:
        try:
            project = ET.parse(directory / name).getroot()
            targets[name] = ";".join((n.text or "") for n in project.iter()
                                     if local_name(n.tag) in ("TargetFramework", "TargetFrameworks"))
            imports = [n.attrib.get("Project") for n in project.iter()
                       if local_name(n.tag) == "Import"]
            if imports.count("CoreSources.props") != 1:
                errors.append(name + ": shared manifest must be imported once")
            if any(n.attrib.get("Include") or n.attrib.get("Update")
                   for n in project.iter() if local_name(n.tag) == "Compile"):
                errors.append(name + ": direct Compile bypasses shared manifest")
            for node in project.iter():
                kind = local_name(node.tag)
                if kind in ("ProjectReference", "Reference", "PackageReference"):
                    reference = node.attrib.get("Include", "")
                    if kind == "ProjectReference" or is_forbidden_reference(reference):
                        errors.append(name + ": nonportable reference: " + reference)
                if kind == "EnableDefaultCompileItems" and (node.text or "").strip().lower() != "false":
                    errors.append(name + ": default compile items must be disabled")
        except (OSError, ET.ParseError) as exc:
            errors.append(name + ": " + str(exc))
    if targets.get(PROJECTS[0]) != "netstandard2.0;net10.0":
        errors.append("compatibility project must target netstandard2.0;net10.0")
    if targets.get(PROJECTS[1]) != "net10.0":
        errors.append("portability project must target net10.0")
    try:
        manifest = ET.parse(directory / "CoreSources.props").getroot()
        for entry in manifest.iter():
            if local_name(entry.tag) != "Compile":
                continue
            raw = entry.attrib.get("Include", "")
            if not raw or any(c in raw for c in ("$(", "*", "?")):
                errors.append("non-explicit source path: " + raw)
                continue
            source = (directory / raw.replace("\\", "/")).resolve()
            if not source.is_relative_to(source_root):
                errors.append("source outside recovered production tree: " + raw)
                continue
            relative = source.relative_to(source_root)
            if source.suffix.lower() != ".cs" or any(p.lower() in FORBIDDEN_DIRS for p in relative.parts):
                errors.append("nonportable source path: " + str(relative))
            if not source.is_file():
                errors.append("missing source: " + str(relative))
            else:
                code = source.read_text(encoding="utf-8-sig")
                for prefix in FORBIDDEN_IMPORTS:
                    if "using " + prefix in code or "Imports " + prefix in code:
                        errors.append("platform dependency in " + str(relative) + ": " + prefix)
            paths.append(relative.as_posix())
    except (OSError, ET.ParseError) as exc:
        errors.append("CoreSources.props: " + str(exc))
    if not paths:
        errors.append("manifest has no production sources")
    if len(paths) != len(set(paths)):
        errors.append("duplicate production source")
    return {"ok": not errors, "source_count": len(paths),
            "source_paths": sorted(set(paths)), "targets": targets, "errors": errors}

def main():
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--repo-root", type=Path, default=Path(__file__).resolve().parents[2])
    parser.add_argument("--json-out", type=Path)
    args = parser.parse_args()
    result = validate(args.repo_root)
    report = json.dumps(result, indent=2)
    if args.json_out:
        args.json_out.write_text(report + "\n", encoding="utf-8")
    print(report)
    return 0 if result["ok"] else 1

if __name__ == "__main__":
    sys.exit(main())
