using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Modules/Animation/HumanTrait.h")]
public class HumanTrait
{
	public static int MuscleCount => 0;

	public static string[] MuscleName
	{
		[NativeMethod("GetMuscleNames")]
		get
		{
			return null;
		}
	}

	internal static int GetBoneIndexFromMono(int humanId)
	{
		return 0;
	}
}
