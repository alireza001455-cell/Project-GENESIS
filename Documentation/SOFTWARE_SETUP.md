# Phase 0 — development environment

Updated: 2026-10-28. Status: Phase 0 Verified Complete. Phase 1/gameplay remains authorization-gated. Earlier dated audit sections preserve historical states; the final sign-off below supersedes their pending items.

## Initial inspection inventory (historical; see CURRENT_STATUS.md for latest)
- Working root: `C:/Users/alire/Documents/ChatGPT/Project GENESIS (codex)`.
- Before this session, this root contained only `.git`.
- Reference root: `C:/Users/alire/Desktop/Celestial/Project GENESIS`, containing `Instructions/writing-block.md` and two PNG screenshots. Screenshots have not yet been reviewed.
- Git: 2.53.0.windows.3, executable supplied by Codex's bundled runtime; standalone terminal availability has not been verified.
- Git LFS: 3.7.1 executable responds; repository LFS hooks/tracking not yet configured or verified.
- Repository: unborn `master`, no commits, no remotes. Git user identity has not been checked.
- Unity Hub, Unity Editor, Visual Studio, and VS Code were not found in the common locations checked. Unity, Unity Hub, VS Code and dotnet were not resolved on PATH. This does not prove they are absent elsewhere. Godot and other tools have not been exhaustively inventoried.
- C: approximately 680 GB free at inspection.
- Hardware/OS details via Windows CIM: access denied. No hardware conclusions can be drawn from those failed queries.

## Ordered checklist
1. **Assessment:** confirm hardware, OS, experience, time, budget, target platforms, and authoritative working folder.
2. **Engine decision:** compare Unity and Godot against actual needs and hardware using current official documentation, including licensing. Record engine, exact supported version, language, render pipeline, and input approach in DECISIONS.md. User approved Unity 6.6 6000.6.7f1/C# on 2026-10-28; platform Windows PC. See D-002.
3. **Essential tools:** install/verify the chosen editor and required build modules, compatible code editor/debugger, and Git accessible in the user's terminal. Verify versions and launch. Defer art/audio/ML tools until needed.
4. **Repository:** agree on canonical folder; configure main branch and ignore rules for the chosen engine, user identity, selective LFS, and GitHub remote/visibility. Make the initial commit and verify remote push. Never store credentials in files.
5. **Minimal engine project:** create the chosen engine project under Game/, pin versions/dependencies, configure input/rendering and test tooling, and open an empty environment test scene. No gameplay scripts.
6. **Local verification:** confirm clean compilation, scene opens/runs/stops, debugger attaches, appropriate test runner operates, and a standalone empty build launches. Record evidence and logs.
7. **Recovery verification:** clone into a separate clean directory, restore required dependencies/LFS assets, open with the pinned editor, build, and launch. Document repeatable steps.
8. **Gate review:** update verified status and resolve blocking setup issues. Only then plan the Cell Stage MVP and request direction to begin gameplay.

## Phase 0 acceptance evidence
All required Phase 0 checks passed. Reviewed adoption, pinned editor/tooling, scene/input/rendering, compilation, VS attachment/breakpoint, 2/2 EditMode tests, standalone Mono build/run/shutdown and clean-checkout recovery are recorded in PHASE0_RECOVERY_VERIFICATION.md and PHASE0_VERIFICATION.md. Developer assessment and final milestone sign-off are recorded below.

Do not mark checklist items complete from installation alone. Record actual observed results.

## 2026-10-28 software/project audit
See UNITY_ENVIRONMENT_AUDIT.md for exact installation paths, versions, component evidence and the proposed minimal layout. Unity and Visual Studio are now installed; the historical inventory above predates installation. Existing Hub project C:/Users/alire/Project GENESIS must be reviewed for adoption into canonical Game/ before creating anything. Its source files were inspected only; preserve all GUID/meta relationships and the original project. Unity/VS end-to-end compatibility, license state and build readiness remain untested. No project creation, adoption, commit or push in this audit.
## Adoption package-review gate — 2026-10-28
User approved guarded copy-first adoption, URP and Windows x64, subject to package review. All 45 direct dependency versions match the source lockfile. Preview Assistant/experimental Pipeline and optional AI/Version Control packages require user review before copying per the task's explicit stop instruction. See UNITY_ADOPTION_PACKAGE_REVIEW.md. No source/adopted project was changed or opened. No installation, tests, commit or push. After dependency decision, preserve original, copy only Assets/Packages/ProjectSettings, verify file hashes/metadata and ignore coverage, then resolve through the pinned editor and run environment checks.

## Adoption execution — 2026-10-28
Continuation directive approves the four package omissions. Game/ source copied with metadata and hash verification; original unchanged. Package graph regenerated by Unity (41 retained direct dependencies). Actual commands, transitive differences, licensing/compilation evidence, pending checks and recovery procedure are recorded in UNITY_ADOPTION_RESULTS.md. No package upgrades requested or manually forced. Verification paused at an orphan removed-package settings reference before scene/debugger/build checks; source preservation and no-generated-files Git checks passed. Do not treat the adopted project as fully verified.

## Hardware and toolchain verification — 2026-10-28
Read-only elevated CIM query succeeded: ASUS Zenbook 14 UX3405MA, Intel Core Ultra 7 155H, 31.4 GiB reported RAM, Intel Arc Graphics, driver 32.0.101.8860; C: approximately 641 GB free at inspection. This supersedes the earlier unavailable hardware-query evidence. User experience, availability and budget remain unanswered. Actual editor, sample scene and local build tests are more useful than inferring all performance suitability from specifications; no gameplay performance target is claimed.

Minimal editor-only tooling is at Game/Assets/Editor/GenesisEnvironment.cs: open preserved scene, select installed VS 2026 and generate solution, build Windows x64 Mono Development with debugging. Builds go to ignored Builds/Windows; evidence to ignored TestResults/UnityAdoption. Two smoke tests and their Editor-only assembly reside under Game/Assets/Tests/EditMode. No gameplay code or new packages added.

## Final local acceptance evidence — 2026-10-28
2/2 EditMode smoke tests passed; Windows x64 Mono development build succeeds with 0 errors/warnings; standalone startup/render and normal shutdown verified. ADOPTION-001 fixed, orphan entry absent on reopen. Adopted URP global settings retain postprocessing resources to avoid observed stripped-shader startup messages. No package upgrades. VS integration/solution generation verified, debugger attachment pending app access. Clean-clone engine recovery pending commit/push authorization. Use PHASE0_VERIFICATION.md for exact commands, evidence paths and remaining boundaries; do not mark Phase 0 closed from local checks alone.

## Recovery procedure executed — 2026-10-28
Published revision a430eaa recovered in a new temporary clone without Game/Library: licensing/package import/compilation succeeded, 2/2 tests passed, Windows x64 Mono development build 0 errors/warnings, and standalone render/normal shutdown observed. VS 2026 normal launch/attachment/breakpoint verified on canonical project. Use PHASE0_RECOVERY_VERIFICATION.md for results and local evidence paths. Machine-wide package cache reuse is normal and was not disabled. UnityConnect auto-enabled in the fresh import; restored only its disabled source value after closing engine; recovered tree then clean, lockfile unchanged. Original source remains unchanged. No native IL2CPP toolchain needed for this Mono milestone.

## Confirmed developer assessment and final sign-off — 2026-10-28
User-confirmed facts: programming experience complete beginner; game-development experience complete beginner; availability 5–8 hours/week; preferred sessions 90 minutes; software budget $0; Codex performs most coding while ChatGPT provides planning, architectural guidance and explanations; initial target Windows PC. Hardware and canonical folder are already recorded in the installation audit.

Phase 0 is Verified Complete under the user's final sign-off directive. The approved baseline is Unity 6000.6.7f1/C#/URP 17.6.0/Input System 1.20.1, Windows x64 Mono, VS Community 2026 18.11.2, Git 2.53.0.windows.3 and Git LFS 3.7.1. No large assets currently require LFS tracking rules. Native IL2CPP/C++ verification is outside this baseline.

Recovery evidence applies to a430eaa05a7948107ae200d4b0918aa08b233da7, Game subtree b1d3f16c88feb8130a5f1c7a34659a091f7ba10c, unchanged at bf075b82cbc64acaf2de9b614893ee3d64c1eecf and by this documentation-only sign-off. No engine tests were rerun for this documentation change. See PHASE0_RECOVERY_VERIFICATION.md for actual results, limitations and accepted nonblocking follow-ups. Phase 1 still requires explicit approval.
