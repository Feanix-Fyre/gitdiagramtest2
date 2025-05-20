using System.Runtime.Serialization;

namespace System.Reflection;

/// <summary>The exception that is thrown by the <see cref="M:System.Reflection.Module.GetTypes" /> method if any of the classes in a module cannot be loaded. This class cannot be inherited.</summary>
[Serializable]
public sealed class ReflectionTypeLoadException : SystemException, ISerializable
{
	/// <summary>Gets the array of classes that were defined in the module and loaded.</summary>
	/// <returns>An array of type <see langword="Type" /> containing the classes that were defined in the module and loaded. This array can contain some <see langword="null" /> values.</returns>
	public Type[] Types { get; }

	/// <summary>Gets the array of exceptions thrown by the class loader.</summary>
	/// <returns>An array of type <see langword="Exception" /> containing the exceptions thrown by the class loader. The null values in the <see cref="P:System.Reflection.ReflectionTypeLoadException.Types" /> array of this instance line up with the exceptions in this array.</returns>
	public Exception[] LoaderExceptions { get; }

	public override string Message => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.ReflectionTypeLoadException" /> class with the given classes and their associated exceptions.</summary>
	/// <param name="classes">An array of type <see langword="Type" /> containing the classes that were defined in the module and loaded. This array can contain null reference (<see langword="Nothing" /> in Visual Basic) values.</param>
	/// <param name="exceptions">An array of type <see langword="Exception" /> containing the exceptions that were thrown by the class loader. The null reference (<see langword="Nothing" /> in Visual Basic) values in the <paramref name="classes" /> array line up with the exceptions in this <paramref name="exceptions" /> array.</param>
	public ReflectionTypeLoadException(Type[] classes, Exception[] exceptions)
	{
	}

	private ReflectionTypeLoadException(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Provides an <see cref="T:System.Runtime.Serialization.ISerializable" /> implementation for serialized objects.</summary>
	/// <param name="info">The information and data needed to serialize or deserialize an object.</param>
	/// <param name="context">The context for the serialization.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <see langword="info" /> is <see langword="null" />.</exception>
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	public override string ToString()
	{
		return null;
	}

	private string CreateString(bool isMessage)
	{
		return null;
	}
}
