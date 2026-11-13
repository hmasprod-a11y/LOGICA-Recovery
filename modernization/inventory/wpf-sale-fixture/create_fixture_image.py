#!/usr/bin/env python3
"""Create the reproducible, valid PNG used by the disposable WPF sale fixture."""
import argparse
import pathlib
import struct
import zlib

def chunk(kind: bytes, payload: bytes) -> bytes:
    body = kind + payload
    return struct.pack(">I", len(payload)) + body + struct.pack(">I", zlib.crc32(body) & 0xffffffff)

def image_bytes() -> bytes:
    # Four opaque pixels, a simple high-contrast 2x2 test image. No third-party packages.
    rows = [bytes([0, 0, 88, 190, 255, 255, 255, 255, 255]),
            bytes([0, 255, 255, 255, 0, 0, 88, 190, 255])]
    header = struct.pack(">IIBBBBB", 2, 2, 8, 2, 0, 0, 0)
    return (b"\x89PNG\r\n\x1a\n" + chunk(b"IHDR", header) +
            chunk(b"IDAT", zlib.compress(b"".join(rows), level=9)) + chunk(b"IEND", b""))

def main() -> None:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--data-dir", required=True, help="Disposable WPF test data directory")
    args = parser.parse_args()
    target = pathlib.Path(args.data_dir).resolve() / "bd" / "images" / "fixture-soap.png"
    content = image_bytes()
    if target.exists():
        if target.read_bytes() != content:
            raise SystemExit(f"Refusing to replace existing image: {target}")
        print(f"Verified existing deterministic PNG: {target}")
        return
    target.parent.mkdir(parents=True, exist_ok=True)
    target.write_bytes(content)
    assert target.read_bytes() == content
    print(f"Created deterministic PNG: {target}")

if __name__ == "__main__":
    main()
