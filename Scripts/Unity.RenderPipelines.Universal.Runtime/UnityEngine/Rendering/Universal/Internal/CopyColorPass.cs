using System;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal;

public class CopyColorPass : ScriptableRenderPass
{
	private class PassData
	{
		internal TextureHandle source;

		internal TextureHandle destination;

		internal bool useProceduralBlit;

		internal bool disableFoveatedRenderingForPass;

		internal CommandBuffer cmd;

		internal Material samplingMaterial;

		internal Material copyColorMaterial;

		internal Downsampling downsamplingMethod;

		internal ClearFlag clearFlag;

		internal Color clearColor;

		internal int sampleOffsetShaderHandle;
	}

	private int m_SampleOffsetShaderHandle;

	private Material m_SamplingMaterial;

	private Downsampling m_DownsamplingMethod;

	private Material m_CopyColorMaterial;

	private PassData m_PassData;

	private RTHandle source { get; set; }

	private RTHandle destination { get; set; }

	private int destinationID { get; set; }

	public CopyColorPass(RenderPassEvent evt, Material samplingMaterial, Material copyColorMaterial = null)
	{
	}

	public static void ConfigureDescriptor(Downsampling downsamplingMethod, ref RenderTextureDescriptor descriptor, out FilterMode filterMode)
	{
		filterMode = default(FilterMode);
	}

	[Obsolete("Use RTHandles for source and destination.")]
	public void Setup(RenderTargetIdentifier source, RenderTargetHandle destination, Downsampling downsampling)
	{
	}

	public void Setup(RTHandle source, RTHandle destination, Downsampling downsampling)
	{
	}

	public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
	{
	}

	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	private static void ExecutePass(PassData passData, RTHandle source, RTHandle destination, ref CommandBuffer cmd, bool useDrawProceduralBlit, bool disableFoveatedRenderingForPass)
	{
	}

	internal TextureHandle Render(RenderGraph renderGraph, out TextureHandle destination, in TextureHandle source, Downsampling downsampling, ref RenderingData renderingData)
	{
		destination = default(TextureHandle);
		return default(TextureHandle);
	}

	public override void OnCameraCleanup(CommandBuffer cmd)
	{
	}
}
