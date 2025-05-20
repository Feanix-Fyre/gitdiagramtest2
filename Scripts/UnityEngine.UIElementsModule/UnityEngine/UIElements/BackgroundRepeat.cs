using System;

namespace UnityEngine.UIElements;

public struct BackgroundRepeat : IEquatable<BackgroundRepeat>
{
	public Repeat x;

	public Repeat y;

	public BackgroundRepeat(Repeat repeatX, Repeat repeatY)
	{
		x = default(Repeat);
		y = default(Repeat);
	}

	internal static BackgroundRepeat Initial()
	{
		return default(BackgroundRepeat);
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(BackgroundRepeat other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(BackgroundRepeat style1, BackgroundRepeat style2)
	{
		return false;
	}

	public static bool operator !=(BackgroundRepeat style1, BackgroundRepeat style2)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
