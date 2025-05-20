using System;

namespace UnityEngine.UIElements;

public struct Cursor : IEquatable<Cursor>
{
	public Texture2D texture { get; set; }

	public Vector2 hotspot { get; set; }

	internal int defaultCursorId { get; set; }

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(Cursor other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(Cursor style1, Cursor style2)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
