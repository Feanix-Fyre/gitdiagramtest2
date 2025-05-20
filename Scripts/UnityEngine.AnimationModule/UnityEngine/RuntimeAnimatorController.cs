using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[ExcludeFromObjectFactory]
[UsedByNativeCode]
[NativeHeader("Modules/Animation/RuntimeAnimatorController.h")]
public class RuntimeAnimatorController : Object
{
	public AnimationClip[] animationClips => null;

	protected RuntimeAnimatorController()
	{
	}
}
