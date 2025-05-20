using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

/// <summary>
///   <see cref="T:System.RuntimeMethodHandle" /> is a handle to the internal metadata representation of a method.</summary>
[Serializable]
[ComVisible(true)]
public struct RuntimeMethodHandle : ISerializable
{
	private IntPtr value;

	/// <summary>Gets the value of this instance.</summary>
	/// <returns>A <see cref="T:System.RuntimeMethodHandle" /> that is the internal metadata representation of a method.</returns>
	public IntPtr Value => (IntPtr)0;

	internal RuntimeMethodHandle(IntPtr v)
	{
		value = (IntPtr)0;
	}

	private RuntimeMethodHandle(SerializationInfo info, StreamingContext context)
	{
		value = (IntPtr)0;
	}

	/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data necessary to deserialize the field represented by this instance.</summary>
	/// <param name="info">The object to populate with serialization information.</param>
	/// <param name="context">(Reserved) The place to store and retrieve serialized data.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="info" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">
	///   <see cref="P:System.RuntimeMethodHandle.Value" /> is invalid.</exception>
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Indicates whether this instance is equal to a specified object.</summary>
	/// <param name="obj">A <see cref="T:System.Object" /> to compare to this instance.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="obj" /> is a <see cref="T:System.RuntimeMethodHandle" /> and equal to the value of this instance; otherwise, <see langword="false" />.</returns>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
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

	internal static string ConstructInstantiation(RuntimeMethodInfo method, TypeNameFormatFlags format)
	{
		return null;
	}

	internal bool IsNullHandle()
	{
		return false;
	}
}
