using System;

namespace UnityEngine.Rendering.Universal;

[Serializable]
internal class ScreenSpaceAmbientOcclusionSettings
{
	internal enum DepthSource
	{
		Depth = 0,
		DepthNormals = 1
	}

	internal enum NormalQuality
	{
		Low = 0,
		Medium = 1,
		High = 2
	}

	internal enum AOSampleOption
	{
		High = 0,
		Medium = 1,
		Low = 2
	}

	internal enum AOMethodOptions
	{
		BlueNoise = 0,
		InterleavedGradient = 1
	}

	internal enum BlurQualityOptions
	{
		High = 0,
		Medium = 1,
		Low = 2
	}

	[SerializeField]
	internal AOMethodOptions AOMethod;

	[SerializeField]
	internal bool Downsample;

	[SerializeField]
	internal bool AfterOpaque;

	[SerializeField]
	internal DepthSource Source;

	[SerializeField]
	internal NormalQuality NormalSamples;

	[SerializeField]
	internal float Intensity;

	[SerializeField]
	internal float DirectLightingStrength;

	[SerializeField]
	internal float Radius;

	[SerializeField]
	internal AOSampleOption Samples;

	[SerializeField]
	internal BlurQualityOptions BlurQuality;

	[SerializeField]
	internal float Falloff;

	[SerializeField]
	internal int SampleCount;
}
