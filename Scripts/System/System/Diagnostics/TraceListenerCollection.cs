using System.Collections;
using System.Reflection;

namespace System.Diagnostics;

/// <summary>Provides a thread-safe list of <see cref="T:System.Diagnostics.TraceListener" /> objects.</summary>
[DefaultMember("Item")]
public class TraceListenerCollection : IList, ICollection, IEnumerable
{
	private ArrayList list;

	/// <summary>Gets the number of listeners in the list.</summary>
	/// <returns>The number of listeners in the list.</returns>
	public int Count => 0;

	/// <summary>Gets or sets the <see cref="T:System.Diagnostics.TraceListener" /> at the specified index in the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</summary>
	/// <param name="index">The zero-based index of the <paramref name="value" /> to get.</param>
	/// <returns>The <see cref="T:System.Diagnostics.TraceListener" /> at the specified index.</returns>
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

	/// <summary>Gets a value indicating whether the <see cref="T:System.Diagnostics.TraceListenerCollection" /> is read-only</summary>
	/// <returns>Always <see langword="false" />.</returns>
	bool IList.IsReadOnly => false;

	/// <summary>Gets a value indicating whether the <see cref="T:System.Diagnostics.TraceListenerCollection" /> has a fixed size.</summary>
	/// <returns>Always <see langword="false" />.</returns>
	bool IList.IsFixedSize => false;

	/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</summary>
	/// <returns>The current <see cref="T:System.Diagnostics.TraceListenerCollection" /> object.</returns>
	object ICollection.SyncRoot => null;

	/// <summary>Gets a value indicating whether access to the <see cref="T:System.Diagnostics.TraceListenerCollection" /> is synchronized (thread safe).</summary>
	/// <returns>Always <see langword="true" />.</returns>
	bool ICollection.IsSynchronized => false;

	internal TraceListenerCollection()
	{
	}

	/// <summary>Adds a <see cref="T:System.Diagnostics.TraceListener" /> to the list.</summary>
	/// <param name="listener">A <see cref="T:System.Diagnostics.TraceListener" /> to add to the list.</param>
	/// <returns>The position at which the new listener was inserted.</returns>
	public int Add(TraceListener listener)
	{
		return 0;
	}

	/// <summary>Clears all the listeners from the list.</summary>
	public void Clear()
	{
	}

	/// <summary>Gets an enumerator for this list.</summary>
	/// <returns>An enumerator of type <see cref="T:System.Collections.IEnumerator" />.</returns>
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	internal void InitializeListener(TraceListener listener)
	{
	}

	/// <summary>Removes from the collection the <see cref="T:System.Diagnostics.TraceListener" /> at the specified index.</summary>
	/// <param name="index">The zero-based index of the <see cref="T:System.Diagnostics.TraceListener" /> to remove from the list.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="index" /> is not a valid index in the list.</exception>
	public void RemoveAt(int index)
	{
	}

	/// <summary>Adds a trace listener to the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</summary>
	/// <param name="value">The object to add to the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</param>
	/// <returns>The position into which the new trace listener was inserted.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="value" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="value" /> is not a <see cref="T:System.Diagnostics.TraceListener" />.</exception>
	int IList.Add(object value)
	{
		return 0;
	}

	/// <summary>Determines whether the <see cref="T:System.Diagnostics.TraceListenerCollection" /> contains a specific object.</summary>
	/// <param name="value">The object to locate in the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</param>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Object" /> is found in the <see cref="T:System.Diagnostics.TraceListenerCollection" />; otherwise, <see langword="false" />.</returns>
	bool IList.Contains(object value)
	{
		return false;
	}

	/// <summary>Determines the index of a specific object in the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</summary>
	/// <param name="value">The object to locate in the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</param>
	/// <returns>The index of <paramref name="value" /> if found in the <see cref="T:System.Diagnostics.TraceListenerCollection" />; otherwise, -1.</returns>
	int IList.IndexOf(object value)
	{
		return 0;
	}

	/// <summary>Inserts a <see cref="T:System.Diagnostics.TraceListener" /> object at the specified position in the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</summary>
	/// <param name="index">The zero-based index at which <paramref name="value" /> should be inserted.</param>
	/// <param name="value">The <see cref="T:System.Diagnostics.TraceListener" /> object to insert into the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="value" /> is not a <see cref="T:System.Diagnostics.TraceListener" /> object.</exception>
	void IList.Insert(int index, object value)
	{
	}

	/// <summary>Removes an object from the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</summary>
	/// <param name="value">The object to remove from the <see cref="T:System.Diagnostics.TraceListenerCollection" />.</param>
	void IList.Remove(object value)
	{
	}

	/// <summary>Copies a section of the current <see cref="T:System.Diagnostics.TraceListenerCollection" /> to the specified array of <see cref="T:System.Diagnostics.TraceListener" /> objects.</summary>
	/// <param name="array">The one-dimensional array of <see cref="T:System.Diagnostics.TraceListener" /> objects that is the destination of the elements copied from the <see cref="T:System.Diagnostics.TraceListenerCollection" />. The array must have zero-based indexing.</param>
	/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
	void ICollection.CopyTo(Array array, int index)
	{
	}
}
