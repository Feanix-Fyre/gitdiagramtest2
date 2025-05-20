using System;

namespace UnityEngine.Rendering;

public struct BatchPackedCullingViewID : IEquatable<BatchPackedCullingViewID>
{
	internal ulong handle;

	public override int GetHashCode()
	{
		return 0;
	}

	public bool Equals(BatchPackedCullingViewID other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}
}
