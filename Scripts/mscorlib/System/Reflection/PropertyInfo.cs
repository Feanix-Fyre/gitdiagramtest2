using System.Diagnostics;
using System.Globalization;

namespace System.Reflection;

/// <summary>Discovers the attributes of a property and provides access to property metadata.</summary>
[Serializable]
public abstract class PropertyInfo : MemberInfo
{
	/// <summary>Gets a <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is a property.</summary>
	/// <returns>A <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is a property.</returns>
	public override MemberTypes MemberType => default(MemberTypes);

	/// <summary>Gets the type of this property.</summary>
	/// <returns>The type of this property.</returns>
	public abstract Type PropertyType { get; }

	/// <summary>Gets a value indicating whether the property can be read.</summary>
	/// <returns>
	///   <see langword="true" /> if this property can be read; otherwise, <see langword="false" />.</returns>
	public abstract bool CanRead { get; }

	/// <summary>Gets a value indicating whether the property can be written to.</summary>
	/// <returns>
	///   <see langword="true" /> if this property can be written to; otherwise, <see langword="false" />.</returns>
	public abstract bool CanWrite { get; }

	/// <summary>Gets the <see langword="get" /> accessor for this property.</summary>
	/// <returns>The <see langword="get" /> accessor for this property.</returns>
	public virtual MethodInfo GetMethod => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.PropertyInfo" /> class.</summary>
	protected PropertyInfo()
	{
	}

	/// <summary>When overridden in a derived class, returns an array of all the index parameters for the property.</summary>
	/// <returns>An array of type <see langword="ParameterInfo" /> containing the parameters for the indexes. If the property is not indexed, the array has 0 (zero) elements.</returns>
	public abstract ParameterInfo[] GetIndexParameters();

	/// <summary>Returns the public <see langword="get" /> accessor for this property.</summary>
	/// <returns>A <see langword="MethodInfo" /> object representing the public <see langword="get" /> accessor for this property, or <see langword="null" /> if the <see langword="get" /> accessor is non-public or does not exist.</returns>
	public MethodInfo GetGetMethod()
	{
		return null;
	}

	/// <summary>When overridden in a derived class, returns the public or non-public <see langword="get" /> accessor for this property.</summary>
	/// <param name="nonPublic">Indicates whether a non-public <see langword="get" /> accessor should be returned. <see langword="true" /> if a non-public accessor is to be returned; otherwise, <see langword="false" />.</param>
	/// <returns>A <see langword="MethodInfo" /> object representing the <see langword="get" /> accessor for this property, if <paramref name="nonPublic" /> is <see langword="true" />. Returns <see langword="null" /> if <paramref name="nonPublic" /> is <see langword="false" /> and the <see langword="get" /> accessor is non-public, or if <paramref name="nonPublic" /> is <see langword="true" /> but no <see langword="get" /> accessors exist.</returns>
	/// <exception cref="T:System.Security.SecurityException">The requested method is non-public and the caller does not have <see cref="T:System.Security.Permissions.ReflectionPermission" /> to reflect on this non-public method.</exception>
	public abstract MethodInfo GetGetMethod(bool nonPublic);

	/// <summary>Returns the public <see langword="set" /> accessor for this property.</summary>
	/// <returns>The <see langword="MethodInfo" /> object representing the <see langword="Set" /> method for this property if the <see langword="set" /> accessor is public, or <see langword="null" /> if the <see langword="set" /> accessor is not public.</returns>
	public MethodInfo GetSetMethod()
	{
		return null;
	}

	/// <summary>When overridden in a derived class, returns the <see langword="set" /> accessor for this property.</summary>
	/// <param name="nonPublic">Indicates whether the accessor should be returned if it is non-public. <see langword="true" /> if a non-public accessor is to be returned; otherwise, <see langword="false" />.</param>
	/// <returns>This property's <see langword="Set" /> method, or <see langword="null" />, as shown in the following table.  
	///   Value  
	///
	///   Condition  
	///
	///   The <see langword="Set" /> method for this property.  
	///
	///   The <see langword="set" /> accessor is public.  
	///
	///  -or-  
	///
	///  <paramref name="nonPublic" /> is <see langword="true" /> and the <see langword="set" /> accessor is non-public.  
	///
	///  <see langword="null" /><paramref name="nonPublic" /> is <see langword="true" />, but the property is read-only.  
	///
	///  -or-  
	///
	///  <paramref name="nonPublic" /> is <see langword="false" /> and the <see langword="set" /> accessor is non-public.  
	///
	///  -or-  
	///
	///  There is no <see langword="set" /> accessor.</returns>
	/// <exception cref="T:System.Security.SecurityException">The requested method is non-public and the caller does not have <see cref="T:System.Security.Permissions.ReflectionPermission" /> to reflect on this non-public method.</exception>
	public abstract MethodInfo GetSetMethod(bool nonPublic);

	/// <summary>Returns the property value of a specified object.</summary>
	/// <param name="obj">The object whose property value will be returned.</param>
	/// <returns>The property value of the specified object.</returns>
	[DebuggerHidden]
	[DebuggerStepThrough]
	public object GetValue(object obj)
	{
		return null;
	}

	/// <summary>Returns the property value of a specified object with optional index values for indexed properties.</summary>
	/// <param name="obj">The object whose property value will be returned.</param>
	/// <param name="index">Optional index values for indexed properties. The indexes of indexed properties are zero-based. This value should be <see langword="null" /> for non-indexed properties.</param>
	/// <returns>The property value of the specified object.</returns>
	/// <exception cref="T:System.ArgumentException">The <paramref name="index" /> array does not contain the type of arguments needed.  
	///  -or-  
	///  The property's <see langword="get" /> accessor is not found.</exception>
	/// <exception cref="T:System.Reflection.TargetException">In the .NET for Windows Store apps or the Portable Class Library, catch <see cref="T:System.Exception" /> instead.  
	///
	///
	///
	///
	///  The object does not match the target type, or a property is an instance property but <paramref name="obj" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Reflection.TargetParameterCountException">The number of parameters in <paramref name="index" /> does not match the number of parameters the indexed property takes.</exception>
	/// <exception cref="T:System.MethodAccessException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.MemberAccessException" />, instead.  
	///
	///
	///
	///
	///  There was an illegal attempt to access a private or protected method inside a class.</exception>
	/// <exception cref="T:System.Reflection.TargetInvocationException">An error occurred while retrieving the property value. For example, an index value specified for an indexed property is out of range. The <see cref="P:System.Exception.InnerException" /> property indicates the reason for the error.</exception>
	[DebuggerStepThrough]
	[DebuggerHidden]
	public virtual object GetValue(object obj, object[] index)
	{
		return null;
	}

	/// <summary>When overridden in a derived class, returns the property value of a specified object that has the specified binding, index, and culture-specific information.</summary>
	/// <param name="obj">The object whose property value will be returned.</param>
	/// <param name="invokeAttr">A bitwise combination of the following enumeration members that specify the invocation attribute: <see langword="InvokeMethod" />, <see langword="CreateInstance" />, <see langword="Static" />, <see langword="GetField" />, <see langword="SetField" />, <see langword="GetProperty" />, and <see langword="SetProperty" />. You must specify a suitable invocation attribute. For example, to invoke a static member, set the <see langword="Static" /> flag.</param>
	/// <param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see cref="T:System.Reflection.MemberInfo" /> objects through reflection. If <paramref name="binder" /> is <see langword="null" />, the default binder is used.</param>
	/// <param name="index">Optional index values for indexed properties. This value should be <see langword="null" /> for non-indexed properties.</param>
	/// <param name="culture">The culture for which the resource is to be localized. If the resource is not localized for this culture, the <see cref="P:System.Globalization.CultureInfo.Parent" /> property will be called successively in search of a match. If this value is <see langword="null" />, the culture-specific information is obtained from the <see cref="P:System.Globalization.CultureInfo.CurrentUICulture" /> property.</param>
	/// <returns>The property value of the specified object.</returns>
	/// <exception cref="T:System.ArgumentException">The <paramref name="index" /> array does not contain the type of arguments needed.  
	///  -or-  
	///  The property's <see langword="get" /> accessor is not found.</exception>
	/// <exception cref="T:System.Reflection.TargetException">The object does not match the target type, or a property is an instance property but <paramref name="obj" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Reflection.TargetParameterCountException">The number of parameters in <paramref name="index" /> does not match the number of parameters the indexed property takes.</exception>
	/// <exception cref="T:System.MethodAccessException">There was an illegal attempt to access a private or protected method inside a class.</exception>
	/// <exception cref="T:System.Reflection.TargetInvocationException">An error occurred while retrieving the property value. For example, an index value specified for an indexed property is out of range. The <see cref="P:System.Exception.InnerException" /> property indicates the reason for the error.</exception>
	public abstract object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

	/// <summary>Sets the property value of a specified object.</summary>
	/// <param name="obj">The object whose property value will be set.</param>
	/// <param name="value">The new property value.</param>
	/// <exception cref="T:System.ArgumentException">The property's <see langword="set" /> accessor is not found.  
	///  -or-  
	///  <paramref name="value" /> cannot be converted to the type of <see cref="P:System.Reflection.PropertyInfo.PropertyType" />.</exception>
	/// <exception cref="T:System.Reflection.TargetException">In the .NET for Windows Store apps or the Portable Class Library, catch <see cref="T:System.Exception" /> instead.  
	///
	///
	///
	///
	///  The type of <paramref name="obj" /> does not match the target type, or a property is an instance property but <paramref name="obj" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.MethodAccessException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.MemberAccessException" />, instead.  
	///
	///
	///
	///
	///  There was an illegal attempt to access a private or protected method inside a class.</exception>
	/// <exception cref="T:System.Reflection.TargetInvocationException">An error occurred while setting the property value. The <see cref="P:System.Exception.InnerException" /> property indicates the reason for the error.</exception>
	[DebuggerHidden]
	[DebuggerStepThrough]
	public void SetValue(object obj, object value)
	{
	}

	/// <summary>Sets the property value of a specified object with optional index values for index properties.</summary>
	/// <param name="obj">The object whose property value will be set.</param>
	/// <param name="value">The new property value.</param>
	/// <param name="index">Optional index values for indexed properties. This value should be <see langword="null" /> for non-indexed properties.</param>
	/// <exception cref="T:System.ArgumentException">The <paramref name="index" /> array does not contain the type of arguments needed.  
	///  -or-  
	///  The property's <see langword="set" /> accessor is not found.  
	///  -or-  
	///  <paramref name="value" /> cannot be converted to the type of <see cref="P:System.Reflection.PropertyInfo.PropertyType" />.</exception>
	/// <exception cref="T:System.Reflection.TargetException">In the .NET for Windows Store apps or the Portable Class Library, catch <see cref="T:System.Exception" /> instead.  
	///
	///
	///
	///
	///  The object does not match the target type, or a property is an instance property but <paramref name="obj" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Reflection.TargetParameterCountException">The number of parameters in <paramref name="index" /> does not match the number of parameters the indexed property takes.</exception>
	/// <exception cref="T:System.MethodAccessException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.MemberAccessException" />, instead.  
	///
	///
	///
	///
	///  There was an illegal attempt to access a private or protected method inside a class.</exception>
	/// <exception cref="T:System.Reflection.TargetInvocationException">An error occurred while setting the property value. For example, an index value specified for an indexed property is out of range. The <see cref="P:System.Exception.InnerException" /> property indicates the reason for the error.</exception>
	[DebuggerStepThrough]
	[DebuggerHidden]
	public virtual void SetValue(object obj, object value, object[] index)
	{
	}

	/// <summary>When overridden in a derived class, sets the property value for a specified object that has the specified binding, index, and culture-specific information.</summary>
	/// <param name="obj">The object whose property value will be set.</param>
	/// <param name="value">The new property value.</param>
	/// <param name="invokeAttr">A bitwise combination of the following enumeration members that specify the invocation attribute: <see langword="InvokeMethod" />, <see langword="CreateInstance" />, <see langword="Static" />, <see langword="GetField" />, <see langword="SetField" />, <see langword="GetProperty" />, or <see langword="SetProperty" />. You must specify a suitable invocation attribute. For example, to invoke a static member, set the <see langword="Static" /> flag.</param>
	/// <param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see cref="T:System.Reflection.MemberInfo" /> objects through reflection. If <paramref name="binder" /> is <see langword="null" />, the default binder is used.</param>
	/// <param name="index">Optional index values for indexed properties. This value should be <see langword="null" /> for non-indexed properties.</param>
	/// <param name="culture">The culture for which the resource is to be localized. If the resource is not localized for this culture, the <see cref="P:System.Globalization.CultureInfo.Parent" /> property will be called successively in search of a match. If this value is <see langword="null" />, the culture-specific information is obtained from the <see cref="P:System.Globalization.CultureInfo.CurrentUICulture" /> property.</param>
	/// <exception cref="T:System.ArgumentException">The <paramref name="index" /> array does not contain the type of arguments needed.  
	///  -or-  
	///  The property's <see langword="set" /> accessor is not found.  
	///  -or-  
	///  <paramref name="value" /> cannot be converted to the type of <see cref="P:System.Reflection.PropertyInfo.PropertyType" />.</exception>
	/// <exception cref="T:System.Reflection.TargetException">The object does not match the target type, or a property is an instance property but <paramref name="obj" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Reflection.TargetParameterCountException">The number of parameters in <paramref name="index" /> does not match the number of parameters the indexed property takes.</exception>
	/// <exception cref="T:System.MethodAccessException">There was an illegal attempt to access a private or protected method inside a class.</exception>
	/// <exception cref="T:System.Reflection.TargetInvocationException">An error occurred while setting the property value. For example, an index value specified for an indexed property is out of range. The <see cref="P:System.Exception.InnerException" /> property indicates the reason for the error.</exception>
	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

	/// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
	/// <param name="obj">An object to compare with this instance, or <see langword="null" />.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="obj" /> equals the type and value of this instance; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Returns the hash code for this instance.</summary>
	/// <returns>A 32-bit signed integer hash code.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Indicates whether two <see cref="T:System.Reflection.PropertyInfo" /> objects are equal.</summary>
	/// <param name="left">The first object to compare.</param>
	/// <param name="right">The second object to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="left" /> is equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
	public static bool operator ==(PropertyInfo left, PropertyInfo right)
	{
		return false;
	}

	/// <summary>Indicates whether two <see cref="T:System.Reflection.PropertyInfo" /> objects are not equal.</summary>
	/// <param name="left">The first object to compare.</param>
	/// <param name="right">The second object to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="left" /> is not equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
	public static bool operator !=(PropertyInfo left, PropertyInfo right)
	{
		return false;
	}
}
