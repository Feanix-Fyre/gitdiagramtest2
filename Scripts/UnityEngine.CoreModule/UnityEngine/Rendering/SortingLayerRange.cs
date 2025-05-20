using System;

namespace UnityEngine.Rendering;

public struct SortingLayerRange : IEquatable<SortingLayerRange>
{
	private short m_LowerBound;

	private short m_UpperBound;

	public short lowerBound => 0;

	public short upperBound => 0;

	public static SortingLayerRange all => default(SortingLayerRange);

	public SortingLayerRange(short lowerBound, short upperBound)
	{
		m_LowerBound = 0;
		m_UpperBound = 0;
	}

	public bool Equals(SortingLayerRange other)
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
