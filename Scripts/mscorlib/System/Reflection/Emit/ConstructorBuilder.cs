using System.Globalization;

namespace System.Reflection.Emit;

/// <summary>Defines and represents a constructor of a dynamic class.</summary>
public class ConstructorBuilder : ConstructorInfo
{
	/// <summary>Gets the attributes for this constructor.</summary>
	/// <returns>The attributes for this constructor.</returns>
	public override MethodAttributes Attributes => default(MethodAttributes);

	/// <summary>Gets a reference to the <see cref="T:System.Type" /> object for the type that declares this member.</summary>
	/// <returns>The type that declares this member.</returns>
	public override Type DeclaringType => null;

	/// <summary>Retrieves the name of this constructor.</summary>
	/// <returns>The name of this constructor.</returns>
	public override string Name => null;

	/// <summary>Gets the internal handle for the method. Use this handle to access the underlying metadata handle.</summary>
	/// <returns>The internal handle for the method. Use this handle to access the underlying metadata handle.</returns>
	/// <exception cref="T:System.NotSupportedException">This property is not supported on this class.</exception>
	public override RuntimeMethodHandle MethodHandle => default(RuntimeMethodHandle);

	/// <summary>Holds a reference to the <see cref="T:System.Type" /> object from which this object was obtained.</summary>
	/// <returns>The <see langword="Type" /> object from which this object was obtained.</returns>
	public override Type ReflectedType => null;

	/// <summary>Returns the parameters of this constructor.</summary>
	/// <returns>An array that represents the parameters of this constructor.</returns>
	/// <exception cref="T:System.InvalidOperationException">
	///   <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> has not been called on this constructor's type, in the .NET Framework versions 1.0 and 1.1.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <see cref="M:System.Reflection.Emit.TypeBuilder.CreateType" /> has not been called on this constructor's type, in the .NET Framework version 2.0.</exception>
	public override ParameterInfo[] GetParameters()
	{
		return null;
	}

	/// <summary>Returns the method implementation flags for this constructor.</summary>
	/// <returns>The method implementation flags for this constructor.</returns>
	public override MethodImplAttributes GetMethodImplementationFlags()
	{
		return default(MethodImplAttributes);
	}

	/// <summary>Dynamically invokes the constructor represented by this instance on the given object, passing along the specified parameters, and under the constraints of the given binder.</summary>
	/// <param name="invokeAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" />, such as InvokeMethod, NonPublic, and so on.</param>
	/// <param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see langword="MemberInfo" /> objects using reflection. If binder is <see langword="null" />, the default binder is used. See <see cref="T:System.Reflection.Binder" />.</param>
	/// <param name="parameters">An argument list. This is an array of arguments with the same number, order, and type as the parameters of the constructor to be invoked. If there are no parameters this should be <see langword="null" />.</param>
	/// <param name="culture">An instance of <see cref="T:System.Globalization.CultureInfo" /> used to govern the coercion of types. If this is null, the <see cref="T:System.Globalization.CultureInfo" /> for the current thread is used. (For example, this is necessary to convert a <see cref="T:System.String" /> that represents 1000 to a <see cref="T:System.Double" /> value, since 1000 is represented differently by different cultures.)</param>
	/// <returns>The value returned by the invoked constructor.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not currently supported. You can retrieve the constructor using <see cref="M:System.Type.GetConstructor(System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> and call <see cref="M:System.Reflection.ConstructorInfo.Invoke(System.Reflection.BindingFlags,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo)" /> on the returned <see cref="T:System.Reflection.ConstructorInfo" />.</exception>
	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
	{
		return null;
	}

	/// <summary>Checks if the specified custom attribute type is defined.</summary>
	/// <param name="attributeType">A custom attribute type.</param>
	/// <param name="inherit">Controls inheritance of custom attributes from base classes. This parameter is ignored.</param>
	/// <returns>
	///   <see langword="true" /> if the specified custom attribute type is defined; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not currently supported. You can retrieve the constructor using <see cref="M:System.Type.GetConstructor(System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> and call <see cref="M:System.Reflection.MemberInfo.IsDefined(System.Type,System.Boolean)" /> on the returned <see cref="T:System.Reflection.ConstructorInfo" />.</exception>
	public override bool IsDefined(Type attributeType, bool inherit)
	{
		return false;
	}

	/// <summary>Returns all the custom attributes defined for this constructor.</summary>
	/// <param name="inherit">Controls inheritance of custom attributes from base classes. This parameter is ignored.</param>
	/// <returns>An array of objects representing all the custom attributes of the constructor represented by this <see cref="T:System.Reflection.Emit.ConstructorBuilder" /> instance.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not currently supported.</exception>
	public override object[] GetCustomAttributes(bool inherit)
	{
		return null;
	}

	/// <summary>Returns the custom attributes identified by the given type.</summary>
	/// <param name="attributeType">The custom attribute type.</param>
	/// <param name="inherit">Controls inheritance of custom attributes from base classes. This parameter is ignored.</param>
	/// <returns>An object array that represents the attributes of this constructor.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not currently supported.</exception>
	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		return null;
	}

	/// <summary>Dynamically invokes the constructor reflected by this instance with the specified arguments, under the constraints of the specified <see langword="Binder" />.</summary>
	/// <param name="obj">The object that needs to be reinitialized.</param>
	/// <param name="invokeAttr">One of the <see langword="BindingFlags" /> values that specifies the type of binding that is desired.</param>
	/// <param name="binder">A <see langword="Binder" /> that defines a set of properties and enables the binding, coercion of argument types, and invocation of members using reflection. If <paramref name="binder" /> is <see langword="null" />, then Binder.DefaultBinding is used.</param>
	/// <param name="parameters">An argument list. This is an array of arguments with the same number, order, and type as the parameters of the constructor to be invoked. If there are no parameters, this should be a null reference (<see langword="Nothing" /> in Visual Basic).</param>
	/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> used to govern the coercion of types. If this is null, the <see cref="T:System.Globalization.CultureInfo" /> for the current thread is used.</param>
	/// <returns>An instance of the class associated with the constructor.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not currently supported. You can retrieve the constructor using <see cref="M:System.Type.GetConstructor(System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> and call <see cref="M:System.Reflection.ConstructorInfo.Invoke(System.Reflection.BindingFlags,System.Reflection.Binder,System.Object[],System.Globalization.CultureInfo)" /> on the returned <see cref="T:System.Reflection.ConstructorInfo" />.</exception>
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
	{
		return null;
	}
}
