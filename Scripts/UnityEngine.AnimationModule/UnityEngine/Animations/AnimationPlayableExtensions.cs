using UnityEngine.Bindings;
using UnityEngine.Playables;

namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/AnimationClip.h")]
[NativeHeader("Modules/Animation/Director/AnimationPlayableExtensions.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
public static class AnimationPlayableExtensions
{
	public static void SetAnimatedProperties<U>(this U playable, AnimationClip clip) where U : struct, IPlayable
	{
	}

	[NativeThrows]
	internal static void SetAnimatedPropertiesInternal(ref PlayableHandle playable, AnimationClip animatedProperties)
	{
	}
}
