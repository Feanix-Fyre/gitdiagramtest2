namespace System.ComponentModel.Design.Serialization;

/// <summary>Indicates the base serializer to use for a root designer object. This class cannot be inherited.</summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = true, Inherited = true)]
[Obsolete("This attribute has been deprecated. Use DesignerSerializerAttribute instead.  For example, to specify a root designer for CodeDom, use DesignerSerializerAttribute(...,typeof(TypeCodeDomSerializer)).  https://go.microsoft.com/fwlink/?linkid=14202")]
public sealed class RootDesignerSerializerAttribute : Attribute
{
	private string _typeId;

	/// <summary>Gets the fully qualified type name of the base type of the serializer.</summary>
	/// <returns>The name of the base type of the serializer.</returns>
	public string SerializerBaseTypeName { get; }

	/// <summary>Gets a unique ID for this attribute type.</summary>
	/// <returns>An object containing a unique ID for this attribute type.</returns>
	public override object TypeId => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.Serialization.RootDesignerSerializerAttribute" /> class using the specified attributes.</summary>
	/// <param name="serializerTypeName">The fully qualified name of the data type of the serializer.</param>
	/// <param name="baseSerializerTypeName">The name of the base type of the serializer. A class can include multiple serializers as they all have different base types.</param>
	/// <param name="reloadable">
	///   <see langword="true" /> if this serializer supports dynamic reloading of the document; otherwise, <see langword="false" />.</param>
	public RootDesignerSerializerAttribute(string serializerTypeName, string baseSerializerTypeName, bool reloadable)
	{
	}
}
