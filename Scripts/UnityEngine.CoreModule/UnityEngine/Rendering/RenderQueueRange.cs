using System;

namespace UnityEngine.Rendering;

public struct RenderQueueRange : IEquatable<RenderQueueRange>
{
	private int m_LowerBound;

	private int m_UpperBound;

	private const int k_MinimumBound = 0;

	public static readonly int minimumBound;

	private const int k_MaximumBound = 5000;

	public static readonly int maximumBound;

	public static RenderQueueRange all => default(RenderQueueRange);

	public static RenderQueueRange opaque => default(RenderQueueRange);

	public static RenderQueueRange transparent => default(RenderQueueRange);

	public bool Equals(RenderQueueRange other)
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

	public static bool operator ==(RenderQueueRange left, RenderQueueRange right)
	{
		return false;
	}
}
