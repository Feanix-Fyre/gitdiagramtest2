using System;
using System.Diagnostics;

namespace UnityEngine.Rendering;

[Serializable]
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class Vector2Parameter : VolumeParameter<Vector2>
{
	public Vector2Parameter(Vector2 value, bool overrideState = false)
	{
	}

	public override void Interp(Vector2 from, Vector2 to, float t)
	{
	}
}
