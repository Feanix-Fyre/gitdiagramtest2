using System.Collections;

namespace System.Runtime.Serialization;

/// <summary>Provides a formatter-friendly mechanism for parsing the data in <see cref="T:System.Runtime.Serialization.SerializationInfo" />. This class cannot be inherited.</summary>
public sealed class SerializationInfoEnumerator : IEnumerator
{
	private readonly string[] _members;

	private readonly object[] _data;

	private readonly Type[] _types;

	private readonly int _numItems;

	private int _currItem;

	private bool _current;

	/// <summary>Gets the current item in the collection.</summary>
	/// <returns>A <see cref="T:System.Runtime.Serialization.SerializationEntry" /> that contains the current serialization data.</returns>
	/// <exception cref="T:System.InvalidOperationException">The enumeration has not started or has already ended.</exception>
	object IEnumerator.Current => null;

	/// <summary>Gets the item currently being examined.</summary>
	/// <returns>The item currently being examined.</returns>
	/// <exception cref="T:System.InvalidOperationException">The enumerator has not started enumerating items or has reached the end of the enumeration.</exception>
	public SerializationEntry Current => default(SerializationEntry);

	/// <summary>Gets the name for the item currently being examined.</summary>
	/// <returns>The item name.</returns>
	/// <exception cref="T:System.InvalidOperationException">The enumerator has not started enumerating items or has reached the end of the enumeration.</exception>
	public string Name => null;

	/// <summary>Gets the value of the item currently being examined.</summary>
	/// <returns>The value of the item currently being examined.</returns>
	/// <exception cref="T:System.InvalidOperationException">The enumerator has not started enumerating items or has reached the end of the enumeration.</exception>
	public object Value => null;

	/// <summary>Gets the type of the item currently being examined.</summary>
	/// <returns>The type of the item currently being examined.</returns>
	/// <exception cref="T:System.InvalidOperationException">The enumerator has not started enumerating items or has reached the end of the enumeration.</exception>
	public Type ObjectType => null;

	internal SerializationInfoEnumerator(string[] members, object[] info, Type[] types, int numItems)
	{
	}

	/// <summary>Updates the enumerator to the next item.</summary>
	/// <returns>
	///   <see langword="true" /> if a new element is found; otherwise, <see langword="false" />.</returns>
	public bool MoveNext()
	{
		return false;
	}

	/// <summary>Resets the enumerator to the first item.</summary>
	public void Reset()
	{
	}
}
