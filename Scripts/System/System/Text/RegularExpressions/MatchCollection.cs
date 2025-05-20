using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace System.Text.RegularExpressions;

/// <summary>Represents the set of successful matches found by iteratively applying a regular expression pattern to the input string.</summary>
[Serializable]
[DebuggerTypeProxy(typeof(CollectionDebuggerProxy<Match>))]
[DebuggerDisplay("Count = {Count}")]
public class MatchCollection : IList<Match>, ICollection<Match>, IEnumerable<Match>, IEnumerable, IReadOnlyList<Match>, IReadOnlyCollection<Match>, IList, ICollection
{
	[Serializable]
	private sealed class Enumerator : IEnumerator<Match>, IDisposable, IEnumerator
	{
		private readonly MatchCollection _collection;

		private int _index;

		public Match Current => null;

		object IEnumerator.Current => null;

		internal Enumerator(MatchCollection collection)
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		void IEnumerator.Reset()
		{
		}

		void IDisposable.Dispose()
		{
		}
	}

	private readonly Regex _regex;

	private readonly List<Match> _matches;

	private bool _done;

	private readonly string _input;

	private readonly int _beginning;

	private readonly int _length;

	private int _startat;

	private int _prevlen;

	/// <summary>Gets a value that indicates whether the collection is read only.</summary>
	/// <returns>
	///   <see langword="true" /> in all cases.</returns>
	public bool IsReadOnly => false;

	/// <summary>Gets the number of matches.</summary>
	/// <returns>The number of matches.</returns>
	/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred.</exception>
	public int Count => 0;

	/// <summary>Gets an individual member of the collection.</summary>
	/// <param name="i">Index into the <see cref="T:System.Text.RegularExpressions.Match" /> collection.</param>
	/// <returns>The captured substring at position <paramref name="i" /> in the collection.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="i" /> is less than 0 or greater than or equal to <see cref="P:System.Text.RegularExpressions.MatchCollection.Count" />.</exception>
	/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred.</exception>
	public virtual Match this[int i] => null;

	/// <summary>Gets a value indicating whether access to the collection is synchronized (thread-safe).</summary>
	/// <returns>
	///   <see langword="false" /> in all cases.</returns>
	public bool IsSynchronized => false;

	/// <summary>Gets an object that can be used to synchronize access to the collection.</summary>
	/// <returns>An object that can be used to synchronize access to the collection. This property always returns the object itself.</returns>
	public object SyncRoot => null;

	Match IList<Match>.this[int index]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	bool IList.IsFixedSize => false;

	object IList.this[int index]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal MatchCollection(Regex regex, string input, int beginning, int length, int startat)
	{
	}

	/// <summary>Provides an enumerator that iterates through the collection.</summary>
	/// <returns>An object that contains all <see cref="T:System.Text.RegularExpressions.Match" /> objects within the <see cref="T:System.Text.RegularExpressions.MatchCollection" />.</returns>
	/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred.</exception>
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	IEnumerator<Match> IEnumerable<Match>.GetEnumerator()
	{
		return null;
	}

	private Match GetMatch(int i)
	{
		return null;
	}

	private void EnsureInitialized()
	{
	}

	/// <summary>Copies all the elements of the collection to the given array starting at the given index.</summary>
	/// <param name="array">The array the collection is to be copied into.</param>
	/// <param name="arrayIndex">The position in the array where copying is to begin.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="array" /> is a multi-dimensional array.</exception>
	/// <exception cref="T:System.IndexOutOfRangeException">
	///   <paramref name="arrayIndex" /> is outside the bounds of <paramref name="array" />.  
	/// -or-  
	/// <paramref name="arrayIndex" /> plus <see cref="P:System.Text.RegularExpressions.MatchCollection.Count" /> is outside the bounds of <paramref name="array" />.</exception>
	/// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred.</exception>
	public void CopyTo(Array array, int arrayIndex)
	{
	}

	public void CopyTo(Match[] array, int arrayIndex)
	{
	}

	int IList<Match>.IndexOf(Match item)
	{
		return 0;
	}

	void IList<Match>.Insert(int index, Match item)
	{
	}

	void IList<Match>.RemoveAt(int index)
	{
	}

	void ICollection<Match>.Add(Match item)
	{
	}

	void ICollection<Match>.Clear()
	{
	}

	bool ICollection<Match>.Contains(Match item)
	{
		return false;
	}

	bool ICollection<Match>.Remove(Match item)
	{
		return false;
	}

	int IList.Add(object value)
	{
		return 0;
	}

	void IList.Clear()
	{
	}

	bool IList.Contains(object value)
	{
		return false;
	}

	int IList.IndexOf(object value)
	{
		return 0;
	}

	void IList.Insert(int index, object value)
	{
	}

	void IList.Remove(object value)
	{
	}

	void IList.RemoveAt(int index)
	{
	}

	internal MatchCollection()
	{
	}
}
