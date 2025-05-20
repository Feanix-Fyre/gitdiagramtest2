using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization;

/// <summary>Stores all the data needed to serialize or deserialize an object. This class cannot be inherited.</summary>
[ComVisible(true)]
public sealed class SerializationInfo
{
	private const int defaultSize = 4;

	private const string s_mscorlibAssemblySimpleName = "mscorlib";

	private const string s_mscorlibFileName = "mscorlib.dll";

	internal string[] m_members;

	internal object[] m_data;

	internal Type[] m_types;

	private Dictionary<string, int> m_nameToIndex;

	internal int m_currMember;

	internal IFormatterConverter m_converter;

	private string m_fullTypeName;

	private string m_assemName;

	private Type objectType;

	private bool isFullTypeNameSetExplicit;

	private bool isAssemblyNameSetExplicit;

	private bool requireSameTokenInPartialTrust;

	/// <summary>Gets or sets the full name of the <see cref="T:System.Type" /> to serialize.</summary>
	/// <returns>The full name of the type to serialize.</returns>
	/// <exception cref="T:System.ArgumentNullException">The value this property is set to is <see langword="null" />.</exception>
	public string FullTypeName => null;

	/// <summary>Gets or sets the assembly name of the type to serialize during serialization only.</summary>
	/// <returns>The full name of the assembly of the type to serialize.</returns>
	/// <exception cref="T:System.ArgumentNullException">The value the property is set to is <see langword="null" />.</exception>
	public string AssemblyName => null;

	/// <summary>Gets the number of members that have been added to the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary>
	/// <returns>The number of members that have been added to the current <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</returns>
	public int MemberCount => 0;

	/// <summary>Returns the type of the object to be serialized.</summary>
	/// <returns>The type of the object being serialized.</returns>
	public Type ObjectType => null;

	/// <summary>Gets whether the full type name has been explicitly set.</summary>
	/// <returns>
	///   <see langword="true" /> if the full type name has been explicitly set; otherwise, <see langword="false" />.</returns>
	public bool IsFullTypeNameSetExplicit => false;

	/// <summary>Gets whether the assembly name has been explicitly set.</summary>
	/// <returns>
	///   <see langword="true" /> if the assembly name has been explicitly set; otherwise, <see langword="false" />.</returns>
	public bool IsAssemblyNameSetExplicit => false;

	/// <summary>Creates a new instance of the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> class.</summary>
	/// <param name="type">The <see cref="T:System.Type" /> of the object to serialize.</param>
	/// <param name="converter">The <see cref="T:System.Runtime.Serialization.IFormatterConverter" /> used during deserialization.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="type" /> or <paramref name="converter" /> is <see langword="null" />.</exception>
	[CLSCompliant(false)]
	public SerializationInfo(Type type, IFormatterConverter converter)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> class.</summary>
	/// <param name="type">The <see cref="T:System.Type" /> of the object to serialize.</param>
	/// <param name="converter">The <see cref="T:System.Runtime.Serialization.IFormatterConverter" /> used during deserialization.</param>
	/// <param name="requireSameTokenInPartialTrust">Indicates whether the object requires same token in partial trust.</param>
	[CLSCompliant(false)]
	public SerializationInfo(Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust)
	{
	}

	/// <summary>Sets the <see cref="T:System.Type" /> of the object to serialize.</summary>
	/// <param name="type">The <see cref="T:System.Type" /> of the object to serialize.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="type" /> parameter is <see langword="null" />.</exception>
	public void SetType(Type type)
	{
	}

	private static bool Compare(byte[] a, byte[] b)
	{
		return false;
	}

	internal static void DemandForUnsafeAssemblyNameAssignments(string originalAssemblyName, string newAssemblyName)
	{
	}

	internal static bool IsAssemblyNameAssignmentSafe(string originalAssemblyName, string newAssemblyName)
	{
		return false;
	}

	/// <summary>Returns a <see cref="T:System.Runtime.Serialization.SerializationInfoEnumerator" /> used to iterate through the name-value pairs in the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary>
	/// <returns>A <see cref="T:System.Runtime.Serialization.SerializationInfoEnumerator" /> for parsing the name-value pairs contained in the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</returns>
	public SerializationInfoEnumerator GetEnumerator()
	{
		return null;
	}

	private void ExpandArrays()
	{
	}

	/// <summary>Adds a value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store, where <paramref name="value" /> is associated with <paramref name="name" /> and is serialized as being of <see cref="T:System.Type" /><paramref name="type" />.</summary>
	/// <param name="name">The name to associate with the value, so it can be deserialized later.</param>
	/// <param name="value">The value to be serialized. Any children of this object will automatically be serialized.</param>
	/// <param name="type">The <see cref="T:System.Type" /> to associate with the current object. This parameter must always be the type of the object itself or of one of its base classes.</param>
	/// <exception cref="T:System.ArgumentNullException">If <paramref name="name" /> or <paramref name="type" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />.</exception>
	public void AddValue(string name, object value, Type type)
	{
	}

	/// <summary>Adds the specified object into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store, where it is associated with a specified name.</summary>
	/// <param name="name">The name to associate with the value, so it can be deserialized later.</param>
	/// <param name="value">The value to be serialized. Any children of this object will automatically be serialized.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />.</exception>
	public void AddValue(string name, object value)
	{
	}

	/// <summary>Adds a Boolean value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary>
	/// <param name="name">The name to associate with the value, so it can be deserialized later.</param>
	/// <param name="value">The Boolean value to serialize.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />.</exception>
	public void AddValue(string name, bool value)
	{
	}

	/// <summary>Adds an 8-bit unsigned integer value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary>
	/// <param name="name">The name to associate with the value, so it can be deserialized later.</param>
	/// <param name="value">The byte value to serialize.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />.</exception>
	public void AddValue(string name, byte value)
	{
	}

	/// <summary>Adds a 16-bit signed integer value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary>
	/// <param name="name">The name to associate with the value, so it can be deserialized later.</param>
	/// <param name="value">The <see langword="Int16" /> value to serialize.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />.</exception>
	public void AddValue(string name, short value)
	{
	}

	/// <summary>Adds a 32-bit signed integer value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary>
	/// <param name="name">The name to associate with the value, so it can be deserialized later.</param>
	/// <param name="value">The <see langword="Int32" /> value to serialize.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />.</exception>
	public void AddValue(string name, int value)
	{
	}

	/// <summary>Adds a 64-bit signed integer value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary>
	/// <param name="name">The name to associate with the value, so it can be deserialized later.</param>
	/// <param name="value">The Int64 value to serialize.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />.</exception>
	public void AddValue(string name, long value)
	{
	}

	/// <summary>Adds a 64-bit unsigned integer value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary>
	/// <param name="name">The name to associate with the value, so it can be deserialized later.</param>
	/// <param name="value">The <see langword="UInt64" /> value to serialize.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />.</exception>
	[CLSCompliant(false)]
	public void AddValue(string name, ulong value)
	{
	}

	/// <summary>Adds a single-precision floating-point value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary>
	/// <param name="name">The name to associate with the value, so it can be deserialized later.</param>
	/// <param name="value">The single value to serialize.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />.</exception>
	public void AddValue(string name, float value)
	{
	}

	/// <summary>Adds a <see cref="T:System.DateTime" /> value into the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary>
	/// <param name="name">The name to associate with the value, so it can be deserialized later.</param>
	/// <param name="value">The <see cref="T:System.DateTime" /> value to serialize.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="name" /> parameter is <see langword="null" />.</exception>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">A value has already been associated with <paramref name="name" />.</exception>
	public void AddValue(string name, DateTime value)
	{
	}

	internal void AddValueInternal(string name, object value, Type type)
	{
	}

	internal void UpdateValue(string name, object value, Type type)
	{
	}

	private int FindElement(string name)
	{
		return 0;
	}

	private object GetElement(string name, out Type foundType)
	{
		foundType = null;
		return null;
	}

	[ComVisible(true)]
	private object GetElementNoThrow(string name, out Type foundType)
	{
		foundType = null;
		return null;
	}

	/// <summary>Retrieves a value from the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary>
	/// <param name="name">The name associated with the value to retrieve.</param>
	/// <param name="type">The <see cref="T:System.Type" /> of the value to retrieve. If the stored value cannot be converted to this type, the system will throw a <see cref="T:System.InvalidCastException" />.</param>
	/// <returns>The object of the specified <see cref="T:System.Type" /> associated with <paramref name="name" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> or <paramref name="type" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidCastException">The value associated with <paramref name="name" /> cannot be converted to <paramref name="type" />.</exception>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">An element with the specified name is not found in the current instance.</exception>
	public object GetValue(string name, Type type)
	{
		return null;
	}

	[ComVisible(true)]
	internal object GetValueNoThrow(string name, Type type)
	{
		return null;
	}

	/// <summary>Retrieves a Boolean value from the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary>
	/// <param name="name">The name associated with the value to retrieve.</param>
	/// <returns>The Boolean value associated with <paramref name="name" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidCastException">The value associated with <paramref name="name" /> cannot be converted to a Boolean value.</exception>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">An element with the specified name is not found in the current instance.</exception>
	public bool GetBoolean(string name)
	{
		return false;
	}

	/// <summary>Retrieves a 32-bit signed integer value from the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary>
	/// <param name="name">The name of the value to retrieve.</param>
	/// <returns>The 32-bit signed integer associated with <paramref name="name" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidCastException">The value associated with <paramref name="name" /> cannot be converted to a 32-bit signed integer.</exception>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">An element with the specified name is not found in the current instance.</exception>
	public int GetInt32(string name)
	{
		return 0;
	}

	/// <summary>Retrieves a 64-bit signed integer value from the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary>
	/// <param name="name">The name associated with the value to retrieve.</param>
	/// <returns>The 64-bit signed integer associated with <paramref name="name" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidCastException">The value associated with <paramref name="name" /> cannot be converted to a 64-bit signed integer.</exception>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">An element with the specified name is not found in the current instance.</exception>
	public long GetInt64(string name)
	{
		return 0L;
	}

	/// <summary>Retrieves a single-precision floating-point value from the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary>
	/// <param name="name">The name of the value to retrieve.</param>
	/// <returns>The single-precision floating-point value associated with <paramref name="name" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidCastException">The value associated with <paramref name="name" /> cannot be converted to a single-precision floating-point value.</exception>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">An element with the specified name is not found in the current instance.</exception>
	public float GetSingle(string name)
	{
		return 0f;
	}

	/// <summary>Retrieves a <see cref="T:System.String" /> value from the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> store.</summary>
	/// <param name="name">The name associated with the value to retrieve.</param>
	/// <returns>The <see cref="T:System.String" /> associated with <paramref name="name" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="name" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidCastException">The value associated with <paramref name="name" /> cannot be converted to a <see cref="T:System.String" />.</exception>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">An element with the specified name is not found in the current instance.</exception>
	public string GetString(string name)
	{
		return null;
	}
}
