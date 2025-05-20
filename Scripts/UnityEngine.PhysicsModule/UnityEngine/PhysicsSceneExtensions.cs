using UnityEngine.Bindings;
using UnityEngine.SceneManagement;

namespace UnityEngine;

public static class PhysicsSceneExtensions
{
	public static PhysicsScene GetPhysicsScene(this Scene scene)
	{
		return default(PhysicsScene);
	}

	[NativeMethod("GetPhysicsSceneFromUnityScene")]
	[StaticAccessor("GetPhysicsManager()", StaticAccessorType.Dot)]
	private static PhysicsScene GetPhysicsScene_Internal(Scene scene)
	{
		return default(PhysicsScene);
	}

	private static void GetPhysicsScene_Internal_Injected(ref Scene scene, out PhysicsScene ret)
	{
		ret = default(PhysicsScene);
	}
}
