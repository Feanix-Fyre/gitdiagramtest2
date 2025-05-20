using System;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeType("Modules/Animation/AnimationClip.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationClip.bindings.h")]
public sealed class AnimationClip : Motion
{
	[NativeProperty("Length", false, TargetType.Function)]
	public float length => 0f;

	[NativeProperty("SampleRate", false, TargetType.Function)]
	public float frameRate
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[NativeProperty("WrapMode", false, TargetType.Function)]
	public WrapMode wrapMode
	{
		get
		{
			return default(WrapMode);
		}
		set
		{
		}
	}

	public bool legacy
	{
		[NativeMethod("IsLegacy")]
		get
		{
			return false;
		}
		[NativeMethod("SetLegacy")]
		set
		{
		}
	}

	public bool empty
	{
		[NativeMethod("IsEmpty")]
		get
		{
			return false;
		}
	}

	public bool hasGenericRootTransform
	{
		[NativeMethod("HasGenericRootTransform")]
		get
		{
			return false;
		}
	}

	public bool hasMotionCurves
	{
		[NativeMethod("HasMotionCurves")]
		get
		{
			return false;
		}
	}

	public bool hasRootCurves
	{
		[NativeMethod("HasRootCurves")]
		get
		{
			return false;
		}
	}

	internal bool hasRootMotion
	{
		[FreeFunction(Name = "AnimationClipBindings::Internal_GetHasRootMotion", HasExplicitThis = true)]
		get
		{
			return false;
		}
	}

	public AnimationEvent[] events => null;

	[FreeFunction("AnimationClipBindings::Internal_CreateAnimationClip")]
	private static void Internal_CreateAnimationClip([Writable] AnimationClip self)
	{
	}

	public void SampleAnimation(GameObject go, float time)
	{
	}

	[NativeHeader("Modules/Animation/AnimationUtility.h")]
	[FreeFunction]
	internal static void SampleAnimation([NotNull("ArgumentNullException")] GameObject go, [NotNull("ArgumentNullException")] AnimationClip clip, float inTime, WrapMode wrapMode)
	{
	}

	[FreeFunction("AnimationClipBindings::Internal_SetCurve", HasExplicitThis = true)]
	public void SetCurve([NotNull("ArgumentNullException")] string relativePath, [NotNull("ArgumentNullException")] Type type, [NotNull("ArgumentNullException")] string propertyName, AnimationCurve curve)
	{
	}

	public void EnsureQuaternionContinuity()
	{
	}

	[FreeFunction(Name = "AnimationClipBindings::GetEventsInternal", HasExplicitThis = true)]
	private Array GetEventsInternal()
	{
		return null;
	}
}
