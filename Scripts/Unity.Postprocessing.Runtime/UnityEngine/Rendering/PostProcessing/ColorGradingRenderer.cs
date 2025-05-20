using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
internal sealed class ColorGradingRenderer : PostProcessEffectRenderer<ColorGrading>
{
	private enum Pass
	{
		LutGenLDRFromScratch = 0,
		LutGenLDR = 1,
		LutGenHDR2D = 2
	}

	private Texture2D m_GradingCurves;

	private readonly Color[] m_Pixels;

	private RenderTexture m_InternalLdrLut;

	private RenderTexture m_InternalLogLut;

	private const int k_Lut2DSize = 32;

	private const int k_Lut3DSize = 33;

	private readonly HableCurve m_HableCurve;

	public override void Render(PostProcessRenderContext context)
	{
	}

	private void RenderExternalPipeline3D(PostProcessRenderContext context)
	{
	}

	private void RenderHDRPipeline3D(PostProcessRenderContext context)
	{
	}

	private void RenderHDRPipeline2D(PostProcessRenderContext context)
	{
	}

	private void RenderLDRPipeline2D(PostProcessRenderContext context)
	{
	}

	private void CheckInternalLogLut()
	{
	}

	private void CheckInternalStripLut()
	{
	}

	private Texture2D GetCurveTexture(bool hdr)
	{
		return null;
	}

	private static bool IsRenderTextureFormatSupportedForLinearFiltering(RenderTextureFormat format)
	{
		return false;
	}

	private static RenderTextureFormat GetLutFormat()
	{
		return default(RenderTextureFormat);
	}

	private static TextureFormat GetCurveFormat()
	{
		return default(TextureFormat);
	}

	public override void Release()
	{
	}
}
