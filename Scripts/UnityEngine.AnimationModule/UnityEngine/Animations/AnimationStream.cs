using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Animations;

[MovedFrom("UnityEngine.Experimental.Animations")]
[NativeHeader("Modules/Animation/Director/AnimationStream.h")]
[RequiredByNativeCode]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationStream.bindings.h")]
public struct AnimationStream
{
	private uint m_AnimatorBindingsVersion;

	private IntPtr constant;

	private IntPtr input;

	private IntPtr output;

	private IntPtr workspace;

	private IntPtr inputStreamAccessor;

	private IntPtr animationHandleBinder;
}
