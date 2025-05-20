using System;
using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine.SceneManagement;

[Serializable]
[NativeHeader("Runtime/Export/SceneManager/Scene.bindings.h")]
public struct Scene
{
	[SerializeField]
	[HideInInspector]
	private int m_Handle;

	public int handle => 0;

	internal string guid => null;

	public string name => null;

	public bool isLoaded => false;

	public int buildIndex => 0;

	public int rootCount => 0;

	[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
	private static bool IsValidInternal(int sceneHandle)
	{
		return false;
	}

	[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
	private static string GetNameInternal(int sceneHandle)
	{
		return null;
	}

	[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
	private static string GetGUIDInternal(int sceneHandle)
	{
		return null;
	}

	[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
	private static bool GetIsLoadedInternal(int sceneHandle)
	{
		return false;
	}

	[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
	private static int GetBuildIndexInternal(int sceneHandle)
	{
		return 0;
	}

	[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
	private static int GetRootCountInternal(int sceneHandle)
	{
		return 0;
	}

	[StaticAccessor("SceneBindings", StaticAccessorType.DoubleColon)]
	private static void GetRootGameObjectsInternal(int sceneHandle, object resultRootList)
	{
	}

	public bool IsValid()
	{
		return false;
	}

	public GameObject[] GetRootGameObjects()
	{
		return null;
	}

	public void GetRootGameObjects(List<GameObject> rootGameObjects)
	{
	}

	public static bool operator ==(Scene lhs, Scene rhs)
	{
		return false;
	}

	public static bool operator !=(Scene lhs, Scene rhs)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override bool Equals(object other)
	{
		return false;
	}
}
