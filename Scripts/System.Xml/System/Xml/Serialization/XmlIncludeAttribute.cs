namespace System.Xml.Serialization;

/// <summary>Allows the <see cref="T:System.Xml.Serialization.XmlSerializer" /> to recognize a type when it serializes or deserializes an object.</summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface, AllowMultiple = true)]
public class XmlIncludeAttribute : Attribute
{
	private Type type;

	/// <summary>Gets or sets the type of the object to include.</summary>
	/// <returns>The <see cref="T:System.Type" /> of the object to include.</returns>
	public Type Type => null;
}
