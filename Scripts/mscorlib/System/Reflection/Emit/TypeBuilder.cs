using System.Globalization;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit;

/// <summary>Defines and creates new instances of classes during run time.</summary>
public sealed class TypeBuilder : TypeInfo
{
	/// <summary>Represents that total size for the type is not specified.</summary>
	public const int UnspecifiedTypeSize = 0;

	/// <summary>Retrieves the dynamic assembly that contains this type definition.</summary>
	/// <returns>Read-only. Retrieves the dynamic assembly that contains this type definition.</returns>
	public override Assembly Assembly => null;

	/// <summary>Returns the full name of this type qualified by the display name of the assembly.</summary>
	/// <returns>Read-only. The full name of this type qualified by the display name of the assembly.</returns>
	public override string AssemblyQualifiedName => null;

	/// <summary>Retrieves the base type of this type.</summary>
	/// <returns>Read-only. Retrieves the base type of this type.</returns>
	public override Type BaseType => null;

	/// <summary>Retrieves the full path of this type.</summary>
	/// <returns>Read-only. Retrieves the full path of this type.</returns>
	public override string FullName => null;

	/// <summary>Retrieves the dynamic module that contains this type definition.</summary>
	/// <returns>Read-only. Retrieves the dynamic module that contains this type definition.</returns>
	public override Module Module => null;

	/// <summary>Retrieves the name of this type.</summary>
	/// <returns>Read-only. Retrieves the <see cref="T:System.String" /> name of this type.</returns>
	public override string Name => null;

	/// <summary>Retrieves the namespace where this <see langword="TypeBuilder" /> is defined.</summary>
	/// <returns>Read-only. Retrieves the namespace where this <see langword="TypeBuilder" /> is defined.</returns>
	public override string Namespace => null;

	/// <summary>Returns the underlying system type for this <see langword="TypeBuilder" />.</summary>
	/// <returns>Read-only. Returns the underlying system type.</returns>
	/// <exception cref="T:System.InvalidOperationException">This type is an enumeration, but there is no underlying system type.</exception>
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
	/// <param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> as in <see langword="InvokeMethod" />, <see langword="NonPublic" />, and so on.</param>
	/// <returns>Returns an array of <see cref="T:System.Reflection.ConstructorInfo" /> objects representing the specified constructors defined for this class. If no constructors are defined, an empty array is returned.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not implemented for incomplete types.</exception>
	[ComVisible(true)]
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
	{
		return null;
	}

	/// <summary>Returns all the custom attributes defined for this type.</summary>
	/// <param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes.</param>
	/// <returns>Returns an array of objects representing all the custom attributes of this type.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not currently supported for incomplete types. Retrieve the type using <see cref="M:System.Type.GetType" /> and call <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Boolean)" /> on the returned <see cref="T:System.Type" />.</exception>
	public override object[] GetCustomAttributes(bool inherit)
	{
		return null;
	}

	/// <summary>Returns all the custom attributes of the current type that are assignable to a specified type.</summary>
	/// <param name="attributeType">The type of attribute to search for. Only attributes that are assignable to this type are returned.</param>
	/// <param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes.</param>
	/// <returns>An array of custom attributes defined on the current type.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not currently supported for incomplete types. Retrieve the type using <see cref="M:System.Type.GetType" /> and call <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Boolean)" /> on the returned <see cref="T:System.Type" />.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="attributeType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The type must be a type provided by the underlying runtime system.</exception>
	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		return null;
	}

	/// <summary>Calling this method always throws <see cref="T:System.NotSupportedException" />.</summary>
	/// <returns>This method is not supported. No value is returned.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not supported.</exception>
	public override Type GetElementType()
	{
		return null;
	}

	/// <summary>Returns the event with the specified name.</summary>
	/// <param name="name">The name of the event to search for.</param>
	/// <param name="bindingAttr">A bitwise combination of <see cref="T:System.Reflection.BindingFlags" /> values that limits the search.</param>
	/// <returns>An <see cref="T:System.Reflection.EventInfo" /> object representing the event declared or inherited by this type with the specified name, or <see langword="null" /> if there are no matches.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not implemented for incomplete types.</exception>
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
	{
		return null;
	}

	/// <summary>Returns the public and non-public events that are declared by this type.</summary>
	/// <param name="bindingAttr">A bitwise combination of <see cref="T:System.Reflection.BindingFlags" /> values that limits the search.</param>
	/// <returns>Returns an array of <see cref="T:System.Reflection.EventInfo" /> objects representing the events declared or inherited by this type that match the specified binding flags. An empty array is returned if there are no matching events.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not implemented for incomplete types.</exception>
	public override EventInfo[] GetEvents(BindingFlags bindingAttr)
	{
		return null;
	}

	/// <summary>Returns the field specified by the given name.</summary>
	/// <param name="name">The name of the field to get.</param>
	/// <param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> as in <see langword="InvokeMethod" />, <see langword="NonPublic" />, and so on.</param>
	/// <returns>Returns the <see cref="T:System.Reflection.FieldInfo" /> object representing the field declared or inherited by this type with the specified name and public or non-public modifier. If there are no matches then <see langword="null" /> is returned.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not implemented for incomplete types.</exception>
	public override FieldInfo GetField(string name, BindingFlags bindingAttr)
	{
		return null;
	}

	/// <summary>Returns the public and non-public fields that are declared by this type.</summary>
	/// <param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> : <see langword="InvokeMethod" />, <see langword="NonPublic" />, and so on.</param>
	/// <returns>Returns an array of <see cref="T:System.Reflection.FieldInfo" /> objects representing the public and non-public fields declared or inherited by this type. An empty array is returned if there are no fields, as specified.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not implemented for incomplete types.</exception>
	public override FieldInfo[] GetFields(BindingFlags bindingAttr)
	{
		return null;
	}

	/// <summary>Returns an array of all the interfaces implemented on this type and its base types.</summary>
	/// <returns>Returns an array of <see cref="T:System.Type" /> objects representing the implemented interfaces. If none are defined, an empty array is returned.</returns>
	public override Type[] GetInterfaces()
	{
		return null;
	}

	/// <summary>Returns the members for the public and non-public members declared or inherited by this type.</summary>
	/// <param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" />, such as <see langword="InvokeMethod" />, <see langword="NonPublic" />, and so on.</param>
	/// <returns>Returns an array of <see cref="T:System.Reflection.MemberInfo" /> objects representing the public and non-public members declared or inherited by this type. An empty array is returned if there are no matching members.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not implemented for incomplete types.</exception>
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
	{
		return null;
	}

	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
	{
		return null;
	}

	/// <summary>Returns all the public and non-public methods declared or inherited by this type, as specified.</summary>
	/// <param name="bindingAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> as in <see langword="InvokeMethod" />, <see langword="NonPublic" />, and so on.</param>
	/// <returns>Returns an array of <see cref="T:System.Reflection.MethodInfo" /> objects representing the public and non-public methods defined on this type if <paramref name="nonPublic" /> is used; otherwise, only the public methods are returned.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not implemented for incomplete types.</exception>
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
	{
		return null;
	}

	/// <summary>Returns the public and non-public nested types that are declared by this type.</summary>
	/// <param name="name">The <see cref="T:System.String" /> containing the name of the nested type to get.</param>
	/// <param name="bindingAttr">A bitmask comprised of one or more <see cref="T:System.Reflection.BindingFlags" /> that specify how the search is conducted.  
	///  -or-  
	///  Zero, to conduct a case-sensitive search for public methods.</param>
	/// <returns>A <see cref="T:System.Type" /> object representing the nested type that matches the specified requirements, if found; otherwise, <see langword="null" />.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not implemented for incomplete types.</exception>
	public override Type GetNestedType(string name, BindingFlags bindingAttr)
	{
		return null;
	}

	/// <summary>Returns all the public and non-public properties declared or inherited by this type, as specified.</summary>
	/// <param name="bindingAttr">This invocation attribute. This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> : <see langword="InvokeMethod" />, <see langword="NonPublic" />, and so on.</param>
	/// <returns>Returns an array of <see langword="PropertyInfo" /> objects representing the public and non-public properties defined on this type if <paramref name="nonPublic" /> is used; otherwise, only the public properties are returned.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not implemented for incomplete types.</exception>
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

	/// <summary>Invokes the specified member. The method that is to be invoked must be accessible and provide the most specific match with the specified argument list, under the constraints of the specified binder and invocation attributes.</summary>
	/// <param name="name">The name of the member to invoke. This can be a constructor, method, property, or field. A suitable invocation attribute must be specified. Note that it is possible to invoke the default member of a class by passing an empty string as the name of the member.</param>
	/// <param name="invokeAttr">The invocation attribute. This must be a bit flag from <see langword="BindingFlags" />.</param>
	/// <param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see langword="MemberInfo" /> objects using reflection. If binder is <see langword="null" />, the default binder is used. See <see cref="T:System.Reflection.Binder" />.</param>
	/// <param name="target">The object on which to invoke the specified member. If the member is static, this parameter is ignored.</param>
	/// <param name="args">An argument list. This is an array of Objects that contains the number, order, and type of the parameters of the member to be invoked. If there are no parameters this should be null.</param>
	/// <param name="modifiers">An array of the same length as <paramref name="args" /> with elements that represent the attributes associated with the arguments of the member to be invoked. A parameter has attributes associated with it in the metadata. They are used by various interoperability services. See the metadata specs for more details.</param>
	/// <param name="culture">An instance of <see langword="CultureInfo" /> used to govern the coercion of types. If this is null, the <see langword="CultureInfo" /> for the current thread is used. (Note that this is necessary to, for example, convert a String that represents 1000 to a Double value, since 1000 is represented differently by different cultures.)</param>
	/// <param name="namedParameters">Each parameter in the <paramref name="namedParameters" /> array gets the value in the corresponding element in the <paramref name="args" /> array. If the length of <paramref name="args" /> is greater than the length of <paramref name="namedParameters" />, the remaining argument values are passed in order.</param>
	/// <returns>Returns the return value of the invoked member.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not currently supported for incomplete types.</exception>
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

	/// <summary>Determines whether a custom attribute is applied to the current type.</summary>
	/// <param name="attributeType">The type of attribute to search for. Only attributes that are assignable to this type are returned.</param>
	/// <param name="inherit">Specifies whether to search this member's inheritance chain to find the attributes.</param>
	/// <returns>
	///   <see langword="true" /> if one or more instances of <paramref name="attributeType" />, or an attribute derived from <paramref name="attributeType" />, is defined on this type; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not currently supported for incomplete types. Retrieve the type using <see cref="M:System.Type.GetType" /> and call <see cref="M:System.Reflection.MemberInfo.IsDefined(System.Type,System.Boolean)" /> on the returned <see cref="T:System.Type" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="attributeType" /> is not defined.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="attributeType" /> is <see langword="null" />.</exception>
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
