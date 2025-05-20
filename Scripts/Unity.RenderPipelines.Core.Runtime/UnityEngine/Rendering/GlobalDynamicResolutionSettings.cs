using System;

namespace UnityEngine.Rendering;

[Serializable]
public struct GlobalDynamicResolutionSettings
{
	public bool enabled;

	public bool useMipBias;

	public bool enableDLSS;

	public uint DLSSPerfQualitySetting;

	public DynamicResolutionHandler.UpsamplerScheduleType DLSSInjectionPoint;

	public bool DLSSUseOptimalSettings;

	[Range(0f, 1f)]
	public float DLSSSharpness;

	public bool fsrOverrideSharpness;

	[Range(0f, 1f)]
	public float fsrSharpness;

	public float maxPercentage;

	public float minPercentage;

	public DynamicResolutionType dynResType;

	public DynamicResUpscaleFilter upsampleFilter;

	public bool forceResolution;

	public float forcedPercentage;

	public float lowResTransparencyMinimumThreshold;

	public float rayTracingHalfResThreshold;

	public float lowResSSGIMinimumThreshold;

	public float lowResVolumetricCloudsMinimumThreshold;

	public static GlobalDynamicResolutionSettings NewDefault()
	{
		return default(GlobalDynamicResolutionSettings);
	}
}
