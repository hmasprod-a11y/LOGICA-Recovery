# Hanouty unified Windows integration gate

This branch is an isolated test workspace, NOT an approved release. Baseline: release/logica-2.0-beta-rc1.

## Integration order (stacked PRs)
1. PR #70 then #75 (Checkout); #75 already contains #70.
2. PR #72 then #74 (Business); #74 already contains #72.
3. PR #71 (Desktop).
4. PR #73 (QA artifact gate).

Latest inspected heads: #75 fe790f01162dc68ad133680b959a4cd50a192be0; #74 b03bd3ee089cef8a6409a23c0e54b695197fe9ff; #71 feb262c5d018cc3c695c4db3ea4aee3f9a1cc3ed; #73 8ce8e8ad62d9f189f94ee215411c9ee3c9a2150e.

## Required acceptance
- Integrate source trees into this branch with reviewed non-overlapping paths and preserve the exact source heads.
- Run Windows POS build, isolated MariaDB, Domain, .NET 10 compatibility and business smoke on the SAME integration SHA.
- Validate generated EXE, dependent DLLs, configuration, launcher and SHA256 manifest, then run the packaged EXE.
- Record exact CI URLs, failure ownership and artifact download link.
- Never use real shop data or merge into main/release without explicit approval.

## Current status
Only the isolated branch and integration gate document exist. Per-track CI successes do not imply unified acceptance. No integrated EXE has been verified.
