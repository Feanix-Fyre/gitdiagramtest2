using System.Collections;

namespace System.Xml.Schema;

/// <summary>Represents the enumerator for the <see cref="T:System.Xml.Schema.XmlSchemaObjectCollection" />.</summary>
public class XmlSchemaObjectEnumerator : IEnumerator
{
	private IEnumerator enumerator;

	/// <summary>Gets the current <see cref="T:System.Xml.Schema.XmlSchemaObject" /> in the collection.</summary>
	/// <returns>The current <see cref="T:System.Xml.Schema.XmlSchemaObject" />.</returns>
	public XmlSchemaObject Current => null;

	/// <summary>For a description of this member, see <see cref="P:System.Xml.Schema.XmlSchemaObjectEnumerator.Current" />.</summary>
	/// <returns>The current <see cref="T:System.Xml.Schema.XmlSchemaObject" />.</returns>
	object IEnumerator.Current => null;

	internal XmlSchemaObjectEnumerator(IEnumerator enumerator)
	{
	}

	/// <summary>Moves to the next item in the collection.</summary>
	/// <returns>
	///     <see langword="false" /> at the end of the collection.</returns>
	public bool MoveNext()
	{
		return false;
	}

	/// <summary>For a description of this member, see <see cref="M:System.Xml.Schema.XmlSchemaObjectEnumerator.Reset" />.</summary>
	void IEnumerator.Reset()
	{
	}

	/// <summary>For a description of this member, see <see cref="M:System.Xml.Schema.XmlSchemaObjectEnumerator.MoveNext" />.</summary>
	/// <returns>The next <see cref="T:System.Xml.Schema.XmlSchemaObject" />.</returns>
	bool IEnumerator.MoveNext()
	{
		return false;
	}
}
