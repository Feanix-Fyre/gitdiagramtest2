using System.Collections.Generic;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal;

internal static class RenderingLayerUtils
{
	public enum Event
	{
		DepthNormalPrePass = 0,
		Opaque = 1
	}

	public enum MaskSize
	{
		Bits8 = 0,
		Bits16 = 1,
		Bits24 = 2,
		Bits32 = 3
	}

	public static void CombineRendererEvents(bool isDeferred, int msaaSampleCount, Event rendererEvent, ref Event combinedEvent)
	{
	}

	public static bool RequireRenderingLayers(UniversalRendererData universalRendererData, int msaaSampleCount, out Event combinedEvent, out MaskSize combinedMaskSize)
	{
		combinedEvent = default(Event);
		combinedMaskSize = default(MaskSize);
		return false;
	}

	public static bool RequireRenderingLayers(UniversalRenderer universalRenderer, List<ScriptableRendererFeature> rendererFeatures, int msaaSampleCount, out Event combinedEvent, out MaskSize combinedMaskSize)
	{
		combinedEvent = default(Event);
		combinedMaskSize = default(MaskSize);
		return false;
	}

	public static void SetupProperties(CommandBuffer cmd, MaskSize maskSize)
	{
	}

	public static GraphicsFormat GetFormat(MaskSize maskSize)
	{
		return default(GraphicsFormat);
	}

	public static uint ToValidRenderingLayers(uint renderingLayers)
	{
		return 0u;
	}

	private static MaskSize GetMaskSize(int bits)
	{
		return default(MaskSize);
	}

	private static int GetBits(MaskSize maskSize)
	{
		return 0;
	}

	private static Event Combine(Event a, Event b)
	{
		return default(Event);
	}

	private static MaskSize Combine(MaskSize a, MaskSize b)
	{
		return default(MaskSize);
	}
}
