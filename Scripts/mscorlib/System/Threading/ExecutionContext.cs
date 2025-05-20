using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;

namespace System.Threading;

/// <summary>Manages the execution context for the current thread. This class cannot be inherited.</summary>
[Serializable]
public sealed class ExecutionContext : IDisposable, ISerializable
{
	private enum Flags
	{
		None = 0,
		IsNewCapture = 1,
		IsFlowSuppressed = 2,
		IsPreAllocatedDefault = 4
	}

	internal struct Reader
	{
		private ExecutionContext m_ec;

		public bool IsNull => false;

		public bool IsFlowSuppressed
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return false;
			}
		}

		public SynchronizationContext SynchronizationContext => null;

		public SynchronizationContext SynchronizationContextNoFlow => null;

		public LogicalCallContext.Reader LogicalCallContext => default(LogicalCallContext.Reader);

		public Reader(ExecutionContext ec)
		{
			m_ec = null;
		}

		public ExecutionContext DangerousGetRawExecutionContext()
		{
			return null;
		}

		public bool IsDefaultFTContext(bool ignoreSyncCtx)
		{
			return false;
		}

		public bool HasSameLocalValues(ExecutionContext other)
		{
			return false;
		}
	}

	[Flags]
	internal enum CaptureOptions
	{
		None = 0,
		IgnoreSyncCtx = 1,
		OptimizeDefaultCase = 2
	}

	private SynchronizationContext _syncContext;

	private SynchronizationContext _syncContextNoFlow;

	private LogicalCallContext _logicalCallContext;

	private IllogicalCallContext _illogicalCallContext;

	private Flags _flags;

	private Dictionary<IAsyncLocal, object> _localValues;

	private List<IAsyncLocal> _localChangeNotifications;

	private static readonly ExecutionContext s_dummyDefaultEC;

	internal static readonly ExecutionContext Default;

	internal bool isNewCapture
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool isFlowSuppressed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool IsPreAllocatedDefault => false;

	internal LogicalCallContext LogicalCallContext
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal IllogicalCallContext IllogicalCallContext
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal SynchronizationContext SynchronizationContext
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return null;
		}
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		set
		{
		}
	}

	internal SynchronizationContext SynchronizationContextNoFlow
	{
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		get
		{
			return null;
		}
		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
		set
		{
		}
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal ExecutionContext()
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal ExecutionContext(bool isPreAllocatedDefault)
	{
	}

	[HandleProcessCorruptedStateExceptions]
	internal static void OnAsyncLocalContextChanged(ExecutionContext previous, ExecutionContext current)
	{
	}

	/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Threading.ExecutionContext" /> class.</summary>
	public void Dispose()
	{
	}

	/// <summary>Runs a method in a specified execution context on the current thread.</summary>
	/// <param name="executionContext">The <see cref="T:System.Threading.ExecutionContext" /> to set.</param>
	/// <param name="callback">A <see cref="T:System.Threading.ContextCallback" /> delegate that represents the method to be run in the provided execution context.</param>
	/// <param name="state">The object to pass to the callback method.</param>
	/// <exception cref="T:System.InvalidOperationException">
	///   <paramref name="executionContext" /> is <see langword="null" />.  
	/// -or-  
	/// <paramref name="executionContext" /> was not acquired through a capture operation.  
	/// -or-  
	/// <paramref name="executionContext" /> has already been used as the argument to a <see cref="M:System.Threading.ExecutionContext.Run(System.Threading.ExecutionContext,System.Threading.ContextCallback,System.Object)" /> call.</exception>
	public static void Run(ExecutionContext executionContext, ContextCallback callback, object state)
	{
	}

	[FriendAccessAllowed]
	internal static void Run(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx)
	{
	}

	internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state)
	{
	}

	[HandleProcessCorruptedStateExceptions]
	internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx)
	{
	}

	internal static void EstablishCopyOnWriteScope(ref ExecutionContextSwitcher ecsw)
	{
	}

	private static void EstablishCopyOnWriteScope(Thread currentThread, bool knownNullWindowsIdentity, ref ExecutionContextSwitcher ecsw)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[HandleProcessCorruptedStateExceptions]
	internal static ExecutionContextSwitcher SetExecutionContext(ExecutionContext executionContext, bool preserveSyncCtx)
	{
		return default(ExecutionContextSwitcher);
	}

	/// <summary>Creates a copy of the current execution context.</summary>
	/// <returns>An <see cref="T:System.Threading.ExecutionContext" /> object representing the current execution context.</returns>
	/// <exception cref="T:System.InvalidOperationException">This context cannot be copied because it is used. Only newly captured contexts can be copied.</exception>
	public ExecutionContext CreateCopy()
	{
		return null;
	}

	internal ExecutionContext CreateMutableCopy()
	{
		return null;
	}

	/// <summary>Indicates whether the flow of the execution context is currently suppressed.</summary>
	/// <returns>
	///   <see langword="true" /> if the flow is suppressed; otherwise, <see langword="false" />.</returns>
	public static bool IsFlowSuppressed()
	{
		return false;
	}

	/// <summary>Captures the execution context from the current thread.</summary>
	/// <returns>An <see cref="T:System.Threading.ExecutionContext" /> object representing the execution context for the current thread.</returns>
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ExecutionContext Capture()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[FriendAccessAllowed]
	internal static ExecutionContext FastCapture()
	{
		return null;
	}

	internal static ExecutionContext Capture(ref StackCrawlMark stackMark, CaptureOptions options)
	{
		return null;
	}

	/// <summary>Sets the specified <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object with the logical context information needed to recreate an instance of the current execution context.</summary>
	/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> object to be populated with serialization information.</param>
	/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> structure representing the destination context of the serialization.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="info" /> is <see langword="null" />.</exception>
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	private ExecutionContext(SerializationInfo info, StreamingContext context)
	{
	}

	internal bool IsDefaultFTContext(bool ignoreSyncCtx)
	{
		return false;
	}
}
