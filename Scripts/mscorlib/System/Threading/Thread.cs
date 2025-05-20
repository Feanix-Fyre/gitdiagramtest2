using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Security.Principal;

namespace System.Threading;

/// <summary>Creates and controls a thread, sets its priority, and gets its status.</summary>
[StructLayout((LayoutKind)0)]
public sealed class Thread : CriticalFinalizerObject
{
	private static LocalDataStoreMgr s_LocalDataStoreMgr;

	[ThreadStatic]
	private static LocalDataStoreHolder s_LocalDataStore;

	[ThreadStatic]
	internal static CultureInfo m_CurrentCulture;

	[ThreadStatic]
	internal static CultureInfo m_CurrentUICulture;

	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentCulture;

	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentUICulture;

	private InternalThread internal_thread;

	private object m_ThreadStartArg;

	private object pending_exception;

	[ThreadStatic]
	private static Thread current_thread;

	private MulticastDelegate m_Delegate;

	private ExecutionContext m_ExecutionContext;

	private bool m_ExecutionContextBelongsToOuterScope;

	private IPrincipal principal;

	private int principal_version;

	internal bool ExecutionContextBelongsToCurrentScope
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	/// <summary>Gets or sets a value indicating the scheduling priority of a thread.</summary>
	/// <returns>One of the <see cref="T:System.Threading.ThreadPriority" /> values. The default value is <see cref="F:System.Threading.ThreadPriority.Normal" />.</returns>
	/// <exception cref="T:System.Threading.ThreadStateException">The thread has reached a final state, such as <see cref="F:System.Threading.ThreadState.Aborted" />.</exception>
	/// <exception cref="T:System.ArgumentException">The value specified for a set operation is not a valid <see cref="T:System.Threading.ThreadPriority" /> value.</exception>
	public ThreadPriority Priority
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the current culture used by the Resource Manager to look up culture-specific resources at run time.</summary>
	/// <returns>An object that represents the current culture.</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is set to <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentException">The property is set to a culture name that cannot be used to locate a resource file. Resource filenames must include only letters, numbers, hyphens or underscores.</exception>
	/// <exception cref="T:System.InvalidOperationException">.NET Core only: Reading or writing the culture of a thread from another thread is not supported.</exception>
	public CultureInfo CurrentUICulture => null;

	/// <summary>Gets or sets the culture for the current thread.</summary>
	/// <returns>An object that represents the culture for the current thread.</returns>
	/// <exception cref="T:System.ArgumentNullException">The property is set to <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">.NET Core only: Reading or writing the culture of a thread from another thread is not supported.</exception>
	public CultureInfo CurrentCulture => null;

	private static LocalDataStoreMgr LocalDataStoreManager => null;

	private InternalThread Internal => null;

	/// <summary>Gets the current context in which the thread is executing.</summary>
	/// <returns>A <see cref="T:System.Runtime.Remoting.Contexts.Context" /> representing the current thread context.</returns>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	public static Context CurrentContext => null;

	/// <summary>Gets the currently running thread.</summary>
	/// <returns>A <see cref="T:System.Threading.Thread" /> that is the representation of the currently running thread.</returns>
	public static Thread CurrentThread
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		get
		{
			return null;
		}
	}

	internal static int CurrentThreadId => 0;

	/// <summary>Gets a value indicating whether or not a thread belongs to the managed thread pool.</summary>
	/// <returns>
	///   <see langword="true" /> if this thread belongs to the managed thread pool; otherwise, <see langword="false" />.</returns>
	public bool IsThreadPoolThread => false;

	internal bool IsThreadPoolThreadInternal => false;

	/// <summary>Gets a value indicating the execution status of the current thread.</summary>
	/// <returns>
	///   <see langword="true" /> if this thread has been started and has not terminated normally or aborted; otherwise, <see langword="false" />.</returns>
	public bool IsAlive => false;

	/// <summary>Gets or sets a value indicating whether or not a thread is a background thread.</summary>
	/// <returns>
	///   <see langword="true" /> if this thread is or is to become a background thread; otherwise, <see langword="false" />.</returns>
	/// <exception cref="T:System.Threading.ThreadStateException">The thread is dead.</exception>
	public bool IsBackground
	{
		set
		{
		}
	}

	/// <summary>Gets or sets the name of the thread.</summary>
	/// <returns>A string containing the name of the thread, or <see langword="null" /> if no name was set.</returns>
	/// <exception cref="T:System.InvalidOperationException">A set operation was requested, but the <see langword="Name" /> property has already been set.</exception>
	public string Name
	{
		set
		{
		}
	}

	/// <summary>Gets a value containing the states of the current thread.</summary>
	/// <returns>One of the <see cref="T:System.Threading.ThreadState" /> values indicating the state of the current thread. The initial value is <see langword="Unstarted" />.</returns>
	public ThreadState ThreadState => default(ThreadState);

	/// <summary>Gets a unique identifier for the current managed thread.</summary>
	/// <returns>An integer that represents a unique identifier for this managed thread.</returns>
	public int ManagedThreadId
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return 0;
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Threading.Thread" /> class.</summary>
	/// <param name="start">A <see cref="T:System.Threading.ThreadStart" /> delegate that represents the methods to be invoked when this thread begins executing.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="start" /> parameter is <see langword="null" />.</exception>
	public Thread(ThreadStart start)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Threading.Thread" /> class, specifying a delegate that allows an object to be passed to the thread when the thread is started.</summary>
	/// <param name="start">A delegate that represents the methods to be invoked when this thread begins executing.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="start" /> is <see langword="null" />.</exception>
	public Thread(ParameterizedThreadStart start)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Threading.Thread" /> class, specifying a delegate that allows an object to be passed to the thread when the thread is started and specifying the maximum stack size for the thread.</summary>
	/// <param name="start">A <see cref="T:System.Threading.ParameterizedThreadStart" /> delegate that represents the methods to be invoked when this thread begins executing.</param>
	/// <param name="maxStackSize">The maximum stack size, in bytes, to be used by the thread, or 0 to use the default maximum stack size specified in the header for the executable.  
	///  Important   For partially trusted code, <paramref name="maxStackSize" /> is ignored if it is greater than the default stack size. No exception is thrown.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="start" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="maxStackSize" /> is less than zero.</exception>
	public Thread(ParameterizedThreadStart start, int maxStackSize)
	{
	}

	/// <summary>Causes the operating system to change the state of the current instance to <see cref="F:System.Threading.ThreadState.Running" />.</summary>
	/// <exception cref="T:System.Threading.ThreadStateException">The thread has already been started.</exception>
	/// <exception cref="T:System.OutOfMemoryException">There is not enough memory available to start this thread.</exception>
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Start()
	{
	}

	/// <summary>Causes the operating system to change the state of the current instance to <see cref="F:System.Threading.ThreadState.Running" />, and optionally supplies an object containing data to be used by the method the thread executes.</summary>
	/// <param name="parameter">An object that contains data to be used by the method the thread executes.</param>
	/// <exception cref="T:System.Threading.ThreadStateException">The thread has already been started.</exception>
	/// <exception cref="T:System.OutOfMemoryException">There is not enough memory available to start this thread.</exception>
	/// <exception cref="T:System.InvalidOperationException">This thread was created using a <see cref="T:System.Threading.ThreadStart" /> delegate instead of a <see cref="T:System.Threading.ParameterizedThreadStart" /> delegate.</exception>
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Start(object parameter)
	{
	}

	private void Start(ref StackCrawlMark stackMark)
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal ExecutionContext.Reader GetExecutionContextReader()
	{
		return default(ExecutionContext.Reader);
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	internal ExecutionContext GetMutableExecutionContext()
	{
		return null;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal void SetExecutionContext(ExecutionContext value, bool belongsToCurrentScope)
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal void SetExecutionContext(ExecutionContext.Reader value, bool belongsToCurrentScope)
	{
	}

	/// <summary>Cancels an <see cref="M:System.Threading.Thread.Abort(System.Object)" /> requested for the current thread.</summary>
	/// <exception cref="T:System.PlatformNotSupportedException">.NET Core only: This member is not supported.</exception>
	/// <exception cref="T:System.Threading.ThreadStateException">
	///   <see langword="Abort" /> was not invoked on the current thread.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required security permission for the current thread.</exception>
	public static void ResetAbort()
	{
	}

	private void ResetAbortNative()
	{
	}

	private void SetPriorityNative(int priority)
	{
	}

	private bool JoinInternal(int millisecondsTimeout)
	{
		return false;
	}

	/// <summary>Blocks the calling thread until the thread represented by this instance terminates, while continuing to perform standard COM and <see langword="SendMessage" /> pumping.</summary>
	/// <exception cref="T:System.Threading.ThreadStateException">The caller attempted to join a thread that is in the <see cref="F:System.Threading.ThreadState.Unstarted" /> state.</exception>
	/// <exception cref="T:System.Threading.ThreadInterruptedException">The thread is interrupted while waiting.</exception>
	public void Join()
	{
	}

	/// <summary>Blocks the calling thread until the thread represented by this instance terminates or the specified time elapses, while continuing to perform standard COM and SendMessage pumping.</summary>
	/// <param name="millisecondsTimeout">The number of milliseconds to wait for the thread to terminate.</param>
	/// <returns>
	///   <see langword="true" /> if the thread has terminated; <see langword="false" /> if the thread has not terminated after the amount of time specified by the <paramref name="millisecondsTimeout" /> parameter has elapsed.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The value of <paramref name="millisecondsTimeout" /> is negative and is not equal to <see cref="F:System.Threading.Timeout.Infinite" /> in milliseconds.</exception>
	/// <exception cref="T:System.Threading.ThreadStateException">The thread has not been started.</exception>
	public bool Join(int millisecondsTimeout)
	{
		return false;
	}

	private static void SleepInternal(int millisecondsTimeout)
	{
	}

	/// <summary>Suspends the current thread for the specified number of milliseconds.</summary>
	/// <param name="millisecondsTimeout">The number of milliseconds for which the thread is suspended. If the value of the <paramref name="millisecondsTimeout" /> argument is zero, the thread relinquishes the remainder of its time slice to any thread of equal priority that is ready to run. If there are no other threads of equal priority that are ready to run, execution of the current thread is not suspended.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">The time-out value is negative and is not equal to <see cref="F:System.Threading.Timeout.Infinite" />.</exception>
	public static void Sleep(int millisecondsTimeout)
	{
	}

	private static bool YieldInternal()
	{
		return false;
	}

	/// <summary>Causes the calling thread to yield execution to another thread that is ready to run on the current processor. The operating system selects the thread to yield to.</summary>
	/// <returns>
	///   <see langword="true" /> if the operating system switched execution to another thread; otherwise, <see langword="false" />.</returns>
	public static bool Yield()
	{
		return false;
	}

	private void SetStartHelper(Delegate start, int maxStackSize)
	{
	}

	/// <summary>Looks up a named data slot. For better performance, use fields that are marked with the <see cref="T:System.ThreadStaticAttribute" /> attribute instead.</summary>
	/// <param name="name">The name of the local data slot.</param>
	/// <returns>A <see cref="T:System.LocalDataStoreSlot" /> allocated for this thread.</returns>
	public static LocalDataStoreSlot GetNamedDataSlot(string name)
	{
		return null;
	}

	/// <summary>Retrieves the value from the specified slot on the current thread, within the current thread's current domain. For better performance, use fields that are marked with the <see cref="T:System.ThreadStaticAttribute" /> attribute instead.</summary>
	/// <param name="slot">The <see cref="T:System.LocalDataStoreSlot" /> from which to get the value.</param>
	/// <returns>The retrieved value.</returns>
	public static object GetData(LocalDataStoreSlot slot)
	{
		return null;
	}

	/// <summary>Sets the data in the specified slot on the currently running thread, for that thread's current domain. For better performance, use fields marked with the <see cref="T:System.ThreadStaticAttribute" /> attribute instead.</summary>
	/// <param name="slot">The <see cref="T:System.LocalDataStoreSlot" /> in which to set the value.</param>
	/// <param name="data">The value to be set.</param>
	public static void SetData(LocalDataStoreSlot slot, object data)
	{
	}

	internal CultureInfo GetCurrentUICultureNoAppX()
	{
		return null;
	}

	private CultureInfo GetCurrentCultureNoAppX()
	{
		return null;
	}

	/// <summary>Synchronizes memory access as follows: The processor executing the current thread cannot reorder instructions in such a way that memory accesses prior to the call to <see cref="M:System.Threading.Thread.MemoryBarrier" /> execute after memory accesses that follow the call to <see cref="M:System.Threading.Thread.MemoryBarrier" />.</summary>
	public static void MemoryBarrier()
	{
	}

	private void ConstructInternalThread()
	{
	}

	private static void GetCurrentThread_icall(ref Thread thread)
	{
	}

	private static Thread GetCurrentThread()
	{
		return null;
	}

	/// <summary>Returns a unique application domain identifier.</summary>
	/// <returns>A 32-bit signed integer uniquely identifying the application domain.</returns>
	public static int GetDomainID()
	{
		return 0;
	}

	private bool Thread_internal(MulticastDelegate start)
	{
		return false;
	}

	/// <summary>Ensures that resources are freed and other cleanup operations are performed when the garbage collector reclaims the <see cref="T:System.Threading.Thread" /> object.</summary>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	~Thread()
	{
	}

	private unsafe static void SetName_icall(InternalThread thread, char* name, int nameLength)
	{
	}

	private static void SetName_internal(InternalThread thread, string name)
	{
	}

	private static void Abort_internal(InternalThread thread, object stateInfo)
	{
	}

	/// <summary>Raises a <see cref="T:System.Threading.ThreadAbortException" /> in the thread on which it is invoked, to begin the process of terminating the thread. Calling this method usually terminates the thread.</summary>
	/// <exception cref="T:System.PlatformNotSupportedException">.NET Core only: This member is not supported.</exception>
	/// <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	/// <exception cref="T:System.Threading.ThreadStateException">The thread that is being aborted is currently suspended.</exception>
	public void Abort()
	{
	}

	private void ClearAbortReason()
	{
	}

	private static void SpinWait_nop()
	{
	}

	/// <summary>Causes a thread to wait the number of times defined by the <paramref name="iterations" /> parameter.</summary>
	/// <param name="iterations">A 32-bit signed integer that defines how long a thread is to wait.</param>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static void SpinWait(int iterations)
	{
	}

	private void StartInternal(object principal, ref StackCrawlMark stackMark)
	{
	}

	private static void SetState(InternalThread thread, ThreadState set)
	{
	}

	private static void ClrState(InternalThread thread, ThreadState clr)
	{
	}

	private static ThreadState GetState(InternalThread thread)
	{
		return default(ThreadState);
	}

	private static int SystemMaxStackStize()
	{
		return 0;
	}

	private static int GetProcessDefaultStackSize(int maxStackSize)
	{
		return 0;
	}

	private void SetStart(MulticastDelegate start, int maxStackSize)
	{
	}

	/// <summary>Notifies a host that execution is about to enter a region of code in which the effects of a thread abort or unhandled exception might jeopardize other tasks in the application domain.</summary>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public static void BeginCriticalRegion()
	{
	}

	/// <summary>Notifies a host that execution is about to enter a region of code in which the effects of a thread abort or unhandled exception are limited to the current task.</summary>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static void EndCriticalRegion()
	{
	}

	/// <summary>Returns a hash code for the current thread.</summary>
	/// <returns>An integer hash code value.</returns>
	[ComVisible(false)]
	public override int GetHashCode()
	{
		return 0;
	}

	private ThreadState ValidateThreadState()
	{
		return default(ThreadState);
	}
}
