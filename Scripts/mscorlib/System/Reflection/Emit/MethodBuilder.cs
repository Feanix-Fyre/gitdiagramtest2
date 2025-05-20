using System.Globalization;

namespace System.Reflection.Emit;

/// <summary>Defines and represents a method (or constructor) on a dynamic class.</summary>
public sealed class MethodBuilder : MethodInfo
{
	/// <summary>Retrieves the attributes for this method.</summary>
	/// <returns>Read-only. Retrieves the <see langword="MethodAttributes" /> for this method.</returns>
	public override MethodAttributes Attributes => default(MethodAttributes);

	/// <summary>Returns the type that declares this method.</summary>
	/// <returns>Read-only. The type that declares this method.</returns>
	public override Type DeclaringType => null;

	/// <summary>Retrieves the internal handle for the method. Use this handle to access the underlying metadata handle.</summary>
	/// <returns>Read-only. The internal handle for the method. Use this handle to access the underlying metadata handle.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not currently supported. Retrieve the method using <see cref="M:System.Type.GetMethod(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> and call <see cref="P:System.Reflection.MethodBase.MethodHandle" /> on the returned <see cref="T:System.Reflection.MethodInfo" />.</exception>
	public override RuntimeMethodHandle MethodHandle => default(RuntimeMethodHandle);

	/// <summary>Retrieves the name of this method.</summary>
	/// <returns>Read-only. Retrieves a string containing the simple name of this method.</returns>
	public override string Name => null;

	/// <summary>Retrieves the class that was used in reflection to obtain this object.</summary>
	/// <returns>Read-only. The type used to obtain this method.</returns>
	public override Type ReflectedType => null;

	/// <summary>Return the base implementation for a method.</summary>
	/// <returns>The base implementation of this method.</returns>
	public override MethodInfo GetBaseDefinition()
	{
		return null;
	}

	/// <summary>Returns all the custom attributes defined for this method.</summary>
	/// <param name="inherit">Specifies whether to search this member's inheritance chain to find the custom attributes.</param>
	/// <returns>Returns an array of objects representing all the custom attributes of this method.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not currently supported. Retrieve the method using <see cref="M:System.Type.GetMethod(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> and call <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Boolean)" /> on the returned <see cref="T:System.Reflection.MethodInfo" />.</exception>
	public override object[] GetCustomAttributes(bool inherit)
	{
		return null;
	}

	/// <summary>Returns the custom attributes identified by the given type.</summary>
	/// <param name="attributeType">The custom attribute type.</param>
	/// <param name="inherit">Specifies whether to search this member's inheritance chain to find the custom attributes.</param>
	/// <returns>Returns an array of objects representing the attributes of this method that are of type <paramref name="attributeType" />.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not currently supported. Retrieve the method using <see cref="M:System.Type.GetMethod(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> and call <see cref="M:System.Reflection.MemberInfo.GetCustomAttributes(System.Boolean)" /> on the returned <see cref="T:System.Reflection.MethodInfo" />.</exception>
	public override object[] GetCustomAttributes(Type attributeType, bool inherit)
	{
		return null;
	}

	/// <summary>Returns the implementation flags for the method.</summary>
	/// <returns>Returns the implementation flags for the method.</returns>
	public override MethodImplAttributes GetMethodImplementationFlags()
	{
		return default(MethodImplAttributes);
	}

	/// <summary>Returns the parameters of this method.</summary>
	/// <returns>An array of <see langword="ParameterInfo" /> objects that represent the parameters of the method.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not currently supported. Retrieve the method using <see cref="M:System.Type.GetMethod(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> and call <see langword="GetParameters" /> on the returned <see cref="T:System.Reflection.MethodInfo" />.</exception>
	public override ParameterInfo[] GetParameters()
	{
		return null;
	}

	/// <summary>Dynamically invokes the method reflected by this instance on the given object, passing along the specified parameters, and under the constraints of the given binder.</summary>
	/// <param name="obj">The object on which to invoke the specified method. If the method is static, this parameter is ignored.</param>
	/// <param name="invokeAttr">This must be a bit flag from <see cref="T:System.Reflection.BindingFlags" /> : <see langword="InvokeMethod" />, <see langword="NonPublic" />, and so on.</param>
	/// <param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of MemberInfo objects via reflection. If binder is <see langword="null" />, the default binder is used. For more details, see <see cref="T:System.Reflection.Binder" />.</param>
	/// <param name="parameters">An argument list. This is an array of arguments with the same number, order, and type as the parameters of the method to be invoked. If there are no parameters this should be <see langword="null" />.</param>
	/// <param name="culture">An instance of <see cref="T:System.Globalization.CultureInfo" /> used to govern the coercion of types. If this is null, the <see cref="T:System.Globalization.CultureInfo" /> for the current thread is used. (Note that this is necessary to, for example, convert a <see cref="T:System.String" /> that represents 1000 to a <see cref="T:System.Double" /> value, since 1000 is represented differently by different cultures.)</param>
	/// <returns>Returns an object containing the return value of the invoked method.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not currently supported. Retrieve the method using <see cref="M:System.Type.GetMethod(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> and call <see cref="M:System.Type.InvokeMember(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object,System.Object[],System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[])" /> on the returned <see cref="T:System.Reflection.MethodInfo" />.</exception>
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture)
	{
		return null;
	}

	/// <summary>Checks if the specified custom attribute type is defined.</summary>
	/// <param name="attributeType">The custom attribute type.</param>
	/// <param name="inherit">Specifies whether to search this member's inheritance chain to find the custom attributes.</param>
	/// <returns>
	///   <see langword="true" /> if the specified custom attribute type is defined; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not currently supported. Retrieve the method using <see cref="M:System.Type.GetMethod(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Reflection.CallingConventions,System.Type[],System.Reflection.ParameterModifier[])" /> and call <see cref="M:System.Reflection.MemberInfo.IsDefined(System.Type,System.Boolean)" /> on the returned <see cref="T:System.Reflection.MethodInfo" />.</exception>
	public override bool IsDefined(Type attributeType, bool inherit)
	{
		return false;
	}
}
