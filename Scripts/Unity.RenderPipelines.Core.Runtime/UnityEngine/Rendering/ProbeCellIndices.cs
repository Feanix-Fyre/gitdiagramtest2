namespace UnityEngine.Rendering;

internal class ProbeCellIndices
{
	internal struct IndexMetaData
	{
		private static uint[] s_PackedValues;

		internal Vector3Int minLocalIdx;

		internal Vector3Int maxLocalIdx;

		internal int firstChunkIndex;

		internal int minSubdiv;

		internal void Pack(out uint[] vals)
		{
			vals = null;
		}
	}

	private const int kUintPerEntry = 3;

	private ComputeBuffer m_IndexOfIndicesBuffer;

	private uint[] m_IndexOfIndicesData;

	private Vector3Int m_CellCount;

	private Vector3Int m_CellMin;

	private int m_CellSizeInMinBricks;

	private bool m_NeedUpdateComputeBuffer;

	internal int estimatedVMemCost { get; private set; }

	internal Vector3Int GetCellIndexDimension()
	{
		return default(Vector3Int);
	}

	internal Vector3Int GetCellMinPosition()
	{
		return default(Vector3Int);
	}

	private int GetFlatIndex(Vector3Int normalizedPos)
	{
		return 0;
	}

	internal ProbeCellIndices(Vector3Int cellMin, Vector3Int cellMax, int cellSizeInMinBricks)
	{
	}

	internal int GetFlatIdxForCell(Vector3Int cellPosition)
	{
		return 0;
	}

	internal void UpdateCell(int cellFlatIdx, ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo)
	{
	}

	internal void MarkCellAsUnloaded(int cellFlatIdx)
	{
	}

	internal void PushComputeData()
	{
	}

	internal void GetRuntimeResources(ref ProbeReferenceVolume.RuntimeResources rr)
	{
	}

	internal void Cleanup()
	{
	}
}
