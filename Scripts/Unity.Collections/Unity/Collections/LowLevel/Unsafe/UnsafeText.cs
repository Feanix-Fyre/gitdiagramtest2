using System;
using System.Diagnostics;
using Unity.Jobs;

namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
[BurstCompatible]
public struct UnsafeText : INativeDisposable, IDisposable, IUTF8Bytes, INativeList<byte>, IIndexable<byte>
{
	internal UntypedUnsafeList m_UntypedListData;

	public bool IsCreated => false;

	public bool IsEmpty => false;

	public byte this[int index]
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Capacity
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Length
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public UnsafeText(int capacity, AllocatorManager.AllocatorHandle allocator)
	{
		m_UntypedListData = default(UntypedUnsafeList);
	}

	public void Dispose()
	{
	}

	[NotBurstCompatible]
	public JobHandle Dispose(JobHandle inputDeps)
	{
		return default(JobHandle);
	}

	public ref byte ElementAt(int index)
	{
		throw null;
	}

	public void Clear()
	{
	}

	public unsafe byte* GetUnsafePtr()
	{
		return null;
	}

	public bool TryResize(int newLength, NativeArrayOptions clearOptions = NativeArrayOptions.ClearMemory)
	{
		return false;
	}

	[NotBurstCompatible]
	public override string ToString()
	{
		return null;
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CheckIndexInRange(int index)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void ThrowCopyError(CopyError error, string source)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CheckCapacityInRange(int value, int length)
	{
	}
}
