namespace UnityEngine.Rendering.Universal.Internal;

internal class DrawObjectsWithRenderingLayersPass : DrawObjectsPass
{
	private RTHandle[] m_ColorTargetIndentifiers;

	private RTHandle m_DepthTargetIndentifiers;

	public DrawObjectsWithRenderingLayersPass(URPProfileId profilerTag, bool opaque, RenderPassEvent evt, RenderQueueRange renderQueueRange, LayerMask layerMask, StencilState stencilState, int stencilReference)
		: base(null, null, opaque: false, default(RenderPassEvent), default(RenderQueueRange), default(LayerMask), default(StencilState), 0)
	{
	}

	public void Setup(RTHandle colorAttachment, RTHandle renderingLayersTexture, RTHandle depthAttachment)
	{
	}

	public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
	{
	}

	protected override void OnExecute(CommandBuffer cmd)
	{
	}
}
