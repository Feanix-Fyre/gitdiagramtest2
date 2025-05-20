using System;
using System.Diagnostics;

namespace UnityEngine.Rendering;

[Serializable]
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class FloatRangeParameter : VolumeParameter<Vector2>
{
	[NonSerialized]
	public float min;

	[NonSerialized]
	public float max;

	public override Vector2 value
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public FloatRangeParameter(Vector2 value, float min, float max, bool overrideState = false)
	{
	}

	public override void Interp(Vector2 from, Vector2 to, float t)
	{
	}
}
