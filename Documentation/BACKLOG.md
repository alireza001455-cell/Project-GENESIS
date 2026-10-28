# Backlog

| ID | Task | Priority | Dependencies | Acceptance / verification | Status | Effort |
|---|---|---|---|---|---|---|
| P0-01 | Complete developer/hardware/platform assessment | High | User answers | Assessment recorded without assumptions | Blocked | 30–60 min |
| P0-02 | Select engine and toolchain | High | User approval | Unity 6000.6.7f1/C#/URP/Windows x64 approved; exact installed versions recorded | Verified Complete | 60 min |
| P0-03 | Verify manual GitHub repository communication | High | Repository access | Published test at 33d20fa; user confirms ChatGPT independently retrieved matching ID/marker; see COMMUNICATION_VERIFICATION.md | Verified Complete | One session |
| P0-04 | Verify empty project and recovery build | High | P0-02; source publication | a430eaa fresh-clone import, 2 tests, Mono build/run/close and canonical VS breakpoint verified; see recovery report | Verified Complete | Completed 2026-10-28 |

Scope: all tasks above belong to Phase 0 foundation. No deliberate implementation debt recorded. For future debt record ID, reason, risk, priority, files, resolution, and review milestone.


Current evidence: PHASE0_VERIFICATION.md. P0-01 hardware is now verified; programming experience, availability and budget still need user input. ADOPTION-001 resolved locally. VS debugger verification requires app access/user-assisted check. Standing Git authorization now applies; original source preserved and all gameplay gated.

## TD-P0-001 — Retain unused postprocessing resources during environment verification
Reason: template player logged stripped Gaussian/Bokeh depth-of-field and Panini shaders on startup. Disabling only unused-postprocessing resource/variant stripping removed these messages. Risk: approximately 2.95 MB added to the sample build, plus potentially longer shader compilation. Priority: Low; affected file Game/Assets/Settings/UniversalRenderPipelineGlobalSettings.asset. Resolution: review stripping against actual postprocessing requirements and pinned-engine fixes before release/performance milestone, with player startup regression check. No blocker for continued Phase 0; do not re-enable solely for speculative optimization.


Latest milestone: P0-04 technical verification complete, standing source publication authorized. P0-01 still awaits user experience/availability/session preference/budget; hardware is verified. Phase 0 sign-off and explicit Phase 1 authorization remain required. CELL_STAGE_MVP_PROPOSAL.md is planning only.
