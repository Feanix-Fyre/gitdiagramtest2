using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace System.Threading;

/// <summary>Encapsulates operating system-specific objects that wait for exclusive access to shared resources.</summary>
[StructLayout((LayoutKind)0)]
[ComVisible(true)]
public abstract class WaitHandle : MarshalByRefObject, IDisposable
{
	/// <summary>Indicates that a <see cref="M:System.Threading.WaitHandle.WaitAny(System.Threading.WaitHandle[],System.Int32,System.Boolean)" /> operation timed out before any of the wait handles were signaled. This field is constant.</summary>
	public const int WaitTimeout = 258;

	private const int MAX_WAITHANDLES = 64;

	private IntPtr waitHandle;

	internal SafeWaitHandle safeWaitHandle;

	internal bool hasThreadAffinity;

	private const int WAIT_OBJECT_0 = 0;

	private const int WAIT_ABANDONED = 128;

	private const int WAIT_FAILED = int.MaxValue;

	private const int ERROR_TOO_MANY_POSTS = 298;

	private const int ERROR_NOT_OWNED_BY_CALLER = 299;

	/// <summary>Represents an invalid native operating system handle. This field is read-only.</summary>
	protected static readonly IntPtr InvalidHandle;

	internal const int MaxWaitHandles = 64;

	/// <summary>Gets or sets the native operating system handle.</summary>
	/// <returns>An <see langword="IntPtr" /> representing the native operating system handle. The default is the value of the <see cref="F:System.Threading.WaitHandle.InvalidHandle" /> field.</returns>
	[Obsolete("Use the SafeWaitHandle property instead.")]
	public virtual IntPtr Handle
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the native operating system handle.</summary>
	/// <returns>A <see cref="T:Microsoft.Win32.SafeHandles.SafeWaitHandle" /> representing the native operating system handle.</returns>
	public SafeWaitHandle SafeWaitHandle
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		get
		{
			return null;
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Threading.WaitHandle" /> class.</summary>
	protected WaitHandle()
	{
	}

	private void Init()
	{
	}

	internal void SetHandleInternal(SafeWaitHandle handle)
	{
	}

	/// <summary>Blocks the current thread until the current <see cref="T:System.Threading.WaitHandle" /> receives a signal, using a 32-bit signed integer to specify the time interval and specifying whether to exit the synchronization domain before the wait.</summary>
	/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param>
	/// <param name="exitContext">
	///   <see langword="true" /> to exit the synchronization domain for the context before the wait (if in a synchronized context), and reacquire it afterward; otherwise, <see langword="false" />.</param>
	/// <returns>
	///   <see langword="true" /> if the current instance receives a signal; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The current instance has already been disposed.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
	/// <exception cref="T:System.Threading.AbandonedMutexException">The wait completed because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception>
	/// <exception cref="T:System.InvalidOperationException">The current instance is a transparent proxy for a <see cref="T:System.Threading.WaitHandle" /> in another application domain.</exception>
	public virtual bool WaitOne(int millisecondsTimeout, bool exitContext)
	{
		return false;
	}

	/// <summary>Blocks the current thread until the current <see cref="T:System.Threading.WaitHandle" /> receives a signal.</summary>
	/// <returns>
	///   <see langword="true" /> if the current instance receives a signal. If the current instance is never signaled, <see cref="M:System.Threading.WaitHandle.WaitOne(System.Int32,System.Boolean)" /> never returns.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The current instance has already been disposed.</exception>
	/// <exception cref="T:System.Threading.AbandonedMutexException">The wait completed because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception>
	/// <exception cref="T:System.InvalidOperationException">The current instance is a transparent proxy for a <see cref="T:System.Threading.WaitHandle" /> in another application domain.</exception>
	public virtual bool WaitOne()
	{
		return false;
	}

	/// <summary>Blocks the current thread until the current <see cref="T:System.Threading.WaitHandle" /> receives a signal, using a 32-bit signed integer to specify the time interval in milliseconds.</summary>
	/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param>
	/// <returns>
	///   <see langword="true" /> if the current instance receives a signal; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ObjectDisposedException">The current instance has already been disposed.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
	/// <exception cref="T:System.Threading.AbandonedMutexException">The wait completed because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception>
	/// <exception cref="T:System.InvalidOperationException">The current instance is a transparent proxy for a <see cref="T:System.Threading.WaitHandle" /> in another application domain.</exception>
	public virtual bool WaitOne(int millisecondsTimeout)
	{
		return false;
	}

	private bool WaitOne(long timeout, bool exitContext)
	{
		return false;
	}

	internal static bool InternalWaitOne(SafeHandle waitableSafeHandle, long millisecondsTimeout, bool hasThreadAffinity, bool exitContext)
	{
		return false;
	}

	/// <summary>Waits for all the elements in the specified array to receive a signal, using an <see cref="T:System.Int32" /> value to specify the time interval and specifying whether to exit the synchronization domain before the wait.</summary>
	/// <param name="waitHandles">A <see langword="WaitHandle" /> array containing the objects for which the current instance will wait. This array cannot contain multiple references to the same object (duplicates).</param>
	/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param>
	/// <param name="exitContext">
	///   <see langword="true" /> to exit the synchronization domain for the context before the wait (if in a synchronized context), and reacquire it afterward; otherwise, <see langword="false" />.</param>
	/// <returns>
	///   <see langword="true" /> when every element in <paramref name="waitHandles" /> has received a signal; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="waitHandles" /> parameter is <see langword="null" />.  
	///  -or-  
	///  One or more of the objects in the <paramref name="waitHandles" /> array is <see langword="null" />.  
	///  -or-  
	///  <paramref name="waitHandles" /> is an array with no elements and the .NET Framework version is 2.0 or later.</exception>
	/// <exception cref="T:System.DuplicateWaitObjectException">The <paramref name="waitHandles" /> array contains elements that are duplicates.</exception>
	/// <exception cref="T:System.NotSupportedException">The number of objects in <paramref name="waitHandles" /> is greater than the system permits.  
	///  -or-  
	///  The <see cref="T:System.STAThreadAttribute" /> attribute is applied to the thread procedure for the current thread, and <paramref name="waitHandles" /> contains more than one element.</exception>
	/// <exception cref="T:System.ApplicationException">
	///   <paramref name="waitHandles" /> is an array with no elements and the .NET Framework version is 1.0 or 1.1.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
	/// <exception cref="T:System.Threading.AbandonedMutexException">The wait completed because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception>
	/// <exception cref="T:System.InvalidOperationException">The <paramref name="waitHandles" /> array contains a transparent proxy for a <see cref="T:System.Threading.WaitHandle" /> in another application domain.</exception>
	public static bool WaitAll(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext)
	{
		return false;
	}

	/// <summary>Waits for all the elements in the specified array to receive a signal, using an <see cref="T:System.Int32" /> value to specify the time interval.</summary>
	/// <param name="waitHandles">A <see langword="WaitHandle" /> array containing the objects for which the current instance will wait. This array cannot contain multiple references to the same object (duplicates).</param>
	/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param>
	/// <returns>
	///   <see langword="true" /> when every element in <paramref name="waitHandles" /> has received a signal; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="waitHandles" /> parameter is <see langword="null" />.  
	///  -or-  
	///  One or more of the objects in the <paramref name="waitHandles" /> array is <see langword="null" />.  
	///  -or-  
	///  <paramref name="waitHandles" /> is an array with no elements.</exception>
	/// <exception cref="T:System.DuplicateWaitObjectException">In the .NET for Windows Store apps or the Portable Class Library, catch the base class exception, <see cref="T:System.ArgumentException" />, instead.  
	///
	///
	///
	///
	///  The <paramref name="waitHandles" /> array contains elements that are duplicates.</exception>
	/// <exception cref="T:System.NotSupportedException">The number of objects in <paramref name="waitHandles" /> is greater than the system permits.  
	///  -or-  
	///  The <see cref="T:System.STAThreadAttribute" /> attribute is applied to the thread procedure for the current thread, and <paramref name="waitHandles" /> contains more than one element.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
	/// <exception cref="T:System.Threading.AbandonedMutexException">The wait completed because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception>
	/// <exception cref="T:System.InvalidOperationException">The <paramref name="waitHandles" /> array contains a transparent proxy for a <see cref="T:System.Threading.WaitHandle" /> in another application domain.</exception>
	public static bool WaitAll(WaitHandle[] waitHandles, int millisecondsTimeout)
	{
		return false;
	}

	/// <summary>Waits for any of the elements in the specified array to receive a signal, using a 32-bit signed integer to specify the time interval, and specifying whether to exit the synchronization domain before the wait.</summary>
	/// <param name="waitHandles">A <see langword="WaitHandle" /> array containing the objects for which the current instance will wait.</param>
	/// <param name="millisecondsTimeout">The number of milliseconds to wait, or <see cref="F:System.Threading.Timeout.Infinite" /> (-1) to wait indefinitely.</param>
	/// <param name="exitContext">
	///   <see langword="true" /> to exit the synchronization domain for the context before the wait (if in a synchronized context), and reacquire it afterward; otherwise, <see langword="false" />.</param>
	/// <returns>The array index of the object that satisfied the wait, or <see cref="F:System.Threading.WaitHandle.WaitTimeout" /> if no object satisfied the wait and a time interval equivalent to <paramref name="millisecondsTimeout" /> has passed.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="waitHandles" /> parameter is <see langword="null" />.  
	///  -or-  
	///  One or more of the objects in the <paramref name="waitHandles" /> array is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">The number of objects in <paramref name="waitHandles" /> is greater than the system permits.</exception>
	/// <exception cref="T:System.ApplicationException">
	///   <paramref name="waitHandles" /> is an array with no elements, and the .NET Framework version is 1.0 or 1.1.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="millisecondsTimeout" /> is a negative number other than -1, which represents an infinite time-out.</exception>
	/// <exception cref="T:System.Threading.AbandonedMutexException">The wait completed because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="waitHandles" /> is an array with no elements, and the .NET Framework version is 2.0 or later.</exception>
	/// <exception cref="T:System.InvalidOperationException">The <paramref name="waitHandles" /> array contains a transparent proxy for a <see cref="T:System.Threading.WaitHandle" /> in another application domain.</exception>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext)
	{
		return 0;
	}

	/// <summary>Waits for any of the elements in the specified array to receive a signal, using a <see cref="T:System.TimeSpan" /> to specify the time interval and specifying whether to exit the synchronization domain before the wait.</summary>
	/// <param name="waitHandles">A <see langword="WaitHandle" /> array containing the objects for which the current instance will wait.</param>
	/// <param name="timeout">A <see cref="T:System.TimeSpan" /> that represents the number of milliseconds to wait, or a <see cref="T:System.TimeSpan" /> that represents -1 milliseconds to wait indefinitely.</param>
	/// <param name="exitContext">
	///   <see langword="true" /> to exit the synchronization domain for the context before the wait (if in a synchronized context), and reacquire it afterward; otherwise, <see langword="false" />.</param>
	/// <returns>The array index of the object that satisfied the wait, or <see cref="F:System.Threading.WaitHandle.WaitTimeout" /> if no object satisfied the wait and a time interval equivalent to <paramref name="timeout" /> has passed.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="waitHandles" /> parameter is <see langword="null" />.  
	///  -or-  
	///  One or more of the objects in the <paramref name="waitHandles" /> array is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">The number of objects in <paramref name="waitHandles" /> is greater than the system permits.</exception>
	/// <exception cref="T:System.ApplicationException">
	///   <paramref name="waitHandles" /> is an array with no elements, and the .NET Framework version is 1.0 or 1.1.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="timeout" /> is a negative number other than -1 milliseconds, which represents an infinite time-out.  
	/// -or-  
	/// <paramref name="timeout" /> is greater than <see cref="F:System.Int32.MaxValue" />.</exception>
	/// <exception cref="T:System.Threading.AbandonedMutexException">The wait completed because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="waitHandles" /> is an array with no elements, and the .NET Framework version is 2.0 or later.</exception>
	/// <exception cref="T:System.InvalidOperationException">The <paramref name="waitHandles" /> array contains a transparent proxy for a <see cref="T:System.Threading.WaitHandle" /> in another application domain.</exception>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public static int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout, bool exitContext)
	{
		return 0;
	}

	/// <summary>Waits for any of the elements in the specified array to receive a signal.</summary>
	/// <param name="waitHandles">A <see langword="WaitHandle" /> array containing the objects for which the current instance will wait.</param>
	/// <returns>The array index of the object that satisfied the wait.</returns>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="waitHandles" /> parameter is <see langword="null" />.  
	///  -or-  
	///  One or more of the objects in the <paramref name="waitHandles" /> array is <see langword="null" />.</exception>
	/// <exception cref="T:System.NotSupportedException">The number of objects in <paramref name="waitHandles" /> is greater than the system permits.</exception>
	/// <exception cref="T:System.ApplicationException">
	///   <paramref name="waitHandles" /> is an array with no elements, and the .NET Framework version is 1.0 or 1.1.</exception>
	/// <exception cref="T:System.Threading.AbandonedMutexException">The wait completed because a thread exited without releasing a mutex. This exception is not thrown on Windows 98 or Windows Millennium Edition.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="waitHandles" /> is an array with no elements, and the .NET Framework version is 2.0 or later.</exception>
	/// <exception cref="T:System.InvalidOperationException">The <paramref name="waitHandles" /> array contains a transparent proxy for a <see cref="T:System.Threading.WaitHandle" /> in another application domain.</exception>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public static int WaitAny(WaitHandle[] waitHandles)
	{
		return 0;
	}

	private static void ThrowAbandonedMutexException()
	{
	}

	private static void ThrowAbandonedMutexException(int location, WaitHandle handle)
	{
	}

	/// <summary>Releases all resources held by the current <see cref="T:System.Threading.WaitHandle" />.</summary>
	public virtual void Close()
	{
	}

	/// <summary>When overridden in a derived class, releases the unmanaged resources used by the <see cref="T:System.Threading.WaitHandle" />, and optionally releases the managed resources.</summary>
	/// <param name="explicitDisposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected virtual void Dispose(bool explicitDisposing)
	{
	}

	/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Threading.WaitHandle" /> class.</summary>
	public void Dispose()
	{
	}

	private static int WaitOneNative(SafeHandle waitableSafeHandle, uint millisecondsTimeout, bool hasThreadAffinity, bool exitContext)
	{
		return 0;
	}

	private static int WaitMultiple(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext, bool WaitAll)
	{
		return 0;
	}

	internal unsafe static int Wait_internal(IntPtr* handles, int numHandles, bool waitAll, int ms)
	{
		return 0;
	}
}
