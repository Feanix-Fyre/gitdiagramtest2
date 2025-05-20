namespace UnityEngine.Rendering.Universal;

public class DebugDisplaySettingsLighting : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
{
	internal static class Strings
	{
		public static readonly DebugUI.Widget.NameAndTooltip LightingDebugMode;

		public static readonly DebugUI.Widget.NameAndTooltip LightingFeatures;

		public static readonly DebugUI.Widget.NameAndTooltip HDRDebugMode;
	}

	internal static class WidgetFactory
	{
		internal static DebugUI.Widget CreateLightingDebugMode(SettingsPanel panel)
		{
			return null;
		}

		internal static DebugUI.Widget CreateLightingFeatures(SettingsPanel panel)
		{
			return null;
		}

		internal static DebugUI.Widget CreateHDRDebugMode(SettingsPanel panel)
		{
			return null;
		}
	}

	[DisplayInfo(name = "Lighting", order = 3)]
	internal class SettingsPanel : DebugDisplaySettingsPanel<DebugDisplaySettingsLighting>
	{
		public SettingsPanel(DebugDisplaySettingsLighting data)
			: base((DebugDisplaySettingsLighting)default(_00210))
		{
		}
	}

	public DebugLightingMode lightingDebugMode { get; set; }

	public DebugLightingFeatureFlags lightingFeatureFlags { get; set; }

	public HDRDebugMode hdrDebugMode { get; set; }

	public bool AreAnySettingsActive => false;

	public bool IsPostProcessingAllowed => false;

	public bool IsLightingActive => false;

	public bool TryGetScreenClearColor(ref Color color)
	{
		return false;
	}

	IDebugDisplaySettingsPanelDisposable IDebugDisplaySettingsData.CreatePanel()
	{
		return null;
	}
}
