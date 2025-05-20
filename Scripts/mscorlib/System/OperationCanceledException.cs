using System.Runtime.Serialization;
using System.Threading;

namespace System;

/// <summary>The exception that is thrown in a thread upon cancellation of an operation that the thread was executing.</summary>
[Serializable]
public class OperationCanceledException : SystemException
{
	[NonSerialized]
	private CancellationToken _cancellationToken;

	/// <summary>Gets a token associated with the operation that was canceled.</summary>
	/// <returns>A token associated with the operation that was canceled, or a default token.</returns>
	public CancellationToken CancellationToken
	{
		get
		{
			return default(CancellationToken);
		}
		private set
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.OperationCanceledException" /> class with a system-supplied error message.</summary>
	public OperationCanceledException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.OperationCanceledException" /> class with a specified error message.</summary>
	/// <param name="message">A <see cref="T:System.String" /> that describes the error.</param>
	public OperationCanceledException(string message)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.OperationCanceledException" /> class with a cancellation token.</summary>
	/// <param name="token">A cancellation token associated with the operation that was canceled.</param>
	public OperationCanceledException(CancellationToken token)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.OperationCanceledException" /> class with a specified error message and a cancellation token.</summary>
	/// <param name="message">The error message that explains the reason for the exception.</param>
	/// <param name="token">A cancellation token associated with the operation that was canceled.</param>
	public OperationCanceledException(string message, CancellationToken token)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.OperationCanceledException" /> class with serialized data.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">The contextual information about the source or destination.</param>
	protected OperationCanceledException(SerializationInfo info, StreamingContext context)
	{
	}
}
