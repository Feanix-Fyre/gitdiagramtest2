using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

/// <summary>The exception that is thrown when type-loading failures occur.</summary>
[Serializable]
[ComVisible(true)]
public class TypeLoadException : SystemException, ISerializable
{
	private string ClassName;

	private string AssemblyName;

	private string MessageArg;

	internal int ResourceId;

	/// <summary>Gets the error message for this exception.</summary>
	/// <returns>The error message string.</returns>
	public override string Message => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.TypeLoadException" /> class.</summary>
	public TypeLoadException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.TypeLoadException" /> class with a specified error message.</summary>
	/// <param name="message">The message that describes the error.</param>
	public TypeLoadException(string message)
	{
	}

	private void SetMessageField()
	{
	}

	private TypeLoadException(string className, string assemblyName)
	{
	}

	private TypeLoadException(string className, string assemblyName, string messageArg, int resourceId)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.TypeLoadException" /> class with serialized data.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">The contextual information about the source or destination.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> object is <see langword="null" />.</exception>
	protected TypeLoadException(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the class name, method name, resource ID, and additional exception information.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">The contextual information about the source or destination.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> object is <see langword="null" />.</exception>
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}
