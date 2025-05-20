using System;

namespace UnityEngine.Rendering;

public static class DocumentationUtils
{
	public static string GetHelpURL<TEnum>(TEnum mask = default(TEnum)) where TEnum : struct, IConvertible
	{
		return null;
	}

	public static bool TryGetHelpURL(Type type, out string url)
	{
		url = null;
		return false;
	}
}
