using UnityEngine.Bindings;
using UnityEngine.SceneManagement;

namespace UnityEngine;

public static class PhysicsSceneExtensions2D
{
	public static PhysicsScene2D GetPhysicsScene2D(this Scene scene)
	{
		return default(PhysicsScene2D);
	}

	[NativeMethod("GetPhysicsSceneFromUnityScene")]
	[StaticAccessor("GetPhysicsManager2D()", StaticAccessorType.Arrow)]
	private static PhysicsScene2D GetPhysicsScene_Internal(Scene scene)
	{
		return default(PhysicsScene2D);
	}

	private static void GetPhysicsScene_Internal_Injected(ref Scene scene, out PhysicsScene2D ret)
	{
		ret = default(PhysicsScene2D);
	}
}
