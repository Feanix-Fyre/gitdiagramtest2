namespace System.Reflection;

/// <summary>Discovers the attributes of a method and provides access to method metadata.</summary>
[Serializable]
public abstract class MethodInfo : MethodBase
{
	/// <summary>Gets a <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is a method.</summary>
	/// <returns>A <see cref="T:System.Reflection.MemberTypes" /> value indicating that this member is a method.</returns>
	public override MemberTypes MemberType => default(MemberTypes);

	/// <summary>Gets a <see cref="T:System.Reflection.ParameterInfo" /> object that contains information about the return type of the method, such as whether the return type has custom modifiers.</summary>
	/// <returns>A <see cref="T:System.Reflection.ParameterInfo" /> object that contains information about the return type.</returns>
	/// <exception cref="T:System.NotImplementedException">This method is not implemented.</exception>
	public virtual ParameterInfo ReturnParameter => null;

	/// <summary>Gets the return type of this method.</summary>
	/// <returns>The return type of this method.</returns>
	public virtual Type ReturnType => null;

	internal virtual int GenericParameterCount => 0;

	/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.MethodInfo" /> class.</summary>
	protected MethodInfo()
	{
	}

	/// <summary>Returns an array of <see cref="T:System.Type" /> objects that represent the type arguments of a generic method or the type parameters of a generic method definition.</summary>
	/// <returns>An array of <see cref="T:System.Type" /> objects that represent the type arguments of a generic method or the type parameters of a generic method definition. Returns an empty array if the current method is not a generic method.</returns>
	/// <exception cref="T:System.NotSupportedException">This method is not supported.</exception>
	public override Type[] GetGenericArguments()
	{
		return null;
	}

	/// <summary>Returns a <see cref="T:System.Reflection.MethodInfo" /> object that represents a generic method definition from which the current method can be constructed.</summary>
	/// <returns>A <see cref="T:System.Reflection.MethodInfo" /> object representing a generic method definition from which the current method can be constructed.</returns>
	/// <exception cref="T:System.InvalidOperationException">The current method is not a generic method. That is, <see cref="P:System.Reflection.MethodBase.IsGenericMethod" /> returns <see langword="false" />.</exception>
	/// <exception cref="T:System.NotSupportedException">This method is not supported.</exception>
	public virtual MethodInfo GetGenericMethodDefinition()
	{
		return null;
	}

	/// <summary>Substitutes the elements of an array of types for the type parameters of the current generic method definition, and returns a <see cref="T:System.Reflection.MethodInfo" /> object representing the resulting constructed method.</summary>
	/// <param name="typeArguments">An array of types to be substituted for the type parameters of the current generic method definition.</param>
	/// <returns>A <see cref="T:System.Reflection.MethodInfo" /> object that represents the constructed method formed by substituting the elements of <paramref name="typeArguments" /> for the type parameters of the current generic method definition.</returns>
	/// <exception cref="T:System.InvalidOperationException">The current <see cref="T:System.Reflection.MethodInfo" /> does not represent a generic method definition. That is, <see cref="P:System.Reflection.MethodBase.IsGenericMethodDefinition" /> returns <see langword="false" />.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="typeArguments" /> is <see langword="null" />.  
	/// -or-  
	/// Any element of <paramref name="typeArguments" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The number of elements in <paramref name="typeArguments" /> is not the same as the number of type parameters of the current generic method definition.  
	///  -or-  
	///  An element of <paramref name="typeArguments" /> does not satisfy the constraints specified for the corresponding type parameter of the current generic method definition.</exception>
	/// <exception cref="T:System.NotSupportedException">This method is not supported.</exception>
	public virtual MethodInfo MakeGenericMethod(params Type[] typeArguments)
	{
		return null;
	}

	/// <summary>When overridden in a derived class, returns the <see cref="T:System.Reflection.MethodInfo" /> object for the method on the direct or indirect base class in which the method represented by this instance was first declared.</summary>
	/// <returns>A <see cref="T:System.Reflection.MethodInfo" /> object for the first implementation of this method.</returns>
	public abstract MethodInfo GetBaseDefinition();

	/// <summary>Creates a delegate of the specified type from this method.</summary>
	/// <param name="delegateType">The type of the delegate to create.</param>
	/// <returns>The delegate for this method.</returns>
	public virtual Delegate CreateDelegate(Type delegateType)
	{
		return null;
	}

	/// <summary>Creates a delegate of the specified type with the specified target from this method.</summary>
	/// <param name="delegateType">The type of the delegate to create.</param>
	/// <param name="target">The object targeted by the delegate.</param>
	/// <returns>The delegate for this method.</returns>
	public virtual Delegate CreateDelegate(Type delegateType, object target)
	{
		return null;
	}

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

	/// <summary>Indicates whether two <see cref="T:System.Reflection.MethodInfo" /> objects are equal.</summary>
	/// <param name="left">The first object to compare.</param>
	/// <param name="right">The second object to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="left" /> is equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
	public static bool operator ==(MethodInfo left, MethodInfo right)
	{
		return false;
	}

	/// <summary>Indicates whether two <see cref="T:System.Reflection.MethodInfo" /> objects are not equal.</summary>
	/// <param name="left">The first object to compare.</param>
	/// <param name="right">The second object to compare.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="left" /> is not equal to <paramref name="right" />; otherwise, <see langword="false" />.</returns>
	public static bool operator !=(MethodInfo left, MethodInfo right)
	{
		return false;
	}
}
