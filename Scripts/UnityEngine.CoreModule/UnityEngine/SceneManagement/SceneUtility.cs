using UnityEngine.Bindings;

namespace UnityEngine.SceneManagement;

[NativeHeader("Runtime/Export/SceneManager/SceneUtility.bindings.h")]
public static class SceneUtility
{
	[StaticAccessor("SceneUtilityBindings", StaticAccessorType.DoubleColon)]
	public static string GetScenePathByBuildIndex(int buildIndex)
	{
		return null;
	}
}
