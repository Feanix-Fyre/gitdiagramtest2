using System;

namespace UnityEngine.UIElements;

internal struct TransformData : IStyleDataGroup<TransformData>, IEquatable<TransformData>
{
	public Rotate rotate;

	public Scale scale;

	public TransformOrigin transformOrigin;

	public Translate translate;

	public TransformData Copy()
	{
		return default(TransformData);
	}

	public void CopyFrom(ref TransformData other)
	{
	}

	public static bool operator ==(TransformData lhs, TransformData rhs)
	{
		return false;
	}

	public bool Equals(TransformData other)
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
