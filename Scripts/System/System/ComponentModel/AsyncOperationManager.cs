using System.Threading;

namespace System.ComponentModel;

/// <summary>Provides concurrency management for classes that support asynchronous method calls. This class cannot be inherited.</summary>
public static class AsyncOperationManager
{
	/// <summary>Gets or sets the synchronization context for the asynchronous operation.</summary>
	/// <returns>The synchronization context for the asynchronous operation.</returns>
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static SynchronizationContext SynchronizationContext => null;

	/// <summary>Returns an <see cref="T:System.ComponentModel.AsyncOperation" /> for tracking the duration of a particular asynchronous operation.</summary>
	/// <param name="userSuppliedState">An object used to associate a piece of client state, such as a task ID, with a particular asynchronous operation.</param>
	/// <returns>An <see cref="T:System.ComponentModel.AsyncOperation" /> that you can use to track the duration of an asynchronous method invocation.</returns>
	public static AsyncOperation CreateOperation(object userSuppliedState)
	{
		return null;
	}
}
