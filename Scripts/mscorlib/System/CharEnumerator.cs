using System.Collections;
using System.Collections.Generic;

namespace System;

/// <summary>Supports iterating over a <see cref="T:System.String" /> object and reading its individual characters. This class cannot be inherited.</summary>
[Serializable]
public sealed class CharEnumerator : IEnumerator, IEnumerator<char>, IDisposable, ICloneable
{
	private string _str;

	private int _index;

	private char _currentElement;

	/// <summary>Gets the currently referenced character in the string enumerated by this <see cref="T:System.CharEnumerator" /> object. For a description of this member, see <see cref="P:System.Collections.IEnumerator.Current" />.</summary>
	/// <returns>The boxed Unicode character currently referenced by this <see cref="T:System.CharEnumerator" /> object.</returns>
	/// <exception cref="T:System.InvalidOperationException">Enumeration has not started.  
	///  -or-  
	///  Enumeration has ended.</exception>
	object IEnumerator.Current => null;

	/// <summary>Gets the currently referenced character in the string enumerated by this <see cref="T:System.CharEnumerator" /> object.</summary>
	/// <returns>The Unicode character currently referenced by this <see cref="T:System.CharEnumerator" /> object.</returns>
	/// <exception cref="T:System.InvalidOperationException">The index is invalid; that is, it is before the first or after the last character of the enumerated string.</exception>
	public char Current => '\0';

	internal CharEnumerator(string str)
	{
	}

	/// <summary>Creates a copy of the current <see cref="T:System.CharEnumerator" /> object.</summary>
	/// <returns>An <see cref="T:System.Object" /> that is a copy of the current <see cref="T:System.CharEnumerator" /> object.</returns>
	public object Clone()
	{
		return null;
	}

	/// <summary>Increments the internal index of the current <see cref="T:System.CharEnumerator" /> object to the next character of the enumerated string.</summary>
	/// <returns>
	///   <see langword="true" /> if the index is successfully incremented and within the enumerated string; otherwise, <see langword="false" />.</returns>
	public bool MoveNext()
	{
		return false;
	}

	/// <summary>Releases all resources used by the current instance of the <see cref="T:System.CharEnumerator" /> class.</summary>
	public void Dispose()
	{
	}

	/// <summary>Initializes the index to a position logically before the first character of the enumerated string.</summary>
	public void Reset()
	{
	}

	internal CharEnumerator()
	{
	}
}
