using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal;

internal class DrawScreenSpaceUIPass : ScriptableRenderPass
{
	private class PassData
	{
		internal CommandBuffer cmd;

		internal Camera camera;

		internal TextureHandle offscreenTexture;
	}

	private PassData m_PassData;

	private RTHandle m_ColorTarget;

	private RTHandle m_DepthTarget;

	private bool m_RenderOffscreen;

	public DrawScreenSpaceUIPass(RenderPassEvent evt, bool renderOffscreen)
	{
	}

	public static void ConfigureColorDescriptor(ref RenderTextureDescriptor descriptor, int cameraWidth, int cameraHeight)
	{
	}

	public static void ConfigureDepthDescriptor(ref RenderTextureDescriptor descriptor, int depthBufferBits, int cameraWidth, int cameraHeight)
	{
	}

	private static void ExecutePass(ScriptableRenderContext context, PassData passData)
	{
	}

	public void Dispose()
	{
	}

	public void Setup(ref CameraData cameraData, int depthBufferBits)
	{
	}

	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	internal void RenderOffscreen(RenderGraph renderGraph, int depthBufferBits, out TextureHandle output, ref RenderingData renderingData)
	{
		output = default(TextureHandle);
	}

	internal void RenderOverlay(RenderGraph renderGraph, in TextureHandle colorBuffer, in TextureHandle depthBuffer, ref RenderingData renderingData)
	{
	}
}
