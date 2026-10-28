using System;
using System.IO;
using Unity.CodeEditor;
using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Rendering;

// Editor-only Phase 0 tooling. Never included in the player; contains no gameplay.
public static class GenesisEnvironment
{
    public const string SampleScene = "Assets/Scenes/SampleScene.unity";
    static string RepositoryRoot => Directory.GetParent(Application.dataPath).Parent.FullName;

    [MenuItem("Genesis/Phase 0/Open Sample Scene")]
    public static void OpenSampleScene()
    {
        if (EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo())
            EditorSceneManager.OpenScene(SampleScene);
    }

    [MenuItem("Genesis/Phase 0/Generate Visual Studio Solution")]
    public static void GenerateSolution()
    {
        const string editor = @"C:\Program Files\Microsoft Visual Studio\18\Community\Common7\IDE\devenv.exe";
        if (!File.Exists(editor)) throw new FileNotFoundException("Approved Visual Studio installation missing", editor);
        CodeEditor.SetExternalScriptEditor(editor);
        CodeEditor.CurrentEditor.SyncAll();
        Debug.Log("GENESIS_PHASE0_IDE: " + CodeEditor.CurrentEditor.GetType().FullName);
    }

    [MenuItem("Genesis/Phase 0/Build Windows x64 Mono Development")]
    public static void BuildWindows()
    {
        if (Application.unityVersion != "6000.6.7f1") throw new InvalidOperationException("Use pinned Unity 6000.6.7f1");
        if (EditorApplication.isCompiling || EditorApplication.isUpdating) throw new InvalidOperationException("Wait for compilation and asset refresh before building");
        if (EditorApplication.isPlayingOrWillChangePlaymode) throw new InvalidOperationException("Exit Play Mode before building");
        if (EditorUserBuildSettings.activeBuildTarget != BuildTarget.StandaloneWindows64 &&
            !EditorUserBuildSettings.SwitchActiveBuildTarget(BuildTargetGroup.Standalone, BuildTarget.StandaloneWindows64))
            throw new InvalidOperationException("Unable to select Windows x64");
        PlayerSettings.SetScriptingBackend(NamedBuildTarget.Standalone, ScriptingImplementation.Mono2x);
        var output = Path.Combine(RepositoryRoot, "Builds", "Windows", "Genesis.exe");
        var pipeline = QualitySettings.renderPipeline ?? GraphicsSettings.defaultRenderPipeline;
        var pipelinePath = pipeline == null ? "<not assigned>" : AssetDatabase.GetAssetPath(pipeline);
        Directory.CreateDirectory(Path.GetDirectoryName(output));
        var report = BuildPipeline.BuildPlayer(new BuildPlayerOptions
        {
            scenes = new[] { SampleScene },
            locationPathName = output,
            target = BuildTarget.StandaloneWindows64,
            options = BuildOptions.Development | BuildOptions.AllowDebugging
        });
        var summary = report.summary;
        var evidence = Path.Combine(RepositoryRoot, "TestResults", "UnityAdoption");
        Directory.CreateDirectory(evidence);
        File.WriteAllText(Path.Combine(evidence, "build-summary.txt"),
            $"Unity={Application.unityVersion}\nTarget={summary.platform}\nBackend={PlayerSettings.GetScriptingBackend(NamedBuildTarget.Standalone)}\n" +
            $"RequestedOptions=Development,AllowDebugging\nReportedOptions={summary.options}\nResult={summary.result}\nErrors={summary.totalErrors}\nWarnings={summary.totalWarnings}\n" +
            $"Bytes={summary.totalSize}\nDuration={summary.totalTime}\nPipelineBeforeBuild={pipelinePath}\nOutput={summary.outputPath}\n");
        if (summary.result != BuildResult.Succeeded) throw new InvalidOperationException("Phase 0 build failed; inspect Console and build-summary.txt");
        Debug.Log("GENESIS_PHASE0_BUILD_SUCCEEDED: " + output);
    }
}
