using System;
using System.Collections.Generic;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering;

public class RTHandleSystem : IDisposable
{
	internal enum ResizeMode
	{
		Auto = 0,
		OnDemand = 1
	}

	private bool m_HardwareDynamicResRequested;

	private HashSet<RTHandle> m_AutoSizedRTs;

	private RTHandle[] m_AutoSizedRTsArray;

	private HashSet<RTHandle> m_ResizeOnDemandRTs;

	private RTHandleProperties m_RTHandleProperties;

	private int m_MaxWidths;

	private int m_MaxHeights;

	public RTHandleProperties rtHandleProperties => default(RTHandleProperties);

	public void Dispose()
	{
	}

	public void Initialize(int width, int height)
	{
	}

	[Obsolete("useLegacyDynamicResControl is deprecated. Please use SetHardwareDynamicResolutionState() instead.")]
	public void Initialize(int width, int height, bool useLegacyDynamicResControl = false)
	{
	}

	public void Release(RTHandle rth)
	{
	}

	internal void Remove(RTHandle rth)
	{
	}

	public void ResetReferenceSize(int width, int height)
	{
	}

	public void SetReferenceSize(int width, int height)
	{
	}

	public void SetReferenceSize(int width, int height, bool reset)
	{
	}

	internal Vector2 CalculateRatioAgainstMaxSize(in Vector2Int viewportSize)
	{
		return default(Vector2);
	}

	public void SetHardwareDynamicResolutionState(bool enableHWDynamicRes)
	{
	}

	internal void SwitchResizeMode(RTHandle rth, ResizeMode mode)
	{
	}

	private void DemandResize(RTHandle rth)
	{
	}

	public int GetMaxWidth()
	{
		return 0;
	}

	public int GetMaxHeight()
	{
		return 0;
	}

	private void Dispose(bool disposing)
	{
	}

	private void Resize(int width, int height, bool sizeChanged)
	{
	}

	public RTHandle Alloc(int width, int height, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = false, bool useDynamicScale = false, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, string name = "")
	{
		return null;
	}

	public RTHandle Alloc(int width, int height, TextureWrapMode wrapModeU, TextureWrapMode wrapModeV, TextureWrapMode wrapModeW = TextureWrapMode.Repeat, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = false, bool useDynamicScale = false, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, string name = "")
	{
		return null;
	}

	public RTHandle Alloc(Vector2 scaleFactor, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = false, bool useDynamicScale = false, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, string name = "")
	{
		return null;
	}

	public RTHandle Alloc(ScaleFunc scaleFunc, int slices = 1, DepthBits depthBufferBits = DepthBits.None, GraphicsFormat colorFormat = GraphicsFormat.R8G8B8A8_SRGB, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Repeat, TextureDimension dimension = TextureDimension.Tex2D, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0f, MSAASamples msaaSamples = MSAASamples.None, bool bindTextureMS = false, bool useDynamicScale = false, RenderTextureMemoryless memoryless = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, string name = "")
	{
		return null;
	}

	private RTHandle AllocAutoSizedRenderTexture(int width, int height, int slices, DepthBits depthBufferBits, GraphicsFormat colorFormat, FilterMode filterMode, TextureWrapMode wrapMode, TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, RenderTextureMemoryless memoryless, VRTextureUsage vrUsage, string name)
	{
		return null;
	}

	public RTHandle Alloc(RenderTexture texture)
	{
		return null;
	}

	public RTHandle Alloc(Texture texture)
	{
		return null;
	}

	public RTHandle Alloc(RenderTargetIdentifier texture)
	{
		return null;
	}

	public RTHandle Alloc(RenderTargetIdentifier texture, string name)
	{
		return null;
	}

	private static RTHandle Alloc(RTHandle tex)
	{
		return null;
	}

	internal string DumpRTInfo()
	{
		return null;
	}
}
