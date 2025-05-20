using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal;

public class CopyDepthPass : ScriptableRenderPass
{
	private class PassData
	{
		internal TextureHandle source;

		internal TextureHandle destination;

		internal CommandBuffer cmd;

		internal CameraData cameraData;

		internal Material copyDepthMaterial;

		internal int msaaSamples;

		internal bool copyResolvedDepth;

		internal bool copyToDepth;
	}

	private Material m_CopyDepthMaterial;

	internal bool m_CopyResolvedDepth;

	internal bool m_ShouldClear;

	private PassData m_PassData;

	private RTHandle source { get; set; }

	private RTHandle destination { get; set; }

	internal int MssaSamples { get; set; }

	internal bool CopyToDepth { get; set; }

	public CopyDepthPass(RenderPassEvent evt, Material copyDepthMaterial, bool shouldClear = false, bool copyToDepth = false, bool copyResolvedDepth = false)
	{
	}

	public void Setup(RTHandle source, RTHandle destination)
	{
	}

	public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
	{
	}

	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	private static void ExecutePass(ScriptableRenderContext context, PassData passData, ref CommandBuffer cmd, ref CameraData cameraData, RTHandle source, RTHandle destination)
	{
	}

	public override void OnCameraCleanup(CommandBuffer cmd)
	{
	}

	internal void Render(RenderGraph renderGraph, out TextureHandle destination, in TextureHandle source, ref RenderingData renderingData)
	{
		destination = default(TextureHandle);
	}
}
