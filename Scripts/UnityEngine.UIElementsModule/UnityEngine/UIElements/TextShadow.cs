using System;

namespace UnityEngine.UIElements;

public struct TextShadow : IEquatable<TextShadow>
{
	public Vector2 offset;

	public float blurRadius;

	public Color color;

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(TextShadow other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(TextShadow style1, TextShadow style2)
	{
		return false;
	}

	public static bool operator !=(TextShadow style1, TextShadow style2)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	internal static TextShadow LerpUnclamped(TextShadow a, TextShadow b, float t)
	{
		return default(TextShadow);
	}
}
