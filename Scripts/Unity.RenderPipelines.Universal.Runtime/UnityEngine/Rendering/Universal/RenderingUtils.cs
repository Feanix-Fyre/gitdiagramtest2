using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal;

public static class RenderingUtils
{
	private static List<ShaderTagId> m_LegacyShaderPassNames;

	private static AttachmentDescriptor s_EmptyAttachment;

	private static Mesh s_FullscreenMesh;

	private static Material s_ErrorMaterial;

	private static Dictionary<RenderTextureFormat, bool> m_RenderTextureFormatSupport;

	private static Dictionary<GraphicsFormat, Dictionary<FormatUsage, bool>> m_GraphicsFormatSupport;

	internal static AttachmentDescriptor emptyAttachment => default(AttachmentDescriptor);

	[Obsolete("Use Blitter.BlitCameraTexture instead of CommandBuffer.DrawMesh(fullscreenMesh, ...)")]
	public static Mesh fullscreenMesh => null;

	internal static bool useStructuredBuffer => false;

	private static Material errorMaterial => null;

	internal static bool SupportsLightLayers(GraphicsDeviceType type)
	{
		return false;
	}

	public static void SetViewAndProjectionMatrices(CommandBuffer cmd, Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix, bool setInverseMatrices)
	{
	}

	internal static void SetScaleBiasRt(CommandBuffer cmd, in RenderingData renderingData)
	{
	}

	internal static void Blit(CommandBuffer cmd, RTHandle source, Rect viewport, RTHandle destination, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag, Color clearColor, Material material, int passIndex = 0)
	{
	}

	internal static void Blit(CommandBuffer cmd, RTHandle source, Rect viewport, RTHandle destinationColor, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RTHandle destinationDepthStencil, RenderBufferLoadAction depthStencilLoadAction, RenderBufferStoreAction depthStencilStoreAction, ClearFlag clearFlag, Color clearColor, Material material, int passIndex = 0)
	{
	}

	internal static void FinalBlit(CommandBuffer cmd, ref CameraData cameraData, RTHandle source, RTHandle destination, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, Material material, int passIndex)
	{
	}

	[Conditional("UNITY_EDITOR")]
	[Conditional("DEVELOPMENT_BUILD")]
	internal static void RenderObjectsWithError(ScriptableRenderContext context, ref CullingResults cullResults, Camera camera, FilteringSettings filterSettings, SortingCriteria sortFlags)
	{
	}

	internal static void ClearSystemInfoCache()
	{
	}

	public static bool SupportsRenderTextureFormat(RenderTextureFormat format)
	{
		return false;
	}

	public static bool SupportsGraphicsFormat(GraphicsFormat format, FormatUsage usage)
	{
		return false;
	}

	internal static int GetLastValidColorBufferIndex(RenderTargetIdentifier[] colorBuffers)
	{
		return 0;
	}

	[Obsolete("Use RTHandles for colorBuffers")]
	internal static uint GetValidColorBufferCount(RenderTargetIdentifier[] colorBuffers)
	{
		return 0u;
	}

	internal static uint GetValidColorBufferCount(RTHandle[] colorBuffers)
	{
		return 0u;
	}

	[Obsolete("Use RTHandles for colorBuffers")]
	internal static bool IsMRT(RenderTargetIdentifier[] colorBuffers)
	{
		return false;
	}

	internal static bool IsMRT(RTHandle[] colorBuffers)
	{
		return false;
	}

	internal static bool Contains(RenderTargetIdentifier[] source, RenderTargetIdentifier value)
	{
		return false;
	}

	internal static int IndexOf(RenderTargetIdentifier[] source, RenderTargetIdentifier value)
	{
		return 0;
	}

	internal static uint CountDistinct(RenderTargetIdentifier[] source, RenderTargetIdentifier value)
	{
		return 0u;
	}

	internal static int LastValid(RenderTargetIdentifier[] source)
	{
		return 0;
	}

	internal static bool Contains(ClearFlag a, ClearFlag b)
	{
		return false;
	}

	internal static bool SequenceEqual(RenderTargetIdentifier[] left, RenderTargetIdentifier[] right)
	{
		return false;
	}

	internal static bool MultisampleDepthResolveSupported()
	{
		return false;
	}

	internal static bool RTHandleNeedsReAlloc(RTHandle handle, in TextureDesc descriptor, bool scaled)
	{
		return false;
	}

	internal static RenderTargetIdentifier GetCameraTargetIdentifier(ref RenderingData renderingData)
	{
		return default(RenderTargetIdentifier);
	}

	public static bool ReAllocateIfNeeded(ref RTHandle handle, in RenderTextureDescriptor descriptor, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
	{
		return false;
	}

	public static bool ReAllocateIfNeeded(ref RTHandle handle, Vector2 scaleFactor, in RenderTextureDescriptor descriptor, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
	{
		return false;
	}

	public static bool ReAllocateIfNeeded(ref RTHandle handle, ScaleFunc scaleFunc, in RenderTextureDescriptor descriptor, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, string name = "")
	{
		return false;
	}

	public static bool SetMaxRTHandlePoolCapacity(int capacity)
	{
		return false;
	}

	internal static void AddStaleResourceToPoolOrRelease(TextureDesc desc, RTHandle handle)
	{
	}

	public static DrawingSettings CreateDrawingSettings(ShaderTagId shaderTagId, ref RenderingData renderingData, SortingCriteria sortingCriteria)
	{
		return default(DrawingSettings);
	}

	public static DrawingSettings CreateDrawingSettings(List<ShaderTagId> shaderTagIdList, ref RenderingData renderingData, SortingCriteria sortingCriteria)
	{
		return default(DrawingSettings);
	}
}
