using System;

namespace UnityEngine.Rendering;

[Serializable]
internal struct ProbeDilationSettings
{
	public bool enableDilation;

	public float dilationDistance;

	public float dilationValidityThreshold;

	public int dilationIterations;

	public bool squaredDistWeighting;

	internal void SetDefaults()
	{
	}

	internal void UpgradeFromTo(ProbeVolumeBakingProcessSettings.SettingsVersion from, ProbeVolumeBakingProcessSettings.SettingsVersion to)
	{
	}
}
