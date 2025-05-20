using System.Collections.Generic;

namespace System.Drawing;

internal static class ColorTable
{
	private static readonly Lazy<Dictionary<string, Color>> s_colorConstants;

	internal static Dictionary<string, Color> Colors => null;

	private static Dictionary<string, Color> GetColors()
	{
		return null;
	}

	private static void FillConstants(Dictionary<string, Color> colors, Type enumType)
	{
	}

	internal static bool TryGetNamedColor(string name, out Color result)
	{
		result = default(Color);
		return false;
	}
}
