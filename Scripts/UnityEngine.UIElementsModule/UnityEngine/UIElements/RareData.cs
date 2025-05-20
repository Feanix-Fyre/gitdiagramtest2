using System;

namespace UnityEngine.UIElements;

internal struct RareData : IStyleDataGroup<RareData>, IEquatable<RareData>
{
	public Cursor cursor;

	public TextOverflow textOverflow;

	public Color unityBackgroundImageTintColor;

	public OverflowClipBox unityOverflowClipBox;

	public int unitySliceBottom;

	public int unitySliceLeft;

	public int unitySliceRight;

	public float unitySliceScale;

	public int unitySliceTop;

	public TextOverflowPosition unityTextOverflowPosition;

	public RareData Copy()
	{
		return default(RareData);
	}

	public void CopyFrom(ref RareData other)
	{
	}

	public static bool operator ==(RareData lhs, RareData rhs)
	{
		return false;
	}

	public bool Equals(RareData other)
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
