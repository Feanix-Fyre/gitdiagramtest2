using System;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Modules/JSONSerialize/Public/JsonUtility.bindings.h")]
public static class JsonUtility
{
	[FreeFunction("ToJsonInternal", true)]
	[ThreadSafe]
	private static string ToJsonInternal([NotNull("ArgumentNullException")] object obj, bool prettyPrint)
	{
		return null;
	}

	[ThreadSafe]
	[FreeFunction("FromJsonInternal", true, ThrowsException = true)]
	private static object FromJsonInternal(string json, object objectToOverwrite, Type type)
	{
		return null;
	}

	public static string ToJson(object obj)
	{
		return null;
	}

	public static string ToJson(object obj, bool prettyPrint)
	{
		return null;
	}

	public static T FromJson<T>(string json)
	{
		return default(T);
	}

	public static object FromJson(string json, Type type)
	{
		return null;
	}

	public static void FromJsonOverwrite(string json, object objectToOverwrite)
	{
	}
}
