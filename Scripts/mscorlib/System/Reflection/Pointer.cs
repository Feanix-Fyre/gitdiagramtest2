using System.Runtime.Serialization;

namespace System.Reflection;

/// <summary>Provides a wrapper class for pointers.</summary>
[CLSCompliant(false)]
public sealed class Pointer : ISerializable
{
	private unsafe readonly void* _ptr;

	private readonly Type _ptrType;

	private unsafe Pointer(void* ptr, Type ptrType)
	{
	}

	/// <summary>Boxes the supplied unmanaged memory pointer and the type associated with that pointer into a managed <see cref="T:System.Reflection.Pointer" /> wrapper object. The value and the type are saved so they can be accessed from the native code during an invocation.</summary>
	/// <param name="ptr">The supplied unmanaged memory pointer.</param>
	/// <param name="type">The type associated with the <paramref name="ptr" /> parameter.</param>
	/// <returns>A pointer object.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="type" /> is not a pointer.</exception>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="type" /> is <see langword="null" />.</exception>
	public unsafe static object Box(void* ptr, Type type)
	{
		return null;
	}

	/// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the file name, fusion log, and additional exception information.</summary>
	/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
	/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}
