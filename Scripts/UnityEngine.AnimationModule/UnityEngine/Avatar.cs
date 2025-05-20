using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[UsedByNativeCode]
[NativeHeader("Modules/Animation/Avatar.h")]
public class Avatar : Object
{
	public bool isValid
	{
		[NativeMethod("IsValid")]
		get
		{
			return false;
		}
	}

	public bool isHuman
	{
		[NativeMethod("IsHuman")]
		get
		{
			return false;
		}
	}

	public HumanDescription humanDescription => default(HumanDescription);

	private Avatar()
	{
	}

	internal float GetAxisLength(int humanId)
	{
		return 0f;
	}

	internal Quaternion GetPostRotation(int humanId)
	{
		return default(Quaternion);
	}

	[NativeMethod("GetAxisLength")]
	internal float Internal_GetAxisLength(int humanId)
	{
		return 0f;
	}

	[NativeMethod("GetPostRotation")]
	internal Quaternion Internal_GetPostRotation(int humanId)
	{
		return default(Quaternion);
	}

	[SpecialName]
	private void get_humanDescription_Injected(out HumanDescription ret)
	{
		ret = default(HumanDescription);
	}

	private void Internal_GetPostRotation_Injected(int humanId, out Quaternion ret)
	{
		ret = default(Quaternion);
	}
}
