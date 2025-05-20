using System;

namespace UnityEngine.Rendering;

public class DebugDisplaySettingsVolume : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
{
	private static class Styles
	{
		public static readonly GUIContent none;

		public static readonly GUIContent editorCamera;
	}

	private static class Strings
	{
		public static readonly string none;

		public static readonly string camera;

		public static readonly string parameter;

		public static readonly string component;

		public static readonly string debugViewNotSupported;

		public static readonly string volumeInfo;

		public static readonly string interpolatedValue;

		public static readonly string defaultValue;

		public static readonly string global;

		public static readonly string local;
	}

	internal static class WidgetFactory
	{
		public static DebugUI.EnumField CreateComponentSelector(SettingsPanel panel, Action<DebugUI.Field<int>, int> refresh)
		{
			return null;
		}

		public static DebugUI.ObjectPopupField CreateCameraSelector(SettingsPanel panel, Action<DebugUI.Field<Object>, Object> refresh)
		{
			return null;
		}

		private static DebugUI.Widget CreateVolumeParameterWidget(string name, VolumeParameter param, Func<bool> isHiddenCallback = null)
		{
			return null;
		}

		public static DebugUI.Table CreateVolumeTable(DebugDisplaySettingsVolume data)
		{
			return null;
		}
	}

	[DisplayInfo(name = "Volume", order = int.MaxValue)]
	internal class SettingsPanel : DebugDisplaySettingsPanel<DebugDisplaySettingsVolume>
	{
		private DebugUI.Table m_VolumeTable;

		public SettingsPanel(DebugDisplaySettingsVolume data)
			: base((DebugDisplaySettingsVolume)default(_00210))
		{
		}

		private void Refresh()
		{
		}
	}

	internal int volumeComponentEnumIndex;

	public IVolumeDebugSettings2 volumeDebugSettings { get; }

	public bool AreAnySettingsActive => false;

	public bool IsPostProcessingAllowed => false;

	public bool IsLightingActive => false;

	public DebugDisplaySettingsVolume(IVolumeDebugSettings2 volumeDebugSettings)
	{
	}

	public bool TryGetScreenClearColor(ref Color color)
	{
		return false;
	}

	public IDebugDisplaySettingsPanelDisposable CreatePanel()
	{
		return null;
	}
}
