using System.Collections;
using System.Collections.Generic;

namespace System.Xml.Schema;

/// <summary>Provides the collections for contained elements in the <see cref="T:System.Xml.Schema.XmlSchema" /> class (for example, Attributes, AttributeGroups, Elements, and so on).</summary>
public class XmlSchemaObjectTable
{
	internal enum EnumeratorType
	{
		Keys = 0,
		Values = 1,
		DictionaryEntry = 2
	}

	internal struct XmlSchemaObjectEntry
	{
		internal XmlQualifiedName qname;

		internal XmlSchemaObject xso;

		public XmlSchemaObjectEntry(XmlQualifiedName name, XmlSchemaObject value)
		{
			qname = null;
			xso = null;
		}
	}

	internal class ValuesCollection : ICollection, IEnumerable
	{
		private List<XmlSchemaObjectEntry> entries;

		private int size;

		public int Count => 0;

		public object SyncRoot => null;

		public bool IsSynchronized => false;

		internal ValuesCollection(List<XmlSchemaObjectEntry> entries, int size)
		{
		}

		public void CopyTo(Array array, int arrayIndex)
		{
		}

		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}

	internal class XSOEnumerator : IEnumerator
	{
		private List<XmlSchemaObjectEntry> entries;

		private EnumeratorType enumType;

		protected int currentIndex;

		protected int size;

		protected XmlQualifiedName currentKey;

		protected XmlSchemaObject currentValue;

		public object Current => null;

		internal XSOEnumerator(List<XmlSchemaObjectEntry> entries, int size, EnumeratorType enumType)
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}
	}

	internal class XSODictionaryEnumerator : XSOEnumerator, IDictionaryEnumerator, IEnumerator
	{
		public DictionaryEntry Entry => default(DictionaryEntry);

		public object Key => null;

		public object Value => null;

		internal XSODictionaryEnumerator(List<XmlSchemaObjectEntry> entries, int size, EnumeratorType enumType)
			: base(null, 0, default(EnumeratorType))
		{
		}
	}

	private Dictionary<XmlQualifiedName, XmlSchemaObject> table;

	private List<XmlSchemaObjectEntry> entries;

	/// <summary>Gets the number of items contained in the <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" />.</summary>
	/// <returns>The number of items contained in the <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" />.</returns>
	public int Count => 0;

	/// <summary>Returns the element in the <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" /> specified by qualified name.</summary>
	/// <param name="name">The <see cref="T:System.Xml.XmlQualifiedName" /> of the element to return.</param>
	/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaObject" /> of the element in the <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" /> specified by qualified name.</returns>
	public XmlSchemaObject this[XmlQualifiedName name] => null;

	/// <summary>Returns a collection of all the values for all the elements in the <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" />.</summary>
	/// <returns>A collection of all the values for all the elements in the <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" />.</returns>
	public ICollection Values => null;

	internal XmlSchemaObjectTable()
	{
	}

	internal void Add(XmlQualifiedName name, XmlSchemaObject value)
	{
	}

	internal void Insert(XmlQualifiedName name, XmlSchemaObject value)
	{
	}

	internal void Replace(XmlQualifiedName name, XmlSchemaObject value)
	{
	}

	internal void Clear()
	{
	}

	internal void Remove(XmlQualifiedName name)
	{
	}

	private int FindIndexByValue(XmlSchemaObject xso)
	{
		return 0;
	}

	/// <summary>Determines if the qualified name specified exists in the collection.</summary>
	/// <param name="name">The <see cref="T:System.Xml.XmlQualifiedName" />.</param>
	/// <returns>
	///     <see langword="true" /> if the qualified name specified exists in the collection; otherwise, <see langword="false" />.</returns>
	public bool Contains(XmlQualifiedName name)
	{
		return false;
	}

	/// <summary>Returns an enumerator that can iterate through the <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" />.</summary>
	/// <returns>An <see cref="T:System.Collections.IDictionaryEnumerator" /> that can iterate through <see cref="T:System.Xml.Schema.XmlSchemaObjectTable" />.</returns>
	public IDictionaryEnumerator GetEnumerator()
	{
		return null;
	}
}
