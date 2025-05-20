using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine;

[NativeHeader("Runtime/Graphics/QualitySettingsTypes.h")]
[NativeHeader("Runtime/Camera/RenderSettings.h")]
[StaticAccessor("GetRenderSettings()", StaticAccessorType.Dot)]
public sealed class RenderSettings : Object
{
	[NativeProperty("UseFog")]
	public static bool fog
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[NativeProperty("LinearFogStart")]
	public static float fogStartDistance => 0f;

	[NativeProperty("LinearFogEnd")]
	public static float fogEndDistance
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static FogMode fogMode => default(FogMode);

	public static Color fogColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public static float fogDensity => 0f;

	public static AmbientMode ambientMode
	{
		get
		{
			return default(AmbientMode);
		}
		set
		{
		}
	}

	public static Color ambientSkyColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public static Color ambientEquatorColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public static Color ambientGroundColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public static float ambientIntensity => 0f;

	[NativeProperty("AmbientSkyColor")]
	public static Color ambientLight
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public static Color subtractiveShadowColor => default(Color);

	[NativeProperty("SkyboxMaterial")]
	public static Material skybox
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static Light sun
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static SphericalHarmonicsL2 ambientProbe
	{
		[NativeMethod("GetFinalAmbientProbe")]
		get
		{
			return default(SphericalHarmonicsL2);
		}
	}

	public static float reflectionIntensity => 0f;

	[SpecialName]
	private static void get_fogColor_Injected(out Color ret)
	{
		ret = default(Color);
	}

	[SpecialName]
	private static void set_fogColor_Injected(ref Color value)
	{
	}

	[SpecialName]
	private static void get_ambientSkyColor_Injected(out Color ret)
	{
		ret = default(Color);
	}

	[SpecialName]
	private static void set_ambientSkyColor_Injected(ref Color value)
	{
	}

	[SpecialName]
	private static void get_ambientEquatorColor_Injected(out Color ret)
	{
		ret = default(Color);
	}

	[SpecialName]
	private static void set_ambientEquatorColor_Injected(ref Color value)
	{
	}

	[SpecialName]
	private static void get_ambientGroundColor_Injected(out Color ret)
	{
		ret = default(Color);
	}

	[SpecialName]
	private static void set_ambientGroundColor_Injected(ref Color value)
	{
	}

	[SpecialName]
	private static void get_ambientLight_Injected(out Color ret)
	{
		ret = default(Color);
	}

	[SpecialName]
	private static void set_ambientLight_Injected(ref Color value)
	{
	}

	[SpecialName]
	private static void get_subtractiveShadowColor_Injected(out Color ret)
	{
		ret = default(Color);
	}

	[SpecialName]
	private static void get_ambientProbe_Injected(out SphericalHarmonicsL2 ret)
	{
		ret = default(SphericalHarmonicsL2);
	}
}
