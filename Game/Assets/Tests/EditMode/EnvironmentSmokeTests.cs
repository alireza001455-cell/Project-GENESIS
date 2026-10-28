using NUnit.Framework;
using System.Linq;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Rendering;

public sealed class EnvironmentSmokeTests
{
    [Test]
    public void UniversalPipelineAssetAndRenderersAreAvailable()
    {
        var pipeline = QualitySettings.renderPipeline != null ? QualitySettings.renderPipeline : GraphicsSettings.defaultRenderPipeline;
        Assert.That(pipeline, Is.Not.Null, "Effective render pipeline asset is missing");
        Assert.That(pipeline.GetType().FullName, Does.Contain("UniversalRenderPipelineAsset"));
        Assert.That(AssetDatabase.GetDependencies(AssetDatabase.GetAssetPath(pipeline)),
            Has.Some.EndsWith("_Renderer.asset"), "Renderer reference is missing");
    }

    [Test]
    public void SampleSceneLoadsWithCameraAndNoMissingScripts()
    {
        var previous = EditorSceneManager.GetSceneManagerSetup();
        try
        {
            var scene = EditorSceneManager.OpenScene("Assets/Scenes/SampleScene.unity");
            var cameras = 0;
            foreach (var root in scene.GetRootGameObjects())
            {
                cameras += root.GetComponentsInChildren<Camera>(true).Length;
                foreach (var transform in root.GetComponentsInChildren<Transform>(true))
                    Assert.That(GameObjectUtility.GetMonoBehavioursWithMissingScriptCount(transform.gameObject),
                        Is.Zero, "Missing script on " + transform.name);
            }
            Assert.That(cameras, Is.GreaterThan(0));
        }
        finally
        {
            if (previous.Any(setup => setup.isLoaded && setup.isActive))
                EditorSceneManager.RestoreSceneManagerSetup(previous);
            else
                EditorSceneManager.NewScene(NewSceneSetup.EmptyScene, NewSceneMode.Single);
        }
    }
}
