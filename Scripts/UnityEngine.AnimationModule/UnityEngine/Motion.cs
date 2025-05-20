using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Modules/Animation/Motion.h")]
public class Motion : Object
{
	public bool isLooping
	{
		[NativeMethod("IsLooping")]
		get
		{
			return false;
		}
	}

	protected Motion()
	{
	}
}
