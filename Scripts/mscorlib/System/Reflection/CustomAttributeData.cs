using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace System.Reflection;

/// <summary>Provides access to custom attribute data for assemblies, modules, types, members and parameters that are loaded into the reflection-only context.</summary>
[Serializable]
[ComVisible(true)]
public class CustomAttributeData
{
	private class LazyCAttrData
	{
		internal Assembly assembly;

		internal IntPtr data;

		internal uint data_length;
	}

	private ConstructorInfo ctorInfo;

	private IList<CustomAttributeTypedArgument> ctorArgs;

	private IList<CustomAttributeNamedArgument> namedArgs;

	private LazyCAttrData lazyData;

	/// <summary>Gets a <see cref="T:System.Reflection.ConstructorInfo" /> object that represents the constructor that would have initialized the custom attribute.</summary>
	/// <returns>An object that represents the constructor that would have initialized the custom attribute represented by the current instance of the <see cref="T:System.Reflection.CustomAttributeData" /> class.</returns>
	[ComVisible(true)]
	public virtual ConstructorInfo Constructor => null;

	/// <summary>Gets the list of positional arguments specified for the attribute instance represented by the <see cref="T:System.Reflection.CustomAttributeData" /> object.</summary>
	/// <returns>A collection of structures that represent the positional arguments specified for the custom attribute instance.</returns>
	[ComVisible(true)]
	public virtual IList<CustomAttributeTypedArgument> ConstructorArguments => null;

	/// <summary>Gets the list of named arguments specified for the attribute instance represented by the <see cref="T:System.Reflection.CustomAttributeData" /> object.</summary>
	/// <returns>A collection of structures that represent the named arguments specified for the custom attribute instance.</returns>
	public virtual IList<CustomAttributeNamedArgument> NamedArguments => null;

	/// <summary>Gets the type of the attribute.</summary>
	/// <returns>The type of the attribute.</returns>
	public Type AttributeType => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.CustomAttributeData" /> class.</summary>
	protected CustomAttributeData()
	{
	}

	internal CustomAttributeData(ConstructorInfo ctorInfo, Assembly assembly, IntPtr data, uint data_length)
	{
	}

	internal CustomAttributeData(ConstructorInfo ctorInfo)
	{
	}

	internal CustomAttributeData(ConstructorInfo ctorInfo, IList<CustomAttributeTypedArgument> ctorArgs, IList<CustomAttributeNamedArgument> namedArgs)
	{
	}

	private static void ResolveArgumentsInternal(ConstructorInfo ctor, Assembly assembly, IntPtr data, uint data_length, out object[] ctorArgs, out object[] namedArgs)
	{
		ctorArgs = null;
		namedArgs = null;
	}

	private void ResolveArguments()
	{
	}

	/// <summary>Returns a list of <see cref="T:System.Reflection.CustomAttributeData" /> objects representing data about the attributes that have been applied to the target assembly.</summary>
	/// <param name="target">The assembly whose custom attribute data is to be retrieved.</param>
	/// <returns>A list of objects that represent data about the attributes that have been applied to the target assembly.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="target" /> is <see langword="null" />.</exception>
	public static IList<CustomAttributeData> GetCustomAttributes(Assembly target)
	{
		return null;
	}

	/// <summary>Returns a list of <see cref="T:System.Reflection.CustomAttributeData" /> objects representing data about the attributes that have been applied to the target member.</summary>
	/// <param name="target">The member whose attribute data is to be retrieved.</param>
	/// <returns>A list of objects that represent data about the attributes that have been applied to the target member.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="target" /> is <see langword="null" />.</exception>
	public static IList<CustomAttributeData> GetCustomAttributes(MemberInfo target)
	{
		return null;
	}

	internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeType target)
	{
		return null;
	}

	/// <summary>Returns a list of <see cref="T:System.Reflection.CustomAttributeData" /> objects representing data about the attributes that have been applied to the target module.</summary>
	/// <param name="target">The module whose custom attribute data is to be retrieved.</param>
	/// <returns>A list of objects that represent data about the attributes that have been applied to the target module.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="target" /> is <see langword="null" />.</exception>
	public static IList<CustomAttributeData> GetCustomAttributes(Module target)
	{
		return null;
	}

	/// <summary>Returns a list of <see cref="T:System.Reflection.CustomAttributeData" /> objects representing data about the attributes that have been applied to the target parameter.</summary>
	/// <param name="target">The parameter whose attribute data is to be retrieved.</param>
	/// <returns>A list of objects that represent data about the attributes that have been applied to the target parameter.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="target" /> is <see langword="null" />.</exception>
	public static IList<CustomAttributeData> GetCustomAttributes(ParameterInfo target)
	{
		return null;
	}

	/// <summary>Returns a string representation of the custom attribute.</summary>
	/// <returns>A string value that represents the custom attribute.</returns>
	public override string ToString()
	{
		return null;
	}

	private static T[] UnboxValues<T>(object[] values)
	{
		return null;
	}

	/// <summary>Returns a value that indicates whether this instance is equal to a specified object.</summary>
	/// <param name="obj">An object to compare with this instance, or <see langword="null" />.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="obj" /> is equal to the current instance; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Serves as a hash function for a particular type.</summary>
	/// <returns>A hash code for the current <see cref="T:System.Object" />.</returns>
	public override int GetHashCode()
	{
		return 0;
	}
}
