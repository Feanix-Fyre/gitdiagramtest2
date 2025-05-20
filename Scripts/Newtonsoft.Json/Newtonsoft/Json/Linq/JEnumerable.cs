using System;
using System.Collections;
using System.Collections.Generic;

namespace Newtonsoft.Json.Linq;

public readonly struct JEnumerable<T> : IJEnumerable<T>, IEnumerable<T>, IEnumerable, IEquatable<JEnumerable<T>> where T : notnull, JToken
{
	public static readonly JEnumerable<T> Empty;

	private readonly IEnumerable<T> _enumerable;

	public IJEnumerable<JToken> this[object key] => null;

	public JEnumerable(IEnumerable<T> enumerable)
	{
		_enumerable = null;
	}

	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public bool Equals(JEnumerable<T> other)
	{
		return false;
	}

	public override bool Equals(object? obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
