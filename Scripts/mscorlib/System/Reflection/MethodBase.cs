using System.Diagnostics;
using System.Globalization;

namespace System.Reflection;

/// <summary>Provides information about methods and constructors.</summary>
[Serializable]
public abstract class MethodBase : MemberInfo
{
	/// <summary>Gets the attributes associated with this method.</summary>
	/// <returns>One of the <see cref="T:System.Reflection.MethodAttributes" /> values.</returns>
	public abstract MethodAttributes Attributes { get; }

	/// <summary>Gets a value indicating the calling conventions for this method.</summary>
	/// <returns>The <see cref="T:System.Reflection.CallingConventions" /> for this method.</returns>
	public virtual CallingConventions CallingConvention => default(CallingConventions);

	/// <summary>Gets a value indicating whether the method is abstract.</summary>
	/// <returns>
	///   <see langword="true" /> if the method is abstract; otherwise, <see langword="false" />.</returns>
	public bool IsAbstract => false;

	/// <summary>Gets a value indicating whether the method is a constructor.</summary>
	/// <returns>
	///   <see langword="true" /> if this method is a constructor represented by a <see cref="T:System.Reflection.ConstructorInfo" /> object (see note in Remarks about <see cref="T:System.Reflection.Emit.ConstructorBuilder" /> objects); otherwise, <see langword="false" />.</returns>
	public bool IsConstructor => false;

	/// <summary>Gets a value indicating whether this method has a special name.</summary>
	/// <returns>
	///   <see langword="true" /> if this method has a special name; otherwise, <see langword="false" />.</returns>
	public bool IsSpecialName => false;

	/// <summary>Gets a value indicating whether the method is <see langword="static" />.</summary>
	/// <returns>
	///   <see langword="true" /> if this method is <see langword="static" />; otherwise, <see langword="false" />.</returns>
	public bool IsStatic => false;

	/// <summary>Gets a value indicating whether the method is <see langword="virtual" />.</summary>
	/// <returns>
	///   <see langword="true" /> if this method is <see langword="virtual" />; otherwise, <see langword="false" />.</returns>
	public bool IsVirtual => false;

	/// <summary>Gets a value indicating whether this is a public method.</summary>
	/// <returns>
	///   <see langword="true" /> if this method is public; otherwise, <see langword="false" />.</returns>
	public bool IsPublic => false;

	/// <summary>Gets a value indicating whether the method is generic.</summary>
	/// <returns>
	///   <see langword="true" /> if the current <see cref="T:System.Reflection.MethodBase" /> represents a generic method; otherwise, <see langword="false" />.</returns>
	public virtual bool IsGenericMethod => false;

	/// <summary>Gets a value indicating whether the method is a generic method definition.</summary>
	/// <returns>
	///   <see langword="true" /> if the current <see cref="T:System.Reflection.MethodBase" /> object represents the definition of a generic method; otherwise, <see langword="false" />.</returns>
	public virtual bool IsGenericMethodDefinition => false;

	/// <summary>Gets a value indicating whether the generic method contains unassigned generic type parameters.</summary>
	/// <returns>
	///   <see langword="true" /> if the current <see cref="T:System.Reflection.MethodBase" /> object represents a generic method that contains unassigned generic type parameters; otherwise, <see langword="false" />.</returns>
	public virtual bool ContainsGenericParameters => false;

	/// <summary>Gets a handle to the internal metadata representation of a method.</summary>
	/// <returns>A <see cref="T:System.RuntimeMethodHandle" /> object.</returns>
	public abstract RuntimeMethodHandle MethodHandle { get; }

	/// <summary>Gets a value that indicates whether the current method or constructor is security-critical or security-safe-critical at the current trust level, and therefore can perform critical operations.</summary>
	/// <returns>
	///   <see langword="true" /> if the current method or constructor is security-critical or security-safe-critical at the current trust level; <see langword="false" /> if it is transparent.</returns>
	public virtual bool IsSecurityCritical => false;

	/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.MethodBase" /> class.</summary>
	protected MethodBase()
	{
	}

	/// <summary>When overridden in a derived class, gets the parameters of the specified method or constructor.</summary>
	/// <returns>An array of type <see langword="ParameterInfo" /> containing information that matches the signature of the method (or constructor) reflected by this <see langword="MethodBase" /> instance.</returns>
	public abstract ParameterInfo[] GetParameters();

	/// <summary>When overridden in a derived class, returns the <see cref="T:System.Reflection.MethodImplAttributes" /> flags.</summary>
	/// <returns>The <see langword="MethodImplAttributes" /> flags.</returns>
	public abstract MethodImplAttributes GetMethodImplementationFlags();

	/// <summary>Returns an array of <see cref="T:System.Type" /> objects that represent the type arguments of a generic method or the type parameters of a generic method definition.</summary>
	/// <returns>An array of <see cref="T:System.Type" /> objects that represent the type arguments of a generic method or the type parameters of a generic method definition. Returns an empty array if the current method is not a generic method.</returns>
	/// <exception cref="T:System.NotSupportedException">The current object is a <see cref="T:System.Reflection.ConstructorInfo" />. Generic constructors are not supported in the .NET Framework version 2.0. This exception is the default behavior if this method is not overridden in a derived class.</exception>
	public virtual Type[] GetGenericArguments()
	{
		return null;
	}

	/// <summary>Invokes the method or constructor represented by the current instance, using the specified parameters.</summary>
	/// <param name="obj">The object on which to invoke the method or constructor. If a method is static, this argument is ignored. If a constructor is static, this argument must be <see langword="null" /> or an instance of the class that defines the constructor.</param>
	/// <param name="parameters">An argument list for the invoked method or constructor. This is an array of objects with the same number, order, and type as the parameters of the method or constructor to be invoked. If there are no parameters, <paramref name="parameters" /> should be <see langword="null" />.  
	///  If the method or constructor represented by this instance takes a <see langword="ref" /> parameter (<see langword="ByRef" /> in Visual Basic), no special attribute is required for that parameter in order to invoke the method or constructor using this function. Any object in this array that is not explicitly initialized with a value will contain the default value for that object type. For reference-type elements, this value is <see langword="null" />. For value-type elements, this value is 0, 0.0, or <see langword="false" />, depending on the specific element type.</param>
	/// <returns>An object containing the return value of the invoked method, or <see langword="null" /> in the case of a constructor.</returns>
	/// <exception cref="T:System.Reflection.TargetException">In the.NET for Windows Store apps or the Portable Class Library, catch <see cref="T:System.Exception" /> instead.  
	///
	///
	///
	///
	///  The <paramref name="obj" /> parameter is <see langword="null" /> and the method is not static.  
	///  -or-  
	///  The method is not declared or inherited by the class of <paramref name="obj" />.  
	///  -or-  
	///  A static constructor is invoked, and <paramref name="obj" /> is neither <see langword="null" /> nor an instance of the class that declared the constructor.</exception>
	/// <exception cref="T:System.ArgumentException">The elements of the <paramref name="parameters" /> array do not match the signature of the method or constructor reflected by this instance.</exception>
	/// <exception cref="T:System.Reflection.TargetInvocationException">The invoked method or constructor throws an exception.  
	///  -or-  
	///  The current instance is a <see cref="T:System.Reflection.Emit.DynamicMethod" /> that contains unverifiable code. See the "Verification" section in Remarks for <see cref="T:System.Reflection.Emit.DynamicMethod" />.</exception>
	/// <exception cref="T:System.Reflection.TargetParameterCountException">The <paramref name="parameters" /> array does not have the correct number of arguments.</exception>
	/// <exception cref="T:System.MethodAccessException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.MemberAccessException" />, instead.  
	///
	///
	///
	///
	///  The caller does not have permission to execute the method or constructor that is represented by the current instance.</exception>
	/// <exception cref="T:System.InvalidOperationException">The type that declares the method is an open generic type. That is, the <see cref="P:System.Type.ContainsGenericParameters" /> property returns <see langword="true" /> for the declaring type.</exception>
	/// <exception cref="T:System.NotSupportedException">The current instance is a <see cref="T:System.Reflection.Emit.MethodBuilder" />.</exception>
	[DebuggerStepThrough]
	[DebuggerHidden]
	public object Invoke(object obj, object[] parameters)
	{
		return null;
	}

	/// <summary>When overridden in a derived class, invokes the reflected method or constructor with the given parameters.</summary>
	/// <param name="obj">The object on which to invoke the method or constructor. If a method is static, this argument is ignored. If a constructor is static, this argument must be <see langword="null" /> or an instance of the class that defines the constructor.</param>
	/// <param name="invokeAttr">A bitmask that is a combination of 0 or more bit flags from <see cref="T:System.Reflection.BindingFlags" />. If <paramref name="binder" /> is <see langword="null" />, this parameter is assigned the value <see cref="F:System.Reflection.BindingFlags.Default" />; thus, whatever you pass in is ignored.</param>
	/// <param name="binder">An object that enables the binding, coercion of argument types, invocation of members, and retrieval of <see langword="MemberInfo" /> objects via reflection. If <paramref name="binder" /> is <see langword="null" />, the default binder is used.</param>
	/// <param name="parameters">An argument list for the invoked method or constructor. This is an array of objects with the same number, order, and type as the parameters of the method or constructor to be invoked. If there are no parameters, this should be <see langword="null" />.  
	///  If the method or constructor represented by this instance takes a ByRef parameter, there is no special attribute required for that parameter in order to invoke the method or constructor using this function. Any object in this array that is not explicitly initialized with a value will contain the default value for that object type. For reference-type elements, this value is <see langword="null" />. For value-type elements, this value is 0, 0.0, or <see langword="false" />, depending on the specific element type.</param>
	/// <param name="culture">An instance of <see langword="CultureInfo" /> used to govern the coercion of types. If this is <see langword="null" />, the <see langword="CultureInfo" /> for the current thread is used. (This is necessary to convert a <see langword="String" /> that represents 1000 to a <see langword="Double" /> value, for example, since 1000 is represented differently by different cultures.)</param>
	/// <returns>An <see langword="Object" /> containing the return value of the invoked method, or <see langword="null" /> in the case of a constructor, or <see langword="null" /> if the method's return type is <see langword="void" />. Before calling the method or constructor, <see langword="Invoke" /> checks to see if the user has access permission and verifies that the parameters are valid.</returns>
	/// <exception cref="T:System.Reflection.TargetException">The <paramref name="obj" /> parameter is <see langword="null" /> and the method is not static.  
	///  -or-  
	///  The method is not declared or inherited by the class of <paramref name="obj" />.  
	///  -or-  
	///  A static constructor is invoked, and <paramref name="obj" /> is neither <see langword="null" /> nor an instance of the class that declared the constructor.</exception>
	/// <exception cref="T:System.ArgumentException">The type of the <paramref name="parameters" /> parameter does not match the signature of the method or constructor reflected by this instance.</exception>
	/// <exception cref="T:System.Reflection.TargetParameterCountException">The <paramref name="parameters" /> array does not have the correct number of arguments.</exception>
	/// <exception cref="T:System.Reflection.TargetInvocationException">The invoked method or constructor throws an exception.</exception>
	/// <exception cref="T:System.MethodAccessException">The caller does not have permission to execute the method or constructor that is represented by the current instance.</exception>
	/// <exception cref="T:System.InvalidOperationException">The type that declares the method is an open generic type. That is, the <see cref="P:System.Type.ContainsGenericParameters" /> property returns <see langword="true" /> for the declaring type.</exception>
	public abstract object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

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

	/// <summary>Indicates whether two <see cref="T:System.Reflection.MethodBase" /> objects are equal.</summary>
	/// <param name="left">The first object to compare.</param>
	/// <param name="right">The second object to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="left" /> is equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
	public static bool operator ==(MethodBase left, MethodBase right)
	{
		return false;
	}

	/// <summary>Indicates whether two <see cref="T:System.Reflection.MethodBase" /> objects are not equal.</summary>
	/// <param name="left">The first object to compare.</param>
	/// <param name="right">The second object to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="left" /> is not equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
	public static bool operator !=(MethodBase left, MethodBase right)
	{
		return false;
	}

	internal virtual ParameterInfo[] GetParametersInternal()
	{
		return null;
	}

	internal virtual int GetParametersCount()
	{
		return 0;
	}

	internal virtual string FormatNameAndSig(bool serialization)
	{
		return null;
	}

	internal virtual Type[] GetParameterTypes()
	{
		return null;
	}

	internal virtual ParameterInfo[] GetParametersNoCopy()
	{
		return null;
	}

	/// <summary>Gets method information by using the method's internal metadata representation (handle).</summary>
	/// <param name="handle">The method's handle.</param>
	/// <returns>A <see langword="MethodBase" /> containing information about the method.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="handle" /> is invalid.</exception>
	public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle)
	{
		return null;
	}

	internal static string ConstructParameters(Type[] parameterTypes, CallingConventions callingConvention, bool serialization)
	{
		return null;
	}
}
