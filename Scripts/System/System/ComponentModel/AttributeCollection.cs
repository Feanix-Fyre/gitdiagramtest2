using System.Collections;

namespace System.ComponentModel;

/// <summary>Represents a collection of attributes.</summary>
public class AttributeCollection : ICollection, IEnumerable
{
	private struct AttributeEntry
	{
		public Type type;

		public int index;
	}

	/// <summary>Specifies an empty collection that you can use, rather than creating a new one. This field is read-only.</summary>
	public static readonly AttributeCollection Empty;

	private static Hashtable s_defaultAttributes;

	private readonly Attribute[] _attributes;

	private static readonly object s_internalSyncObject;

	private AttributeEntry[] _foundAttributeTypes;

	private int _index;

	/// <summary>Gets the attribute collection.</summary>
	/// <returns>The attribute collection.</returns>
	protected virtual Attribute[] Attributes => null;

	/// <summary>Gets the number of attributes.</summary>
	/// <returns>The number of attributes.</returns>
	public int Count => 0;

	/// <summary>Gets the attribute with the specified index number.</summary>
	/// <param name="index">The zero-based index of <see cref="T:System.ComponentModel.AttributeCollection" />.</param>
	/// <returns>The <see cref="T:System.Attribute" /> with the specified index number.</returns>
	public virtual Attribute this[int index] => null;

	/// <summary>Gets the attribute with the specified type.</summary>
	/// <param name="attributeType">The <see cref="T:System.Type" /> of the <see cref="T:System.Attribute" /> to get from the collection.</param>
	/// <returns>The <see cref="T:System.Attribute" /> with the specified type or, if the attribute does not exist, the default value for the attribute type.</returns>
	public virtual Attribute this[Type attributeType] => null;

	/// <summary>Gets a value indicating whether access to the collection is synchronized (thread-safe).</summary>
	/// <returns>
	///   <see langword="true" /> if access to the collection is synchronized (thread-safe); otherwise, <see langword="false" />.</returns>
	bool ICollection.IsSynchronized => false;

	/// <summary>Gets an object that can be used to synchronize access to the collection.</summary>
	/// <returns>An object that can be used to synchronize access to the collection.</returns>
	object ICollection.SyncRoot => null;

	/// <summary>Gets the number of elements contained in the collection.</summary>
	/// <returns>The number of elements contained in the collection.</returns>
	int ICollection.Count => 0;

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.AttributeCollection" /> class.</summary>
	/// <param name="attributes">An array of type <see cref="T:System.Attribute" /> that provides the attributes for this collection.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="attributes" /> is <see langword="null" />.</exception>
	public AttributeCollection(params Attribute[] attributes)
	{
	}

	/// <summary>Determines whether this collection of attributes has the specified attribute.</summary>
	/// <param name="attribute">An <see cref="T:System.Attribute" /> to find in the collection.</param>
	/// <returns>
	///   <see langword="true" /> if the collection contains the attribute or is the default attribute for the type of attribute; otherwise, <see langword="false" />.</returns>
	public bool Contains(Attribute attribute)
	{
		return false;
	}

	/// <summary>Returns the default <see cref="T:System.Attribute" /> of a given <see cref="T:System.Type" />.</summary>
	/// <param name="attributeType">The <see cref="T:System.Type" /> of the attribute to retrieve.</param>
	/// <returns>The default <see cref="T:System.Attribute" /> of a given <paramref name="attributeType" />.</returns>
	protected Attribute GetDefaultAttribute(Type attributeType)
	{
		return null;
	}

	/// <summary>Gets an enumerator for this collection.</summary>
	/// <returns>An enumerator of type <see cref="T:System.Collections.IEnumerator" />.</returns>
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	/// <summary>Returns an <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Collections.IDictionary" />.</summary>
	/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for the <see cref="T:System.Collections.IDictionary" />.</returns>
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	/// <summary>Copies the collection to an array, starting at the specified index.</summary>
	/// <param name="array">The <see cref="T:System.Array" /> to copy the collection to.</param>
	/// <param name="index">The index to start from.</param>
	public void CopyTo(Array array, int index)
	{
	}
}
