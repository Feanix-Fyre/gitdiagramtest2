using System.Runtime.InteropServices;

namespace System.Runtime.Remoting.Metadata;

/// <summary>Customizes SOAP generation and processing for a method. This class cannot be inherited.</summary>
[ComVisible(true)]
[AttributeUsage(AttributeTargets.Method)]
public sealed class SoapMethodAttribute : SoapAttribute
{
	private string _responseElement;

	private string _responseNamespace;

	private string _returnElement;

	private string _soapAction;

	private bool _useAttribute;

	private string _namespace;

	/// <summary>Gets or sets a value indicating whether the target of the current attribute will be serialized as an XML attribute instead of an XML field.</summary>
	/// <returns>The current implementation always returns <see langword="false" />.</returns>
	/// <exception cref="T:System.Runtime.Remoting.RemotingException">An attempt was made to set the current property.</exception>
	public override bool UseAttribute => false;

	/// <summary>Gets or sets the XML namespace that is used during serialization of remote method calls of the target method.</summary>
	/// <returns>The XML namespace that is used during serialization of remote method calls of the target method.</returns>
	public override string XmlNamespace => null;

	/// <summary>Creates an instance of <see cref="T:System.Runtime.Remoting.Metadata.SoapMethodAttribute" />.</summary>
	public SoapMethodAttribute()
	{
	}

	internal override void SetReflectionObject(object reflectionObject)
	{
	}
}
