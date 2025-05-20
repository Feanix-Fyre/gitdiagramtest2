using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Events;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine.SceneManagement;

[RequiredByNativeCode]
[NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
public class SceneManager
{
	internal static bool s_AllowLoadScene;

	public static int sceneCount
	{
		[NativeMethod("GetSceneCount")]
		[NativeHeader("Runtime/SceneManager/SceneManager.h")]
		[StaticAccessor("GetSceneManager()", StaticAccessorType.Dot)]
		get
		{
			return 0;
		}
	}

	public static int sceneCountInBuildSettings => 0;

	public static event UnityAction<Scene, LoadSceneMode> sceneLoaded
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event UnityAction<Scene> sceneUnloaded
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event UnityAction<Scene, Scene> activeSceneChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
	public static Scene GetActiveScene()
	{
		return default(Scene);
	}

	[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
	[NativeThrows]
	public static bool SetActiveScene(Scene scene)
	{
		return false;
	}

	[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
	public static Scene GetSceneByName(string name)
	{
		return default(Scene);
	}

	[NativeThrows]
	[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
	public static Scene GetSceneAt(int index)
	{
		return default(Scene);
	}

	[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
	[NativeThrows]
	public static Scene CreateScene([NotNull("ArgumentNullException")] string sceneName, CreateSceneParameters parameters)
	{
		return default(Scene);
	}

	[NativeThrows]
	[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
	private static AsyncOperation UnloadSceneAsyncInternal(Scene scene, UnloadSceneOptions options)
	{
		return null;
	}

	private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame)
	{
		return null;
	}

	[StaticAccessor("SceneManagerBindings", StaticAccessorType.DoubleColon)]
	[NativeThrows]
	public static void MoveGameObjectToScene([NotNull("ArgumentNullException")] GameObject go, Scene scene)
	{
	}

	[RequiredByNativeCode]
	internal static AsyncOperation LoadFirstScene_Internal(bool async)
	{
		return null;
	}

	public static Scene CreateScene(string sceneName)
	{
		return default(Scene);
	}

	[ExcludeFromDocs]
	public static void LoadScene(string sceneName)
	{
	}

	public static Scene LoadScene(string sceneName, LoadSceneParameters parameters)
	{
		return default(Scene);
	}

	public static void LoadScene(int sceneBuildIndex, [DefaultValue("LoadSceneMode.Single")] LoadSceneMode mode)
	{
	}

	public static Scene LoadScene(int sceneBuildIndex, LoadSceneParameters parameters)
	{
		return default(Scene);
	}

	[ExcludeFromDocs]
	public static AsyncOperation LoadSceneAsync(string sceneName)
	{
		return null;
	}

	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneParameters parameters)
	{
		return null;
	}

	public static AsyncOperation UnloadSceneAsync(Scene scene)
	{
		return null;
	}

	[RequiredByNativeCode]
	private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	[RequiredByNativeCode]
	private static void Internal_SceneUnloaded(Scene scene)
	{
	}

	[RequiredByNativeCode]
	private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene)
	{
	}

	private static void GetActiveScene_Injected(out Scene ret)
	{
		ret = default(Scene);
	}

	private static bool SetActiveScene_Injected(ref Scene scene)
	{
		return false;
	}

	private static void GetSceneByName_Injected(string name, out Scene ret)
	{
		ret = default(Scene);
	}

	private static void GetSceneAt_Injected(int index, out Scene ret)
	{
		ret = default(Scene);
	}

	private static void CreateScene_Injected(string sceneName, ref CreateSceneParameters parameters, out Scene ret)
	{
		ret = default(Scene);
	}

	private static AsyncOperation UnloadSceneAsyncInternal_Injected(ref Scene scene, UnloadSceneOptions options)
	{
		return null;
	}

	private static void MoveGameObjectToScene_Injected(GameObject go, ref Scene scene)
	{
	}
}
