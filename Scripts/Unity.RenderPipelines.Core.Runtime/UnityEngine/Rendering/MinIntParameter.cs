using System;
using System.Diagnostics;

namespace UnityEngine.Rendering;

[Serializable]
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class MinIntParameter : IntParameter
{
	[NonSerialized]
	public int min;

	public override int value
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public MinIntParameter(int value, int min, bool overrideState = false)
		: base(0)
	{
	}
}
