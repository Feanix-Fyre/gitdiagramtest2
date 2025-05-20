using System;
using System.Diagnostics;
using Unity.Jobs;

namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerTypeProxy(typeof(UnsafeRingQueueDebugView<>))]
[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
public struct UnsafeRingQueue<T> : INativeDisposable, IDisposable where T : unmanaged
{
	[NativeDisableUnsafePtrRestriction]
	public unsafe T* Ptr;

	public AllocatorManager.AllocatorHandle Allocator;

	internal RingControl Control;

	public bool IsEmpty => false;

	public int Length => 0;

	public int Capacity => 0;

	public bool IsCreated => false;

	public unsafe UnsafeRingQueue(T* ptr, int capacity)
	{
		Ptr = null;
		Allocator = default(AllocatorManager.AllocatorHandle);
		Control = default(RingControl);
	}

	public unsafe UnsafeRingQueue(int capacity, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory)
	{
		Ptr = null;
		Allocator = default(AllocatorManager.AllocatorHandle);
		Control = default(RingControl);
	}

	public void Dispose()
	{
	}

	[NotBurstCompatible]
	public JobHandle Dispose(JobHandle inputDeps)
	{
		return default(JobHandle);
	}

	public bool TryEnqueue(T value)
	{
		return false;
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void ThrowQueueFull()
	{
	}

	public void Enqueue(T value)
	{
	}

	public bool TryDequeue(out T item)
	{
		item = default(T);
		return false;
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void ThrowQueueEmpty()
	{
	}

	public T Dequeue()
	{
		return default(T);
	}
}
