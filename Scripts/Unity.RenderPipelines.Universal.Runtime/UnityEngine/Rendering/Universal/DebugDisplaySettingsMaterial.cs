namespace UnityEngine.Rendering.Universal;

public class DebugDisplaySettingsMaterial : IDebugDisplaySettingsData, IDebugDisplaySettingsQuery
{
	public enum AlbedoDebugValidationPreset
	{
		DefaultLuminance = 0,
		BlackAcrylicPaint = 1,
		DarkSoil = 2,
		WornAsphalt = 3,
		DryClaySoil = 4,
		GreenGrass = 5,
		OldConcrete = 6,
		RedClayTile = 7,
		DrySand = 8,
		NewConcrete = 9,
		WhiteAcrylicPaint = 10,
		FreshSnow = 11,
		BlueSky = 12,
		Foliage = 13,
		Custom = 14
	}

	private struct AlbedoDebugValidationPresetData
	{
		public string name;

		public Color color;

		public float minLuminance;

		public float maxLuminance;
	}

	private static class Strings
	{
		public const string AlbedoSettingsContainerName = "Albedo Settings";

		public const string MetallicSettingsContainerName = "Metallic Settings";

		public static readonly DebugUI.Widget.NameAndTooltip MaterialOverride;

		public static readonly DebugUI.Widget.NameAndTooltip VertexAttribute;

		public static readonly DebugUI.Widget.NameAndTooltip MaterialValidationMode;

		public static readonly DebugUI.Widget.NameAndTooltip ValidationPreset;

		public static readonly DebugUI.Widget.NameAndTooltip AlbedoCustomColor;

		public static readonly DebugUI.Widget.NameAndTooltip AlbedoMinLuminance;

		public static readonly DebugUI.Widget.NameAndTooltip AlbedoMaxLuminance;

		public static readonly DebugUI.Widget.NameAndTooltip AlbedoHueTolerance;

		public static readonly DebugUI.Widget.NameAndTooltip AlbedoSaturationTolerance;

		public static readonly DebugUI.Widget.NameAndTooltip MetallicMinValue;

		public static readonly DebugUI.Widget.NameAndTooltip MetallicMaxValue;
	}

	internal static class WidgetFactory
	{
		internal static DebugUI.Widget CreateMaterialOverride(SettingsPanel panel)
		{
			return null;
		}

		internal static DebugUI.Widget CreateVertexAttribute(SettingsPanel panel)
		{
			return null;
		}

		internal static DebugUI.Widget CreateMaterialValidationMode(SettingsPanel panel)
		{
			return null;
		}

		internal static DebugUI.Widget CreateAlbedoPreset(SettingsPanel panel)
		{
			return null;
		}

		internal static DebugUI.Widget CreateAlbedoCustomColor(SettingsPanel panel)
		{
			return null;
		}

		internal static DebugUI.Widget CreateAlbedoMinLuminance(SettingsPanel panel)
		{
			return null;
		}

		internal static DebugUI.Widget CreateAlbedoMaxLuminance(SettingsPanel panel)
		{
			return null;
		}

		internal static DebugUI.Widget CreateAlbedoHueTolerance(SettingsPanel panel)
		{
			return null;
		}

		internal static DebugUI.Widget CreateAlbedoSaturationTolerance(SettingsPanel panel)
		{
			return null;
		}

		internal static DebugUI.Widget CreateMetallicMinValue(SettingsPanel panel)
		{
			return null;
		}

		internal static DebugUI.Widget CreateMetallicMaxValue(SettingsPanel panel)
		{
			return null;
		}
	}

	[DisplayInfo(name = "Material", order = 2)]
	internal class SettingsPanel : DebugDisplaySettingsPanel<DebugDisplaySettingsMaterial>
	{
		public SettingsPanel(DebugDisplaySettingsMaterial data)
			: base((DebugDisplaySettingsMaterial)default(_00210))
		{
		}
	}

	private AlbedoDebugValidationPresetData[] m_AlbedoDebugValidationPresetData;

	private AlbedoDebugValidationPreset m_AlbedoValidationPreset;

	private float m_AlbedoHueTolerance;

	private float m_AlbedoSaturationTolerance;

	public AlbedoDebugValidationPreset albedoValidationPreset
	{
		get
		{
			return default(AlbedoDebugValidationPreset);
		}
		set
		{
		}
	}

	public float albedoMinLuminance { get; set; }

	public float albedoMaxLuminance { get; set; }

	public float albedoHueTolerance
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float albedoSaturationTolerance
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public Color albedoCompareColor { get; set; }

	public float metallicMinValue { get; set; }

	public float metallicMaxValue { get; set; }

	public DebugMaterialValidationMode materialValidationMode { get; set; }

	public DebugMaterialMode materialDebugMode { get; set; }

	public DebugVertexAttributeMode vertexAttributeDebugMode { get; set; }

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
