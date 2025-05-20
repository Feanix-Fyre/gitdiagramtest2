using System.Globalization;

namespace System.Reflection.Emit;

/// <summary>Defines and represents a dynamic method that can be compiled, executed, and discarded. Discarded methods are available for garbage collection.</summary>
public sealed class DynamicMethod : MethodInfo
{
	/// <summary>Gets the attributes specified when the dynamic method was created.</summary>
	/// <returns>A bitwise combination of the <see cref="T:System.Reflection.MethodAttributes" /> values representing the attributes for the method.</returns>
	public override MethodAttributes Attributes => default(MethodAttributes);

	/// <summary>Gets the type that declares the method, which is always <see langword="null" /> for dynamic methods.</summary>
	/// <returns>Always <see langword="null" />.</returns>
	public override Type DeclaringType => null;

	/// <summary>Gets the name of the dynamic method.</summary>
	/// <returns>The simple name of the method.</returns>
	public override string Name => null;

	/// <summary>Not supported for dynamic methods.</summary>
	/// <returns>Not supported for dynamic methods.</returns>
	/// <exception cref="T:System.InvalidOperationException">Not allowed for dynamic methods.</exception>
	public override RuntimeMethodHandle MethodHandle => default(RuntimeMethodHandle);

	/// <summary>Gets the class that was used in reflection to obtain the method.</summary>
	/// <returns>Always <see langword="null" />.</returns>
	public override Type ReflectedType => null;

	/// <summary>Returns the parameters of the dynamic method.</summary>
	/// <returns>An array of <see cref="T:System.Reflection.ParameterInfo" /> objects that represent the parameters of the dynamic method.</returns>
	public override ParameterInfo[] GetParameters()
	{
		return null;
	}

	/// <summary>Returns all the custom attributes defined for the method.</summary>
	/// <param name="inherit">
	///   <see langword="true" /> to search the method's inheritance chain to find the custom attributes; <see langword="false" /> to check only the current method.</param>
	/// <returns>An array of objects representing all the custom attributes of the method.</returns>
	public override object[] GetCustomAttributes(bool inherit)
	{
		return null;
	}

	/// <summary>Returns the custom attributes of the specified type that have been applied to the method.</summary>
	/// <param name="attributeType">A <see cref="T:System.Type" /> representing the type of custom attribute to return.</param>
	/// <param name="inherit">
	///   <see langword="true" /> to search the method's inheritance chain to find the custom attributes; <see langword="false" /> to check only the current method.</param>
	/// <returns>An array of objects representing the attributes of the method that are of type <paramref name="attributeType" /> or derive from type <paramref name="attributeType" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="attributeType" /> is <see langword="null" />.</exception>
	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		return null;
	}

	/// <summary>Returns the implementation flags for the method.</summary>
	/// <returns>A bitwise combination of <see cref="T:System.Reflection.MethodImplAttributes" /> values representing the implementation flags for the method.</returns>
	public override MethodImplAttributes GetMethodImplementationFlags()
	{
		return default(MethodImplAttributes);
	}

	/// <summary>Returns the base implementation for the method.</summary>
	/// <returns>The base implementation of the method.</returns>
	public override MethodInfo GetBaseDefinition()
	{
		return null;
	}

	/// <summary>Invokes the dynamic method using the specified parameters, under the constraints of the specified binder, with the specified culture information.</summary>
	/// <param name="obj">This parameter is ignored for dynamic methods, because they are static. Specify <see langword="null" />.</param>
	/// <param name="invokeAttr">A bitwise combination of <see cref="T:System.Reflection.BindingFlags" /> values.</param>
	/// <param name="binder">A <see cref="T:System.Reflection.Binder" /> object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see cref="T:System.Reflection.MemberInfo" /> objects through reflection. If <paramref name="binder" /> is <see langword="null" />, the default binder is used. For more details, see <see cref="T:System.Reflection.Binder" />.</param>
	/// <param name="parameters">An argument list. This is an array of arguments with the same number, order, and type as the parameters of the method to be invoked. If there are no parameters this parameter should be <see langword="null" />.</param>
	/// <param name="culture">An instance of <see cref="T:System.Globalization.CultureInfo" /> used to govern the coercion of types. If this is <see langword="null" />, the <see cref="T:System.Globalization.CultureInfo" /> for the current thread is used. For example, this information is needed to correctly convert a <see cref="T:System.String" /> that represents 1000 to a <see cref="T:System.Double" /> value, because 1000 is represented differently by different cultures.</param>
	/// <returns>A <see cref="T:System.Object" /> containing the return value of the invoked method.</returns>
	/// <exception cref="T:System.NotSupportedException">The <see cref="F:System.Reflection.CallingConventions.VarArgs" /> calling convention is not supported.</exception>
	/// <exception cref="T:System.Reflection.TargetParameterCountException">The number of elements in <paramref name="parameters" /> does not match the number of parameters in the dynamic method.</exception>
	/// <exception cref="T:System.ArgumentException">The type of one or more elements of <paramref name="parameters" /> does not match the type of the corresponding parameter of the dynamic method.</exception>
	/// <exception cref="T:System.Reflection.TargetInvocationException">The dynamic method is associated with a module, is not anonymously hosted, and was constructed with <paramref name="skipVisibility" /> set to <see langword="false" />, but the dynamic method accesses members that are not <see langword="public" /> or <see langword="internal" /> (<see langword="Friend" /> in Visual Basic).  
	///  -or-  
	///  The dynamic method is anonymously hosted and was constructed with <paramref name="skipVisibility" /> set to <see langword="false" />, but it accesses members that are not <see langword="public" />.  
	///  -or-  
	///  The dynamic method contains unverifiable code. See the "Verification" section in Remarks for <see cref="T:System.Reflection.Emit.DynamicMethod" />.</exception>
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
	{
		return null;
	}

	/// <summary>Indicates whether the specified custom attribute type is defined.</summary>
	/// <param name="attributeType">A <see cref="T:System.Type" /> representing the type of custom attribute to search for.</param>
	/// <param name="inherit">
	///   <see langword="true" /> to search the method's inheritance chain to find the custom attributes; <see langword="false" /> to check only the current method.</param>
	/// <returns>
	///   <see langword="true" /> if the specified custom attribute type is defined; otherwise, <see langword="false" />.</returns>
	public override bool IsDefined(Type attributeType, bool inherit)
	{
		return false;
	}
}
