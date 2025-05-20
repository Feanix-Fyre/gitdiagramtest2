using System.Collections;
using System.Runtime.Serialization;

namespace System.Net;

/// <summary>Provides a collection container for instances of the <see cref="T:System.Net.Cookie" /> class.</summary>
[Serializable]
public class CookieCollection : ICollection, IEnumerable
{
	internal enum Stamp
	{
		Check = 0,
		Set = 1,
		SetToUnused = 2,
		SetToMaxUsed = 3
	}

	private class CookieCollectionEnumerator : IEnumerator
	{
		private CookieCollection m_cookies;

		private int m_count;

		private int m_index;

		private int m_version;

		object IEnumerator.Current => null;

		internal CookieCollectionEnumerator(CookieCollection cookies)
		{
		}

		bool IEnumerator.MoveNext()
		{
			return false;
		}

		void IEnumerator.Reset()
		{
		}
	}

	internal int m_version;

	private ArrayList m_list;

	private DateTime m_TimeStamp;

	private bool m_has_other_versions;

	[OptionalField]
	private bool m_IsReadOnly;

	/// <summary>Gets the <see cref="T:System.Net.Cookie" /> with a specific index from a <see cref="T:System.Net.CookieCollection" />.</summary>
	/// <param name="index">The zero-based index of the <see cref="T:System.Net.Cookie" /> to be found.</param>
	/// <returns>A <see cref="T:System.Net.Cookie" /> with a specific index from a <see cref="T:System.Net.CookieCollection" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than 0 or <paramref name="index" /> is greater than or equal to <see cref="P:System.Net.CookieCollection.Count" />.</exception>
	public Cookie this[int index] => null;

	/// <summary>Gets the number of cookies contained in a <see cref="T:System.Net.CookieCollection" />.</summary>
	/// <returns>The number of cookies contained in a <see cref="T:System.Net.CookieCollection" />.</returns>
	public int Count => 0;

	/// <summary>Gets a value that indicates whether access to a <see cref="T:System.Net.CookieCollection" /> is thread safe.</summary>
	/// <returns>
	///   <see langword="true" /> if access to the <see cref="T:System.Net.CookieCollection" /> is thread safe; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	public bool IsSynchronized => false;

	/// <summary>Gets an object to synchronize access to the <see cref="T:System.Net.CookieCollection" />.</summary>
	/// <returns>An object to synchronize access to the <see cref="T:System.Net.CookieCollection" />.</returns>
	public object SyncRoot => null;

	internal bool IsOtherVersionSeen => false;

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.CookieCollection" /> class.</summary>
	public CookieCollection()
	{
	}

	/// <summary>Adds a <see cref="T:System.Net.Cookie" /> to a <see cref="T:System.Net.CookieCollection" />.</summary>
	/// <param name="cookie">The <see cref="T:System.Net.Cookie" /> to be added to a <see cref="T:System.Net.CookieCollection" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="cookie" /> is <see langword="null" />.</exception>
	public void Add(Cookie cookie)
	{
	}

	/// <summary>Adds the contents of a <see cref="T:System.Net.CookieCollection" /> to the current instance.</summary>
	/// <param name="cookies">The <see cref="T:System.Net.CookieCollection" /> to be added.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="cookies" /> is <see langword="null" />.</exception>
	public void Add(CookieCollection cookies)
	{
	}

	/// <summary>Copies the elements of a <see cref="T:System.Net.CookieCollection" /> to an instance of the <see cref="T:System.Array" /> class, starting at a particular index.</summary>
	/// <param name="array">The target <see cref="T:System.Array" /> to which the <see cref="T:System.Net.CookieCollection" /> will be copied.</param>
	/// <param name="index">The zero-based index in the target <see cref="T:System.Array" /> where copying begins.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="array" /> is multidimensional.  
	/// -or-  
	/// The number of elements in this <see cref="T:System.Net.CookieCollection" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />.</exception>
	/// <exception cref="T:System.InvalidCastException">The elements in this <see cref="T:System.Net.CookieCollection" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception>
	public void CopyTo(Array array, int index)
	{
	}

	internal DateTime TimeStamp(Stamp how)
	{
		return default(DateTime);
	}

	internal int InternalAdd(Cookie cookie, bool isStrict)
	{
		return 0;
	}

	internal int IndexOf(Cookie cookie)
	{
		return 0;
	}

	internal void RemoveAt(int idx)
	{
	}

	/// <summary>Gets an enumerator that can iterate through a <see cref="T:System.Net.CookieCollection" />.</summary>
	/// <returns>An instance of an implementation of an <see cref="T:System.Collections.IEnumerator" /> interface that can iterate through a <see cref="T:System.Net.CookieCollection" />.</returns>
	public IEnumerator GetEnumerator()
	{
		return null;
	}
}
