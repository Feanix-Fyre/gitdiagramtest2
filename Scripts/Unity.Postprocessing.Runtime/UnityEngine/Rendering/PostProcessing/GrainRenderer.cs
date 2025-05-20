using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
internal sealed class GrainRenderer : PostProcessEffectRenderer<Grain>
{
	private RenderTexture m_GrainLookupRT;

	private const int k_SampleCount = 1024;

	private int m_SampleIndex;

	public override void Render(PostProcessRenderContext context)
	{
	}

	private RenderTextureFormat GetLookupFormat()
	{
		return default(RenderTextureFormat);
	}

	public override void Release()
	{
	}
}
