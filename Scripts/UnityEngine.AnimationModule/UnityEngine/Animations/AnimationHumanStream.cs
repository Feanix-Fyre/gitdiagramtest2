using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Animations;

[NativeHeader("Modules/Animation/Director/AnimationHumanStream.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationHumanStream.bindings.h")]
[MovedFrom("UnityEngine.Experimental.Animations")]
[RequiredByNativeCode]
public struct AnimationHumanStream
{
	private IntPtr stream;
}
