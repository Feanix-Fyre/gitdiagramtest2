using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Rendering.RendererUtils;

namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Graphics/ScriptableRenderLoop/ScriptableDrawRenderersUtility.h")]
[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderPipeline.bindings.h")]
[NativeHeader("Modules/UI/Canvas.h")]
[NativeHeader("Modules/UI/CanvasManager.h")]
[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderContext.bindings.h")]
[NativeType("Runtime/Graphics/ScriptableRenderLoop/ScriptableRenderContext.h")]
public struct ScriptableRenderContext : IEquatable<ScriptableRenderContext>
{
	private static readonly ShaderTagId kRenderTypeTag;

	private IntPtr m_Ptr;

	[FreeFunction("ScriptableRenderContext::BeginRenderPass")]
	private static void BeginRenderPass_Internal(IntPtr self, int width, int height, int volumeDepth, int samples, IntPtr colors, int colorCount, int depthAttachmentIndex)
	{
	}

	[FreeFunction("ScriptableRenderContext::BeginSubPass")]
	private static void BeginSubPass_Internal(IntPtr self, IntPtr colors, int colorCount, IntPtr inputs, int inputCount, bool isDepthReadOnly, bool isStencilReadOnly)
	{
	}

	[FreeFunction("ScriptableRenderContext::EndSubPass")]
	private static void EndSubPass_Internal(IntPtr self)
	{
	}

	[FreeFunction("ScriptableRenderContext::EndRenderPass")]
	private static void EndRenderPass_Internal(IntPtr self)
	{
	}

	[FreeFunction("ScriptableRenderPipeline_Bindings::Internal_Cull")]
	private static void Internal_Cull(ref ScriptableCullingParameters parameters, ScriptableRenderContext renderLoop, IntPtr results)
	{
	}

	[FreeFunction("InitializeSortSettings")]
	internal static void InitializeSortSettings(Camera camera, out SortingSettings sortingSettings)
	{
		sortingSettings = default(SortingSettings);
	}

	private void Submit_Internal()
	{
	}

	private bool SubmitForRenderPassValidation_Internal()
	{
		return false;
	}

	private void GetCameras_Internal(Type listType, object resultList)
	{
	}

	private void DrawRenderers_Internal(IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount)
	{
	}

	private void DrawShadows_Internal(IntPtr shadowDrawingSettings)
	{
	}

	[FreeFunction("PlayerEmitCanvasGeometryForCamera")]
	public static void EmitGeometryForCamera(Camera camera)
	{
	}

	[NativeThrows]
	private void ExecuteCommandBuffer_Internal(CommandBuffer commandBuffer)
	{
	}

	[NativeThrows]
	private void ExecuteCommandBufferAsync_Internal(CommandBuffer commandBuffer, ComputeQueueType queueType)
	{
	}

	private void SetupCameraProperties_Internal([NotNull("NullExceptionObject")] Camera camera, bool stereoSetup, int eye)
	{
	}

	private void InvokeOnRenderObjectCallback_Internal()
	{
	}

	private void DrawWireOverlay_Impl([NotNull("NullExceptionObject")] Camera camera)
	{
	}

	private void DrawUIOverlay_Internal([NotNull("NullExceptionObject")] Camera camera)
	{
	}

	private RendererList CreateRendererList_Internal(IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount)
	{
		return default(RendererList);
	}

	private RendererList CreateSkyboxRendererList_Internal([NotNull("NullExceptionObject")] Camera camera, int mode, Matrix4x4 proj, Matrix4x4 view, Matrix4x4 projR, Matrix4x4 viewR)
	{
		return default(RendererList);
	}

	private void PrepareRendererListsAsync_Internal(object rendererLists)
	{
	}

	private RendererListStatus QueryRendererListStatus_Internal(RendererList handle)
	{
		return default(RendererListStatus);
	}

	internal ScriptableRenderContext(IntPtr ptr)
	{
		m_Ptr = (IntPtr)0;
	}

	public void BeginRenderPass(int width, int height, int samples, NativeArray<AttachmentDescriptor> attachments, int depthAttachmentIndex = -1)
	{
	}

	public void BeginSubPass(NativeArray<int> colors, NativeArray<int> inputs, bool isDepthStencilReadOnly = false)
	{
	}

	public void BeginSubPass(NativeArray<int> colors, bool isDepthStencilReadOnly = false)
	{
	}

	public void EndSubPass()
	{
	}

	public void EndRenderPass()
	{
	}

	public void Submit()
	{
	}

	public bool SubmitForRenderPassValidation()
	{
		return false;
	}

	internal void GetCameras(List<Camera> results)
	{
	}

	public void DrawRenderers(CullingResults cullingResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings)
	{
	}

	public void DrawRenderers(CullingResults cullingResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref RenderStateBlock stateBlock)
	{
	}

	public void DrawRenderers(CullingResults cullingResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ShaderTagId tagName, bool isPassTagName, NativeArray<ShaderTagId> tagValues, NativeArray<RenderStateBlock> stateBlocks)
	{
	}

	public void DrawShadows(ref ShadowDrawingSettings settings)
	{
	}

	public void ExecuteCommandBuffer(CommandBuffer commandBuffer)
	{
	}

	public void ExecuteCommandBufferAsync(CommandBuffer commandBuffer, ComputeQueueType queueType)
	{
	}

	public void SetupCameraProperties(Camera camera, bool stereoSetup = false)
	{
	}

	public void SetupCameraProperties(Camera camera, bool stereoSetup, int eye)
	{
	}

	public void InvokeOnRenderObjectCallback()
	{
	}

	public void DrawWireOverlay(Camera camera)
	{
	}

	public void DrawUIOverlay(Camera camera)
	{
	}

	public CullingResults Cull(ref ScriptableCullingParameters parameters)
	{
		return default(CullingResults);
	}

	public bool Equals(ScriptableRenderContext other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public RendererList CreateRendererList(RendererListDesc desc)
	{
		return default(RendererList);
	}

	public RendererList CreateRendererList(ref RendererListParams param)
	{
		return default(RendererList);
	}

	public RendererList CreateSkyboxRendererList(Camera camera, Matrix4x4 projectionMatrixL, Matrix4x4 viewMatrixL, Matrix4x4 projectionMatrixR, Matrix4x4 viewMatrixR)
	{
		return default(RendererList);
	}

	public RendererList CreateSkyboxRendererList(Camera camera, Matrix4x4 projectionMatrix, Matrix4x4 viewMatrix)
	{
		return default(RendererList);
	}

	public RendererList CreateSkyboxRendererList(Camera camera)
	{
		return default(RendererList);
	}

	public void PrepareRendererListsAsync(List<RendererList> rendererLists)
	{
	}

	public RendererListStatus QueryRendererListStatus(RendererList rendererList)
	{
		return default(RendererListStatus);
	}

	private static void Internal_Cull_Injected(ref ScriptableCullingParameters parameters, ref ScriptableRenderContext renderLoop, IntPtr results)
	{
	}

	private static void Submit_Internal_Injected(ref ScriptableRenderContext _unity_self)
	{
	}

	private static bool SubmitForRenderPassValidation_Internal_Injected(ref ScriptableRenderContext _unity_self)
	{
		return false;
	}

	private static void GetCameras_Internal_Injected(ref ScriptableRenderContext _unity_self, Type listType, object resultList)
	{
	}

	private static void DrawRenderers_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount)
	{
	}

	private static void DrawShadows_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr shadowDrawingSettings)
	{
	}

	private static void ExecuteCommandBuffer_Internal_Injected(ref ScriptableRenderContext _unity_self, CommandBuffer commandBuffer)
	{
	}

	private static void ExecuteCommandBufferAsync_Internal_Injected(ref ScriptableRenderContext _unity_self, CommandBuffer commandBuffer, ComputeQueueType queueType)
	{
	}

	private static void SetupCameraProperties_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera, bool stereoSetup, int eye)
	{
	}

	private static void InvokeOnRenderObjectCallback_Internal_Injected(ref ScriptableRenderContext _unity_self)
	{
	}

	private static void DrawWireOverlay_Impl_Injected(ref ScriptableRenderContext _unity_self, Camera camera)
	{
	}

	private static void DrawUIOverlay_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera)
	{
	}

	private static void CreateRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, IntPtr cullResults, ref DrawingSettings drawingSettings, ref FilteringSettings filteringSettings, ref ShaderTagId tagName, bool isPassTagName, IntPtr tagValues, IntPtr stateBlocks, int stateCount, out RendererList ret)
	{
		ret = default(RendererList);
	}

	private static void CreateSkyboxRendererList_Internal_Injected(ref ScriptableRenderContext _unity_self, Camera camera, int mode, ref Matrix4x4 proj, ref Matrix4x4 view, ref Matrix4x4 projR, ref Matrix4x4 viewR, out RendererList ret)
	{
		ret = default(RendererList);
	}

	private static void PrepareRendererListsAsync_Internal_Injected(ref ScriptableRenderContext _unity_self, object rendererLists)
	{
	}

	private static RendererListStatus QueryRendererListStatus_Internal_Injected(ref ScriptableRenderContext _unity_self, ref RendererList handle)
	{
		return default(RendererListStatus);
	}
}
