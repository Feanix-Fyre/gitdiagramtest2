using System.Reflection;

namespace System;

/// <summary>Represents the base class for custom attributes.</summary>
[Serializable]
[AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
public abstract class Attribute
{
	/// <summary>When implemented in a derived class, gets a unique identifier for this <see cref="T:System.Attribute" />.</summary>
	/// <returns>An <see cref="T:System.Object" /> that is a unique identifier for the attribute.</returns>
	public virtual object TypeId => null;

	private static Attribute[] InternalGetCustomAttributes(PropertyInfo element, Type type, bool inherit)
	{
		return null;
	}

	private static Attribute[] InternalGetCustomAttributes(EventInfo element, Type type, bool inherit)
	{
		return null;
	}

	private static Attribute[] InternalParamGetCustomAttributes(ParameterInfo parameter, Type attributeType, bool inherit)
	{
		return null;
	}

	private static bool InternalIsDefined(PropertyInfo element, Type attributeType, bool inherit)
	{
		return false;
	}

	private static bool InternalIsDefined(EventInfo element, Type attributeType, bool inherit)
	{
		return false;
	}

	/// <summary>Retrieves an array of the custom attributes applied to a member of a type. Parameters specify the member, and the type of the custom attribute to search for.</summary>
	/// <param name="element">An object derived from the <see cref="T:System.Reflection.MemberInfo" /> class that describes a constructor, event, field, method, or property member of a class.</param>
	/// <param name="type">The type, or a base type, of the custom attribute to search for.</param>
	/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes of type <paramref name="type" /> applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="element" /> or <paramref name="type" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="type" /> is not derived from <see cref="T:System.Attribute" />.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="element" /> is not a constructor, method, property, event, type, or field.</exception>
	/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded.</exception>
	public static Attribute[] GetCustomAttributes(MemberInfo element, Type type)
	{
		return null;
	}

	/// <summary>Retrieves an array of the custom attributes applied to a member of a type. Parameters specify the member, the type of the custom attribute to search for, and whether to search ancestors of the member.</summary>
	/// <param name="element">An object derived from the <see cref="T:System.Reflection.MemberInfo" /> class that describes a constructor, event, field, method, or property member of a class.</param>
	/// <param name="type">The type, or a base type, of the custom attribute to search for.</param>
	/// <param name="inherit">If <see langword="true" />, specifies to also search the ancestors of <paramref name="element" /> for custom attributes.</param>
	/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes of type <paramref name="type" /> applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="element" /> or <paramref name="type" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="type" /> is not derived from <see cref="T:System.Attribute" />.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="element" /> is not a constructor, method, property, event, type, or field.</exception>
	/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded.</exception>
	public static Attribute[] GetCustomAttributes(MemberInfo element, Type type, bool inherit)
	{
		return null;
	}

	/// <summary>Retrieves an array of the custom attributes applied to a member of a type. A parameter specifies the member.</summary>
	/// <param name="element">An object derived from the <see cref="T:System.Reflection.MemberInfo" /> class that describes a constructor, event, field, method, or property member of a class.</param>
	/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="element" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="element" /> is not a constructor, method, property, event, type, or field.</exception>
	/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded.</exception>
	public static Attribute[] GetCustomAttributes(MemberInfo element)
	{
		return null;
	}

	/// <summary>Retrieves an array of the custom attributes applied to a member of a type. Parameters specify the member, the type of the custom attribute to search for, and whether to search ancestors of the member.</summary>
	/// <param name="element">An object derived from the <see cref="T:System.Reflection.MemberInfo" /> class that describes a constructor, event, field, method, or property member of a class.</param>
	/// <param name="inherit">If <see langword="true" />, specifies to also search the ancestors of <paramref name="element" /> for custom attributes.</param>
	/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="element" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="element" /> is not a constructor, method, property, event, type, or field.</exception>
	/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded.</exception>
	public static Attribute[] GetCustomAttributes(MemberInfo element, bool inherit)
	{
		return null;
	}

	/// <summary>Determines whether any custom attributes are applied to a member of a type. Parameters specify the member, and the type of the custom attribute to search for.</summary>
	/// <param name="element">An object derived from the <see cref="T:System.Reflection.MemberInfo" /> class that describes a constructor, event, field, method, type, or property member of a class.</param>
	/// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
	/// <returns>
	///   <see langword="true" /> if a custom attribute of type <paramref name="attributeType" /> is applied to <paramref name="element" />; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="element" /> or <paramref name="attributeType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="element" /> is not a constructor, method, property, event, type, or field.</exception>
	public static bool IsDefined(MemberInfo element, Type attributeType)
	{
		return false;
	}

	/// <summary>Determines whether any custom attributes are applied to a member of a type. Parameters specify the member, the type of the custom attribute to search for, and whether to search ancestors of the member.</summary>
	/// <param name="element">An object derived from the <see cref="T:System.Reflection.MemberInfo" /> class that describes a constructor, event, field, method, type, or property member of a class.</param>
	/// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
	/// <param name="inherit">If <see langword="true" />, specifies to also search the ancestors of <paramref name="element" /> for custom attributes.</param>
	/// <returns>
	///   <see langword="true" /> if a custom attribute of type <paramref name="attributeType" /> is applied to <paramref name="element" />; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="element" /> or <paramref name="attributeType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="element" /> is not a constructor, method, property, event, type, or field.</exception>
	public static bool IsDefined(MemberInfo element, Type attributeType, bool inherit)
	{
		return false;
	}

	/// <summary>Retrieves a custom attribute applied to a member of a type. Parameters specify the member, and the type of the custom attribute to search for.</summary>
	/// <param name="element">An object derived from the <see cref="T:System.Reflection.MemberInfo" /> class that describes a constructor, event, field, method, or property member of a class.</param>
	/// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
	/// <returns>A reference to the single custom attribute of type <paramref name="attributeType" /> that is applied to <paramref name="element" />, or <see langword="null" /> if there is no such attribute.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="element" /> or <paramref name="attributeType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="element" /> is not a constructor, method, property, event, type, or field.</exception>
	/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one of the requested attributes was found.</exception>
	/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded.</exception>
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType)
	{
		return null;
	}

	/// <summary>Retrieves a custom attribute applied to a member of a type. Parameters specify the member, the type of the custom attribute to search for, and whether to search ancestors of the member.</summary>
	/// <param name="element">An object derived from the <see cref="T:System.Reflection.MemberInfo" /> class that describes a constructor, event, field, method, or property member of a class.</param>
	/// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
	/// <param name="inherit">If <see langword="true" />, specifies to also search the ancestors of <paramref name="element" /> for custom attributes.</param>
	/// <returns>A reference to the single custom attribute of type <paramref name="attributeType" /> that is applied to <paramref name="element" />, or <see langword="null" /> if there is no such attribute.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="element" /> or <paramref name="attributeType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="element" /> is not a constructor, method, property, event, type, or field.</exception>
	/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one of the requested attributes was found.</exception>
	/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded.</exception>
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType, bool inherit)
	{
		return null;
	}

	/// <summary>Retrieves an array of the custom attributes applied to a method parameter. Parameters specify the method parameter, the type of the custom attribute to search for, and whether to search ancestors of the method parameter.</summary>
	/// <param name="element">An object derived from the <see cref="T:System.Reflection.ParameterInfo" /> class that describes a parameter of a member of a class.</param>
	/// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
	/// <param name="inherit">If <see langword="true" />, specifies to also search the ancestors of <paramref name="element" /> for custom attributes.</param>
	/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes of type <paramref name="attributeType" /> applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="element" /> or <paramref name="attributeType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />.</exception>
	/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded.</exception>
	public static Attribute[] GetCustomAttributes(ParameterInfo element, Type attributeType, bool inherit)
	{
		return null;
	}

	/// <summary>Retrieves an array of the custom attributes applied to a method parameter. Parameters specify the method parameter, and whether to search ancestors of the method parameter.</summary>
	/// <param name="element">An object derived from the <see cref="T:System.Reflection.ParameterInfo" /> class that describes a parameter of a member of a class.</param>
	/// <param name="inherit">If <see langword="true" />, specifies to also search the ancestors of <paramref name="element" /> for custom attributes.</param>
	/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
	/// <exception cref="T:System.ArgumentException">The <see cref="P:System.Reflection.ParameterInfo.Member" /> property of <paramref name="element" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="element" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded.</exception>
	public static Attribute[] GetCustomAttributes(ParameterInfo element, bool inherit)
	{
		return null;
	}

	/// <summary>Retrieves an array of the custom attributes applied to a module. Parameters specify the module, and an ignored search option.</summary>
	/// <param name="element">An object derived from the <see cref="T:System.Reflection.Module" /> class that describes a portable executable file.</param>
	/// <param name="inherit">This parameter is ignored, and does not affect the operation of this method.</param>
	/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="element" /> or <paramref name="attributeType" /> is <see langword="null" />.</exception>
	public static Attribute[] GetCustomAttributes(Module element, bool inherit)
	{
		return null;
	}

	/// <summary>Retrieves an array of the custom attributes applied to a module. Parameters specify the module, the type of the custom attribute to search for, and an ignored search option.</summary>
	/// <param name="element">An object derived from the <see cref="T:System.Reflection.Module" /> class that describes a portable executable file.</param>
	/// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
	/// <param name="inherit">This parameter is ignored, and does not affect the operation of this method.</param>
	/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes of type <paramref name="attributeType" /> applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="element" /> or <paramref name="attributeType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />.</exception>
	public static Attribute[] GetCustomAttributes(Module element, Type attributeType, bool inherit)
	{
		return null;
	}

	/// <summary>Retrieves an array of the custom attributes applied to an assembly. Parameters specify the assembly, and the type of the custom attribute to search for.</summary>
	/// <param name="element">An object derived from the <see cref="T:System.Reflection.Assembly" /> class that describes a reusable collection of modules.</param>
	/// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
	/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes of type <paramref name="attributeType" /> applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="element" /> or <paramref name="attributeType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />.</exception>
	public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType)
	{
		return null;
	}

	/// <summary>Retrieves an array of the custom attributes applied to an assembly. Parameters specify the assembly, the type of the custom attribute to search for, and an ignored search option.</summary>
	/// <param name="element">An object derived from the <see cref="T:System.Reflection.Assembly" /> class that describes a reusable collection of modules.</param>
	/// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
	/// <param name="inherit">This parameter is ignored, and does not affect the operation of this method.</param>
	/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes of type <paramref name="attributeType" /> applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="element" /> or <paramref name="attributeType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />.</exception>
	public static Attribute[] GetCustomAttributes(Assembly element, Type attributeType, bool inherit)
	{
		return null;
	}

	/// <summary>Retrieves an array of the custom attributes applied to an assembly. A parameter specifies the assembly.</summary>
	/// <param name="element">An object derived from the <see cref="T:System.Reflection.Assembly" /> class that describes a reusable collection of modules.</param>
	/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="element" /> is <see langword="null" />.</exception>
	public static Attribute[] GetCustomAttributes(Assembly element)
	{
		return null;
	}

	/// <summary>Retrieves an array of the custom attributes applied to an assembly. Parameters specify the assembly, and an ignored search option.</summary>
	/// <param name="element">An object derived from the <see cref="T:System.Reflection.Assembly" /> class that describes a reusable collection of modules.</param>
	/// <param name="inherit">This parameter is ignored, and does not affect the operation of this method.</param>
	/// <returns>An <see cref="T:System.Attribute" /> array that contains the custom attributes applied to <paramref name="element" />, or an empty array if no such custom attributes exist.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="element" /> or <paramref name="attributeType" /> is <see langword="null" />.</exception>
	public static Attribute[] GetCustomAttributes(Assembly element, bool inherit)
	{
		return null;
	}

	/// <summary>Retrieves a custom attribute applied to a specified assembly. Parameters specify the assembly and the type of the custom attribute to search for.</summary>
	/// <param name="element">An object derived from the <see cref="T:System.Reflection.Assembly" /> class that describes a reusable collection of modules.</param>
	/// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
	/// <returns>A reference to the single custom attribute of type <paramref name="attributeType" /> that is applied to <paramref name="element" />, or <see langword="null" /> if there is no such attribute.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="element" /> or <paramref name="attributeType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />.</exception>
	/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one of the requested attributes was found.</exception>
	public static Attribute GetCustomAttribute(Assembly element, Type attributeType)
	{
		return null;
	}

	/// <summary>Retrieves a custom attribute applied to an assembly. Parameters specify the assembly, the type of the custom attribute to search for, and an ignored search option.</summary>
	/// <param name="element">An object derived from the <see cref="T:System.Reflection.Assembly" /> class that describes a reusable collection of modules.</param>
	/// <param name="attributeType">The type, or a base type, of the custom attribute to search for.</param>
	/// <param name="inherit">This parameter is ignored, and does not affect the operation of this method.</param>
	/// <returns>A reference to the single custom attribute of type <paramref name="attributeType" /> that is applied to <paramref name="element" />, or <see langword="null" /> if there is no such attribute.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="element" /> or <paramref name="attributeType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />.</exception>
	/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one of the requested attributes was found.</exception>
	public static Attribute GetCustomAttribute(Assembly element, Type attributeType, bool inherit)
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Attribute" /> class.</summary>
	protected Attribute()
	{
	}

	/// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
	/// <param name="obj">An <see cref="T:System.Object" /> to compare with this instance or <see langword="null" />.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="obj" /> and this instance are of the same type and have identical field values; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	private static bool AreFieldValuesEqual(object thisValue, object thatValue)
	{
		return false;
	}

	/// <summary>Returns the hash code for this instance.</summary>
	/// <returns>A 32-bit signed integer hash code.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>When overridden in a derived class, returns a value that indicates whether this instance equals a specified object.</summary>
	/// <param name="obj">An <see cref="T:System.Object" /> to compare with this instance of <see cref="T:System.Attribute" />.</param>
	/// <returns>
	///   <see langword="true" /> if this instance equals <paramref name="obj" />; otherwise, <see langword="false" />.</returns>
	public virtual bool Match(object obj)
	{
		return false;
	}

	/// <summary>When overridden in a derived class, indicates whether the value of this instance is the default value for the derived class.</summary>
	/// <returns>
	///   <see langword="true" /> if this instance is the default attribute for the class; otherwise, <see langword="false" />.</returns>
	public virtual bool IsDefaultAttribute()
	{
		return false;
	}
}
