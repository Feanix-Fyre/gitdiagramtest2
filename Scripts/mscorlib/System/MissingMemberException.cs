using System.Runtime.Serialization;

namespace System;

/// <summary>The exception that is thrown when there is an attempt to dynamically access a class member that does not exist or that is not declared as public. If a member in a class library has been removed or renamed, recompile any assemblies that reference that library.</summary>
[Serializable]
public class MissingMemberException : MemberAccessException
{
	/// <summary>Holds the class name of the missing member.</summary>
	protected string ClassName;

	/// <summary>Holds the name of the missing member.</summary>
	protected string MemberName;

	/// <summary>Holds the signature of the missing member.</summary>
	protected byte[] Signature;

	/// <summary>Gets the text string showing the class name, the member name, and the signature of the missing member.</summary>
	/// <returns>The error message string.</returns>
	public override string Message => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.MissingMemberException" /> class.</summary>
	public MissingMemberException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.MissingMemberException" /> class with a specified error message.</summary>
	/// <param name="message">The message that describes the error.</param>
	public MissingMemberException(string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.MissingMemberException" /> class with serialized data.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">The contextual information about the source or destination.</param>
	protected MissingMemberException(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the class name, the member name, the signature of the missing member, and additional exception information.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">The contextual information about the source or destination.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> object is <see langword="null" />.</exception>
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	internal static string FormatSignature(byte[] signature)
	{
		return null;
	}
}
