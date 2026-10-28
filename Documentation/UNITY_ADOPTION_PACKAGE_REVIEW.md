# Unity adoption package review — 2026-10-28

Task: P0-UNITY-ADOPTION-01. Status: package review requires user decision; copying and editor launch have not begun.

## Preflight evidence
- Branch main, HEAD and live remote HEAD/main: 38547f6321315124280a087fed5d1063e23db79f. Correct origin; no new remote commits.
- Preserved all five prior audit documentation changes. Game/ absent. Source ProjectVersion.txt confirms 6000.6.7f1 / b22767f04f04.
- Source Assets/, Packages/, ProjectSettings/ contain 69 files; no reparse points found in this inspection. Only two template Readme C# files found under Assets.
- Manifest and lock agree on every direct dependency version. This is static consistency, not a successful restore/compile.

## Full direct dependency inventory
45 direct dependencies. Versions below are manifest and matching lock versions. No direct dependency is marked deprecated in inspected package metadata; a full ecosystem deprecation audit was not established.

| Package | Version | Lock source |
|---|---|---|
| com.unity.ai.assistant | 2.21.0-pre.2 | registry |
| com.unity.ai.inference | 2.6.1 | registry |
| com.unity.collab-proxy | 2.13.6 | registry |
| com.unity.ide.rider | 3.1.0 | registry |
| com.unity.ide.visualstudio | 2.0.28 | registry |
| com.unity.inputsystem | 1.20.1 | registry |
| com.unity.pipeline | 0.9.1-exp.1 | registry |
| com.unity.render-pipelines.universal | 17.6.0 | builtin |
| com.unity.ugui | 2.6.0 | builtin |
| com.unity.modules.accessibility | 1.0.0 | builtin |
| com.unity.modules.adaptiveperformance | 1.0.0 | builtin |
| com.unity.modules.ai | 1.0.0 | builtin |
| com.unity.modules.androidjni | 1.0.0 | builtin |
| com.unity.modules.animation | 1.0.0 | builtin |
| com.unity.modules.assetbundle | 1.0.0 | builtin |
| com.unity.modules.audio | 1.0.0 | builtin |
| com.unity.modules.cloth | 1.0.0 | builtin |
| com.unity.modules.director | 1.0.0 | builtin |
| com.unity.modules.imageconversion | 1.0.0 | builtin |
| com.unity.modules.imgui | 1.0.0 | builtin |
| com.unity.modules.jsonserialize | 1.0.0 | builtin |
| com.unity.modules.particlesystem | 1.0.0 | builtin |
| com.unity.modules.physics | 1.0.0 | builtin |
| com.unity.modules.physics2d | 1.0.0 | builtin |
| com.unity.modules.physicscore2d | 1.0.0 | builtin |
| com.unity.modules.screencapture | 1.0.0 | builtin |
| com.unity.modules.terrain | 1.0.0 | builtin |
| com.unity.modules.terrainphysics | 1.0.0 | builtin |
| com.unity.modules.tetgen | 1.0.0 | builtin |
| com.unity.modules.tilemap | 1.0.0 | builtin |
| com.unity.modules.timelinefoundation | 1.0.0 | builtin |
| com.unity.modules.ui | 1.0.0 | builtin |
| com.unity.modules.uielements | 1.0.0 | builtin |
| com.unity.modules.umbra | 1.0.0 | builtin |
| com.unity.modules.unityanalytics | 1.0.0 | builtin |
| com.unity.modules.unitywebrequest | 1.0.0 | builtin |
| com.unity.modules.unitywebrequestassetbundle | 1.0.0 | builtin |
| com.unity.modules.unitywebrequestaudio | 1.0.0 | builtin |
| com.unity.modules.unitywebrequesttexture | 1.0.0 | builtin |
| com.unity.modules.unitywebrequestwww | 1.0.0 | builtin |
| com.unity.modules.vectorgraphics | 1.0.0 | builtin |
| com.unity.modules.vehicles | 1.0.0 | builtin |
| com.unity.modules.video | 1.0.0 | builtin |
| com.unity.modules.wind | 1.0.0 | builtin |
| com.unity.modules.xr | 1.0.0 | builtin |

## Questionable packages and required decision
| Package | Purpose / compatibility evidence | Licensing, privacy, cost | Phase 0 recommendation |
|---|---|---|---|
| AI Assistant 2.21.0-pre.2 | Preview editor assistant; can inspect project and change scenes/assets. Metadata minimum Unity 6000.0; exact 6000.6.7f1 execution untested. | Local license points to Unity Terms of Service. Official docs describe credits consumed by Assistant requests; project-aware service use warrants privacy review. No entitlement or terms acceptance verified. Merely finding the package does not demonstrate a purchase or data transfer. | Not necessary. Recommend removing direct dependency only in the adopted copy if explicitly approved; leave original unchanged. |
| AI Inference / Sentis 2.6.1 | Local neural-network inference runtime, brings Burst/Collections and other dependencies; minimum Unity 6000.0. | Local license: Unity Terms of Service. Local inference is distinct from hosted Assistant credit usage; model licensing must be reviewed if models are later added. No paid inference service enabled or inferred. | Not needed for empty-scene verification; propose removing from adopted copy with approval. |
| Unity Pipeline 0.9.1-exp.1 | Experimental bridge for CLI/agents to issue editor/game commands, including builds/tests/play. Minimum Unity 6000.0; cached package dependencies include older Test Framework and JSON package requests; actual locked resolution differs and is not by itself proof of incompatibility. | Local license: Unity Terms of Service. No separate paid service established from package metadata. Command-access surface and experimental compatibility need explicit review; official package docs could not be fetched. | Optional automation aid, not required for the game. Recommend omitting from initial adopted baseline unless user explicitly wants this integration retained. |
| Unity Version Control 2.13.6 | Editor integration for Unity Version Control; minimum Unity 6000.0. | Unity Package Distribution License in local LICENSE.md. Package description says service subscription is required, with free entry options; no account entitlement checked. Installation alone does not prove charges. | GitHub/Git already selected. Recommend removing only in adopted copy with approval; do not activate service. |
| Rider Editor 3.1.0 | JetBrains IDE integration, minimum Unity 6000.0. | Integration package is MIT licensed. IDE licensing is separate and was not evaluated or purchased. | Unneeded for Visual Studio. Safe to retain during preservation-first adoption; removal optional, no change without approval. |

Other direct dependencies are URP 17.6.0, uGUI 2.6.0, Input System 1.20.1, Visual Studio Editor 2.0.28, and engine modules at 1.0.0. These serve rendering/UI/input/IDE or engine capabilities. Preserve their current resolution. Package presence and minimum-version metadata do not establish full compatibility.

## Scope held for review
The user request explicitly says: "Stop for review if any questionable package could affect licensing, privacy, cost, project compatibility, or existing user work." The above preview/service/experimental packages meet that condition. No dependency was removed, replaced, installed, enabled, or invoked. No terms were accepted. No source project file was modified.

Recommended decision: authorize removing only com.unity.ai.assistant, com.unity.ai.inference, com.unity.pipeline, and com.unity.collab-proxy from the future adopted copy, preserving the original and retaining Rider for now. Then resolve the lockfile through the approved editor; review transitive changes before testing. Alternatively explicitly approve retaining the existing manifest with no AI/Version Control service use; compatibility still needs observed verification. No cleanup is executed by this recommendation.

## Verification and next steps
- Copy: NOT STARTED. Game/ does not exist. No caches copied; no LFS rules or ignore edits.
- Unity launch, licensing, URP runtime, compilation, scene play/stop, Visual Studio integration, debugger, tests, Windows Mono build/run: NOT RUN because package gate was reached before copying.
- No-tests-exist claim is not made: no adopted project/test runner has been inspected.
- Clean-checkout engine recovery: pending adoption plus separate commit/push authorization. Prior documentation-only recovery remains verified.
- Current review changes are documentation only; proposed later commit contains prior audit + adoption review docs, then approved Game/ source/settings/manifests after copying/verification. No commit/push authorized.

## Sources
- Cached package.json and LICENSE.md files under source Library/PackageCache (read-only inspection).
- https://docs.unity.com/en-us/ai/credits/credits-about
- https://unity.com/legal/unityai-guiding-principles
- https://docs.unity3d.com/Packages/com.unity.ai.inference@2.6/manual/index.html
- Pipeline documentation URL in metadata could not be retrieved: https://docs.unity3d.com/Packages/com.unity.pipeline@0.9/manual/index.html

## Source manifest/lock integrity snapshot
- Packages/manifest.json: SHA-256 00c6be2534f14b8bda24368dca24e112ce2a54ed611fa511fd23b43e05eb9d86
- Packages/packages-lock.json: SHA-256 49607666ebbc877529693242d55dfc946b4111be3d03def5cb1fbcfa5f81d86d
- ProjectSettings/ProjectVersion.txt: SHA-256 2a88e6864b6f54588287bed3bc6e9260e65bd49498910cca4478770ca8a5d674

## Approved omissions and execution result — 2026-10-28
User explicitly approved removing the four recommended dependencies in adopted Game/ only. Copy-first adoption executed, source preserved, no direct pin changes beyond those four omissions. Unity's resolved lock removes those four plus com.unity.2d.sprite, com.unity.dt.app-ui, com.unity.mathematics and com.unity.nuget.newtonsoft-json; no added or changed retained versions. Post-resolution inspection found an App UI settings reference pointing into removed Sentis; verification paused under user stop condition without repair. See UNITY_ADOPTION_RESULTS.md. Earlier pending-copy/package-review sections above are historical.

## Final local verification — 2026-10-28
Autonomy directive cleared ADOPTION-001 repair and verification. No further dependency changes: original four approved direct omissions and four orphan removals remain the full manifest/lock diff. Local scene/test/build/player checks are documented in PHASE0_VERIFICATION.md; actual remote engine recovery and debugger attach remain pending. Original source preserved.
