using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System;

/// <summary>Provides methods for creating, manipulating, searching, and sorting arrays, thereby serving as the base class for all arrays in the common language runtime.</summary>
[Serializable]
public abstract class Array : ICollection, IEnumerable, IList, IStructuralComparable, IStructuralEquatable, ICloneable
{
	private sealed class ArrayEnumerator : IEnumerator, ICloneable
	{
		private Array _array;

		private int _index;

		private int _endIndex;

		public object Current => null;

		internal ArrayEnumerator(Array array)
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}

		public object Clone()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)0)]
	private class RawData
	{
		public IntPtr Bounds;

		public IntPtr Count;

		public byte Data;
	}

	internal struct InternalEnumerator<T> : IEnumerator<T>, IDisposable, IEnumerator
	{
		private readonly Array array;

		private int idx;

		public T Current => default(T);

		object IEnumerator.Current => null;

		internal InternalEnumerator(Array array)
		{
			this.array = null;
			idx = 0;
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		void IEnumerator.Reset()
		{
		}
	}

	internal class EmptyInternalEnumerator<T> : IEnumerator<T>, IDisposable, IEnumerator
	{
		public static readonly EmptyInternalEnumerator<T> Value;

		public T Current => default(T);

		object IEnumerator.Current => null;

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		void IEnumerator.Reset()
		{
		}
	}

	private struct SorterObjectArray
	{
		private object[] keys;

		private object[] items;

		private IComparer comparer;

		internal SorterObjectArray(object[] keys, object[] items, IComparer comparer)
		{
			this.keys = null;
			this.items = null;
			this.comparer = null;
		}

		internal void SwapIfGreaterWithItems(int a, int b)
		{
		}

		private void Swap(int i, int j)
		{
		}

		internal void Sort(int left, int length)
		{
		}

		private void IntrospectiveSort(int left, int length)
		{
		}

		private void IntroSort(int lo, int hi, int depthLimit)
		{
		}

		private int PickPivotAndPartition(int lo, int hi)
		{
			return 0;
		}

		private void Heapsort(int lo, int hi)
		{
		}

		private void DownHeap(int i, int n, int lo)
		{
		}

		private void InsertionSort(int lo, int hi)
		{
		}
	}

	private struct SorterGenericArray
	{
		private Array keys;

		private Array items;

		private IComparer comparer;

		internal SorterGenericArray(Array keys, Array items, IComparer comparer)
		{
			this.keys = null;
			this.items = null;
			this.comparer = null;
		}

		internal void SwapIfGreaterWithItems(int a, int b)
		{
		}

		private void Swap(int i, int j)
		{
		}

		internal void Sort(int left, int length)
		{
		}

		private void IntrospectiveSort(int left, int length)
		{
		}

		private void IntroSort(int lo, int hi, int depthLimit)
		{
		}

		private int PickPivotAndPartition(int lo, int hi)
		{
			return 0;
		}

		private void Heapsort(int lo, int hi)
		{
		}

		private void DownHeap(int i, int n, int lo)
		{
		}

		private void InsertionSort(int lo, int hi)
		{
		}
	}

	/// <summary>Gets the number of elements contained in the <see cref="T:System.Array" />.</summary>
	/// <returns>The number of elements contained in the collection.</returns>
	int ICollection.Count => 0;

	bool IList.IsReadOnly => false;

	/// <summary>Gets or sets the element at the specified index.</summary>
	/// <param name="index">The index of the element to get or set.</param>
	/// <returns>The element at the specified index.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than zero.  
	/// -or-  
	/// <paramref name="index" /> is equal to or greater than <see cref="P:System.Collections.ICollection.Count" />.</exception>
	/// <exception cref="T:System.ArgumentException">The current <see cref="T:System.Array" /> does not have exactly one dimension.</exception>
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

	/// <summary>Gets a 64-bit integer that represents the total number of elements in all the dimensions of the <see cref="T:System.Array" />.</summary>
	/// <returns>A 64-bit integer that represents the total number of elements in all the dimensions of the <see cref="T:System.Array" />.</returns>
	public long LongLength => 0L;

	/// <summary>Gets a value indicating whether the <see cref="T:System.Array" /> has a fixed size.</summary>
	/// <returns>This property is always <see langword="true" /> for all arrays.</returns>
	public bool IsFixedSize => false;

	/// <summary>Gets a value indicating whether the <see cref="T:System.Array" /> is read-only.</summary>
	/// <returns>This property is always <see langword="false" /> for all arrays.</returns>
	public bool IsReadOnly => false;

	/// <summary>Gets a value indicating whether access to the <see cref="T:System.Array" /> is synchronized (thread safe).</summary>
	/// <returns>This property is always <see langword="false" /> for all arrays.</returns>
	public bool IsSynchronized => false;

	/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Array" />.</summary>
	/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Array" />.</returns>
	public object SyncRoot => null;

	/// <summary>Gets the total number of elements in all the dimensions of the <see cref="T:System.Array" />.</summary>
	/// <returns>The total number of elements in all the dimensions of the <see cref="T:System.Array" />; zero if there are no elements in the array.</returns>
	/// <exception cref="T:System.OverflowException">The array is multidimensional and contains more than <see cref="F:System.Int32.MaxValue" /> elements.</exception>
	public int Length
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return 0;
		}
	}

	/// <summary>Gets the rank (number of dimensions) of the <see cref="T:System.Array" />. For example, a one-dimensional array returns 1, a two-dimensional array returns 2, and so on.</summary>
	/// <returns>The rank (number of dimensions) of the <see cref="T:System.Array" />.</returns>
	public int Rank
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return 0;
		}
	}

	/// <summary>Creates a multidimensional <see cref="T:System.Array" /> of the specified <see cref="T:System.Type" /> and dimension lengths, with zero-based indexing. The dimension lengths are specified in an array of 64-bit integers.</summary>
	/// <param name="elementType">The <see cref="T:System.Type" /> of the <see cref="T:System.Array" /> to create.</param>
	/// <param name="lengths">An array of 64-bit integers that represent the size of each dimension of the <see cref="T:System.Array" /> to create. Each integer in the array must be between zero and <see cref="F:System.Int32.MaxValue" />, inclusive.</param>
	/// <returns>A new multidimensional <see cref="T:System.Array" /> of the specified <see cref="T:System.Type" /> with the specified length for each dimension, using zero-based indexing.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="elementType" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="lengths" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="elementType" /> is not a valid <see cref="T:System.Type" />.  
	/// -or-  
	/// The <paramref name="lengths" /> array contains less than one element.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="elementType" /> is not supported. For example, <see cref="T:System.Void" /> is not supported.  
	/// -or-  
	/// <paramref name="elementType" /> is an open generic type.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Any value in <paramref name="lengths" /> is less than zero or greater than <see cref="F:System.Int32.MaxValue" />.</exception>
	public static Array CreateInstance(Type elementType, params long[] lengths)
	{
		return null;
	}

	/// <summary>Returns a read-only wrapper for the specified array.</summary>
	/// <param name="array">The one-dimensional, zero-based array to wrap in a read-only <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> wrapper.</param>
	/// <typeparam name="T">The type of the elements of the array.</typeparam>
	/// <returns>A read-only <see cref="T:System.Collections.ObjectModel.ReadOnlyCollection`1" /> wrapper for the specified array.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	public static ReadOnlyCollection<T> AsReadOnly<T>(T[] array)
	{
		return null;
	}

	/// <summary>Changes the number of elements of a one-dimensional array to the specified new size.</summary>
	/// <param name="array">The one-dimensional, zero-based array to resize, or <see langword="null" /> to create a new array with the specified size.</param>
	/// <param name="newSize">The size of the new array.</param>
	/// <typeparam name="T">The type of the elements of the array.</typeparam>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="newSize" /> is less than zero.</exception>
	public static void Resize<T>(ref T[] array, int newSize)
	{
	}

	/// <summary>Calling this method always throws a <see cref="T:System.NotSupportedException" /> exception.</summary>
	/// <param name="value">The object to be added to the <see cref="T:System.Collections.IList" />.</param>
	/// <returns>Adding a value to an array is not supported. No value is returned.</returns>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.IList" /> has a fixed size.</exception>
	int IList.Add(object value)
	{
		return 0;
	}

	/// <summary>Determines whether an element is in the <see cref="T:System.Collections.IList" />.</summary>
	/// <param name="value">The object to locate in the current list. The element to locate can be <see langword="null" /> for reference types.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="value" /> is found in the <see cref="T:System.Collections.IList" />; otherwise, <see langword="false" />.</returns>
	bool IList.Contains(object value)
	{
		return false;
	}

	/// <summary>Removes all items from the <see cref="T:System.Collections.IList" />.</summary>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.IList" /> is read-only.</exception>
	void IList.Clear()
	{
	}

	/// <summary>Determines the index of a specific item in the <see cref="T:System.Collections.IList" />.</summary>
	/// <param name="value">The object to locate in the current list.</param>
	/// <returns>The index of value if found in the list; otherwise, -1.</returns>
	int IList.IndexOf(object value)
	{
		return 0;
	}

	/// <summary>Inserts an item to the <see cref="T:System.Collections.IList" /> at the specified index.</summary>
	/// <param name="index">The index at which <paramref name="value" /> should be inserted.</param>
	/// <param name="value">The object to insert.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is not a valid index in the <see cref="T:System.Collections.IList" />.</exception>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.IList" /> is read-only.  
	///  -or-  
	///  The <see cref="T:System.Collections.IList" /> has a fixed size.</exception>
	/// <exception cref="T:System.NullReferenceException">
	///   <paramref name="value" /> is null reference in the <see cref="T:System.Collections.IList" />.</exception>
	void IList.Insert(int index, object value)
	{
	}

	/// <summary>Removes the first occurrence of a specific object from the <see cref="T:System.Collections.IList" />.</summary>
	/// <param name="value">The object to remove from the <see cref="T:System.Collections.IList" />.</param>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.IList" /> is read-only.  
	///  -or-  
	///  The <see cref="T:System.Collections.IList" /> has a fixed size.</exception>
	void IList.Remove(object value)
	{
	}

	/// <summary>Removes the <see cref="T:System.Collections.IList" /> item at the specified index.</summary>
	/// <param name="index">The index of the element to remove.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">index is not a valid index in the <see cref="T:System.Collections.IList" />.</exception>
	/// <exception cref="T:System.NotSupportedException">The <see cref="T:System.Collections.IList" /> is read-only.  
	///  -or-  
	///  The <see cref="T:System.Collections.IList" /> has a fixed size.</exception>
	void IList.RemoveAt(int index)
	{
	}

	/// <summary>Copies all the elements of the current one-dimensional array to the specified one-dimensional array starting at the specified destination array index. The index is specified as a 32-bit integer.</summary>
	/// <param name="array">The one-dimensional array that is the destination of the elements copied from the current array.</param>
	/// <param name="index">A 32-bit integer that represents the index in <paramref name="array" /> at which copying begins.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than the lower bound of <paramref name="array" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="array" /> is multidimensional.  
	/// -or-  
	/// The number of elements in the source array is greater than the available number of elements from <paramref name="index" /> to the end of the destination <paramref name="array" />.</exception>
	/// <exception cref="T:System.ArrayTypeMismatchException">The type of the source <see cref="T:System.Array" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception>
	/// <exception cref="T:System.RankException">The source array is multidimensional.</exception>
	/// <exception cref="T:System.InvalidCastException">At least one element in the source <see cref="T:System.Array" /> cannot be cast to the type of destination <paramref name="array" />.</exception>
	public void CopyTo(Array array, int index)
	{
	}

	/// <summary>Creates a shallow copy of the <see cref="T:System.Array" />.</summary>
	/// <returns>A shallow copy of the <see cref="T:System.Array" />.</returns>
	public object Clone()
	{
		return null;
	}

	/// <summary>Determines whether the current collection object precedes, occurs in the same position as, or follows another object in the sort order.</summary>
	/// <param name="other">The object to compare with the current instance.</param>
	/// <param name="comparer">An object that compares the current object and <paramref name="other" />.</param>
	/// <returns>An integer that indicates the relationship of the current collection object to other, as shown in the following table.  
	///   Return value  
	///
	///   Description  
	///
	///   -1  
	///
	///   The current instance precedes <paramref name="other" />.  
	///
	///   0  
	///
	///   The current instance and <paramref name="other" /> are equal.  
	///
	///   1  
	///
	///   The current instance follows <paramref name="other" />.</returns>
	int IStructuralComparable.CompareTo(object other, IComparer comparer)
	{
		return 0;
	}

	/// <summary>Determines whether an object is equal to the current instance.</summary>
	/// <param name="other">The object to compare with the current instance.</param>
	/// <param name="comparer">An object that determines whether the current instance and <paramref name="other" /> are equal.</param>
	/// <returns>
	///   <see langword="true" /> if the two objects are equal; otherwise, <see langword="false" />.</returns>
	bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
	{
		return false;
	}

	internal static int CombineHashCodes(int h1, int h2)
	{
		return 0;
	}

	/// <summary>Returns a hash code for the current instance.</summary>
	/// <param name="comparer">An object that computes the hash code of the current object.</param>
	/// <returns>The hash code for the current instance.</returns>
	int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
	{
		return 0;
	}

	/// <summary>Searches an entire one-dimensional sorted array for a specific element, using the <see cref="T:System.IComparable" /> interface implemented by each element of the array and by the specified object.</summary>
	/// <param name="array">The sorted one-dimensional <see cref="T:System.Array" /> to search.</param>
	/// <param name="value">The object to search for.</param>
	/// <returns>The index of the specified <paramref name="value" /> in the specified <paramref name="array" />, if <paramref name="value" /> is found; otherwise, a negative number. If <paramref name="value" /> is not found and <paramref name="value" /> is less than one or more elements in <paramref name="array" />, the negative number returned is the bitwise complement of the index of the first element that is larger than <paramref name="value" />. If <paramref name="value" /> is not found and <paramref name="value" /> is greater than all elements in <paramref name="array" />, the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted <paramref name="array" />, the return value can be incorrect and a negative number could be returned, even if <paramref name="value" /> is present in <paramref name="array" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.RankException">
	///   <paramref name="array" /> is multidimensional.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="value" /> is of a type that is not compatible with the elements of <paramref name="array" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <paramref name="value" /> does not implement the <see cref="T:System.IComparable" /> interface, and the search encounters an element that does not implement the <see cref="T:System.IComparable" /> interface.</exception>
	public static int BinarySearch(Array array, object value)
	{
		return 0;
	}

	/// <summary>Converts an array of one type to an array of another type.</summary>
	/// <param name="array">The one-dimensional, zero-based <see cref="T:System.Array" /> to convert to a target type.</param>
	/// <param name="converter">A <see cref="T:System.Converter`2" /> that converts each element from one type to another type.</param>
	/// <typeparam name="TInput">The type of the elements of the source array.</typeparam>
	/// <typeparam name="TOutput">The type of the elements of the target array.</typeparam>
	/// <returns>An array of the target type containing the converted elements from the source array.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="converter" /> is <see langword="null" />.</exception>
	public static TOutput[] ConvertAll<TInput, TOutput>(TInput[] array, Converter<TInput, TOutput> converter)
	{
		return null;
	}

	/// <summary>Copies a range of elements from an <see cref="T:System.Array" /> starting at the first element and pastes them into another <see cref="T:System.Array" /> starting at the first element. The length is specified as a 64-bit integer.</summary>
	/// <param name="sourceArray">The <see cref="T:System.Array" /> that contains the data to copy.</param>
	/// <param name="destinationArray">The <see cref="T:System.Array" /> that receives the data.</param>
	/// <param name="length">A 64-bit integer that represents the number of elements to copy. The integer must be between zero and <see cref="F:System.Int32.MaxValue" />, inclusive.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="sourceArray" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="destinationArray" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.RankException">
	///   <paramref name="sourceArray" /> and <paramref name="destinationArray" /> have different ranks.</exception>
	/// <exception cref="T:System.ArrayTypeMismatchException">
	///   <paramref name="sourceArray" /> and <paramref name="destinationArray" /> are of incompatible types.</exception>
	/// <exception cref="T:System.InvalidCastException">At least one element in <paramref name="sourceArray" /> cannot be cast to the type of <paramref name="destinationArray" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="length" /> is less than 0 or greater than <see cref="F:System.Int32.MaxValue" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="length" /> is greater than the number of elements in <paramref name="sourceArray" />.  
	/// -or-  
	/// <paramref name="length" /> is greater than the number of elements in <paramref name="destinationArray" />.</exception>
	public static void Copy(Array sourceArray, Array destinationArray, long length)
	{
	}

	/// <summary>Copies a range of elements from an <see cref="T:System.Array" /> starting at the specified source index and pastes them to another <see cref="T:System.Array" /> starting at the specified destination index. The length and the indexes are specified as 64-bit integers.</summary>
	/// <param name="sourceArray">The <see cref="T:System.Array" /> that contains the data to copy.</param>
	/// <param name="sourceIndex">A 64-bit integer that represents the index in the <paramref name="sourceArray" /> at which copying begins.</param>
	/// <param name="destinationArray">The <see cref="T:System.Array" /> that receives the data.</param>
	/// <param name="destinationIndex">A 64-bit integer that represents the index in the <paramref name="destinationArray" /> at which storing begins.</param>
	/// <param name="length">A 64-bit integer that represents the number of elements to copy. The integer must be between zero and <see cref="F:System.Int32.MaxValue" />, inclusive.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="sourceArray" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="destinationArray" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.RankException">
	///   <paramref name="sourceArray" /> and <paramref name="destinationArray" /> have different ranks.</exception>
	/// <exception cref="T:System.ArrayTypeMismatchException">
	///   <paramref name="sourceArray" /> and <paramref name="destinationArray" /> are of incompatible types.</exception>
	/// <exception cref="T:System.InvalidCastException">At least one element in <paramref name="sourceArray" /> cannot be cast to the type of <paramref name="destinationArray" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="sourceIndex" /> is outside the range of valid indexes for the <paramref name="sourceArray" />.  
	/// -or-  
	/// <paramref name="destinationIndex" /> is outside the range of valid indexes for the <paramref name="destinationArray" />.  
	/// -or-  
	/// <paramref name="length" /> is less than 0 or greater than <see cref="F:System.Int32.MaxValue" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="length" /> is greater than the number of elements from <paramref name="sourceIndex" /> to the end of <paramref name="sourceArray" />.  
	/// -or-  
	/// <paramref name="length" /> is greater than the number of elements from <paramref name="destinationIndex" /> to the end of <paramref name="destinationArray" />.</exception>
	public static void Copy(Array sourceArray, long sourceIndex, Array destinationArray, long destinationIndex, long length)
	{
	}

	/// <summary>Copies all the elements of the current one-dimensional array to the specified one-dimensional array starting at the specified destination array index. The index is specified as a 64-bit integer.</summary>
	/// <param name="array">The one-dimensional array that is the destination of the elements copied from the current array.</param>
	/// <param name="index">A 64-bit integer that represents the index in <paramref name="array" /> at which copying begins.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is outside the range of valid indexes for <paramref name="array" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="array" /> is multidimensional.  
	/// -or-  
	/// The number of elements in the source array is greater than the available number of elements from <paramref name="index" /> to the end of the destination <paramref name="array" />.</exception>
	/// <exception cref="T:System.ArrayTypeMismatchException">The type of the source <see cref="T:System.Array" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception>
	/// <exception cref="T:System.RankException">The source <see cref="T:System.Array" /> is multidimensional.</exception>
	/// <exception cref="T:System.InvalidCastException">At least one element in the source <see cref="T:System.Array" /> cannot be cast to the type of destination <paramref name="array" />.</exception>
	public void CopyTo(Array array, long index)
	{
	}

	/// <summary>Performs the specified action on each element of the specified array.</summary>
	/// <param name="array">The one-dimensional, zero-based <see cref="T:System.Array" /> on whose elements the action is to be performed.</param>
	/// <param name="action">The <see cref="T:System.Action`1" /> to perform on each element of <paramref name="array" />.</param>
	/// <typeparam name="T">The type of the elements of the array.</typeparam>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="action" /> is <see langword="null" />.</exception>
	public static void ForEach<T>(T[] array, Action<T> action)
	{
	}

	/// <summary>Gets a 64-bit integer that represents the number of elements in the specified dimension of the <see cref="T:System.Array" />.</summary>
	/// <param name="dimension">A zero-based dimension of the <see cref="T:System.Array" /> whose length needs to be determined.</param>
	/// <returns>A 64-bit integer that represents the number of elements in the specified dimension.</returns>
	/// <exception cref="T:System.IndexOutOfRangeException">
	///   <paramref name="dimension" /> is less than zero.  
	/// -or-  
	/// <paramref name="dimension" /> is equal to or greater than <see cref="P:System.Array.Rank" />.</exception>
	public long GetLongLength(int dimension)
	{
		return 0L;
	}

	/// <summary>Gets the value at the specified position in the one-dimensional <see cref="T:System.Array" />. The index is specified as a 64-bit integer.</summary>
	/// <param name="index">A 64-bit integer that represents the position of the <see cref="T:System.Array" /> element to get.</param>
	/// <returns>The value at the specified position in the one-dimensional <see cref="T:System.Array" />.</returns>
	/// <exception cref="T:System.ArgumentException">The current <see cref="T:System.Array" /> does not have exactly one dimension.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is outside the range of valid indexes for the current <see cref="T:System.Array" />.</exception>
	public object GetValue(long index)
	{
		return null;
	}

	/// <summary>Gets the value at the specified position in the two-dimensional <see cref="T:System.Array" />. The indexes are specified as 64-bit integers.</summary>
	/// <param name="index1">A 64-bit integer that represents the first-dimension index of the <see cref="T:System.Array" /> element to get.</param>
	/// <param name="index2">A 64-bit integer that represents the second-dimension index of the <see cref="T:System.Array" /> element to get.</param>
	/// <returns>The value at the specified position in the two-dimensional <see cref="T:System.Array" />.</returns>
	/// <exception cref="T:System.ArgumentException">The current <see cref="T:System.Array" /> does not have exactly two dimensions.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Either <paramref name="index1" /> or <paramref name="index2" /> is outside the range of valid indexes for the corresponding dimension of the current <see cref="T:System.Array" />.</exception>
	public object GetValue(long index1, long index2)
	{
		return null;
	}

	/// <summary>Gets the value at the specified position in the three-dimensional <see cref="T:System.Array" />. The indexes are specified as 64-bit integers.</summary>
	/// <param name="index1">A 64-bit integer that represents the first-dimension index of the <see cref="T:System.Array" /> element to get.</param>
	/// <param name="index2">A 64-bit integer that represents the second-dimension index of the <see cref="T:System.Array" /> element to get.</param>
	/// <param name="index3">A 64-bit integer that represents the third-dimension index of the <see cref="T:System.Array" /> element to get.</param>
	/// <returns>The value at the specified position in the three-dimensional <see cref="T:System.Array" />.</returns>
	/// <exception cref="T:System.ArgumentException">The current <see cref="T:System.Array" /> does not have exactly three dimensions.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index1" /> or <paramref name="index2" /> or <paramref name="index3" /> is outside the range of valid indexes for the corresponding dimension of the current <see cref="T:System.Array" />.</exception>
	public object GetValue(long index1, long index2, long index3)
	{
		return null;
	}

	/// <summary>Gets the value at the specified position in the multidimensional <see cref="T:System.Array" />. The indexes are specified as an array of 64-bit integers.</summary>
	/// <param name="indices">A one-dimensional array of 64-bit integers that represent the indexes specifying the position of the <see cref="T:System.Array" /> element to get.</param>
	/// <returns>The value at the specified position in the multidimensional <see cref="T:System.Array" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="indices" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The number of dimensions in the current <see cref="T:System.Array" /> is not equal to the number of elements in <paramref name="indices" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Any element in <paramref name="indices" /> is outside the range of valid indexes for the corresponding dimension of the current <see cref="T:System.Array" />.</exception>
	public object GetValue(params long[] indices)
	{
		return null;
	}

	/// <summary>Searches a range of elements in a one-dimensional sorted array for a value, using the <see cref="T:System.IComparable" /> interface implemented by each element of the array and by the specified value.</summary>
	/// <param name="array">The sorted one-dimensional <see cref="T:System.Array" /> to search.</param>
	/// <param name="index">The starting index of the range to search.</param>
	/// <param name="length">The length of the range to search.</param>
	/// <param name="value">The object to search for.</param>
	/// <returns>The index of the specified <paramref name="value" /> in the specified <paramref name="array" />, if <paramref name="value" /> is found; otherwise, a negative number. If <paramref name="value" /> is not found and <paramref name="value" /> is less than one or more elements in <paramref name="array" />, the negative number returned is the bitwise complement of the index of the first element that is larger than <paramref name="value" />. If <paramref name="value" /> is not found and <paramref name="value" /> is greater than all elements in <paramref name="array" />, the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted <paramref name="array" />, the return value can be incorrect and a negative number could be returned, even if <paramref name="value" /> is present in <paramref name="array" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.RankException">
	///   <paramref name="array" /> is multidimensional.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than the lower bound of <paramref name="array" />.  
	/// -or-  
	/// <paramref name="length" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="index" /> and <paramref name="length" /> do not specify a valid range in <paramref name="array" />.  
	/// -or-  
	/// <paramref name="value" /> is of a type that is not compatible with the elements of <paramref name="array" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <paramref name="value" /> does not implement the <see cref="T:System.IComparable" /> interface, and the search encounters an element that does not implement the <see cref="T:System.IComparable" /> interface.</exception>
	public static int BinarySearch(Array array, int index, int length, object value)
	{
		return 0;
	}

	/// <summary>Searches an entire one-dimensional sorted array for a value using the specified <see cref="T:System.Collections.IComparer" /> interface.</summary>
	/// <param name="array">The sorted one-dimensional <see cref="T:System.Array" /> to search.</param>
	/// <param name="value">The object to search for.</param>
	/// <param name="comparer">The <see cref="T:System.Collections.IComparer" /> implementation to use when comparing elements.  
	///  -or-  
	///  <see langword="null" /> to use the <see cref="T:System.IComparable" /> implementation of each element.</param>
	/// <returns>The index of the specified <paramref name="value" /> in the specified <paramref name="array" />, if <paramref name="value" /> is found; otherwise, a negative number. If <paramref name="value" /> is not found and <paramref name="value" /> is less than one or more elements in <paramref name="array" />, the negative number returned is the bitwise complement of the index of the first element that is larger than <paramref name="value" />. If <paramref name="value" /> is not found and <paramref name="value" /> is greater than all elements in <paramref name="array" />, the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted <paramref name="array" />, the return value can be incorrect and a negative number could be returned, even if <paramref name="value" /> is present in <paramref name="array" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.RankException">
	///   <paramref name="array" /> is multidimensional.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="comparer" /> is <see langword="null" />, and <paramref name="value" /> is of a type that is not compatible with the elements of <paramref name="array" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <paramref name="comparer" /> is <see langword="null" />, <paramref name="value" /> does not implement the <see cref="T:System.IComparable" /> interface, and the search encounters an element that does not implement the <see cref="T:System.IComparable" /> interface.</exception>
	public static int BinarySearch(Array array, object value, IComparer comparer)
	{
		return 0;
	}

	/// <summary>Searches a range of elements in a one-dimensional sorted array for a value, using the specified <see cref="T:System.Collections.IComparer" /> interface.</summary>
	/// <param name="array">The sorted one-dimensional <see cref="T:System.Array" /> to search.</param>
	/// <param name="index">The starting index of the range to search.</param>
	/// <param name="length">The length of the range to search.</param>
	/// <param name="value">The object to search for.</param>
	/// <param name="comparer">The <see cref="T:System.Collections.IComparer" /> implementation to use when comparing elements.  
	///  -or-  
	///  <see langword="null" /> to use the <see cref="T:System.IComparable" /> implementation of each element.</param>
	/// <returns>The index of the specified <paramref name="value" /> in the specified <paramref name="array" />, if <paramref name="value" /> is found; otherwise, a negative number. If <paramref name="value" /> is not found and <paramref name="value" /> is less than one or more elements in <paramref name="array" />, the negative number returned is the bitwise complement of the index of the first element that is larger than <paramref name="value" />. If <paramref name="value" /> is not found and <paramref name="value" /> is greater than all elements in <paramref name="array" />, the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted <paramref name="array" />, the return value can be incorrect and a negative number could be returned, even if <paramref name="value" /> is present in <paramref name="array" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.RankException">
	///   <paramref name="array" /> is multidimensional.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than the lower bound of <paramref name="array" />.  
	/// -or-  
	/// <paramref name="length" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="index" /> and <paramref name="length" /> do not specify a valid range in <paramref name="array" />.  
	/// -or-  
	/// <paramref name="comparer" /> is <see langword="null" />, and <paramref name="value" /> is of a type that is not compatible with the elements of <paramref name="array" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <paramref name="comparer" /> is <see langword="null" />, <paramref name="value" /> does not implement the <see cref="T:System.IComparable" /> interface, and the search encounters an element that does not implement the <see cref="T:System.IComparable" /> interface.</exception>
	public static int BinarySearch(Array array, int index, int length, object value, IComparer comparer)
	{
		return 0;
	}

	private static int GetMedian(int low, int hi)
	{
		return 0;
	}

	/// <summary>Searches an entire one-dimensional sorted array for a specific element, using the <see cref="T:System.IComparable`1" /> generic interface implemented by each element of the <see cref="T:System.Array" /> and by the specified object.</summary>
	/// <param name="array">The sorted one-dimensional, zero-based <see cref="T:System.Array" /> to search.</param>
	/// <param name="value">The object to search for.</param>
	/// <typeparam name="T">The type of the elements of the array.</typeparam>
	/// <returns>The index of the specified <paramref name="value" /> in the specified <paramref name="array" />, if <paramref name="value" /> is found; otherwise, a negative number. If <paramref name="value" /> is not found and <paramref name="value" /> is less than one or more elements in <paramref name="array" />, the negative number returned is the bitwise complement of the index of the first element that is larger than <paramref name="value" />. If <paramref name="value" /> is not found and <paramref name="value" /> is greater than all elements in <paramref name="array" />, the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted <paramref name="array" />, the return value can be incorrect and a negative number could be returned, even if <paramref name="value" /> is present in <paramref name="array" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <paramref name="T" /> does not implement the <see cref="T:System.IComparable`1" /> generic interface.</exception>
	public static int BinarySearch<T>(T[] array, T value)
	{
		return 0;
	}

	/// <summary>Searches an entire one-dimensional sorted array for a value using the specified <see cref="T:System.Collections.Generic.IComparer`1" /> generic interface.</summary>
	/// <param name="array">The sorted one-dimensional, zero-based <see cref="T:System.Array" /> to search.</param>
	/// <param name="value">The object to search for.</param>
	/// <param name="comparer">The <see cref="T:System.Collections.Generic.IComparer`1" /> implementation to use when comparing elements.  
	///  -or-  
	///  <see langword="null" /> to use the <see cref="T:System.IComparable`1" /> implementation of each element.</param>
	/// <typeparam name="T">The type of the elements of the array.</typeparam>
	/// <returns>The index of the specified <paramref name="value" /> in the specified <paramref name="array" />, if <paramref name="value" /> is found; otherwise, a negative number. If <paramref name="value" /> is not found and <paramref name="value" /> is less than one or more elements in <paramref name="array" />, the negative number returned is the bitwise complement of the index of the first element that is larger than <paramref name="value" />. If <paramref name="value" /> is not found and <paramref name="value" /> is greater than all elements in <paramref name="array" />, the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted <paramref name="array" />, the return value can be incorrect and a negative number could be returned, even if <paramref name="value" /> is present in <paramref name="array" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="comparer" /> is <see langword="null" />, and <paramref name="value" /> is of a type that is not compatible with the elements of <paramref name="array" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <paramref name="comparer" /> is <see langword="null" />, and <paramref name="T" /> does not implement the <see cref="T:System.IComparable`1" /> generic interface</exception>
	public static int BinarySearch<T>(T[] array, T value, IComparer<T> comparer)
	{
		return 0;
	}

	/// <summary>Searches a range of elements in a one-dimensional sorted array for a value, using the <see cref="T:System.IComparable`1" /> generic interface implemented by each element of the <see cref="T:System.Array" /> and by the specified value.</summary>
	/// <param name="array">The sorted one-dimensional, zero-based <see cref="T:System.Array" /> to search.</param>
	/// <param name="index">The starting index of the range to search.</param>
	/// <param name="length">The length of the range to search.</param>
	/// <param name="value">The object to search for.</param>
	/// <typeparam name="T">The type of the elements of the array.</typeparam>
	/// <returns>The index of the specified <paramref name="value" /> in the specified <paramref name="array" />, if <paramref name="value" /> is found; otherwise, a negative number. If <paramref name="value" /> is not found and <paramref name="value" /> is less than one or more elements in <paramref name="array" />, the negative number returned is the bitwise complement of the index of the first element that is larger than <paramref name="value" />. If <paramref name="value" /> is not found and <paramref name="value" /> is greater than all elements in <paramref name="array" />, the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted <paramref name="array" />, the return value can be incorrect and a negative number could be returned, even if <paramref name="value" /> is present in <paramref name="array" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than the lower bound of <paramref name="array" />.  
	/// -or-  
	/// <paramref name="length" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="index" /> and <paramref name="length" /> do not specify a valid range in <paramref name="array" />.  
	/// -or-  
	/// <paramref name="value" /> is of a type that is not compatible with the elements of <paramref name="array" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <paramref name="T" /> does not implement the <see cref="T:System.IComparable`1" /> generic interface.</exception>
	public static int BinarySearch<T>(T[] array, int index, int length, T value)
	{
		return 0;
	}

	/// <summary>Searches a range of elements in a one-dimensional sorted array for a value, using the specified <see cref="T:System.Collections.Generic.IComparer`1" /> generic interface.</summary>
	/// <param name="array">The sorted one-dimensional, zero-based <see cref="T:System.Array" /> to search.</param>
	/// <param name="index">The starting index of the range to search.</param>
	/// <param name="length">The length of the range to search.</param>
	/// <param name="value">The object to search for.</param>
	/// <param name="comparer">The <see cref="T:System.Collections.Generic.IComparer`1" /> implementation to use when comparing elements.  
	///  -or-  
	///  <see langword="null" /> to use the <see cref="T:System.IComparable`1" /> implementation of each element.</param>
	/// <typeparam name="T">The type of the elements of the array.</typeparam>
	/// <returns>The index of the specified <paramref name="value" /> in the specified <paramref name="array" />, if <paramref name="value" /> is found; otherwise, a negative number. If <paramref name="value" /> is not found and <paramref name="value" /> is less than one or more elements in <paramref name="array" />, the negative number returned is the bitwise complement of the index of the first element that is larger than <paramref name="value" />. If <paramref name="value" /> is not found and <paramref name="value" /> is greater than all elements in <paramref name="array" />, the negative number returned is the bitwise complement of (the index of the last element plus 1). If this method is called with a non-sorted <paramref name="array" />, the return value can be incorrect and a negative number could be returned, even if <paramref name="value" /> is present in <paramref name="array" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than the lower bound of <paramref name="array" />.  
	/// -or-  
	/// <paramref name="length" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="index" /> and <paramref name="length" /> do not specify a valid range in <paramref name="array" />.  
	/// -or-  
	/// <paramref name="comparer" /> is <see langword="null" />, and <paramref name="value" /> is of a type that is not compatible with the elements of <paramref name="array" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <paramref name="comparer" /> is <see langword="null" />, and <paramref name="T" /> does not implement the <see cref="T:System.IComparable`1" /> generic interface.</exception>
	public static int BinarySearch<T>(T[] array, int index, int length, T value, IComparer<T> comparer)
	{
		return 0;
	}

	/// <summary>Searches for the specified object and returns the index of its first occurrence in a one-dimensional array.</summary>
	/// <param name="array">The one-dimensional array to search.</param>
	/// <param name="value">The object to locate in <paramref name="array" />.</param>
	/// <returns>The index of the first occurrence of <paramref name="value" /> in <paramref name="array" />, if found; otherwise, the lower bound of the array minus 1.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.RankException">
	///   <paramref name="array" /> is multidimensional.</exception>
	public static int IndexOf(Array array, object value)
	{
		return 0;
	}

	/// <summary>Searches for the specified object in a range of elements of a one-dimensional array, and returns the index of its first occurrence. The range extends from a specified index to the end of the array.</summary>
	/// <param name="array">The one-dimensional array to search.</param>
	/// <param name="value">The object to locate in <paramref name="array" />.</param>
	/// <param name="startIndex">The starting index of the search. 0 (zero) is valid in an empty array.</param>
	/// <returns>The index of the first occurrence of <paramref name="value" />, if it's found, within the range of elements in <paramref name="array" /> that extends from <paramref name="startIndex" /> to the last element; otherwise, the lower bound of the array minus 1.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="array" />.</exception>
	/// <exception cref="T:System.RankException">
	///   <paramref name="array" /> is multidimensional.</exception>
	public static int IndexOf(Array array, object value, int startIndex)
	{
		return 0;
	}

	/// <summary>Searches for the specified object in a range of elements of a one-dimensional array, and returns the index of ifs first occurrence. The range extends from a specified index for a specified number of elements.</summary>
	/// <param name="array">The one-dimensional array to search.</param>
	/// <param name="value">The object to locate in <paramref name="array" />.</param>
	/// <param name="startIndex">The starting index of the search. 0 (zero) is valid in an empty array.</param>
	/// <param name="count">The number of elements to search.</param>
	/// <returns>The index of the first occurrence of <paramref name="value" />, if it's found in the <paramref name="array" /> from index <paramref name="startIndex" /> to <paramref name="startIndex" /> + <paramref name="count" /> - 1; otherwise, the lower bound of the array minus 1.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="array" />.  
	/// -or-  
	/// <paramref name="count" /> is less than zero.  
	/// -or-  
	/// <paramref name="startIndex" /> and <paramref name="count" /> do not specify a valid section in <paramref name="array" />.</exception>
	/// <exception cref="T:System.RankException">
	///   <paramref name="array" /> is multidimensional.</exception>
	public static int IndexOf(Array array, object value, int startIndex, int count)
	{
		return 0;
	}

	/// <summary>Searches for the specified object and returns the index of its first occurrence in a one-dimensional array.</summary>
	/// <param name="array">The one-dimensional, zero-based array to search.</param>
	/// <param name="value">The object to locate in <paramref name="array" />.</param>
	/// <typeparam name="T">The type of the elements of the array.</typeparam>
	/// <returns>The zero-based index of the first occurrence of <paramref name="value" /> in the entire <paramref name="array" />, if found; otherwise, -1.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	public static int IndexOf<T>(T[] array, T value)
	{
		return 0;
	}

	/// <summary>Searches for the specified object in a range of elements of a one dimensional array, and returns the index of its first occurrence. The range extends from a specified index to the end of the array.</summary>
	/// <param name="array">The one-dimensional, zero-based array to search.</param>
	/// <param name="value">The object to locate in <paramref name="array" />.</param>
	/// <param name="startIndex">The zero-based starting index of the search. 0 (zero) is valid in an empty array.</param>
	/// <typeparam name="T">The type of the elements of the array.</typeparam>
	/// <returns>The zero-based index of the first occurrence of <paramref name="value" /> within the range of elements in <paramref name="array" /> that extends from <paramref name="startIndex" /> to the last element, if found; otherwise, -1.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="array" />.</exception>
	public static int IndexOf<T>(T[] array, T value, int startIndex)
	{
		return 0;
	}

	/// <summary>Searches for the specified object in a range of elements of a one-dimensional array, and returns the index of its first occurrence. The range extends from a specified index for a specified number of elements.</summary>
	/// <param name="array">The one-dimensional, zero-based array to search.</param>
	/// <param name="value">The object to locate in <paramref name="array" />.</param>
	/// <param name="startIndex">The zero-based starting index of the search. 0 (zero) is valid in an empty array.</param>
	/// <param name="count">The number of elements in the section to search.</param>
	/// <typeparam name="T">The type of the elements of the array.</typeparam>
	/// <returns>The zero-based index of the first occurrence of <paramref name="value" /> within the range of elements in <paramref name="array" /> that starts at <paramref name="startIndex" /> and contains the number of elements specified in <paramref name="count" />, if found; otherwise, -1.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="array" />.  
	/// -or-  
	/// <paramref name="count" /> is less than zero.  
	/// -or-  
	/// <paramref name="startIndex" /> and <paramref name="count" /> do not specify a valid section in <paramref name="array" />.</exception>
	public static int IndexOf<T>(T[] array, T value, int startIndex, int count)
	{
		return 0;
	}

	/// <summary>Searches for the specified object and returns the index of the last occurrence within the entire one-dimensional <see cref="T:System.Array" />.</summary>
	/// <param name="array">The one-dimensional <see cref="T:System.Array" /> to search.</param>
	/// <param name="value">The object to locate in <paramref name="array" />.</param>
	/// <returns>The index of the last occurrence of <paramref name="value" /> within the entire <paramref name="array" />, if found; otherwise, the lower bound of the array minus 1.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.RankException">
	///   <paramref name="array" /> is multidimensional.</exception>
	public static int LastIndexOf(Array array, object value)
	{
		return 0;
	}

	/// <summary>Searches for the specified object and returns the index of the last occurrence within the range of elements in the one-dimensional <see cref="T:System.Array" /> that extends from the first element to the specified index.</summary>
	/// <param name="array">The one-dimensional <see cref="T:System.Array" /> to search.</param>
	/// <param name="value">The object to locate in <paramref name="array" />.</param>
	/// <param name="startIndex">The starting index of the backward search.</param>
	/// <returns>The index of the last occurrence of <paramref name="value" /> within the range of elements in <paramref name="array" /> that extends from the first element to <paramref name="startIndex" />, if found; otherwise, the lower bound of the array minus 1.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="array" />.</exception>
	/// <exception cref="T:System.RankException">
	///   <paramref name="array" /> is multidimensional.</exception>
	public static int LastIndexOf(Array array, object value, int startIndex)
	{
		return 0;
	}

	/// <summary>Searches for the specified object and returns the index of the last occurrence within the range of elements in the one-dimensional <see cref="T:System.Array" /> that contains the specified number of elements and ends at the specified index.</summary>
	/// <param name="array">The one-dimensional <see cref="T:System.Array" /> to search.</param>
	/// <param name="value">The object to locate in <paramref name="array" />.</param>
	/// <param name="startIndex">The starting index of the backward search.</param>
	/// <param name="count">The number of elements in the section to search.</param>
	/// <returns>The index of the last occurrence of <paramref name="value" /> within the range of elements in <paramref name="array" /> that contains the number of elements specified in <paramref name="count" /> and ends at <paramref name="startIndex" />, if found; otherwise, the lower bound of the array minus 1.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="array" />.  
	/// -or-  
	/// <paramref name="count" /> is less than zero.  
	/// -or-  
	/// <paramref name="startIndex" /> and <paramref name="count" /> do not specify a valid section in <paramref name="array" />.</exception>
	/// <exception cref="T:System.RankException">
	///   <paramref name="array" /> is multidimensional.</exception>
	public static int LastIndexOf(Array array, object value, int startIndex, int count)
	{
		return 0;
	}

	/// <summary>Searches for the specified object and returns the index of the last occurrence within the entire <see cref="T:System.Array" />.</summary>
	/// <param name="array">The one-dimensional, zero-based <see cref="T:System.Array" /> to search.</param>
	/// <param name="value">The object to locate in <paramref name="array" />.</param>
	/// <typeparam name="T">The type of the elements of the array.</typeparam>
	/// <returns>The zero-based index of the last occurrence of <paramref name="value" /> within the entire <paramref name="array" />, if found; otherwise, -1.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	public static int LastIndexOf<T>(T[] array, T value)
	{
		return 0;
	}

	/// <summary>Searches for the specified object and returns the index of the last occurrence within the range of elements in the <see cref="T:System.Array" /> that extends from the first element to the specified index.</summary>
	/// <param name="array">The one-dimensional, zero-based <see cref="T:System.Array" /> to search.</param>
	/// <param name="value">The object to locate in <paramref name="array" />.</param>
	/// <param name="startIndex">The zero-based starting index of the backward search.</param>
	/// <typeparam name="T">The type of the elements of the array.</typeparam>
	/// <returns>The zero-based index of the last occurrence of <paramref name="value" /> within the range of elements in <paramref name="array" /> that extends from the first element to <paramref name="startIndex" />, if found; otherwise, -1.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="array" />.</exception>
	public static int LastIndexOf<T>(T[] array, T value, int startIndex)
	{
		return 0;
	}

	/// <summary>Searches for the specified object and returns the index of the last occurrence within the range of elements in the <see cref="T:System.Array" /> that contains the specified number of elements and ends at the specified index.</summary>
	/// <param name="array">The one-dimensional, zero-based <see cref="T:System.Array" /> to search.</param>
	/// <param name="value">The object to locate in <paramref name="array" />.</param>
	/// <param name="startIndex">The zero-based starting index of the backward search.</param>
	/// <param name="count">The number of elements in the section to search.</param>
	/// <typeparam name="T">The type of the elements of the array.</typeparam>
	/// <returns>The zero-based index of the last occurrence of <paramref name="value" /> within the range of elements in <paramref name="array" /> that contains the number of elements specified in <paramref name="count" /> and ends at <paramref name="startIndex" />, if found; otherwise, -1.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="array" />.  
	/// -or-  
	/// <paramref name="count" /> is less than zero.  
	/// -or-  
	/// <paramref name="startIndex" /> and <paramref name="count" /> do not specify a valid section in <paramref name="array" />.</exception>
	public static int LastIndexOf<T>(T[] array, T value, int startIndex, int count)
	{
		return 0;
	}

	/// <summary>Reverses the sequence of the elements in the entire one-dimensional <see cref="T:System.Array" />.</summary>
	/// <param name="array">The one-dimensional <see cref="T:System.Array" /> to reverse.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.RankException">
	///   <paramref name="array" /> is multidimensional.</exception>
	public static void Reverse(Array array)
	{
	}

	/// <summary>Reverses the sequence of the elements in a range of elements in the one-dimensional <see cref="T:System.Array" />.</summary>
	/// <param name="array">The one-dimensional <see cref="T:System.Array" /> to reverse.</param>
	/// <param name="index">The starting index of the section to reverse.</param>
	/// <param name="length">The number of elements in the section to reverse.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.RankException">
	///   <paramref name="array" /> is multidimensional.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than the lower bound of <paramref name="array" />.  
	/// -or-  
	/// <paramref name="length" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="index" /> and <paramref name="length" /> do not specify a valid range in <paramref name="array" />.</exception>
	public static void Reverse(Array array, int index, int length)
	{
	}

	public static void Reverse<T>(T[] array)
	{
	}

	public static void Reverse<T>(T[] array, int index, int length)
	{
	}

	/// <summary>Sets a value to the element at the specified position in the one-dimensional <see cref="T:System.Array" />. The index is specified as a 64-bit integer.</summary>
	/// <param name="value">The new value for the specified element.</param>
	/// <param name="index">A 64-bit integer that represents the position of the <see cref="T:System.Array" /> element to set.</param>
	/// <exception cref="T:System.ArgumentException">The current <see cref="T:System.Array" /> does not have exactly one dimension.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> cannot be cast to the element type of the current <see cref="T:System.Array" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is outside the range of valid indexes for the current <see cref="T:System.Array" />.</exception>
	public void SetValue(object value, long index)
	{
	}

	/// <summary>Sets a value to the element at the specified position in the two-dimensional <see cref="T:System.Array" />. The indexes are specified as 64-bit integers.</summary>
	/// <param name="value">The new value for the specified element.</param>
	/// <param name="index1">A 64-bit integer that represents the first-dimension index of the <see cref="T:System.Array" /> element to set.</param>
	/// <param name="index2">A 64-bit integer that represents the second-dimension index of the <see cref="T:System.Array" /> element to set.</param>
	/// <exception cref="T:System.ArgumentException">The current <see cref="T:System.Array" /> does not have exactly two dimensions.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> cannot be cast to the element type of the current <see cref="T:System.Array" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Either <paramref name="index1" /> or <paramref name="index2" /> is outside the range of valid indexes for the corresponding dimension of the current <see cref="T:System.Array" />.</exception>
	public void SetValue(object value, long index1, long index2)
	{
	}

	/// <summary>Sets a value to the element at the specified position in the three-dimensional <see cref="T:System.Array" />. The indexes are specified as 64-bit integers.</summary>
	/// <param name="value">The new value for the specified element.</param>
	/// <param name="index1">A 64-bit integer that represents the first-dimension index of the <see cref="T:System.Array" /> element to set.</param>
	/// <param name="index2">A 64-bit integer that represents the second-dimension index of the <see cref="T:System.Array" /> element to set.</param>
	/// <param name="index3">A 64-bit integer that represents the third-dimension index of the <see cref="T:System.Array" /> element to set.</param>
	/// <exception cref="T:System.ArgumentException">The current <see cref="T:System.Array" /> does not have exactly three dimensions.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> cannot be cast to the element type of the current <see cref="T:System.Array" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index1" /> or <paramref name="index2" /> or <paramref name="index3" /> is outside the range of valid indexes for the corresponding dimension of the current <see cref="T:System.Array" />.</exception>
	public void SetValue(object value, long index1, long index2, long index3)
	{
	}

	/// <summary>Sets a value to the element at the specified position in the multidimensional <see cref="T:System.Array" />. The indexes are specified as an array of 64-bit integers.</summary>
	/// <param name="value">The new value for the specified element.</param>
	/// <param name="indices">A one-dimensional array of 64-bit integers that represent the indexes specifying the position of the element to set.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="indices" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The number of dimensions in the current <see cref="T:System.Array" /> is not equal to the number of elements in <paramref name="indices" />.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> cannot be cast to the element type of the current <see cref="T:System.Array" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Any element in <paramref name="indices" /> is outside the range of valid indexes for the corresponding dimension of the current <see cref="T:System.Array" />.</exception>
	public void SetValue(object value, params long[] indices)
	{
	}

	/// <summary>Sorts the elements in an entire one-dimensional <see cref="T:System.Array" /> using the <see cref="T:System.IComparable" /> implementation of each element of the <see cref="T:System.Array" />.</summary>
	/// <param name="array">The one-dimensional <see cref="T:System.Array" /> to sort.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.RankException">
	///   <paramref name="array" /> is multidimensional.</exception>
	/// <exception cref="T:System.InvalidOperationException">One or more elements in <paramref name="array" /> do not implement the <see cref="T:System.IComparable" /> interface.</exception>
	public static void Sort(Array array)
	{
	}

	/// <summary>Sorts the elements in a range of elements in a one-dimensional <see cref="T:System.Array" /> using the <see cref="T:System.IComparable" /> implementation of each element of the <see cref="T:System.Array" />.</summary>
	/// <param name="array">The one-dimensional <see cref="T:System.Array" /> to sort.</param>
	/// <param name="index">The starting index of the range to sort.</param>
	/// <param name="length">The number of elements in the range to sort.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.RankException">
	///   <paramref name="array" /> is multidimensional.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than the lower bound of <paramref name="array" />.  
	/// -or-  
	/// <paramref name="length" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="index" /> and <paramref name="length" /> do not specify a valid range in <paramref name="array" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">One or more elements in <paramref name="array" /> do not implement the <see cref="T:System.IComparable" /> interface.</exception>
	public static void Sort(Array array, int index, int length)
	{
	}

	/// <summary>Sorts the elements in a one-dimensional <see cref="T:System.Array" /> using the specified <see cref="T:System.Collections.IComparer" />.</summary>
	/// <param name="array">The one-dimensional array to sort.</param>
	/// <param name="comparer">The implementation to use when comparing elements.  
	///  -or-  
	///  <see langword="null" /> to use the <see cref="T:System.IComparable" /> implementation of each element.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.RankException">
	///   <paramref name="array" /> is multidimensional.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <paramref name="comparer" /> is <see langword="null" />, and one or more elements in <paramref name="array" /> do not implement the <see cref="T:System.IComparable" /> interface.</exception>
	/// <exception cref="T:System.ArgumentException">The implementation of <paramref name="comparer" /> caused an error during the sort. For example, <paramref name="comparer" /> might not return 0 when comparing an item with itself.</exception>
	public static void Sort(Array array, IComparer comparer)
	{
	}

	/// <summary>Sorts the elements in a range of elements in a one-dimensional <see cref="T:System.Array" /> using the specified <see cref="T:System.Collections.IComparer" />.</summary>
	/// <param name="array">The one-dimensional <see cref="T:System.Array" /> to sort.</param>
	/// <param name="index">The starting index of the range to sort.</param>
	/// <param name="length">The number of elements in the range to sort.</param>
	/// <param name="comparer">The <see cref="T:System.Collections.IComparer" /> implementation to use when comparing elements.  
	///  -or-  
	///  <see langword="null" /> to use the <see cref="T:System.IComparable" /> implementation of each element.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.RankException">
	///   <paramref name="array" /> is multidimensional.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than the lower bound of <paramref name="array" />.  
	/// -or-  
	/// <paramref name="length" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="index" /> and <paramref name="length" /> do not specify a valid range in <paramref name="array" />.  
	/// -or-  
	/// The implementation of <paramref name="comparer" /> caused an error during the sort. For example, <paramref name="comparer" /> might not return 0 when comparing an item with itself.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <paramref name="comparer" /> is <see langword="null" />, and one or more elements in <paramref name="array" /> do not implement the <see cref="T:System.IComparable" /> interface.</exception>
	public static void Sort(Array array, int index, int length, IComparer comparer)
	{
	}

	/// <summary>Sorts a pair of one-dimensional <see cref="T:System.Array" /> objects (one contains the keys and the other contains the corresponding items) based on the keys in the first <see cref="T:System.Array" /> using the <see cref="T:System.IComparable" /> implementation of each key.</summary>
	/// <param name="keys">The one-dimensional <see cref="T:System.Array" /> that contains the keys to sort.</param>
	/// <param name="items">The one-dimensional <see cref="T:System.Array" /> that contains the items that correspond to each of the keys in the <paramref name="keys" /><see cref="T:System.Array" />.  
	///  -or-  
	///  <see langword="null" /> to sort only the <paramref name="keys" /><see cref="T:System.Array" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="keys" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.RankException">The <paramref name="keys" /><see cref="T:System.Array" /> is multidimensional.  
	///  -or-  
	///  The <paramref name="items" /><see cref="T:System.Array" /> is multidimensional.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="items" /> is not <see langword="null" />, and the length of <paramref name="keys" /> is greater than the length of <paramref name="items" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">One or more elements in the <paramref name="keys" /><see cref="T:System.Array" /> do not implement the <see cref="T:System.IComparable" /> interface.</exception>
	public static void Sort(Array keys, Array items)
	{
	}

	/// <summary>Sorts a pair of one-dimensional <see cref="T:System.Array" /> objects (one contains the keys and the other contains the corresponding items) based on the keys in the first <see cref="T:System.Array" /> using the specified <see cref="T:System.Collections.IComparer" />.</summary>
	/// <param name="keys">The one-dimensional <see cref="T:System.Array" /> that contains the keys to sort.</param>
	/// <param name="items">The one-dimensional <see cref="T:System.Array" /> that contains the items that correspond to each of the keys in the <paramref name="keys" /><see cref="T:System.Array" />.  
	///  -or-  
	///  <see langword="null" /> to sort only the <paramref name="keys" /><see cref="T:System.Array" />.</param>
	/// <param name="comparer">The <see cref="T:System.Collections.IComparer" /> implementation to use when comparing elements.  
	///  -or-  
	///  <see langword="null" /> to use the <see cref="T:System.IComparable" /> implementation of each element.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="keys" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.RankException">The <paramref name="keys" /><see cref="T:System.Array" /> is multidimensional.  
	///  -or-  
	///  The <paramref name="items" /><see cref="T:System.Array" /> is multidimensional.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="items" /> is not <see langword="null" />, and the length of <paramref name="keys" /> is greater than the length of <paramref name="items" />.  
	/// -or-  
	/// The implementation of <paramref name="comparer" /> caused an error during the sort. For example, <paramref name="comparer" /> might not return 0 when comparing an item with itself.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <paramref name="comparer" /> is <see langword="null" />, and one or more elements in the <paramref name="keys" /><see cref="T:System.Array" /> do not implement the <see cref="T:System.IComparable" /> interface.</exception>
	public static void Sort(Array keys, Array items, IComparer comparer)
	{
	}

	/// <summary>Sorts a range of elements in a pair of one-dimensional <see cref="T:System.Array" /> objects (one contains the keys and the other contains the corresponding items) based on the keys in the first <see cref="T:System.Array" /> using the <see cref="T:System.IComparable" /> implementation of each key.</summary>
	/// <param name="keys">The one-dimensional <see cref="T:System.Array" /> that contains the keys to sort.</param>
	/// <param name="items">The one-dimensional <see cref="T:System.Array" /> that contains the items that correspond to each of the keys in the <paramref name="keys" /><see cref="T:System.Array" />.  
	///  -or-  
	///  <see langword="null" /> to sort only the <paramref name="keys" /><see cref="T:System.Array" />.</param>
	/// <param name="index">The starting index of the range to sort.</param>
	/// <param name="length">The number of elements in the range to sort.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="keys" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.RankException">The <paramref name="keys" /><see cref="T:System.Array" /> is multidimensional.  
	///  -or-  
	///  The <paramref name="items" /><see cref="T:System.Array" /> is multidimensional.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than the lower bound of <paramref name="keys" />.  
	/// -or-  
	/// <paramref name="length" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="items" /> is not <see langword="null" />, and the length of <paramref name="keys" /> is greater than the length of <paramref name="items" />.  
	/// -or-  
	/// <paramref name="index" /> and <paramref name="length" /> do not specify a valid range in the <paramref name="keys" /><see cref="T:System.Array" />.  
	/// -or-  
	/// <paramref name="items" /> is not <see langword="null" />, and <paramref name="index" /> and <paramref name="length" /> do not specify a valid range in the <paramref name="items" /><see cref="T:System.Array" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">One or more elements in the <paramref name="keys" /><see cref="T:System.Array" /> do not implement the <see cref="T:System.IComparable" /> interface.</exception>
	public static void Sort(Array keys, Array items, int index, int length)
	{
	}

	/// <summary>Sorts a range of elements in a pair of one-dimensional <see cref="T:System.Array" /> objects (one contains the keys and the other contains the corresponding items) based on the keys in the first <see cref="T:System.Array" /> using the specified <see cref="T:System.Collections.IComparer" />.</summary>
	/// <param name="keys">The one-dimensional <see cref="T:System.Array" /> that contains the keys to sort.</param>
	/// <param name="items">The one-dimensional <see cref="T:System.Array" /> that contains the items that correspond to each of the keys in the <paramref name="keys" /><see cref="T:System.Array" />.  
	///  -or-  
	///  <see langword="null" /> to sort only the <paramref name="keys" /><see cref="T:System.Array" />.</param>
	/// <param name="index">The starting index of the range to sort.</param>
	/// <param name="length">The number of elements in the range to sort.</param>
	/// <param name="comparer">The <see cref="T:System.Collections.IComparer" /> implementation to use when comparing elements.  
	///  -or-  
	///  <see langword="null" /> to use the <see cref="T:System.IComparable" /> implementation of each element.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="keys" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.RankException">The <paramref name="keys" /><see cref="T:System.Array" /> is multidimensional.  
	///  -or-  
	///  The <paramref name="items" /><see cref="T:System.Array" /> is multidimensional.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than the lower bound of <paramref name="keys" />.  
	/// -or-  
	/// <paramref name="length" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="items" /> is not <see langword="null" />, and the lower bound of <paramref name="keys" /> does not match the lower bound of <paramref name="items" />.  
	/// -or-  
	/// <paramref name="items" /> is not <see langword="null" />, and the length of <paramref name="keys" /> is greater than the length of <paramref name="items" />.  
	/// -or-  
	/// <paramref name="index" /> and <paramref name="length" /> do not specify a valid range in the <paramref name="keys" /><see cref="T:System.Array" />.  
	/// -or-  
	/// <paramref name="items" /> is not <see langword="null" />, and <paramref name="index" /> and <paramref name="length" /> do not specify a valid range in the <paramref name="items" /><see cref="T:System.Array" />.  
	/// -or-  
	/// The implementation of <paramref name="comparer" /> caused an error during the sort. For example, <paramref name="comparer" /> might not return 0 when comparing an item with itself.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <paramref name="comparer" /> is <see langword="null" />, and one or more elements in the <paramref name="keys" /><see cref="T:System.Array" /> do not implement the <see cref="T:System.IComparable" /> interface.</exception>
	public static void Sort(Array keys, Array items, int index, int length, IComparer comparer)
	{
	}

	/// <summary>Sorts the elements in an entire <see cref="T:System.Array" /> using the <see cref="T:System.IComparable`1" /> generic interface implementation of each element of the <see cref="T:System.Array" />.</summary>
	/// <param name="array">The one-dimensional, zero-based <see cref="T:System.Array" /> to sort.</param>
	/// <typeparam name="T">The type of the elements of the array.</typeparam>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">One or more elements in <paramref name="array" /> do not implement the <see cref="T:System.IComparable`1" /> generic interface.</exception>
	public static void Sort<T>(T[] array)
	{
	}

	/// <summary>Sorts the elements in a range of elements in an <see cref="T:System.Array" /> using the <see cref="T:System.IComparable`1" /> generic interface implementation of each element of the <see cref="T:System.Array" />.</summary>
	/// <param name="array">The one-dimensional, zero-based <see cref="T:System.Array" /> to sort</param>
	/// <param name="index">The starting index of the range to sort.</param>
	/// <param name="length">The number of elements in the range to sort.</param>
	/// <typeparam name="T">The type of the elements of the array.</typeparam>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than the lower bound of <paramref name="array" />.  
	/// -or-  
	/// <paramref name="length" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="index" /> and <paramref name="length" /> do not specify a valid range in <paramref name="array" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">One or more elements in <paramref name="array" /> do not implement the <see cref="T:System.IComparable`1" /> generic interface.</exception>
	public static void Sort<T>(T[] array, int index, int length)
	{
	}

	/// <summary>Sorts the elements in an <see cref="T:System.Array" /> using the specified <see cref="T:System.Collections.Generic.IComparer`1" /> generic interface.</summary>
	/// <param name="array">The one-dimensional, zero-base <see cref="T:System.Array" /> to sort</param>
	/// <param name="comparer">The <see cref="T:System.Collections.Generic.IComparer`1" /> generic interface implementation to use when comparing elements, or <see langword="null" /> to use the <see cref="T:System.IComparable`1" /> generic interface implementation of each element.</param>
	/// <typeparam name="T">The type of the elements of the array.</typeparam>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <paramref name="comparer" /> is <see langword="null" />, and one or more elements in <paramref name="array" /> do not implement the <see cref="T:System.IComparable`1" /> generic interface.</exception>
	/// <exception cref="T:System.ArgumentException">The implementation of <paramref name="comparer" /> caused an error during the sort. For example, <paramref name="comparer" /> might not return 0 when comparing an item with itself.</exception>
	public static void Sort<T>(T[] array, IComparer<T> comparer)
	{
	}

	/// <summary>Sorts the elements in a range of elements in an <see cref="T:System.Array" /> using the specified <see cref="T:System.Collections.Generic.IComparer`1" /> generic interface.</summary>
	/// <param name="array">The one-dimensional, zero-based <see cref="T:System.Array" /> to sort.</param>
	/// <param name="index">The starting index of the range to sort.</param>
	/// <param name="length">The number of elements in the range to sort.</param>
	/// <param name="comparer">The <see cref="T:System.Collections.Generic.IComparer`1" /> generic interface implementation to use when comparing elements, or <see langword="null" /> to use the <see cref="T:System.IComparable`1" /> generic interface implementation of each element.</param>
	/// <typeparam name="T">The type of the elements of the array.</typeparam>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than the lower bound of <paramref name="array" />.  
	/// -or-  
	/// <paramref name="length" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="index" /> and <paramref name="length" /> do not specify a valid range in <paramref name="array" />.  
	/// -or-  
	/// The implementation of <paramref name="comparer" /> caused an error during the sort. For example, <paramref name="comparer" /> might not return 0 when comparing an item with itself.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <paramref name="comparer" /> is <see langword="null" />, and one or more elements in <paramref name="array" /> do not implement the <see cref="T:System.IComparable`1" /> generic interface.</exception>
	public static void Sort<T>(T[] array, int index, int length, IComparer<T> comparer)
	{
	}

	/// <summary>Sorts the elements in an <see cref="T:System.Array" /> using the specified <see cref="T:System.Comparison`1" />.</summary>
	/// <param name="array">The one-dimensional, zero-based <see cref="T:System.Array" /> to sort</param>
	/// <param name="comparison">The <see cref="T:System.Comparison`1" /> to use when comparing elements.</param>
	/// <typeparam name="T">The type of the elements of the array.</typeparam>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="comparison" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The implementation of <paramref name="comparison" /> caused an error during the sort. For example, <paramref name="comparison" /> might not return 0 when comparing an item with itself.</exception>
	public static void Sort<T>(T[] array, Comparison<T> comparison)
	{
	}

	/// <summary>Sorts a pair of <see cref="T:System.Array" /> objects (one contains the keys and the other contains the corresponding items) based on the keys in the first <see cref="T:System.Array" /> using the <see cref="T:System.IComparable`1" /> generic interface implementation of each key.</summary>
	/// <param name="keys">The one-dimensional, zero-based <see cref="T:System.Array" /> that contains the keys to sort.</param>
	/// <param name="items">The one-dimensional, zero-based <see cref="T:System.Array" /> that contains the items that correspond to the keys in <paramref name="keys" />, or <see langword="null" /> to sort only <paramref name="keys" />.</param>
	/// <typeparam name="TKey">The type of the elements of the key array.</typeparam>
	/// <typeparam name="TValue">The type of the elements of the items array.</typeparam>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="keys" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="items" /> is not <see langword="null" />, and the lower bound of <paramref name="keys" /> does not match the lower bound of <paramref name="items" />.  
	/// -or-  
	/// <paramref name="items" /> is not <see langword="null" />, and the length of <paramref name="keys" /> is greater than the length of <paramref name="items" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">One or more elements in the <paramref name="keys" /><see cref="T:System.Array" /> do not implement the <see cref="T:System.IComparable`1" /> generic interface.</exception>
	public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items)
	{
	}

	/// <summary>Sorts a range of elements in a pair of <see cref="T:System.Array" /> objects (one contains the keys and the other contains the corresponding items) based on the keys in the first <see cref="T:System.Array" /> using the <see cref="T:System.IComparable`1" /> generic interface implementation of each key.</summary>
	/// <param name="keys">The one-dimensional, zero-based <see cref="T:System.Array" /> that contains the keys to sort.</param>
	/// <param name="items">The one-dimensional, zero-based <see cref="T:System.Array" /> that contains the items that correspond to the keys in <paramref name="keys" />, or <see langword="null" /> to sort only <paramref name="keys" />.</param>
	/// <param name="index">The starting index of the range to sort.</param>
	/// <param name="length">The number of elements in the range to sort.</param>
	/// <typeparam name="TKey">The type of the elements of the key array.</typeparam>
	/// <typeparam name="TValue">The type of the elements of the items array.</typeparam>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="keys" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than the lower bound of <paramref name="keys" />.  
	/// -or-  
	/// <paramref name="length" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="items" /> is not <see langword="null" />, and the lower bound of <paramref name="keys" /> does not match the lower bound of <paramref name="items" />.  
	/// -or-  
	/// <paramref name="items" /> is not <see langword="null" />, and the length of <paramref name="keys" /> is greater than the length of <paramref name="items" />.  
	/// -or-  
	/// <paramref name="index" /> and <paramref name="length" /> do not specify a valid range in the <paramref name="keys" /><see cref="T:System.Array" />.  
	/// -or-  
	/// <paramref name="items" /> is not <see langword="null" />, and <paramref name="index" /> and <paramref name="length" /> do not specify a valid range in the <paramref name="items" /><see cref="T:System.Array" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">One or more elements in the <paramref name="keys" /><see cref="T:System.Array" /> do not implement the <see cref="T:System.IComparable`1" /> generic interface.</exception>
	public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length)
	{
	}

	/// <summary>Sorts a pair of <see cref="T:System.Array" /> objects (one contains the keys and the other contains the corresponding items) based on the keys in the first <see cref="T:System.Array" /> using the specified <see cref="T:System.Collections.Generic.IComparer`1" /> generic interface.</summary>
	/// <param name="keys">The one-dimensional, zero-based <see cref="T:System.Array" /> that contains the keys to sort.</param>
	/// <param name="items">The one-dimensional, zero-based <see cref="T:System.Array" /> that contains the items that correspond to the keys in <paramref name="keys" />, or <see langword="null" /> to sort only <paramref name="keys" />.</param>
	/// <param name="comparer">The <see cref="T:System.Collections.Generic.IComparer`1" /> generic interface implementation to use when comparing elements, or <see langword="null" /> to use the <see cref="T:System.IComparable`1" /> generic interface implementation of each element.</param>
	/// <typeparam name="TKey">The type of the elements of the key array.</typeparam>
	/// <typeparam name="TValue">The type of the elements of the items array.</typeparam>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="keys" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="items" /> is not <see langword="null" />, and the lower bound of <paramref name="keys" /> does not match the lower bound of <paramref name="items" />.  
	/// -or-  
	/// <paramref name="items" /> is not <see langword="null" />, and the length of <paramref name="keys" /> is greater than the length of <paramref name="items" />.  
	/// -or-  
	/// The implementation of <paramref name="comparer" /> caused an error during the sort. For example, <paramref name="comparer" /> might not return 0 when comparing an item with itself.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <paramref name="comparer" /> is <see langword="null" />, and one or more elements in the <paramref name="keys" /><see cref="T:System.Array" /> do not implement the <see cref="T:System.IComparable`1" /> generic interface.</exception>
	public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, IComparer<TKey> comparer)
	{
	}

	/// <summary>Sorts a range of elements in a pair of <see cref="T:System.Array" /> objects (one contains the keys and the other contains the corresponding items) based on the keys in the first <see cref="T:System.Array" /> using the specified <see cref="T:System.Collections.Generic.IComparer`1" /> generic interface.</summary>
	/// <param name="keys">The one-dimensional, zero-based <see cref="T:System.Array" /> that contains the keys to sort.</param>
	/// <param name="items">The one-dimensional, zero-based <see cref="T:System.Array" /> that contains the items that correspond to the keys in <paramref name="keys" />, or <see langword="null" /> to sort only <paramref name="keys" />.</param>
	/// <param name="index">The starting index of the range to sort.</param>
	/// <param name="length">The number of elements in the range to sort.</param>
	/// <param name="comparer">The <see cref="T:System.Collections.Generic.IComparer`1" /> generic interface implementation to use when comparing elements, or <see langword="null" /> to use the <see cref="T:System.IComparable`1" /> generic interface implementation of each element.</param>
	/// <typeparam name="TKey">The type of the elements of the key array.</typeparam>
	/// <typeparam name="TValue">The type of the elements of the items array.</typeparam>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="keys" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than the lower bound of <paramref name="keys" />.  
	/// -or-  
	/// <paramref name="length" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="items" /> is not <see langword="null" />, and the lower bound of <paramref name="keys" /> does not match the lower bound of <paramref name="items" />.  
	/// -or-  
	/// <paramref name="items" /> is not <see langword="null" />, and the length of <paramref name="keys" /> is greater than the length of <paramref name="items" />.  
	/// -or-  
	/// <paramref name="index" /> and <paramref name="length" /> do not specify a valid range in the <paramref name="keys" /><see cref="T:System.Array" />.  
	/// -or-  
	/// <paramref name="items" /> is not <see langword="null" />, and <paramref name="index" /> and <paramref name="length" /> do not specify a valid range in the <paramref name="items" /><see cref="T:System.Array" />.  
	/// -or-  
	/// The implementation of <paramref name="comparer" /> caused an error during the sort. For example, <paramref name="comparer" /> might not return 0 when comparing an item with itself.</exception>
	/// <exception cref="T:System.InvalidOperationException">
	///   <paramref name="comparer" /> is <see langword="null" />, and one or more elements in the <paramref name="keys" /><see cref="T:System.Array" /> do not implement the <see cref="T:System.IComparable`1" /> generic interface.</exception>
	public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length, IComparer<TKey> comparer)
	{
	}

	/// <summary>Determines whether the specified array contains elements that match the conditions defined by the specified predicate.</summary>
	/// <param name="array">The one-dimensional, zero-based <see cref="T:System.Array" /> to search.</param>
	/// <param name="match">The <see cref="T:System.Predicate`1" /> that defines the conditions of the elements to search for.</param>
	/// <typeparam name="T">The type of the elements of the array.</typeparam>
	/// <returns>
	///   <see langword="true" /> if <paramref name="array" /> contains one or more elements that match the conditions defined by the specified predicate; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="match" /> is <see langword="null" />.</exception>
	public static bool Exists<T>(T[] array, Predicate<T> match)
	{
		return false;
	}

	public static void Fill<T>(T[] array, T value)
	{
	}

	public static void Fill<T>(T[] array, T value, int startIndex, int count)
	{
	}

	/// <summary>Searches for an element that matches the conditions defined by the specified predicate, and returns the first occurrence within the entire <see cref="T:System.Array" />.</summary>
	/// <param name="array">The one-dimensional, zero-based array to search.</param>
	/// <param name="match">The predicate that defines the conditions of the element to search for.</param>
	/// <typeparam name="T">The type of the elements of the array.</typeparam>
	/// <returns>The first element that matches the conditions defined by the specified predicate, if found; otherwise, the default value for type <paramref name="T" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="match" /> is <see langword="null" />.</exception>
	public static T Find<T>(T[] array, Predicate<T> match)
	{
		return default(T);
	}

	/// <summary>Retrieves all the elements that match the conditions defined by the specified predicate.</summary>
	/// <param name="array">The one-dimensional, zero-based <see cref="T:System.Array" /> to search.</param>
	/// <param name="match">The <see cref="T:System.Predicate`1" /> that defines the conditions of the elements to search for.</param>
	/// <typeparam name="T">The type of the elements of the array.</typeparam>
	/// <returns>An <see cref="T:System.Array" /> containing all the elements that match the conditions defined by the specified predicate, if found; otherwise, an empty <see cref="T:System.Array" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="match" /> is <see langword="null" />.</exception>
	public static T[] FindAll<T>(T[] array, Predicate<T> match)
	{
		return null;
	}

	/// <summary>Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the first occurrence within the entire <see cref="T:System.Array" />.</summary>
	/// <param name="array">The one-dimensional, zero-based <see cref="T:System.Array" /> to search.</param>
	/// <param name="match">The <see cref="T:System.Predicate`1" /> that defines the conditions of the element to search for.</param>
	/// <typeparam name="T">The type of the elements of the array.</typeparam>
	/// <returns>The zero-based index of the first occurrence of an element that matches the conditions defined by <paramref name="match" />, if found; otherwise, -1.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="match" /> is <see langword="null" />.</exception>
	public static int FindIndex<T>(T[] array, Predicate<T> match)
	{
		return 0;
	}

	/// <summary>Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the first occurrence within the range of elements in the <see cref="T:System.Array" /> that extends from the specified index to the last element.</summary>
	/// <param name="array">The one-dimensional, zero-based <see cref="T:System.Array" /> to search.</param>
	/// <param name="startIndex">The zero-based starting index of the search.</param>
	/// <param name="match">The <see cref="T:System.Predicate`1" /> that defines the conditions of the element to search for.</param>
	/// <typeparam name="T">The type of the elements of the array.</typeparam>
	/// <returns>The zero-based index of the first occurrence of an element that matches the conditions defined by <paramref name="match" />, if found; otherwise, -1.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="match" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="array" />.</exception>
	public static int FindIndex<T>(T[] array, int startIndex, Predicate<T> match)
	{
		return 0;
	}

	/// <summary>Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the first occurrence within the range of elements in the <see cref="T:System.Array" /> that starts at the specified index and contains the specified number of elements.</summary>
	/// <param name="array">The one-dimensional, zero-based <see cref="T:System.Array" /> to search.</param>
	/// <param name="startIndex">The zero-based starting index of the search.</param>
	/// <param name="count">The number of elements in the section to search.</param>
	/// <param name="match">The <see cref="T:System.Predicate`1" /> that defines the conditions of the element to search for.</param>
	/// <typeparam name="T">The type of the elements of the array.</typeparam>
	/// <returns>The zero-based index of the first occurrence of an element that matches the conditions defined by <paramref name="match" />, if found; otherwise, -1.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="match" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="array" />.  
	/// -or-  
	/// <paramref name="count" /> is less than zero.  
	/// -or-  
	/// <paramref name="startIndex" /> and <paramref name="count" /> do not specify a valid section in <paramref name="array" />.</exception>
	public static int FindIndex<T>(T[] array, int startIndex, int count, Predicate<T> match)
	{
		return 0;
	}

	/// <summary>Searches for an element that matches the conditions defined by the specified predicate, and returns the last occurrence within the entire <see cref="T:System.Array" />.</summary>
	/// <param name="array">The one-dimensional, zero-based <see cref="T:System.Array" /> to search.</param>
	/// <param name="match">The <see cref="T:System.Predicate`1" /> that defines the conditions of the element to search for.</param>
	/// <typeparam name="T">The type of the elements of the array.</typeparam>
	/// <returns>The last element that matches the conditions defined by the specified predicate, if found; otherwise, the default value for type <paramref name="T" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="match" /> is <see langword="null" />.</exception>
	public static T FindLast<T>(T[] array, Predicate<T> match)
	{
		return default(T);
	}

	/// <summary>Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the last occurrence within the entire <see cref="T:System.Array" />.</summary>
	/// <param name="array">The one-dimensional, zero-based <see cref="T:System.Array" /> to search.</param>
	/// <param name="match">The <see cref="T:System.Predicate`1" /> that defines the conditions of the element to search for.</param>
	/// <typeparam name="T">The type of the elements of the array.</typeparam>
	/// <returns>The zero-based index of the last occurrence of an element that matches the conditions defined by <paramref name="match" />, if found; otherwise, -1.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="match" /> is <see langword="null" />.</exception>
	public static int FindLastIndex<T>(T[] array, Predicate<T> match)
	{
		return 0;
	}

	/// <summary>Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the last occurrence within the range of elements in the <see cref="T:System.Array" /> that extends from the first element to the specified index.</summary>
	/// <param name="array">The one-dimensional, zero-based <see cref="T:System.Array" /> to search.</param>
	/// <param name="startIndex">The zero-based starting index of the backward search.</param>
	/// <param name="match">The <see cref="T:System.Predicate`1" /> that defines the conditions of the element to search for.</param>
	/// <typeparam name="T">The type of the elements of the array.</typeparam>
	/// <returns>The zero-based index of the last occurrence of an element that matches the conditions defined by <paramref name="match" />, if found; otherwise, -1.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="match" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="array" />.</exception>
	public static int FindLastIndex<T>(T[] array, int startIndex, Predicate<T> match)
	{
		return 0;
	}

	/// <summary>Searches for an element that matches the conditions defined by the specified predicate, and returns the zero-based index of the last occurrence within the range of elements in the <see cref="T:System.Array" /> that contains the specified number of elements and ends at the specified index.</summary>
	/// <param name="array">The one-dimensional, zero-based <see cref="T:System.Array" /> to search.</param>
	/// <param name="startIndex">The zero-based starting index of the backward search.</param>
	/// <param name="count">The number of elements in the section to search.</param>
	/// <param name="match">The <see cref="T:System.Predicate`1" /> that defines the conditions of the element to search for.</param>
	/// <typeparam name="T">The type of the elements of the array.</typeparam>
	/// <returns>The zero-based index of the last occurrence of an element that matches the conditions defined by <paramref name="match" />, if found; otherwise, -1.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="match" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="startIndex" /> is outside the range of valid indexes for <paramref name="array" />.  
	/// -or-  
	/// <paramref name="count" /> is less than zero.  
	/// -or-  
	/// <paramref name="startIndex" /> and <paramref name="count" /> do not specify a valid section in <paramref name="array" />.</exception>
	public static int FindLastIndex<T>(T[] array, int startIndex, int count, Predicate<T> match)
	{
		return 0;
	}

	/// <summary>Determines whether every element in the array matches the conditions defined by the specified predicate.</summary>
	/// <param name="array">The one-dimensional, zero-based <see cref="T:System.Array" /> to check against the conditions.</param>
	/// <param name="match">The predicate that defines the conditions to check against the elements.</param>
	/// <typeparam name="T">The type of the elements of the array.</typeparam>
	/// <returns>
	///   <see langword="true" /> if every element in <paramref name="array" /> matches the conditions defined by the specified predicate; otherwise, <see langword="false" />. If there are no elements in the array, the return value is <see langword="true" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="match" /> is <see langword="null" />.</exception>
	public static bool TrueForAll<T>(T[] array, Predicate<T> match)
	{
		return false;
	}

	/// <summary>Returns an <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Array" />.</summary>
	/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Array" />.</returns>
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	private Array()
	{
	}

	internal int InternalArray__ICollection_get_Count()
	{
		return 0;
	}

	internal bool InternalArray__ICollection_get_IsReadOnly()
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal ref byte GetRawSzArrayData()
	{
		throw null;
	}

	internal IEnumerator<T> InternalArray__IEnumerable_GetEnumerator<T>()
	{
		return null;
	}

	internal void InternalArray__ICollection_Clear()
	{
	}

	internal void InternalArray__ICollection_Add<T>(T item)
	{
	}

	internal bool InternalArray__ICollection_Remove<T>(T item)
	{
		return false;
	}

	internal bool InternalArray__ICollection_Contains<T>(T item)
	{
		return false;
	}

	internal void InternalArray__ICollection_CopyTo<T>(T[] array, int arrayIndex)
	{
	}

	internal T InternalArray__IReadOnlyList_get_Item<T>(int index)
	{
		return default(T);
	}

	internal int InternalArray__IReadOnlyCollection_get_Count()
	{
		return 0;
	}

	internal void InternalArray__Insert<T>(int index, T item)
	{
	}

	internal void InternalArray__RemoveAt(int index)
	{
	}

	internal int InternalArray__IndexOf<T>(T item)
	{
		return 0;
	}

	internal T InternalArray__get_Item<T>(int index)
	{
		return default(T);
	}

	internal void InternalArray__set_Item<T>(int index, T item)
	{
	}

	internal void GetGenericValueImpl<T>(int pos, out T value)
	{
		value = default(T);
	}

	internal void SetGenericValueImpl<T>(int pos, ref T value)
	{
	}

	private int GetRank()
	{
		return 0;
	}

	/// <summary>Gets a 32-bit integer that represents the number of elements in the specified dimension of the <see cref="T:System.Array" />.</summary>
	/// <param name="dimension">A zero-based dimension of the <see cref="T:System.Array" /> whose length needs to be determined.</param>
	/// <returns>A 32-bit integer that represents the number of elements in the specified dimension.</returns>
	/// <exception cref="T:System.IndexOutOfRangeException">
	///   <paramref name="dimension" /> is less than zero.  
	/// -or-  
	/// <paramref name="dimension" /> is equal to or greater than <see cref="P:System.Array.Rank" />.</exception>
	public int GetLength(int dimension)
	{
		return 0;
	}

	/// <summary>Gets the index of the first element of the specified dimension in the array.</summary>
	/// <param name="dimension">A zero-based dimension of the array whose starting index needs to be determined.</param>
	/// <returns>The index of the first element of the specified dimension in the array.</returns>
	/// <exception cref="T:System.IndexOutOfRangeException">
	///   <paramref name="dimension" /> is less than zero.  
	/// -or-  
	/// <paramref name="dimension" /> is equal to or greater than <see cref="P:System.Array.Rank" />.</exception>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public int GetLowerBound(int dimension)
	{
		return 0;
	}

	/// <summary>Gets the value at the specified position in the multidimensional <see cref="T:System.Array" />. The indexes are specified as an array of 32-bit integers.</summary>
	/// <param name="indices">A one-dimensional array of 32-bit integers that represent the indexes specifying the position of the <see cref="T:System.Array" /> element to get.</param>
	/// <returns>The value at the specified position in the multidimensional <see cref="T:System.Array" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="indices" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The number of dimensions in the current <see cref="T:System.Array" /> is not equal to the number of elements in <paramref name="indices" />.</exception>
	/// <exception cref="T:System.IndexOutOfRangeException">Any element in <paramref name="indices" /> is outside the range of valid indexes for the corresponding dimension of the current <see cref="T:System.Array" />.</exception>
	public object GetValue(params int[] indices)
	{
		return null;
	}

	/// <summary>Sets a value to the element at the specified position in the multidimensional <see cref="T:System.Array" />. The indexes are specified as an array of 32-bit integers.</summary>
	/// <param name="value">The new value for the specified element.</param>
	/// <param name="indices">A one-dimensional array of 32-bit integers that represent the indexes specifying the position of the element to set.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="indices" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The number of dimensions in the current <see cref="T:System.Array" /> is not equal to the number of elements in <paramref name="indices" />.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> cannot be cast to the element type of the current <see cref="T:System.Array" />.</exception>
	/// <exception cref="T:System.IndexOutOfRangeException">Any element in <paramref name="indices" /> is outside the range of valid indexes for the corresponding dimension of the current <see cref="T:System.Array" />.</exception>
	public void SetValue(object value, params int[] indices)
	{
	}

	internal object GetValueImpl(int pos)
	{
		return null;
	}

	internal void SetValueImpl(object value, int pos)
	{
	}

	internal static bool FastCopy(Array source, int source_idx, Array dest, int dest_idx, int length)
	{
		return false;
	}

	internal static Array CreateInstanceImpl(Type elementType, int[] lengths, int[] bounds)
	{
		return null;
	}

	/// <summary>Gets the index of the last element of the specified dimension in the array.</summary>
	/// <param name="dimension">A zero-based dimension of the array whose upper bound needs to be determined.</param>
	/// <returns>The index of the last element of the specified dimension in the array, or -1 if the specified dimension is empty.</returns>
	/// <exception cref="T:System.IndexOutOfRangeException">
	///   <paramref name="dimension" /> is less than zero.  
	/// -or-  
	/// <paramref name="dimension" /> is equal to or greater than <see cref="P:System.Array.Rank" />.</exception>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public int GetUpperBound(int dimension)
	{
		return 0;
	}

	/// <summary>Gets the value at the specified position in the one-dimensional <see cref="T:System.Array" />. The index is specified as a 32-bit integer.</summary>
	/// <param name="index">A 32-bit integer that represents the position of the <see cref="T:System.Array" /> element to get.</param>
	/// <returns>The value at the specified position in the one-dimensional <see cref="T:System.Array" />.</returns>
	/// <exception cref="T:System.ArgumentException">The current <see cref="T:System.Array" /> does not have exactly one dimension.</exception>
	/// <exception cref="T:System.IndexOutOfRangeException">
	///   <paramref name="index" /> is outside the range of valid indexes for the current <see cref="T:System.Array" />.</exception>
	public object GetValue(int index)
	{
		return null;
	}

	/// <summary>Gets the value at the specified position in the two-dimensional <see cref="T:System.Array" />. The indexes are specified as 32-bit integers.</summary>
	/// <param name="index1">A 32-bit integer that represents the first-dimension index of the <see cref="T:System.Array" /> element to get.</param>
	/// <param name="index2">A 32-bit integer that represents the second-dimension index of the <see cref="T:System.Array" /> element to get.</param>
	/// <returns>The value at the specified position in the two-dimensional <see cref="T:System.Array" />.</returns>
	/// <exception cref="T:System.ArgumentException">The current <see cref="T:System.Array" /> does not have exactly two dimensions.</exception>
	/// <exception cref="T:System.IndexOutOfRangeException">Either <paramref name="index1" /> or <paramref name="index2" /> is outside the range of valid indexes for the corresponding dimension of the current <see cref="T:System.Array" />.</exception>
	public object GetValue(int index1, int index2)
	{
		return null;
	}

	/// <summary>Gets the value at the specified position in the three-dimensional <see cref="T:System.Array" />. The indexes are specified as 32-bit integers.</summary>
	/// <param name="index1">A 32-bit integer that represents the first-dimension index of the <see cref="T:System.Array" /> element to get.</param>
	/// <param name="index2">A 32-bit integer that represents the second-dimension index of the <see cref="T:System.Array" /> element to get.</param>
	/// <param name="index3">A 32-bit integer that represents the third-dimension index of the <see cref="T:System.Array" /> element to get.</param>
	/// <returns>The value at the specified position in the three-dimensional <see cref="T:System.Array" />.</returns>
	/// <exception cref="T:System.ArgumentException">The current <see cref="T:System.Array" /> does not have exactly three dimensions.</exception>
	/// <exception cref="T:System.IndexOutOfRangeException">
	///   <paramref name="index1" /> or <paramref name="index2" /> or <paramref name="index3" /> is outside the range of valid indexes for the corresponding dimension of the current <see cref="T:System.Array" />.</exception>
	public object GetValue(int index1, int index2, int index3)
	{
		return null;
	}

	/// <summary>Sets a value to the element at the specified position in the one-dimensional <see cref="T:System.Array" />. The index is specified as a 32-bit integer.</summary>
	/// <param name="value">The new value for the specified element.</param>
	/// <param name="index">A 32-bit integer that represents the position of the <see cref="T:System.Array" /> element to set.</param>
	/// <exception cref="T:System.ArgumentException">The current <see cref="T:System.Array" /> does not have exactly one dimension.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> cannot be cast to the element type of the current <see cref="T:System.Array" />.</exception>
	/// <exception cref="T:System.IndexOutOfRangeException">
	///   <paramref name="index" /> is outside the range of valid indexes for the current <see cref="T:System.Array" />.</exception>
	public void SetValue(object value, int index)
	{
	}

	/// <summary>Sets a value to the element at the specified position in the two-dimensional <see cref="T:System.Array" />. The indexes are specified as 32-bit integers.</summary>
	/// <param name="value">The new value for the specified element.</param>
	/// <param name="index1">A 32-bit integer that represents the first-dimension index of the <see cref="T:System.Array" /> element to set.</param>
	/// <param name="index2">A 32-bit integer that represents the second-dimension index of the <see cref="T:System.Array" /> element to set.</param>
	/// <exception cref="T:System.ArgumentException">The current <see cref="T:System.Array" /> does not have exactly two dimensions.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> cannot be cast to the element type of the current <see cref="T:System.Array" />.</exception>
	/// <exception cref="T:System.IndexOutOfRangeException">Either <paramref name="index1" /> or <paramref name="index2" /> is outside the range of valid indexes for the corresponding dimension of the current <see cref="T:System.Array" />.</exception>
	public void SetValue(object value, int index1, int index2)
	{
	}

	/// <summary>Sets a value to the element at the specified position in the three-dimensional <see cref="T:System.Array" />. The indexes are specified as 32-bit integers.</summary>
	/// <param name="value">The new value for the specified element.</param>
	/// <param name="index1">A 32-bit integer that represents the first-dimension index of the <see cref="T:System.Array" /> element to set.</param>
	/// <param name="index2">A 32-bit integer that represents the second-dimension index of the <see cref="T:System.Array" /> element to set.</param>
	/// <param name="index3">A 32-bit integer that represents the third-dimension index of the <see cref="T:System.Array" /> element to set.</param>
	/// <exception cref="T:System.ArgumentException">The current <see cref="T:System.Array" /> does not have exactly three dimensions.</exception>
	/// <exception cref="T:System.InvalidCastException">
	///   <paramref name="value" /> cannot be cast to the element type of the current <see cref="T:System.Array" />.</exception>
	/// <exception cref="T:System.IndexOutOfRangeException">
	///   <paramref name="index1" /> or <paramref name="index2" /> or <paramref name="index3" /> is outside the range of valid indexes for the corresponding dimension of the current <see cref="T:System.Array" />.</exception>
	public void SetValue(object value, int index1, int index2, int index3)
	{
	}

	internal static Array UnsafeCreateInstance(Type elementType, int[] lengths, int[] lowerBounds)
	{
		return null;
	}

	internal static Array UnsafeCreateInstance(Type elementType, int length1, int length2)
	{
		return null;
	}

	internal static Array UnsafeCreateInstance(Type elementType, params int[] lengths)
	{
		return null;
	}

	/// <summary>Creates a one-dimensional <see cref="T:System.Array" /> of the specified <see cref="T:System.Type" /> and length, with zero-based indexing.</summary>
	/// <param name="elementType">The <see cref="T:System.Type" /> of the <see cref="T:System.Array" /> to create.</param>
	/// <param name="length">The size of the <see cref="T:System.Array" /> to create.</param>
	/// <returns>A new one-dimensional <see cref="T:System.Array" /> of the specified <see cref="T:System.Type" /> with the specified length, using zero-based indexing.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="elementType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="elementType" /> is not a valid <see cref="T:System.Type" />.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="elementType" /> is not supported. For example, <see cref="T:System.Void" /> is not supported.  
	/// -or-  
	/// <paramref name="elementType" /> is an open generic type.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="length" /> is less than zero.</exception>
	public static Array CreateInstance(Type elementType, int length)
	{
		return null;
	}

	/// <summary>Creates a two-dimensional <see cref="T:System.Array" /> of the specified <see cref="T:System.Type" /> and dimension lengths, with zero-based indexing.</summary>
	/// <param name="elementType">The <see cref="T:System.Type" /> of the <see cref="T:System.Array" /> to create.</param>
	/// <param name="length1">The size of the first dimension of the <see cref="T:System.Array" /> to create.</param>
	/// <param name="length2">The size of the second dimension of the <see cref="T:System.Array" /> to create.</param>
	/// <returns>A new two-dimensional <see cref="T:System.Array" /> of the specified <see cref="T:System.Type" /> with the specified length for each dimension, using zero-based indexing.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="elementType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="elementType" /> is not a valid <see cref="T:System.Type" />.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="elementType" /> is not supported. For example, <see cref="T:System.Void" /> is not supported.  
	/// -or-  
	/// <paramref name="elementType" /> is an open generic type.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="length1" /> is less than zero.  
	/// -or-  
	/// <paramref name="length2" /> is less than zero.</exception>
	public static Array CreateInstance(Type elementType, int length1, int length2)
	{
		return null;
	}

	/// <summary>Creates a three-dimensional <see cref="T:System.Array" /> of the specified <see cref="T:System.Type" /> and dimension lengths, with zero-based indexing.</summary>
	/// <param name="elementType">The <see cref="T:System.Type" /> of the <see cref="T:System.Array" /> to create.</param>
	/// <param name="length1">The size of the first dimension of the <see cref="T:System.Array" /> to create.</param>
	/// <param name="length2">The size of the second dimension of the <see cref="T:System.Array" /> to create.</param>
	/// <param name="length3">The size of the third dimension of the <see cref="T:System.Array" /> to create.</param>
	/// <returns>A new three-dimensional <see cref="T:System.Array" /> of the specified <see cref="T:System.Type" /> with the specified length for each dimension, using zero-based indexing.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="elementType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="elementType" /> is not a valid <see cref="T:System.Type" />.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="elementType" /> is not supported. For example, <see cref="T:System.Void" /> is not supported.  
	/// -or-  
	/// <paramref name="elementType" /> is an open generic type.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="length1" /> is less than zero.  
	/// -or-  
	/// <paramref name="length2" /> is less than zero.  
	/// -or-  
	/// <paramref name="length3" /> is less than zero.</exception>
	public static Array CreateInstance(Type elementType, int length1, int length2, int length3)
	{
		return null;
	}

	/// <summary>Creates a multidimensional <see cref="T:System.Array" /> of the specified <see cref="T:System.Type" /> and dimension lengths, with zero-based indexing. The dimension lengths are specified in an array of 32-bit integers.</summary>
	/// <param name="elementType">The <see cref="T:System.Type" /> of the <see cref="T:System.Array" /> to create.</param>
	/// <param name="lengths">An array of 32-bit integers that represent the size of each dimension of the <see cref="T:System.Array" /> to create.</param>
	/// <returns>A new multidimensional <see cref="T:System.Array" /> of the specified <see cref="T:System.Type" /> with the specified length for each dimension, using zero-based indexing.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="elementType" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="lengths" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="elementType" /> is not a valid <see cref="T:System.Type" />.  
	/// -or-  
	/// The <paramref name="lengths" /> array contains less than one element.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="elementType" /> is not supported. For example, <see cref="T:System.Void" /> is not supported.  
	/// -or-  
	/// <paramref name="elementType" /> is an open generic type.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Any value in <paramref name="lengths" /> is less than zero.</exception>
	public static Array CreateInstance(Type elementType, params int[] lengths)
	{
		return null;
	}

	/// <summary>Creates a multidimensional <see cref="T:System.Array" /> of the specified <see cref="T:System.Type" /> and dimension lengths, with the specified lower bounds.</summary>
	/// <param name="elementType">The <see cref="T:System.Type" /> of the <see cref="T:System.Array" /> to create.</param>
	/// <param name="lengths">A one-dimensional array that contains the size of each dimension of the <see cref="T:System.Array" /> to create.</param>
	/// <param name="lowerBounds">A one-dimensional array that contains the lower bound (starting index) of each dimension of the <see cref="T:System.Array" /> to create.</param>
	/// <returns>A new multidimensional <see cref="T:System.Array" /> of the specified <see cref="T:System.Type" /> with the specified length and lower bound for each dimension.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="elementType" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="lengths" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="lowerBounds" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="elementType" /> is not a valid <see cref="T:System.Type" />.  
	/// -or-  
	/// The <paramref name="lengths" /> array contains less than one element.  
	/// -or-  
	/// The <paramref name="lengths" /> and <paramref name="lowerBounds" /> arrays do not contain the same number of elements.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="elementType" /> is not supported. For example, <see cref="T:System.Void" /> is not supported.  
	/// -or-  
	/// <paramref name="elementType" /> is an open generic type.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">Any value in <paramref name="lengths" /> is less than zero.  
	///  -or-  
	///  Any value in <paramref name="lowerBounds" /> is very large, such that the sum of a dimension's lower bound and length is greater than <see cref="F:System.Int32.MaxValue" />.</exception>
	public static Array CreateInstance(Type elementType, int[] lengths, int[] lowerBounds)
	{
		return null;
	}

	/// <summary>Sets a range of elements in an array to the default value of each element type.</summary>
	/// <param name="array">The array whose elements need to be cleared.</param>
	/// <param name="index">The starting index of the range of elements to clear.</param>
	/// <param name="length">The number of elements to clear.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.IndexOutOfRangeException">
	///   <paramref name="index" /> is less than the lower bound of <paramref name="array" />.  
	/// -or-  
	/// <paramref name="length" /> is less than zero.  
	/// -or-  
	/// The sum of <paramref name="index" /> and <paramref name="length" /> is greater than the size of <paramref name="array" />.</exception>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static void Clear(Array array, int index, int length)
	{
	}

	private static void ClearInternal(Array a, int index, int count)
	{
	}

	/// <summary>Copies a range of elements from an <see cref="T:System.Array" /> starting at the first element and pastes them into another <see cref="T:System.Array" /> starting at the first element. The length is specified as a 32-bit integer.</summary>
	/// <param name="sourceArray">The <see cref="T:System.Array" /> that contains the data to copy.</param>
	/// <param name="destinationArray">The <see cref="T:System.Array" /> that receives the data.</param>
	/// <param name="length">A 32-bit integer that represents the number of elements to copy.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="sourceArray" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="destinationArray" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.RankException">
	///   <paramref name="sourceArray" /> and <paramref name="destinationArray" /> have different ranks.</exception>
	/// <exception cref="T:System.ArrayTypeMismatchException">
	///   <paramref name="sourceArray" /> and <paramref name="destinationArray" /> are of incompatible types.</exception>
	/// <exception cref="T:System.InvalidCastException">At least one element in <paramref name="sourceArray" /> cannot be cast to the type of <paramref name="destinationArray" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="length" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="length" /> is greater than the number of elements in <paramref name="sourceArray" />.  
	/// -or-  
	/// <paramref name="length" /> is greater than the number of elements in <paramref name="destinationArray" />.</exception>
	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	public static void Copy(Array sourceArray, Array destinationArray, int length)
	{
	}

	/// <summary>Copies a range of elements from an <see cref="T:System.Array" /> starting at the specified source index and pastes them to another <see cref="T:System.Array" /> starting at the specified destination index. The length and the indexes are specified as 32-bit integers.</summary>
	/// <param name="sourceArray">The <see cref="T:System.Array" /> that contains the data to copy.</param>
	/// <param name="sourceIndex">A 32-bit integer that represents the index in the <paramref name="sourceArray" /> at which copying begins.</param>
	/// <param name="destinationArray">The <see cref="T:System.Array" /> that receives the data.</param>
	/// <param name="destinationIndex">A 32-bit integer that represents the index in the <paramref name="destinationArray" /> at which storing begins.</param>
	/// <param name="length">A 32-bit integer that represents the number of elements to copy.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="sourceArray" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="destinationArray" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.RankException">
	///   <paramref name="sourceArray" /> and <paramref name="destinationArray" /> have different ranks.</exception>
	/// <exception cref="T:System.ArrayTypeMismatchException">
	///   <paramref name="sourceArray" /> and <paramref name="destinationArray" /> are of incompatible types.</exception>
	/// <exception cref="T:System.InvalidCastException">At least one element in <paramref name="sourceArray" /> cannot be cast to the type of <paramref name="destinationArray" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="sourceIndex" /> is less than the lower bound of the first dimension of <paramref name="sourceArray" />.  
	/// -or-  
	/// <paramref name="destinationIndex" /> is less than the lower bound of the first dimension of <paramref name="destinationArray" />.  
	/// -or-  
	/// <paramref name="length" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="length" /> is greater than the number of elements from <paramref name="sourceIndex" /> to the end of <paramref name="sourceArray" />.  
	/// -or-  
	/// <paramref name="length" /> is greater than the number of elements from <paramref name="destinationIndex" /> to the end of <paramref name="destinationArray" />.</exception>
	[ReliabilityContract(Consistency.MayCorruptInstance, Cer.MayFail)]
	public static void Copy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length)
	{
	}

	private static ArrayTypeMismatchException CreateArrayTypeMismatchException()
	{
		return null;
	}

	private static bool CanAssignArrayElement(Type source, Type target)
	{
		return false;
	}

	/// <summary>Copies a range of elements from an <see cref="T:System.Array" /> starting at the specified source index and pastes them to another <see cref="T:System.Array" /> starting at the specified destination index.  Guarantees that all changes are undone if the copy does not succeed completely.</summary>
	/// <param name="sourceArray">The <see cref="T:System.Array" /> that contains the data to copy.</param>
	/// <param name="sourceIndex">A 32-bit integer that represents the index in the <paramref name="sourceArray" /> at which copying begins.</param>
	/// <param name="destinationArray">The <see cref="T:System.Array" /> that receives the data.</param>
	/// <param name="destinationIndex">A 32-bit integer that represents the index in the <paramref name="destinationArray" /> at which storing begins.</param>
	/// <param name="length">A 32-bit integer that represents the number of elements to copy.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="sourceArray" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="destinationArray" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.RankException">
	///   <paramref name="sourceArray" /> and <paramref name="destinationArray" /> have different ranks.</exception>
	/// <exception cref="T:System.ArrayTypeMismatchException">The <paramref name="sourceArray" /> type is neither the same as nor derived from the <paramref name="destinationArray" /> type.</exception>
	/// <exception cref="T:System.InvalidCastException">At least one element in <paramref name="sourceArray" /> cannot be cast to the type of <paramref name="destinationArray" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="sourceIndex" /> is less than the lower bound of the first dimension of <paramref name="sourceArray" />.  
	/// -or-  
	/// <paramref name="destinationIndex" /> is less than the lower bound of the first dimension of <paramref name="destinationArray" />.  
	/// -or-  
	/// <paramref name="length" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="length" /> is greater than the number of elements from <paramref name="sourceIndex" /> to the end of <paramref name="sourceArray" />.  
	/// -or-  
	/// <paramref name="length" /> is greater than the number of elements from <paramref name="destinationIndex" /> to the end of <paramref name="destinationArray" />.</exception>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static void ConstrainedCopy(Array sourceArray, int sourceIndex, Array destinationArray, int destinationIndex, int length)
	{
	}

	/// <summary>Returns an empty array.</summary>
	/// <typeparam name="T">The type of the elements of the array.</typeparam>
	/// <returns>An empty array.</returns>
	public static T[] Empty<T>()
	{
		return null;
	}

	/// <summary>Initializes every element of the value-type <see cref="T:System.Array" /> by calling the default constructor of the value type.</summary>
	public void Initialize()
	{
	}

	private static int IndexOfImpl<T>(T[] array, T value, int startIndex, int count)
	{
		return 0;
	}

	private static int LastIndexOfImpl<T>(T[] array, T value, int startIndex, int count)
	{
		return 0;
	}

	private static void SortImpl(Array keys, Array items, int index, int length, IComparer comparer)
	{
	}

	internal static T UnsafeLoad<T>(T[] array, int index)
	{
		return default(T);
	}

	internal static void UnsafeStore<T>(T[] array, int index, T value)
	{
	}

	internal static R UnsafeMov<S, R>(S instance)
	{
		return default(R);
	}
}
