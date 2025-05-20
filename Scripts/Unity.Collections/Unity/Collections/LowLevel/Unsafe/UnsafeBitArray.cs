using System;
using System.Diagnostics;
using Unity.Jobs;

namespace Unity.Collections.LowLevel.Unsafe;

[BurstCompatible]
[DebuggerTypeProxy(typeof(UnsafeBitArrayDebugView))]
[DebuggerDisplay("Length = {Length}, IsCreated = {IsCreated}")]
public struct UnsafeBitArray : INativeDisposable, IDisposable
{
	[NativeDisableUnsafePtrRestriction]
	public unsafe ulong* Ptr;

	public int Length;

	public AllocatorManager.AllocatorHandle Allocator;

	public bool IsCreated => false;

	public unsafe UnsafeBitArray(void* ptr, int sizeInBytes, AllocatorManager.AllocatorHandle allocator = default(AllocatorManager.AllocatorHandle))
	{
		Ptr = null;
		Length = 0;
		Allocator = default(AllocatorManager.AllocatorHandle);
	}

	public unsafe UnsafeBitArray(int numBits, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory)
	{
		Ptr = null;
		Length = 0;
		Allocator = default(AllocatorManager.AllocatorHandle);
	}

	public void Dispose()
	{
	}

	[NotBurstCompatible]
	public JobHandle Dispose(JobHandle inputDeps)
	{
		return default(JobHandle);
	}

	public void Clear()
	{
	}

	public void Set(int pos, bool value)
	{
	}

	public void SetBits(int pos, bool value, int numBits)
	{
	}

	public void SetBits(int pos, ulong value, int numBits = 1)
	{
	}

	public ulong GetBits(int pos, int numBits = 1)
	{
		return 0uL;
	}

	public bool IsSet(int pos)
	{
		return false;
	}

	internal void CopyUlong(int dstPos, ref UnsafeBitArray srcBitArray, int srcPos, int numBits)
	{
	}

	public void Copy(int dstPos, int srcPos, int numBits)
	{
	}

	public void Copy(int dstPos, ref UnsafeBitArray srcBitArray, int srcPos, int numBits)
	{
	}

	public int Find(int pos, int numBits)
	{
		return 0;
	}

	public int Find(int pos, int count, int numBits)
	{
		return 0;
	}

	public bool TestNone(int pos, int numBits = 1)
	{
		return false;
	}

	public bool TestAny(int pos, int numBits = 1)
	{
		return false;
	}

	public bool TestAll(int pos, int numBits = 1)
	{
		return false;
	}

	public int CountBits(int pos, int numBits = 1)
	{
		return 0;
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CheckSizeMultipleOf8(int sizeInBytes)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CheckArgs(int pos, int numBits)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CheckArgsPosCount(int begin, int count, int numBits)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CheckArgsUlong(int pos, int numBits)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CheckArgsCopy(ref UnsafeBitArray dstBitArray, int dstPos, ref UnsafeBitArray srcBitArray, int srcPos, int numBits)
	{
	}
}
