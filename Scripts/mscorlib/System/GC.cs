using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace System;

/// <summary>Controls the system garbage collector, a service that automatically reclaims unused memory.</summary>
public static class GC
{
	internal static readonly object EPHEMERON_TOMBSTONE;

	/// <summary>Gets the maximum number of generations that the system currently supports.</summary>
	/// <returns>A value that ranges from zero to the maximum number of supported generations.</returns>
	public static int MaxGeneration => 0;

	private static int GetCollectionCount(int generation)
	{
		return 0;
	}

	private static int GetMaxGeneration()
	{
		return 0;
	}

	private static void InternalCollect(int generation)
	{
	}

	private static void RecordPressure(long bytesAllocated)
	{
	}

	internal static void register_ephemeron_array(Ephemeron[] array)
	{
	}

	private static object get_ephemeron_tombstone()
	{
		return null;
	}

	internal static void GetMemoryInfo(out uint highMemLoadThreshold, out ulong totalPhysicalMem, out uint lastRecordedMemLoad, out UIntPtr lastRecordedHeapSize, out UIntPtr lastRecordedFragmentation)
	{
		highMemLoadThreshold = default(uint);
		totalPhysicalMem = default(ulong);
		lastRecordedMemLoad = default(uint);
		lastRecordedHeapSize = default(UIntPtr);
		lastRecordedFragmentation = default(UIntPtr);
	}

	/// <summary>Informs the runtime of a large allocation of unmanaged memory that should be taken into account when scheduling garbage collection.</summary>
	/// <param name="bytesAllocated">The incremental amount of unmanaged memory that has been allocated.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="bytesAllocated" /> is less than or equal to 0.  
	/// -or-  
	/// On a 32-bit computer, <paramref name="bytesAllocated" /> is larger than <see cref="F:System.Int32.MaxValue" />.</exception>
	public static void AddMemoryPressure(long bytesAllocated)
	{
	}

	/// <summary>Informs the runtime that unmanaged memory has been released and no longer needs to be taken into account when scheduling garbage collection.</summary>
	/// <param name="bytesAllocated">The amount of unmanaged memory that has been released.</param>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="bytesAllocated" /> is less than or equal to 0.  
	/// -or-  
	/// On a 32-bit computer, <paramref name="bytesAllocated" /> is larger than <see cref="F:System.Int32.MaxValue" />.</exception>
	public static void RemoveMemoryPressure(long bytesAllocated)
	{
	}

	/// <summary>Forces an immediate garbage collection of all generations.</summary>
	public static void Collect()
	{
	}

	/// <summary>Returns the number of times garbage collection has occurred for the specified generation of objects.</summary>
	/// <param name="generation">The generation of objects for which the garbage collection count is to be determined.</param>
	/// <returns>The number of times garbage collection has occurred for the specified generation since the process was started.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="generation" /> is less than 0.</exception>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static int CollectionCount(int generation)
	{
		return 0;
	}

	/// <summary>References the specified object, which makes it ineligible for garbage collection from the start of the current routine to the point where this method is called.</summary>
	/// <param name="obj">The object to reference.</param>
	[MethodImpl(MethodImplOptions.NoInlining)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static void KeepAlive(object obj)
	{
	}

	/// <summary>Suspends the current thread until the thread that is processing the queue of finalizers has emptied that queue.</summary>
	public static void WaitForPendingFinalizers()
	{
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private static void _SuppressFinalize(object o)
	{
	}

	/// <summary>Requests that the common language runtime not call the finalizer for the specified object.</summary>
	/// <param name="obj">The object whose finalizer must not be executed.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="obj" /> is <see langword="null" />.</exception>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static void SuppressFinalize(object obj)
	{
	}

	private static void _ReRegisterForFinalize(object o)
	{
	}

	/// <summary>Requests that the system call the finalizer for the specified object for which <see cref="M:System.GC.SuppressFinalize(System.Object)" /> has previously been called.</summary>
	/// <param name="obj">The object that a finalizer must be called for.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="obj" /> is <see langword="null" />.</exception>
	public static void ReRegisterForFinalize(object obj)
	{
	}

	/// <summary>Retrieves the number of bytes currently thought to be allocated. A parameter indicates whether this method can wait a short interval before returning, to allow the system to collect garbage and finalize objects.</summary>
	/// <param name="forceFullCollection">
	///   <see langword="true" /> to indicate that this method can wait for garbage collection to occur before returning; otherwise, <see langword="false" />.</param>
	/// <returns>A number that is the best available approximation of the number of bytes currently allocated in managed memory.</returns>
	public static long GetTotalMemory(bool forceFullCollection)
	{
		return 0L;
	}
}
