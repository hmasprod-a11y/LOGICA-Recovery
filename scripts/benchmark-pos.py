"""Synthetic ToDo service benchmark. GUI/executable startup is a separate metric."""
import argparse
import json
import math
import os
import platform
import statistics
import sys
import tempfile
import time
from pathlib import Path


def peak_memory_bytes():
    if os.name == 'nt':
        import ctypes
        from ctypes import wintypes
        class Counters(ctypes.Structure):
            _fields_ = [('cb', wintypes.DWORD), ('PageFaultCount', wintypes.DWORD)] + [(name, ctypes.c_size_t) for name in ('PeakWorkingSetSize','WorkingSetSize','QuotaPeakPagedPoolUsage','QuotaPagedPoolUsage','QuotaPeakNonPagedPoolUsage','QuotaNonPagedPoolUsage','PagefileUsage','PeakPagefileUsage')]
        value = Counters()
        value.cb = ctypes.sizeof(value)
        kernel = ctypes.WinDLL('kernel32', use_last_error=True)
        kernel.GetCurrentProcess.restype = wintypes.HANDLE
        api = ctypes.WinDLL('psapi', use_last_error=True).GetProcessMemoryInfo
        api.argtypes = [wintypes.HANDLE, ctypes.POINTER(Counters), wintypes.DWORD]
        if not api(kernel.GetCurrentProcess(), ctypes.byref(value), value.cb):
            raise ctypes.WinError(ctypes.get_last_error())
        return value.PeakWorkingSetSize
    import resource
    return resource.getrusage(resource.RUSAGE_SELF).ru_maxrss * (1 if sys.platform == 'darwin' else 1024)


def timing(fn, count):
    values = []
    cpu = time.process_time()
    for _ in range(count):
        start = time.perf_counter()
        fn()
        values.append((time.perf_counter() - start) * 1000)
    values.sort()
    return dict(samples=count, median_ms=round(statistics.median(values),3),
                p95_ms=round(values[math.ceil(.95 * count)-1],3), max_ms=round(max(values),3),
                process_cpu_ms=round((time.process_time()-cpu)*1000,3))


def main():
    parser = argparse.ArgumentParser()
    parser.add_argument('--todo-root', type=Path, required=True)
    parser.add_argument('--output', type=Path, required=True)
    args = parser.parse_args()
    start = time.perf_counter()
    sys.path.insert(0, str(args.todo_root.resolve() / 'todo'))
    import database as db
    from services.bootstrap import ensure_defaults
    from services.security import current_user
    from services.cash import open_session
    from services.catalog import search_products
    from services.sales import complete_sale
    previous = db.DB_PATH
    with tempfile.TemporaryDirectory() as td:
        db.DB_PATH = Path(td) / 'benchmark.db'
        token = None
        try:
            db.init_db(); ensure_defaults()
            init_ms = (time.perf_counter()-start)*1000
            with db.connect() as conn:
                uid = conn.execute('SELECT id FROM users ORDER BY id LIMIT 1').fetchone()[0]
                conn.executemany('INSERT INTO products(name,sku,sale_price_cents,stock_qty) VALUES(?,?,1250,10000)',
                                 [(f'Benchmark {i:05}', f'PERF{i:05}') for i in range(20000)])
                pid = conn.execute("SELECT id FROM products WHERE sku='PERF10000'").fetchone()[0]
            token = current_user.set(uid)
            sid = open_session(uid,0)
            def search():
                rows = search_products('PERF10000')
                assert any(r['id']==pid for r in rows), 'search result missing'
            cart = [dict(product_id=pid,qty=1,unit_price_cents=1250)]
            report = dict(schema_version=1, engine='todo', platform=platform.platform(), python=sys.version,
                          products=20000, service_import_and_fresh_db_init_ms=round(init_ms,3),
                          search_exact_reference=timing(search,50),
                          checkout_single_line=timing(lambda:complete_sale(sid,uid,cart,'CASH',1250),50))
            with db.connect() as conn:
                assert conn.execute('SELECT COUNT(*) FROM sales').fetchone()[0] == 50
                assert conn.execute('SELECT stock_qty FROM products WHERE id=?',(pid,)).fetchone()[0] == 9950
                assert conn.execute('PRAGMA integrity_check').fetchone()[0] == 'ok'
                assert not conn.execute('PRAGMA foreign_key_check').fetchall()
            report['process_peak_working_set_bytes'] = peak_memory_bytes()
            report['data_checks'] = 'passed'
            report['limitations'] = ['single process synthetic services', 'peak RAM includes seeding', 'not full executable startup', 'no physical print or scanner', 'no cross-machine absolute speed claim', 'no LOGICA performance comparison yet']
        finally:
            if token is not None: current_user.reset(token)
            db.DB_PATH = previous
    args.output.parent.mkdir(parents=True, exist_ok=True)
    args.output.write_text(json.dumps(report,indent=2)+'\n',encoding='utf-8')
    print(json.dumps(report,indent=2))


if __name__ == '__main__':
    main()
