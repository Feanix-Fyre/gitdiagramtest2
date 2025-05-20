using System.Runtime.Serialization;

namespace System.Threading.Tasks;

/// <summary>Represents an exception used to communicate task cancellation.</summary>
[Serializable]
public class TaskCanceledException : OperationCanceledException
{
	[NonSerialized]
	private readonly Task _canceledTask;

	/// <summary>Initializes a new instance of the <see cref="T:System.Threading.Tasks.TaskCanceledException" /> class with a system-supplied message that describes the error.</summary>
	public TaskCanceledException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Threading.Tasks.TaskCanceledException" /> class with a reference to the <see cref="T:System.Threading.Tasks.Task" /> that has been canceled.</summary>
	/// <param name="task">A task that has been canceled.</param>
	public TaskCanceledException(Task task)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Threading.Tasks.TaskCanceledException" /> class with serialized data.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">The contextual information about the source or destination.</param>
	protected TaskCanceledException(SerializationInfo info, StreamingContext context)
	{
	}
}
