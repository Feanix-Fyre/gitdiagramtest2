using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

/// <summary>Represents a field using an internal metadata token.</summary>
[Serializable]
[ComVisible(true)]
public struct RuntimeFieldHandle : ISerializable
{
	private IntPtr value;

	/// <summary>Gets a handle to the field represented by the current instance.</summary>
	/// <returns>An <see cref="T:System.IntPtr" /> that contains the handle to the field represented by the current instance.</returns>
	public IntPtr Value => (IntPtr)0;

	internal RuntimeFieldHandle(IntPtr v)
	{
		value = (IntPtr)0;
	}

	private RuntimeFieldHandle(SerializationInfo info, StreamingContext context)
	{
		value = (IntPtr)0;
	}

	/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data necessary to deserialize the field represented by the current instance.</summary>
	/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object to populate with serialization information.</param>
	/// <param name="context">(Reserved) The place to store and retrieve serialized data.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="info" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">The <see cref="P:System.RuntimeFieldHandle.Value" /> property of the current instance is not a valid handle.</exception>
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Indicates whether the current instance is equal to the specified object.</summary>
	/// <param name="obj">The object to compare to the current instance.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="obj" /> is a <see cref="T:System.RuntimeFieldHandle" /> and equal to the value of the current instance; otherwise, <see langword="false" />.</returns>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Returns the hash code for this instance.</summary>
	/// <returns>A 32-bit signed integer that is the hash code for this instance.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	private static void SetValueInternal(FieldInfo fi, object obj, object value)
	{
	}

	internal static void SetValue(RuntimeFieldInfo field, object obj, object value, RuntimeType fieldType, FieldAttributes fieldAttr, RuntimeType declaringType, ref bool domainInitialized)
	{
	}

	internal unsafe static void SetValueDirect(RuntimeFieldInfo field, RuntimeType fieldType, void* pTypedRef, object value, RuntimeType contextType)
	{
	}
}
