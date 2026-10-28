# Phase 0 local verification — 2026-10-28

## Scope and repository
P0-UNITY-ADOPTION-01, continued under the user's Autonomous Development Directive. Local Phase 0 only; no gameplay, publishing, monitoring, commits, pushes, or external service activation. Original external source preserved.

Branch main; local and live remote HEAD/main at preflight: `38547f6321315124280a087fed5d1063e23db79f`. Remote: https://github.com/alireza001455-cell/Project-GENESIS. Existing uncommitted work preserved. All new source/metadata/settings and documentation are ready for review, not staged or published.

## Changes implemented
- ADOPTION-001: removed only `com.unity.dt.app-ui` from adopted EditorBuildSettings.asset. Scene path/GUID and Input System config-object GUID are unchanged. Reopened corrected project successfully; no restoration of removed packages.
- Added persistent Autonomy and Escalation Policy to AGENTS.md and COMMUNICATION_PROTOCOL.md, explicitly retaining consequential-action and commit/push boundaries.
- Added editor-only `Assets/Editor/GenesisEnvironment.cs`: open preserved scene; select installed VS 2026/generate solution; repeatable Windows x64 Mono development build. No runtime gameplay logic. It refuses wrong editor/Play Mode/active compilation, uses the existing SampleScene, and writes only ignored build/evidence output.
- Added Editor-only environment test assembly with two smoke tests: active URP asset/renderer references, and sample scene loading/camera/no missing scripts. Test cleanup handles an initially empty batch editor session.
- Disabled unused-postprocessing variant/resource stripping in adopted UniversalRenderPipelineGlobalSettings.asset. The template build rendered but logged unsupported/stripped depth-of-field and Panini shaders. Retaining those resources removed those startup messages in the rebuilt player. Other stripping settings and package versions are unchanged. This adds about 2.95 MB to the reported build; optimize only after profiling/feature requirements warrant it.
- Standalone scripting backend explicitly Mono; existing Android settings preserved. Unity-generated solution/project files, builds/caches/logs/test output remain ignored.

## Verified software/configuration
Unity 6000.6.7f1 / b22767f04f04; URP 17.6.0; Input System 1.20.1; Visual Studio Editor package 2.0.28; Test Framework 1.8.0; Visual Studio Community 2026 18.11.2 (installation 18.11.12324.101); Git 2.53.0.windows.3; Git LFS 3.7.1. No package upgrades were requested; the four approved omissions and orphan removal remain as documented in UNITY_ADOPTION_RESULTS.md.

Hardware query now verified: ASUS Zenbook 14 UX3405MA, Intel Core Ultra 7 155H, 31.4 GiB RAM, Intel Arc Graphics driver 32.0.101.8860, about 641 GB free on C: at inspection. Earlier CIM access-denied observations are historical. User experience/time/budget remain unanswered; no gameplay performance conclusion is inferred from this sample.

## Results and limitations
| Check | Actual evidence/result |
|---|---|
| Licensing/package resolution | Successful license update/entitlement resolution and package registration in editor/batch logs. No login, extra terms, credit purchase or service activation performed. |
| C# compilation | Editor/template/tool/test assemblies generated; no C# compiler errors or warnings in reviewed final logs. |
| Console | After opening SampleScene and Play Mode cycle: screenshot shows 0 warnings and 0 errors, before informational tooling logs/build activity. |
| Scene/Play Mode | SampleScene hierarchy has Main Camera, Directional Light and Global Volume. Entered Play Mode, observed sky/ground, exited successfully. Scene source was not edited. |
| URP/input | PC_RPAsset included in build; effective URP renderer test passed. Preserved Input System-only config and keyboard/mouse bindings verified statically. No gameplay input responsiveness claimed. |
| IDE recognition/generation | Unity logs Microsoft.Unity.VisualStudio.Editor.VisualStudioEditor. Game.slnx references runtime/editor/test csproj; generated files inspected. External editor selected to installed VS 2026. |
| VS GUI/debugger | VS solution launch requested. Computer Use inspection returned `Computer Use app approval timed out` before attach controls could be reached. No debugger attachment or breakpoint hit verified. App access/user-assisted attachment is still needed. No permission barrier bypass attempted. |
| Tests | Initial run: 1 passed/1 failed due solely to test cleanup trying to restore no active scene in batch mode. Fixed cleanup; rerun: 2 passed/0 failed, exit 0. Final-configuration run recorded in the closing evidence entry below. |
| Initial GUI build | Succeeded with 1 warning: uncompiled editor changes. Rebuilt after compilation in batch mode; warning absent. |
| Final Windows build | Succeeded, 0 errors/0 warnings, process exit 0. Windows x64 (`StandaloneWindows64`), Mono2x, requested Development+AllowDebugging, SampleScene only. 174,974,907 bytes reported; 36.48 seconds. Output: ignored Builds/Windows/Genesis.exe. PE machine 0x8664 and MonoBleedingEdge runtime present. |
| Standalone run/shutdown | Rebuilt player opened and rendered expected sky/ground; screenshot observed Development Build. Closed by Alt+F4; process exited and log shows physics/Input System shutdown. No postprocess unsupported/stripped messages in final player log. |
| Remaining player diagnostic | `d3d12: failed to query info queue interface (0x80004002)` remains. Direct3D 12 feature level 12.2/Intel Arc initialized and rendering succeeded. No related crash observed; no graphics-driver/system changes made. |
| Source preservation | 69-file SHA-256 comparison of original Assets/Packages/ProjectSettings passed after adoption; final comparison recorded below. Original cache/user-session state outside those source directories was not comprehensively audited. |
| Recovery | Documentation-only recovery was previously verified. Adopted engine project's remote clean-clone import/test/build/run is NOT verified; commit/push authorization is required first. |

Build report's raw enum string lists overlapping/internal flag names, including `Il2CPP`; it is not the backend selection. Requested options are recorded separately. PlayerSettings backend is Mono2x, Standalone serialized value is 0, and built runtime is MonoBleedingEdge. No IL2CPP build is claimed; native C++ toolchain remains unverified.

## Reproduce local checks
Use the installed editor at `C:/Program Files/Unity/Hub/Editor/6000.6.7f1/Editor/Unity.exe`. Close another editor using the same Game/ before batch commands. Run from the canonical repository, substituting its absolute path for `<root>`.

```text
Unity.exe -projectPath "<root>/Game" -logFile "<root>/TestResults/UnityAdoption/Editor-verified.log"
Unity.exe -batchmode -nographics -projectPath "<root>/Game" -runTests -testPlatform EditMode -assemblyNames Genesis.Environment.EditModeTests -testResults "<root>/TestResults/UnityAdoption/EditMode-final.xml" -logFile "<root>/TestResults/UnityAdoption/Tests-final.log"
Unity.exe -batchmode -projectPath "<root>/Game" -buildTarget Win64 -executeMethod GenesisEnvironment.BuildWindows -quit -logFile "<root>/TestResults/UnityAdoption/Build-postprocess-fix.log"
Genesis.exe -screen-fullscreen 0 -screen-width 960 -screen-height 540 -logFile "<root>/TestResults/UnityAdoption/Player-final.log"
```

Use Genesis > Phase 0 menus for interactive scene/IDE/build actions. Runtime player stays open until normal window close; do not equate successful process launch with rendering/shutdown verification. Batch tests do not use `-quit`; Test Framework owns test completion/exit. PowerShell should use Start-Process -Wait -PassThru to capture GUI executable exit codes reliably.

Local ignored evidence also includes source hashes before/after, package diff, build-summary.txt and earlier failed-run XML/logs. Raw logs may contain machine/account data; keep them out of Git. Portable findings belong in this record. Official API docs and installed IDE/Test Framework package source were checked before invoking commands/APIs; no external dependencies added.

## Proposed commits and recovery boundary
Suggested logical groups for review (not executed):
1. Adopt pinned Unity source/settings/manifests and metadata, four approved package omissions, orphan fix, Mono/URP fixes, ignore rules and adoption decisions.
2. Add editor-only environment tooling/tests with metadata, autonomy policy and accurate verification/setup/status records.

No raw logs, caches, generated projects/solutions or builds belong in either commit. After explicit commit/push authorization, clone the published revision to a separate directory, open Game/ in the pinned editor without original Library, restore retained packages, rerun smoke tests and scene, build and run Windows x64 Mono development player, and record commit/results. Resolve VS debugger access/attach and remaining assessment items before Phase 0 sign-off. Do not declare Phase 0 complete or begin gameplay based only on these local results.

## Closing evidence
Final smoke-test and preservation checks are recorded in the completion entry after execution.

Final configuration smoke test completed: 2 tests passed, 0 failed, process exit 0 (EditMode-final.xml). Final source preservation: all 69 original Assets/Packages/ProjectSettings files still match pre-adoption SHA-256 snapshot. All copied original .meta bytes unchanged; no missing metadata or duplicate GUIDs. Git exposes 78 Game/ source/settings/metadata files, no generated caches/builds/logs/test output. Bounded candidate secret-pattern scan found no matches; largest candidate 41,005 bytes. Final player log contains zero unsupported/stripped-postprocess messages. Normal shutdown observed and final player process exited. No commits/pushes or Phase 0 completion claimed.

Technical debt: TD-P0-001 tracks the roughly 2.95 MB cost of retaining postprocessing resources; review before release/performance work. No major architectural debt introduced. Metadata, original-source preservation and ignore/secret checks passed; no destructive changes performed.

Additional settings-diff review: Unity import/build reserialized PC_RPAsset (shader-prefilter fields) and GraphicsSettings (new engine-default fields); these are retained engine-generated source-settings updates, with asset GUIDs unchanged. Standalone backend is the only ProjectSettings.asset change (0 = Mono). Unity also automatically changed UnityConnectSettings.m_Enabled from original 0 to 1; this was detected and restored to original 0 with the editor closed, preserving the original disabled cloud-services setting. No AI/Version Control/paid feature was invoked. Licensing/package restore traffic was part of the authorized setup; no claim is made that all engine network traffic was audited. Recheck this automatic flag behavior on future editor/recovery runs; no fresh editor launch followed this restoration. Local build/run results above precede this final restoration of editor service configuration.

## Git publication authorization — 2026-10-28
Source/tooling adoption committed locally as 9e10d8d391ac0acfd25d6bb32fb6739c37174bd1 under new standing Git authorization. This supersedes earlier permission-pending statements; no force-push/history rewrite or game-build publication is authorized. The staged audit passed. New Unity file attributes keep LF text and permit serializer-generated empty YAML values without rewriting source assets. Remote verification and fresh-checkout engine results will be appended after execution.
