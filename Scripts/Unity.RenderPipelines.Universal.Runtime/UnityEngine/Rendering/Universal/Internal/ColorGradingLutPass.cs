using UnityEngine.Experimental.Rendering;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal;

public class ColorGradingLutPass : ScriptableRenderPass
{
	private class PassData
	{
		internal RenderingData renderingData;

		internal Material lutBuilderLdr;

		internal Material lutBuilderHdr;

		internal bool allowColorGradingACESHDR;

		internal TextureHandle internalLut;
	}

	private static class ShaderConstants
	{
		public static readonly int _Lut_Params;

		public static readonly int _ColorBalance;

		public static readonly int _ColorFilter;

		public static readonly int _ChannelMixerRed;

		public static readonly int _ChannelMixerGreen;

		public static readonly int _ChannelMixerBlue;

		public static readonly int _HueSatCon;

		public static readonly int _Lift;

		public static readonly int _Gamma;

		public static readonly int _Gain;

		public static readonly int _Shadows;

		public static readonly int _Midtones;

		public static readonly int _Highlights;

		public static readonly int _ShaHiLimits;

		public static readonly int _SplitShadows;

		public static readonly int _SplitHighlights;

		public static readonly int _CurveMaster;

		public static readonly int _CurveRed;

		public static readonly int _CurveGreen;

		public static readonly int _CurveBlue;

		public static readonly int _CurveHueVsHue;

		public static readonly int _CurveHueVsSat;

		public static readonly int _CurveLumVsSat;

		public static readonly int _CurveSatVsSat;
	}

	private readonly Material m_LutBuilderLdr;

	private readonly Material m_LutBuilderHdr;

	internal readonly GraphicsFormat m_HdrLutFormat;

	internal readonly GraphicsFormat m_LdrLutFormat;

	private PassData m_PassData;

	private RTHandle m_InternalLut;

	private bool m_AllowColorGradingACESHDR;

	public ColorGradingLutPass(RenderPassEvent evt, PostProcessData data)
	{
	}

	public void Setup(in RTHandle internalLut)
	{
	}

	public void ConfigureDescriptor(in PostProcessingData postProcessingData, out RenderTextureDescriptor descriptor, out FilterMode filterMode)
	{
		descriptor = default(RenderTextureDescriptor);
		filterMode = default(FilterMode);
	}

	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	private static void ExecutePass(ScriptableRenderContext context, PassData passData, ref RenderingData renderingData, RTHandle internalLutTarget)
	{
	}

	internal void Render(RenderGraph renderGraph, out TextureHandle internalColorLut, ref RenderingData renderingData)
	{
		internalColorLut = default(TextureHandle);
	}

	public void Cleanup()
	{
	}
}
