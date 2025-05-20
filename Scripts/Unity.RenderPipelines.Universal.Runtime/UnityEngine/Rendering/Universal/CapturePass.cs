namespace UnityEngine.Rendering.Universal;

internal class CapturePass : ScriptableRenderPass
{
	private RTHandle m_CameraColorHandle;

	private const string m_ProfilerTag = "Capture Pass";

	private static readonly ProfilingSampler m_ProfilingSampler;

	public CapturePass(RenderPassEvent evt)
	{
	}

	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}
}
