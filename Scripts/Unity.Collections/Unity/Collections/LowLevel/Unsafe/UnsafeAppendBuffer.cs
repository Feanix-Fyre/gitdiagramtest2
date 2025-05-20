using System;
using System.Diagnostics;
using Unity.Jobs;

namespace Unity.Collections.LowLevel.Unsafe;

[BurstCompatible]
public struct UnsafeAppendBuffer : INativeDisposable, IDisposable
{
	[BurstCompatible]
	public struct Reader
	{
		public unsafe readonly byte* Ptr;

		public readonly int Size;

		public int Offset;

		public bool EndOfBuffer => false;

		public unsafe Reader(ref UnsafeAppendBuffer buffer)
		{
			Ptr = null;
			Size = 0;
			Offset = 0;
		}

		public unsafe Reader(void* ptr, int length)
		{
			Ptr = null;
			Size = 0;
			Offset = 0;
		}

		[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
		public void ReadNext<T>(out T value) where T : struct
		{
			value = default(T);
		}

		[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
		public T ReadNext<T>() where T : struct
		{
			return default(T);
		}

		public unsafe void* ReadNext(int structSize)
		{
			return null;
		}

		[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
		public void ReadNext<T>(out NativeArray<T> value, AllocatorManager.AllocatorHandle allocator) where T : struct
		{
			value = default(NativeArray<T>);
		}

		[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
		public unsafe void* ReadNextArray<T>(out int length) where T : struct
		{
			length = default(int);
			return null;
		}

		[Obsolete("Please use `ReadNextNBC` from `Unity.Collections.LowLevel.Unsafe.NotBurstCompatible` namespace instead. (RemovedAfter 2021-06-22)", false)]
		[NotBurstCompatible]
		public void ReadNext(out string value)
		{
			value = null;
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private void CheckBounds(int structSize)
		{
		}
	}

	[NativeDisableUnsafePtrRestriction]
	public unsafe byte* Ptr;

	public int Length;

	public int Capacity;

	public AllocatorManager.AllocatorHandle Allocator;

	public readonly int Alignment;

	public bool IsEmpty => false;

	public bool IsCreated => false;

	public unsafe UnsafeAppendBuffer(int initialCapacity, int alignment, AllocatorManager.AllocatorHandle allocator)
	{
		Ptr = null;
		Length = 0;
		Capacity = 0;
		Allocator = default(AllocatorManager.AllocatorHandle);
		Alignment = 0;
	}

	public unsafe UnsafeAppendBuffer(void* ptr, int length)
	{
		Ptr = null;
		Length = 0;
		Capacity = 0;
		Allocator = default(AllocatorManager.AllocatorHandle);
		Alignment = 0;
	}

	public void Dispose()
	{
	}

	[NotBurstCompatible]
	public JobHandle Dispose(JobHandle inputDeps)
	{
		return default(JobHandle);
	}

	public void Reset()
	{
	}

	public void SetCapacity(int capacity)
	{
	}

	public void ResizeUninitialized(int length)
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public void Add<T>(T value) where T : struct
	{
	}

	public unsafe void Add(void* ptr, int structSize)
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public unsafe void AddArray<T>(void* ptr, int length) where T : struct
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public void Add<T>(NativeArray<T> value) where T : struct
	{
	}

	[Obsolete("Please use `AddNBC` from `Unity.Collections.LowLevel.Unsafe.NotBurstCompatible` namespace instead. (RemovedAfter 2021-06-22)", false)]
	[NotBurstCompatible]
	public void Add(string value)
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public T Pop<T>() where T : struct
	{
		return default(T);
	}

	public unsafe void Pop(void* ptr, int structSize)
	{
	}

	[NotBurstCompatible]
	[Obsolete("Please use `ToBytesNBC` from `Unity.Collections.LowLevel.Unsafe.NotBurstCompatible` namespace instead. (RemovedAfter 2021-06-22)", false)]
	public byte[] ToBytes()
	{
		return null;
	}

	public Reader AsReader()
	{
		return default(Reader);
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CheckAlignment(int alignment)
	{
	}
}
