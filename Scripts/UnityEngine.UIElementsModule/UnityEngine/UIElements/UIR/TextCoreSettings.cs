using System;

namespace UnityEngine.UIElements.UIR;

internal struct TextCoreSettings : IEquatable<TextCoreSettings>
{
	public Color faceColor;

	public Color outlineColor;

	public float outlineWidth;

	public Color underlayColor;

	public Vector2 underlayOffset;

	public float underlaySoftness;

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(TextCoreSettings other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
