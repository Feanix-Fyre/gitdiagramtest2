using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Runtime.Serialization;

namespace System;

/// <summary>Represents one or more errors that occur during application execution.</summary>
[Serializable]
[DebuggerDisplay("Count = {InnerExceptionCount}")]
public class AggregateException : Exception
{
	private ReadOnlyCollection<Exception> m_innerExceptions;

	/// <summary>Gets a read-only collection of the <see cref="T:System.Exception" /> instances that caused the current exception.</summary>
	/// <returns>A read-only collection of the <see cref="T:System.Exception" /> instances that caused the current exception.</returns>
	public ReadOnlyCollection<Exception> InnerExceptions => null;

	public override string Message => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.AggregateException" /> class with a system-supplied message that describes the error.</summary>
	public AggregateException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.AggregateException" /> class with references to the inner exceptions that are the cause of this exception.</summary>
	/// <param name="innerExceptions">The exceptions that are the cause of the current exception.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="innerExceptions" /> argument is null.</exception>
	/// <exception cref="T:System.ArgumentException">An element of <paramref name="innerExceptions" /> is null.</exception>
	public AggregateException(IEnumerable<Exception> innerExceptions)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.AggregateException" /> class with references to the inner exceptions that are the cause of this exception.</summary>
	/// <param name="innerExceptions">The exceptions that are the cause of the current exception.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="innerExceptions" /> argument is null.</exception>
	/// <exception cref="T:System.ArgumentException">An element of <paramref name="innerExceptions" /> is null.</exception>
	public AggregateException(params Exception[] innerExceptions)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.AggregateException" /> class with a specified error message and references to the inner exceptions that are the cause of this exception.</summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="innerExceptions">The exceptions that are the cause of the current exception.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="innerExceptions" /> argument is null.</exception>
	/// <exception cref="T:System.ArgumentException">An element of <paramref name="innerExceptions" /> is null.</exception>
	public AggregateException(string message, IEnumerable<Exception> innerExceptions)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.AggregateException" /> class with a specified error message and references to the inner exceptions that are the cause of this exception.</summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="innerExceptions">The exceptions that are the cause of the current exception.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="innerExceptions" /> argument is null.</exception>
	/// <exception cref="T:System.ArgumentException">An element of <paramref name="innerExceptions" /> is null.</exception>
	public AggregateException(string message, params Exception[] innerExceptions)
	{
	}

	private AggregateException(string message, IList<Exception> innerExceptions)
	{
	}

	internal AggregateException(IEnumerable<ExceptionDispatchInfo> innerExceptionInfos)
	{
	}

	internal AggregateException(string message, IEnumerable<ExceptionDispatchInfo> innerExceptionInfos)
	{
	}

	private AggregateException(string message, IList<ExceptionDispatchInfo> innerExceptionInfos)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.AggregateException" /> class with serialized data.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">The contextual information about the source or destination.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> argument is null.</exception>
	/// <exception cref="T:System.Runtime.Serialization.SerializationException">The exception could not be deserialized correctly.</exception>
	protected AggregateException(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.AggregateException" /> class with serialized data.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">The contextual information about the source or destination.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> argument is null.</exception>
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	/// <summary>Flattens an <see cref="T:System.AggregateException" /> instances into a single, new instance.</summary>
	/// <returns>A new, flattened <see cref="T:System.AggregateException" />.</returns>
	public AggregateException Flatten()
	{
		return null;
	}

	/// <summary>Creates and returns a string representation of the current <see cref="T:System.AggregateException" />.</summary>
	/// <returns>A string representation of the current exception.</returns>
	public override string ToString()
	{
		return null;
	}
}
