# Bugs and setup limitations

No gameplay exists; no gameplay bugs verified.

- SETUP-001: Windows CIM hardware queries returned Access denied. Workaround: obtain hardware information from user. Not evidence of a game defect.
- SETUP-002: Remote connection resolved: origin points to the official repository. Initial publication and independent ChatGPT retrieval are tracked in COMMUNICATION_VERIFICATION.md.

## ADOPTION-001 — Orphan removed-package settings reference (2026-10-28)
After approved omission of Sentis and automatic removal of its App UI dependency, Game/ProjectSettings/EditorBuildSettings.asset retains com.unity.dt.app-ui config GUID 1b1c20d82303e4b5781c3ef50ac1449f. Original target asset was Sentis Editor/Visualizer/App UI Settings.asset. Reproduced by static GUID resolution; no C# compiler error established from this reference. Task stopped before repairs per user instruction. Proposed minimal fix for review: remove only that adopted config entry, retain SampleScene and Input System entries; reimport and verify Console/scene/build. Original source must remain unchanged. See UNITY_ADOPTION_RESULTS.md.

## ADOPTION-001 resolution — 2026-10-28
User's autonomy directive explicitly authorized the repair. Removed only com.unity.dt.app-ui from adopted EditorBuildSettings.asset; original source unchanged. Reopened adopted project and verified scene/input entries retained, C# compilation, SampleScene Play Mode and clean Console. Status: resolved locally; pending publication/recovery verification. No package restoration or broader repair needed.

## URP-001 — Template postprocessing stripping diagnostics (resolved locally, 2026-10-28)
Final-template player rendered but reported unsupported/stripped Gaussian/Bokeh depth-of-field and Panini resources. Kept unused-postprocessing resources in adopted URP global settings, rebuilt and reran: zero such messages, correct rendering and normal shutdown. Final build 0 errors/warnings. Size tradeoff tracked as TD-P0-001. Remaining D3D12 debug-info interface diagnostic has no observed startup/rendering failure; no graphics-driver/Windows changes made.

## Recovery follow-up — 2026-10-28
ADOPTION-001 remains resolved in published source. Fresh-clone recovery and VS 2026 attach/breakpoint verified; no new blocking defects found. UnityConnect.m_Enabled again auto-changed 0→1 during clean import; restored committed 0 after engine closure. Recheck on future runs; no paid feature invoked. See PHASE0_RECOVERY_VERIFICATION.md. Nonfatal D3D12 info-queue diagnostic and TD-P0-001 remain documented limitations.
