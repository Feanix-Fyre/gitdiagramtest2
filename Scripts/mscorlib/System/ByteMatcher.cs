using System.Collections;

namespace System;

internal class ByteMatcher
{
	private Hashtable map;

	private Hashtable starts;

	public void AddMapping(TermInfoStrings key, byte[] val)
	{
	}

	public void Sort()
	{
	}

	public bool StartsWith(int c)
	{
		return false;
	}

	public TermInfoStrings Match(char[] buffer, int offset, int length, out int used)
	{
		used = default(int);
		return default(TermInfoStrings);
	}
}
