using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.Collections;

namespace UnityEngine.Rendering;

internal class ProbeBrickIndex
{
	[Serializable]
	[DebuggerDisplay("Brick [{position}, {subdivisionLevel}]")]
	public struct Brick : IEquatable<Brick>
	{
		public Vector3Int position;

		public int subdivisionLevel;

		internal Brick(Vector3Int position, int subdivisionLevel)
		{
			this.position = default(Vector3Int);
			this.subdivisionLevel = 0;
		}

		public bool Equals(Brick other)
		{
			return false;
		}
	}

	[DebuggerDisplay("Brick [{brick.position}, {brick.subdivisionLevel}], {flattenedIdx}")]
	private struct ReservedBrick
	{
		public Brick brick;

		public int flattenedIdx;
	}

	private class VoxelMeta
	{
		public ProbeReferenceVolume.Cell cell;

		public List<ushort> brickIndices;

		public void Clear()
		{
		}
	}

	private class BrickMeta
	{
		public HashSet<Vector3Int> voxels;

		public List<ReservedBrick> bricks;

		public void Clear()
		{
		}
	}

	public struct CellIndexUpdateInfo
	{
		public int firstChunkIndex;

		public int numberOfChunks;

		public int minSubdivInCell;

		public Vector3Int minValidBrickIndexForCellAtMaxRes;

		public Vector3Int maxValidBrickIndexForCellAtMaxResPlusOne;

		public Vector3Int cellPositionInBricksAtMaxRes;
	}

	internal const int kMaxSubdivisionLevels = 7;

	internal const int kIndexChunkSize = 243;

	private BitArray m_IndexChunks;

	private int m_IndexInChunks;

	private int m_NextFreeChunk;

	private int m_AvailableChunkCount;

	private ComputeBuffer m_PhysicalIndexBuffer;

	private int[] m_PhysicalIndexBufferData;

	private Vector3Int m_CenterRS;

	private Dictionary<Vector3Int, List<VoxelMeta>> m_VoxelToBricks;

	private Dictionary<ProbeReferenceVolume.Cell, BrickMeta> m_BricksToVoxels;

	private ObjectPool<BrickMeta> m_BrickMetaPool;

	private ObjectPool<List<VoxelMeta>> m_VoxelMetaListPool;

	private ObjectPool<VoxelMeta> m_VoxelMetaPool;

	private bool m_NeedUpdateIndexComputeBuffer;

	private int m_UpdateMinIndex;

	private int m_UpdateMaxIndex;

	private static ProbeReferenceVolume.Cell g_Cell;

	internal int estimatedVMemCost { get; private set; }

	private int GetVoxelSubdivLevel()
	{
		return 0;
	}

	private int SizeOfPhysicalIndexFromBudget(ProbeVolumeTextureMemoryBudget memoryBudget)
	{
		return 0;
	}

	internal ProbeBrickIndex(ProbeVolumeTextureMemoryBudget memoryBudget)
	{
	}

	public int GetRemainingChunkCount()
	{
		return 0;
	}

	internal void UploadIndexData()
	{
	}

	internal void Clear()
	{
	}

	private void MapBrickToVoxels(Brick brick, HashSet<Vector3Int> voxels)
	{
	}

	private void ClearVoxel(Vector3Int pos, CellIndexUpdateInfo cellInfo)
	{
	}

	internal void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr)
	{
	}

	internal void Cleanup()
	{
	}

	private int MergeIndex(int index, int size)
	{
		return 0;
	}

	internal bool AssignIndexChunksToCell(int bricksCount, ref CellIndexUpdateInfo cellUpdateInfo, bool ignoreErrorLog)
	{
		return false;
	}

	public void AddBricks(ProbeReferenceVolume.Cell cell, NativeArray<Brick> bricks, List<ProbeBrickPool.BrickChunkAlloc> allocations, int allocationSize, int poolWidth, int poolHeight, CellIndexUpdateInfo cellInfo)
	{
	}

	public void RemoveBricks(ProbeReferenceVolume.CellInfo cellInfo)
	{
	}

	private void UpdateIndexForVoxel(Vector3Int voxel, CellIndexUpdateInfo cellInfo)
	{
	}

	private void UpdatePhysicalIndex(Vector3Int brickMin, Vector3Int brickMax, int value, CellIndexUpdateInfo cellInfo)
	{
	}

	private void ClipToIndexSpace(Vector3Int pos, int subdiv, out Vector3Int outMinpos, out Vector3Int outMaxpos, CellIndexUpdateInfo cellInfo)
	{
		outMinpos = default(Vector3Int);
		outMaxpos = default(Vector3Int);
	}

	private void UpdateIndexForVoxel(Vector3Int voxel, List<ReservedBrick> bricks, List<ushort> indices, CellIndexUpdateInfo cellInfo)
	{
	}
}
