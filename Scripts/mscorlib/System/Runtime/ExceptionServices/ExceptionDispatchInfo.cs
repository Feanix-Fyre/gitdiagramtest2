using System.Diagnostics;

namespace System.Runtime.ExceptionServices;

/// <summary>Represents an exception whose state is captured at a certain point in code.</summary>
public sealed class ExceptionDispatchInfo
{
	private Exception m_Exception;

	private object m_stackTrace;

	internal object BinaryStackTraceArray => null;

	/// <summary>Gets the exception that is represented by the current instance.</summary>
	/// <returns>The exception that is represented by the current instance.</returns>
	public Exception SourceException => null;

	private ExceptionDispatchInfo(Exception exception)
	{
	}

	/// <summary>Creates an <see cref="T:System.Runtime.ExceptionServices.ExceptionDispatchInfo" /> object that represents the specified exception at the current point in code.</summary>
	/// <param name="source">The exception whose state is captured, and which is represented by the returned object.</param>
	/// <returns>An object that represents the specified exception at the current point in code.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="source" /> is <see langword="null" />.</exception>
	public static ExceptionDispatchInfo Capture(Exception source)
	{
		return null;
	}

	/// <summary>Throws the exception that is represented by the current <see cref="T:System.Runtime.ExceptionServices.ExceptionDispatchInfo" /> object, after restoring the state that was saved when the exception was captured.</summary>
	[StackTraceHidden]
	public void Throw()
	{
	}

	[StackTraceHidden]
	public static void Throw(Exception source)
	{
	}
}
