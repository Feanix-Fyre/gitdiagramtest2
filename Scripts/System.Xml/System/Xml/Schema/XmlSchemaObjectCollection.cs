using System.Collections;

namespace System.Xml.Schema;

/// <summary>A collection of <see cref="T:System.Xml.Schema.XmlSchemaObject" />s.</summary>
public class XmlSchemaObjectCollection : CollectionBase
{
	private XmlSchemaObject parent;

	/// <summary>Gets the <see cref="T:System.Xml.Schema.XmlSchemaObject" /> at the specified index.</summary>
	/// <param name="index">The index of the <see cref="T:System.Xml.Schema.XmlSchemaObject" />. </param>
	/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaObject" /> at the specified index.</returns>
	public virtual XmlSchemaObject this[int index]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see langword="XmlSchemaObjectCollection" /> class.</summary>
	public XmlSchemaObjectCollection()
	{
	}

	/// <summary>Returns an enumerator for iterating through the <see langword="XmlSchemaObjects" /> contained in the <see langword="XmlSchemaObjectCollection" />.</summary>
	/// <returns>The iterator returns <see cref="T:System.Xml.Schema.XmlSchemaObjectEnumerator" />.</returns>
	public new XmlSchemaObjectEnumerator GetEnumerator()
	{
		return null;
	}

	/// <summary>Adds an <see cref="T:System.Xml.Schema.XmlSchemaObject" /> to the <see langword="XmlSchemaObjectCollection" />.</summary>
	/// <param name="item">The <see cref="T:System.Xml.Schema.XmlSchemaObject" />. </param>
	/// <returns>The index at which the item has been added.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///         <paramref name="index" /> is less than zero.-or- 
	///         <paramref name="index" /> is greater than <see langword="Count" />. </exception>
	/// <exception cref="T:System.InvalidCastException">The <see cref="T:System.Xml.Schema.XmlSchemaObject" /> parameter specified is not of type <see cref="T:System.Xml.Schema.XmlSchemaExternal" /> or its derived types <see cref="T:System.Xml.Schema.XmlSchemaImport" />, <see cref="T:System.Xml.Schema.XmlSchemaInclude" />, and <see cref="T:System.Xml.Schema.XmlSchemaRedefine" />.</exception>
	public int Add(XmlSchemaObject item)
	{
		return 0;
	}

	/// <summary>Inserts an <see cref="T:System.Xml.Schema.XmlSchemaObject" /> to the <see langword="XmlSchemaObjectCollection" />.</summary>
	/// <param name="index">The zero-based index at which an item should be inserted. </param>
	/// <param name="item">The <see cref="T:System.Xml.Schema.XmlSchemaObject" /> to insert. </param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///         <paramref name="index" /> is less than zero.-or- 
	///         <paramref name="index" /> is greater than <see langword="Count" />. </exception>
	public void Insert(int index, XmlSchemaObject item)
	{
	}

	/// <summary>Removes an <see cref="T:System.Xml.Schema.XmlSchemaObject" /> from the <see langword="XmlSchemaObjectCollection" />.</summary>
	/// <param name="item">The <see cref="T:System.Xml.Schema.XmlSchemaObject" /> to remove. </param>
	public void Remove(XmlSchemaObject item)
	{
	}

	/// <summary>
	///     <see langword="OnInsert" /> is invoked before the standard <see langword="Insert" /> behavior. For more information, see <see langword="OnInsert" /> method <see cref="T:System.Collections.CollectionBase" />.</summary>
	/// <param name="index">The index of <see cref="T:System.Xml.Schema.XmlSchemaObject" />. </param>
	/// <param name="item">The item. </param>
	protected override void OnInsert(int index, object item)
	{
	}

	/// <summary>
	///     <see langword="OnSet" /> is invoked before the standard <see langword="Set" /> behavior. For more information, see the OnSet method for <see cref="T:System.Collections.CollectionBase" />.</summary>
	/// <param name="index">The index of <see cref="T:System.Xml.Schema.XmlSchemaObject" />. </param>
	/// <param name="oldValue">The old value. </param>
	/// <param name="newValue">The new value. </param>
	protected override void OnSet(int index, object oldValue, object newValue)
	{
	}

	/// <summary>
	///     <see langword="OnClear" /> is invoked before the standard <see langword="Clear" /> behavior. For more information, see OnClear method for <see cref="T:System.Collections.CollectionBase" />.</summary>
	protected override void OnClear()
	{
	}

	/// <summary>
	///     <see langword="OnRemove" /> is invoked before the standard <see langword="Remove" /> behavior. For more information, see the <see langword="OnRemove" /> method for <see cref="T:System.Collections.CollectionBase" />.</summary>
	/// <param name="index">The index of <see cref="T:System.Xml.Schema.XmlSchemaObject" />. </param>
	/// <param name="item">The item. </param>
	protected override void OnRemove(int index, object item)
	{
	}

	internal XmlSchemaObjectCollection Clone()
	{
		return null;
	}

	private void Add(XmlSchemaObjectCollection collToAdd)
	{
	}
}
