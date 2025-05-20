using System;

namespace UnityEngine;

public class ResourcesAPI
{
	private static ResourcesAPI s_DefaultAPI;

	internal static ResourcesAPI ActiveAPI => null;

	public static ResourcesAPI overrideAPI { get; }

	protected internal ResourcesAPI()
	{
	}

	protected internal virtual Object[] FindObjectsOfTypeAll(Type systemTypeInstance)
	{
		return null;
	}

	protected internal virtual Shader FindShaderByName(string name)
	{
		return null;
	}

	protected internal virtual Object Load(string path, Type systemTypeInstance)
	{
		return null;
	}

	protected internal virtual Object[] LoadAll(string path, Type systemTypeInstance)
	{
		return null;
	}
}
