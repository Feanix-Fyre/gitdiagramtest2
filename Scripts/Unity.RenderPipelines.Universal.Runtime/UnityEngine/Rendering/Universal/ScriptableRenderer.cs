using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Unity.Collections;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal;

public abstract class ScriptableRenderer : IDisposable
{
	private static class Profiling
	{
		public static class RenderBlock
		{
			private const string k_Name = "RenderPassBlock";

			public static readonly ProfilingSampler beforeRendering;

			public static readonly ProfilingSampler mainRenderingOpaque;

			public static readonly ProfilingSampler mainRenderingTransparent;

			public static readonly ProfilingSampler afterRendering;
		}

		public static class RenderPass
		{
			private const string k_Name = "ScriptableRenderPass";

			public static readonly ProfilingSampler configure;

			public static readonly ProfilingSampler setRenderPassAttachments;
		}

		public static readonly ProfilingSampler setMRTAttachmentsList;

		public static readonly ProfilingSampler setAttachmentList;

		public static readonly ProfilingSampler execute;

		public static readonly ProfilingSampler setupFrameData;

		private const string k_Name = "ScriptableRenderer";

		public static readonly ProfilingSampler setPerCameraShaderVariables;

		public static readonly ProfilingSampler sortRenderPasses;

		public static readonly ProfilingSampler setupLights;

		public static readonly ProfilingSampler setupCamera;

		public static readonly ProfilingSampler vfxProcessCamera;

		public static readonly ProfilingSampler addRenderPasses;

		public static readonly ProfilingSampler setupRenderPasses;

		public static readonly ProfilingSampler clearRenderingState;

		public static readonly ProfilingSampler internalStartRendering;

		public static readonly ProfilingSampler internalFinishRendering;

		public static readonly ProfilingSampler drawGizmos;

		internal static readonly ProfilingSampler beginXRRendering;

		internal static readonly ProfilingSampler endXRRendering;
	}

	internal struct RenderPassDescriptor
	{
		internal int w;

		internal int h;

		internal int samples;

		internal int depthID;

		internal RenderPassDescriptor(int width, int height, int sampleCount, int rtID)
		{
			w = 0;
			h = 0;
			samples = 0;
			depthID = 0;
		}
	}

	public class RenderingFeatures
	{
		[Obsolete("cameraStacking has been deprecated use SupportedCameraRenderTypes() in ScriptableRenderer instead.", false)]
		public bool cameraStacking { get; set; }

		public bool msaa { get; set; }
	}

	private static class RenderPassBlock
	{
		public static readonly int BeforeRendering;

		public static readonly int MainRenderingOpaque;

		public static readonly int MainRenderingTransparent;

		public static readonly int AfterRendering;
	}

	internal struct RTHandleRenderTargetIdentifierCompat
	{
		public RTHandle handle;

		public RenderTargetIdentifier fallback;

		public bool useRTHandle => false;

		public RenderTargetIdentifier nameID => default(RenderTargetIdentifier);
	}

	private class VFXProcessCameraPassData
	{
		internal CullingResults cullResults;

		internal Camera camera;
	}

	private class DrawGizmosPassData
	{
		public RenderingData renderingData;

		public ScriptableRenderer renderer;

		public GizmoSubset gizmoSubset;
	}

	private class BeginXRPassData
	{
		public RenderingData renderingData;

		public CameraData cameraData;
	}

	private class EndXRPassData
	{
		public RenderingData renderingData;

		public CameraData cameraData;
	}

	private class PassData
	{
		internal RenderingData renderingData;

		internal ScriptableRenderer renderer;

		internal CameraData cameraData;

		internal bool isTargetBackbuffer;
	}

	internal struct RenderBlocks : IDisposable
	{
		public struct BlockRange : IDisposable
		{
			private int m_Current;

			private int m_End;

			public int Current => 0;

			public BlockRange(int begin, int end)
			{
				m_Current = 0;
				m_End = 0;
			}

			public BlockRange GetEnumerator()
			{
				return default(BlockRange);
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Dispose()
			{
			}
		}

		private NativeArray<RenderPassEvent> m_BlockEventLimits;

		private NativeArray<int> m_BlockRanges;

		private NativeArray<int> m_BlockRangeLengths;

		public RenderBlocks(List<ScriptableRenderPass> activeRenderPassQueue)
		{
			m_BlockEventLimits = default(NativeArray<RenderPassEvent>);
			m_BlockRanges = default(NativeArray<int>);
			m_BlockRangeLengths = default(NativeArray<int>);
		}

		public void Dispose()
		{
		}

		private void FillBlockRanges(List<ScriptableRenderPass> activeRenderPassQueue)
		{
		}

		public int GetLength(int index)
		{
			return 0;
		}

		public BlockRange GetRange(int index)
		{
			return default(BlockRange);
		}
	}

	private const int kRenderPassMapSize = 10;

	private const int kRenderPassMaxCount = 20;

	private int m_LastBeginSubpassPassIndex;

	private Dictionary<Hash128, int[]> m_MergeableRenderPassesMap;

	private int[][] m_MergeableRenderPassesMapArrays;

	private Hash128[] m_PassIndexToPassHash;

	private Dictionary<Hash128, int> m_RenderPassesAttachmentCount;

	private AttachmentDescriptor[] m_ActiveColorAttachmentDescriptors;

	private AttachmentDescriptor m_ActiveDepthAttachmentDescriptor;

	private bool[] m_IsActiveColorAttachmentTransient;

	internal RenderBufferStoreAction[] m_FinalColorStoreAction;

	internal RenderBufferStoreAction m_FinalDepthStoreAction;

	internal bool hasReleasedRTs;

	internal static ScriptableRenderer current;

	private StoreActionsOptimization m_StoreActionsOptimizationSetting;

	private static bool m_UseOptimizedStoreActions;

	private const int k_RenderPassBlockCount = 4;

	protected static readonly RTHandle k_CameraTarget;

	private List<ScriptableRenderPass> m_ActiveRenderPassQueue;

	private List<ScriptableRendererFeature> m_RendererFeatures;

	private RTHandleRenderTargetIdentifierCompat m_CameraColorTarget;

	private RTHandleRenderTargetIdentifierCompat m_CameraDepthTarget;

	private RTHandleRenderTargetIdentifierCompat m_CameraResolveTarget;

	private bool m_FirstTimeCameraColorTargetIsBound;

	private bool m_FirstTimeCameraDepthTargetIsBound;

	private bool m_IsPipelineExecuting;

	internal bool disableNativeRenderPassInFeatures;

	internal bool useRenderPassEnabled;

	private static RenderTargetIdentifier[] m_ActiveColorAttachments;

	private static RenderTargetIdentifier m_ActiveDepthAttachment;

	private static RenderBufferStoreAction[] m_ActiveColorStoreActions;

	private static RenderBufferStoreAction m_ActiveDepthStoreAction;

	private static RenderTargetIdentifier[][] m_TrimmedColorAttachmentCopies;

	private static Plane[] s_Planes;

	private static Vector4[] s_VectorPlanes;

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("cameraDepth has been renamed to cameraDepthTarget. (UnityUpgradable) -> cameraDepthTarget")]
	public RenderTargetIdentifier cameraDepth => default(RenderTargetIdentifier);

	protected ProfilingSampler profilingExecute { get; set; }

	internal DebugHandler DebugHandler { get; }

	[Obsolete("Use cameraColorTargetHandle")]
	public RenderTargetIdentifier cameraColorTarget => default(RenderTargetIdentifier);

	public RTHandle cameraColorTargetHandle => null;

	[Obsolete("Use cameraDepthTargetHandle")]
	public RenderTargetIdentifier cameraDepthTarget => default(RenderTargetIdentifier);

	public RTHandle cameraDepthTargetHandle => null;

	protected List<ScriptableRendererFeature> rendererFeatures => null;

	protected List<ScriptableRenderPass> activeRenderPassQueue => null;

	public RenderingFeatures supportedRenderingFeatures { get; set; }

	public GraphicsDeviceType[] unsupportedGraphicsDeviceTypes { get; set; }

	internal bool useDepthPriming { get; set; }

	internal bool stripShadowsOffVariants { get; set; }

	internal bool stripAdditionalLightOffVariants { get; set; }

	internal void ResetNativeRenderPassFrameData()
	{
	}

	internal void SetupNativeRenderPassFrameData(ref CameraData cameraData, bool isRenderPassEnabled)
	{
	}

	internal void UpdateFinalStoreActions(int[] currentMergeablePasses, ref CameraData cameraData)
	{
	}

	internal void SetNativeRenderPassMRTAttachmentList(ScriptableRenderPass renderPass, ref CameraData cameraData, bool needCustomCameraColorClear, ClearFlag cameraClearFlag)
	{
	}

	private bool IsDepthOnlyRenderTexture(RenderTexture t)
	{
		return false;
	}

	internal void SetNativeRenderPassAttachmentList(ScriptableRenderPass renderPass, ref CameraData cameraData, RTHandle passColorAttachment, RTHandle passDepthAttachment, ClearFlag finalClearFlag, Color finalClearColor)
	{
	}

	internal void ExecuteNativeRenderPass(ScriptableRenderContext context, ScriptableRenderPass renderPass, ref CameraData cameraData, ref RenderingData renderingData)
	{
	}

	internal void SetupInputAttachmentIndices(ScriptableRenderPass pass)
	{
	}

	internal void SetupTransientInputAttachments(int attachmentCount)
	{
	}

	internal static uint GetSubPassAttachmentIndicesCount(ScriptableRenderPass pass)
	{
		return 0u;
	}

	internal static bool AreAttachmentIndicesCompatible(ScriptableRenderPass lastSubPass, ScriptableRenderPass currentSubPass)
	{
		return false;
	}

	internal static uint GetValidColorAttachmentCount(AttachmentDescriptor[] colorAttachments)
	{
		return 0u;
	}

	internal static int GetValidInputAttachmentCount(ScriptableRenderPass renderPass)
	{
		return 0;
	}

	internal static int FindAttachmentDescriptorIndexInList(int attachmentIdx, AttachmentDescriptor attachmentDescriptor, AttachmentDescriptor[] attachmentDescriptors)
	{
		return 0;
	}

	internal static int FindAttachmentDescriptorIndexInList(RenderTargetIdentifier target, AttachmentDescriptor[] attachmentDescriptors)
	{
		return 0;
	}

	internal static int GetValidPassIndexCount(int[] array)
	{
		return 0;
	}

	internal static RTHandle GetFirstAllocatedRTHandle(ScriptableRenderPass pass)
	{
		return null;
	}

	internal static bool PassHasInputAttachments(ScriptableRenderPass renderPass)
	{
		return false;
	}

	internal static Hash128 CreateRenderPassHash(int width, int height, int depthID, int sample, uint hashIndex)
	{
		return default(Hash128);
	}

	internal static Hash128 CreateRenderPassHash(RenderPassDescriptor desc, uint hashIndex)
	{
		return default(Hash128);
	}

	internal static void GetRenderTextureDescriptor(ref CameraData cameraData, ScriptableRenderPass renderPass, out RenderTextureDescriptor targetRT)
	{
		targetRT = default(RenderTextureDescriptor);
	}

	private RenderPassDescriptor InitializeRenderPassDescriptor(ref CameraData cameraData, ScriptableRenderPass renderPass)
	{
		return default(RenderPassDescriptor);
	}

	public virtual int SupportedCameraStackingTypes()
	{
		return 0;
	}

	public bool SupportsCameraStackingType(CameraRenderType cameraRenderType)
	{
		return false;
	}

	public static void SetCameraMatrices(CommandBuffer cmd, ref CameraData cameraData, bool setInverseMatrices)
	{
	}

	internal static void SetCameraMatrices(CommandBuffer cmd, ref CameraData cameraData, bool setInverseMatrices, bool isTargetFlipped)
	{
	}

	private void SetPerCameraShaderVariables(CommandBuffer cmd, ref CameraData cameraData)
	{
	}

	private void SetPerCameraShaderVariables(CommandBuffer cmd, ref CameraData cameraData, bool isTargetFlipped)
	{
	}

	private void SetPerCameraBillboardProperties(CommandBuffer cmd, ref CameraData cameraData)
	{
	}

	private static void CalculateBillboardProperties(in Matrix4x4 worldToCameraMatrix, out Vector3 billboardTangent, out Vector3 billboardNormal, out float cameraXZAngle)
	{
		billboardTangent = default(Vector3);
		billboardNormal = default(Vector3);
		cameraXZAngle = default(float);
	}

	private void SetPerCameraClippingPlaneProperties(CommandBuffer cmd, ref CameraData cameraData)
	{
	}

	private void SetPerCameraClippingPlaneProperties(CommandBuffer cmd, in CameraData cameraData, bool isTargetFlipped)
	{
	}

	private static void SetShaderTimeValues(CommandBuffer cmd, float time, float deltaTime, float smoothDeltaTime)
	{
	}

	internal virtual RTHandle GetCameraColorFrontBuffer(CommandBuffer cmd)
	{
		return null;
	}

	internal virtual RTHandle GetCameraColorBackBuffer(CommandBuffer cmd)
	{
		return null;
	}

	internal static void ConfigureActiveTarget(RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment)
	{
	}

	public ScriptableRenderer(ScriptableRendererData data)
	{
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	internal virtual void ReleaseRenderTargets()
	{
	}

	[Obsolete("Use RTHandles for colorTarget and depthTarget")]
	public void ConfigureCameraTarget(RenderTargetIdentifier colorTarget, RenderTargetIdentifier depthTarget)
	{
	}

	public void ConfigureCameraTarget(RTHandle colorTarget, RTHandle depthTarget)
	{
	}

	[Obsolete("Use RTHandles for colorTarget, depthTarget and resolveTarget")]
	internal void ConfigureCameraTarget(RenderTargetIdentifier colorTarget, RenderTargetIdentifier depthTarget, RenderTargetIdentifier resolveTarget)
	{
	}

	internal void ConfigureCameraTarget(RTHandle colorTarget, RTHandle depthTarget, RTHandle resolveTarget)
	{
	}

	[Obsolete("Use RTHandle for colorTarget")]
	internal void ConfigureCameraColorTarget(RenderTargetIdentifier colorTarget)
	{
	}

	internal void ConfigureCameraColorTarget(RTHandle colorTarget)
	{
	}

	public abstract void Setup(ScriptableRenderContext context, ref RenderingData renderingData);

	public virtual void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	public virtual void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData)
	{
	}

	public virtual void FinishRendering(CommandBuffer cmd)
	{
	}

	internal virtual void OnRecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	private void InitRenderGraphFrame(RenderGraph renderGraph, ref RenderingData renderingData)
	{
	}

	internal void ProcessVFXCameraCommand(RenderGraph renderGraph, ref RenderingData renderingData)
	{
	}

	internal void SetupRenderGraphCameraProperties(RenderGraph renderGraph, ref RenderingData renderingData, bool isTargetBackbuffer)
	{
	}

	internal void DrawRenderGraphGizmos(RenderGraph renderGraph, TextureHandle color, TextureHandle depth, GizmoSubset gizmoSubset, ref RenderingData renderingData)
	{
	}

	private void BeginRenderGraphXRRendering(RenderGraph renderGraph, ref RenderingData renderingData)
	{
	}

	private void EndRenderGraphXRRendering(RenderGraph renderGraph, ref RenderingData renderingData)
	{
	}

	internal void RecordRenderGraph(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	internal void FinishRenderGraphRendering(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	internal virtual void OnFinishRenderGraphRendering(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	internal void RecordCustomRenderGraphPasses(RenderGraph renderGraph, ScriptableRenderContext context, ref RenderingData renderingData, RenderPassEvent injectionPoint)
	{
	}

	internal void SetPerCameraProperties(ScriptableRenderContext context, ref CameraData cameraData, Camera camera, CommandBuffer cmd)
	{
	}

	public void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	public void EnqueuePass(ScriptableRenderPass pass)
	{
	}

	protected static ClearFlag GetCameraClearFlag(ref CameraData cameraData)
	{
		return default(ClearFlag);
	}

	internal void OnPreCullRenderPasses(in CameraData cameraData)
	{
	}

	internal void AddRenderPasses(ref RenderingData renderingData)
	{
	}

	protected void SetupRenderPasses(in RenderingData renderingData)
	{
	}

	private static void ClearRenderingState(CommandBuffer cmd)
	{
	}

	internal void Clear(CameraRenderType cameraType)
	{
	}

	private void ExecuteBlock(int blockIndex, in RenderBlocks renderBlocks, ScriptableRenderContext context, ref RenderingData renderingData, bool submit = false)
	{
	}

	private bool IsRenderPassEnabled(ScriptableRenderPass renderPass)
	{
		return false;
	}

	private void ExecuteRenderPass(ScriptableRenderContext context, ScriptableRenderPass renderPass, ref RenderingData renderingData)
	{
	}

	private void SetRenderPassAttachments(CommandBuffer cmd, ScriptableRenderPass renderPass, ref CameraData cameraData)
	{
	}

	private void BeginXRRendering(CommandBuffer cmd, ScriptableRenderContext context, ref CameraData cameraData)
	{
	}

	private void EndXRRendering(CommandBuffer cmd, ScriptableRenderContext context, ref CameraData cameraData)
	{
	}

	[Obsolete("Use RTHandles for colorAttachment and depthAttachment")]
	internal static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment, ClearFlag clearFlag, Color clearColor)
	{
	}

	internal static void SetRenderTarget(CommandBuffer cmd, RTHandle colorAttachment, RTHandle depthAttachment, ClearFlag clearFlag, Color clearColor)
	{
	}

	[Obsolete("Use RTHandles for colorAttachment and depthAttachment")]
	internal static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderTargetIdentifier depthAttachment, ClearFlag clearFlag, Color clearColor, RenderBufferStoreAction colorStoreAction, RenderBufferStoreAction depthStoreAction)
	{
	}

	internal static void SetRenderTarget(CommandBuffer cmd, RTHandle colorAttachment, RTHandle depthAttachment, ClearFlag clearFlag, Color clearColor, RenderBufferStoreAction colorStoreAction, RenderBufferStoreAction depthStoreAction)
	{
	}

	[Obsolete("Use RTHandle for colorAttachment")]
	private static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, ClearFlag clearFlags, Color clearColor)
	{
	}

	private static void SetRenderTarget(CommandBuffer cmd, RTHandle colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, ClearFlag clearFlags, Color clearColor)
	{
	}

	[Obsolete("Use RTHandles for colorAttachment and depthAttachment")]
	private static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthAttachment, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlags, Color clearColor)
	{
	}

	private static void SetRenderTarget(CommandBuffer cmd, RTHandle colorAttachment, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RTHandle depthAttachment, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlags, Color clearColor)
	{
	}

	[Obsolete("Use RTHandles for colorAttachments and depthAttachment")]
	private static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorAttachments, RenderTargetIdentifier depthAttachment, ClearFlag clearFlag, Color clearColor)
	{
	}

	[Obsolete("Use RTHandle for colorAttachments")]
	private static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorAttachments, RTHandle depthAttachment, ClearFlag clearFlag, Color clearColor)
	{
	}

	private static void SetRenderTarget(CommandBuffer cmd, RTHandle[] colorAttachments, RTHandle depthAttachment, ClearFlag clearFlag, Color clearColor)
	{
	}

	internal virtual void SwapColorBuffer(CommandBuffer cmd)
	{
	}

	internal virtual void EnableSwapBufferMSAA(bool enable)
	{
	}

	[Conditional("UNITY_EDITOR")]
	private void DrawGizmos(ScriptableRenderContext context, Camera camera, GizmoSubset gizmoSubset, ref RenderingData renderingData)
	{
	}

	[Conditional("UNITY_EDITOR")]
	private void DrawWireOverlay(ScriptableRenderContext context, Camera camera)
	{
	}

	private void InternalStartRendering(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	private void InternalFinishRendering(bool resolveFinalTarget, RenderingData renderingData)
	{
	}

	private void InternalFinishRendering(ScriptableRenderContext context, bool resolveFinalTarget, RenderingData renderingData)
	{
	}

	internal static void SortStable(List<ScriptableRenderPass> list)
	{
	}
}
