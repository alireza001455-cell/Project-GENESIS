# First Cell Stage playable — proposal for review

Status: proposed planning only. No gameplay implementation authorized. Complete Phase 0 assessment/sign-off and obtain explicit Phase 1 approval first. This draft follows the master directive's first-playable scope; it is not the complete Cell Stage.

## Player loop
Control one placeholder cell in a small top-down microscopic arena, collect food, manage energy spent moving, avoid one simple hazard, and read a minimal status display. A restart makes the loop repeatable. Use original placeholder visuals and existing URP/Input System; no new paid assets or services.

## Small implementation sequence after approval
1. Agree movement plane, camera, controls, energy rules and acceptance thresholds; create a dedicated Cell prototype scene while preserving SampleScene for environment checks.
2. Implement movement/input/camera as one small vertical slice. Prefer an explicitly constrained top-down arena over speculative procedural-body systems.
3. Add simple food collection, energy gain and movement-related drain, with isolated domain-rule tests and one scene integration check.
4. Add one hazard/damage or energy-loss rule, minimal HUD and restart; playtest readability/responsiveness.
5. Build/run Windows x64 Mono locally, rerun environment/regression tests, measure basic frame-time/memory behavior, and publish only source under standing Git authorization. Game-build distribution needs separate approval.

Each step gets concrete acceptance criteria and a small reviewable commit before the next dependent step. Estimate sessions after learning the user's experience and availability; no delivery date promised.

## Acceptance questions to settle before coding
- Movement controls and camera framing; keyboard/mouse baseline already approved, gamepad optional later.
- Food amount, energy limits/drain model, hazard consequence, restart behavior and what counts as completing the playable loop.
- Legible HUD, consistent behavior across frame rates and a reproducible local build; define measurable thresholds rather than assuming the empty-scene checks establish gameplay performance.

## Deferred from the first playable
Predators/advanced AI, reproduction, genetics, creature editor, complex procedural biology, multiplayer, other stages and Game 2 systems. Save/load and broader Cell Stage progression follow later approved scope. Avoid frameworks or architecture for unimplemented stages.

## Verification intent
Unit-test meaningful energy/resource rules; integration-test collect-once and hazard behavior; manually verify controls, camera and HUD in Play Mode and the standalone player. Preserve the existing environment smoke tests and clean-checkout build procedure. Do not add tests that merely mirror implementation details or claim automated tests establish fun.
