using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit;

/// <summary>Describes and represents an enumeration type.</summary>
public sealed class EnumBuilder : TypeInfo
{
	/// <summary>Retrieves the dynamic assembly that contains this enum definition.</summary>
	/// <returns>Read-only. The dynamic assembly that contains this enum definition.</returns>
	public override Assembly Assembly => null;

	/// <summary>Returns the full path of this enum qualified by the display name of the parent assembly.</summary>
	/// <returns>Read-only. The full path of this enum qualified by the display name of the parent assembly.</returns>
	public override string AssemblyQualifiedName => null;

	/// <summary>Returns the parent <see cref="T:System.Type" /> of this type which is always <see cref="T:System.Enum" />.</summary>
	/// <returns>Read-only. The parent <see cref="T:System.Type" /> of this type.</returns>
	public override Type BaseType => null;

	/// <summary>Returns the full path of this enum.</summary>
	/// <returns>Read-only. The full path of this enum.</returns>
	public override string FullName => null;

	/// <summary>Retrieves the dynamic module that contains this <see cref="T:System.Reflection.Emit.EnumBuilder" /> definition.</summary>
	/// <returns>Read-only. The dynamic module that contains this <see cref="T:System.Reflection.Emit.EnumBuilder" /> definition.</returns>
	public override Module Module => null;

	/// <summary>Returns the name of this enum.</summary>
	/// <returns>Read-only. The name of this enum.</returns>
	public override string Name => null;

	/// <summary>Returns the namespace of this enum.</summary>
	/// <returns>Read-only. The namespace of this enum.</returns>
	public override string Namespace => null;

	/// <summary>Returns the underlying system type for this enum.</summary>
	/// <returns>Read-only. Returns the underlying system type.</returns>
	public override Type UnderlyingSystemType => null;

	protected override TypeAttributes GetAttributeFlagsImpl()
	{
		return default(TypeAttributes);
	}

	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	/// <summary>Returns an array of <see cref="T:System.Reflection.ConstructorInfo" /> objects representing the public and non-public constructors defined for this class, as specified.</summary>
	/// <param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> : <see langword="InvokeMethod" />, <see langword="NonPublic" />, and so on.</param>
	/// <returns>Returns an array of <see cref="T:System.Reflection.ConstructorInfo" /> objects representing the specified constructors defined for this class. If no constructors are defined, an empty array is returned.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete.</exception>
	[ComVisible(true)]
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
	{
		return null;
	}

	/// <summary>Returns all the custom attributes defined for this constructor.</summary>
	/// <param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes.</param>
	/// <returns>Returns an array of objects representing all the custom attributes of the constructor represented by this <see cref="T:System.Reflection.Emit.ConstructorBuilder" /> instance.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete.</exception>
	public override object[] GetCustomAttributes(bool inherit)
	{
		return null;
	}

	/// <summary>Returns the custom attributes identified by the given type.</summary>
	/// <param name="attributeType">The <see langword="Type" /> object to which the custom attributes are applied.</param>
	/// <param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes.</param>
	/// <returns>Returns an array of objects representing the attributes of this constructor that are of <see cref="T:System.Type" /><paramref name="attributeType" />.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete.</exception>
	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		return null;
	}

	/// <summary>Calling this method always throws <see cref="T:System.NotSupportedException" />.</summary>
	/// <returns>This method is not supported. No value is returned.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not currently supported.</exception>
	public override Type GetElementType()
	{
		return null;
	}

	/// <summary>Returns the event with the specified name.</summary>
	/// <param name="name">The name of the event to get.</param>
	/// <param name="bindingAttr">This invocation attribute. This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> : <see langword="InvokeMethod" />, <see langword="NonPublic" />, and so on.</param>
	/// <returns>Returns an <see cref="T:System.Reflection.EventInfo" /> object representing the event declared or inherited by this type with the specified name. If there are no matches, <see langword="null" /> is returned.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete.</exception>
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
	{
		return null;
	}

	/// <summary>Returns the public and non-public events that are declared by this type.</summary>
	/// <param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" />, such as <see langword="InvokeMethod" />, <see langword="NonPublic" />, and so on.</param>
	/// <returns>Returns an array of <see cref="T:System.Reflection.EventInfo" /> objects representing the public and non-public events declared or inherited by this type. An empty array is returned if there are no events, as specified.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete.</exception>
	public override EventInfo[] GetEvents(BindingFlags bindingAttr)
	{
		return null;
	}

	/// <summary>Returns the field specified by the given name.</summary>
	/// <param name="name">The name of the field to get.</param>
	/// <param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> : <see langword="InvokeMethod" />, <see langword="NonPublic" />, and so on.</param>
	/// <returns>Returns the <see cref="T:System.Reflection.FieldInfo" /> object representing the field declared or inherited by this type with the specified name and public or non-public modifier. If there are no matches, then null is returned.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete.</exception>
	public override FieldInfo GetField(string name, BindingFlags bindingAttr)
	{
		return null;
	}

	/// <summary>Returns the public and non-public fields that are declared by this type.</summary>
	/// <param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" />, such as InvokeMethod, NonPublic, and so on.</param>
	/// <returns>Returns an array of <see cref="T:System.Reflection.FieldInfo" /> objects representing the public and non-public fields declared or inherited by this type. An empty array is returned if there are no fields, as specified.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete.</exception>
	public override FieldInfo[] GetFields(BindingFlags bindingAttr)
	{
		return null;
	}

	/// <summary>Returns an array of all the interfaces implemented on this a class and its base classes.</summary>
	/// <returns>Returns an array of <see cref="T:System.Type" /> objects representing the implemented interfaces. If none are defined, an empty array is returned.</returns>
	public override Type[] GetInterfaces()
	{
		return null;
	}

	/// <summary>Returns the specified members declared or inherited by this type,.</summary>
	/// <param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> : <see langword="InvokeMethod" />, <see langword="NonPublic" />, and so on.</param>
	/// <returns>Returns an array of <see cref="T:System.Reflection.MemberInfo" /> objects representing the public and non-public members declared or inherited by this type. An empty array is returned if there are no matching members.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete.</exception>
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
	{
		return null;
	}

	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	/// <summary>Returns all the public and non-public methods declared or inherited by this type, as specified.</summary>
	/// <param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" />, such as <see langword="InvokeMethod" />, <see langword="NonPublic" />, and so on.</param>
	/// <returns>Returns an array of <see cref="T:System.Reflection.MethodInfo" /> objects representing the public and non-public methods defined on this type if <paramref name="nonPublic" /> is used; otherwise, only the public methods are returned.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete.</exception>
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
	{
		return null;
	}

	/// <summary>Returns the specified nested type that is declared by this type.</summary>
	/// <param name="name">The <see cref="T:System.String" /> containing the name of the nested type to get.</param>
	/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.  
	///  -or-  
	///  Zero, to conduct a case-sensitive search for public methods.</param>
	/// <returns>A <see cref="T:System.Type" /> object representing the nested type that matches the specified requirements, if found; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete.</exception>
	public override Type GetNestedType(string name, BindingFlags bindingAttr)
	{
		return null;
	}

	/// <summary>Returns all the public and non-public properties declared or inherited by this type, as specified.</summary>
	/// <param name="bindingAttr">This invocation attribute. This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> : <see langword="InvokeMethod" />, <see langword="NonPublic" />, and so on.</param>
	/// <returns>Returns an array of <see cref="T:System.Reflection.PropertyInfo" /> objects representing the public and non-public properties defined on this type if <paramref name="nonPublic" /> is used; otherwise, only the public properties are returned.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete.</exception>
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
	{
		return null;
	}

	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	protected override bool HasElementTypeImpl()
	{
		return false;
	}

	/// <summary>Invokes the specified member. The method that is to be invoked must be accessible and provide the most specific match with the specified argument list, under the contraints of the specified binder and invocation attributes.</summary>
	/// <param name="name">The name of the member to invoke. This can be a constructor, method, property, or field. A suitable invocation attribute must be specified. Note that it is possible to invoke the default member of a class by passing an empty string as the name of the member.</param>
	/// <param name="invokeAttr">The invocation attribute. This must be a bit flag from <see langword="BindingFlags" />.</param>
	/// <param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see langword="MemberInfo" /> objects using reflection. If binder is <see langword="null" />, the default binder is used. See <see cref="T:System.Reflection.Binder" />.</param>
	/// <param name="target">The object on which to invoke the specified member. If the member is static, this parameter is ignored.</param>
	/// <param name="args">An argument list. This is an array of objects that contains the number, order, and type of the parameters of the member to be invoked. If there are no parameters this should be null.</param>
	/// <param name="modifiers">An array of the same length as <paramref name="args" /> with elements that represent the attributes associated with the arguments of the member to be invoked. A parameter has attributes associated with it in the metadata. They are used by various interoperability services. See the metadata specs for details such as this.</param>
	/// <param name="culture">An instance of <see langword="CultureInfo" /> used to govern the coercion of types. If this is null, the <see langword="CultureInfo" /> for the current thread is used. (Note that this is necessary to, for example, convert a string that represents 1000 to a double value, since 1000 is represented differently by different cultures.)</param>
	/// <param name="namedParameters">Each parameter in the <paramref name="namedParameters" /> array gets the value in the corresponding element in the <paramref name="args" /> array. If the length of <paramref name="args" /> is greater than the length of <paramref name="namedParameters" />, the remaining argument values are passed in order.</param>
	/// <returns>Returns the return value of the invoked member.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete.</exception>
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
	{
		return null;
	}

	protected override bool IsArrayImpl()
	{
		return false;
	}

	protected override bool IsByRefImpl()
	{
		return false;
	}

	protected override bool IsCOMObjectImpl()
	{
		return false;
	}

	/// <summary>Checks if the specified custom attribute type is defined.</summary>
	/// <param name="attributeType">The <see langword="Type" /> object to which the custom attributes are applied.</param>
	/// <param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes.</param>
	/// <returns>
	///   <see langword="true" /> if one or more instance of <paramref name="attributeType" /> is defined on this member; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not currently supported in types that are not complete.</exception>
	public override bool IsDefined(Type attributeType, bool inherit)
	{
		return false;
	}

	protected override bool IsPointerImpl()
	{
		return false;
	}

	protected override bool IsPrimitiveImpl()
	{
		return false;
	}
}
