using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
internal sealed class BloomRenderer : PostProcessEffectRenderer<Bloom>
{
	private enum Pass
	{
		Prefilter13 = 0,
		Prefilter4 = 1,
		Downsample13 = 2,
		Downsample4 = 3,
		UpsampleTent = 4,
		UpsampleBox = 5,
		DebugOverlayThreshold = 6,
		DebugOverlayTent = 7,
		DebugOverlayBox = 8
	}

	private struct Level
	{
		internal int down;

		internal int up;
	}

	private Level[] m_Pyramid;

	private const int k_MaxPyramidSize = 16;

	public override void Init()
	{
	}

	public override void Render(PostProcessRenderContext context)
	{
	}
}
