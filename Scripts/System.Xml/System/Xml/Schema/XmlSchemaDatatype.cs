namespace System.Xml.Schema;

/// <summary>The <see cref="T:System.Xml.Schema.XmlSchemaDatatype" /> class is an abstract class for mapping XML Schema definition language (XSD) types to Common Language Runtime (CLR) types.</summary>
public abstract class XmlSchemaDatatype
{
	/// <summary>When overridden in a derived class, gets the Common Language Runtime (CLR) type of the item.</summary>
	/// <returns>The Common Language Runtime (CLR) type of the item.</returns>
	public abstract Type ValueType { get; }

	/// <summary>When overridden in a derived class, gets the type for the <see langword="string" /> as specified in the World Wide Web Consortium (W3C) XML 1.0 specification.</summary>
	/// <returns>An <see cref="T:System.Xml.XmlTokenizedType" /> value for the <see langword="string" />.</returns>
	public abstract XmlTokenizedType TokenizedType { get; }

	/// <summary>Gets the <see cref="T:System.Xml.Schema.XmlSchemaDatatypeVariety" /> value for the simple type.</summary>
	/// <returns>The <see cref="T:System.Xml.Schema.XmlSchemaDatatypeVariety" /> value for the simple type.</returns>
	public virtual XmlSchemaDatatypeVariety Variety => default(XmlSchemaDatatypeVariety);

	/// <summary>Gets the <see cref="T:System.Xml.Schema.XmlTypeCode" /> value for the simple type.</summary>
	/// <returns>The <see cref="T:System.Xml.Schema.XmlTypeCode" /> value for the simple type.</returns>
	public virtual XmlTypeCode TypeCode => default(XmlTypeCode);

	internal abstract bool HasLexicalFacets { get; }

	internal abstract bool HasValueFacets { get; }

	internal abstract XmlValueConverter ValueConverter { get; }

	internal abstract RestrictionFacets Restriction { get; }

	internal abstract FacetsChecker FacetsChecker { get; }

	internal abstract XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	internal string TypeCodeString => null;

	/// <summary>When overridden in a derived class, validates the <see langword="string" /> specified against a built-in or user-defined simple type.</summary>
	/// <param name="s">The <see langword="string" /> to validate against the simple type.</param>
	/// <param name="nameTable">The <see cref="T:System.Xml.XmlNameTable" /> to use for atomization while parsing the <see langword="string" /> if this <see cref="T:System.Xml.Schema.XmlSchemaDatatype" /> object represents the xs:NCName type. </param>
	/// <param name="nsmgr">The <see cref="T:System.Xml.IXmlNamespaceResolver" /> object to use while parsing the <see langword="string" /> if this <see cref="T:System.Xml.Schema.XmlSchemaDatatype" /> object represents the xs:QName type.</param>
	/// <returns>An <see cref="T:System.Object" /> that can be cast safely to the type returned by the <see cref="P:System.Xml.Schema.XmlSchemaDatatype.ValueType" /> property.</returns>
	/// <exception cref="T:System.Xml.Schema.XmlSchemaValidationException">The input value is not a valid instance of this W3C XML Schema type.</exception>
	/// <exception cref="T:System.ArgumentNullException">The value to parse cannot be <see langword="null" />.</exception>
	public abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr);

	/// <summary>The <see cref="M:System.Xml.Schema.XmlSchemaDatatype.IsDerivedFrom(System.Xml.Schema.XmlSchemaDatatype)" /> method always returns <see langword="false" />.</summary>
	/// <param name="datatype">The <see cref="T:System.Xml.Schema.XmlSchemaDatatype" />.</param>
	/// <returns>Always returns <see langword="false" />.</returns>
	public virtual bool IsDerivedFrom(XmlSchemaDatatype datatype)
	{
		return false;
	}

	internal abstract int Compare(object value1, object value2);

	internal abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue);

	internal abstract Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue);

	internal abstract Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue);

	internal abstract XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType);

	internal abstract XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType);

	internal abstract void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller);

	internal abstract bool IsEqual(object o1, object o2);

	internal abstract bool IsComparable(XmlSchemaDatatype dtype);

	internal string TypeCodeToString(XmlTypeCode typeCode)
	{
		return null;
	}

	internal static string ConcatenatedToString(object value)
	{
		return null;
	}

	internal static XmlSchemaDatatype FromXmlTokenizedType(XmlTokenizedType token)
	{
		return null;
	}

	internal static XmlSchemaDatatype FromXmlTokenizedTypeXsd(XmlTokenizedType token)
	{
		return null;
	}

	internal static XmlSchemaDatatype FromXdrName(string name)
	{
		return null;
	}

	internal static XmlSchemaDatatype DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType)
	{
		return null;
	}

	internal static string XdrCanonizeUri(string uri, XmlNameTable nameTable, SchemaNames schemaNames)
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaDatatype" /> class.</summary>
	protected XmlSchemaDatatype()
	{
	}
}
