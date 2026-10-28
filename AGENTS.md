# Project Genesis development standards

## Scope and current gate
- Build Game 1: an original five-stage game (Cell, Creature, Tribal, Civilization, Space). Complete Game 1 before full Game 2 production.
- Game 2 may reuse proven foundations; do not implement speculative simulation, genetics, or machine learning systems for it now.
- Current milestone: Phase 0 Verified Complete (2026-10-28); Phase 1 awaits explicit user authorization. CELL_STAGE_MVP_PROPOSAL.md remains review-only. Do not implement gameplay before that approval.
- Source directive: `Documentation/MASTER_DEVELOPMENT_DIRECTIVE.md`. Follow the user's latest instructions where they differ, especially the Phase 0 gameplay gate.
- Approved engine: Unity 6.6 `6000.6.7f1` with C#, URP `17.6.0`, Input System `1.20.1`, Windows x64. Game/ contains the adopted source; original `C:/Users/alire/Project GENESIS` is preserved. User approved omitting Assistant, Sentis, Pipeline and Unity Version Control only in Game/, resolving ADOPTION-001, and verifying/publishing the Phase 0 source. No duplicate project, gameplay, or paid-service activation. Routine source commit/push authority follows the policy below; publishing game builds remains separately gated.

## Autonomy and Escalation Policy
- Complete routine Phase 0 work independently: small reversible fixes, environment configuration, non-destructive dependency cleanup within approved scope, error investigation, tests/builds, documentation, and preparing verified changes for review. Apply the smallest safe fix and retest; do not stop for each routine error.
- Preserve existing work and original source. Avoid unnecessary packages/upgrades and major architecture changes. Record results and uncertainties; group progress into meaningful milestones.
- Escalate significant deletion, destructive/irreversible actions or history rewrites, paid services, unapproved external data transmission/services, publishing/deployment, major architecture/scope changes, and gameplay before Phase 0 closure and explicit Phase 1 authorization.
- Standing user authorization (2026-10-28): commit and normally push verified, in-scope work in the current and future approved milestones, including at the end of productive sessions when safe. Before every push verify branch, origin, live remote HEAD and working-tree state; inspect staged files and relevant checks; exclude secrets, caches, builds, logs and temporary files. Preserve work and reconcile unexpected remote commits. Use descriptive, logically grouped commits; push main only when safe and consistent with protections. Never force-push or rewrite history. Report commit hashes and push result. Source publication is distinct from publishing game builds. Clean-checkout engine recovery and remaining acceptance checks must pass before Phase 0 closure; Phase 1 needs explicit approval.

## Working standards
- Apply `Documentation/COMMUNICATION_PROTOCOL.md` to every chat working in this repository. Official shared repository: https://github.com/alireza001455-cell/Project-GENESIS.
- At session start, identify the repository, branch, commit, and working-tree changes; read `Documentation/CURRENT_STATUS.md`, `Documentation/ROADMAP.md`, `Documentation/DECISIONS.md`, and relevant architecture documents. Report missing files or unavailable remote access instead of assuming synchronization.
- GitHub is the shared recorded source of truth; distinguish local uncommitted work from remote verified state. Reconcile remote changes before editing shared files and preserve concurrent work.
- Carry design decisions into DECISIONS.md, test evidence and progress into CURRENT_STATUS.md, and significant completed changes into CHANGELOG.md. Follow the protocol's session handoff fields.
- Notify only for meaningful milestones, critical failures, blocking issues, architectural conflicts, scope changes, review requests, or consequential research. Never claim live cross-chat synchronization or background monitoring without configured, verified support.
- Obtain explicit approval for significant deletions, shared-history rewrites, major architectural merges, paid costs, publishing builds, irreversible actions, and substantial scope changes. Commit/push only within user authorization; never automatically merge or deploy.
- Inspect existing files and repository state before changes. Preserve user work; never reset, delete, or overwrite unrelated changes.
- Make small, maintainable increments with a clear purpose. Explain unfamiliar concepts and editor actions step by step.
- Verify installed software, exact engine/package versions, and applicable official API documentation before relying on them.
- Record dependencies, purpose, licensing, costs, and exact versions. Prefer practical free tools; add tools only when needed.
- Never commit secrets, generated caches, or temporary builds. Keep original assets and track third-party licenses and attribution.
- Do not claim compilation, tests, runtime behavior, backups, or builds succeeded without observed evidence.

## Modular architecture
- Keep domain data and rules independent of rendering, UI, input, and engine objects where practical.
- Establish boundaries as systems become necessary: core state, stage progression, creatures, world, gameplay, persistence, presentation, audio, configuration, diagnostics, and editor tooling.
- Stage modules depend on shared foundations; shared foundations must not depend on individual stages. Avoid circular dependencies and direct coupling between stage internals.
- Separate creature definitions from visual models. Use stable identifiers and versioned save schemas; preserve species identity across stages.
- Prefer explicit dependencies, composition, small interfaces, and data-driven definitions where they solve demonstrated problems. Avoid speculative frameworks, global service collections, and excessive module fragmentation.
- Introduce engine assembly/module boundaries when justified. Keep editor-only code out of runtime builds.
- Record significant tradeoffs and dependency changes in `Documentation/DECISIONS.md` before dependent work proceeds.

## Testing and verification
- Define acceptance criteria and verification before implementing a meaningful change.
- Unit-test isolated domain rules and serialization; integration-test boundaries, persistence, and stage transitions when introduced.
- Use engine runtime tests and manual play checks for input, visuals, physics, animation, and usability as appropriate. Automated tests do not replace observed runtime behavior.
- Add focused regression coverage for substantive bugs when practical. Document reproduction steps and expected behavior.
- Profile before optimization. Agree on baseline hardware and measurable performance targets before treating them as release requirements.
- Record exact commands/editor steps, versions, results, and unverified items. Distinguish tests not run from failures.
- Phase 0 must verify editor launch, compilation, an empty test scene, selected input/rendering configuration, a standalone build that launches, and reproduction from a clean checkout.
- Run checks proportionate to the change; documentation-only changes need content verification, not gameplay tests.

## Technical debt
- Document every deliberate workaround in `Documentation/BACKLOG.md` with an ID, reason, risk, priority, affected files, proposed resolution, and milestone for review.
- Reference the debt ID in a nearby `TECH DEBT` code comment when useful. Do not leave unexplained TODOs.
- Review debt before milestone closure. Resolve high-risk debt before building dependent systems; record explicitly accepted lower-risk deferrals.
- Refactor stable code only for a concrete benefit and verify preserved behavior.

## Milestone workflow
- Plan at phase, monthly milestone, and weekly/session levels. Keep sessions near 60–120 minutes unless the user chooses otherwise.
- Every task has an ID, scope category (MVP/Core Release/Polish/Future Expansion), priority, dependencies, effort estimate, acceptance criteria, tests, and status.
- Task statuses: Backlog, Ready, In Progress, Blocked, In Review, Verified Complete.
- Evidence stages are distinct: Planned → Implemented → Tested → Verified → Integrated → Released.
- Close a feature only after compilation, required tests, observed behavior, relevant integration checks, no critical regressions, updated documentation, and safely preserved changes.
- Do not expand a milestone without assessing scope, architecture, cost, performance, and schedule implications.
- Require the modular creature assembly/rigging/locomotion feasibility gate before full Creature Stage production.
- Use descriptive commits and `codex/` feature branches when appropriate; do not alter branch history without authorization. Tag verified milestones.
- Use selective Git LFS rules for suitable large binary assets. If Unity is chosen, preserve `.meta` files, use visible metadata and text serialization, and keep text scenes/prefabs in ordinary Git where practical.
- Verify repository recovery from a clean clone; a remote alone is not a verified backup.

## Documentation and handoff
- `Documentation/CURRENT_STATUS.md` is the authoritative record of verified progress.
- Maintain setup, decisions, backlog, roadmap, test plan, bugs, architecture, vision/design, asset register, and release checklist as their content becomes necessary; avoid empty scaffolding.
- End sessions by recording completed work, files changed, actual verification, unverified items, bugs/debt/risks, current milestone, and next objective with prerequisites.
