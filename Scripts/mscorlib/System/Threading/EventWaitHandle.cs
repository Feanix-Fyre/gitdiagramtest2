using System.Runtime.InteropServices;

namespace System.Threading;

/// <summary>Represents a thread synchronization event.</summary>
[ComVisible(true)]
public class EventWaitHandle : WaitHandle
{
	/// <summary>Initializes a new instance of the <see cref="T:System.Threading.EventWaitHandle" /> class, specifying whether the wait handle is initially signaled, and whether it resets automatically or manually.</summary>
	/// <param name="initialState">
	///   <see langword="true" /> to set the initial state to signaled; <see langword="false" /> to set it to nonsignaled.</param>
	/// <param name="mode">One of the <see cref="T:System.Threading.EventResetMode" /> values that determines whether the event resets automatically or manually.</param>
	public EventWaitHandle(bool initialState, EventResetMode mode)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Threading.EventWaitHandle" /> class, specifying whether the wait handle is initially signaled if created as a result of this call, whether it resets automatically or manually, and the name of a system synchronization event.</summary>
	/// <param name="initialState">
	///   <see langword="true" /> to set the initial state to signaled if the named event is created as a result of this call; <see langword="false" /> to set it to nonsignaled.</param>
	/// <param name="mode">One of the <see cref="T:System.Threading.EventResetMode" /> values that determines whether the event resets automatically or manually.</param>
	/// <param name="name">The name of a system-wide synchronization event.</param>
	/// <exception cref="T:System.IO.IOException">A Win32 error occurred.</exception>
	/// <exception cref="T:System.UnauthorizedAccessException">The named event exists and has access control security, but the user does not have <see cref="F:System.Security.AccessControl.EventWaitHandleRights.FullControl" />.</exception>
	/// <exception cref="T:System.Threading.WaitHandleCannotBeOpenedException">The named event cannot be created, perhaps because a wait handle of a different type has the same name.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="name" /> is longer than 260 characters.</exception>
	public EventWaitHandle(bool initialState, EventResetMode mode, string name)
	{
	}

	/// <summary>Sets the state of the event to nonsignaled, causing threads to block.</summary>
	/// <returns>
	///   <see langword="true" /> if the operation succeeds; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="M:System.Threading.WaitHandle.Close" /> method was previously called on this <see cref="T:System.Threading.EventWaitHandle" />.</exception>
	public bool Reset()
	{
		return false;
	}

	/// <summary>Sets the state of the event to signaled, allowing one or more waiting threads to proceed.</summary>
	/// <returns>
	///   <see langword="true" /> if the operation succeeds; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The <see cref="M:System.Threading.WaitHandle.Close" /> method was previously called on this <see cref="T:System.Threading.EventWaitHandle" />.</exception>
	public bool Set()
	{
		return false;
	}
}
