namespace System.Threading;

/// <summary>Notifies one or more waiting threads that an event has occurred. This class cannot be inherited.</summary>
public sealed class ManualResetEvent : EventWaitHandle
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Threading.ManualResetEvent" /> class with a Boolean value indicating whether to set the initial state to signaled.</summary>
	/// <param name="initialState">
	///   <see langword="true" /> to set the initial state signaled; <see langword="false" /> to set the initial state to nonsignaled.</param>
	public ManualResetEvent(bool initialState)
		: base(initialState: false, default(EventResetMode))
	{
	}
}
