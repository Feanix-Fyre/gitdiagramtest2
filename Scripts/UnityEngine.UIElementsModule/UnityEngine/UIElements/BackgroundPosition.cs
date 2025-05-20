using System;

namespace UnityEngine.UIElements;

public struct BackgroundPosition : IEquatable<BackgroundPosition>
{
	public BackgroundPositionKeyword keyword;

	public Length offset;

	public BackgroundPosition(BackgroundPositionKeyword keyword)
	{
		this.keyword = default(BackgroundPositionKeyword);
		offset = default(Length);
	}

	public BackgroundPosition(BackgroundPositionKeyword keyword, Length offset)
	{
		this.keyword = default(BackgroundPositionKeyword);
		this.offset = default(Length);
	}

	internal static BackgroundPosition Initial()
	{
		return default(BackgroundPosition);
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(BackgroundPosition other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(BackgroundPosition style1, BackgroundPosition style2)
	{
		return false;
	}

	public static bool operator !=(BackgroundPosition style1, BackgroundPosition style2)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
