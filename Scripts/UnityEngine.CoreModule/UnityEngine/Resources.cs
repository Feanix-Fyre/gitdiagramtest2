using System;
using UnityEngine.Bindings;
using UnityEngineInternal;

namespace UnityEngine;

[NativeHeader("Runtime/Export/Resources/Resources.bindings.h")]
[NativeHeader("Runtime/Misc/ResourceManagerUtility.h")]
public sealed class Resources
{
	internal static T[] ConvertObjects<T>(Object[] rawObjects) where T : Object
	{
		return null;
	}

	public static Object[] FindObjectsOfTypeAll(Type type)
	{
		return null;
	}

	public static T[] FindObjectsOfTypeAll<T>() where T : Object
	{
		return null;
	}

	public static Object Load(string path)
	{
		return null;
	}

	public static T Load<T>(string path) where T : Object
	{
		return null;
	}

	public static Object Load(string path, Type systemTypeInstance)
	{
		return null;
	}

	public static Object[] LoadAll(string path, Type systemTypeInstance)
	{
		return null;
	}

	public static T[] LoadAll<T>(string path) where T : Object
	{
		return null;
	}

	[FreeFunction("GetScriptingBuiltinResource", ThrowsException = true)]
	[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
	public static Object GetBuiltinResource([NotNull("ArgumentNullException")] Type type, string path)
	{
		return null;
	}

	public static T GetBuiltinResource<T>(string path) where T : Object
	{
		return null;
	}

	[FreeFunction("Resources_Bindings::UnloadUnusedAssets")]
	public static AsyncOperation UnloadUnusedAssets()
	{
		return null;
	}
}
