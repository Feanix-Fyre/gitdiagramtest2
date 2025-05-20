using System.Collections.Generic;

namespace UnityEngine.Rendering;

internal class ProbeBrickBlendingPool
{
	private static ComputeShader stateBlendShader;

	private static int scenarioBlendingKernel;

	private static readonly int _PoolDim_LerpFactor;

	private static readonly int _ChunkList;

	private static readonly int _State0_L0_L1Rx;

	private static readonly int _State0_L1G_L1Ry;

	private static readonly int _State0_L1B_L1Rz;

	private static readonly int _State0_L2_0;

	private static readonly int _State0_L2_1;

	private static readonly int _State0_L2_2;

	private static readonly int _State0_L2_3;

	private static readonly int _State1_L0_L1Rx;

	private static readonly int _State1_L1G_L1Ry;

	private static readonly int _State1_L1B_L1Rz;

	private static readonly int _State1_L2_0;

	private static readonly int _State1_L2_1;

	private static readonly int _State1_L2_2;

	private static readonly int _State1_L2_3;

	private static readonly int _Out_L0_L1Rx;

	private static readonly int _Out_L1G_L1Ry;

	private static readonly int _Out_L1B_L1Rz;

	private static readonly int _Out_L2_0;

	private static readonly int _Out_L2_1;

	private static readonly int _Out_L2_2;

	private static readonly int _Out_L2_3;

	private Vector4[] m_ChunkList;

	private int m_MappedChunks;

	private ProbeBrickPool m_State0;

	private ProbeBrickPool m_State1;

	private ProbeVolumeTextureMemoryBudget m_MemoryBudget;

	private ProbeVolumeSHBands m_ShBands;

	internal static bool isSupported => false;

	internal bool isAllocated => false;

	internal int estimatedVMemCost => 0;

	internal static void Initialize(in ProbeVolumeSystemParameters parameters)
	{
	}

	internal int GetPoolWidth()
	{
		return 0;
	}

	internal int GetPoolHeight()
	{
		return 0;
	}

	internal int GetPoolDepth()
	{
		return 0;
	}

	internal ProbeBrickBlendingPool(ProbeVolumeBlendingTextureMemoryBudget memoryBudget, ProbeVolumeSHBands shBands)
	{
	}

	internal void AllocateResourcesIfNeeded()
	{
	}

	internal void Update(ProbeBrickPool.DataLocation source, List<ProbeBrickPool.BrickChunkAlloc> srcLocations, List<ProbeBrickPool.BrickChunkAlloc> dstLocations, int destStartIndex, ProbeVolumeSHBands bands, int state)
	{
	}

	private static int DivRoundUp(int x, int y)
	{
		return 0;
	}

	internal void PerformBlending(CommandBuffer cmd, float factor, ProbeBrickPool dstPool)
	{
	}

	internal void BlendChunks(ProbeReferenceVolume.BlendingCellInfo blendingCell, ProbeBrickPool dstPool)
	{
	}

	internal void Clear()
	{
	}

	internal bool Allocate(int numberOfBrickChunks, List<ProbeBrickPool.BrickChunkAlloc> outAllocations)
	{
		return false;
	}

	internal void Deallocate(List<ProbeBrickPool.BrickChunkAlloc> allocations)
	{
	}

	internal void EnsureTextureValidity()
	{
	}

	internal void Cleanup()
	{
	}
}
