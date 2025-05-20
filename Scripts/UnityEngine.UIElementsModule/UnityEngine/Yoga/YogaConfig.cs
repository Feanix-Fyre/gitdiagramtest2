using System;

namespace UnityEngine.Yoga;

internal class YogaConfig
{
	internal static readonly YogaConfig Default;

	private IntPtr _ygConfig;

	private Logger _logger;

	internal IntPtr Handle => (IntPtr)0;

	public bool UseWebDefaults
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float PointScaleFactor
	{
		set
		{
		}
	}

	private YogaConfig(IntPtr ygConfig)
	{
	}

	public YogaConfig()
	{
	}

	~YogaConfig()
	{
	}
}
