using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Modules/Wind/Public/Wind.h")]
public class WindZone : Component
{
	public WindZoneMode mode => default(WindZoneMode);

	public float windMain
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float windTurbulence
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float windPulseFrequency
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}
}
