using System;
using Unity.Burst;
using Unity.Jobs;

namespace Unity.Collections.LowLevel.Unsafe;

[BurstCompatible]
public struct UnsafeStream : INativeDisposable, IDisposable
{
	[BurstCompile]
	private struct DisposeJob : IJob
	{
		public UnsafeStream Container;

		public void Execute()
		{
		}
	}

	[BurstCompile]
	private struct ConstructJobList : IJob
	{
		public UnsafeStream Container;

		[ReadOnly]
		[NativeDisableUnsafePtrRestriction]
		public unsafe UntypedUnsafeList* List;

		public void Execute()
		{
		}
	}

	[BurstCompile]
	private struct ConstructJob : IJob
	{
		public UnsafeStream Container;

		[ReadOnly]
		public NativeArray<int> Length;

		public void Execute()
		{
		}
	}

	[BurstCompatible]
	public struct Writer
	{
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeStreamBlockData* m_BlockStream;

		[NativeDisableUnsafePtrRestriction]
		private unsafe UnsafeStreamBlock* m_CurrentBlock;

		[NativeDisableUnsafePtrRestriction]
		private unsafe byte* m_CurrentPtr;

		[NativeDisableUnsafePtrRestriction]
		private unsafe byte* m_CurrentBlockEnd;

		internal int m_ForeachIndex;

		private int m_ElementCount;

		[NativeDisableUnsafePtrRestriction]
		private unsafe UnsafeStreamBlock* m_FirstBlock;

		private int m_FirstOffset;

		private int m_NumberOfBlocks;

		[NativeSetThreadIndex]
		private int m_ThreadIndex;

		public int ForEachCount => 0;

		internal unsafe Writer(ref UnsafeStream stream)
		{
			m_BlockStream = null;
			m_CurrentBlock = null;
			m_CurrentPtr = null;
			m_CurrentBlockEnd = null;
			m_ForeachIndex = 0;
			m_ElementCount = 0;
			m_FirstBlock = null;
			m_FirstOffset = 0;
			m_NumberOfBlocks = 0;
			m_ThreadIndex = 0;
		}

		public void BeginForEachIndex(int foreachIndex)
		{
		}

		public void EndForEachIndex()
		{
		}

		[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
		public void Write<T>(T value) where T : struct
		{
		}

		[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
		public ref T Allocate<T>() where T : struct
		{
			throw null;
		}

		public unsafe byte* Allocate(int size)
		{
			return null;
		}
	}

	[BurstCompatible]
	public struct Reader
	{
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeStreamBlockData* m_BlockStream;

		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeStreamBlock* m_CurrentBlock;

		[NativeDisableUnsafePtrRestriction]
		internal unsafe byte* m_CurrentPtr;

		[NativeDisableUnsafePtrRestriction]
		internal unsafe byte* m_CurrentBlockEnd;

		internal int m_RemainingItemCount;

		internal int m_LastBlockSize;

		public int ForEachCount => 0;

		public int RemainingItemCount => 0;

		internal unsafe Reader(ref UnsafeStream stream)
		{
			m_BlockStream = null;
			m_CurrentBlock = null;
			m_CurrentPtr = null;
			m_CurrentBlockEnd = null;
			m_RemainingItemCount = 0;
			m_LastBlockSize = 0;
		}

		public int BeginForEachIndex(int foreachIndex)
		{
			return 0;
		}

		public void EndForEachIndex()
		{
		}

		public unsafe byte* ReadUnsafePtr(int size)
		{
			return null;
		}

		[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
		public ref T Read<T>() where T : struct
		{
			throw null;
		}

		[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
		public ref T Peek<T>() where T : struct
		{
			throw null;
		}

		public int Count()
		{
			return 0;
		}
	}

	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeStreamBlockData* m_Block;

	internal AllocatorManager.AllocatorHandle m_Allocator;

	public bool IsCreated => false;

	public int ForEachCount => 0;

	public unsafe UnsafeStream(int bufferCount, AllocatorManager.AllocatorHandle allocator)
	{
		m_Block = null;
		m_Allocator = default(AllocatorManager.AllocatorHandle);
	}

	[NotBurstCompatible]
	public static JobHandle ScheduleConstruct<T>(out UnsafeStream stream, NativeList<T> bufferCount, JobHandle dependency, AllocatorManager.AllocatorHandle allocator) where T : struct
	{
		stream = default(UnsafeStream);
		return default(JobHandle);
	}

	[NotBurstCompatible]
	public static JobHandle ScheduleConstruct(out UnsafeStream stream, NativeArray<int> bufferCount, JobHandle dependency, AllocatorManager.AllocatorHandle allocator)
	{
		stream = default(UnsafeStream);
		return default(JobHandle);
	}

	internal static void AllocateBlock(out UnsafeStream stream, AllocatorManager.AllocatorHandle allocator)
	{
		stream = default(UnsafeStream);
	}

	internal void AllocateForEach(int forEachCount)
	{
	}

	public bool IsEmpty()
	{
		return false;
	}

	public Reader AsReader()
	{
		return default(Reader);
	}

	public Writer AsWriter()
	{
		return default(Writer);
	}

	public int Count()
	{
		return 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public NativeArray<T> ToNativeArray<T>(AllocatorManager.AllocatorHandle allocator) where T : struct
	{
		return default(NativeArray<T>);
	}

	private void Deallocate()
	{
	}

	public void Dispose()
	{
	}

	[NotBurstCompatible]
	public JobHandle Dispose(JobHandle inputDeps)
	{
		return default(JobHandle);
	}
}
