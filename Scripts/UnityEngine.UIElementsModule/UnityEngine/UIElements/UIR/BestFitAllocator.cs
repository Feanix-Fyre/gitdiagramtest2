using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements.UIR;

internal class BestFitAllocator
{
	private class BlockPool : LinkedPool<Block>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Block CreateBlock()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void ResetBlock(Block block)
		{
		}

		public BlockPool()
			: base((Func<Block>)null, (Action<Block>)null, 0)
		{
		}
	}

	private class Block : LinkedPoolItem<Block>
	{
		public uint start;

		public uint end;

		public Block prev;

		public Block next;

		public Block prevAvailable;

		public Block nextAvailable;

		public bool allocated;

		public uint size => 0u;
	}

	private Block m_FirstBlock;

	private Block m_FirstAvailableBlock;

	private BlockPool m_BlockPool;

	private uint m_HighWatermark;

	public uint totalSize { get; }

	public uint highWatermark => 0u;

	public BestFitAllocator(uint size)
	{
	}

	public Alloc Allocate(uint size)
	{
		return default(Alloc);
	}

	public void Free(Alloc alloc)
	{
	}

	private Block CoalesceBlockWithPrevious(Block block)
	{
		return null;
	}

	private Block BestFitFindAvailableBlock(uint size)
	{
		return null;
	}

	private void SplitBlock(Block block, uint size)
	{
	}
}
