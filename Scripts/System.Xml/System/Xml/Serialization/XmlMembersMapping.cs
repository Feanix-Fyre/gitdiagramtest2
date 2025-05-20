using System.Reflection;

namespace System.Xml.Serialization;

/// <summary>Provides mappings between .NET Framework Web service methods and Web Services Description Language (WSDL) messages that are defined for SOAP Web services. </summary>
[DefaultMember("Item")]
public class XmlMembersMapping : XmlMapping
{
	private bool _hasWrapperElement;

	private XmlMemberMapping[] _mapping;

	/// <summary>Gets the number of .NET Framework code entities that belong to a Web service method to which a SOAP message is being mapped. </summary>
	/// <returns>The number of mappings in the collection.</returns>
	public int Count => 0;

	internal bool HasWrapperElement => false;
}
