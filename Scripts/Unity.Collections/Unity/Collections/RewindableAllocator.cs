using System;
using System.Runtime.CompilerServices;
using AOT;
using Unity.Burst;

namespace Unity.Collections;

[BurstCompile]
public struct RewindableAllocator : AllocatorManager.IAllocator, IDisposable
{
	[BurstCompatible]
	internal struct MemoryBlock : IDisposable
	{
		public const int kMaximumAlignment = 16384;

		public unsafe byte* m_pointer;

		public long m_bytes;

		public long m_current;

		public long m_allocations;

		public unsafe MemoryBlock(long bytes)
		{
			m_pointer = null;
			m_bytes = 0L;
			m_current = 0L;
			m_allocations = 0L;
		}

		public void Rewind()
		{
		}

		public void Dispose()
		{
		}

		public int TryAllocate(ref AllocatorManager.Block block)
		{
			return 0;
		}

		public bool Contains(IntPtr ptr)
		{
			return false;
		}
	}

	public delegate int Try_000008B3_0024PostfixBurstDelegate(IntPtr state, ref AllocatorManager.Block block);

	internal static class Try_000008B3_0024BurstDirectCall
	{
		private static IntPtr Pointer;

		private static IntPtr DeferredCompilation;

		[BurstDiscard]
		private static void GetFunctionPointerDiscard(ref IntPtr P_0)
		{
		}

		private static IntPtr GetFunctionPointer()
		{
			return (IntPtr)0;
		}

		public static void Constructor()
		{
		}

		public static void Initialize()
		{
		}

		public static int Invoke(IntPtr state, ref AllocatorManager.Block block)
		{
			return 0;
		}
	}

	private Spinner m_spinner;

	private AllocatorManager.AllocatorHandle m_handle;

	private UnmanagedArray<MemoryBlock> m_block;

	private int m_best;

	private int m_last;

	private int m_used;

	private bool m_enableBlockFree;

	public bool EnableBlockFree
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int BlocksAllocated => 0;

	public int InitialSizeInBytes => 0;

	[NotBurstCompatible]
	public AllocatorManager.TryFunction Function => null;

	public AllocatorManager.AllocatorHandle Handle
	{
		get
		{
			return default(AllocatorManager.AllocatorHandle);
		}
		set
		{
		}
	}

	public Allocator ToAllocator => default(Allocator);

	public bool IsCustomAllocator => false;

	public void Initialize(int initialSizeInBytes, bool enableBlockFree = false)
	{
	}

	public void Rewind()
	{
	}

	public void Dispose()
	{
	}

	public int Try(ref AllocatorManager.Block block)
	{
		return 0;
	}

	[MonoPInvokeCallback(typeof(AllocatorManager.TryFunction))]
	[BurstCompile]
	internal static int Try(IntPtr state, ref AllocatorManager.Block block)
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public NativeArray<T> AllocateNativeArray<T>(int length) where T : struct
	{
		return default(NativeArray<T>);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public NativeList<T> AllocateNativeList<T>(int capacity) where T : struct
	{
		return default(NativeList<T>);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[MonoPInvokeCallback(typeof(AllocatorManager.TryFunction))]
	[BurstCompile]
	public static int Try_0024BurstManaged(IntPtr state, ref AllocatorManager.Block block)
	{
		return 0;
	}
}
