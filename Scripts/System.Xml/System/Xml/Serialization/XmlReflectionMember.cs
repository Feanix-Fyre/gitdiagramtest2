namespace System.Xml.Serialization;

/// <summary>Provides mappings between code entities in .NET Framework Web service methods and the content of Web Services Description Language (WSDL) messages that are defined for SOAP Web services. </summary>
public class XmlReflectionMember
{
	private bool isReturnValue;

	private string memberName;

	private Type memberType;

	private XmlAttributes xmlAttributes;

	private Type declaringType;

	/// <summary>Gets or sets a value that indicates whether the <see cref="T:System.Xml.Serialization.XmlReflectionMember" /> represents a Web service method return value, as opposed to an output parameter. </summary>
	/// <returns>
	///     <see langword="true" />, if the member represents a Web service return value; otherwise, <see langword="false" />.</returns>
	public bool IsReturnValue => false;

	/// <summary>Gets or sets the name of the Web service method member for this mapping. </summary>
	/// <returns>The name of the Web service method.</returns>
	public string MemberName => null;

	/// <summary>Gets or sets the type of the Web service method member code entity that is represented by this mapping. </summary>
	/// <returns>The <see cref="T:System.Type" /> of the Web service method member code entity that is represented by this mapping.</returns>
	public Type MemberType => null;

	/// <summary>Gets or sets an <see cref="T:System.Xml.Serialization.XmlAttributes" /> with the collection of <see cref="T:System.Xml.Serialization.XmlSerializer" />-related attributes that have been applied to the member code entity. </summary>
	/// <returns>An <see cref="T:System.Xml.Serialization.XmlAttributes" /> that represents XML attributes that have been applied to the member code.</returns>
	public XmlAttributes XmlAttributes => null;

	internal Type DeclaringType
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal XmlReflectionMember(string name, Type type, XmlAttributes attributes)
	{
	}
}
