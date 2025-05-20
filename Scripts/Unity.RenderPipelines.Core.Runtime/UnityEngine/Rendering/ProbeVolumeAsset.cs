using System;
using Unity.Collections;

namespace UnityEngine.Rendering;

[PreferBinarySerialization]
internal class ProbeVolumeAsset : ScriptableObject
{
	[Serializable]
	internal enum AssetVersion
	{
		First = 0,
		AddProbeVolumesAtlasEncodingModes = 1,
		PV2 = 2,
		ChunkBasedIndex = 3,
		BinaryRuntimeDebugSplit = 4,
		BinaryTextureData = 5,
		Max = 6,
		Current = 5
	}

	[Serializable]
	internal struct CellCounts
	{
		public int bricksCount;

		public int probesCount;

		public int offsetsCount;

		public int chunksCount;

		public void Add(CellCounts o)
		{
		}
	}

	[SerializeField]
	protected internal int m_Version;

	[SerializeField]
	internal ProbeReferenceVolume.Cell[] cells;

	[SerializeField]
	internal CellCounts[] cellCounts;

	[SerializeField]
	internal CellCounts totalCellCounts;

	[SerializeField]
	internal Vector3Int maxCellPosition;

	[SerializeField]
	internal Vector3Int minCellPosition;

	[SerializeField]
	internal Bounds globalBounds;

	[SerializeField]
	internal ProbeVolumeSHBands bands;

	[SerializeField]
	internal int chunkSizeInBricks;

	[SerializeField]
	private string m_AssetFullPath;

	[SerializeField]
	internal int cellSizeInBricks;

	[SerializeField]
	internal int simplificationLevels;

	[SerializeField]
	internal float minDistanceBetweenProbes;

	public int Version => 0;

	internal int maxSubdivision => 0;

	internal float minBrickSize => 0f;

	internal bool CompatibleWith(ProbeVolumeAsset otherAsset)
	{
		return false;
	}

	internal bool IsInvalid()
	{
		return false;
	}

	public string GetSerializedFullPath()
	{
		return null;
	}

	private static int AlignUp16(int count)
	{
		return 0;
	}

	private NativeArray<T> GetSubArray<T>(NativeArray<byte> input, int count, ref int offset) where T : struct
	{
		return default(NativeArray<T>);
	}

	internal bool ResolveSharedCellData(TextAsset cellSharedDataAsset, TextAsset cellSupportDataAsset)
	{
		return false;
	}

	internal bool ResolvePerScenarioCellData(TextAsset cellDataAsset, TextAsset cellOptionalDataAsset, int stateIndex)
	{
		return false;
	}
}
