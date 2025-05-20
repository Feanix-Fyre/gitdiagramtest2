using System;

namespace UnityEngine.Rendering;

public struct DepthState : IEquatable<DepthState>
{
	private byte m_WriteEnabled;

	private sbyte m_CompareFunction;

	public static DepthState defaultValue => default(DepthState);

	public CompareFunction compareFunction => default(CompareFunction);

	public DepthState(bool writeEnabled = true, CompareFunction compareFunction = CompareFunction.Less)
	{
		m_WriteEnabled = 0;
		m_CompareFunction = 0;
	}

	public bool Equals(DepthState other)
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
