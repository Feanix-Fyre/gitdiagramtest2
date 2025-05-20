using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata;

/// <summary>Customizes SOAP generation and processing for target types. This class cannot be inherited.</summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface)]
[ComVisible(true)]
public sealed class SoapTypeAttribute : SoapAttribute
{
	private bool _useAttribute;

	private string _xmlElementName;

	private string _xmlNamespace;

	private string _xmlTypeName;

	private string _xmlTypeNamespace;

	private bool _isType;

	private bool _isElement;

	/// <summary>Gets or sets a value indicating whether the target of the current attribute will be serialized as an XML attribute instead of an XML field.</summary>
	/// <returns>The current implementation always returns <see langword="false" />.</returns>
	/// <exception cref="T:System.Runtime.Remoting.RemotingException">An attempt was made to set the current property.</exception>
	public override bool UseAttribute => false;

	/// <summary>Gets or sets the XML element name.</summary>
	/// <returns>The XML element name.</returns>
	public string XmlElementName => null;

	/// <summary>Gets or sets the XML namespace that is used during serialization of the target object type.</summary>
	/// <returns>The XML namespace that is used during serialization of the target object type.</returns>
	public override string XmlNamespace => null;

	/// <summary>Gets or sets the XML type name for the target object type.</summary>
	/// <returns>The XML type name for the target object type.</returns>
	public string XmlTypeName => null;

	/// <summary>Gets or sets the XML type namespace for the current object type.</summary>
	/// <returns>The XML type namespace for the current object type.</returns>
	public string XmlTypeNamespace => null;

	internal bool IsInteropXmlElement => false;

	internal bool IsInteropXmlType => false;

	/// <summary>Creates an instance of <see cref="T:System.Runtime.Remoting.Metadata.SoapTypeAttribute" />.</summary>
	public SoapTypeAttribute()
	{
	}

	internal override void SetReflectionObject(object reflectionObject)
	{
	}
}
