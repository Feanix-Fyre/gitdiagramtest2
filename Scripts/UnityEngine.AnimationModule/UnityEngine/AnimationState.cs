using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[UsedByNativeCode]
[NativeHeader("Modules/Animation/AnimationState.h")]
public sealed class AnimationState : TrackedReference
{
	public bool enabled
	{
		set
		{
		}
	}

	public float weight
	{
		set
		{
		}
	}

	public float time
	{
		set
		{
		}
	}

	public float normalizedTime
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float speed
	{
		set
		{
		}
	}

	public float length => 0f;

	public int layer
	{
		set
		{
		}
	}

	public AnimationClip clip => null;
}
