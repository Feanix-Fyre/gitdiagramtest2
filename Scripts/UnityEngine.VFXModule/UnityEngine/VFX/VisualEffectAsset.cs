using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.VFX;

[UsedByNativeCode]
[NativeHeader("Modules/VFX/Public/VisualEffectAsset.h")]
[NativeHeader("VFXScriptingClasses.h")]
public class VisualEffectAsset : VisualEffectObject
{
	public static readonly int PlayEventID;

	public static readonly int StopEventID;
}
