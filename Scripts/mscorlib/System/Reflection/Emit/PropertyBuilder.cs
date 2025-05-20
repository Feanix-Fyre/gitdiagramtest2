using System.Globalization;

namespace System.Reflection.Emit;

/// <summary>Defines the properties for a type.</summary>
public sealed class PropertyBuilder : PropertyInfo
{
	/// <summary>Gets a value indicating whether the property can be read.</summary>
	/// <returns>
	///   <see langword="true" /> if this property can be read; otherwise, <see langword="false" />.</returns>
	public override bool CanRead => false;

	/// <summary>Gets a value indicating whether the property can be written to.</summary>
	/// <returns>
	///   <see langword="true" /> if this property can be written to; otherwise, <see langword="false" />.</returns>
	public override bool CanWrite => false;

	/// <summary>Gets the class that declares this member.</summary>
	/// <returns>The <see langword="Type" /> object for the class that declares this member.</returns>
	public override Type DeclaringType => null;

	/// <summary>Gets the name of this member.</summary>
	/// <returns>A <see cref="T:System.String" /> containing the name of this member.</returns>
	public override string Name => null;

	/// <summary>Gets the type of the field of this property.</summary>
	/// <returns>The type of this property.</returns>
	public override Type PropertyType => null;

	/// <summary>Gets the class object that was used to obtain this instance of <see langword="MemberInfo" />.</summary>
	/// <returns>The <see langword="Type" /> object through which this <see langword="MemberInfo" /> object was obtained.</returns>
	public override Type ReflectedType => null;

	/// <summary>Returns an array of all the custom attributes for this property.</summary>
	/// <param name="inherit">If <see langword="true" />, walks up this property's inheritance chain to find the custom attributes</param>
	/// <returns>An array of all the custom attributes.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not supported.</exception>
	public override object[] GetCustomAttributes(bool inherit)
	{
		return null;
	}

	/// <summary>Returns an array of custom attributes identified by <see cref="T:System.Type" />.</summary>
	/// <param name="attributeType">An array of custom attributes identified by type.</param>
	/// <param name="inherit">If <see langword="true" />, walks up this property's inheritance chain to find the custom attributes.</param>
	/// <returns>An array of custom attributes defined on this reflected member, or <see langword="null" /> if no attributes are defined on this member.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not supported.</exception>
	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		return null;
	}

	/// <summary>Returns the public and non-public get accessor for this property.</summary>
	/// <param name="nonPublic">Indicates whether non-public get accessors should be returned. <see langword="true" /> if non-public methods are to be included; otherwise, <see langword="false" />.</param>
	/// <returns>A <see langword="MethodInfo" /> object representing the get accessor for this property, if <paramref name="nonPublic" /> is <see langword="true" />. Returns <see langword="null" /> if <paramref name="nonPublic" /> is <see langword="false" /> and the get accessor is non-public, or if <paramref name="nonPublic" /> is <see langword="true" /> but no get accessors exist.</returns>
	public override MethodInfo GetGetMethod(bool nonPublic)
	{
		return null;
	}

	/// <summary>Returns an array of all the index parameters for the property.</summary>
	/// <returns>An array of type <see langword="ParameterInfo" /> containing the parameters for the indexes.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not supported.</exception>
	public override ParameterInfo[] GetIndexParameters()
	{
		return null;
	}

	/// <summary>Returns the set accessor for this property.</summary>
	/// <param name="nonPublic">Indicates whether the accessor should be returned if it is non-public. <see langword="true" /> if non-public methods are to be included; otherwise, <see langword="false" />.</param>
	/// <returns>The property's <see langword="Set" /> method, or <see langword="null" />, as shown in the following table.  
	///   Value  
	///
	///   Condition  
	///
	///   A <see cref="T:System.Reflection.MethodInfo" /> object representing the Set method for this property.  
	///
	///   The set accessor is public.  
	///
	///  <paramref name="nonPublic" /> is true and non-public methods can be returned.  
	///
	///   null  
	///
	///  <paramref name="nonPublic" /> is true, but the property is read-only.  
	///
	///  <paramref name="nonPublic" /> is false and the set accessor is non-public.</returns>
	public override MethodInfo GetSetMethod(bool nonPublic)
	{
		return null;
	}

	/// <summary>Gets the value of a property having the specified binding, index, and <see langword="CultureInfo" />.</summary>
	/// <param name="obj">The object whose property value will be returned.</param>
	/// <param name="invokeAttr">The invocation attribute. This must be a bit flag from <see langword="BindingFlags" /> : <see langword="InvokeMethod" />, <see langword="CreateInstance" />, <see langword="Static" />, <see langword="GetField" />, <see langword="SetField" />, <see langword="GetProperty" />, or <see langword="SetProperty" />. A suitable invocation attribute must be specified. If a static member is to be invoked, the <see langword="Static" /> flag of <see langword="BindingFlags" /> must be set.</param>
	/// <param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see langword="MemberInfo" /> objects using reflection. If <paramref name="binder" /> is <see langword="null" />, the default binder is used.</param>
	/// <param name="index">Optional index values for indexed properties. This value should be <see langword="null" /> for non-indexed properties.</param>
	/// <param name="culture">The <see langword="CultureInfo" /> object that represents the culture for which the resource is to be localized. Note that if the resource is not localized for this culture, the <see langword="CultureInfo.Parent" /> method will be called successively in search of a match. If this value is <see langword="null" />, the <see langword="CultureInfo" /> is obtained from the <see langword="CultureInfo.CurrentUICulture" /> property.</param>
	/// <returns>The property value for <paramref name="obj" />.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not supported.</exception>
	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
	{
		return null;
	}

	/// <summary>Indicates whether one or more instance of <paramref name="attributeType" /> is defined on this property.</summary>
	/// <param name="attributeType">The <see langword="Type" /> object to which the custom attributes are applied.</param>
	/// <param name="inherit">Specifies whether to walk up this property's inheritance chain to find the custom attributes.</param>
	/// <returns>
	///   <see langword="true" /> if one or more instance of <paramref name="attributeType" /> is defined on this property; otherwise <see langword="false" />.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not supported.</exception>
	public override bool IsDefined(Type attributeType, bool inherit)
	{
		return false;
	}

	/// <summary>Sets the property value for the given object to the given value.</summary>
	/// <param name="obj">The object whose property value will be returned.</param>
	/// <param name="value">The new value for this property.</param>
	/// <param name="invokeAttr">The invocation attribute. This must be a bit flag from <see langword="BindingFlags" /> : <see langword="InvokeMethod" />, <see langword="CreateInstance" />, <see langword="Static" />, <see langword="GetField" />, <see langword="SetField" />, <see langword="GetProperty" />, or <see langword="SetProperty" />. A suitable invocation attribute must be specified. If a static member is to be invoked, the <see langword="Static" /> flag of <see langword="BindingFlags" /> must be set.</param>
	/// <param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see langword="MemberInfo" /> objects using reflection. If <paramref name="binder" /> is <see langword="null" />, the default binder is used.</param>
	/// <param name="index">Optional index values for indexed properties. This value should be <see langword="null" /> for non-indexed properties.</param>
	/// <param name="culture">The <see langword="CultureInfo" /> object that represents the culture for which the resource is to be localized. Note that if the resource is not localized for this culture, the <see langword="CultureInfo.Parent" /> method will be called successively in search of a match. If this value is <see langword="null" />, the <see langword="CultureInfo" /> is obtained from the <see langword="CultureInfo.CurrentUICulture" /> property.</param>
	/// <exception cref="T:System.NotSupportedException">This method is not supported.</exception>
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture)
	{
	}
}
