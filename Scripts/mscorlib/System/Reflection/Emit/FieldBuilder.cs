using System.Globalization;

namespace System.Reflection.Emit;

/// <summary>Defines and represents a field. This class cannot be inherited.</summary>
public sealed class FieldBuilder : FieldInfo
{
	/// <summary>Indicates the attributes of this field. This property is read-only.</summary>
	/// <returns>The attributes of this field.</returns>
	public override FieldAttributes Attributes => default(FieldAttributes);

	/// <summary>Indicates a reference to the <see cref="T:System.Type" /> object for the type that declares this field. This property is read-only.</summary>
	/// <returns>A reference to the <see cref="T:System.Type" /> object for the type that declares this field.</returns>
	public override Type DeclaringType => null;

	/// <summary>Indicates the internal metadata handle for this field. This property is read-only.</summary>
	/// <returns>The internal metadata handle for this field.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not supported.</exception>
	public override RuntimeFieldHandle FieldHandle => default(RuntimeFieldHandle);

	/// <summary>Indicates the <see cref="T:System.Type" /> object that represents the type of this field. This property is read-only.</summary>
	/// <returns>The <see cref="T:System.Type" /> object that represents the type of this field.</returns>
	public override Type FieldType => null;

	/// <summary>Indicates the name of this field. This property is read-only.</summary>
	/// <returns>A <see cref="T:System.String" /> containing the name of this field.</returns>
	public override string Name => null;

	/// <summary>Indicates the reference to the <see cref="T:System.Type" /> object from which this object was obtained. This property is read-only.</summary>
	/// <returns>A reference to the <see cref="T:System.Type" /> object from which this instance was obtained.</returns>
	public override Type ReflectedType => null;

	/// <summary>Returns all the custom attributes defined for this field.</summary>
	/// <param name="inherit">Controls inheritance of custom attributes from base classes.</param>
	/// <returns>An array of type <see cref="T:System.Object" /> representing all the custom attributes of the constructor represented by this <see cref="T:System.Reflection.Emit.FieldBuilder" /> instance.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not supported.</exception>
	public override object[] GetCustomAttributes(bool inherit)
	{
		return null;
	}

	/// <summary>Returns all the custom attributes defined for this field identified by the given type.</summary>
	/// <param name="attributeType">The custom attribute type.</param>
	/// <param name="inherit">Controls inheritance of custom attributes from base classes.</param>
	/// <returns>An array of type <see cref="T:System.Object" /> representing all the custom attributes of the constructor represented by this <see cref="T:System.Reflection.Emit.FieldBuilder" /> instance.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not supported.</exception>
	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		return null;
	}

	/// <summary>Retrieves the value of the field supported by the given object.</summary>
	/// <param name="obj">The object on which to access the field.</param>
	/// <returns>An <see cref="T:System.Object" /> containing the value of the field reflected by this instance.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not supported.</exception>
	public override object GetValue(object obj)
	{
		return null;
	}

	/// <summary>Indicates whether an attribute having the specified type is defined on a field.</summary>
	/// <param name="attributeType">The type of the attribute.</param>
	/// <param name="inherit">Controls inheritance of custom attributes from base classes.</param>
	/// <returns>
	///   <see langword="true" /> if one or more instance of <paramref name="attributeType" /> is defined on this field; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not currently supported. Retrieve the field using <see cref="M:System.Type.GetField(System.String,System.Reflection.BindingFlags)" /> and call <see cref="M:System.Reflection.MemberInfo.IsDefined(System.Type,System.Boolean)" /> on the returned <see cref="T:System.Reflection.FieldInfo" />.</exception>
	public override bool IsDefined(Type attributeType, bool inherit)
	{
		return false;
	}

	/// <summary>Sets the value of the field supported by the given object.</summary>
	/// <param name="obj">The object on which to access the field.</param>
	/// <param name="val">The value to assign to the field.</param>
	/// <param name="invokeAttr">A member of <see langword="IBinder" /> that specifies the type of binding that is desired (for example, IBinder.CreateInstance, IBinder.ExactBinding).</param>
	/// <param name="binder">A set of properties and enabling for binding, coercion of argument types, and invocation of members using reflection. If binder is null, then IBinder.DefaultBinding is used.</param>
	/// <param name="culture">The software preferences of a particular culture.</param>
	/// <exception cref="T:System.NotSupportedException">This method is not supported.</exception>
	public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
	{
	}
}
