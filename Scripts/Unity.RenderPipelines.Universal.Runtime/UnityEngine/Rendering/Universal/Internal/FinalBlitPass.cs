using System;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal;

public class FinalBlitPass : ScriptableRenderPass
{
	private static class BlitPassNames
	{
		public const string NearestSampler = "NearestDebugDraw";

		public const string BilinearSampler = "BilinearDebugDraw";
	}

	private enum BlitType
	{
		Core = 0,
		HDR = 1,
		Count = 2
	}

	private struct BlitMaterialData
	{
		public Material material;

		public int nearestSamplerPass;

		public int bilinearSamplerPass;
	}

	private class PassData
	{
		internal TextureHandle source;

		internal TextureHandle destination;

		internal int sourceID;

		internal Vector4 hdrOutputLuminanceParams;

		internal bool requireSrgbConversion;

		internal BlitMaterialData blitMaterialData;

		internal RenderingData renderingData;
	}

	private RTHandle m_Source;

	private PassData m_PassData;

	private BlitMaterialData[] m_BlitMaterialData;

	public FinalBlitPass(RenderPassEvent evt, Material blitMaterial, Material blitHDRMaterial)
	{
	}

	public void Dispose()
	{
	}

	[Obsolete("Use RTHandles for colorHandle")]
	public void Setup(RenderTextureDescriptor baseDescriptor, RenderTargetHandle colorHandle)
	{
	}

	public void Setup(RenderTextureDescriptor baseDescriptor, RTHandle colorHandle)
	{
	}

	private static void SetupHDROutput(ColorGamut hdrDisplayColorGamut, Material material, HDROutputUtils.Operation hdrOperation, Vector4 hdrOutputParameters)
	{
	}

	public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
	{
	}

	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	private static void ExecutePass(ref RenderingData renderingData, in BlitMaterialData blitMaterialData, RTHandle cameraTarget, RTHandle source)
	{
	}

	private void InitPassData(ref RenderingData renderingData, ref PassData passData, BlitType blitType)
	{
	}

	internal void Render(RenderGraph renderGraph, ref RenderingData renderingData, TextureHandle src, TextureHandle dest, TextureHandle overlayUITexture)
	{
	}
}
