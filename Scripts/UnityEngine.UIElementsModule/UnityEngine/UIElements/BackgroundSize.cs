using System;

namespace UnityEngine.UIElements;

public struct BackgroundSize : IEquatable<BackgroundSize>
{
	private BackgroundSizeType m_SizeType;

	private Length m_X;

	private Length m_Y;

	public BackgroundSizeType sizeType
	{
		get
		{
			return default(BackgroundSizeType);
		}
		set
		{
		}
	}

	public Length x
	{
		get
		{
			return default(Length);
		}
		set
		{
		}
	}

	public Length y
	{
		get
		{
			return default(Length);
		}
		set
		{
		}
	}

	public BackgroundSize(Length sizeX, Length sizeY)
	{
		m_SizeType = default(BackgroundSizeType);
		m_X = default(Length);
		m_Y = default(Length);
	}

	public BackgroundSize(BackgroundSizeType sizeType)
	{
		m_SizeType = default(BackgroundSizeType);
		m_X = default(Length);
		m_Y = default(Length);
	}

	internal static BackgroundSize Initial()
	{
		return default(BackgroundSize);
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(BackgroundSize other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(BackgroundSize style1, BackgroundSize style2)
	{
		return false;
	}

	public static bool operator !=(BackgroundSize style1, BackgroundSize style2)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
