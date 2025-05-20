using System.Diagnostics;

namespace System.Collections;

/// <summary>Implements the <see cref="T:System.Collections.IList" /> interface using an array whose size is dynamically increased as required.</summary>
[Serializable]
[DebuggerTypeProxy(typeof(ArrayListDebugView))]
[DebuggerDisplay("Count = {Count}")]
public class ArrayList : IList, ICollection, IEnumerable, ICloneable
{
	[Serializable]
	private class IListWrapper : ArrayList
	{
		private IList _list;

		public override int Capacity
		{
			set
			{
			}
		}

		public override int Count => 0;

		public override bool IsReadOnly => false;

		public override bool IsFixedSize => false;

		public override bool IsSynchronized => false;

		public override object this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override object SyncRoot => null;

		internal IListWrapper(IList list)
			: base(trash: false)
		{
		}

		public override int Add(object obj)
		{
			return 0;
		}

		public override void AddRange(ICollection c)
		{
		}

		public override int BinarySearch(int index, int count, object value, IComparer comparer)
		{
			return 0;
		}

		public override void Clear()
		{
		}

		public override object Clone()
		{
			return null;
		}

		public override bool Contains(object obj)
		{
			return false;
		}

		public override void CopyTo(Array array, int index)
		{
		}

		public override void CopyTo(int index, Array array, int arrayIndex, int count)
		{
		}

		public override IEnumerator GetEnumerator()
		{
			return null;
		}

		public override int IndexOf(object value)
		{
			return 0;
		}

		public override void Insert(int index, object obj)
		{
		}

		public override void InsertRange(int index, ICollection c)
		{
		}

		public override void Remove(object value)
		{
		}

		public override void RemoveAt(int index)
		{
		}

		public override void RemoveRange(int index, int count)
		{
		}

		public override void Sort(int index, int count, IComparer comparer)
		{
		}

		public override object[] ToArray()
		{
			return null;
		}

		public override Array ToArray(Type type)
		{
			return null;
		}
	}

	[Serializable]
	private class SyncArrayList : ArrayList
	{
		private ArrayList _list;

		private object _root;

		public override int Capacity
		{
			set
			{
			}
		}

		public override int Count => 0;

		public override bool IsReadOnly => false;

		public override bool IsFixedSize => false;

		public override bool IsSynchronized => false;

		public override object this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override object SyncRoot => null;

		internal SyncArrayList(ArrayList list)
			: base(trash: false)
		{
		}

		public override int Add(object value)
		{
			return 0;
		}

		public override void AddRange(ICollection c)
		{
		}

		public override int BinarySearch(object value)
		{
			return 0;
		}

		public override int BinarySearch(int index, int count, object value, IComparer comparer)
		{
			return 0;
		}

		public override void Clear()
		{
		}

		public override object Clone()
		{
			return null;
		}

		public override bool Contains(object item)
		{
			return false;
		}

		public override void CopyTo(Array array)
		{
		}

		public override void CopyTo(Array array, int index)
		{
		}

		public override void CopyTo(int index, Array array, int arrayIndex, int count)
		{
		}

		public override IEnumerator GetEnumerator()
		{
			return null;
		}

		public override int IndexOf(object value)
		{
			return 0;
		}

		public override void Insert(int index, object value)
		{
		}

		public override void InsertRange(int index, ICollection c)
		{
		}

		public override void Remove(object value)
		{
		}

		public override void RemoveAt(int index)
		{
		}

		public override void RemoveRange(int index, int count)
		{
		}

		public override void Sort()
		{
		}

		public override void Sort(IComparer comparer)
		{
		}

		public override void Sort(int index, int count, IComparer comparer)
		{
		}

		public override object[] ToArray()
		{
			return null;
		}

		public override Array ToArray(Type type)
		{
			return null;
		}
	}

	[Serializable]
	private class ReadOnlyArrayList : ArrayList
	{
		private ArrayList _list;

		public override int Count => 0;

		public override bool IsReadOnly => false;

		public override bool IsFixedSize => false;

		public override bool IsSynchronized => false;

		public override object this[int index]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override object SyncRoot => null;

		public override int Capacity
		{
			set
			{
			}
		}

		internal ReadOnlyArrayList(ArrayList l)
			: base(trash: false)
		{
		}

		public override int Add(object obj)
		{
			return 0;
		}

		public override void AddRange(ICollection c)
		{
		}

		public override int BinarySearch(int index, int count, object value, IComparer comparer)
		{
			return 0;
		}

		public override void Clear()
		{
		}

		public override object Clone()
		{
			return null;
		}

		public override bool Contains(object obj)
		{
			return false;
		}

		public override void CopyTo(Array array, int index)
		{
		}

		public override void CopyTo(int index, Array array, int arrayIndex, int count)
		{
		}

		public override IEnumerator GetEnumerator()
		{
			return null;
		}

		public override int IndexOf(object value)
		{
			return 0;
		}

		public override void Insert(int index, object obj)
		{
		}

		public override void InsertRange(int index, ICollection c)
		{
		}

		public override void Remove(object value)
		{
		}

		public override void RemoveAt(int index)
		{
		}

		public override void RemoveRange(int index, int count)
		{
		}

		public override void Sort(int index, int count, IComparer comparer)
		{
		}

		public override object[] ToArray()
		{
			return null;
		}

		public override Array ToArray(Type type)
		{
			return null;
		}
	}

	[Serializable]
	private sealed class ArrayListEnumeratorSimple : IEnumerator, ICloneable
	{
		private ArrayList _list;

		private int _index;

		private int _version;

		private object _currentElement;

		private bool _isArrayList;

		private static object s_dummyObject;

		public object Current => null;

		internal ArrayListEnumeratorSimple(ArrayList list)
		{
		}

		public object Clone()
		{
			return null;
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}
	}

	internal class ArrayListDebugView
	{
	}

	private object[] _items;

	private int _size;

	private int _version;

	[NonSerialized]
	private object _syncRoot;

	/// <summary>Gets or sets the number of elements that the <see cref="T:System.Collections.ArrayList" /> can contain.</summary>
	/// <returns>The number of elements that the <see cref="T:System.Collections.ArrayList" /> can contain.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <see cref="P:System.Collections.ArrayList.Capacity" /> is set to a value that is less than <see cref="P:System.Collections.ArrayList.Count" />.</exception>
	/// <exception cref="T:System.OutOfMemoryException">There is not enough memory available on the system.</exception>
	public virtual int Capacity
	{
		set
		{
		}
	}

	/// <summary>Gets the number of elements actually contained in the <see cref="T:System.Collections.ArrayList" />.</summary>
	/// <returns>The number of elements actually contained in the <see cref="T:System.Collections.ArrayList" />.</returns>
	public virtual int Count => 0;

	/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.ArrayList" /> has a fixed size.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Collections.ArrayList" /> has a fixed size; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	public virtual bool IsFixedSize => false;

	/// <summary>Gets a value indicating whether the <see cref="T:System.Collections.ArrayList" /> is read-only.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Collections.ArrayList" /> is read-only; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	public virtual bool IsReadOnly => false;

	/// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.ArrayList" /> is synchronized (thread safe).</summary>
	/// <returns>
	///   <see langword="true" /> if access to the <see cref="T:System.Collections.ArrayList" /> is synchronized (thread safe); otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
	public virtual bool IsSynchronized => false;

	/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.ArrayList" />.</summary>
	/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.ArrayList" />.</returns>
	public virtual object SyncRoot => null;

	/// <summary>Gets or sets the element at the specified index.</summary>
	/// <param name="index">The zero-based index of the element to get or set.</param>
	/// <returns>The element at the specified index.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than zero.  
	/// -or-  
	/// <paramref name="index" /> is equal to or greater than <see cref="P:System.Collections.ArrayList.Count" />.</exception>
	public virtual object this[int index]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal ArrayList(bool trash)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.ArrayList" /> class that is empty and has the default initial capacity.</summary>
	public ArrayList()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.ArrayList" /> class that is empty and has the specified initial capacity.</summary>
	/// <param name="capacity">The number of elements that the new list can initially store.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="capacity" /> is less than zero.</exception>
	public ArrayList(int capacity)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.ArrayList" /> class that contains elements copied from the specified collection and that has the same initial capacity as the number of elements copied.</summary>
	/// <param name="c">The <see cref="T:System.Collections.ICollection" /> whose elements are copied to the new list.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="c" /> is <see langword="null" />.</exception>
	public ArrayList(ICollection c)
	{
	}

	/// <summary>Creates an <see cref="T:System.Collections.ArrayList" /> wrapper for a specific <see cref="T:System.Collections.IList" />.</summary>
	/// <param name="list">The <see cref="T:System.Collections.IList" /> to wrap.</param>
	/// <returns>The <see cref="T:System.Collections.ArrayList" /> wrapper around the <see cref="T:System.Collections.IList" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="list" /> is <see langword="null" />.</exception>
	public static ArrayList Adapter(IList list)
	{
		return null;
	}

	/// <summary>Adds an object to the end of the <see cref="T:System.Collections.ArrayList" />.</summary>
	/// <param name="value">The <see cref="T:System.Object" /> to be added to the end of the <see cref="T:System.Collections.ArrayList" />. The value can be <see langword="null" />.</param>
	/// <returns>The <see cref="T:System.Collections.ArrayList" /> index at which the <paramref name="value" /> has been added.</returns>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.ArrayList" /> is read-only.  
	///  -or-  
	///  The <see cref="T:System.Collections.ArrayList" /> has a fixed size.</exception>
	public virtual int Add(object value)
	{
		return 0;
	}

	/// <summary>Adds the elements of an <see cref="T:System.Collections.ICollection" /> to the end of the <see cref="T:System.Collections.ArrayList" />.</summary>
	/// <param name="c">The <see cref="T:System.Collections.ICollection" /> whose elements should be added to the end of the <see cref="T:System.Collections.ArrayList" />. The collection itself cannot be <see langword="null" />, but it can contain elements that are <see langword="null" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="c" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.ArrayList" /> is read-only.  
	///  -or-  
	///  The <see cref="T:System.Collections.ArrayList" /> has a fixed size.</exception>
	public virtual void AddRange(ICollection c)
	{
	}

	/// <summary>Searches a range of elements in the sorted <see cref="T:System.Collections.ArrayList" /> for an element using the specified comparer and returns the zero-based index of the element.</summary>
	/// <param name="index">The zero-based starting index of the range to search.</param>
	/// <param name="count">The length of the range to search.</param>
	/// <param name="value">The <see cref="T:System.Object" /> to locate. The value can be <see langword="null" />.</param>
	/// <param name="comparer">The <see cref="T:System.Collections.IComparer" /> implementation to use when comparing elements.  
	///  -or-  
	///  <see langword="null" /> to use the default comparer that is the <see cref="T:System.IComparable" /> implementation of each element.</param>
	/// <returns>The zero-based index of <paramref name="value" /> in the sorted <see cref="T:System.Collections.ArrayList" />, if <paramref name="value" /> is found; otherwise, a negative number, which is the bitwise complement of the index of the next element that is larger than <paramref name="value" /> or, if there is no larger element, the bitwise complement of <see cref="P:System.Collections.ArrayList.Count" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="index" /> and <paramref name="count" /> do not denote a valid range in the <see cref="T:System.Collections.ArrayList" />.  
	/// -or-  
	/// <paramref name="comparer" /> is <see langword="null" /> and neither <paramref name="value" /> nor the elements of <see cref="T:System.Collections.ArrayList" /> implement the <see cref="T:System.IComparable" /> interface.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <paramref name="comparer" /> is <see langword="null" /> and <paramref name="value" /> is not of the same type as the elements of the <see cref="T:System.Collections.ArrayList" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than zero.  
	/// -or-  
	/// <paramref name="count" /> is less than zero.</exception>
	public virtual int BinarySearch(int index, int count, object value, IComparer comparer)
	{
		return 0;
	}

	/// <summary>Searches the entire sorted <see cref="T:System.Collections.ArrayList" /> for an element using the default comparer and returns the zero-based index of the element.</summary>
	/// <param name="value">The <see cref="T:System.Object" /> to locate. The value can be <see langword="null" />.</param>
	/// <returns>The zero-based index of <paramref name="value" /> in the sorted <see cref="T:System.Collections.ArrayList" />, if <paramref name="value" /> is found; otherwise, a negative number, which is the bitwise complement of the index of the next element that is larger than <paramref name="value" /> or, if there is no larger element, the bitwise complement of <see cref="P:System.Collections.ArrayList.Count" />.</returns>
	/// <exception cref="T:System.ArgumentException">Neither <paramref name="value" /> nor the elements of <see cref="T:System.Collections.ArrayList" /> implement the <see cref="T:System.IComparable" /> interface.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <paramref name="value" /> is not of the same type as the elements of the <see cref="T:System.Collections.ArrayList" />.</exception>
	public virtual int BinarySearch(object value)
	{
		return 0;
	}

	/// <summary>Removes all elements from the <see cref="T:System.Collections.ArrayList" />.</summary>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.ArrayList" /> is read-only.  
	///  -or-  
	///  The <see cref="T:System.Collections.ArrayList" /> has a fixed size.</exception>
	public virtual void Clear()
	{
	}

	/// <summary>Creates a shallow copy of the <see cref="T:System.Collections.ArrayList" />.</summary>
	/// <returns>A shallow copy of the <see cref="T:System.Collections.ArrayList" />.</returns>
	public virtual object Clone()
	{
		return null;
	}

	/// <summary>Determines whether an element is in the <see cref="T:System.Collections.ArrayList" />.</summary>
	/// <param name="item">The <see cref="T:System.Object" /> to locate in the <see cref="T:System.Collections.ArrayList" />. The value can be <see langword="null" />.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="item" /> is found in the <see cref="T:System.Collections.ArrayList" />; otherwise, <see langword="false" />.</returns>
	public virtual bool Contains(object item)
	{
		return false;
	}

	/// <summary>Copies the entire <see cref="T:System.Collections.ArrayList" /> to a compatible one-dimensional <see cref="T:System.Array" />, starting at the beginning of the target array.</summary>
	/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.ArrayList" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="array" /> is multidimensional.  
	/// -or-  
	/// The number of elements in the source <see cref="T:System.Collections.ArrayList" /> is greater than the number of elements that the destination <paramref name="array" /> can contain.</exception>
	/// <exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.ArrayList" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception>
	public virtual void CopyTo(Array array)
	{
	}

	/// <summary>Copies the entire <see cref="T:System.Collections.ArrayList" /> to a compatible one-dimensional <see cref="T:System.Array" />, starting at the specified index of the target array.</summary>
	/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.ArrayList" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
	/// <param name="arrayIndex">The zero-based index in <paramref name="array" /> at which copying begins.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="arrayIndex" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="array" /> is multidimensional.  
	/// -or-  
	/// The number of elements in the source <see cref="T:System.Collections.ArrayList" /> is greater than the available space from <paramref name="arrayIndex" /> to the end of the destination <paramref name="array" />.</exception>
	/// <exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.ArrayList" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception>
	public virtual void CopyTo(Array array, int arrayIndex)
	{
	}

	/// <summary>Copies a range of elements from the <see cref="T:System.Collections.ArrayList" /> to a compatible one-dimensional <see cref="T:System.Array" />, starting at the specified index of the target array.</summary>
	/// <param name="index">The zero-based index in the source <see cref="T:System.Collections.ArrayList" /> at which copying begins.</param>
	/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.ArrayList" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
	/// <param name="arrayIndex">The zero-based index in <paramref name="array" /> at which copying begins.</param>
	/// <param name="count">The number of elements to copy.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than zero.  
	/// -or-  
	/// <paramref name="arrayIndex" /> is less than zero.  
	/// -or-  
	/// <paramref name="count" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="array" /> is multidimensional.  
	/// -or-  
	/// <paramref name="index" /> is equal to or greater than the <see cref="P:System.Collections.ArrayList.Count" /> of the source <see cref="T:System.Collections.ArrayList" />.  
	/// -or-  
	/// The number of elements from <paramref name="index" /> to the end of the source <see cref="T:System.Collections.ArrayList" /> is greater than the available space from <paramref name="arrayIndex" /> to the end of the destination <paramref name="array" />.</exception>
	/// <exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.ArrayList" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception>
	public virtual void CopyTo(int index, Array array, int arrayIndex, int count)
	{
	}

	private void EnsureCapacity(int min)
	{
	}

	/// <summary>Returns an enumerator for the entire <see cref="T:System.Collections.ArrayList" />.</summary>
	/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for the entire <see cref="T:System.Collections.ArrayList" />.</returns>
	public virtual IEnumerator GetEnumerator()
	{
		return null;
	}

	/// <summary>Searches for the specified <see cref="T:System.Object" /> and returns the zero-based index of the first occurrence within the entire <see cref="T:System.Collections.ArrayList" />.</summary>
	/// <param name="value">The <see cref="T:System.Object" /> to locate in the <see cref="T:System.Collections.ArrayList" />. The value can be <see langword="null" />.</param>
	/// <returns>The zero-based index of the first occurrence of <paramref name="value" /> within the entire <see cref="T:System.Collections.ArrayList" />, if found; otherwise, -1.</returns>
	public virtual int IndexOf(object value)
	{
		return 0;
	}

	/// <summary>Inserts an element into the <see cref="T:System.Collections.ArrayList" /> at the specified index.</summary>
	/// <param name="index">The zero-based index at which <paramref name="value" /> should be inserted.</param>
	/// <param name="value">The <see cref="T:System.Object" /> to insert. The value can be <see langword="null" />.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than zero.  
	/// -or-  
	/// <paramref name="index" /> is greater than <see cref="P:System.Collections.ArrayList.Count" />.</exception>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.ArrayList" /> is read-only.  
	///  -or-  
	///  The <see cref="T:System.Collections.ArrayList" /> has a fixed size.</exception>
	public virtual void Insert(int index, object value)
	{
	}

	/// <summary>Inserts the elements of a collection into the <see cref="T:System.Collections.ArrayList" /> at the specified index.</summary>
	/// <param name="index">The zero-based index at which the new elements should be inserted.</param>
	/// <param name="c">The <see cref="T:System.Collections.ICollection" /> whose elements should be inserted into the <see cref="T:System.Collections.ArrayList" />. The collection itself cannot be <see langword="null" />, but it can contain elements that are <see langword="null" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="c" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than zero.  
	/// -or-  
	/// <paramref name="index" /> is greater than <see cref="P:System.Collections.ArrayList.Count" />.</exception>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.ArrayList" /> is read-only.  
	///  -or-  
	///  The <see cref="T:System.Collections.ArrayList" /> has a fixed size.</exception>
	public virtual void InsertRange(int index, ICollection c)
	{
	}

	/// <summary>Returns a read-only <see cref="T:System.Collections.ArrayList" /> wrapper.</summary>
	/// <param name="list">The <see cref="T:System.Collections.ArrayList" /> to wrap.</param>
	/// <returns>A read-only <see cref="T:System.Collections.ArrayList" /> wrapper around <paramref name="list" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="list" /> is <see langword="null" />.</exception>
	public static ArrayList ReadOnly(ArrayList list)
	{
		return null;
	}

	/// <summary>Removes the first occurrence of a specific object from the <see cref="T:System.Collections.ArrayList" />.</summary>
	/// <param name="obj">The <see cref="T:System.Object" /> to remove from the <see cref="T:System.Collections.ArrayList" />. The value can be <see langword="null" />.</param>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.ArrayList" /> is read-only.  
	///  -or-  
	///  The <see cref="T:System.Collections.ArrayList" /> has a fixed size.</exception>
	public virtual void Remove(object obj)
	{
	}

	/// <summary>Removes the element at the specified index of the <see cref="T:System.Collections.ArrayList" />.</summary>
	/// <param name="index">The zero-based index of the element to remove.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than zero.  
	/// -or-  
	/// <paramref name="index" /> is equal to or greater than <see cref="P:System.Collections.ArrayList.Count" />.</exception>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.ArrayList" /> is read-only.  
	///  -or-  
	///  The <see cref="T:System.Collections.ArrayList" /> has a fixed size.</exception>
	public virtual void RemoveAt(int index)
	{
	}

	/// <summary>Removes a range of elements from the <see cref="T:System.Collections.ArrayList" />.</summary>
	/// <param name="index">The zero-based starting index of the range of elements to remove.</param>
	/// <param name="count">The number of elements to remove.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than zero.  
	/// -or-  
	/// <paramref name="count" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="index" /> and <paramref name="count" /> do not denote a valid range of elements in the <see cref="T:System.Collections.ArrayList" />.</exception>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.ArrayList" /> is read-only.  
	///  -or-  
	///  The <see cref="T:System.Collections.ArrayList" /> has a fixed size.</exception>
	public virtual void RemoveRange(int index, int count)
	{
	}

	/// <summary>Sorts the elements in the entire <see cref="T:System.Collections.ArrayList" />.</summary>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.ArrayList" /> is read-only.</exception>
	public virtual void Sort()
	{
	}

	/// <summary>Sorts the elements in the entire <see cref="T:System.Collections.ArrayList" /> using the specified comparer.</summary>
	/// <param name="comparer">The <see cref="T:System.Collections.IComparer" /> implementation to use when comparing elements.  
	///  -or-  
	///  A null reference (<see langword="Nothing" /> in Visual Basic) to use the <see cref="T:System.IComparable" /> implementation of each element.</param>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.ArrayList" /> is read-only.</exception>
	/// <exception cref="T:System.InvalidOperationException">An error occurred while comparing two elements.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <see langword="null" /> is passed for <paramref name="comparer" />, and the elements in the list do not implement <see cref="T:System.IComparable" />.</exception>
	public virtual void Sort(IComparer comparer)
	{
	}

	/// <summary>Sorts the elements in a range of elements in <see cref="T:System.Collections.ArrayList" /> using the specified comparer.</summary>
	/// <param name="index">The zero-based starting index of the range to sort.</param>
	/// <param name="count">The length of the range to sort.</param>
	/// <param name="comparer">The <see cref="T:System.Collections.IComparer" /> implementation to use when comparing elements.  
	///  -or-  
	///  A null reference (<see langword="Nothing" /> in Visual Basic) to use the <see cref="T:System.IComparable" /> implementation of each element.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than zero.  
	/// -or-  
	/// <paramref name="count" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="index" /> and <paramref name="count" /> do not specify a valid range in the <see cref="T:System.Collections.ArrayList" />.</exception>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.ArrayList" /> is read-only.</exception>
	/// <exception cref="T:System.InvalidOperationException">An error occurred while comparing two elements.</exception>
	public virtual void Sort(int index, int count, IComparer comparer)
	{
	}

	/// <summary>Returns an <see cref="T:System.Collections.ArrayList" /> wrapper that is synchronized (thread safe).</summary>
	/// <param name="list">The <see cref="T:System.Collections.ArrayList" /> to synchronize.</param>
	/// <returns>An <see cref="T:System.Collections.ArrayList" /> wrapper that is synchronized (thread safe).</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="list" /> is <see langword="null" />.</exception>
	public static ArrayList Synchronized(ArrayList list)
	{
		return null;
	}

	/// <summary>Copies the elements of the <see cref="T:System.Collections.ArrayList" /> to a new <see cref="T:System.Object" /> array.</summary>
	/// <returns>An <see cref="T:System.Object" /> array containing copies of the elements of the <see cref="T:System.Collections.ArrayList" />.</returns>
	public virtual object[] ToArray()
	{
		return null;
	}

	/// <summary>Copies the elements of the <see cref="T:System.Collections.ArrayList" /> to a new array of the specified element type.</summary>
	/// <param name="type">The element <see cref="T:System.Type" /> of the destination array to create and copy elements to.</param>
	/// <returns>An array of the specified element type containing copies of the elements of the <see cref="T:System.Collections.ArrayList" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="type" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.ArrayList" /> cannot be cast automatically to the specified type.</exception>
	public virtual Array ToArray(Type type)
	{
		return null;
	}
}
