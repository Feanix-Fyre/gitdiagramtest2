namespace UnityEngine.Rendering.Universal;

internal class DebugDisplaySettingsCommon : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
{
	internal static class WidgetFactory
	{
		internal static DebugUI.Widget CreateMissingDebugShadersWarning()
		{
			return null;
		}
	}

	[DisplayInfo(name = "Frequently Used", order = -1)]
	private class SettingsPanel : DebugDisplaySettingsPanel
	{
		private const string k_GoToSectionString = "Go to Section...";

		public override DebugUI.Flags Flags => default(DebugUI.Flags);
	}

	public bool AreAnySettingsActive => false;

	public bool IsPostProcessingAllowed => false;

	public bool IsLightingActive => false;

	public bool TryGetScreenClearColor(ref Color _)
	{
		return false;
	}

	public IDebugDisplaySettingsPanelDisposable CreatePanel()
	{
		return null;
	}
}
