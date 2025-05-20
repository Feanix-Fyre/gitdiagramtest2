using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace System.Text.RegularExpressions;

/// <summary>Returns the set of captured groups in a single match.</summary>
[Serializable]
[DebuggerTypeProxy(typeof(CollectionDebuggerProxy<Group>))]
[DebuggerDisplay("Count = {Count}")]
public class GroupCollection : IList<Group>, ICollection<Group>, IEnumerable<Group>, IEnumerable, IReadOnlyList<Group>, IReadOnlyCollection<Group>, IList, ICollection
{
	private sealed class Enumerator : IEnumerator<Group>, IDisposable, IEnumerator
	{
		private readonly GroupCollection _collection;

		private int _index;

		public Group Current => null;

		object IEnumerator.Current => null;

		internal Enumerator(GroupCollection collection)
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

	private readonly Match _match;

	private readonly Hashtable _captureMap;

	private Group[] _groups;

	/// <summary>Gets a value that indicates whether the collection is read-only.</summary>
	/// <returns>
	///   <see langword="true" /> in all cases.</returns>
	public bool IsReadOnly => false;

	/// <summary>Returns the number of groups in the collection.</summary>
	/// <returns>The number of groups in the collection.</returns>
	public int Count => 0;

	/// <summary>Enables access to a member of the collection by integer index.</summary>
	/// <param name="groupnum">The zero-based index of the collection member to be retrieved.</param>
	/// <returns>The member of the collection specified by <paramref name="groupnum" />.</returns>
	public Group this[int groupnum] => null;

	/// <summary>Gets a value that indicates whether access to the <see cref="T:System.Text.RegularExpressions.GroupCollection" /> is synchronized (thread-safe).</summary>
	/// <returns>
	///   <see langword="false" /> in all cases.</returns>
	public bool IsSynchronized => false;

	/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Text.RegularExpressions.GroupCollection" />.</summary>
	/// <returns>A copy of the <see cref="T:System.Text.RegularExpressions.Match" /> object to synchronize.</returns>
	public object SyncRoot => null;

	Group IList<Group>.this[int index]
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

	internal GroupCollection(Match match, Hashtable caps)
	{
	}

	/// <summary>Provides an enumerator that iterates through the collection.</summary>
	/// <returns>An enumerator that contains all <see cref="T:System.Text.RegularExpressions.Group" /> objects in the <see cref="T:System.Text.RegularExpressions.GroupCollection" />.</returns>
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	IEnumerator<Group> IEnumerable<Group>.GetEnumerator()
	{
		return null;
	}

	private Group GetGroup(int groupnum)
	{
		return null;
	}

	private Group GetGroupImpl(int groupnum)
	{
		return null;
	}

	/// <summary>Copies all the elements of the collection to the given array beginning at the given index.</summary>
	/// <param name="array">The array the collection is to be copied into.</param>
	/// <param name="arrayIndex">The position in the destination array where the copying is to begin.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.IndexOutOfRangeException">
	///   <paramref name="arrayIndex" /> is outside the bounds of <paramref name="array" />.  
	/// -or-  
	/// <paramref name="arrayIndex" /> plus <see cref="P:System.Text.RegularExpressions.GroupCollection.Count" /> is outside the bounds of <paramref name="array" />.</exception>
	public void CopyTo(Array array, int arrayIndex)
	{
	}

	public void CopyTo(Group[] array, int arrayIndex)
	{
	}

	int IList<Group>.IndexOf(Group item)
	{
		return 0;
	}

	void IList<Group>.Insert(int index, Group item)
	{
	}

	void IList<Group>.RemoveAt(int index)
	{
	}

	void ICollection<Group>.Add(Group item)
	{
	}

	void ICollection<Group>.Clear()
	{
	}

	bool ICollection<Group>.Contains(Group item)
	{
		return false;
	}

	bool ICollection<Group>.Remove(Group item)
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

	internal GroupCollection()
	{
	}
}
