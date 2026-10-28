# Phase 0 Unity environment audit — 2026-10-28

## Repository and scope
- Canonical root: C:/Users/alire/Documents/ChatGPT/Project GENESIS (codex).
- Branch main; initial working tree clean. Local HEAD and live remote HEAD/main: `38547f6321315124280a087fed5d1063e23db79f`.
- Origin fetch/push: https://github.com/alireza001455-cell/Project-GENESIS.git.
- Canonical root contains documentation/configuration only, no Game/ or Unity ProjectVersion.txt. Desktop reference root also contains no ProjectVersion.txt. No whole-disk inventory was performed.
- This session changes documentation only. No editor/project launch, source adoption, project creation, installation, commit, push, or monitoring activation.

## Installation evidence (not runtime acceptance tests)
| Component | Observed evidence | Remaining verification |
|---|---|---|
| Unity Editor | C:/Program Files/Unity/Hub/Editor/6000.6.7f1/Editor/Unity.exe product version 6000.6.7f1_b22767f04f04 | Launch/license, Console, compilation and build |
| Unity Hub | Running Store installation under UnityTechnologies.UnityHub_3.22.4.65535_x64__2vrhnee42bhxm | Interactive version/about and license state not tested |
| Visual Studio | vswhere: Community 2026, display 18.11.2; installation 18.11.12324.101; complete/launchable; no reboot required | Actual launch, script opening, IntelliSense and debugger attach |
| Unity IDE tooling | vswhere confirms ManagedGame workload and Unity component; Visual Studio Tools for Unity DLLs present | End-to-end Unity/VS 2026 integration |
| .NET SDK | Explicit dotnet.exe --list-sdks: 10.0.403 under C:/Program Files/dotnet/sdk | Not on current shell PATH; Unity's compilation uses its own tooling, do not retarget Unity scripts to .NET 10 |
| Git | 2.53.0.windows.3, bundled Codex executable; live remote query succeeded | Availability in user's separate terminal remains untested |
| Git LFS | 3.7.1; filter configuration responds | No repository pre-push hook, attributes, or binary round-trip; configure selectively before large binary commits |
| Windows modules | windowsstandalonesupport with win64 Mono/IL2CPP variations present; WebGL also present | Standalone build execution |
| Native build toolchain | vswhere did not find VC.Tools.x86.x64 or Windows11SDK.26100; standard Windows Kits/10/Include path not found | Treat Windows IL2CPP as not ready; other SDK versions were not exhaustively inventoried |

## Existing project inspection
Store Hub's hub.db was queried read-only, projects table only. It contains one row:
- Title/path: Project GENESIS, C:/Users/alire/Project GENESIS.
- Editor: 6000.6.7f1, b22767f04f04, x86_64; build target StandaloneWindows64; renderPipeline URP. Hub cloudEnabled is true; no cloud settings were changed.
- On-disk ProjectSettings/ProjectVersion.txt confirms the editor revision. Assets/, Packages/, ProjectSettings/, Library/, Logs/, UserSettings/ exist. Git reports this path is not a repository.
- Assets include Scenes/SampleScene.unity, pipeline/renderer settings, InputSystem_Actions.inputactions, and template Readme scripts. The only .cs files found under Assets were TutorialInfo/Readme.cs and TutorialInfo/Editor/ReadmeEditor.cs. No custom gameplay was identified in this bounded source inspection.
- Project configuration: productName Project GENESIS; companyName DefaultCompany; activeInputHandler 1 (new Input System); Force Text serialization (2); Visible Meta Files.
- Resolved packages from packages-lock.json: URP 17.6.0 (builtin), Input System 1.20.1 (registry), Visual Studio Editor 2.0.28 (registry), Test Framework 1.8.0 (builtin). Cache directories for the IDE/Input/Test packages are present. Resolution files/cache do not prove error-free import or compilation.
- Extra manifest dependencies include AI Assistant 2.21.0-pre.2, AI Inference 2.6.1, pipeline 0.9.1-exp.1, Unity Version Control 2.13.6, and Rider integration 3.1.0. Their necessity, external services, and preview/experimental compatibility require review; none were removed.

## Proposed setup for review (not executed)
Prefer adopting the existing project rather than creating another. First confirm that this is the user's intended Genesis project, close any editor using it, review unsaved work and package requirements, and preserve a recovery copy. Transfer only Assets/ (with every .meta), Packages/, and ProjectSettings/ into the currently absent canonical Game/; preserve the original external folder until canonical launch and recovery succeed. This is a controlled adoption, not a second independently maintained project. No new .git repository. Update Hub to the canonical path only after successful verification, without deleting project data.

Minimal tracked layout:

```text
Game/
  Assets/
    Scenes/                 # initially retain SampleScene; later environment-only verification scene
    Settings/               # existing URP assets/renderer settings
    InputSystem_Actions.inputactions
    Tests/                  # add EditMode/PlayMode assemblies only with meaningful environment checks
  Packages/
    manifest.json
    packages-lock.json
  ProjectSettings/          # including ProjectVersion, editor, input and build settings
```

Preserve other source assets during adoption; the diagram is a minimum, not a deletion list. Do not create empty gameplay modules or placeholders. Future scripts/prefabs/art folders arise only when needed.

- Proposed rendering: existing URP 17.6.0, conservative desktop settings. Keep existing references/GUIDs; verify graphics and quality pipeline assignments.
- Proposed input: Input System 1.20.1 only, keyboard/mouse initially. Preserve existing action asset; no player-control scripts or new action design during setup.
- Proposed IDE: Visual Studio 2026 selected as external editor with com.unity.ide.visualstudio 2.0.28. Verify generated solution, script opening and debugger before claiming compatibility.
- Test tooling: editor-supplied Test Framework 1.8.0. Confirm Test Runner and EditMode/PlayMode support in the adopted project; do not replace it with a guessed version or add performance packages yet.
- Proposed first build: Windows x86_64, Mono, Development Build, avoiding the currently missing native IL2CPP prerequisites. No deployment. If IL2CPP is chosen instead, verify/install compatible C++ tools and Windows SDK first.
- Review optional preview/AI/service and redundant IDE/version-control packages before deciding which to retain. Do not blindly reset the manifest to template defaults. The installed blank URP template 17.2.6 defaults to older Input 1.20.0; preserve the existing resolved 1.20.1 unless a verified reason warrants change.
- Existing ignore rules cover Game/Library, Temp, Logs, UserSettings and build outputs. Review generated solution/csproj ignore additions before adoption. Keep metadata, source assets, package lock and project settings tracked; configure LFS/hook only for selected binary source assets when introduced.

## Risks and gates
- Primary risk: two paths bearing Genesis names; creating a fresh project now would duplicate source. Adoption must be reviewed first.
- User hardware/GPU/RAM and experience remain unknown; installed files do not establish URP performance suitability.
- Unity 6.6 is the current update release, not the LTS line. Approved version remains pinned; updates require a deliberate compatibility review.
- Licenses, offline/network package restore, editor startup, errors, C# compilation, scene execution, debugger, tests, standalone build and clean-checkout engine build are unverified. No software was declared fully configured from version files alone.
- No tests/builds were run and the external project was not modified. Next safe action is review of this adoption/input/backend/package scope, then controlled adoption and environment verification. No gameplay.

## Official references checked
- https://unity.com/releases/editor/whats-new/6000.6.7f1 — release and changeset match installed editor.
- https://docs.unity3d.com/6000.6/Documentation/Manual/windows-requirements-and-compatibility.html — native IL2CPP requirements.
- https://docs.unity3d.com/6000.6/Documentation/Manual/com.unity.test-framework.html — editor test tooling.
- https://learn.microsoft.com/en-us/visualstudio/gamedev/unity/get-started/getting-started-with-visual-studio-tools-for-unity — Unity workload, external editor and IDE package setup. This general guide alone does not prove this exact editor/VS pairing works.

## Adoption preflight follow-up — 2026-10-28
P0-UNITY-ADOPTION-01 now approves guarded copy-first adoption and URP/Windows x64, superseding the review-only scope above. Preflight remains consistent: Game/ absent, source editor revision unchanged, local/remote main match. No .cs files beyond the two template Readme files were found under Assets. Full manifest/lock and local package license review documented in UNITY_ADOPTION_PACKAGE_REVIEW.md (45 direct dependencies). User's package stop condition was reached; no copying, editor launch, package mutation, tests or builds performed. The external original is unchanged by Codex. No commit/push.

## Local adoption execution follow-up — 2026-10-28
The user's continuation directive clears the four-package decision and authorizes guarded copying. Game/ was adopted; 69 original files hash-verified before manifest omission. Unity removed four direct/four orphan dependencies; original source unchanged. Licensing and generated C# assemblies observed. New blocker: App UI config-object reference remains in EditorBuildSettings.asset but its Sentis asset is absent after package omission. Stop condition honored; no settings repair attempted. See UNITY_ADOPTION_RESULTS.md; scene/IDE/debugger/test/build/recovery checks remain pending. No gameplay or commits/pushes.

## Autonomous environment verification — 2026-10-28
ADOPTION-001 resolved locally and verified on reopen. Final two smoke tests and Windows x64 Mono Development+AllowDebugging build pass (0 errors/warnings); player startup, sky/ground rendering and normal close observed. Retaining postprocessing shader resources in adopted URP global settings removed startup stripping messages. VS solution generation/integration recognized; actual debugger attachment blocked by Computer Use app-approval timeout. No package upgrades, source-original changes, gameplay, commit/push or publishing. PHASE0_VERIFICATION.md provides final commands/evidence and remote recovery procedure.
