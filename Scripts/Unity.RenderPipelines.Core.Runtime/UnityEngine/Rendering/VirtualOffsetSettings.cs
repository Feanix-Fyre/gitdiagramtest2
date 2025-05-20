using System;

namespace UnityEngine.Rendering;

[Serializable]
internal struct VirtualOffsetSettings
{
	public bool useVirtualOffset;

	[Range(0f, 1f)]
	public float outOfGeoOffset;

	[Range(0f, 2f)]
	public float searchMultiplier;

	[Range(-0.05f, 0f)]
	public float rayOriginBias;

	[Range(4f, 24f)]
	public int maxHitsPerRay;

	public LayerMask collisionMask;

	internal void SetDefaults()
	{
	}

	internal void UpgradeFromTo(ProbeVolumeBakingProcessSettings.SettingsVersion from, ProbeVolumeBakingProcessSettings.SettingsVersion to)
	{
	}
}
