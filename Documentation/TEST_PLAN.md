# Test plan

Phase 0 checks: tool versions and editor launch; compilation; empty scene run/stop; debugger; test runner; standalone build launch; clean-clone reproduction. Record commands, exact versions, results, and logs when executed. All required Phase 0 checks passed; see PHASE0_RECOVERY_VERIFICATION.md for observed results and final sign-off. Phase 0 is Verified Complete (2026-10-28). No engine tests were rerun for this documentation-only sign-off; gameplay tests await explicitly approved Phase 1 work.

Communication check: preserve the supplied protocol verbatim; verify its file hash; send it to the identified Project Genesis chat; confirm receipt separately from persistent project instructions; then verify a documentation commit through GitHub and independent retrieval. A sent chat message alone does not establish file synchronization.

After engine selection, consider inexpensive repository documentation checks on pull requests. Defer engine CI until a valid runner, toolchain, and any required licensing are verified. Defer scheduled monitors until basic communication works and cadence is established.

Executed on 2026-10-27: candidate and committed secret-pattern scans (no matches), ignore probes (expected exclusions), README local-link check (passed), staged whitespace check (passed), initial commit/push (passed), GitHub tree/file retrieval (passed), and clean-clone tree/hash comparison of all 16 files (passed). Independent ChatGPT retrieval was requested but has no inspectable result. Actions permission probes were blocked by connector endpoint restrictions. See COMMUNICATION_VERIFICATION.md for details.

## Local environment smoke tests — 2026-10-28
Added two Editor-only tests under Game/Assets/Tests/EditMode: effective URP asset/renderer availability and sample scene camera/missing-script integrity. Initial run failed only in restoring an empty batch scene setup; fixed teardown. Final run: 2 passed, 0 failed, exit 0. Manual Play Mode and final Windows x64 Mono development build/run/normal shutdown passed. Postprocess stripping fix verified by rebuilt player log. Actual VS debugger attachment and remote clean-clone engine verification still pending. Commands and evidence: PHASE0_VERIFICATION.md. No gameplay testing claimed.

## Remote recovery and IDE retry — 2026-10-28
Verified source published via 9e10d8d/a430eaa. Fresh-clone test run: 2 passed/0 failed, process exit 0. Fresh-clone Windows x64 Mono Development build: 0 errors/warnings, exit 0; recovered player rendering and normal shutdown passed. Canonical VS 2026 attachment and editor-only breakpoint/call stack/resume verified. PHASE0_RECOVERY_VERIFICATION.md records exact tested revision, source tree and limitations. No additional implementation changes needed; original source and dependency pins preserved.
