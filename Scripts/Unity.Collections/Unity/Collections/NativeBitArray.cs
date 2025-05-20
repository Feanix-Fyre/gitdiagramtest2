using System;
using System.Diagnostics;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace Unity.Collections;

[NativeContainer]
[DebuggerDisplay("Length = {Length}, IsCreated = {IsCreated}")]
[BurstCompatible]
public struct NativeBitArray : INativeDisposable, IDisposable
{
	[NativeDisableUnsafePtrRestriction]
	internal UnsafeBitArray m_BitArray;

	public bool IsCreated => false;

	public int Length => 0;

	public NativeBitArray(int numBits, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory)
	{
		m_BitArray = default(UnsafeBitArray);
	}

	private NativeBitArray(int numBits, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options, int disposeSentinelStackDepth)
	{
		m_BitArray = default(UnsafeBitArray);
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

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public NativeArray<T> AsNativeArray<T>() where T : struct
	{
		return default(NativeArray<T>);
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

	public void Copy(int dstPos, int srcPos, int numBits)
	{
	}

	public void Copy(int dstPos, ref NativeBitArray srcBitArray, int srcPos, int numBits)
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
	private void CheckRead()
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CheckReadBounds<T>() where T : struct
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CheckWrite()
	{
	}
}
