using System.Diagnostics.CodeAnalysis;
using Unity.Collections;

namespace UnityEngine.Rendering;

public class KeyframeUtility
{
	public static void ResetAnimationCurve(AnimationCurve curve)
	{
	}

	private static Keyframe LerpSingleKeyframe(Keyframe lhs, Keyframe rhs, float t)
	{
		return default(Keyframe);
	}

	private static Keyframe GetKeyframeAndClampEdge([DisallowNull] NativeArray<Keyframe> keys, int index)
	{
		return default(Keyframe);
	}

	private static Keyframe FetchKeyFromIndexClampEdge([DisallowNull] NativeArray<Keyframe> keys, int index, float segmentStartTime, float segmentEndTime)
	{
		return default(Keyframe);
	}

	private static void EvalCurveSegmentAndDeriv(out float dstValue, out float dstDeriv, Keyframe lhsKey, Keyframe rhsKey, float desiredTime)
	{
		dstValue = default(float);
		dstDeriv = default(float);
	}

	private static Keyframe EvalKeyAtTime([DisallowNull] NativeArray<Keyframe> keys, int lhsIndex, int rhsIndex, float startTime, float endTime, float currTime)
	{
		return default(Keyframe);
	}

	public static void InterpAnimationCurve(ref AnimationCurve lhsAndResultCurve, [DisallowNull] AnimationCurve rhsCurve, float t)
	{
	}
}
