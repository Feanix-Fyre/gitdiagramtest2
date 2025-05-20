namespace System.Runtime.Serialization;

/// <summary>When applied to the member of a type, specifies that the member is part of a data contract and is serializable by the <see cref="T:System.Runtime.Serialization.DataContractSerializer" />.</summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
public sealed class DataMemberAttribute : Attribute
{
	private string name;

	private bool isNameSetExplicitly;

	private int order;

	private bool isRequired;

	private bool emitDefaultValue;

	/// <summary>Gets or sets a data member name.</summary>
	/// <returns>The name of the data member. The default is the name of the target that the attribute is applied to.</returns>
	public string Name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets the order of serialization and deserialization of a member.</summary>
	/// <returns>The numeric order of serialization or deserialization.</returns>
	public int Order => 0;

	/// <summary>Gets or sets a value that instructs the serialization engine that the member must be present when reading or deserializing.</summary>
	/// <returns>
	///   <see langword="true" />, if the member is required; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">the member is not present.</exception>
	public bool IsRequired => false;

	/// <summary>Gets or sets a value that specifies whether to serialize the default value for a field or property being serialized.</summary>
	/// <returns>
	///   <see langword="true" /> if the default value for a member should be generated in the serialization stream; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
	public bool EmitDefaultValue
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Serialization.DataMemberAttribute" /> class.</summary>
	public DataMemberAttribute()
	{
	}
}
