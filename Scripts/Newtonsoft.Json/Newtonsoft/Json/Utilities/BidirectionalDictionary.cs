using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Newtonsoft.Json.Utilities;

internal class BidirectionalDictionary<TFirst, TSecond> where TFirst : notnull where TSecond : notnull
{
	private readonly IDictionary<TFirst, TSecond> _firstToSecond;

	private readonly IDictionary<TSecond, TFirst> _secondToFirst;

	private readonly string _duplicateFirstErrorMessage;

	private readonly string _duplicateSecondErrorMessage;

	public BidirectionalDictionary()
	{
	}

	public BidirectionalDictionary(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer)
	{
	}

	public BidirectionalDictionary(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage)
	{
	}

	public void Set(TFirst first, TSecond second)
	{
	}

	public bool TryGetByFirst(TFirst first, [NotNullWhen(true)] out TSecond? second)
	{
		second = default(TSecond);
		return false;
	}

	public bool TryGetBySecond(TSecond second, [NotNullWhen(true)] out TFirst? first)
	{
		first = default(TFirst);
		return false;
	}
}
