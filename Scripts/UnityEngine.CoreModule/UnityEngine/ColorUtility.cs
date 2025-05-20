using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Runtime/Math/ColorUtility.h")]
public class ColorUtility
{
	[FreeFunction("TryParseHtmlColor", true)]
	internal static bool DoTryParseHtmlColor(string htmlString, out Color32 color)
	{
		color = default(Color32);
		return false;
	}

	public static bool TryParseHtmlString(string htmlString, out Color color)
	{
		color = default(Color);
		return false;
	}

	public static string ToHtmlStringRGB(Color color)
	{
		return null;
	}

	public static string ToHtmlStringRGBA(Color color)
	{
		return null;
	}
}
