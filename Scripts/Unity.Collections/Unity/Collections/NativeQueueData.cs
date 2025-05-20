using System;
using System.Runtime.CompilerServices;

namespace Unity.Collections;

[BurstCompatible]
internal struct NativeQueueData
{
	public IntPtr m_FirstBlock;

	public IntPtr m_LastBlock;

	public int m_MaxItems;

	public int m_CurrentRead;

	public unsafe byte* m_CurrentWriteBlockTLS;

	internal unsafe NativeQueueBlockHeader* GetCurrentWriteBlockTLS(int threadIndex)
	{
		return null;
	}

	internal unsafe void SetCurrentWriteBlockTLS(int threadIndex, NativeQueueBlockHeader* currentWriteBlock)
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public unsafe static NativeQueueBlockHeader* AllocateWriteBlockMT<T>(NativeQueueData* data, NativeQueueBlockPoolData* pool, int threadIndex) where T : struct
	{
		return null;
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public unsafe static void AllocateQueue<T>(AllocatorManager.AllocatorHandle label, out NativeQueueData* outBuf) where T : struct
	{
		System.Runtime.CompilerServices.Unsafe.As<NativeQueueData*, @null>(ref outBuf) = null;
	}

	public unsafe static void DeallocateQueue(NativeQueueData* data, NativeQueueBlockPoolData* pool, AllocatorManager.AllocatorHandle allocation)
	{
	}
}
