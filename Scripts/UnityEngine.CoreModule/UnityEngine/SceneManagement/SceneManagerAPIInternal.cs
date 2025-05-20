using UnityEngine.Bindings;

namespace UnityEngine.SceneManagement;

[NativeHeader("Runtime/SceneManager/SceneManager.h")]
[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
[NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
internal static class SceneManagerAPIInternal
{
	public static int GetNumScenesInBuildSettings()
	{
		return 0;
	}

	[NativeThrows]
	public static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
	{
		return null;
	}

	private static AsyncOperation LoadSceneAsyncNameIndexInternal_Injected(string sceneName, int sceneBuildIndex, ref LoadSceneParameters parameters, bool mustCompleteNextFrame)
	{
		return null;
	}
}
