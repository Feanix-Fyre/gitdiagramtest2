using System;

namespace UnityEngine.InputSystem.Utilities;

public struct InternedString : IEquatable<InternedString>, IComparable<InternedString>
{
	private readonly string m_StringOriginalCase;

	private readonly string m_StringLowerCase;

	public int length => 0;

	public InternedString(string text)
	{
		m_StringOriginalCase = null;
		m_StringLowerCase = null;
	}

	public bool IsEmpty()
	{
		return false;
	}

	public string ToLower()
	{
		return null;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(InternedString other)
	{
		return false;
	}

	public int CompareTo(InternedString other)
	{
		return 0;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	public static bool operator ==(InternedString a, InternedString b)
	{
		return false;
	}

	public static bool operator !=(InternedString a, InternedString b)
	{
		return false;
	}

	public static bool operator ==(InternedString a, string b)
	{
		return false;
	}

	public static bool operator !=(InternedString a, string b)
	{
		return false;
	}

	public static bool operator ==(string a, InternedString b)
	{
		return false;
	}

	public static bool operator !=(string a, InternedString b)
	{
		return false;
	}

	public static bool operator <(InternedString left, InternedString right)
	{
		return false;
	}

	public static bool operator >(InternedString left, InternedString right)
	{
		return false;
	}

	public static implicit operator string(InternedString str)
	{
		return null;
	}
}
