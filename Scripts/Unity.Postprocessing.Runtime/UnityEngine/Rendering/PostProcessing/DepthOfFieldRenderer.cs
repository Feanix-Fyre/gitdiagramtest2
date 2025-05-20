using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
internal sealed class DepthOfFieldRenderer : PostProcessEffectRenderer<DepthOfField>
{
	private enum Pass
	{
		CoCCalculation = 0,
		CoCTemporalFilter = 1,
		DownsampleAndPrefilter = 2,
		BokehSmallKernel = 3,
		BokehMediumKernel = 4,
		BokehLargeKernel = 5,
		BokehVeryLargeKernel = 6,
		PostFilter = 7,
		Combine = 8,
		DebugOverlay = 9
	}

	private const int k_NumEyes = 2;

	private const int k_NumCoCHistoryTextures = 2;

	private readonly RenderTexture[][] m_CoCHistoryTextures;

	private int[] m_HistoryPingPong;

	private const float k_FilmHeight = 0.024f;

	public override DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	private RenderTextureFormat SelectFormat(RenderTextureFormat primary, RenderTextureFormat secondary)
	{
		return default(RenderTextureFormat);
	}

	private float CalculateMaxCoCRadius(int screenHeight)
	{
		return 0f;
	}

	private RenderTexture CheckHistory(int eye, int id, PostProcessRenderContext context, RenderTextureFormat format)
	{
		return null;
	}

	public override void Render(PostProcessRenderContext context)
	{
	}

	public override void Release()
	{
	}
}
