using System;

namespace UnityEngine.InputSystem.Utilities;

internal struct Substring : IComparable<Substring>, IEquatable<Substring>
{
	private readonly string m_String;

	private readonly int m_Index;

	private readonly int m_Length;

	public bool isEmpty => false;

	public int length => 0;

	public int index => 0;

	public char this[int index] => '\0';

	public Substring(string str)
	{
		m_String = null;
		m_Index = 0;
		m_Length = 0;
	}

	public Substring(string str, int index, int length)
	{
		m_String = null;
		m_Index = 0;
		m_Length = 0;
	}

	public Substring(string str, int index)
	{
		m_String = null;
		m_Index = 0;
		m_Length = 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(string other)
	{
		return false;
	}

	public bool Equals(Substring other)
	{
		return false;
	}

	public bool Equals(InternedString other)
	{
		return false;
	}

	public int CompareTo(Substring other)
	{
		return 0;
	}

	public static int Compare(Substring left, Substring right, StringComparison comparison)
	{
		return 0;
	}

	public bool StartsWith(string str)
	{
		return false;
	}

	public string Substr(int index = 0, int length = -1)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(Substring a, Substring b)
	{
		return false;
	}

	public static bool operator !=(Substring a, Substring b)
	{
		return false;
	}

	public static bool operator ==(Substring a, InternedString b)
	{
		return false;
	}

	public static bool operator !=(Substring a, InternedString b)
	{
		return false;
	}

	public static bool operator ==(InternedString a, Substring b)
	{
		return false;
	}

	public static bool operator !=(InternedString a, Substring b)
	{
		return false;
	}

	public static implicit operator Substring(string s)
	{
		return default(Substring);
	}
}
