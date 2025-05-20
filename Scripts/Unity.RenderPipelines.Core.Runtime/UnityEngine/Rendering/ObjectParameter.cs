using System;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace UnityEngine.Rendering;

[Serializable]
[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
public class ObjectParameter<T> : VolumeParameter<T>
{
	internal ReadOnlyCollection<VolumeParameter> parameters { get; private set; }

	public sealed override bool overrideState
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public sealed override T value
	{
		get
		{
			return default(T);
		}
		set
		{
		}
	}

	public ObjectParameter(T value)
	{
	}

	internal override void Interp(VolumeParameter from, VolumeParameter to, float t)
	{
	}
}
