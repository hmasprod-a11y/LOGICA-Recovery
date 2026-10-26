"""Reproducible static inventory; findings are candidates, never runtime proof.

Reads source/schema definitions only. Never exports database rows or SQL values.
"""
import argparse
import ast
import hashlib
import json
import re
from pathlib import Path

SQL_TABLE = re.compile(r'\b(?:FROM|JOIN|INTO|UPDATE|TABLE(?:\s+IF\s+NOT\s+EXISTS)?)\s+[`\[]?([\w\u0080-\uffff]+)', re.I)
CS_METHOD = re.compile(r'^\s*(?:public|private|protected|internal)\s+(?:(?:static|virtual|override|new|async|sealed)\s+)*(?:[\w.<>,\[\]?]+)\s+(\w+)\s*\(', re.M)
CS_CAPTION = re.compile(r'\b(\w+)\.(?:Text|HeaderText|ToolTipText)\s*=\s*"((?:\\.|[^"\\])*)"')


def inventory(root):
    files = []
    for path in sorted(root.rglob('*')):
        relative = path.relative_to(root).as_posix()
        if not path.is_file() or any(p in relative.split('/') for p in ('bin', 'obj', '.git', '__pycache__', 'results', 'overrides', '.comparison')):
            continue
        if path.suffix not in ('.cs', '.py', '.pyw', '.sql'):
            continue
        body = path.read_text(encoding='utf-8-sig')
        entry = dict(path=relative, sha256=hashlib.sha256(path.read_bytes()).hexdigest(),
                     lines=len(body.splitlines()), functions=[], ui_captions=[], sql_tables=[])
        if path.suffix in ('.py', '.pyw'):
            tree = ast.parse(body, filename=relative)
            for node in ast.walk(tree):
                if isinstance(node, (ast.FunctionDef, ast.AsyncFunctionDef)):
                    entry['functions'].append(dict(name=node.name, line=node.lineno,
                                                  kind='test' if node.name.startswith('test_') else 'function'))
                elif isinstance(node, ast.Call):
                    for keyword in node.keywords:
                        if keyword.arg in ('text', 'title') and isinstance(keyword.value, ast.Constant) and isinstance(keyword.value.value, str):
                            entry['ui_captions'].append(dict(line=node.lineno, text=keyword.value.value))
                elif isinstance(node, ast.Constant) and isinstance(node.value, str):
                    # Only SQL-looking strings; literal values and rows are discarded.
                    if re.search(r'\b(?:SELECT|INSERT|UPDATE|DELETE|CREATE\s+TABLE)\b', node.value, re.I):
                        entry['sql_tables'].extend(dict(table=m.group(1), line=node.lineno) for m in SQL_TABLE.finditer(node.value))
        else:
            for m in CS_METHOD.finditer(body) if path.suffix == '.cs' else []:
                entry['functions'].append(dict(name=m.group(1), line=body.count('\n', 0, m.start()) + 1,
                                              kind='event_handler' if m.group(1).endswith(('_Click', '_Load', '_Changed')) else 'method'))
            if path.suffix == '.cs':
                entry['ui_captions'] = [dict(control=m.group(1), text=m.group(2), line=body.count('\n', 0, m.start()) + 1) for m in CS_CAPTION.finditer(body)]
            if path.suffix == '.cs':
                # Restrict to C# string literals; comments/identifiers are not SQL.
                strings = re.finditer(r'@"(?:""|[^"])*"|"(?:\\.|[^"\\])*"', body)
                entry['sql_tables'] = [dict(table=m.group(1), line=body.count('\n', 0, literal.start()) + 1)
                                       for literal in strings for m in SQL_TABLE.finditer(literal.group())
                                       if re.search(r'\b(?:SELECT|INSERT|UPDATE|DELETE|CREATE\s+TABLE)\b', literal.group(), re.I)]
            else:
                entry['sql_tables'] = [dict(table=m.group(1), line=body.count('\n', 0, m.start()) + 1) for m in SQL_TABLE.finditer(body)]
        files.append(entry)
    return dict(files=files, summary=dict(files=len(files), functions=sum(len(f['functions']) for f in files),
                test_functions=sum(x['kind']=='test' for f in files for x in f['functions']),
                ui_captions=sum(len(f['ui_captions']) for f in files),
                schema_tables=sorted({m.group(1) for p in root.rglob('*.sql') for m in re.finditer(r'CREATE\s+TABLE\s+(?:IF\s+NOT\s+EXISTS\s+)?[`\[]?([\w]+)', p.read_text(encoding='utf-8-sig'), re.I)}),
                sql_table_candidates=sorted({x['table'] for f in files for x in f['sql_tables']})))


def main():
    parser = argparse.ArgumentParser()
    parser.add_argument('--logica-root', type=Path, required=True)
    parser.add_argument('--todo-root', type=Path, required=True)
    parser.add_argument('--output', type=Path, required=True)
    args = parser.parse_args()
    report = dict(schema_version=1, status='static_candidates_only',
                  limitations=['C# regex is not a compiler parser', 'dynamic SQL/translated captions may be missed',
                               'table candidates need schema review', 'test names do not establish feature coverage',
                               'database rows and physical screens are not inspected by this extractor'],
                  logica=inventory(args.logica_root), todo=inventory(args.todo_root))
    args.output.parent.mkdir(parents=True, exist_ok=True)
    args.output.write_text(json.dumps(report, ensure_ascii=False, indent=2) + '\n', encoding='utf-8')
    print(json.dumps({k: report[k]['summary'] for k in ('logica','todo')}, ensure_ascii=False, indent=2))


if __name__ == '__main__':
    main()
