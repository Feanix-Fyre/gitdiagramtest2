using System.Collections.Concurrent;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization;

/// <summary>Provides static methods to aid with the implementation of a <see cref="T:System.Runtime.Serialization.Formatter" /> for serialization. This class cannot be inherited.</summary>
[ComVisible(true)]
public static class FormatterServices
{
	internal static ConcurrentDictionary<MemberHolder, MemberInfo[]> m_MemberInfoTable;

	private static bool unsafeTypeForwardersIsEnabled;

	private static bool unsafeTypeForwardersIsEnabledInitialized;

	private static readonly Type[] advancedTypes;

	private static Binder s_binder;

	static FormatterServices()
	{
	}

	private static MemberInfo[] GetSerializableMembers(RuntimeType type)
	{
		return null;
	}

	private static bool CheckSerializable(RuntimeType type)
	{
		return false;
	}

	private static MemberInfo[] InternalGetSerializableMembers(RuntimeType type)
	{
		return null;
	}

	private static bool GetParentTypes(RuntimeType parentType, out RuntimeType[] parentTypes, out int parentTypeCount)
	{
		parentTypes = null;
		parentTypeCount = default(int);
		return false;
	}

	/// <summary>Gets all the serializable members for a class of the specified <see cref="T:System.Type" /> and in the provided <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
	/// <param name="type">The type being serialized or cloned.</param>
	/// <param name="context">The context where the serialization occurs.</param>
	/// <returns>An array of type <see cref="T:System.Reflection.MemberInfo" /> of the non-transient, non-static members.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="type" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	public static MemberInfo[] GetSerializableMembers(Type type, StreamingContext context)
	{
		return null;
	}

	/// <summary>Creates a new instance of the specified object type.</summary>
	/// <param name="type">The type of object to create.</param>
	/// <returns>A zeroed object of the specified type.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="type" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	public static object GetUninitializedObject(Type type)
	{
		return null;
	}

	private static object nativeGetUninitializedObject(RuntimeType type)
	{
		return null;
	}

	private static bool GetEnableUnsafeTypeForwarders()
	{
		return false;
	}

	internal static bool UnsafeTypeForwardersIsEnabled()
	{
		return false;
	}

	internal static void SerializationSetValue(MemberInfo fi, object target, object value)
	{
	}

	/// <summary>Populates the specified object with values for each field drawn from the data array of objects.</summary>
	/// <param name="obj">The object to populate.</param>
	/// <param name="members">An array of <see cref="T:System.Reflection.MemberInfo" /> that describes which fields and properties to populate.</param>
	/// <param name="data">An array of <see cref="T:System.Object" /> that specifies the values for each field and property to populate.</param>
	/// <returns>The newly populated object.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="obj" />, <paramref name="members" />, or <paramref name="data" /> parameter is <see langword="null" />.  
	///  An element of <paramref name="members" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The length of <paramref name="members" /> does not match the length of <paramref name="data" />.</exception>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">An element of <paramref name="members" /> is not an instance of <see cref="T:System.Reflection.FieldInfo" />.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	public static object PopulateObjectMembers(object obj, MemberInfo[] members, object[] data)
	{
		return null;
	}

	/// <summary>Extracts the data from the specified object and returns it as an array of objects.</summary>
	/// <param name="obj">The object to write to the formatter.</param>
	/// <param name="members">The members to extract from the object.</param>
	/// <returns>An array of <see cref="T:System.Object" /> that contains data stored in <paramref name="members" /> and associated with <paramref name="obj" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="obj" /> or <paramref name="members" /> parameter is <see langword="null" />.  
	///  An element of <paramref name="members" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">An element of <paramref name="members" /> does not represent a field.</exception>
	public static object[] GetObjectData(object obj, MemberInfo[] members)
	{
		return null;
	}

	/// <summary>Looks up the <see cref="T:System.Type" /> of the specified object in the provided <see cref="T:System.Reflection.Assembly" />.</summary>
	/// <param name="assem">The assembly where you want to look up the object.</param>
	/// <param name="name">The name of the object.</param>
	/// <returns>The <see cref="T:System.Type" /> of the named object.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="assem" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	public static Type GetTypeFromAssembly(Assembly assem, string name)
	{
		return null;
	}

	internal static Assembly LoadAssemblyFromString(string assemblyName)
	{
		return null;
	}

	internal static Assembly LoadAssemblyFromStringNoThrow(string assemblyName)
	{
		return null;
	}

	internal static string GetClrAssemblyName(Type type, out bool hasTypeForwardedFrom)
	{
		hasTypeForwardedFrom = default(bool);
		return null;
	}

	internal static string GetClrTypeFullName(Type type)
	{
		return null;
	}

	private static string GetClrTypeFullNameForArray(Type type)
	{
		return null;
	}

	private static string GetClrTypeFullNameForNonArrayTypes(Type type)
	{
		return null;
	}
}
