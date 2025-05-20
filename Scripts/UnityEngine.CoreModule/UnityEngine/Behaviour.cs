using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[UsedByNativeCode]
[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
public class Behaviour : Component
{
	[NativeProperty]
	[RequiredByNativeCode]
	public bool enabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[NativeProperty]
	public bool isActiveAndEnabled
	{
		[NativeMethod("IsAddedToManager")]
		get
		{
			return false;
		}
	}
}
