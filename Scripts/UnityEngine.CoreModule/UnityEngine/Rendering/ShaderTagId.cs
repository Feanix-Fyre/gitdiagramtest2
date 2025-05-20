using System;

namespace UnityEngine.Rendering;

public struct ShaderTagId : IEquatable<ShaderTagId>
{
	public static readonly ShaderTagId none;

	private int m_Id;

	internal int id
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public ShaderTagId(string name)
	{
		m_Id = 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(ShaderTagId other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(ShaderTagId tag1, ShaderTagId tag2)
	{
		return false;
	}

	public static bool operator !=(ShaderTagId tag1, ShaderTagId tag2)
	{
		return false;
	}
}
