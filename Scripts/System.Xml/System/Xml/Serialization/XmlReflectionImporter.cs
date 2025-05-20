using System.Collections;
using System.Collections.Generic;

namespace System.Xml.Serialization;

/// <summary>Generates mappings to XML schema element declarations, including literal XML Schema Definition (XSD) message parts in a Web Services Description Language (WSDL) document, for .NET Framework types or Web service method information. </summary>
public class XmlReflectionImporter
{
	private string initialDefaultNamespace;

	private XmlAttributeOverrides attributeOverrides;

	private ArrayList includedTypes;

	private ReflectionHelper helper;

	private int arrayChoiceCount;

	private ArrayList relatedMaps;

	private bool allowPrivateTypes;

	private static readonly string errSimple;

	private static readonly string errSimple2;

	/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlReflectionImporter" /> class using the specified XML serialization overrides and default XML namespace. </summary>
	/// <param name="attributeOverrides">An object that overrides how the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class serializes mapped types.</param>
	/// <param name="defaultNamespace">The default XML namespace to use for imported type mappings.</param>
	public XmlReflectionImporter(XmlAttributeOverrides attributeOverrides, string defaultNamespace)
	{
	}

	/// <summary>Generates a mapping to an XML Schema element for a specified .NET Framework type. </summary>
	/// <param name="type">The .NET Framework type for which to generate a type mapping.</param>
	/// <returns>Internal .NET Framework mapping of a type to an XML Schema element.</returns>
	public XmlTypeMapping ImportTypeMapping(Type type)
	{
		return null;
	}

	/// <summary>Generates a mapping to an XML Schema element for a .NET Framework type, using the specified type and namespace. </summary>
	/// <param name="type">The .NET Framework type for which to generate a type mapping.</param>
	/// <param name="defaultNamespace">The default XML namespace to use.</param>
	/// <returns>Internal .NET Framework mapping of a type to an XML Schema element.</returns>
	public XmlTypeMapping ImportTypeMapping(Type type, string defaultNamespace)
	{
		return null;
	}

	/// <summary>Generates a mapping to an XML Schema element for a .NET Framework type, using the specified type, attribute, and namespace. </summary>
	/// <param name="type">The .NET Framework type for which to generate a type mapping.</param>
	/// <param name="root">An <see cref="T:System.Xml.Serialization.XmlRootAttribute" /> attribute that is applied to the type.</param>
	/// <param name="defaultNamespace">The default XML namespace to use.</param>
	/// <returns>An <see cref="T:System.Xml.Serialization.XmlTypeMapping" /> that contains the internal .NET Framework mapping of a type to an XML Schema element.</returns>
	public XmlTypeMapping ImportTypeMapping(Type type, XmlRootAttribute root, string defaultNamespace)
	{
		return null;
	}

	private XmlTypeMapping ImportTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace)
	{
		return null;
	}

	private XmlTypeMapping CreateTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultXmlType, string defaultNamespace)
	{
		return null;
	}

	private XmlTypeMapping ImportClassMapping(Type type, XmlRootAttribute root, string defaultNamespace, bool isBaseType = false)
	{
		return null;
	}

	private XmlTypeMapping ImportClassMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, bool isBaseType = false)
	{
		return null;
	}

	private void RegisterDerivedMap(XmlTypeMapping map, XmlTypeMapping derivedMap)
	{
	}

	private string GetTypeNamespace(TypeData typeData, XmlRootAttribute root, string defaultNamespace)
	{
		return null;
	}

	private XmlTypeMapping ImportListMapping(Type type, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel)
	{
		return null;
	}

	private XmlTypeMapping ImportListMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel)
	{
		return null;
	}

	private XmlTypeMapping ImportXmlNodeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace)
	{
		return null;
	}

	private XmlTypeMapping ImportPrimitiveMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace)
	{
		return null;
	}

	private XmlTypeMapping ImportEnumMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace)
	{
		return null;
	}

	private XmlTypeMapping ImportXmlSerializableMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace)
	{
		return null;
	}

	private void ImportIncludedTypes(Type type, string defaultNamespace)
	{
	}

	private List<XmlReflectionMember> GetReflectionMembers(Type type)
	{
		return null;
	}

	private XmlTypeMapMember CreateMapMember(Type declaringType, XmlReflectionMember rmember, string defaultNamespace)
	{
		return null;
	}

	private XmlTypeMapElementInfoList ImportElementInfo(Type cls, string defaultName, string defaultNamespace, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts)
	{
		return null;
	}

	private XmlTypeMapElementInfoList ImportAnyElementInfo(string defaultNamespace, XmlReflectionMember rmember, XmlTypeMapMemberElement member, XmlAttributes atts)
	{
		return null;
	}

	private void ImportTextElementInfo(XmlTypeMapElementInfoList list, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts, string defaultNamespace)
	{
	}

	private bool CanBeNull(TypeData type)
	{
		return false;
	}

	/// <summary>Includes mappings for a type for later use when import methods are invoked. </summary>
	/// <param name="type">The .NET Framework type for which to save type mapping information.</param>
	public void IncludeType(Type type)
	{
	}

	private object GetDefaultValue(TypeData typeData, object defaultValue)
	{
		return null;
	}
}
