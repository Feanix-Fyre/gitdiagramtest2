using System.Runtime.CompilerServices;

namespace System.Collections.Generic;

/// <summary>Provides a base class for implementations of the <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> generic interface.</summary>
/// <typeparam name="T">The type of objects to compare.</typeparam>
[Serializable]
[TypeDependency("System.Collections.Generic.ObjectEqualityComparer`1")]
public abstract class EqualityComparer<T> : IEqualityComparer, IEqualityComparer<T>
{
	private static EqualityComparer<T> defaultComparer;

	/// <summary>Returns a default equality comparer for the type specified by the generic argument.</summary>
	/// <returns>The default instance of the <see cref="T:System.Collections.Generic.EqualityComparer`1" /> class for type <typeparamref name="T" />.</returns>
	public static EqualityComparer<T> Default
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return null;
		}
	}

	private static EqualityComparer<T> CreateComparer()
	{
		return null;
	}

	/// <summary>When overridden in a derived class, determines whether two objects of type <typeparamref name="T" /> are equal.</summary>
	/// <param name="x">The first object to compare.</param>
	/// <param name="y">The second object to compare.</param>
	/// <returns>
	///   <see langword="true" /> if the specified objects are equal; otherwise, <see langword="false" />.</returns>
	public abstract bool Equals(T x, T y);

	/// <summary>When overridden in a derived class, serves as a hash function for the specified object for hashing algorithms and data structures, such as a hash table.</summary>
	/// <param name="obj">The object for which to get a hash code.</param>
	/// <returns>A hash code for the specified object.</returns>
	/// <exception cref="T:System.ArgumentNullException">The type of <paramref name="obj" /> is a reference type and <paramref name="obj" /> is <see langword="null" />.</exception>
	public abstract int GetHashCode(T obj);

	internal virtual int IndexOf(T[] array, T value, int startIndex, int count)
	{
		return 0;
	}

	internal virtual int LastIndexOf(T[] array, T value, int startIndex, int count)
	{
		return 0;
	}

	/// <summary>Returns a hash code for the specified object.</summary>
	/// <param name="obj">The <see cref="T:System.Object" /> for which a hash code is to be returned.</param>
	/// <returns>A hash code for the specified object.</returns>
	/// <exception cref="T:System.ArgumentNullException">The type of <paramref name="obj" /> is a reference type and <paramref name="obj" /> is <see langword="null" />.  
	///  -or-  
	///  <paramref name="obj" /> is of a type that cannot be cast to type <typeparamref name="T" />.</exception>
	int IEqualityComparer.GetHashCode(object obj)
	{
		return 0;
	}

	/// <summary>Determines whether the specified objects are equal.</summary>
	/// <param name="x">The first object to compare.</param>
	/// <param name="y">The second object to compare.</param>
	/// <returns>
	///   <see langword="true" /> if the specified objects are equal; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="x" /> or <paramref name="y" /> is of a type that cannot be cast to type <typeparamref name="T" />.</exception>
	bool IEqualityComparer.Equals(object x, object y)
	{
		return false;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Generic.EqualityComparer`1" /> class.</summary>
	protected EqualityComparer()
	{
	}
}
