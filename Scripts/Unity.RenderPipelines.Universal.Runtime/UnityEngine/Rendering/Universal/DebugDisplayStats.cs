namespace UnityEngine.Rendering.Universal;

internal class DebugDisplayStats : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
{
	[DisplayInfo(name = "Display Stats", order = int.MinValue)]
	private class StatsPanel : DebugDisplaySettingsPanel
	{
		public override DebugUI.Flags Flags => default(DebugUI.Flags);

		public StatsPanel(DebugFrameTiming frameTiming)
		{
		}
	}

	private DebugFrameTiming m_DebugFrameTiming;

	public bool AreAnySettingsActive => false;

	public bool IsPostProcessingAllowed => false;

	public bool IsLightingActive => false;

	public void UpdateFrameTiming()
	{
	}

	public bool TryGetScreenClearColor(ref Color _)
	{
		return false;
	}

	public IDebugDisplaySettingsPanelDisposable CreatePanel()
	{
		return null;
	}
}
