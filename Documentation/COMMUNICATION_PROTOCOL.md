# PROJECT GENESIS — CROSS-PLATFORM COMMUNICATION & AUTOMATION PROTOCOL

**Version 1.0**

## 1. Mission

Establish a reliable, persistent coordination system between:

- **GitHub:** Central repository and authoritative source of project files.
- **Codex:** Primary software development, implementation, debugging, testing, and code maintenance.
- **ChatGPT Project:** Game design, strategic planning, architectural decisions, technical education, and project oversight.
- **ChatGPT Work:** Research, documentation, project audits, and automated reviews where supported.

The purpose is to ensure that all environments operate from the same verified project information without requiring me to manually repeat context or copy development updates between conversations.

This protocol supplements the existing Project Genesis Master Development Directive. It does not replace that directive.

## 2. Single Source of Truth

The official Project Genesis GitHub repository is:

**Repository URL:** [https://github.com/alireza001455-cell/Project-GENESIS](https://github.com/alireza001455-cell/Project-GENESIS)

Use this repository as the authoritative source for the actual codebase, current development progress, technical architecture, decisions, bugs, and milestones.

Do not assume that conversational memory, previous responses, or cached repository information reflects the latest project state.

If repository access is unavailable, explicitly report the limitation. Never claim that synchronization or verification occurred when it did not.

## 3. Shared Documentation

Maintain these files in the repository:

- `AGENTS.md` — Persistent instructions for Codex and coding agents.
- `Documentation/PROJECT_VISION.md` — Long-term vision for Game 1 and Game 2.
- `Documentation/ROADMAP.md` — Phases, milestones, dependencies, and priorities.
- `Documentation/CURRENT_STATUS.md` — Verified current development state.
- `Documentation/DECISIONS.md` — Architectural and design decisions.
- `Documentation/BACKLOG.md` — Upcoming tasks and technical debt.
- `Documentation/BUG_TRACKER.md` — Known issues and reproduction steps.
- `Documentation/TEST_PLAN.md` — Testing strategy and results.
- `Documentation/CHANGELOG.md` — Significant completed changes.
- `Documentation/COMMUNICATION_PROTOCOL.md` — This coordination protocol.

Before creating files, inspect the repository and preserve existing documentation. Reconcile differences rather than overwriting established work.

## 4. Automatic Context Loading

At the beginning of every development or planning session:

1. Identify the repository and current branch or commit, where accessible.
2. Read `CURRENT_STATUS.md`.
3. Read `ROADMAP.md`.
4. Read `DECISIONS.md` and relevant architectural documentation.
5. Identify the current milestone, active tasks, blockers, and outstanding tests.
6. Check for relevant changes since the previous verified state, where supported.
7. Continue from the latest verified project state.

**Codex:** Implement these instructions in `AGENTS.md` so they are automatically applied when Codex operates in the repository.

**ChatGPT:** Follow this procedure whenever repository tools are available and the conversation concerns current project state. Do not claim to have checked the repository unless a retrieval actually occurred.

**Work:** Follow the same procedure for research, audits, and event-triggered reviews when configured.

## 5. Change Detection and Notifications

Establish automated change detection using supported platform features.

Preferred mechanisms:

- GitHub Actions for repository events and validation.
- Codex Automations for scheduled development checks, where available.
- ChatGPT Work event-triggered tasks for supported GitHub events, where available.

When a meaningful change occurs, the relevant automation should:

1. Identify the changed files, commit, or pull request.
2. Determine which milestone or subsystem is affected.
3. Summarize what changed.
4. Identify possible integration risks.
5. Identify missing or failed tests.
6. Report whether documentation needs updating.
7. Provide a concise action summary.

Do not create redundant alerts for every minor change.

**Important:** A GitHub event does not automatically update an existing ChatGPT Project conversation. Do not claim live synchronization unless an actual supported integration has been configured and verified.

## 6. Responsibilities

### Codex — Development Authority

Codex is responsible for:

- Implementing approved features.
- Maintaining code quality and modular architecture.
- Running available automated tests.
- Fixing bugs.
- Updating relevant technical documentation.
- Recording verified development progress.
- Creating commits and pull requests when authorized.

Codex must not independently make major scope changes or override approved architectural decisions.

### ChatGPT Project — Design and Planning Authority

ChatGPT is responsible for:

- Clarifying gameplay goals.
- Evaluating architectural choices.
- Designing development milestones.
- Teaching relevant technical concepts.
- Reviewing implementation plans.
- Identifying project risks.
- Recommending priorities.

When a decision affects implementation, document it in a form that can be transferred to the repository.

### ChatGPT Work — Research and Review

Work may:

- Research technical alternatives.
- Compare engines, packages, and development methods.
- Review supported GitHub pull request events.
- Audit documentation and milestone progress.
- Produce structured reports.

Work must not independently approve or merge major changes.

### GitHub — Shared Record

GitHub stores the code, documentation, commit history, pull requests, and project history.

GitHub is the source of truth for recorded project state, not an autonomous decision-maker.

## 7. Development Session Protocol

For every Codex development session:

**Before implementation:**

- Read repository instructions and current status.
- Check relevant decisions and dependencies.
- Define the task and acceptance criteria.
- Identify files likely to be modified.

**During implementation:**

- Make focused, reversible changes.
- Preserve modularity.
- Run appropriate tests.
- Record technical debt.
- Avoid unrelated changes.

**After implementation:**

- Report files changed.
- Report tests run and results.
- Distinguish verified functionality from untested code.
- Update `CURRENT_STATUS.md` and other affected documentation.
- Record remaining issues and next steps.
- Commit and push changes only when authorized.

## 8. Decision Synchronization

When ChatGPT recommends an important technical or gameplay decision:

1. State the proposed decision.
2. Explain the reasoning and alternatives.
3. Identify affected systems.
4. Record the decision in `DECISIONS.md` through an authorized repository-writing workflow.
5. Notify the implementation workflow through a task or pull request when supported.

A decision discussed only in ChatGPT is not considered synchronized until it has been written to the repository and verified.

Codex must flag conflicts between a requested implementation and existing approved decisions.

## 9. Conflict Prevention

Prevent conflicting edits through:

- Git branches and pull requests.
- Clear ownership of active tasks.
- Review before merging.
- Small, focused commits.
- Avoiding simultaneous edits to the same files.
- Checking the latest repository state before modifying shared documents.

If two environments propose conflicting changes, do not silently choose one. Present the conflict and request a decision when necessary.

## 10. Verification Standards

Use the following status labels accurately:

- **Proposed:** Discussed but not implemented.
- **Implemented:** Code or files created, not necessarily tested.
- **Tested:** Specified tests completed successfully.
- **Integrated:** Verified with relevant existing systems.
- **Blocked:** Cannot proceed until a dependency or problem is resolved.
- **Released:** Included in an identified build or release.

Never equate code generation with successful compilation, testing, or gameplay validation.

## 11. Automated Quality Checks

Where appropriate, configure GitHub Actions to perform:

- Repository structure validation.
- Documentation consistency checks.
- C# formatting or static analysis.
- Automated tests supported by the installed Unity environment.
- Build validation when a suitable runner and license configuration exist.

Avoid expensive or unnecessary automated jobs.

Do not expose API keys, credentials, tokens, or Unity license secrets in committed files or logs.

## 12. Notification Policy

Only notify me about meaningful events, such as:

- Completed milestones.
- Failed builds or critical tests.
- Significant architectural conflicts.
- Blocking bugs.
- Major changes to project scope.
- Pull requests requiring approval.
- Important research findings affecting implementation.

Routine updates should be summarized in documentation rather than producing excessive notifications.

## 13. Safety and Approval

Require my explicit approval before:

- Deleting significant project files.
- Force-pushing or rewriting shared Git history.
- Merging major architectural changes.
- Publishing a game build.
- Incurring paid service costs.
- Making irreversible changes.
- Introducing substantial scope changes.

Do not automatically merge, deploy, purchase services, or publish releases without authorization.

## 14. Session Handoff

At the end of meaningful development work, record:

**Project Genesis — Session Handoff**

- Current milestone:
- Branch and latest commit:
- Work completed:
- Files changed:
- Tests performed:
- Known issues:
- Decisions made:
- Documentation updated:
- Recommended next task:
- Outstanding approvals:

Save the durable information to the repository rather than relying exclusively on chat history.

## 15. Initial Setup Instructions

Before implementing this protocol:

1. Inspect the existing repository and its documentation.
2. Identify which platform integrations are actually available.
3. Check whether GitHub access is configured.
4. Create or update `AGENTS.md` and `Documentation/COMMUNICATION_PROTOCOL.md`.
5. Establish the shared status and decision records.
6. Recommend appropriate GitHub Actions and automation triggers.
7. Configure only automations supported by the current environment and authorized by me.
8. Test the communication workflow using a harmless documentation-only change.
9. Verify that the change can be committed, pushed, and subsequently retrieved by the other environment.
10. Report which parts of the system are fully operational, partially operational, or require manual setup.

Do not claim automatic cross-platform synchronization until it has been demonstrated.

## 16. Permanent Operating Directive

From this point forward, treat Project Genesis as one coordinated development project spanning multiple tools.

Use GitHub to preserve verified state, Codex to implement software, ChatGPT to guide design and architecture, and Work for supported research and automated reviews.

Minimize repeated instructions, preserve long-term continuity, avoid contradictory development decisions, and maintain transparent reporting.

**Begin by auditing the current repository and proposing the smallest reliable synchronization setup. Do not implement complicated automation before the basic workflow has been verified.**

## 17. Autonomy and Escalation Policy — user-approved 2026-10-28

This supplement preserves the preceding coordination protocol. Codex independently handles routine work within the approved milestone: small reversible technical fixes, environment configuration, non-destructive approved dependency cleanup, tests and local builds, error investigation, documentation, and preparing verified changes for review. Investigate errors, apply the smallest safe fix and retest without requesting permission for every minor step. Preserve unrelated work; avoid speculative upgrades or dependencies. Group progress into meaningful milestones and accurately distinguish implementation from verification.

User authorization remains required for significant destructive or irreversible actions, paid services, publishing game builds/deployment, major architectural or scope changes, unapproved external services or data transmission, and gameplay before Phase 0 closure/Phase 1 approval. Automatic synchronization/monitoring remains inactive unless separately configured and verified. Original external Unity source remains unchanged. Phase 0 cannot close before clean-checkout engine recovery and required acceptance checks are verified.

### Standing Git authorization — user-approved 2026-10-28
Codex is authorized to commit and push the reviewed Phase 0 source/configuration/tooling/tests/documentation and future verified, in-scope work during approved milestones. At meaningful milestones and the end of productive sessions, update CURRENT_STATUS.md and relevant records, inspect staged files, run appropriate checks, and commit/push when safe. Before each push verify branch, remote URL, live remote HEAD and working-tree state; preserve and reconcile unexpected work. Exclude secrets/credentials, caches, generated builds, logs and temporary files. Use descriptive, logically grouped commits and normal pushes to main when safe under repository protections. Never force-push or rewrite history. Report resulting commit hashes and whether remote publication succeeded. Significant deletions, major architecture/scope changes, paid services, publishing builds and other consequential actions still require separate authorization. This source-publication authority does not enable automatic synchronization or authorize gameplay.
