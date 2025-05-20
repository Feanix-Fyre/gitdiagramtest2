namespace System.Threading.Tasks;

/// <summary>Provides data for the event that is raised when a faulted <see cref="T:System.Threading.Tasks.Task" />'s exception goes unobserved.</summary>
public class UnobservedTaskExceptionEventArgs : EventArgs
{
	private AggregateException m_exception;

	internal bool m_observed;

	/// <summary>Initializes a new instance of the <see cref="T:System.Threading.Tasks.UnobservedTaskExceptionEventArgs" /> class with the unobserved exception.</summary>
	/// <param name="exception">The Exception that has gone unobserved.</param>
	public UnobservedTaskExceptionEventArgs(AggregateException exception)
	{
	}
}
