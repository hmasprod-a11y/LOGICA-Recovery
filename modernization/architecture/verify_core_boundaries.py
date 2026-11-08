#!/usr/bin/env python3
"""Check that both portable projects use one explicit set of real production sources."""
import argparse
import json
import re
from pathlib import Path
import sys
import xml.etree.ElementTree as ET

PROJECTS = ("LOGICA.CoreCompatibility.csproj", "LOGICA.CorePortability.csproj")
FORBIDDEN_DIRS = {"forms", "winforms", "bunifu", "obj", "bin"}
FORBIDDEN_IMPORTS = ("System.Windows.Forms", "Bunifu", "MySql.", "Microsoft.VisualBasic")
FORBIDDEN_QUALIFIED_TYPES = re.compile(r"(?<![A-Za-z0-9_])(?:global\s*::\s*)?(?:System\s*\.\s*Windows\s*\.\s*Forms|Bunifu(?:\s*\.\s*[A-Za-z_]\w*)?|MySql(?:\s*\.\s*[A-Za-z_]\w*)?|Microsoft\s*\.\s*VisualBasic)\s*(?:\.|::)")
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
            if any(local_name(n.tag) == "Compile"
                   for n in project.iter()):
                errors.append(name + ": direct Compile bypasses shared manifest")
            for node in project.iter():
                kind = local_name(node.tag)
                if kind in ("Target", "UsingTask", "Task", "Exec", "Choose", "When", "Otherwise", "Sdk"):
                    errors.append(name + ": executable/conditional MSBuild element requires review: " + kind)
                if kind == "Import" and node.attrib.get("Project") != "CoreSources.props":
                    errors.append(name + ": unreviewed project import: " + str(node.attrib.get("Project")))
                if node.attrib.get("Condition"):
                    errors.append(name + ": conditional MSBuild element requires review: " + kind)
                if kind in ("Import", "ItemGroup", "PropertyGroup") and node.attrib.get("Condition"):
                    errors.append(name + ": conditional project structure requires review: " + kind)
                if kind in ("ProjectReference", "Reference", "PackageReference"):
                    reference = node.attrib.get("Include", "")
                    if kind == "ProjectReference" or is_forbidden_reference(reference):
                        errors.append(name + ": nonportable reference: " + reference)
                if kind == "EnableDefaultCompileItems" and (node.text or "").strip().lower() != "false":
                    errors.append(name + ": default compile items must be disabled")
            if not any(local_name(node.tag) == "EnableDefaultCompileItems" and
                       (node.text or "").strip().lower() == "false"
                       for node in project.iter()):
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
            kind = local_name(entry.tag)
            # The shared source manifest is data, not a general MSBuild extension point.
            # Reject property/item definitions and unknown nodes that can silently
            # change compilation even when all Compile Include paths look safe.
            if kind not in ("Project", "ItemGroup", "Compile"):
                errors.append("manifest unexpected MSBuild element requires review: " + kind)
            if kind in ("Target", "UsingTask", "Task", "Exec", "Choose", "When", "Otherwise", "Sdk"):
                errors.append("manifest executable/conditional MSBuild element requires review: " + kind)
            if kind == "Import":
                errors.append("manifest unreviewed import: " + str(entry.attrib.get("Project", "")))
            if entry.attrib.get("Condition"):
                errors.append("manifest conditional MSBuild element requires review: " + kind)
            if kind in ("ItemGroup", "PropertyGroup") and entry.attrib.get("Condition"):
                errors.append("manifest conditional structure requires review: " + kind)
            if kind in ("ProjectReference", "Reference", "PackageReference"):
                reference = entry.attrib.get("Include", "")
                if kind == "ProjectReference" or is_forbidden_reference(reference):
                    errors.append("manifest nonportable reference: " + reference)
            if kind == "EnableDefaultCompileItems" and (entry.text or "").strip().lower() != "false":
                errors.append("manifest cannot re-enable default compile items")
            if kind != "Compile":
                continue
            if any(key not in ("Include", "Link") for key in entry.attrib):
                errors.append("manifest Compile has unreviewed metadata: " + str(entry.attrib))
            raw = entry.attrib.get("Include", "")
            if entry.attrib.get("Condition") or any(k in entry.attrib for k in ("Update", "Remove", "Exclude")):
                errors.append("manifest conditional/indirect Compile is forbidden: " + raw)
                continue
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
                # Scan executable lines for imports too: a commented-out using must not
                # make an otherwise portable source fail its boundary check.
                executable_lines = "\n".join("" if line.lstrip().startswith("//") else line for line in code.splitlines())
                for prefix in FORBIDDEN_IMPORTS:
                    # C# global/alias imports and arbitrary whitespace are still imports.
                    # Do not let a tab or newline bypass the portable-source boundary.
                    csharp_import = re.compile(r"\b(?:global\s+)?using\s+(?:(?:static\s+)|(?:[A-Za-z_]\w*\s*=\s*))?(?:global::)?" + re.escape(prefix) + r"(?![A-Za-z0-9_])")
                    vb_import = re.compile(r"\bImports\s+" + re.escape(prefix), re.IGNORECASE)
                    if csharp_import.search(executable_lines) or vb_import.search(executable_lines):
                        errors.append("platform dependency in " + str(relative) + ": " + prefix)
                # Ignore line comments: mentioning a forbidden dependency in an explanatory
                # comment is not a production reference. Keep scanning executable source.
                if FORBIDDEN_QUALIFIED_TYPES.search(executable_lines):
                    errors.append("fully qualified platform dependency in " + str(relative))
            paths.append(relative.as_posix())
    except (OSError, ET.ParseError) as exc:
        errors.append("CoreSources.props: " + str(exc))
    if not paths:
        errors.append("manifest has no production sources")
    if len(paths) != len({path.casefold() for path in paths}):
        errors.append("duplicate production source (case-insensitive Windows path identity)")
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
