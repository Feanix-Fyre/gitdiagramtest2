using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[UsedByNativeCode]
[NativeHeader("Runtime/GfxDevice/HDROutputSettings.h")]
public class HDROutputSettings
{
	private int m_DisplayIndex;

	public static HDROutputSettings[] displays;

	private static HDROutputSettings _mainDisplay;

	public static HDROutputSettings main => null;

	public bool active => false;

	public bool available => false;

	public bool automaticHDRTonemapping
	{
		set
		{
		}
	}

	public ColorGamut displayColorGamut => default(ColorGamut);

	public float paperWhiteNits => 0f;

	public int maxFullFrameToneMapLuminance => 0;

	public int maxToneMapLuminance => 0;

	public int minToneMapLuminance => 0;

	[VisibleToOtherModules(new string[] { "UnityEngine.XRModule" })]
	internal HDROutputSettings()
	{
	}

	[VisibleToOtherModules(new string[] { "UnityEngine.XRModule" })]
	internal HDROutputSettings(int displayIndex)
	{
	}

	public void RequestHDRModeChange(bool enabled)
	{
	}

	[FreeFunction("HDROutputSettingsBindings::GetActive", HasExplicitThis = false, ThrowsException = true)]
	private static bool GetActive(int displayIndex)
	{
		return false;
	}

	[FreeFunction("HDROutputSettingsBindings::GetAvailable", HasExplicitThis = false, ThrowsException = true)]
	private static bool GetAvailable(int displayIndex)
	{
		return false;
	}

	[FreeFunction("HDROutputSettingsBindings::SetAutomaticHDRTonemapping", HasExplicitThis = false, ThrowsException = true)]
	private static void SetAutomaticHDRTonemapping(int displayIndex, bool scripted)
	{
	}

	[FreeFunction("HDROutputSettingsBindings::GetDisplayColorGamut", HasExplicitThis = false, ThrowsException = true)]
	private static ColorGamut GetDisplayColorGamut(int displayIndex)
	{
		return default(ColorGamut);
	}

	[FreeFunction("HDROutputSettingsBindings::GetPaperWhiteNits", HasExplicitThis = false, ThrowsException = true)]
	private static float GetPaperWhiteNits(int displayIndex)
	{
		return 0f;
	}

	[FreeFunction("HDROutputSettingsBindings::GetMaxFullFrameToneMapLuminance", HasExplicitThis = false, ThrowsException = true)]
	private static int GetMaxFullFrameToneMapLuminance(int displayIndex)
	{
		return 0;
	}

	[FreeFunction("HDROutputSettingsBindings::GetMaxToneMapLuminance", HasExplicitThis = false, ThrowsException = true)]
	private static int GetMaxToneMapLuminance(int displayIndex)
	{
		return 0;
	}

	[FreeFunction("HDROutputSettingsBindings::GetMinToneMapLuminance", HasExplicitThis = false, ThrowsException = true)]
	private static int GetMinToneMapLuminance(int displayIndex)
	{
		return 0;
	}

	[FreeFunction("HDROutputSettingsBindings::RequestHDRModeChange", HasExplicitThis = false, ThrowsException = true)]
	private static void RequestHDRModeChangeInternal(int displayIndex, bool enabled)
	{
	}
}
