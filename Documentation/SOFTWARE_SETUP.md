# Phase 0 — development environment

Updated: 2026-10-27. Status: in progress; gameplay prohibited until the gate passes.

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
2. **Engine decision:** compare Unity and Godot against actual needs and hardware using current official documentation, including licensing. Record engine, exact supported version, language, render pipeline, and input approach in DECISIONS.md. No engine selected yet.
3. **Essential tools:** install/verify the chosen editor and required build modules, compatible code editor/debugger, and Git accessible in the user's terminal. Verify versions and launch. Defer art/audio/ML tools until needed.
4. **Repository:** agree on canonical folder; configure main branch and ignore rules for the chosen engine, user identity, selective LFS, and GitHub remote/visibility. Make the initial commit and verify remote push. Never store credentials in files.
5. **Minimal engine project:** create the chosen engine project under Game/, pin versions/dependencies, configure input/rendering and test tooling, and open an empty environment test scene. No gameplay scripts.
6. **Local verification:** confirm clean compilation, scene opens/runs/stops, debugger attaches, appropriate test runner operates, and a standalone empty build launches. Record evidence and logs.
7. **Recovery verification:** clone into a separate clean directory, restore required dependencies/LFS assets, open with the pinned editor, build, and launch. Document repeatable steps.
8. **Gate review:** update verified status and resolve blocking setup issues. Only then plan the Cell Stage MVP and request direction to begin gameplay.

## Phase 0 acceptance evidence
Pending: selected versions; successful editor and debugger checks; test runner result; standalone build/run; remote push; clean-clone build/run; reproducible setup instructions.

Do not mark checklist items complete from installation alone. Record actual observed results.
