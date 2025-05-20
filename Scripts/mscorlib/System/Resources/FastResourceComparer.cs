using System.Collections;
using System.Collections.Generic;

namespace System.Resources;

internal sealed class FastResourceComparer : IComparer, IEqualityComparer, IComparer<string>, IEqualityComparer<string>
{
	internal static readonly FastResourceComparer Default;

	public int GetHashCode(object key)
	{
		return 0;
	}

	public int GetHashCode(string key)
	{
		return 0;
	}

	internal static int HashFunction(string key)
	{
		return 0;
	}

	public int Compare(object a, object b)
	{
		return 0;
	}

	public int Compare(string a, string b)
	{
		return 0;
	}

	public bool Equals(string a, string b)
	{
		return false;
	}

	public new bool Equals(object a, object b)
	{
		return false;
	}

	public static int CompareOrdinal(string a, byte[] bytes, int bCharLength)
	{
		return 0;
	}

	public static int CompareOrdinal(byte[] bytes, int aCharLength, string b)
	{
		return 0;
	}

	internal unsafe static int CompareOrdinal(byte* a, int byteLen, string b)
	{
		return 0;
	}
}
