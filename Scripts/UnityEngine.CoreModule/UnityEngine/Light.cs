using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine;

[NativeHeader("Runtime/Camera/Light.h")]
[RequireComponent(typeof(Transform))]
[NativeHeader("Runtime/Export/Graphics/Light.bindings.h")]
[RequireComponent(typeof(Transform))]
public sealed class Light : Behaviour
{
	private int m_BakedIndex;

	[NativeProperty("LightType")]
	public LightType type
	{
		get
		{
			return default(LightType);
		}
		set
		{
		}
	}

	public float spotAngle
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float innerSpotAngle => 0f;

	public Color color
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public float colorTemperature => 0f;

	public bool useColorTemperature => false;

	public float intensity
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float bounceIntensity => 0f;

	public float shadowBias => 0f;

	public float shadowNormalBias => 0f;

	public float shadowNearPlane => 0f;

	public float range
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public LightBakingOutput bakingOutput => default(LightBakingOutput);

	public int cullingMask
	{
		set
		{
		}
	}

	public int renderingLayerMask
	{
		set
		{
		}
	}

	public LightShadows shadows
	{
		[NativeMethod("GetShadowType")]
		get
		{
			return default(LightShadows);
		}
		[FreeFunction("Light_Bindings::SetShadowType", HasExplicitThis = true, ThrowsException = true)]
		set
		{
		}
	}

	public float shadowStrength => 0f;

	public LightShadowResolution shadowResolution => default(LightShadowResolution);

	public float cookieSize => 0f;

	public Texture cookie => null;

	[SpecialName]
	private void get_color_Injected(out Color ret)
	{
		ret = default(Color);
	}

	[SpecialName]
	private void set_color_Injected(ref Color value)
	{
	}

	[SpecialName]
	private void get_bakingOutput_Injected(out LightBakingOutput ret)
	{
		ret = default(LightBakingOutput);
	}
}
