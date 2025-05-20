using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine;

[NativeHeader("Modules/Animation/AvatarMask.h")]
[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
[UsedByNativeCode]
[MovedFrom(true, "UnityEditor.Animations", "UnityEditor", null)]
public sealed class AvatarMask : Object
{
	public int transformCount => 0;

	[NativeMethod("GetBodyPart")]
	public bool GetHumanoidBodyPartActive(AvatarMaskBodyPart index)
	{
		return false;
	}

	public string GetTransformPath(int index)
	{
		return null;
	}

	private float GetTransformWeight(int index)
	{
		return 0f;
	}

	public bool GetTransformActive(int index)
	{
		return false;
	}
}
