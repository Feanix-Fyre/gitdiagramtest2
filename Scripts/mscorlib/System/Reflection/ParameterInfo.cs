using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Reflection;

/// <summary>Discovers the attributes of a parameter and provides access to parameter metadata.</summary>
[Serializable]
[StructLayout((LayoutKind)0)]
public class ParameterInfo : ICustomAttributeProvider, IObjectReference, _ParameterInfo
{
	/// <summary>The attributes of the parameter.</summary>
	protected ParameterAttributes AttrsImpl;

	/// <summary>The <see langword="Type" /> of the parameter.</summary>
	protected Type ClassImpl;

	/// <summary>The default value of the parameter.</summary>
	protected object DefaultValueImpl;

	/// <summary>The member in which the field is implemented.</summary>
	protected MemberInfo MemberImpl;

	/// <summary>The name of the parameter.</summary>
	protected string NameImpl;

	/// <summary>The zero-based position of the parameter in the parameter list.</summary>
	protected int PositionImpl;

	private const int MetadataToken_ParamDef = 134217728;

	/// <summary>Gets the attributes for this parameter.</summary>
	/// <returns>A <see langword="ParameterAttributes" /> object representing the attributes for this parameter.</returns>
	public virtual ParameterAttributes Attributes => default(ParameterAttributes);

	/// <summary>Gets a value indicating the member in which the parameter is implemented.</summary>
	/// <returns>The member which implanted the parameter represented by this <see cref="T:System.Reflection.ParameterInfo" />.</returns>
	public virtual MemberInfo Member => null;

	/// <summary>Gets the name of the parameter.</summary>
	/// <returns>The simple name of this parameter.</returns>
	public virtual string Name => null;

	/// <summary>Gets the <see langword="Type" /> of this parameter.</summary>
	/// <returns>The <see langword="Type" /> object that represents the <see langword="Type" /> of this parameter.</returns>
	public virtual Type ParameterType => null;

	/// <summary>Gets the zero-based position of the parameter in the formal parameter list.</summary>
	/// <returns>An integer representing the position this parameter occupies in the parameter list.</returns>
	public virtual int Position => 0;

	/// <summary>Gets a value indicating whether this is an input parameter.</summary>
	/// <returns>
	///   <see langword="true" /> if the parameter is an input parameter; otherwise, <see langword="false" />.</returns>
	public bool IsIn => false;

	/// <summary>Gets a value indicating whether this parameter is optional.</summary>
	/// <returns>
	///   <see langword="true" /> if the parameter is optional; otherwise, <see langword="false" />.</returns>
	public bool IsOptional => false;

	/// <summary>Gets a value indicating whether this is an output parameter.</summary>
	/// <returns>
	///   <see langword="true" /> if the parameter is an output parameter; otherwise, <see langword="false" />.</returns>
	public bool IsOut => false;

	/// <summary>Gets a value indicating the default value if the parameter has a default value.</summary>
	/// <returns>The default value of the parameter, or <see cref="F:System.DBNull.Value" /> if the parameter has no default value.</returns>
	public virtual object DefaultValue => null;

	/// <summary>Initializes a new instance of the <see langword="ParameterInfo" /> class.</summary>
	protected ParameterInfo()
	{
	}

	/// <summary>Determines whether the custom attribute of the specified type or its derived types is applied to this parameter.</summary>
	/// <param name="attributeType">The <see langword="Type" /> object to search for.</param>
	/// <param name="inherit">This argument is ignored for objects of this type.</param>
	/// <returns>
	///   <see langword="true" /> if one or more instances of <paramref name="attributeType" /> or its derived types are applied to this parameter; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="attributeType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="attributeType" /> is not a <see cref="T:System.Type" /> object supplied by the common language runtime.</exception>
	public virtual bool IsDefined(Type attributeType, bool inherit)
	{
		return false;
	}

	/// <summary>Gets all the custom attributes defined on this parameter.</summary>
	/// <param name="inherit">This argument is ignored for objects of this type.</param>
	/// <returns>An array that contains all the custom attributes applied to this parameter.</returns>
	/// <exception cref="T:System.TypeLoadException">A custom attribute type could not be loaded.</exception>
	public virtual object[] GetCustomAttributes(bool inherit)
	{
		return null;
	}

	/// <summary>Gets the custom attributes of the specified type or its derived types that are applied to this parameter.</summary>
	/// <param name="attributeType">The custom attributes identified by type.</param>
	/// <param name="inherit">This argument is ignored for objects of this type.</param>
	/// <returns>An array that contains the custom attributes of the specified type or its derived types.</returns>
	/// <exception cref="T:System.ArgumentException">The type must be a type provided by the underlying runtime system.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="attributeType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.TypeLoadException">A custom attribute type could not be loaded.</exception>
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		return null;
	}

	/// <summary>Returns the real object that should be deserialized instead of the object that the serialized stream specifies.</summary>
	/// <param name="context">The serialized stream from which the current object is deserialized.</param>
	/// <returns>The actual object that is put into the graph.</returns>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">The parameter's position in the parameter list of its associated member is not valid for that member's type.</exception>
	public object GetRealObject(StreamingContext context)
	{
		return null;
	}

	/// <summary>Gets the parameter type and name represented as a string.</summary>
	/// <returns>A string containing the type and the name of the parameter.</returns>
	public override string ToString()
	{
		return null;
	}
}
