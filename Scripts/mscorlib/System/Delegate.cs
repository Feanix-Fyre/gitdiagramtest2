using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

/// <summary>Represents a delegate, which is a data structure that refers to a static method or to a class instance and an instance method of that class.</summary>
[Serializable]
[StructLayout((LayoutKind)0)]
public abstract class Delegate : ICloneable, ISerializable
{
	private IntPtr method_ptr;

	private IntPtr invoke_impl;

	private object m_target;

	private IntPtr method;

	private IntPtr delegate_trampoline;

	private IntPtr extra_arg;

	private IntPtr method_code;

	private IntPtr interp_method;

	private IntPtr interp_invoke_impl;

	private MethodInfo method_info;

	private MethodInfo original_method_info;

	private DelegateData data;

	private bool method_is_virtual;

	/// <summary>Gets the method represented by the delegate.</summary>
	/// <returns>A <see cref="T:System.Reflection.MethodInfo" /> describing the method represented by the delegate.</returns>
	/// <exception cref="T:System.MemberAccessException">The caller does not have access to the method represented by the delegate (for example, if the method is private).</exception>
	public MethodInfo Method => null;

	/// <summary>Gets the class instance on which the current delegate invokes the instance method.</summary>
	/// <returns>The object on which the current delegate invokes the instance method, if the delegate represents an instance method; <see langword="null" /> if the delegate represents a static method.</returns>
	public object Target => null;

	private MethodInfo GetVirtualMethod_internal()
	{
		return null;
	}

	internal static Delegate CreateDelegate_internal(Type type, object target, MethodInfo info, bool throwOnBindFailure)
	{
		return null;
	}

	private static bool arg_type_match(Type delArgType, Type argType)
	{
		return false;
	}

	private static bool arg_type_match_this(Type delArgType, Type argType, bool boxedThis)
	{
		return false;
	}

	private static bool return_type_match(Type delReturnType, Type returnType)
	{
		return false;
	}

	private static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method, bool throwOnBindFailure, bool allowClosed)
	{
		return null;
	}

	/// <summary>Creates a delegate of the specified type that represents the specified static or instance method, with the specified first argument.</summary>
	/// <param name="type">The <see cref="T:System.Type" /> of delegate to create.</param>
	/// <param name="firstArgument">The object to which the delegate is bound, or <see langword="null" /> to treat <paramref name="method" /> as <see langword="static" /> (<see langword="Shared" /> in Visual Basic).</param>
	/// <param name="method">The <see cref="T:System.Reflection.MethodInfo" /> describing the static or instance method the delegate is to represent.</param>
	/// <returns>A delegate of the specified type that represents the specified static or instance method.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="type" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="method" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />.  
	/// -or-  
	/// <paramref name="type" /> is not a <see langword="RuntimeType" />. See Runtime Types in Reflection.  
	/// -or-  
	/// <paramref name="method" /> cannot be bound.  
	/// -or-  
	/// <paramref name="method" /> is not a <see langword="RuntimeMethodInfo" />. See Runtime Types in Reflection.</exception>
	/// <exception cref="T:System.MissingMethodException">The <see langword="Invoke" /> method of <paramref name="type" /> is not found.</exception>
	/// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />.</exception>
	public static Delegate CreateDelegate(Type type, object firstArgument, MethodInfo method)
	{
		return null;
	}

	/// <summary>Creates a delegate of the specified type to represent the specified static method, with the specified behavior on failure to bind.</summary>
	/// <param name="type">The <see cref="T:System.Type" /> of delegate to create.</param>
	/// <param name="method">The <see cref="T:System.Reflection.MethodInfo" /> describing the static or instance method the delegate is to represent.</param>
	/// <param name="throwOnBindFailure">
	///   <see langword="true" /> to throw an exception if <paramref name="method" /> cannot be bound; otherwise, <see langword="false" />.</param>
	/// <returns>A delegate of the specified type to represent the specified static method.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="type" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="method" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />.  
	/// -or-  
	/// <paramref name="type" /> is not a <see langword="RuntimeType" />. See Runtime Types in Reflection.  
	/// -or-  
	/// <paramref name="method" /> cannot be bound, and <paramref name="throwOnBindFailure" /> is <see langword="true" />.  
	/// -or-  
	/// <paramref name="method" /> is not a <see langword="RuntimeMethodInfo" />. See Runtime Types in Reflection.</exception>
	/// <exception cref="T:System.MissingMethodException">The <see langword="Invoke" /> method of <paramref name="type" /> is not found.</exception>
	/// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />.</exception>
	public static Delegate CreateDelegate(Type type, MethodInfo method, bool throwOnBindFailure)
	{
		return null;
	}

	/// <summary>Creates a delegate of the specified type to represent the specified static method.</summary>
	/// <param name="type">The <see cref="T:System.Type" /> of delegate to create.</param>
	/// <param name="method">The <see cref="T:System.Reflection.MethodInfo" /> describing the static or instance method the delegate is to represent. Only static methods are supported in the .NET Framework version 1.0 and 1.1.</param>
	/// <returns>A delegate of the specified type to represent the specified static method.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="type" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="method" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />.  
	/// -or-  
	/// <paramref name="type" /> is not a <see langword="RuntimeType" />. See Runtime Types in Reflection.  
	/// -or-  
	/// <paramref name="method" /> is not a static method, and the .NET Framework version is 1.0 or 1.1.  
	/// -or-  
	/// <paramref name="method" /> cannot be bound.  
	/// -or-  
	/// <paramref name="method" /> is not a <see langword="RuntimeMethodInfo" />. See Runtime Types in Reflection.</exception>
	/// <exception cref="T:System.MissingMethodException">The <see langword="Invoke" /> method of <paramref name="type" /> is not found.</exception>
	/// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />.</exception>
	public static Delegate CreateDelegate(Type type, MethodInfo method)
	{
		return null;
	}

	/// <summary>Creates a delegate of the specified type that represents the specified instance method to invoke on the specified class instance.</summary>
	/// <param name="type">The <see cref="T:System.Type" /> of delegate to create.</param>
	/// <param name="target">The class instance on which <paramref name="method" /> is invoked.</param>
	/// <param name="method">The name of the instance method that the delegate is to represent.</param>
	/// <returns>A delegate of the specified type that represents the specified instance method to invoke on the specified class instance.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="type" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="target" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="method" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />.  
	/// -or-  
	/// <paramref name="type" /> is not a <see langword="RuntimeType" />. See Runtime Types in Reflection.  
	/// -or-  
	/// <paramref name="method" /> is not an instance method.  
	/// -or-  
	/// <paramref name="method" /> cannot be bound, for example because it cannot be found.</exception>
	/// <exception cref="T:System.MissingMethodException">The <see langword="Invoke" /> method of <paramref name="type" /> is not found.</exception>
	/// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />.</exception>
	public static Delegate CreateDelegate(Type type, object target, string method)
	{
		return null;
	}

	private static MethodInfo GetCandidateMethod(Type type, Type target, string method, BindingFlags bflags, bool ignoreCase, bool throwOnBindFailure)
	{
		return null;
	}

	/// <summary>Creates a delegate of the specified type that represents the specified static method of the specified class, with the specified case-sensitivity and the specified behavior on failure to bind.</summary>
	/// <param name="type">The <see cref="T:System.Type" /> of delegate to create.</param>
	/// <param name="target">The <see cref="T:System.Type" /> representing the class that implements <paramref name="method" />.</param>
	/// <param name="method">The name of the static method that the delegate is to represent.</param>
	/// <param name="ignoreCase">A Boolean indicating whether to ignore the case when comparing the name of the method.</param>
	/// <param name="throwOnBindFailure">
	///   <see langword="true" /> to throw an exception if <paramref name="method" /> cannot be bound; otherwise, <see langword="false" />.</param>
	/// <returns>A delegate of the specified type that represents the specified static method of the specified class.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="type" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="target" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="method" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />.  
	/// -or-  
	/// <paramref name="type" /> is not a <see langword="RuntimeType" />. See Runtime Types in Reflection.  
	/// -or-  
	/// <paramref name="target" /> is not a <see langword="RuntimeType" />.  
	/// -or-  
	/// <paramref name="target" /> is an open generic type. That is, its <see cref="P:System.Type.ContainsGenericParameters" /> property is <see langword="true" />.  
	/// -or-  
	/// <paramref name="method" /> is not a <see langword="static" /> method (<see langword="Shared" /> method in Visual Basic).  
	/// -or-  
	/// <paramref name="method" /> cannot be bound, for example because it cannot be found, and <paramref name="throwOnBindFailure" /> is <see langword="true" />.</exception>
	/// <exception cref="T:System.MissingMethodException">The <see langword="Invoke" /> method of <paramref name="type" /> is not found.</exception>
	/// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />.</exception>
	public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase, bool throwOnBindFailure)
	{
		return null;
	}

	/// <summary>Creates a delegate of the specified type that represents the specified static method of the specified class.</summary>
	/// <param name="type">The <see cref="T:System.Type" /> of delegate to create.</param>
	/// <param name="target">The <see cref="T:System.Type" /> representing the class that implements <paramref name="method" />.</param>
	/// <param name="method">The name of the static method that the delegate is to represent.</param>
	/// <returns>A delegate of the specified type that represents the specified static method of the specified class.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="type" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="target" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="method" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />.  
	/// -or-  
	/// <paramref name="type" /> is not a <see langword="RuntimeType" />. See Runtime Types in Reflection.  
	/// -or-  
	/// <paramref name="target" /> is not a <see langword="RuntimeType" />.  
	/// -or-  
	/// <paramref name="target" /> is an open generic type. That is, its <see cref="P:System.Type.ContainsGenericParameters" /> property is <see langword="true" />.  
	/// -or-  
	/// <paramref name="method" /> is not a <see langword="static" /> method (<see langword="Shared" /> method in Visual Basic).  
	/// -or-  
	/// <paramref name="method" /> cannot be bound, for example because it cannot be found, and <paramref name="throwOnBindFailure" /> is <see langword="true" />.</exception>
	/// <exception cref="T:System.MissingMethodException">The <see langword="Invoke" /> method of <paramref name="type" /> is not found.</exception>
	/// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />.</exception>
	public static Delegate CreateDelegate(Type type, Type target, string method)
	{
		return null;
	}

	/// <summary>Creates a delegate of the specified type that represents the specified static method of the specified class, with the specified case-sensitivity.</summary>
	/// <param name="type">The <see cref="T:System.Type" /> of delegate to create.</param>
	/// <param name="target">The <see cref="T:System.Type" /> representing the class that implements <paramref name="method" />.</param>
	/// <param name="method">The name of the static method that the delegate is to represent.</param>
	/// <param name="ignoreCase">A Boolean indicating whether to ignore the case when comparing the name of the method.</param>
	/// <returns>A delegate of the specified type that represents the specified static method of the specified class.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="type" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="target" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="method" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />.  
	/// -or-  
	/// <paramref name="type" /> is not a <see langword="RuntimeType" />. See Runtime Types in Reflection.  
	/// -or-  
	/// <paramref name="target" /> is not a <see langword="RuntimeType" />.  
	/// -or-  
	/// <paramref name="target" /> is an open generic type. That is, its <see cref="P:System.Type.ContainsGenericParameters" /> property is <see langword="true" />.  
	/// -or-  
	/// <paramref name="method" /> is not a <see langword="static" /> method (<see langword="Shared" /> method in Visual Basic).  
	/// -or-  
	/// <paramref name="method" /> cannot be bound, for example because it cannot be found.</exception>
	/// <exception cref="T:System.MissingMethodException">The <see langword="Invoke" /> method of <paramref name="type" /> is not found.</exception>
	/// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />.</exception>
	public static Delegate CreateDelegate(Type type, Type target, string method, bool ignoreCase)
	{
		return null;
	}

	/// <summary>Creates a delegate of the specified type that represents the specified instance method to invoke on the specified class instance, with the specified case-sensitivity and the specified behavior on failure to bind.</summary>
	/// <param name="type">The <see cref="T:System.Type" /> of delegate to create.</param>
	/// <param name="target">The class instance on which <paramref name="method" /> is invoked.</param>
	/// <param name="method">The name of the instance method that the delegate is to represent.</param>
	/// <param name="ignoreCase">A Boolean indicating whether to ignore the case when comparing the name of the method.</param>
	/// <param name="throwOnBindFailure">
	///   <see langword="true" /> to throw an exception if <paramref name="method" /> cannot be bound; otherwise, <see langword="false" />.</param>
	/// <returns>A delegate of the specified type that represents the specified instance method to invoke on the specified class instance.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="type" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="target" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="method" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />.  
	/// -or-  
	/// <paramref name="type" /> is not a <see langword="RuntimeType" />. See Runtime Types in Reflection.  
	/// -or-  
	/// <paramref name="method" /> is not an instance method.  
	/// -or-  
	/// <paramref name="method" /> cannot be bound, for example because it cannot be found, and <paramref name="throwOnBindFailure" /> is <see langword="true" />.</exception>
	/// <exception cref="T:System.MissingMethodException">The <see langword="Invoke" /> method of <paramref name="type" /> is not found.</exception>
	/// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />.</exception>
	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase, bool throwOnBindFailure)
	{
		return null;
	}

	/// <summary>Creates a delegate of the specified type that represents the specified instance method to invoke on the specified class instance with the specified case-sensitivity.</summary>
	/// <param name="type">The <see cref="T:System.Type" /> of delegate to create.</param>
	/// <param name="target">The class instance on which <paramref name="method" /> is invoked.</param>
	/// <param name="method">The name of the instance method that the delegate is to represent.</param>
	/// <param name="ignoreCase">A Boolean indicating whether to ignore the case when comparing the name of the method.</param>
	/// <returns>A delegate of the specified type that represents the specified instance method to invoke on the specified class instance.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="type" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="target" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="method" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="type" /> does not inherit <see cref="T:System.MulticastDelegate" />.  
	/// -or-  
	/// <paramref name="type" /> is not a <see langword="RuntimeType" />. See Runtime Types in Reflection.  
	/// -or-  
	/// <paramref name="method" /> is not an instance method.  
	/// -or-  
	/// <paramref name="method" /> cannot be bound, for example because it cannot be found.</exception>
	/// <exception cref="T:System.MissingMethodException">The <see langword="Invoke" /> method of <paramref name="type" /> is not found.</exception>
	/// <exception cref="T:System.MethodAccessException">The caller does not have the permissions necessary to access <paramref name="method" />.</exception>
	public static Delegate CreateDelegate(Type type, object target, string method, bool ignoreCase)
	{
		return null;
	}

	/// <summary>Dynamically invokes (late-bound) the method represented by the current delegate.</summary>
	/// <param name="args">An array of objects that are the arguments to pass to the method represented by the current delegate.  
	///  -or-  
	///  <see langword="null" />, if the method represented by the current delegate does not require arguments.</param>
	/// <returns>The object returned by the method represented by the delegate.</returns>
	/// <exception cref="T:System.MemberAccessException">The caller does not have access to the method represented by the delegate (for example, if the method is private).  
	///  -or-  
	///  The number, order, or type of parameters listed in <paramref name="args" /> is invalid.</exception>
	/// <exception cref="T:System.ArgumentException">The method represented by the delegate is invoked on an object or a class that does not support it.</exception>
	/// <exception cref="T:System.Reflection.TargetInvocationException">The method represented by the delegate is an instance method and the target object is <see langword="null" />.  
	///  -or-  
	///  One of the encapsulated methods throws an exception.</exception>
	public object DynamicInvoke(params object[] args)
	{
		return null;
	}

	private void InitializeDelegateData()
	{
	}

	/// <summary>Dynamically invokes (late-bound) the method represented by the current delegate.</summary>
	/// <param name="args">An array of objects that are the arguments to pass to the method represented by the current delegate.  
	///  -or-  
	///  <see langword="null" />, if the method represented by the current delegate does not require arguments.</param>
	/// <returns>The object returned by the method represented by the delegate.</returns>
	/// <exception cref="T:System.MemberAccessException">The caller does not have access to the method represented by the delegate (for example, if the method is private).  
	///  -or-  
	///  The number, order, or type of parameters listed in <paramref name="args" /> is invalid.</exception>
	/// <exception cref="T:System.ArgumentException">The method represented by the delegate is invoked on an object or a class that does not support it.</exception>
	/// <exception cref="T:System.Reflection.TargetInvocationException">The method represented by the delegate is an instance method and the target object is <see langword="null" />.  
	///  -or-  
	///  One of the encapsulated methods throws an exception.</exception>
	protected virtual object DynamicInvokeImpl(object[] args)
	{
		return null;
	}

	/// <summary>Creates a shallow copy of the delegate.</summary>
	/// <returns>A shallow copy of the delegate.</returns>
	public virtual object Clone()
	{
		return null;
	}

	/// <summary>Determines whether the specified object and the current delegate are of the same type and share the same targets, methods, and invocation list.</summary>
	/// <param name="obj">The object to compare with the current delegate.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="obj" /> and the current delegate have the same targets, methods, and invocation list; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.MemberAccessException">The caller does not have access to the method represented by the delegate (for example, if the method is private).</exception>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Returns a hash code for the delegate.</summary>
	/// <returns>A hash code for the delegate.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Gets the static method represented by the current delegate.</summary>
	/// <returns>A <see cref="T:System.Reflection.MethodInfo" /> describing the static method represented by the current delegate.</returns>
	/// <exception cref="T:System.MemberAccessException">The caller does not have access to the method represented by the delegate (for example, if the method is private).</exception>
	protected virtual MethodInfo GetMethodImpl()
	{
		return null;
	}

	/// <summary>Not supported.</summary>
	/// <param name="info">Not supported.</param>
	/// <param name="context">Not supported.</param>
	/// <exception cref="T:System.NotSupportedException">This method is not supported.</exception>
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Returns the invocation list of the delegate.</summary>
	/// <returns>An array of delegates representing the invocation list of the current delegate.</returns>
	public virtual Delegate[] GetInvocationList()
	{
		return null;
	}

	/// <summary>Concatenates the invocation lists of two delegates.</summary>
	/// <param name="a">The delegate whose invocation list comes first.</param>
	/// <param name="b">The delegate whose invocation list comes last.</param>
	/// <returns>A new delegate with an invocation list that concatenates the invocation lists of <paramref name="a" /> and <paramref name="b" /> in that order. Returns <paramref name="a" /> if <paramref name="b" /> is <see langword="null" />, returns <paramref name="b" /> if <paramref name="a" /> is a null reference, and returns a null reference if both <paramref name="a" /> and <paramref name="b" /> are null references.</returns>
	/// <exception cref="T:System.ArgumentException">Both <paramref name="a" /> and <paramref name="b" /> are not <see langword="null" />, and <paramref name="a" /> and <paramref name="b" /> are not instances of the same delegate type.</exception>
	public static Delegate Combine(Delegate a, Delegate b)
	{
		return null;
	}

	/// <summary>Concatenates the invocation lists of an array of delegates.</summary>
	/// <param name="delegates">The array of delegates to combine.</param>
	/// <returns>A new delegate with an invocation list that concatenates the invocation lists of the delegates in the <paramref name="delegates" /> array. Returns <see langword="null" /> if <paramref name="delegates" /> is <see langword="null" />, if <paramref name="delegates" /> contains zero elements, or if every entry in <paramref name="delegates" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.ArgumentException">Not all the non-null entries in <paramref name="delegates" /> are instances of the same delegate type.</exception>
	[ComVisible(true)]
	public static Delegate Combine(params Delegate[] delegates)
	{
		return null;
	}

	/// <summary>Concatenates the invocation lists of the specified multicast (combinable) delegate and the current multicast (combinable) delegate.</summary>
	/// <param name="d">The multicast (combinable) delegate whose invocation list to append to the end of the invocation list of the current multicast (combinable) delegate.</param>
	/// <returns>A new multicast (combinable) delegate with an invocation list that concatenates the invocation list of the current multicast (combinable) delegate and the invocation list of <paramref name="d" />, or the current multicast (combinable) delegate if <paramref name="d" /> is <see langword="null" />.</returns>
	/// <exception cref="T:System.MulticastNotSupportedException">Always thrown.</exception>
	protected virtual Delegate CombineImpl(Delegate d)
	{
		return null;
	}

	/// <summary>Removes the last occurrence of the invocation list of a delegate from the invocation list of another delegate.</summary>
	/// <param name="source">The delegate from which to remove the invocation list of <paramref name="value" />.</param>
	/// <param name="value">The delegate that supplies the invocation list to remove from the invocation list of <paramref name="source" />.</param>
	/// <returns>A new delegate with an invocation list formed by taking the invocation list of <paramref name="source" /> and removing the last occurrence of the invocation list of <paramref name="value" />, if the invocation list of <paramref name="value" /> is found within the invocation list of <paramref name="source" />. Returns <paramref name="source" /> if <paramref name="value" /> is <see langword="null" /> or if the invocation list of <paramref name="value" /> is not found within the invocation list of <paramref name="source" />. Returns a null reference if the invocation list of <paramref name="value" /> is equal to the invocation list of <paramref name="source" /> or if <paramref name="source" /> is a null reference.</returns>
	/// <exception cref="T:System.MemberAccessException">The caller does not have access to the method represented by the delegate (for example, if the method is private).</exception>
	/// <exception cref="T:System.ArgumentException">The delegate types do not match.</exception>
	public static Delegate Remove(Delegate source, Delegate value)
	{
		return null;
	}

	/// <summary>Removes the invocation list of a delegate from the invocation list of another delegate.</summary>
	/// <param name="d">The delegate that supplies the invocation list to remove from the invocation list of the current delegate.</param>
	/// <returns>A new delegate with an invocation list formed by taking the invocation list of the current delegate and removing the invocation list of <paramref name="value" />, if the invocation list of <paramref name="value" /> is found within the current delegate's invocation list. Returns the current delegate if <paramref name="value" /> is <see langword="null" /> or if the invocation list of <paramref name="value" /> is not found within the current delegate's invocation list. Returns <see langword="null" /> if the invocation list of <paramref name="value" /> is equal to the current delegate's invocation list.</returns>
	/// <exception cref="T:System.MemberAccessException">The caller does not have access to the method represented by the delegate (for example, if the method is private).</exception>
	protected virtual Delegate RemoveImpl(Delegate d)
	{
		return null;
	}

	/// <summary>Determines whether the specified delegates are equal.</summary>
	/// <param name="d1">The first delegate to compare.</param>
	/// <param name="d2">The second delegate to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="d1" /> is equal to <paramref name="d2" />; otherwise, <see langword="false" />.</returns>
	public static bool operator ==(Delegate d1, Delegate d2)
	{
		return false;
	}

	/// <summary>Determines whether the specified delegates are not equal.</summary>
	/// <param name="d1">The first delegate to compare.</param>
	/// <param name="d2">The second delegate to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="d1" /> is not equal to <paramref name="d2" />; otherwise, <see langword="false" />.</returns>
	public static bool operator !=(Delegate d1, Delegate d2)
	{
		return false;
	}

	internal static MulticastDelegate AllocDelegateLike_internal(Delegate d)
	{
		return null;
	}
}
