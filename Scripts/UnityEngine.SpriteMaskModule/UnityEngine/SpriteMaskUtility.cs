using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Modules/SpriteMask/Public/ScriptBindings/SpriteMask.bindings.h")]
[StaticAccessor("SpriteUtilityBindings", StaticAccessorType.DoubleColon)]
public static class SpriteMaskUtility
{
	public static bool HasSpriteMaskInScene()
	{
		return false;
	}
}
