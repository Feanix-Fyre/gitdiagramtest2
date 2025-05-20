using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Runtime/Utilities/PlayerPrefs.h")]
public class PlayerPrefs
{
	[NativeMethod("SetInt")]
	private static bool TrySetInt(string key, int value)
	{
		return false;
	}

	[NativeMethod("SetFloat")]
	private static bool TrySetFloat(string key, float value)
	{
		return false;
	}

	[NativeMethod("SetString")]
	private static bool TrySetSetString(string key, string value)
	{
		return false;
	}

	public static void SetInt(string key, int value)
	{
	}

	public static int GetInt(string key, int defaultValue)
	{
		return 0;
	}

	public static int GetInt(string key)
	{
		return 0;
	}

	public static void SetFloat(string key, float value)
	{
	}

	public static float GetFloat(string key, float defaultValue)
	{
		return 0f;
	}

	public static void SetString(string key, string value)
	{
	}

	public static string GetString(string key, string defaultValue)
	{
		return null;
	}

	public static string GetString(string key)
	{
		return null;
	}

	public static bool HasKey(string key)
	{
		return false;
	}

	public static void DeleteKey(string key)
	{
	}

	[NativeMethod("Sync")]
	public static void Save()
	{
	}
}
