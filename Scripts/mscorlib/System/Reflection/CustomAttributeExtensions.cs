using System.Collections.Generic;

namespace System.Reflection;

/// <summary>Contains static methods for retrieving custom attributes.</summary>
public static class CustomAttributeExtensions
{
	/// <summary>Retrieves a custom attribute of a specified type that is applied to a specified assembly.</summary>
	/// <param name="element">The assembly to inspect.</param>
	/// <param name="attributeType">The type of attribute to search for.</param>
	/// <returns>A custom attribute that matches <paramref name="attributeType" />, or <see langword="null" /> if no such attribute is found.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="element" /> or <paramref name="attributeType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />.</exception>
	/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one of the requested attributes was found.</exception>
	public static Attribute GetCustomAttribute(this Assembly element, Type attributeType)
	{
		return null;
	}

	/// <summary>Retrieves a custom attribute of a specified type that is applied to a specified member.</summary>
	/// <param name="element">The member to inspect.</param>
	/// <param name="attributeType">The type of attribute to search for.</param>
	/// <returns>A custom attribute that matches <paramref name="attributeType" />, or <see langword="null" /> if no such attribute is found.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="element" /> or <paramref name="attributeType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="element" /> is not a constructor, method, property, event, type, or field.</exception>
	/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one of the requested attributes was found.</exception>
	/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded.</exception>
	public static Attribute GetCustomAttribute(this MemberInfo element, Type attributeType)
	{
		return null;
	}

	/// <summary>Retrieves a custom attribute of a specified type that is applied to a specified assembly.</summary>
	/// <param name="element">The assembly to inspect.</param>
	/// <typeparam name="T">The type of attribute to search for.</typeparam>
	/// <returns>A custom attribute that matches <paramref name="T" />, or <see langword="null" /> if no such attribute is found.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="element" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one of the requested attributes was found.</exception>
	public static T GetCustomAttribute<T>(this Assembly element) where T : Attribute
	{
		return null;
	}

	/// <summary>Retrieves a custom attribute of a specified type that is applied to a specified member.</summary>
	/// <param name="element">The member to inspect.</param>
	/// <typeparam name="T">The type of attribute to search for.</typeparam>
	/// <returns>A custom attribute that matches <paramref name="T" />, or <see langword="null" /> if no such attribute is found.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="element" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="element" /> is not a constructor, method, property, event, type, or field.</exception>
	/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one of the requested attributes was found.</exception>
	/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded.</exception>
	public static T GetCustomAttribute<T>(this MemberInfo element) where T : Attribute
	{
		return null;
	}

	/// <summary>Retrieves a custom attribute of a specified type that is applied to a specified member, and optionally inspects the ancestors of that member.</summary>
	/// <param name="element">The member to inspect.</param>
	/// <param name="attributeType">The type of attribute to search for.</param>
	/// <param name="inherit">
	///   <see langword="true" /> to inspect the ancestors of <paramref name="element" />; otherwise, <see langword="false" />.</param>
	/// <returns>A custom attribute that matches <paramref name="attributeType" />, or <see langword="null" /> if no such attribute is found.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="element" /> or <paramref name="attributeType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="element" /> is not a constructor, method, property, event, type, or field.</exception>
	/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one of the requested attributes was found.</exception>
	/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded.</exception>
	public static Attribute GetCustomAttribute(this MemberInfo element, Type attributeType, bool inherit)
	{
		return null;
	}

	/// <summary>Retrieves a custom attribute of a specified type that is applied to a specified member, and optionally inspects the ancestors of that member.</summary>
	/// <param name="element">The member to inspect.</param>
	/// <param name="inherit">
	///   <see langword="true" /> to inspect the ancestors of <paramref name="element" />; otherwise, <see langword="false" />.</param>
	/// <typeparam name="T">The type of attribute to search for.</typeparam>
	/// <returns>A custom attribute that matches <paramref name="T" />, or <see langword="null" /> if no such attribute is found.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="element" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="element" /> is not a constructor, method, property, event, type, or field.</exception>
	/// <exception cref="T:System.Reflection.AmbiguousMatchException">More than one of the requested attributes was found.</exception>
	/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded.</exception>
	public static T GetCustomAttribute<T>(this MemberInfo element, bool inherit) where T : Attribute
	{
		return null;
	}

	/// <summary>Retrieves a collection of custom attributes that are applied to a specified assembly.</summary>
	/// <param name="element">The assembly to inspect.</param>
	/// <returns>A collection of the custom attributes that are applied to <paramref name="element" />, or an empty collection if no such attributes exist.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="element" /> is <see langword="null" />.</exception>
	public static IEnumerable<Attribute> GetCustomAttributes(this Assembly element)
	{
		return null;
	}

	/// <summary>Retrieves a collection of custom attributes that are applied to a specified member.</summary>
	/// <param name="element">The member to inspect.</param>
	/// <returns>A collection of the custom attributes that are applied to <paramref name="element" />, or an empty collection if no such attributes exist.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="element" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="element" /> is not a constructor, method, property, event, type, or field.</exception>
	/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded.</exception>
	public static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element)
	{
		return null;
	}

	/// <summary>Retrieves a collection of custom attributes of a specified type that are applied to a specified member.</summary>
	/// <param name="element">The member to inspect.</param>
	/// <param name="attributeType">The type of attribute to search for.</param>
	/// <returns>A collection of the custom attributes that are applied to <paramref name="element" /> and that match <paramref name="attributeType" />, or an empty collection if no such attributes exist.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="element" /> or <paramref name="attributeType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="element" /> is not a constructor, method, property, event, type, or field.</exception>
	/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded.</exception>
	public static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element, Type attributeType)
	{
		return null;
	}

	/// <summary>Retrieves a collection of custom attributes of a specified type that are applied to a specified member.</summary>
	/// <param name="element">The member to inspect.</param>
	/// <typeparam name="T">The type of attribute to search for.</typeparam>
	/// <returns>A collection of the custom attributes that are applied to <paramref name="element" /> and that match <paramref name="T" />, or an empty collection if no such attributes exist.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="element" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="element" /> is not a constructor, method, property, event, type, or field.</exception>
	/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded.</exception>
	public static IEnumerable<T> GetCustomAttributes<T>(this MemberInfo element) where T : Attribute
	{
		return null;
	}

	/// <summary>Retrieves a collection of custom attributes of a specified type that are applied to a specified member, and optionally inspects the ancestors of that member.</summary>
	/// <param name="element">The member to inspect.</param>
	/// <param name="attributeType">The type of attribute to search for.</param>
	/// <param name="inherit">
	///   <see langword="true" /> to inspect the ancestors of <paramref name="element" />; otherwise, <see langword="false" />.</param>
	/// <returns>A collection of the custom attributes that are applied to <paramref name="element" /> and that match <paramref name="attributeType" />, or an empty collection if no such attributes exist.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="element" /> or <paramref name="attributeType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="element" /> is not a constructor, method, property, event, type, or field.</exception>
	/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded.</exception>
	public static IEnumerable<Attribute> GetCustomAttributes(this MemberInfo element, Type attributeType, bool inherit)
	{
		return null;
	}

	/// <summary>Retrieves a collection of custom attributes of a specified type that are applied to a specified member, and optionally inspects the ancestors of that member.</summary>
	/// <param name="element">The member to inspect.</param>
	/// <param name="inherit">
	///   <see langword="true" /> to inspect the ancestors of <paramref name="element" />; otherwise, <see langword="false" />.</param>
	/// <typeparam name="T">The type of attribute to search for.</typeparam>
	/// <returns>A collection of the custom attributes that are applied to <paramref name="element" /> and that match <paramref name="T" />, or an empty collection if no such attributes exist.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="element" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="element" /> is not a constructor, method, property, event, type, or field.</exception>
	/// <exception cref="T:System.TypeLoadException">A custom attribute type cannot be loaded.</exception>
	public static IEnumerable<T> GetCustomAttributes<T>(this MemberInfo element, bool inherit) where T : Attribute
	{
		return null;
	}

	/// <summary>Indicates whether custom attributes of a specified type are applied to a specified member.</summary>
	/// <param name="element">The member to inspect.</param>
	/// <param name="attributeType">The type of attribute to search for.</param>
	/// <returns>
	///   <see langword="true" /> if an attribute of the specified type is applied to <paramref name="element" />; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="element" /> or <paramref name="attributeType" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="attributeType" /> is not derived from <see cref="T:System.Attribute" />.</exception>
	/// <exception cref="T:System.NotSupportedException">
	///   <paramref name="element" /> is not a constructor, method, property, event, type, or field.</exception>
	public static bool IsDefined(this MemberInfo element, Type attributeType)
	{
		return false;
	}
}
