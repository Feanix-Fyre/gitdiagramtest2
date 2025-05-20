using System;

namespace UnityEngine.Rendering.Universal;

[Obsolete("ForwardRenderer has been deprecated (UnityUpgradable) -> UniversalRenderer", true)]
public sealed class ForwardRenderer : ScriptableRenderer
{
	private static readonly string k_ErrorMessage;

	public ForwardRenderer(ForwardRendererData data)
		: base(null)
	{
	}

	public override void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	public override void SetupLights(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	public override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData)
	{
	}

	public override void FinishRendering(CommandBuffer cmd)
	{
	}

	internal override void SwapColorBuffer(CommandBuffer cmd)
	{
	}

	internal override RTHandle GetCameraColorFrontBuffer(CommandBuffer cmd)
	{
		return null;
	}
}
