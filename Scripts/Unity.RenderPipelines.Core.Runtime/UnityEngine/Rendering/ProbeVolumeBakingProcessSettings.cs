using System;

namespace UnityEngine.Rendering;

[Serializable]
internal struct ProbeVolumeBakingProcessSettings
{
	internal enum SettingsVersion
	{
		Initial = 0,
		ThreadedVirtualOffset = 1,
		Max = 2,
		Current = 1
	}

	[SerializeField]
	private SettingsVersion m_Version;

	public ProbeDilationSettings dilationSettings;

	public VirtualOffsetSettings virtualOffsetSettings;

	internal static ProbeVolumeBakingProcessSettings Default => default(ProbeVolumeBakingProcessSettings);

	internal ProbeVolumeBakingProcessSettings(ProbeDilationSettings dilationSettings, VirtualOffsetSettings virtualOffsetSettings)
	{
		m_Version = default(SettingsVersion);
		this.dilationSettings = default(ProbeDilationSettings);
		this.virtualOffsetSettings = default(VirtualOffsetSettings);
	}

	internal void SetDefaults()
	{
	}

	internal void Upgrade()
	{
	}
}
