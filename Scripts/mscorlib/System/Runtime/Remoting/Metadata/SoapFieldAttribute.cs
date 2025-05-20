using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata;

/// <summary>Customizes SOAP generation and processing for a field. This class cannot be inherited.</summary>
[AttributeUsage(AttributeTargets.Field)]
[ComVisible(true)]
public sealed class SoapFieldAttribute : SoapAttribute
{
	private string _elementName;

	private bool _isElement;

	/// <summary>Gets or sets the XML element name of the field contained in the <see cref="T:System.Runtime.Remoting.Metadata.SoapFieldAttribute" /> attribute.</summary>
	/// <returns>The XML element name of the field contained in this attribute.</returns>
	public string XmlElementName => null;

	/// <summary>Creates an instance of <see cref="T:System.Runtime.Remoting.Metadata.SoapFieldAttribute" /> class.</summary>
	public SoapFieldAttribute()
	{
	}

	/// <summary>Returns a value indicating whether the current attribute contains interop XML element values.</summary>
	/// <returns>
	///   <see langword="true" /> if the current attribute contains interop XML element values; otherwise, <see langword="false" />.</returns>
	public bool IsInteropXmlElement()
	{
		return false;
	}

	internal override void SetReflectionObject(object reflectionObject)
	{
	}
}
