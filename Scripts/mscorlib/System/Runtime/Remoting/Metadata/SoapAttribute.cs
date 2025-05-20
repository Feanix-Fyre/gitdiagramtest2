using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata;

/// <summary>Provides default functionality for all SOAP attributes.</summary>
[ComVisible(true)]
public class SoapAttribute : Attribute
{
	private bool _useAttribute;

	/// <summary>The XML namespace to which the target of the current SOAP attribute is serialized.</summary>
	protected string ProtXmlNamespace;

	/// <summary>A reflection object used by attribute classes derived from the <see cref="T:System.Runtime.Remoting.Metadata.SoapAttribute" /> class to set XML serialization information.</summary>
	protected object ReflectInfo;

	/// <summary>Gets or sets a value indicating whether the target of the current attribute will be serialized as an XML attribute instead of an XML field.</summary>
	/// <returns>
	///   <see langword="true" /> if the target object of the current attribute must be serialized as an XML attribute; <see langword="false" /> if the target object must be serialized as a subelement.</returns>
	public virtual bool UseAttribute => false;

	/// <summary>Gets or sets the XML namespace name.</summary>
	/// <returns>The XML namespace name under which the target of the current attribute is serialized.</returns>
	public virtual string XmlNamespace => null;

	/// <summary>Creates an instance of <see cref="T:System.Runtime.Remoting.Metadata.SoapAttribute" />.</summary>
	public SoapAttribute()
	{
	}

	internal virtual void SetReflectionObject(object reflectionObject)
	{
	}
}
