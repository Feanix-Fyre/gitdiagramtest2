using System;

namespace Unity.Collections;

[BurstCompatible]
internal struct NativeQueueBlockPoolData
{
	internal IntPtr m_FirstBlock;

	internal int m_NumBlocks;

	internal int m_MaxBlocks;

	internal const int m_BlockSize = 16384;

	internal int m_AllocLock;

	public unsafe NativeQueueBlockHeader* AllocateBlock()
	{
		return null;
	}

	public unsafe void FreeBlock(NativeQueueBlockHeader* block)
	{
	}
}
