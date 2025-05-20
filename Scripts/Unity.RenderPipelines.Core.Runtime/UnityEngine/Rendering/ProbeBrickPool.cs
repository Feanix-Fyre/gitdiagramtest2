using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering;

internal class ProbeBrickPool
{
	[DebuggerDisplay("Chunk ({x}, {y}, {z})")]
	public struct BrickChunkAlloc
	{
		public int x;

		public int y;

		public int z;

		internal int flattenIndex(int sx, int sy)
		{
			return 0;
		}
	}

	public struct DataLocation
	{
		internal Texture TexL0_L1rx;

		internal Texture TexL1_G_ry;

		internal Texture TexL1_B_rz;

		internal Texture TexL2_0;

		internal Texture TexL2_1;

		internal Texture TexL2_2;

		internal Texture TexL2_3;

		internal Texture3D TexValidity;

		internal int width;

		internal int height;

		internal int depth;

		internal void Cleanup()
		{
		}
	}

	private const int kProbePoolChunkSizeInBricks = 128;

	internal const int kBrickCellCount = 3;

	internal const int kBrickProbeCountPerDim = 4;

	internal const int kBrickProbeCountTotal = 64;

	internal const int kChunkProbeCountPerDim = 512;

	private const int kMaxPoolWidth = 2048;

	internal DataLocation m_Pool;

	private BrickChunkAlloc m_NextFreeChunk;

	private Stack<BrickChunkAlloc> m_FreeList;

	private int m_AvailableChunkCount;

	private ProbeVolumeSHBands m_SHBands;

	private bool m_ContainsValidity;

	internal int estimatedVMemCost { get; private set; }

	internal ProbeBrickPool(ProbeVolumeTextureMemoryBudget memoryBudget, ProbeVolumeSHBands shBands, bool allocateValidityData = true)
	{
	}

	public int GetRemainingChunkCount()
	{
		return 0;
	}

	internal void EnsureTextureValidity()
	{
	}

	internal static int GetChunkSizeInBrickCount()
	{
		return 0;
	}

	internal static int GetChunkSizeInProbeCount()
	{
		return 0;
	}

	internal int GetPoolWidth()
	{
		return 0;
	}

	internal int GetPoolHeight()
	{
		return 0;
	}

	internal Vector3Int GetPoolDimensions()
	{
		return default(Vector3Int);
	}

	internal void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr)
	{
	}

	internal void Clear()
	{
	}

	internal static int GetChunkCount(int brickCount, int chunkSizeInBricks)
	{
		return 0;
	}

	internal bool Allocate(int numberOfBrickChunks, List<BrickChunkAlloc> outAllocations, bool ignoreErrorLog)
	{
		return false;
	}

	internal void Deallocate(List<BrickChunkAlloc> allocations)
	{
	}

	internal void Update(DataLocation source, List<BrickChunkAlloc> srcLocations, List<BrickChunkAlloc> dstLocations, int destStartIndex, ProbeVolumeSHBands bands)
	{
	}

	internal void UpdateValidity(DataLocation source, List<BrickChunkAlloc> srcLocations, List<BrickChunkAlloc> dstLocations, int destStartIndex)
	{
	}

	internal static Vector3Int ProbeCountToDataLocSize(int numProbes)
	{
		return default(Vector3Int);
	}

	public static Texture CreateDataTexture(int width, int height, int depth, GraphicsFormat format, string name, bool allocateRendertexture, ref int allocatedBytes)
	{
		return null;
	}

	public static DataLocation CreateDataLocation(int numProbes, bool compressed, ProbeVolumeSHBands bands, string name, bool allocateRendertexture, bool allocateValidityData, out int allocatedBytes)
	{
		allocatedBytes = default(int);
		return default(DataLocation);
	}

	private void DerivePoolSizeFromBudget(ProbeVolumeTextureMemoryBudget memoryBudget, out int width, out int height, out int depth)
	{
		width = default(int);
		height = default(int);
		depth = default(int);
	}

	internal void Cleanup()
	{
	}
}
