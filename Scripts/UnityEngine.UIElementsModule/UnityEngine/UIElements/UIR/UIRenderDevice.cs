using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR;

internal class UIRenderDevice : IDisposable
{
	internal struct AllocToUpdate
	{
		public uint id;

		public uint allocTime;

		public MeshHandle meshHandle;

		public Alloc permAllocVerts;

		public Alloc permAllocIndices;

		public Page permPage;

		public bool copyBackIndices;
	}

	private struct AllocToFree
	{
		public Alloc alloc;

		public Page page;

		public bool vertices;
	}

	private struct DeviceToFree
	{
		public uint handle;

		public Page page;

		public void Dispose()
		{
		}
	}

	private struct EvaluationState
	{
		public MaterialPropertyBlock stateMatProps;

		public Material defaultMat;

		public State curState;

		public Page curPage;

		public bool mustApplyMaterial;

		public bool mustApplyCommonBlock;

		public bool mustApplyStateBlock;

		public bool mustApplyStencil;
	}

	internal struct DrawStatistics
	{
		public int currentFrameIndex;

		public uint totalIndices;

		public uint commandCount;

		public uint drawCommandCount;

		public uint materialSetCount;

		public uint drawRangeCount;

		public uint drawRangeCallCount;

		public uint immediateDraws;

		public uint stencilRefChanges;
	}

	private readonly bool m_MockDevice;

	private IntPtr m_DefaultStencilState;

	private IntPtr m_VertexDecl;

	private Page m_FirstPage;

	private uint m_NextPageVertexCount;

	private uint m_LargeMeshVertexCount;

	private float m_IndexToVertexCountRatio;

	private List<List<AllocToFree>> m_DeferredFrees;

	private List<List<AllocToUpdate>> m_Updates;

	private uint[] m_Fences;

	private MaterialPropertyBlock m_StandardMatProps;

	private uint m_FrameIndex;

	private uint m_NextUpdateID;

	private DrawStatistics m_DrawStats;

	private readonly LinkedPool<MeshHandle> m_MeshHandles;

	private readonly DrawParams m_DrawParams;

	private readonly TextureSlotManager m_TextureSlotManager;

	private static LinkedList<DeviceToFree> m_DeviceFreeQueue;

	private static int m_ActiveDeviceCount;

	private static bool m_SubscribedToNotifications;

	private static bool m_SynchronousFree;

	private static readonly int s_GradientSettingsTexID;

	private static readonly int s_ShaderInfoTexID;

	private static readonly int s_TransformsPropID;

	private static readonly int s_ClipRectsPropID;

	private static ProfilerMarker s_MarkerAllocate;

	private static ProfilerMarker s_MarkerFree;

	private static ProfilerMarker s_MarkerAdvanceFrame;

	private static ProfilerMarker s_MarkerFence;

	private static ProfilerMarker s_MarkerBeforeDraw;

	private static bool? s_VertexTexturingIsAvailable;

	private static bool? s_ShaderModelIs35;

	private static Texture2D s_DefaultShaderInfoTexFloat;

	private static Texture2D s_DefaultShaderInfoTexARGB8;

	internal uint maxVerticesPerPage { get; }

	internal bool breakBatches { get; set; }

	internal static Texture2D defaultShaderInfoTexFloat => null;

	internal static Texture2D defaultShaderInfoTexARGB8 => null;

	internal static bool vertexTexturingIsAvailable => false;

	internal static bool shaderModelIs35 => false;

	private bool fullyCreated => false;

	protected bool disposed { get; private set; }

	static UIRenderDevice()
	{
	}

	public UIRenderDevice(uint initialVertexCapacity = 0u, uint initialIndexCapacity = 0u)
	{
	}

	protected UIRenderDevice(uint initialVertexCapacity, uint initialIndexCapacity, bool mockDevice)
	{
	}

	private void InitVertexDeclaration()
	{
	}

	private void CompleteCreation()
	{
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	public MeshHandle Allocate(uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset)
	{
		vertexData = default(NativeSlice<Vertex>);
		indexData = default(NativeSlice<ushort>);
		indexOffset = default(ushort);
		return null;
	}

	public void Update(MeshHandle mesh, uint vertexCount, out NativeSlice<Vertex> vertexData)
	{
		vertexData = default(NativeSlice<Vertex>);
	}

	public void Update(MeshHandle mesh, uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset)
	{
		vertexData = default(NativeSlice<Vertex>);
		indexData = default(NativeSlice<ushort>);
		indexOffset = default(ushort);
	}

	private void UpdateCopyBackIndices(MeshHandle mesh, bool copyBackIndices)
	{
	}

	internal List<AllocToUpdate> ActiveUpdatesForMeshHandle(MeshHandle mesh)
	{
		return null;
	}

	private bool TryAllocFromPage(Page page, uint vertexCount, uint indexCount, ref Alloc va, ref Alloc ia, bool shortLived)
	{
		return false;
	}

	private void Allocate(MeshHandle meshHandle, uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, bool shortLived)
	{
		vertexData = default(NativeSlice<Vertex>);
		indexData = default(NativeSlice<ushort>);
	}

	private void UpdateAfterGPUUsedData(MeshHandle mesh, uint vertexCount, uint indexCount, out NativeSlice<Vertex> vertexData, out NativeSlice<ushort> indexData, out ushort indexOffset, out AllocToUpdate allocToUpdate, bool copyBackIndices)
	{
		vertexData = default(NativeSlice<Vertex>);
		indexData = default(NativeSlice<ushort>);
		indexOffset = default(ushort);
		allocToUpdate = default(AllocToUpdate);
	}

	public void Free(MeshHandle mesh)
	{
	}

	public void OnFrameRenderingBegin()
	{
	}

	internal unsafe static NativeSlice<T> PtrToSlice<T>(void* p, int count) where T : struct
	{
		return default(NativeSlice<T>);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void ApplyDrawCommandState(RenderChainCommand cmd, int textureSlot, Material newMat, bool newMatDiffers, ref EvaluationState st)
	{
	}

	private void ApplyBatchState(ref EvaluationState st, bool allowMaterialChange)
	{
	}

	public void EvaluateChain(RenderChainCommand head, Material initialMat, Material defaultMat, Texture gradientSettings, Texture shaderInfo, float pixelsPerPoint, NativeSlice<Transform3x4> transforms, NativeSlice<Vector4> clipRects, MaterialPropertyBlock stateMatProps, bool allowMaterialChange, ref Exception immediateException)
	{
	}

	private void UpdateFenceValue()
	{
	}

	private unsafe void KickRanges(DrawBufferRange* ranges, ref int rangesReady, ref int rangesStart, int rangesCount, Page curPage)
	{
	}

	private void DrawRanges<I, T>(Utility.GPUBuffer<I> ib, Utility.GPUBuffer<T> vb, NativeSlice<DrawBufferRange> ranges) where I : struct where T : struct
	{
	}

	private void WaitOnCpuFence(uint fence)
	{
	}

	public void AdvanceFrame()
	{
	}

	private void PruneUnusedPages()
	{
	}

	internal static void PrepareForGfxDeviceRecreate()
	{
	}

	internal static void WrapUpGfxDeviceRecreate()
	{
	}

	internal static void FlushAllPendingDeviceDisposes()
	{
	}

	internal DrawStatistics GatherDrawStatistics()
	{
		return default(DrawStatistics);
	}

	private static void ProcessDeviceFreeQueue()
	{
	}

	private static void OnEngineUpdateGlobal()
	{
	}

	private static void OnFlushPendingResources()
	{
	}
}
