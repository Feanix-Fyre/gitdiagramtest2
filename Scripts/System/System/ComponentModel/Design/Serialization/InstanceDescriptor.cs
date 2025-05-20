using System.Collections;
using System.Reflection;

namespace System.ComponentModel.Design.Serialization;

/// <summary>Provides the information necessary to create an instance of an object. This class cannot be inherited.</summary>
public sealed class InstanceDescriptor
{
	/// <summary>Gets the collection of arguments that can be used to reconstruct an instance of the object that this instance descriptor represents.</summary>
	/// <returns>An <see cref="T:System.Collections.ICollection" /> of arguments that can be used to create the object.</returns>
	public ICollection Arguments { get; }

	/// <summary>Gets the member information that describes the instance this descriptor is associated with.</summary>
	/// <returns>A <see cref="T:System.Reflection.MemberInfo" /> that describes the instance that this object is associated with.</returns>
	public MemberInfo MemberInfo { get; }

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.Serialization.InstanceDescriptor" /> class using the specified member information and arguments.</summary>
	/// <param name="member">The member information for the descriptor. This can be a <see cref="T:System.Reflection.MethodInfo" />, <see cref="T:System.Reflection.ConstructorInfo" />, <see cref="T:System.Reflection.FieldInfo" />, or <see cref="T:System.Reflection.PropertyInfo" />. If this is a <see cref="T:System.Reflection.MethodInfo" />, <see cref="T:System.Reflection.FieldInfo" />, or <see cref="T:System.Reflection.PropertyInfo" />, it must represent a <see langword="static" /> member.</param>
	/// <param name="arguments">The collection of arguments to pass to the member. This parameter can be <see langword="null" /> or an empty collection if there are no arguments. The collection can also consist of other instances of <see cref="T:System.ComponentModel.Design.Serialization.InstanceDescriptor" />.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="member" /> is of type <see cref="T:System.Reflection.MethodInfo" />, <see cref="T:System.Reflection.FieldInfo" />, or <see cref="T:System.Reflection.PropertyInfo" />, and it does not represent a <see langword="static" /> member.  
	/// -or-
	/// <paramref name="member" /> is of type <see cref="T:System.Reflection.PropertyInfo" /> and is not readable.  
	/// -or-
	/// <paramref name="member" /> is of type <see cref="T:System.Reflection.MethodInfo" /> or <see cref="T:System.Reflection.ConstructorInfo" />, and the number of arguments in <paramref name="arguments" /> does not match the signature of <paramref name="member" />.
	/// -or-
	/// <paramref name="member" /> is of type <see cref="T:System.Reflection.ConstructorInfo" /> and represents a <see langword="static" /> member.  
	/// -or-
	/// <paramref name="member" /> is of type <see cref="T:System.Reflection.FieldInfo" />, and the number of arguments in <paramref name="arguments" /> is not zero.</exception>
	public InstanceDescriptor(MemberInfo member, ICollection arguments)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.Serialization.InstanceDescriptor" /> class using the specified member information, arguments, and value indicating whether the specified information completely describes the instance.</summary>
	/// <param name="member">The member information for the descriptor. This can be a <see cref="T:System.Reflection.MethodInfo" />, <see cref="T:System.Reflection.ConstructorInfo" />, <see cref="T:System.Reflection.FieldInfo" />, or <see cref="T:System.Reflection.PropertyInfo" />. If this is a <see cref="T:System.Reflection.MethodInfo" />, <see cref="T:System.Reflection.FieldInfo" />, or <see cref="T:System.Reflection.PropertyInfo" />, it must represent a <see langword="static" /> member.</param>
	/// <param name="arguments">The collection of arguments to pass to the member. This parameter can be <see langword="null" /> or an empty collection if there are no arguments. The collection can also consist of other instances of <see cref="T:System.ComponentModel.Design.Serialization.InstanceDescriptor" />.</param>
	/// <param name="isComplete">
	///   <see langword="true" /> if the specified information completely describes the instance; otherwise, <see langword="false" />.</param>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="member" /> is of type <see cref="T:System.Reflection.MethodInfo" />, <see cref="T:System.Reflection.FieldInfo" />, or <see cref="T:System.Reflection.PropertyInfo" />, and it does not represent a <see langword="static" /> member  
	/// <paramref name="member" /> is of type <see cref="T:System.Reflection.PropertyInfo" /> and is not readable.  
	/// <paramref name="member" /> is of type <see cref="T:System.Reflection.MethodInfo" /> or <see cref="T:System.Reflection.ConstructorInfo" /> and the number of arguments in <paramref name="arguments" /> does not match the signature of <paramref name="member" />.  
	/// <paramref name="member" /> is of type <see cref="T:System.Reflection.ConstructorInfo" /> and represents a <see langword="static" /> member  
	/// <paramref name="member" /> is of type <see cref="T:System.Reflection.FieldInfo" />, and the number of arguments in <paramref name="arguments" /> is not zero.</exception>
	public InstanceDescriptor(MemberInfo member, ICollection arguments, bool isComplete)
	{
	}

	/// <summary>Invokes this instance descriptor and returns the object the descriptor describes.</summary>
	/// <returns>The object this instance descriptor describes.</returns>
	public object Invoke()
	{
		return null;
	}
}
