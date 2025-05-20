using System;
using System.Diagnostics;

namespace UnityEngine.Rendering;

[Serializable]
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class NoInterpFloatRangeParameter : VolumeParameter<Vector2>
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

	public NoInterpFloatRangeParameter(Vector2 value, float min, float max, bool overrideState = false)
	{
	}
}
