using System;

namespace UnityEngine.TextCore.Text;

[Serializable]
[ExcludeFromPreset]
[ExcludeFromObjectFactory]
public class TextColorGradient : ScriptableObject
{
	public ColorGradientMode colorMode;

	public Color topLeft;

	public Color topRight;

	public Color bottomLeft;

	public Color bottomRight;

	private const ColorGradientMode k_DefaultColorMode = ColorGradientMode.FourCornersGradient;

	private static readonly Color k_DefaultColor;

	public TextColorGradient()
	{
	}

	public TextColorGradient(Color color)
	{
	}

	public TextColorGradient(Color color0, Color color1, Color color2, Color color3)
	{
	}
}
