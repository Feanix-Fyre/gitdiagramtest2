using System;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements;

public class PanelTextSettings : TextSettings
{
	private static PanelTextSettings s_DefaultPanelTextSettings;

	internal static Func<string, Object> EditorGUIUtilityLoad;

	internal static Func<SystemLanguage> GetCurrentLanguage;

	internal static readonly string s_DefaultEditorPanelTextSettingPath;

	internal static PanelTextSettings defaultPanelTextSettings => null;

	internal static void UpdateLocalizationFontAsset()
	{
	}

	internal FontAsset GetCachedFontAsset(Font font)
	{
		return null;
	}
}
