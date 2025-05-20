using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Unity.Collections;

namespace UnityEngine.Rendering;

public class ProbeReferenceVolume
{
	[Serializable]
	[DebuggerDisplay("Index = {index} position = {position}")]
	internal class Cell
	{
		public struct PerScenarioData
		{
			public NativeArray<ushort> shL0L1RxData { get; internal set; }

			public NativeArray<byte> shL1GL1RyData { get; internal set; }

			public NativeArray<byte> shL1BL1RzData { get; internal set; }

			public NativeArray<byte> shL2Data_0 { get; internal set; }

			public NativeArray<byte> shL2Data_1 { get; internal set; }

			public NativeArray<byte> shL2Data_2 { get; internal set; }

			public NativeArray<byte> shL2Data_3 { get; internal set; }
		}

		public Vector3Int position;

		public int index;

		public int probeCount;

		public int minSubdiv;

		public int maxSubdiv;

		public int indexChunkCount;

		public int shChunkCount;

		public bool hasTwoScenarios;

		public ProbeVolumeSHBands shBands;

		[NonSerialized]
		public PerScenarioData scenario0;

		[NonSerialized]
		public PerScenarioData scenario1;

		public NativeArray<ProbeBrickIndex.Brick> bricks { get; internal set; }

		public NativeArray<byte> validityNeighMaskData { get; internal set; }

		public NativeArray<Vector3> probePositions { get; internal set; }

		public NativeArray<float> touchupVolumeInteraction { get; internal set; }

		public NativeArray<Vector3> offsetVectors { get; internal set; }

		public NativeArray<float> validity { get; internal set; }

		public PerScenarioData bakingScenario => default(PerScenarioData);
	}

	[DebuggerDisplay("Index = {cell.index} Loaded = {loaded}")]
	internal class CellInfo : IComparable<CellInfo>
	{
		public Cell cell;

		public BlendingCellInfo blendingCell;

		public List<ProbeBrickPool.BrickChunkAlloc> chunkList;

		public int flatIdxInCellIndices;

		public bool loaded;

		public ProbeBrickIndex.CellIndexUpdateInfo updateInfo;

		public bool indexUpdated;

		public ProbeBrickIndex.CellIndexUpdateInfo tempUpdateInfo;

		public int sourceAssetInstanceID;

		public float streamingScore;

		public int referenceCount;

		public CellInstancedDebugProbes debugProbes;

		public int CompareTo(CellInfo other)
		{
			return 0;
		}

		public void Clear()
		{
		}
	}

	[DebuggerDisplay("Index = {cellInfo.cell.index} Factor = {blendingFactor} Score = {streamingScore}")]
	internal class BlendingCellInfo : IComparable<BlendingCellInfo>
	{
		public CellInfo cellInfo;

		public List<ProbeBrickPool.BrickChunkAlloc> chunkList;

		public float streamingScore;

		public float blendingFactor;

		public bool blending;

		public int CompareTo(BlendingCellInfo other)
		{
			return 0;
		}

		public void Clear()
		{
		}

		public void MarkUpToDate()
		{
		}

		public bool IsUpToDate()
		{
			return false;
		}

		public void ForceReupload()
		{
		}

		public bool ShouldReupload()
		{
			return false;
		}

		public void Prioritize()
		{
		}

		public bool ShouldPrioritize()
		{
			return false;
		}
	}

	internal struct Volume : IEquatable<Volume>
	{
		internal Vector3 corner;

		internal Vector3 X;

		internal Vector3 Y;

		internal Vector3 Z;

		internal float maxSubdivisionMultiplier;

		internal float minSubdivisionMultiplier;

		public Volume(Matrix4x4 trs, float maxSubdivision, float minSubdivision)
		{
			corner = default(Vector3);
			X = default(Vector3);
			Y = default(Vector3);
			Z = default(Vector3);
			maxSubdivisionMultiplier = 0f;
			minSubdivisionMultiplier = 0f;
		}

		public Volume(Vector3 corner, Vector3 X, Vector3 Y, Vector3 Z, float maxSubdivision = 1f, float minSubdivision = 0f)
		{
			this.corner = default(Vector3);
			this.X = default(Vector3);
			this.Y = default(Vector3);
			this.Z = default(Vector3);
			maxSubdivisionMultiplier = 0f;
			minSubdivisionMultiplier = 0f;
		}

		public Volume(Volume copy)
		{
			corner = default(Vector3);
			X = default(Vector3);
			Y = default(Vector3);
			Z = default(Vector3);
			maxSubdivisionMultiplier = 0f;
			minSubdivisionMultiplier = 0f;
		}

		public Volume(Bounds bounds)
		{
			corner = default(Vector3);
			X = default(Vector3);
			Y = default(Vector3);
			Z = default(Vector3);
			maxSubdivisionMultiplier = 0f;
			minSubdivisionMultiplier = 0f;
		}

		public Bounds CalculateAABB()
		{
			return default(Bounds);
		}

		public void CalculateCenterAndSize(out Vector3 center, out Vector3 size)
		{
			center = default(Vector3);
			size = default(Vector3);
		}

		public void Transform(Matrix4x4 trs)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public bool Equals(Volume other)
		{
			return false;
		}
	}

	internal struct RefVolTransform
	{
		public Vector3 posWS;

		public Quaternion rot;

		public float scale;
	}

	public struct RuntimeResources
	{
		public ComputeBuffer index;

		public ComputeBuffer cellIndices;

		public RenderTexture L0_L1rx;

		public RenderTexture L1_G_ry;

		public RenderTexture L1_B_rz;

		public RenderTexture L2_0;

		public RenderTexture L2_1;

		public RenderTexture L2_2;

		public RenderTexture L2_3;

		public Texture3D Validity;
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	public struct ExtraDataActionInput
	{
	}

	private struct InitInfo
	{
		public Vector3Int pendingMinCellPosition;

		public Vector3Int pendingMaxCellPosition;
	}

	internal class CellInstancedDebugProbes
	{
		public List<Matrix4x4[]> probeBuffers;

		public List<Matrix4x4[]> offsetBuffers;

		public List<MaterialPropertyBlock> props;
	}

	private bool m_IsInitialized;

	private bool m_SupportStreaming;

	private RefVolTransform m_Transform;

	private int m_MaxSubdivision;

	private ProbeBrickPool m_Pool;

	private ProbeBrickIndex m_Index;

	private ProbeCellIndices m_CellIndices;

	private ProbeBrickBlendingPool m_BlendingPool;

	private List<ProbeBrickPool.BrickChunkAlloc> m_TmpSrcChunks;

	private float[] m_PositionOffsets;

	private Bounds m_CurrGlobalBounds;

	internal Dictionary<int, CellInfo> cells;

	private ObjectPool<CellInfo> m_CellInfoPool;

	private ObjectPool<BlendingCellInfo> m_BlendingCellInfoPool;

	private ProbeBrickPool.DataLocation m_TemporaryDataLocation;

	private int m_TemporaryDataLocationMemCost;

	private int m_CurrentProbeVolumeChunkSizeInBricks;

	internal ProbeVolumeSceneData sceneData;

	private Vector3Int minLoadedCellPos;

	private Vector3Int maxLoadedCellPos;

	public Action<ExtraDataActionInput> retrieveExtraDataAction;

	public Action checksDuringBakeAction;

	private bool m_BricksLoaded;

	private Dictionary<string, ProbeVolumeAsset> m_PendingAssetsToBeLoaded;

	private Dictionary<string, ProbeVolumeAsset> m_PendingAssetsToBeUnloaded;

	private Dictionary<string, ProbeVolumeAsset> m_ActiveAssets;

	private bool m_NeedLoadAsset;

	private bool m_ProbeReferenceVolumeInit;

	private bool m_EnabledBySRP;

	private InitInfo m_PendingInitInfo;

	private bool m_NeedsIndexRebuild;

	private bool m_HasChangedIndex;

	private int m_CBShaderID;

	private int m_NumberOfCellsLoadedPerFrame;

	private int m_NumberOfCellsBlendedPerFrame;

	private float m_TurnoverRate;

	private ProbeVolumeTextureMemoryBudget m_MemoryBudget;

	private ProbeVolumeBlendingTextureMemoryBudget m_BlendingMemoryBudget;

	private ProbeVolumeSHBands m_SHBands;

	private float m_ProbeVolumesWeight;

	internal bool clearAssetsOnVolumeClear;

	internal static string defaultLightingScenario;

	private static ProbeReferenceVolume _instance;

	private const int kProbesPerBatch = 511;

	public static readonly string k_DebugPanelName;

	private DebugUI.Widget[] m_DebugItems;

	private Mesh m_DebugMesh;

	private Material m_DebugMaterial;

	private Mesh m_DebugOffsetMesh;

	private Material m_DebugOffsetMaterial;

	private Plane[] m_DebugFrustumPlanes;

	private GUIContent[] m_DebugScenarioNames;

	private int[] m_DebugScenarioValues;

	private string m_DebugActiveSceneGUID;

	private string m_DebugActiveScenario;

	private DebugUI.EnumField m_DebugScenarioField;

	internal ProbeVolumeBakingProcessSettings bakingProcessSettings;

	internal Dictionary<Bounds, ProbeBrickIndex.Brick[]> realtimeSubdivisionInfo;

	private bool m_MaxSubdivVisualizedIsMaxAvailable;

	private DynamicArray<CellInfo> m_LoadedCells;

	private DynamicArray<CellInfo> m_ToBeLoadedCells;

	private DynamicArray<CellInfo> m_TempCellToLoadList;

	private DynamicArray<CellInfo> m_TempCellToUnloadList;

	private DynamicArray<BlendingCellInfo> m_LoadedBlendingCells;

	private DynamicArray<BlendingCellInfo> m_ToBeLoadedBlendingCells;

	private DynamicArray<BlendingCellInfo> m_TempBlendingCellToLoadList;

	private DynamicArray<BlendingCellInfo> m_TempBlendingCellToUnloadList;

	private Vector3 m_FrozenCameraPosition;

	private bool m_HasRemainingCellsToBlend;

	internal Bounds globalBounds
	{
		get
		{
			return default(Bounds);
		}
		set
		{
		}
	}

	public bool isInitialized => false;

	internal bool enabledBySRP => false;

	internal bool hasUnloadedCells => false;

	internal bool enableScenarioBlending => false;

	internal int numberOfCellsLoadedPerFrame => 0;

	public int numberOfCellsBlendedPerFrame
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float turnoverRate
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public ProbeVolumeSHBands shBands => default(ProbeVolumeSHBands);

	public string lightingScenario
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float scenarioBlendingFactor
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public ProbeVolumeTextureMemoryBudget memoryBudget => default(ProbeVolumeTextureMemoryBudget);

	public float probeVolumesWeight
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	internal List<ProbeVolumePerSceneData> perSceneDataList { get; private set; }

	public static ProbeReferenceVolume instance => null;

	internal ProbeVolumeDebug probeVolumeDebug { get; }

	public Color[] subdivisionDebugColors { get; }

	public void BlendLightingScenario(string otherScenario, float blendingFactor)
	{
	}

	internal void RegisterPerSceneData(ProbeVolumePerSceneData data)
	{
	}

	internal void UnregisterPerSceneData(ProbeVolumePerSceneData data)
	{
	}

	public void Initialize(in ProbeVolumeSystemParameters parameters)
	{
	}

	public void SetEnableStateFromSRP(bool srpEnablesPV)
	{
	}

	internal void ForceSHBand(ProbeVolumeSHBands shBands)
	{
	}

	public void Cleanup()
	{
	}

	public int GetVideoMemoryCost()
	{
		return 0;
	}

	private void RemoveCell(Cell cell)
	{
	}

	internal void UnloadCell(CellInfo cellInfo)
	{
	}

	internal void UnloadBlendingCell(BlendingCellInfo blendingCell)
	{
	}

	internal void UnloadAllCells()
	{
	}

	internal void UnloadAllBlendingCells()
	{
	}

	private void AddCell(Cell cell, int assetInstanceID)
	{
	}

	internal bool LoadCell(CellInfo cellInfo, bool ignoreErrorLog = false)
	{
		return false;
	}

	internal void LoadAllCells()
	{
	}

	private void RecomputeMinMaxLoadedCellPos()
	{
	}

	private bool CheckCompatibilityWithCollection(ProbeVolumeAsset asset, Dictionary<string, ProbeVolumeAsset> collection)
	{
		return false;
	}

	internal void AddPendingAssetLoading(ProbeVolumeAsset asset)
	{
	}

	internal void AddPendingAssetRemoval(ProbeVolumeAsset asset)
	{
	}

	internal void RemovePendingAsset(ProbeVolumeAsset asset)
	{
	}

	private void PerformPendingIndexChangeAndInit()
	{
	}

	internal void SetMinBrickAndMaxSubdiv(float minBrickSize, int maxSubdiv)
	{
	}

	private void LoadAsset(ProbeVolumeAsset asset)
	{
	}

	private void PerformPendingLoading()
	{
	}

	private void PerformPendingDeletion()
	{
	}

	internal int GetNumberOfBricksAtSubdiv(Vector3Int position, int minSubdiv, out Vector3Int minValidLocalIdxAtMaxRes, out Vector3Int sizeOfValidIndicesAtMaxRes)
	{
		minValidLocalIdxAtMaxRes = default(Vector3Int);
		sizeOfValidIndicesAtMaxRes = default(Vector3Int);
		return 0;
	}

	private bool GetCellIndexUpdate(Cell cell, out ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo, bool ignoreErrorLog)
	{
		cellUpdateInfo = default(ProbeBrickIndex.CellIndexUpdateInfo);
		return false;
	}

	public void PerformPendingOperations()
	{
	}

	private void InitProbeReferenceVolume(ProbeVolumeTextureMemoryBudget memoryBudget, ProbeVolumeBlendingTextureMemoryBudget blendingMemoryBudget, ProbeVolumeSHBands shBands)
	{
	}

	private void AllocateTemporaryDataLocation()
	{
	}

	private ProbeReferenceVolume()
	{
	}

	public RuntimeResources GetRuntimeResources()
	{
		return default(RuntimeResources);
	}

	internal void SetTRS(Vector3 position, Quaternion rotation, float minBrickSize)
	{
	}

	internal void SetMaxSubdivision(int maxSubdivision)
	{
	}

	internal static int CellSize(int subdivisionLevel)
	{
		return 0;
	}

	internal float BrickSize(int subdivisionLevel)
	{
		return 0f;
	}

	internal float MinBrickSize()
	{
		return 0f;
	}

	internal float MaxBrickSize()
	{
		return 0f;
	}

	internal RefVolTransform GetTransform()
	{
		return default(RefVolTransform);
	}

	internal int GetMaxSubdivision()
	{
		return 0;
	}

	internal int GetMaxSubdivision(float multiplier)
	{
		return 0;
	}

	internal float GetDistanceBetweenProbes(int subdivisionLevel)
	{
		return 0f;
	}

	internal float MinDistanceBetweenProbes()
	{
		return 0f;
	}

	public bool DataHasBeenLoaded()
	{
		return false;
	}

	internal void Clear()
	{
	}

	private List<ProbeBrickPool.BrickChunkAlloc> GetSourceLocations(int count, int chunkSize, ProbeBrickPool.DataLocation dataLoc)
	{
		return null;
	}

	private void UpdatePool(List<ProbeBrickPool.BrickChunkAlloc> chunkList, Cell.PerScenarioData data, NativeArray<byte> validityNeighMaskData, int chunkIndex, int poolIndex)
	{
	}

	private void UpdatePoolValidity(List<ProbeBrickPool.BrickChunkAlloc> chunkList, Cell.PerScenarioData data, NativeArray<byte> validityNeighMaskData, int chunkIndex)
	{
	}

	private bool AddBlendingBricks(BlendingCellInfo blendingCell)
	{
		return false;
	}

	private bool AddBricks(CellInfo cellInfo, ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo, bool ignoreErrorLog)
	{
		return false;
	}

	private void UpdateCellIndex(CellInfo cellInfo)
	{
	}

	private void ReleaseBricks(CellInfo cellInfo)
	{
	}

	public void UpdateConstantBuffer(CommandBuffer cmd, ProbeVolumeShadingParameters parameters)
	{
	}

	private void CleanupLoadedData()
	{
	}

	public void RenderDebug(Camera camera)
	{
	}

	private void InitializeDebug(in ProbeVolumeSystemParameters parameters)
	{
	}

	private void CleanupDebug()
	{
	}

	private void DebugCellIndexChanged<T>(DebugUI.Field<T> field, T value)
	{
	}

	private void RegisterDebug(ProbeVolumeSystemParameters parameters)
	{
	}

	private void UnregisterDebug(bool destroyPanel)
	{
	}

	private bool ShouldCullCell(Vector3 cellPosition, Transform cameraTransform, Plane[] frustumPlanes)
	{
		return false;
	}

	private void DrawProbeDebug(Camera camera)
	{
	}

	internal void ResetDebugViewToMaxSubdiv()
	{
	}

	private void ClearDebugData()
	{
	}

	private CellInstancedDebugProbes CreateInstancedProbes(CellInfo cellInfo)
	{
		return null;
	}

	private void OnClearLightingdata()
	{
	}

	internal void ScenarioBlendingChanged(bool scenarioChanged)
	{
	}

	public void SetNumberOfCellsLoadedPerFrame(int numberOfCells)
	{
	}

	private void ComputeCellCameraDistance(Vector3 cameraPosition, DynamicArray<CellInfo> cells)
	{
	}

	private void ComputeStreamingScoreForBlending(DynamicArray<BlendingCellInfo> cells, float worstScore)
	{
	}

	private bool TryLoadCell(CellInfo cellInfo, ref int shBudget, ref int indexBudget, DynamicArray<CellInfo> loadedCells)
	{
		return false;
	}

	private void UnloadBlendingCell(BlendingCellInfo blendingCell, DynamicArray<BlendingCellInfo> unloadedCells)
	{
	}

	private bool TryLoadBlendingCell(BlendingCellInfo blendingCell, DynamicArray<BlendingCellInfo> loadedCells)
	{
		return false;
	}

	public void UpdateCellStreaming(CommandBuffer cmd, Camera camera)
	{
	}

	private int FindWorstBlendingCellToBeLoaded()
	{
		return 0;
	}

	private void UpdateBlendingCellStreaming(CommandBuffer cmd)
	{
	}
}
