using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
internal sealed class AmbientOcclusionRenderer : PostProcessEffectRenderer<AmbientOcclusion>
{
	private IAmbientOcclusionMethod[] m_Methods;

	public override void Init()
	{
	}

	public bool IsAmbientOnly(PostProcessRenderContext context)
	{
		return false;
	}

	public IAmbientOcclusionMethod Get()
	{
		return null;
	}

	public override DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	public override void Release()
	{
	}

	public ScalableAO GetScalableAO()
	{
		return null;
	}

	public MultiScaleVO GetMultiScaleVO()
	{
		return null;
	}

	public override void Render(PostProcessRenderContext context)
	{
	}
}
