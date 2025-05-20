using System.Collections;

namespace System.Xml.Schema;

/// <summary>Infers an XML Schema Definition Language (XSD) schema from an XML document. The <see cref="T:System.Xml.Schema.XmlSchemaInference" /> class cannot be inherited.</summary>
public sealed class XmlSchemaInference
{
	/// <summary>Affects occurrence and type information inferred by the <see cref="T:System.Xml.Schema.XmlSchemaInference" /> class for elements and attributes in an XML document. </summary>
	public enum InferenceOption
	{
		/// <summary>Indicates that a more restrictive schema declaration should be inferred for a particular element or attribute.</summary>
		Restricted = 0,
		/// <summary>Indicates that a less restrictive schema declaration should be inferred for a particular element or attribute.</summary>
		Relaxed = 1
	}

	internal static XmlQualifiedName ST_boolean;

	internal static XmlQualifiedName ST_byte;

	internal static XmlQualifiedName ST_unsignedByte;

	internal static XmlQualifiedName ST_short;

	internal static XmlQualifiedName ST_unsignedShort;

	internal static XmlQualifiedName ST_int;

	internal static XmlQualifiedName ST_unsignedInt;

	internal static XmlQualifiedName ST_long;

	internal static XmlQualifiedName ST_unsignedLong;

	internal static XmlQualifiedName ST_integer;

	internal static XmlQualifiedName ST_decimal;

	internal static XmlQualifiedName ST_float;

	internal static XmlQualifiedName ST_double;

	internal static XmlQualifiedName ST_duration;

	internal static XmlQualifiedName ST_dateTime;

	internal static XmlQualifiedName ST_time;

	internal static XmlQualifiedName ST_date;

	internal static XmlQualifiedName ST_gYearMonth;

	internal static XmlQualifiedName ST_string;

	internal static XmlQualifiedName ST_anySimpleType;

	internal static XmlQualifiedName[] SimpleTypes;

	private XmlSchema rootSchema;

	private XmlSchemaSet schemaSet;

	private XmlReader xtr;

	private NameTable nametable;

	private string TargetNamespace;

	private XmlNamespaceManager NamespaceManager;

	private ArrayList schemaList;

	private InferenceOption occurrence;

	private InferenceOption typeInference;

	/// <summary>Gets or sets the <see cref="T:System.Xml.Schema.XmlSchemaInference.InferenceOption" /> value that affects schema occurrence declarations inferred from the XML document.</summary>
	/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaInference.InferenceOption" /> object.</returns>
	public InferenceOption Occurrence
	{
		get
		{
			return default(InferenceOption);
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the <see cref="T:System.Xml.Schema.XmlSchemaInference.InferenceOption" /> value that affects types inferred from the XML document.</summary>
	/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaInference.InferenceOption" /> object.</returns>
	public InferenceOption TypeInference
	{
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Schema.XmlSchemaInference" /> class.</summary>
	public XmlSchemaInference()
	{
	}

	/// <summary>Infers an XML Schema Definition Language (XSD) schema from the XML document contained in the <see cref="T:System.Xml.XmlReader" /> object specified.</summary>
	/// <param name="instanceDocument">An <see cref="T:System.Xml.XmlReader" /> object containing the XML document to infer a schema from.</param>
	/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaSet" /> object containing the inferred schemas.</returns>
	/// <exception cref="T:System.Xml.XmlException">The XML document is not well-formed.</exception>
	/// <exception cref="T:System.Xml.Schema.XmlSchemaInferenceException">The <see cref="T:System.Xml.XmlReader" /> object is not positioned on the root node or on an element. An error occurs during the schema inference process.</exception>
	public XmlSchemaSet InferSchema(XmlReader instanceDocument)
	{
		return null;
	}

	internal XmlSchemaSet InferSchema1(XmlReader instanceDocument, XmlSchemaSet schemas)
	{
		return null;
	}

	private XmlSchemaAttribute AddAttribute(string localName, string prefix, string childURI, string attrValue, bool bCreatingNewType, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, XmlSchemaObjectTable compiledAttributes)
	{
		return null;
	}

	private XmlSchema CreateXmlSchema(string targetNS)
	{
		return null;
	}

	private XmlSchemaElement AddElement(string localName, string prefix, string childURI, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, int positionWithinCollection)
	{
		return null;
	}

	internal void InferElement(XmlSchemaElement xse, bool bCreatingNewType, XmlSchema parentSchema)
	{
	}

	private XmlSchemaSimpleContentExtension CheckSimpleContentExtension(XmlSchemaComplexType ct)
	{
		return null;
	}

	private XmlSchemaType GetEffectiveSchemaType(XmlSchemaElement elem, bool bCreatingNewType)
	{
		return null;
	}

	internal XmlSchemaElement FindMatchingElement(bool bCreatingNewType, XmlReader xtr, XmlSchemaComplexType ct, ref int lastUsedSeqItem, ref bool bParticleChanged, XmlSchema parentSchema, bool setMaxoccurs)
	{
		return null;
	}

	internal void ProcessAttributes(ref XmlSchemaElement xse, XmlSchemaType effectiveSchemaType, bool bCreatingNewType, XmlSchema parentSchema)
	{
	}

	private void MoveAttributes(XmlSchemaSimpleContentExtension scExtension, XmlSchemaComplexType ct)
	{
	}

	private void MoveAttributes(XmlSchemaComplexType ct, XmlSchemaSimpleContentExtension simpleContentExtension, bool bCreatingNewType)
	{
	}

	internal XmlSchemaAttribute FindAttribute(ICollection attributes, string attrName)
	{
		return null;
	}

	internal XmlSchemaElement FindGlobalElement(string namespaceURI, string localName, out XmlSchema parentSchema)
	{
		parentSchema = null;
		return null;
	}

	internal XmlSchemaElement FindElement(XmlSchemaObjectCollection elements, string elementName)
	{
		return null;
	}

	internal XmlSchemaAttribute FindAttributeRef(ICollection attributes, string attributeName, string nsURI)
	{
		return null;
	}

	internal XmlSchemaElement FindElementRef(XmlSchemaObjectCollection elements, string elementName, string nsURI)
	{
		return null;
	}

	internal void MakeExistingAttributesOptional(XmlSchemaComplexType ct, XmlSchemaObjectCollection attributesInInstance)
	{
	}

	private void SwitchUseToOptional(XmlSchemaObjectCollection attributes, XmlSchemaObjectCollection attributesInInstance)
	{
	}

	internal XmlQualifiedName RefineSimpleType(string s, ref int iTypeFlags)
	{
		return null;
	}

	internal static int InferSimpleType(string s, ref bool bNeedsRangeCheck)
	{
		return 0;
	}

	internal static int DateTime(string s, bool bDate, bool bTime)
	{
		return 0;
	}

	private XmlSchemaElement CreateNewElementforChoice(XmlSchemaElement copyElement)
	{
		return null;
	}

	private static int GetSchemaType(XmlQualifiedName qname)
	{
		return 0;
	}

	internal void SetMinMaxOccurs(XmlSchemaElement el, bool setMaxOccurs)
	{
	}
}
