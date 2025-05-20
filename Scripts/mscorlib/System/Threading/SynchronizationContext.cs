using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace System.Threading;

/// <summary>Provides the basic functionality for propagating a synchronization context in various synchronization models.</summary>
public class SynchronizationContext
{
	private SynchronizationContextProperties _props;

	private static Type s_cachedPreparedType1;

	private static Type s_cachedPreparedType2;

	private static Type s_cachedPreparedType3;

	private static Type s_cachedPreparedType4;

	private static Type s_cachedPreparedType5;

	/// <summary>Gets the synchronization context for the current thread.</summary>
	/// <returns>A <see cref="T:System.Threading.SynchronizationContext" /> object representing the current synchronization context.</returns>
	public static SynchronizationContext Current => null;

	internal static SynchronizationContext CurrentNoFlow
	{
		[FriendAccessAllowed]
		get
		{
			return null;
		}
	}

	internal static SynchronizationContext CurrentExplicit => null;

	/// <summary>Creates a new instance of the <see cref="T:System.Threading.SynchronizationContext" /> class.</summary>
	public SynchronizationContext()
	{
	}

	/// <summary>Determines if wait notification is required.</summary>
	/// <returns>
	///   <see langword="true" /> if wait notification is required; otherwise, <see langword="false" />.</returns>
	public bool IsWaitNotificationRequired()
	{
		return false;
	}

	/// <summary>When overridden in a derived class, dispatches a synchronous message to a synchronization context.</summary>
	/// <param name="d">The <see cref="T:System.Threading.SendOrPostCallback" /> delegate to call.</param>
	/// <param name="state">The object passed to the delegate.</param>
	/// <exception cref="T:System.NotSupportedException">The method was called in a Windows Store app. The implementation of <see cref="T:System.Threading.SynchronizationContext" /> for Windows Store apps does not support the <see cref="M:System.Threading.SynchronizationContext.Send(System.Threading.SendOrPostCallback,System.Object)" /> method.</exception>
	public virtual void Send(SendOrPostCallback d, object state)
	{
	}

	/// <summary>When overridden in a derived class, dispatches an asynchronous message to a synchronization context.</summary>
	/// <param name="d">The <see cref="T:System.Threading.SendOrPostCallback" /> delegate to call.</param>
	/// <param name="state">The object passed to the delegate.</param>
	public virtual void Post(SendOrPostCallback d, object state)
	{
	}

	/// <summary>When overridden in a derived class, responds to the notification that an operation has started.</summary>
	public virtual void OperationStarted()
	{
	}

	/// <summary>When overridden in a derived class, responds to the notification that an operation has completed.</summary>
	public virtual void OperationCompleted()
	{
	}

	/// <summary>Waits for any or all the elements in the specified array to receive a signal.</summary>
	/// <param name="waitHandles">An array of type <see cref="T:System.IntPtr" /> that contains the native operating system handles.</param>
	/// <param name="waitAll">
	///   <see langword="true" /> to wait for all handles; <see langword="false" /> to wait for any handle.</param>
	/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param>
	/// <returns>The array index of the object that satisfied the wait.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="waitHandles" /> is null.</exception>
	[CLSCompliant(false)]
	[PrePrepareMethod]
	public virtual int Wait(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout)
	{
		return 0;
	}

	/// <summary>Helper function that waits for any or all the elements in the specified array to receive a signal.</summary>
	/// <param name="waitHandles">An array of type <see cref="T:System.IntPtr" /> that contains the native operating system handles.</param>
	/// <param name="waitAll">
	///   <see langword="true" /> to wait for all handles;  <see langword="false" /> to wait for any handle.</param>
	/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param>
	/// <returns>The array index of the object that satisfied the wait.</returns>
	[CLSCompliant(false)]
	[PrePrepareMethod]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	protected static int WaitHelper(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout)
	{
		return 0;
	}

	/// <summary>Sets the current synchronization context.</summary>
	/// <param name="syncContext">The <see cref="T:System.Threading.SynchronizationContext" /> object to be set.</param>
	public static void SetSynchronizationContext(SynchronizationContext syncContext)
	{
	}

	private static SynchronizationContext GetThreadLocalContext()
	{
		return null;
	}

	/// <summary>When overridden in a derived class, creates a copy of the synchronization context.</summary>
	/// <returns>A new <see cref="T:System.Threading.SynchronizationContext" /> object.</returns>
	public virtual SynchronizationContext CreateCopy()
	{
		return null;
	}
}
