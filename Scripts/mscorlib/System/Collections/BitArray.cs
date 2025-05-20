namespace System.Collections;

/// <summary>Manages a compact array of bit values, which are represented as Booleans, where <see langword="true" /> indicates that the bit is on (1) and <see langword="false" /> indicates the bit is off (0).</summary>
[Serializable]
public sealed class BitArray : ICollection, IEnumerable, ICloneable
{
	[Serializable]
	private class BitArrayEnumeratorSimple : IEnumerator, ICloneable
	{
		private BitArray bitarray;

		private int index;

		private int version;

		private bool currentElement;

		public virtual object Current => null;

		internal BitArrayEnumeratorSimple(BitArray bitarray)
		{
		}

		public object Clone()
		{
			return null;
		}

		public virtual bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}
	}

	private int[] m_array;

	private int m_length;

	private int _version;

	[NonSerialized]
	private object _syncRoot;

	/// <summary>Gets or sets the value of the bit at a specific position in the <see cref="T:System.Collections.BitArray" />.</summary>
	/// <param name="index">The zero-based index of the value to get or set.</param>
	/// <returns>The value of the bit at position <paramref name="index" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than zero.  
	/// -or-  
	/// <paramref name="index" /> is equal to or greater than <see cref="P:System.Collections.BitArray.Count" />.</exception>
	public bool this[int index]
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the number of elements in the <see cref="T:System.Collections.BitArray" />.</summary>
	/// <returns>The number of elements in the <see cref="T:System.Collections.BitArray" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The property is set to a value that is less than zero.</exception>
	public int Length
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>Gets the number of elements contained in the <see cref="T:System.Collections.BitArray" />.</summary>
	/// <returns>The number of elements contained in the <see cref="T:System.Collections.BitArray" />.</returns>
	public int Count => 0;

	/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.BitArray" />.</summary>
	/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Collections.BitArray" />.</returns>
	public object SyncRoot => null;

	/// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.BitArray" /> is synchronized (thread safe).</summary>
	/// <returns>This property is always <see langword="false" />.</returns>
	public bool IsSynchronized => false;

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.BitArray" /> class that can hold the specified number of bit values, which are initially set to <see langword="false" />.</summary>
	/// <param name="length">The number of bit values in the new <see cref="T:System.Collections.BitArray" />.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="length" /> is less than zero.</exception>
	public BitArray(int length)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.BitArray" /> class that can hold the specified number of bit values, which are initially set to the specified value.</summary>
	/// <param name="length">The number of bit values in the new <see cref="T:System.Collections.BitArray" />.</param>
	/// <param name="defaultValue">The Boolean value to assign to each bit.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="length" /> is less than zero.</exception>
	public BitArray(int length, bool defaultValue)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.BitArray" /> class that contains bit values copied from the specified <see cref="T:System.Collections.BitArray" />.</summary>
	/// <param name="bits">The <see cref="T:System.Collections.BitArray" /> to copy.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="bits" /> is <see langword="null" />.</exception>
	public BitArray(BitArray bits)
	{
	}

	/// <summary>Gets the value of the bit at a specific position in the <see cref="T:System.Collections.BitArray" />.</summary>
	/// <param name="index">The zero-based index of the value to get.</param>
	/// <returns>The value of the bit at position <paramref name="index" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than zero.  
	/// -or-  
	/// <paramref name="index" /> is greater than or equal to the number of elements in the <see cref="T:System.Collections.BitArray" />.</exception>
	public bool Get(int index)
	{
		return false;
	}

	/// <summary>Sets the bit at a specific position in the <see cref="T:System.Collections.BitArray" /> to the specified value.</summary>
	/// <param name="index">The zero-based index of the bit to set.</param>
	/// <param name="value">The Boolean value to assign to the bit.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than zero.  
	/// -or-  
	/// <paramref name="index" /> is greater than or equal to the number of elements in the <see cref="T:System.Collections.BitArray" />.</exception>
	public void Set(int index, bool value)
	{
	}

	/// <summary>Sets all bits in the <see cref="T:System.Collections.BitArray" /> to the specified value.</summary>
	/// <param name="value">The Boolean value to assign to all bits.</param>
	public void SetAll(bool value)
	{
	}

	/// <summary>Copies the entire <see cref="T:System.Collections.BitArray" /> to a compatible one-dimensional <see cref="T:System.Array" />, starting at the specified index of the target array.</summary>
	/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from <see cref="T:System.Collections.BitArray" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
	/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="array" /> is multidimensional.  
	/// -or-  
	/// The number of elements in the source <see cref="T:System.Collections.BitArray" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />.</exception>
	/// <exception cref="T:System.InvalidCastException">The type of the source <see cref="T:System.Collections.BitArray" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception>
	public void CopyTo(Array array, int index)
	{
	}

	/// <summary>Creates a shallow copy of the <see cref="T:System.Collections.BitArray" />.</summary>
	/// <returns>A shallow copy of the <see cref="T:System.Collections.BitArray" />.</returns>
	public object Clone()
	{
		return null;
	}

	/// <summary>Returns an enumerator that iterates through the <see cref="T:System.Collections.BitArray" />.</summary>
	/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for the entire <see cref="T:System.Collections.BitArray" />.</returns>
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	private static int GetArrayLength(int n, int div)
	{
		return 0;
	}
}
