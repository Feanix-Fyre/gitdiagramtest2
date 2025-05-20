using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine;

[StaticAccessor("GetQualitySettings()", StaticAccessorType.Dot)]
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Graphics/QualitySettings.h")]
public sealed class QualitySettings : Object
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static Action<int, int> activeQualityLevelChanged;

	[NativeProperty("ShadowmaskMode")]
	public static ShadowmaskMode shadowmaskMode => default(ShadowmaskMode);

	[NativeProperty("LODBias")]
	public static float lodBias
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static int maximumLODLevel
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static bool enableLODCrossFade
	{
		set
		{
		}
	}

	public static int vSyncCount
	{
		set
		{
		}
	}

	public static int antiAliasing
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static bool billboardsFaceCameraPosition => false;

	[NativeName("RenderPipeline")]
	private static ScriptableObject INTERNAL_renderPipeline
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static RenderPipelineAsset renderPipeline
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[NativeProperty("QualitySettingsNames")]
	public static string[] names => null;

	public static ColorSpace activeColorSpace
	{
		[StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
		[NativeName("GetColorSpace")]
		get
		{
			return default(ColorSpace);
		}
	}

	[RequiredByNativeCode]
	internal static void OnActiveQualityLevelChanged(int previousQualityLevel, int currentQualityLevel)
	{
	}

	public static void SetQualityLevel(int index)
	{
	}

	[NativeName("GetCurrentIndex")]
	public static int GetQualityLevel()
	{
		return 0;
	}

	[NativeName("SetCurrentIndex")]
	public static void SetQualityLevel(int index, [DefaultValue("true")] bool applyExpensiveChanges)
	{
	}
}
