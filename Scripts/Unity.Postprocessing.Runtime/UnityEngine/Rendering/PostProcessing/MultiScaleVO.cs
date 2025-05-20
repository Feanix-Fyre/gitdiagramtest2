using System;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[Preserve]
internal sealed class MultiScaleVO : IAmbientOcclusionMethod
{
	internal enum MipLevel
	{
		Original = 0,
		L1 = 1,
		L2 = 2,
		L3 = 3,
		L4 = 4,
		L5 = 5,
		L6 = 6
	}

	private enum Pass
	{
		DepthCopy = 0,
		CompositionDeferred = 1,
		CompositionForward = 2,
		DebugOverlay = 3
	}

	private readonly float[] m_SampleThickness;

	private readonly float[] m_InvThicknessTable;

	private readonly float[] m_SampleWeightTable;

	private readonly int[] m_Widths;

	private readonly int[] m_Heights;

	private readonly int[] m_ScaledWidths;

	private readonly int[] m_ScaledHeights;

	private AmbientOcclusion m_Settings;

	private PropertySheet m_PropertySheet;

	private PostProcessResources m_Resources;

	private RenderTexture m_AmbientOnlyAO;

	private RenderTextureFormat m_R8Format;

	private RenderTextureFormat m_R16Format;

	private bool float4Texture;

	private readonly RenderTargetIdentifier[] m_MRT;

	public MultiScaleVO(AmbientOcclusion settings)
	{
	}

	public DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	public void SetResources(PostProcessResources resources)
	{
	}

	private void Alloc(CommandBuffer cmd, int id, MipLevel size, RenderTextureFormat format, bool uav, bool dynamicScale)
	{
	}

	private void AllocArray(CommandBuffer cmd, int id, MipLevel size, RenderTextureFormat format, bool uav, bool dynamicScale)
	{
	}

	private void Release(CommandBuffer cmd, int id)
	{
	}

	private Vector4 CalculateZBufferParams(Camera camera)
	{
		return default(Vector4);
	}

	private float CalculateTanHalfFovHeight(Camera camera)
	{
		return 0f;
	}

	private Vector2 GetSize(MipLevel mip)
	{
		return default(Vector2);
	}

	private Vector3 GetSizeArray(MipLevel mip)
	{
		return default(Vector3);
	}

	public void GenerateAOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, RenderTargetIdentifier? depthMap, bool invert, bool isMSAA)
	{
	}

	private void PushAllocCommands(CommandBuffer cmd, bool isMSAA, Camera camera)
	{
	}

	private void PushDownsampleCommands(CommandBuffer cmd, Camera camera, RenderTargetIdentifier? depthMap, bool isMSAA)
	{
	}

	private void PushRenderCommands(CommandBuffer cmd, int source, int destination, Vector3 sourceSize, float tanHalfFovH, bool isMSAA)
	{
	}

	private void PushUpsampleCommands(CommandBuffer cmd, int lowResDepth, int interleavedAO, int highResDepth, int? highResAO, RenderTargetIdentifier dest, Vector3 lowResDepthSize, Vector2 highResDepthSize, bool isMSAA, bool invert = false)
	{
	}

	private void PushReleaseCommands(CommandBuffer cmd)
	{
	}

	private void PreparePropertySheet(PostProcessRenderContext context)
	{
	}

	private void CheckAOTexture(PostProcessRenderContext context)
	{
	}

	private void PushDebug(PostProcessRenderContext context)
	{
	}

	public void RenderAfterOpaque(PostProcessRenderContext context)
	{
	}

	public void RenderAmbientOnly(PostProcessRenderContext context)
	{
	}

	public void CompositeAmbientOnly(PostProcessRenderContext context)
	{
	}

	public void Release()
	{
	}
}
