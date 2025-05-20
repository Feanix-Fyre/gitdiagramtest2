using System.Runtime.Serialization;

namespace System.Threading.Tasks;

/// <summary>Represents an exception used to communicate an invalid operation by a <see cref="T:System.Threading.Tasks.TaskScheduler" />.</summary>
[Serializable]
public class TaskSchedulerException : Exception
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Threading.Tasks.TaskSchedulerException" /> class with a system-supplied message that describes the error.</summary>
	public TaskSchedulerException()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Threading.Tasks.TaskSchedulerException" /> class using the default error message and a reference to the inner exception that is the cause of this exception.</summary>
	/// <param name="innerException">The exception that is the cause of the current exception.</param>
	public TaskSchedulerException(Exception innerException)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Threading.Tasks.TaskSchedulerException" /> class with serialized data.</summary>
	/// <param name="info">The object that holds the serialized object data.</param>
	/// <param name="context">The contextual information about the source or destination.</param>
	protected TaskSchedulerException(SerializationInfo info, StreamingContext context)
	{
	}
}
