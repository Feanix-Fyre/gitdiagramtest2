using System;

namespace UnityEngine.UIElements;

internal struct VisualData : IStyleDataGroup<VisualData>, IEquatable<VisualData>
{
	public Color backgroundColor;

	public Background backgroundImage;

	public BackgroundPosition backgroundPositionX;

	public BackgroundPosition backgroundPositionY;

	public BackgroundRepeat backgroundRepeat;

	public BackgroundSize backgroundSize;

	public Color borderBottomColor;

	public Length borderBottomLeftRadius;

	public Length borderBottomRightRadius;

	public Color borderLeftColor;

	public Color borderRightColor;

	public Color borderTopColor;

	public Length borderTopLeftRadius;

	public Length borderTopRightRadius;

	public float opacity;

	public OverflowInternal overflow;

	public VisualData Copy()
	{
		return default(VisualData);
	}

	public void CopyFrom(ref VisualData other)
	{
	}

	public static bool operator ==(VisualData lhs, VisualData rhs)
	{
		return false;
	}

	public bool Equals(VisualData other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
