using System.Collections;

namespace System.Net;

internal class CaseInsensitiveAscii : IEqualityComparer, IComparer
{
	internal static readonly CaseInsensitiveAscii StaticInstance;

	internal static readonly byte[] AsciiToLower;

	public int GetHashCode(object myObject)
	{
		return 0;
	}

	public int Compare(object firstObject, object secondObject)
	{
		return 0;
	}

	private int FastGetHashCode(string myString)
	{
		return 0;
	}

	public new bool Equals(object firstObject, object secondObject)
	{
		return false;
	}
}
