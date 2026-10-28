# Decisions

## D-001 — Shared coordination protocol (2026-10-27)
Accepted by user instruction: apply communication protocol v1.0 across Project Genesis chats. GitHub repository: https://github.com/alireza001455-cell/Project-GENESIS. Local changes remain distinguishable from verified remote state. Existing development standards remain in force.

## Pending decisions
- Hardware, experience, schedule, and budget assessment.
- Rendering/input/backend proposal and adoption of the existing external Unity project into Game/.
- Automation cadence and event integrations, after a basic documentation exchange is verified. No scheduled monitoring configured yet.

## D-003 — Guarded adoption approved; package gate pending (2026-10-28)
P0-UNITY-ADOPTION-01 explicitly approves Unity 6000.6.7f1/C#/URP/Windows x64, copying only source Assets (including metadata), Packages and ProjectSettings into canonical Game/, preserving the external original. No gameplay, destructive cleanup, service activation, or commit/push is authorized. This supersedes D-002's earlier proposed-URP/adoption wording.

Preflight found matching local/remote main at 38547f6, preserved prior uncommitted audit work, and confirmed Game/ absent. Package review identified preview AI Assistant, experimental Pipeline and optional service dependencies. The user's explicit package-review stop condition applies before copying. See UNITY_ADOPTION_PACKAGE_REVIEW.md for all direct dependencies, licenses/compatibility limits, recommendation and requested decision. No package or source changes executed.

## D-002 — Approved Unity engine, platform, and root (2026-10-28)
User explicitly approved Unity 6.6 `6000.6.7f1` with C#, initial Windows PC target, canonical working root `C:/Users/alire/Documents/ChatGPT/Project GENESIS (codex)`, and the existing Project-GENESIS remote. This supersedes the earlier provisional engine status. Do not substitute an LTS release or another patch without a decision.

URP is proposed rather than newly approved here. Installed editor file version and existing project's ProjectVersion.txt both report `6000.6.7f1`, changeset `b22767f04f04`. Visual Studio Community 2026 18.11.2 and Unity workload/component are installed; runtime interoperability remains untested.

Hub inventory and disk inspection found an existing Unity project named Project GENESIS at `C:/Users/alire/Project GENESIS`. It is not the Git repository and must not be overwritten or assumed disposable. Proposed next step: review source adoption under canonical Game/, preserving source/meta files and original folder; do not create a duplicate. No project files, commits, or pushes are authorized by this audit. Detailed evidence and proposal: UNITY_ENVIRONMENT_AUDIT.md.

## D-004 — Four package omissions approved and local adoption performed (2026-10-28)
User continuation directive explicitly approves omitting com.unity.ai.assistant, com.unity.ai.inference, com.unity.pipeline and com.unity.collab-proxy from the adopted copy only. URP 17.6.0/Input 1.20.1/Unity 6000.6.7f1 and other direct pins retained. This supersedes D-003's pending package decision. Copied 69 Assets/Packages/ProjectSettings files into Game/ and verified original-source hashes unchanged. Unity regenerated the lockfile without those four and four orphan transitive dependencies. No lock entries fabricated.

An orphan App UI config-object entry in adopted EditorBuildSettings.asset resolves only in the removed Sentis package. Verification paused under the user's explicit broken-reference stop condition; no repair attempted. Proposed repair: remove that single adopted config entry while retaining scene/input entries. No gameplay/commits/pushes/services authorized. See UNITY_ADOPTION_RESULTS.md for actual checks and pending work.

## D-005 — Phase 0 autonomy and routine environment fixes (2026-10-28)
User's Autonomous Development Directive authorizes small reversible fixes/configuration, error investigation, tests/local builds and documentation within Phase 0 without repeated approval. Consequential changes, paid services, unapproved external services/data transmission, publishing, major architecture/scope expansion, gameplay before Phase 0/Phase 1 approval, and commit/push remain authorization boundaries. AGENTS.md and COMMUNICATION_PROTOCOL.md now contain the durable Autonomy and Escalation Policy.

ADOPTION-001 is resolved by removing only the obsolete com.unity.dt.app-ui config-object entry from the adopted EditorBuildSettings.asset; SampleScene and Input System entries remain unchanged. Project reopened successfully. Added editor-only build/IDE/scene helper and two environment EditMode smoke tests, with no runtime/gameplay script additions. First test cleanup failed when batch mode had no prior active scene; cleanup was corrected and both tests passed. URP unused-postprocessing stripping was disabled in the adopted global settings after standalone startup reported stripped postprocess shaders; rebuilding/retesting determines final outcome. Full evidence: PHASE0_VERIFICATION.md.

## D-006 — Standing Git publication authorization (2026-10-28)
User authorizes publishing the reviewed Phase 0 Unity source/configuration/fixes/tests/tooling/documentation, and routine verified in-scope commits/pushes during future approved milestones. Verify branch/remote/live HEAD/worktree before every push, inspect staged files/checks and exclude secrets/generated output; preserve work and reconcile unexpected commits. Use logical descriptive commits and normal safe pushes to main consistent with protections; never force-push/rewrite history. Report hashes and success. Consequential deletions/architecture/scope changes, paid services, publishing game builds and gameplay still require approval. AGENTS.md and COMMUNICATION_PROTOCOL.md are updated. Earlier no-commit/no-push restrictions describe historical sessions and are superseded for routine in-scope source publication only.

Source adoption/tooling commit: 9e10d8d391ac0acfd25d6bb32fb6739c37174bd1. Staged-content secret/generated-path audit passed. Unity's serializer whitespace is preserved via file-specific attributes; handwritten source/doc checks remain enabled. Remote publication and clean-checkout results will be recorded after execution.

## D-007 — Final Phase 0 acceptance and sign-off (2026-10-28)
User confirmed the remaining developer assessment (SOFTWARE_SETUP.md) and authorized closure if no required checks remained. Reviewed master completion criteria and recorded local/recovery/debugger results: Phase 0 Verified Complete. Evidence: PHASE0_RECOVERY_VERIFICATION.md; tested Game subtree b1d3f16c88feb8130a5f1c7a34659a091f7ba10c, technical records published at bf075b82cbc64acaf2de9b614893ee3d64c1eecf.

Accept D3D12 info-queue diagnostic and UnityConnect import auto-toggle as tracked nonblocking limitations; defer TD-P0-001 to its pre-release/performance review. Baseline remains Windows x64 Mono. No new tooling or gameplay is required for closure. Phase 1 needs explicit user approval; Cell Stage proposal is review-only. Manual GitHub communication is verified; automatic synchronization remains inactive.
