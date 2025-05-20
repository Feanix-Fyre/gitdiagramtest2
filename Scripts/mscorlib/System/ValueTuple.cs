using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System;

/// <summary>Provides static methods for creating value tuples.</summary>
[Serializable]
[StructLayout((LayoutKind)0, Size = 1)]
public struct ValueTuple : IEquatable<ValueTuple>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple>, IValueTupleInternal, ITuple
{
	/// <summary>Gets the length of this <see langword="ValueTuple" /> instance, which is always 0. There are no elements in a <see langword="ValueTuple" />.</summary>
	/// <returns>0, the number of elements in this <see langword="ValueTuple" /> instance.</returns>
	int ITuple.Length => 0;

	/// <summary>Returns a value that indicates whether the current <see cref="T:System.ValueTuple" /> instance is equal to a specified object.</summary>
	/// <param name="obj">The object to compare to the current instance.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="obj" /> is a <see cref="T:System.ValueTuple" /> instance; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Determines whether two <see cref="T:System.ValueTuple" /> instances are equal. This method always returns <see langword="true" />.</summary>
	/// <param name="other">The value tuple to compare with the current instance.</param>
	/// <returns>This method always returns <see langword="true" />.</returns>
	public bool Equals(ValueTuple other)
	{
		return false;
	}

	/// <summary>Returns a value that indicates whether the current <see cref="T:System.ValueTuple" /> instance is equal to a specified object based on a specified comparison method.</summary>
	/// <param name="other">The object to compare with this instance.</param>
	/// <param name="comparer">An object that defines the method to use to evaluate whether the two objects are equal.</param>
	/// <returns>
	///   <see langword="true" /> if the current instance is equal to the specified object; otherwise, <see langword="false" />.</returns>
	bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
	{
		return false;
	}

	/// <summary>Compares this <see cref="T:System.ValueTuple" /> instance with a specified object and returns an indication of their relative values.</summary>
	/// <param name="other">The object to compare with the current instance</param>
	/// <returns>0 if <paramref name="other" /> is a <see cref="T:System.ValueTuple" /> instance; otherwise, 1 if <paramref name="other" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="other" /> is not a <see cref="T:System.ValueTuple" /> instance.</exception>
	int IComparable.CompareTo(object other)
	{
		return 0;
	}

	/// <summary>Compares the current <see cref="T:System.ValueTuple" /> instance to a specified <see cref="T:System.ValueTuple" /> instance.</summary>
	/// <param name="other">The object to compare with the current instance.</param>
	/// <returns>This method always returns 0.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="other" /> is not a <see cref="T:System.ValueTuple" /> instance.</exception>
	public int CompareTo(ValueTuple other)
	{
		return 0;
	}

	/// <summary>Compares the current <see cref="T:System.ValueTuple" /> instance to a specified object.</summary>
	/// <param name="other">The object to compare with the current instance.</param>
	/// <param name="comparer">An object that provides custom rules for comparison. This parameter is ignored.</param>
	/// <returns>Returns 0 if <paramref name="other" /> is a <see cref="T:System.ValueTuple" /> instance and 1 if <paramref name="other" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="other" /> is not a <see cref="T:System.ValueTuple" /> instance.</exception>
	int IStructuralComparable.CompareTo(object other, IComparer comparer)
	{
		return 0;
	}

	/// <summary>Returns the hash code for the current <see cref="T:System.ValueTuple" /> instance.</summary>
	/// <returns>This method always return 0.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Returns the hash code for this <see cref="T:System.ValueTuple" /> instance.</summary>
	/// <param name="comparer">An object whose <see cref="M:System.Collections.IEqualityComparer.GetHashCode(System.Object)" /> method computes the hash code. This parameter is ignored.</param>
	/// <returns>The hash code for this <see cref="T:System.ValueTuple" /> instance.</returns>
	int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
	{
		return 0;
	}

	int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
	{
		return 0;
	}

	/// <summary>Returns the string representation of this <see cref="T:System.ValueTuple" /> instance.</summary>
	/// <returns>This method always returns "()".</returns>
	public override string ToString()
	{
		return null;
	}

	string IValueTupleInternal.ToStringEnd()
	{
		return null;
	}

	internal static int CombineHashCodes(int h1, int h2)
	{
		return 0;
	}

	internal static int CombineHashCodes(int h1, int h2, int h3)
	{
		return 0;
	}

	internal static int CombineHashCodes(int h1, int h2, int h3, int h4)
	{
		return 0;
	}

	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5)
	{
		return 0;
	}

	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6)
	{
		return 0;
	}

	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7)
	{
		return 0;
	}

	internal static int CombineHashCodes(int h1, int h2, int h3, int h4, int h5, int h6, int h7, int h8)
	{
		return 0;
	}
}
/// <summary>Represents a value tuple with a single component.</summary>
/// <typeparam name="T1">The type of the value tuple's only element.</typeparam>
[Serializable]
public struct ValueTuple<T1> : IEquatable<ValueTuple<T1>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1>>, IValueTupleInternal, ITuple
{
	/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`1" /> instance's first element.</summary>
	public T1 Item1;

	/// <summary>Gets the number of elements in the <see langword="ValueTuple" />.</summary>
	/// <returns>1, the number of elements in a <see cref="T:System.ValueTuple`1" /> object.</returns>
	int ITuple.Length => 0;

	/// <summary>Initializes a new <see cref="T:System.ValueTuple`1" /> instance.</summary>
	/// <param name="item1">The value tuple's first element.</param>
	public ValueTuple(T1 item1)
	{
		Item1 = default(T1);
	}

	/// <summary>Returns a value that indicates whether the current <see cref="T:System.ValueTuple`1" /> instance is equal to a specified object.</summary>
	/// <param name="obj">The object to compare with this instance.</param>
	/// <returns>
	///   <see langword="true" /> if the current instance is equal to the specified object; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Returns a value that indicates whether the current <see cref="T:System.ValueTuple`1" /> instance is equal to a specified <see cref="T:System.ValueTuple`1" /> instance.</summary>
	/// <param name="other">The value tuple to compare with this instance.</param>
	/// <returns>
	///   <see langword="true" /> if the current instance is equal to the specified tuple; otherwise, <see langword="false" />.</returns>
	public bool Equals(ValueTuple<T1> other)
	{
		return false;
	}

	/// <summary>Returns a value that indicates whether the current <see cref="T:System.ValueTuple`1" /> instance is equal to a specified object based on a specified comparison method.</summary>
	/// <param name="other">The object to compare with this instance.</param>
	/// <param name="comparer">An object that defines the method to use to evaluate whether the two objects are equal.</param>
	/// <returns>
	///   <see langword="true" /> if the current instance is equal to the specified object; otherwise, <see langword="false" />.</returns>
	bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
	{
		return false;
	}

	/// <summary>Compares the current <see cref="T:System.ValueTuple`1" /> instance to a specified object by using a specified comparer and returns an integer that indicates whether the current object is before, after, or in the same position as the specified object in the sort order.</summary>
	/// <param name="other">The object to compare with the current instance.</param>
	/// <returns>A signed integer that indicates the relative position of this instance and <paramref name="obj" /> in the sort order, as shown in the following table.  
	///   Value  
	///
	///   Description  
	///
	///   A negative integer  
	///
	///   This instance precedes <paramref name="other" />.  
	///
	///   Zero  
	///
	///   This instance and <paramref name="other" /> have the same position in the sort order.  
	///
	///   A positive integer  
	///
	///   This instance follows <paramref name="other" />.</returns>
	int IComparable.CompareTo(object other)
	{
		return 0;
	}

	/// <summary>Compares the current <see cref="T:System.ValueTuple`1" /> instance to a specified <see cref="T:System.ValueTuple`1" /> instance.</summary>
	/// <param name="other">The tuple to compare with this instance.</param>
	/// <returns>A signed integer that indicates the relative position of this instance and <paramref name="other" /> in the sort order, as shown in the following table.  
	///   Value  
	///
	///   Description  
	///
	///   A negative integer  
	///
	///   This instance precedes <paramref name="other" />.  
	///
	///   Zero  
	///
	///   This instance and <paramref name="other" /> have the same position in the sort order.  
	///
	///   A positive integer  
	///
	///   This instance follows <paramref name="other" />.</returns>
	public int CompareTo(ValueTuple<T1> other)
	{
		return 0;
	}

	/// <summary>Compares the current <see cref="T:System.ValueTuple`1" /> instance to a specified object by using a specified comparer and returns an integer that indicates whether the current object is before, after, or in the same position as the specified object in the sort order.</summary>
	/// <param name="other">The object to compare with the current instance.</param>
	/// <param name="comparer">An object that provides custom rules for comparison.</param>
	/// <returns>A signed integer that indicates the relative position of this instance and <paramref name="other" /> in the sort order, as shown in the following table.  
	///   Vaue  
	///
	///   Description  
	///
	///   A negative integer  
	///
	///   This instance precedes <paramref name="other" />.  
	///
	///   Zero  
	///
	///   This instance and <paramref name="other" /> have the same position in the sort order.  
	///
	///   A positive integer  
	///
	///   This instance follows <paramref name="other" />.</returns>
	int IStructuralComparable.CompareTo(object other, IComparer comparer)
	{
		return 0;
	}

	/// <summary>Calculates the hash code for the current <see cref="T:System.ValueTuple`1" /> instance.</summary>
	/// <returns>The hash code for the current <see cref="T:System.ValueTuple`1" /> instance.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Calculates the hash code for the current <see cref="T:System.ValueTuple`1" /> instance by using a specified computation method.</summary>
	/// <param name="comparer">An object whose <see cref="M:System.Collections.IEqualityComparer.GetHashCode(System.Object)" /> method calculates the hash code of the current <see cref="T:System.ValueTuple`1" /> instance.</param>
	/// <returns>A 32-bit signed integer hash code.</returns>
	int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
	{
		return 0;
	}

	int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
	{
		return 0;
	}

	/// <summary>Returns a string that represents the value of this <see cref="T:System.ValueTuple`1" /> instance.</summary>
	/// <returns>The string representation of this <see cref="T:System.ValueTuple`1" /> instance.</returns>
	public override string ToString()
	{
		return null;
	}

	string IValueTupleInternal.ToStringEnd()
	{
		return null;
	}
}
/// <summary>Represents a value tuple with 2 components.</summary>
/// <typeparam name="T1">The type of the value tuple's first element.</typeparam>
/// <typeparam name="T2">The type of the value tuple's second element.</typeparam>
[Serializable]
[StructLayout((LayoutKind)3)]
public struct ValueTuple<T1, T2> : IEquatable<(T1, T2)>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<(T1, T2)>, IValueTupleInternal, ITuple
{
	/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`2" /> instance's first element.</summary>
	public T1 Item1;

	/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`2" /> instance's second element.</summary>
	public T2 Item2;

	/// <summary>Gets the number of elements in the <see langword="ValueTuple" />.</summary>
	/// <returns>2, the number of elements in a <see cref="T:System.ValueTuple`2" /> object.</returns>
	int ITuple.Length => 0;

	/// <summary>Initializes a new <see cref="T:System.ValueTuple`2" /> instance.</summary>
	/// <param name="item1">The value tuple's first element.</param>
	/// <param name="item2">The value tuple's second element.</param>
	public ValueTuple(T1 item1, T2 item2)
	{
		Item1 = default(T1);
		Item2 = default(T2);
	}

	/// <summary>Returns a value that indicates whether the current <see cref="T:System.ValueTuple`2" /> instance is equal to a specified object.</summary>
	/// <param name="obj">The object to compare with this instance.</param>
	/// <returns>
	///   <see langword="true" /> if the current instance is equal to the specified object; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals((T1, T2) other)
	{
		return false;
	}

	/// <summary>Returns a value that indicates whether the current <see cref="T:System.ValueTuple`2" /> instance is equal to a specified object based on a specified comparison method.</summary>
	/// <param name="other">The object to compare with this instance.</param>
	/// <param name="comparer">An object that defines the method to use to evaluate whether the two objects are equal.</param>
	/// <returns>
	///   <see langword="true" /> if the current instance is equal to the specified objects; otherwise, <see langword="false" />.</returns>
	bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
	{
		return false;
	}

	/// <summary>Compares the current <see cref="T:System.ValueTuple`2" /> instance to a specified object by using a specified comparer and returns an integer that indicates whether the current object is before, after, or in the same position as the specified object in the sort order.</summary>
	/// <param name="other">The object to compare with the current instance.</param>
	/// <returns>A signed integer that indicates the relative position of this instance and <paramref name="obj" /> in the sort order, as shown in the following table.  
	///   Value  
	///
	///   Description  
	///
	///   A negative integer  
	///
	///   This instance precedes <paramref name="other" />.  
	///
	///   Zero  
	///
	///   This instance and <paramref name="other" /> have the same position in the sort order.  
	///
	///   A positive integer  
	///
	///   This instance follows <paramref name="other" />.</returns>
	int IComparable.CompareTo(object other)
	{
		return 0;
	}

	public int CompareTo((T1, T2) other)
	{
		return 0;
	}

	/// <summary>Compares the current <see cref="T:System.ValueTuple`2" /> instance to a specified object by using a specified comparer and returns an integer that indicates whether the current object is before, after, or in the same position as the specified object in the sort order.</summary>
	/// <param name="other">The object to compare with the current instance.</param>
	/// <param name="comparer">An object that provides custom rules for comparison.</param>
	/// <returns>A signed integer that indicates the relative position of this instance and <paramref name="other" /> in the sort order, as shown in the following table.  
	///   Value  
	///
	///   Description  
	///
	///   A negative integer  
	///
	///   This instance precedes <paramref name="other" />.  
	///
	///   Zero  
	///
	///   This instance and <paramref name="other" /> have the same position in the sort order.  
	///
	///   A positive integer  
	///
	///   This instance follows <paramref name="other" />.</returns>
	int IStructuralComparable.CompareTo(object other, IComparer comparer)
	{
		return 0;
	}

	/// <summary>Calculates the hash code for the current <see cref="T:System.ValueTuple`2" /> instance.</summary>
	/// <returns>The hash code for the current <see cref="T:System.ValueTuple`2" /> instance.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Calculates the hash code for the current <see cref="T:System.ValueTuple`2" /> instance by using a specified computation method.</summary>
	/// <param name="comparer">An object whose <see cref="M:System.Collections.IEqualityComparer.GetHashCode(System.Object)" /> method calculates the hash code of the current <see cref="T:System.ValueTuple`2" /> instance.</param>
	/// <returns>A 32-bit signed integer hash code.</returns>
	int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
	{
		return 0;
	}

	private int GetHashCodeCore(IEqualityComparer comparer)
	{
		return 0;
	}

	int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
	{
		return 0;
	}

	/// <summary>Returns a string that represents the value of this <see cref="T:System.ValueTuple`2" /> instance.</summary>
	/// <returns>The string representation of this <see cref="T:System.ValueTuple`2" /> instance.</returns>
	public override string ToString()
	{
		return null;
	}

	string IValueTupleInternal.ToStringEnd()
	{
		return null;
	}
}
/// <summary>Represents a value tuple with 3 components.</summary>
/// <typeparam name="T1">The type of the value tuple's first element.</typeparam>
/// <typeparam name="T2">The type of the value tuple's second element.</typeparam>
/// <typeparam name="T3">The type of the value tuple's third element.</typeparam>
[Serializable]
[StructLayout((LayoutKind)3)]
public struct ValueTuple<T1, T2, T3> : IEquatable<(T1, T2, T3)>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<(T1, T2, T3)>, IValueTupleInternal, ITuple
{
	/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`3" /> instance's first element.</summary>
	public T1 Item1;

	/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`3" /> instance's second element.</summary>
	public T2 Item2;

	/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`3" /> instance's third element.</summary>
	public T3 Item3;

	/// <summary>Gets the number of elements in the <see langword="ValueTuple" />.</summary>
	/// <returns>3, the number of elements in a <see cref="T:System.ValueTuple`3" /> object.</returns>
	int ITuple.Length => 0;

	/// <summary>Initializes a new <see cref="T:System.ValueTuple`3" /> instance.</summary>
	/// <param name="item1">The value tuple's first element.</param>
	/// <param name="item2">The value tuple's second element.</param>
	/// <param name="item3">The value tuple's third element.</param>
	public ValueTuple(T1 item1, T2 item2, T3 item3)
	{
		Item1 = default(T1);
		Item2 = default(T2);
		Item3 = default(T3);
	}

	/// <summary>Returns a value that indicates whether the current <see cref="T:System.ValueTuple`3" /> instance is equal to a specified object.</summary>
	/// <param name="obj">The object to compare with this instance.</param>
	/// <returns>
	///   <see langword="true" /> if the current instance is equal to the specified object; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals((T1, T2, T3) other)
	{
		return false;
	}

	/// <summary>Returns a value that indicates whether the current <see cref="T:System.ValueTuple`3" /> instance is equal to a specified object based on a specified comparison method.</summary>
	/// <param name="other">The object to compare with this instance.</param>
	/// <param name="comparer">An object that defines the method to use to evaluate whether the two objects are equal.</param>
	/// <returns>
	///   <see langword="true" /> if the current instance is equal to the specified objects; otherwise, <see langword="false" />.</returns>
	bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
	{
		return false;
	}

	/// <summary>Compares the current <see cref="T:System.ValueTuple`3" /> instance to a specified object by using a specified comparer and returns an integer that indicates whether the current object is before, after, or in the same position as the specified object in the sort order.</summary>
	/// <param name="other">The object to compare with the current instance.</param>
	/// <returns>A signed integer that indicates the relative position of this instance and <paramref name="obj" /> in the sort order, as shown in the following table.  
	///   Value  
	///
	///   Description  
	///
	///   A negative integer  
	///
	///   This instance precedes <paramref name="other" />.  
	///
	///   Zero  
	///
	///   This instance and <paramref name="other" /> have the same position in the sort order.  
	///
	///   A positive integer  
	///
	///   This instance follows <paramref name="other" />.</returns>
	int IComparable.CompareTo(object other)
	{
		return 0;
	}

	public int CompareTo((T1, T2, T3) other)
	{
		return 0;
	}

	/// <summary>Compares the current <see cref="T:System.ValueTuple`3" /> instance to a specified object by using a specified comparer and returns an integer that indicates whether the current object is before, after, or in the same position as the specified object in the sort order.</summary>
	/// <param name="other">The object to compare with the current instance.</param>
	/// <param name="comparer">An object that provides custom rules for comparison.</param>
	/// <returns>A signed integer that indicates the relative position of this instance and <paramref name="other" /> in the sort order, as shown in the following table.  
	///   Value  
	///
	///   Description  
	///
	///   A negative integer  
	///
	///   This instance precedes <paramref name="other" />.  
	///
	///   Zero  
	///
	///   This instance and <paramref name="other" /> have the same position in the sort order.  
	///
	///   A positive integer  
	///
	///   This instance follows <paramref name="other" />.</returns>
	int IStructuralComparable.CompareTo(object other, IComparer comparer)
	{
		return 0;
	}

	/// <summary>Calculates the hash code for the current <see cref="T:System.ValueTuple`3" /> instance.</summary>
	/// <returns>The hash code for the current <see cref="T:System.ValueTuple`3" /> instance.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Calculates the hash code for the current <see cref="T:System.ValueTuple`3" /> instance by using a specified computation method.</summary>
	/// <param name="comparer">An object whose <see cref="M:System.Collections.IEqualityComparer.GetHashCode(System.Object)" /> method calculates the hash code of the current <see cref="T:System.ValueTuple`3" /> instance.</param>
	/// <returns>A 32-bit signed integer hash code.</returns>
	int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
	{
		return 0;
	}

	private int GetHashCodeCore(IEqualityComparer comparer)
	{
		return 0;
	}

	int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
	{
		return 0;
	}

	/// <summary>Returns a string that represents the value of this <see cref="T:System.ValueTuple`3" /> instance.</summary>
	/// <returns>The string representation of this <see cref="T:System.ValueTuple`2" /> instance.</returns>
	public override string ToString()
	{
		return null;
	}

	string IValueTupleInternal.ToStringEnd()
	{
		return null;
	}
}
/// <summary>Represents a value tuple with 4 components.</summary>
/// <typeparam name="T1">The type of the value tuple's first element.</typeparam>
/// <typeparam name="T2">The type of the value tuple's second element.</typeparam>
/// <typeparam name="T3">The type of the value tuple's third element.</typeparam>
/// <typeparam name="T4">The type of the value tuple's fourth element.</typeparam>
[Serializable]
[StructLayout((LayoutKind)3)]
public struct ValueTuple<T1, T2, T3, T4> : IEquatable<(T1, T2, T3, T4)>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<(T1, T2, T3, T4)>, IValueTupleInternal, ITuple
{
	/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`4" /> instance's first element.</summary>
	public T1 Item1;

	/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`4" /> instance's second element.</summary>
	public T2 Item2;

	/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`4" /> instance's third element.</summary>
	public T3 Item3;

	/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`4" /> instance's fourth element.</summary>
	public T4 Item4;

	/// <summary>Gets the number of elements in the <see langword="ValueTuple" />.</summary>
	/// <returns>4, the number of elements in a <see cref="T:System.ValueTuple`4" /> object.</returns>
	int ITuple.Length => 0;

	/// <summary>Initializes a new <see cref="T:System.ValueTuple`4" /> instance.</summary>
	/// <param name="item1">The value tuple's first element.</param>
	/// <param name="item2">The value tuple's second element.</param>
	/// <param name="item3">The value tuple's third element.</param>
	/// <param name="item4">The value tuple's fourth element.</param>
	public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4)
	{
		Item1 = default(T1);
		Item2 = default(T2);
		Item3 = default(T3);
		Item4 = default(T4);
	}

	/// <summary>Returns a value that indicates whether the current <see cref="T:System.ValueTuple`4" /> instance is equal to a specified object.</summary>
	/// <param name="obj">The object to compare with this instance.</param>
	/// <returns>
	///   <see langword="true" /> if the current instance is equal to the specified object; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals((T1, T2, T3, T4) other)
	{
		return false;
	}

	/// <summary>Returns a value that indicates whether the current <see cref="T:System.ValueTuple`4" /> instance is equal to a specified object based on a specified comparison method.</summary>
	/// <param name="other">The object to compare with this instance.</param>
	/// <param name="comparer">An object that defines the method to use to evaluate whether the two objects are equal.</param>
	/// <returns>
	///   <see langword="true" /> if the current instance is equal to the specified objects; otherwise, <see langword="false" />.</returns>
	bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
	{
		return false;
	}

	/// <summary>Compares the current <see cref="T:System.ValueTuple`4" /> instance to a specified object by using a specified comparer and returns an integer that indicates whether the current object is before, after, or in the same position as the specified object in the sort order.</summary>
	/// <param name="other">The object to compare with the current instance.</param>
	/// <returns>A signed integer that indicates the relative position of this instance and <paramref name="obj" /> in the sort order, as shown in the following table.  
	///   Value  
	///
	///   Description  
	///
	///   A negative integer  
	///
	///   This instance precedes <paramref name="other" />.  
	///
	///   Zero  
	///
	///   This instance and <paramref name="other" /> have the same position in the sort order.  
	///
	///   A positive integer  
	///
	///   This instance follows <paramref name="other" />.</returns>
	int IComparable.CompareTo(object other)
	{
		return 0;
	}

	public int CompareTo((T1, T2, T3, T4) other)
	{
		return 0;
	}

	/// <summary>Compares the current <see cref="T:System.ValueTuple`4" /> instance to a specified object by using a specified comparer and returns an integer that indicates whether the current object is before, after, or in the same position as the specified object in the sort order.</summary>
	/// <param name="other">The object to compare with the current instance.</param>
	/// <param name="comparer">An object that provides custom rules for comparison.</param>
	/// <returns>A signed integer that indicates the relative position of this instance and <paramref name="other" /> in the sort order, as shown in the following table.  
	///   Vaue  
	///
	///   Description  
	///
	///   A negative integer  
	///
	///   This instance precedes <paramref name="other" />.  
	///
	///   Zero  
	///
	///   This instance and <paramref name="other" /> have the same position in the sort order.  
	///
	///   A positive integer  
	///
	///   This instance follows <paramref name="other" />.</returns>
	int IStructuralComparable.CompareTo(object other, IComparer comparer)
	{
		return 0;
	}

	/// <summary>Calculates the hash code for the current <see cref="T:System.ValueTuple`4" /> instance.</summary>
	/// <returns>The hash code for the current <see cref="T:System.ValueTuple`4" /> instance.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Calculates the hash code for the current <see cref="T:System.ValueTuple`4" /> instance by using a specified computation method.</summary>
	/// <param name="comparer">An object whose <see cref="M:System.Collections.IEqualityComparer.GetHashCode(System.Object)" /> method calculates the hash code of the current <see cref="T:System.ValueTuple`4" /> instance.</param>
	/// <returns>A 32-bit signed integer hash code.</returns>
	int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
	{
		return 0;
	}

	private int GetHashCodeCore(IEqualityComparer comparer)
	{
		return 0;
	}

	int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
	{
		return 0;
	}

	/// <summary>Returns a string that represents the value of this <see cref="T:System.ValueTuple`4" /> instance.</summary>
	/// <returns>The string representation of this <see cref="T:System.ValueTuple`4" /> instance.</returns>
	public override string ToString()
	{
		return null;
	}

	string IValueTupleInternal.ToStringEnd()
	{
		return null;
	}
}
/// <summary>Represents a value tuple with 5 components.</summary>
/// <typeparam name="T1">The type of the value tuple's first element.</typeparam>
/// <typeparam name="T2">The type of the value tuple's second element.</typeparam>
/// <typeparam name="T3">The type of the value tuple's third element.</typeparam>
/// <typeparam name="T4">The type of the value tuple's fourth element.</typeparam>
/// <typeparam name="T5">The type of the value tuple's fifth element.</typeparam>
[Serializable]
[StructLayout((LayoutKind)3)]
public struct ValueTuple<T1, T2, T3, T4, T5> : IEquatable<(T1, T2, T3, T4, T5)>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<(T1, T2, T3, T4, T5)>, IValueTupleInternal, ITuple
{
	/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`5" /> instance's first element.</summary>
	public T1 Item1;

	/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`5" /> instance's second element.</summary>
	public T2 Item2;

	/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`5" /> instance's third element.</summary>
	public T3 Item3;

	/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`5" /> instance's fourth element.</summary>
	public T4 Item4;

	/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`5" /> instance's fifth element.</summary>
	public T5 Item5;

	/// <summary>Gets the number of elements in the <see langword="ValueTuple" />.</summary>
	/// <returns>5, the number of elements in a <see cref="T:System.ValueTuple`5" /> object.</returns>
	int ITuple.Length => 0;

	/// <summary>Initializes a new <see cref="T:System.ValueTuple`5" /> instance.</summary>
	/// <param name="item1">The value tuple's first element.</param>
	/// <param name="item2">The value tuple's second element.</param>
	/// <param name="item3">The value tuple's third element.</param>
	/// <param name="item4">The value tuple's fourth element.</param>
	/// <param name="item5">The value tuple's fifth element.</param>
	public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5)
	{
		Item1 = default(T1);
		Item2 = default(T2);
		Item3 = default(T3);
		Item4 = default(T4);
		Item5 = default(T5);
	}

	/// <summary>Returns a value that indicates whether the current <see cref="T:System.ValueTuple`5" /> instance is equal to a specified object.</summary>
	/// <param name="obj">The object to compare with this instance.</param>
	/// <returns>
	///   <see langword="true" /> if the current instance is equal to the specified object; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals((T1, T2, T3, T4, T5) other)
	{
		return false;
	}

	/// <summary>Returns a value that indicates whether the current <see cref="T:System.ValueTuple`5" /> instance is equal to a specified object based on a specified comparison method.</summary>
	/// <param name="other">The object to compare with this instance.</param>
	/// <param name="comparer">An object that defines the method to use to evaluate whether the two objects are equal.</param>
	/// <returns>
	///   <see langword="true" /> if the current instance is equal to the specified objects; otherwise, <see langword="false" />.</returns>
	bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
	{
		return false;
	}

	/// <summary>Compares the current <see cref="T:System.ValueTuple`5" /> instance to a specified object by using a specified comparer and returns an integer that indicates whether the current object is before, after, or in the same position as the specified object in the sort order.</summary>
	/// <param name="other">The object to compare with the current instance.</param>
	/// <returns>A signed integer that indicates the relative position of this instance and <paramref name="obj" /> in the sort order, as shown in the following table.  
	///   Value  
	///
	///   Description  
	///
	///   A negative integer  
	///
	///   This instance precedes <paramref name="other" />.  
	///
	///   Zero  
	///
	///   This instance and <paramref name="other" /> have the same position in the sort order.  
	///
	///   A positive integer  
	///
	///   This instance follows <paramref name="other" />.</returns>
	int IComparable.CompareTo(object other)
	{
		return 0;
	}

	public int CompareTo((T1, T2, T3, T4, T5) other)
	{
		return 0;
	}

	/// <summary>Compares the current <see cref="T:System.ValueTuple`5" /> instance to a specified object by using a specified comparer and returns an integer that indicates whether the current object is before, after, or in the same position as the specified object in the sort order.</summary>
	/// <param name="other">The object to compare with the current instance.</param>
	/// <param name="comparer">An object that provides custom rules for comparison.</param>
	/// <returns>A signed integer that indicates the relative position of this instance and <paramref name="other" /> in the sort order, as shown in the following table.  
	///   Value  
	///
	///   Description  
	///
	///   A negative integer  
	///
	///   This instance precedes <paramref name="other" />.  
	///
	///   Zero  
	///
	///   This instance and <paramref name="other" /> have the same position in the sort order.  
	///
	///   A positive integer  
	///
	///   This instance follows <paramref name="other" />.</returns>
	int IStructuralComparable.CompareTo(object other, IComparer comparer)
	{
		return 0;
	}

	/// <summary>Calculates the hash code for the current <see cref="T:System.ValueTuple`5" /> instance.</summary>
	/// <returns>The hash code for the current <see cref="T:System.ValueTuple`5" /> instance.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Calculates the hash code for the current <see cref="T:System.ValueTuple`5" /> instance by using a specified computation method.</summary>
	/// <param name="comparer">An object whose <see cref="M:System.Collections.IEqualityComparer.GetHashCode(System.Object)" /> method calculates the hash code of the current <see cref="T:System.ValueTuple`5" /> instance.</param>
	/// <returns>A 32-bit signed integer hash code.</returns>
	int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
	{
		return 0;
	}

	private int GetHashCodeCore(IEqualityComparer comparer)
	{
		return 0;
	}

	int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
	{
		return 0;
	}

	/// <summary>Returns a string that represents the value of this <see cref="T:System.ValueTuple`5" /> instance.</summary>
	/// <returns>The string representation of this <see cref="T:System.ValueTuple`5" /> instance.</returns>
	public override string ToString()
	{
		return null;
	}

	string IValueTupleInternal.ToStringEnd()
	{
		return null;
	}
}
/// <summary>Represents an n-value tuple, where n is 8 or greater.</summary>
/// <typeparam name="T1">The type of the value tuple's first element.</typeparam>
/// <typeparam name="T2">The type of the value tuple's second element.</typeparam>
/// <typeparam name="T3">The type of the value tuple's third element.</typeparam>
/// <typeparam name="T4">The type of the value tuple's fourth element.</typeparam>
/// <typeparam name="T5">The type of the value tuple's fifth element.</typeparam>
/// <typeparam name="T6">The type of the value tuple's sixth element.</typeparam>
/// <typeparam name="T7">The type of the value tuple's seventh element.</typeparam>
/// <typeparam name="TRest">Any generic value tuple instance that defines the types of the tuple's remaining elements.</typeparam>
[Serializable]
[StructLayout((LayoutKind)3)]
public struct ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> : IEquatable<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest>>, IValueTupleInternal, ITuple where TRest : struct
{
	/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`8" /> instance's first element.</summary>
	public T1 Item1;

	/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`8" /> instance's second element.</summary>
	public T2 Item2;

	/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`8" /> instance's third element.</summary>
	public T3 Item3;

	/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`8" /> instance's fourth element.</summary>
	public T4 Item4;

	/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`8" /> instance's fifth element.</summary>
	public T5 Item5;

	/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`8" /> instance's sixth element.</summary>
	public T6 Item6;

	/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`8" /> instance's seventh element.</summary>
	public T7 Item7;

	/// <summary>Gets the current <see cref="T:System.ValueTuple`8" /> instance's remaining elements.</summary>
	public TRest Rest;

	/// <summary>Gets the number of elements in the <see langword="ValueTuple" />.</summary>
	/// <returns>The number of elements in the <see langword="ValueTuple" />.</returns>
	int ITuple.Length => 0;

	/// <summary>Initializes a new <see cref="T:System.ValueTuple`8" /> instance.</summary>
	/// <param name="item1">The value tuple's first element.</param>
	/// <param name="item2">The value tuple's second element.</param>
	/// <param name="item3">The value tuple's third element.</param>
	/// <param name="item4">The value tuple's fourth element.</param>
	/// <param name="item5">The value tuple's fifth element.</param>
	/// <param name="item6">The value tuple's sixth element.</param>
	/// <param name="item7">The value tuple's seventh element.</param>
	/// <param name="rest">An instance of any value tuple type that contains the values of the value's tuple's remaining elements.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="rest" /> is not a generic value tuple type.</exception>
	public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7, TRest rest)
	{
		Item1 = default(T1);
		Item2 = default(T2);
		Item3 = default(T3);
		Item4 = default(T4);
		Item5 = default(T5);
		Item6 = default(T6);
		Item7 = default(T7);
		Rest = default(TRest);
	}

	/// <summary>Returns a value that indicates whether the current <see cref="T:System.ValueTuple`8" /> instance is equal to a specified object.</summary>
	/// <param name="obj">The object to compare with this instance.</param>
	/// <returns>
	///   <see langword="true" /> if the current instance is equal to the specified object; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Returns a value that indicates whether the current <see cref="T:System.ValueTuple`8" /> instance is equal to a specified <see cref="T:System.ValueTuple`8" /> instance.</summary>
	/// <param name="other">The value tuple to compare with this instance.</param>
	/// <returns>
	///   <see langword="true" /> if the current instance is equal to the specified tuple; otherwise, <see langword="false" />.</returns>
	public bool Equals(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other)
	{
		return false;
	}

	/// <summary>Returns a value that indicates whether the current <see cref="T:System.ValueTuple`8" /> instance is equal to a specified object based on a specified comparison method.</summary>
	/// <param name="other">The object to compare with this instance.</param>
	/// <param name="comparer">An object that defines the method to use to evaluate whether the two objects are equal.</param>
	/// <returns>
	///   <see langword="true" /> if the current instance is equal to the specified objects; otherwise, <see langword="false" />.</returns>
	bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
	{
		return false;
	}

	/// <summary>Compares the current <see cref="T:System.ValueTuple`8" /> object to a specified object and returns an integer that indicates whether the current object is before, after, or in the same position as the specified object in the sort order.</summary>
	/// <param name="other">An object to compare with the current instance.</param>
	/// <returns>A signed integer that indicates the relative position of this instance and <paramref name="obj" /> in the sort order, as shown in the following table.  
	///   Value  
	///
	///   Description  
	///
	///   A negative integer  
	///
	///   This instance precedes <paramref name="other" />.  
	///
	///   Zero  
	///
	///   This instance and <paramref name="other" /> have the same position in the sort order.  
	///
	///   A positive integer  
	///
	///   This instance follows <paramref name="other" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="other" /> is not a <see cref="T:System.ValueTuple`8" /> object.</exception>
	int IComparable.CompareTo(object other)
	{
		return 0;
	}

	/// <summary>Compares the current <see cref="T:System.ValueTuple`8" /> instance to a specified <see cref="T:System.ValueTuple`8" /> instance</summary>
	/// <param name="other">The tuple to compare with this instance.</param>
	/// <returns>A signed integer that indicates the relative position of this instance and <paramref name="other" /> in the sort order, as shown in the following table.  
	///   Value  
	///
	///   Description  
	///
	///   A negative integer  
	///
	///   This instance precedes <paramref name="other" />.  
	///
	///   Zero  
	///
	///   This instance and <paramref name="other" /> have the same position in the sort order.  
	///
	///   A positive integer  
	///
	///   This instance follows <paramref name="other" />.</returns>
	public int CompareTo(ValueTuple<T1, T2, T3, T4, T5, T6, T7, TRest> other)
	{
		return 0;
	}

	/// <summary>Compares the current <see cref="T:System.ValueTuple`8" /> instance to a specified object by using a specified comparer and returns an integer that indicates whether the current object is before, after, or in the same position as the specified object in the sort order.</summary>
	/// <param name="other">The object to compare with the current instance.</param>
	/// <param name="comparer">An object that provides custom rules for comparison.</param>
	/// <returns>A signed integer that indicates the relative position of this instance and <paramref name="other" /> in the sort order, as shown in the following table.  
	///   Value  
	///
	///   Description  
	///
	///   A negative integer  
	///
	///   This instance precedes <paramref name="other" />.  
	///
	///   Zero  
	///
	///   This instance and <paramref name="other" /> have the same position in the sort order.  
	///
	///   A positive integer  
	///
	///   This instance follows <paramref name="other" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="other" /> is not a <see cref="T:System.ValueTuple`8" /> object.</exception>
	int IStructuralComparable.CompareTo(object other, IComparer comparer)
	{
		return 0;
	}

	/// <summary>Calculates the hash code for the current <see cref="T:System.ValueTuple`8" /> instance.</summary>
	/// <returns>The hash code for the current <see cref="T:System.ValueTuple`8" /> instance.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Calculates the hash code for the current <see cref="T:System.ValueTuple`8" /> instance by using a specified computation method.</summary>
	/// <param name="comparer">An object whose <see cref="M:System.Collections.IEqualityComparer.GetHashCode(System.Object)" /> method calculates the hash code of the current <see cref="T:System.ValueTuple`8" /> instance.</param>
	/// <returns>A 32-bit signed integer hash code.</returns>
	int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
	{
		return 0;
	}

	private int GetHashCodeCore(IEqualityComparer comparer)
	{
		return 0;
	}

	int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
	{
		return 0;
	}

	/// <summary>Returns a string that represents the value of this <see cref="T:System.ValueTuple`8" /> instance.</summary>
	/// <returns>The string representation of this <see cref="T:System.ValueTuple`8" /> instance.</returns>
	public override string ToString()
	{
		return null;
	}

	string IValueTupleInternal.ToStringEnd()
	{
		return null;
	}
}
