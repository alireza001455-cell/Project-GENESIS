# P0-UNITY-ADOPTION-01 — local adoption results

Date: 2026-10-28. Status: adopted locally; stopped for review of an orphaned settings reference. Phase 0 remains open. No gameplay, commits, pushes, publishing, paid services, or monitoring.

## Authorization and preflight
- User continuation directive approves omitting exactly AI Assistant, Sentis, Pipeline and Unity Version Control from the adopted copy; original must remain unchanged.
- Branch main. Local HEAD and live remote HEAD/main were `38547f6321315124280a087fed5d1063e23db79f`. Origin is the official Project-GENESIS repository.
- Preserved all previous uncommitted documentation. Destination Game/ did not exist. Source C:/Users/alire/Project GENESIS existed with editor revision 6000.6.7f1 / b22767f04f04.
- Read required project records; reviewed manifest/lock and both template Readme C# sources; namespace/assembly references and source Asset script-GUID references revealed no dependency on the four omitted packages. No retained package in the source lock depended on those four package IDs. No custom asmdef or gameplay dependency was found in the source Assets inspection.

## Adoption and integrity
- Copied only Assets/, Packages/, ProjectSettings/: 69 files total. No UserSettings, Library, Temp, Logs, Obj or build output copied.
- SHA-256 snapshot of every source file in those three folders matched every copied file before editing manifest. Original 69-file snapshot still matched after launch/package resolution. This verifies preservation of the source folders; external processes/caches outside those folders were not comprehensively monitored.
- Removed four direct manifest entries only: com.unity.ai.assistant 2.21.0-pre.2; com.unity.ai.inference 2.6.1; com.unity.pipeline 0.9.1-exp.1; com.unity.collab-proxy 2.13.6. Retained 41 direct dependencies and all their pinned versions. Rider was retained.
- Unity regenerated packages-lock.json; no manual lockfile edits. Four additional orphan dependencies disappeared: com.unity.2d.sprite, com.unity.dt.app-ui, com.unity.mathematics, com.unity.nuget.newtonsoft-json. No added packages or retained-version changes in the resolved lock comparison.
- Original copied asset metadata is byte-identical. No missing asset/directory .meta files or duplicate asset GUIDs found. Largest non-generated project file: 41,005 bytes; no LFS rules justified.
- .gitignore now also excludes generated Game/*.csproj, *.sln, *.slnx, *.pidb, *.unityproj and .vsconfig. Ignore probes passed for Library, Temp, Logs, UserSettings, solutions/projects and Builds; all 69 required source/settings/package files remain visible to Git.

## Blocker: orphan App UI configuration reference
`Game/ProjectSettings/EditorBuildSettings.asset` still contains:

```yaml
com.unity.dt.app-ui: {fileID: 11400000, guid: 1b1c20d82303e4b5781c3ef50ac1449f, type: 2}
```

The referenced asset is Sentis' `Editor/Visualizer/App UI Settings.asset` in the original Library/PackageCache. It was available in the original dependency graph; Sentis and App UI are absent from the adopted resolved graph. This is a now-unresolved serialized settings reference, even though no C# dependency was found. It was discovered after package resolution; pre-copy GUID scanning covered Assets but did not catch this ProjectSettings config-object reference.

Per the directive's stop-on-broken-references condition, no repair was attempted and further scene/debugger/test/build verification was paused. Proposed minimal repair for review: remove only the `com.unity.dt.app-ui` config-object entry from the adopted EditorBuildSettings.asset, preserving the SampleScene entry and Input System config object. Do not edit the original, reinstall packages, or change the remaining dependency pins. Reimport and recheck settings/Console before continuing.

## Actual verification results
| Check | Observed result |
|---|---|
| Unity launch | Approved Unity.exe launched adopted Game/ (PID 27880). Initial-import splash observed. Final interactive workspace readiness not verified at stop. |
| Licensing | Editor log reports license successfully updated and entitlement details resolved. One earlier access-token refresh error was also logged; later entitlement checks succeeded. No sign-in, terms acceptance, or paid action performed. |
| Package resolution | Done registering packages; regenerated lock has no omitted IDs, retained versions unchanged. Package-resolution success does not clear orphan settings reference. |
| C# compilation | Log records script compilation time 77.847192s; Assembly-CSharp.dll and Assembly-CSharp-Editor.dll generated. No `error CS` or `warning CS` matches in inspected log. Final Console/UI sign-off not performed. |
| URP/input | Copied configuration and resolved URP 17.6.0/Input 1.20.1 verified statically; new Input System setting retained. Runtime rendering/input not tested. |
| Scene / Play Mode | SampleScene and references preserved; enter/exit Play Mode NOT RUN after blocker. |
| Visual Studio / debugger | Previously installed VS 2026 and Unity tools; adopted solution generation, recognition and debugger attachment NOT TESTED. |
| Tests | No Test/UnityTest/NUnit/test-assembly source candidates under adopted Assets; Test Framework 1.8.0 resolves. Test Runner discovery/execution NOT RUN; no passing tests claimed. |
| Windows x64 Mono | Support installed and source Hub target was Windows64; local development build and executable launch NOT RUN after blocker. |
| Recovery | Remote clean-checkout engine build PENDING separate authorization to commit/push adoption, then clone/import/build/run. Original external source is not recovery evidence. |
| Quality | Original-source comparison, manifest pins, lock diff, metadata, size and bounded secret-pattern scan passed; no secret-pattern matches. git diff --check passed. |

## Reproduction / evidence
- Live repository check: `git ls-remote origin HEAD refs/heads/main`; working changes: `git status --short --untracked-files=all` and `git diff --check`.
- Python stdlib performed snapshot, copytree, manifest-only omission, manifest/lock comparison, package script-GUID inspection and final SHA-256 comparison. No external dependency installed for these operations.
- Editor invocation: `Unity.exe -projectPath "<canonical-root>/Game" -logFile "<canonical-root>/TestResults/UnityAdoption/Editor.log"`.
- Local ignored evidence: TestResults/UnityAdoption/source-hashes-before.json, source-hashes-after.json, source-preservation-result.json, package-diff.json and Editor.log. Raw logs may contain account/machine data; do not commit raw evidence without review.
- Computer Use attempts observed splash/import. Later attempts reported user activity and were not forced; this does not establish scene/debugger success. The editor was not forcibly terminated; initial import may continue. No mutation commands were issued after identifying the blocker.

## Pending recovery procedure (not executed)
After the settings repair and all local checks pass, obtain separate commit/push authorization. Include Game/Assets with metadata, Packages manifest/lock, ProjectSettings, ignore rules and documentation. Clone the published revision into a new directory, open Game/ with pinned 6000.6.7f1, restore packages without the original Library, verify no compilation errors, run scene/tests, build Windows x64 Mono Development, launch/close locally and record exact commit/results. Keep builds/logs/caches ignored.

## Review scope / next action
Proposed future commit: the 69 adopted project files, ignore updates, and existing/new documentation. No new gameplay or editor helper scripts were added. Current modifications remain uncommitted and unstaged. First review the single orphan settings-entry repair, then finish editor, scene, IDE/debugger, tests and local build/run verification. Native IL2CPP and user hardware/experience assessment remain pending; no major architectural debt introduced.

## 2026-10-28 autonomous verification update
ADOPTION-001 fixed: removed only orphaned App UI entry; scene/input objects preserved. Phase 0 now permits routine reversible fixes without per-step approval. Project reopened, SampleScene entered/exited Play Mode and rendered expected sky/ground. Console after Play Mode showed zero warnings/errors. Unity recognized Microsoft.Unity.VisualStudio.Editor.VisualStudioEditor and generated Game.slnx plus runtime/editor/test csproj files. Two EditMode smoke tests pass on rerun; initial cleanup failure is documented. Windows x64 Mono Development+AllowDebugging build succeeded with zero warnings/errors after compilation. Standalone startup/rendering and normal UI shutdown observed; postprocess stripping warnings prompted a minimal adopted-only URP setting fix and rebuild. See PHASE0_VERIFICATION.md for final evidence and unresolved boundaries.

Visual Studio UI inspection/attachment was blocked by Computer Use app-approval timeout; generation/recognition is verified but actual debugger attachment is not. Remote clean-checkout engine recovery remains pending separate commit/push authorization. No gameplay or publication. Original source hash comparison remains required at final check.

## Autonomous verification completion — 2026-10-28
Local environment results supersede the earlier paused-check statuses: ADOPTION-001 resolved, SampleScene Play Mode passed, 2 final smoke tests passed, final Windows Mono development build 0 errors/warnings and standalone startup/render/normal shutdown passed. Template postprocess stripping diagnostic fixed in adopted global settings; minimal non-gameplay editor/test tooling added. VS recognizes integration and solution generation; attach remains unverified due app-approval timeout. Original 69 source-file hashes and metadata preserved. Remote engine recovery remains pending separate commit/push authorization. Exact commands, paths and limitations: PHASE0_VERIFICATION.md.
