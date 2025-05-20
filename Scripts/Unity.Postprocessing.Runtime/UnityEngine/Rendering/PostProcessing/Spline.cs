using System;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
public sealed class Spline
{
	public const int k_Precision = 128;

	public const float k_Step = 1f / 128f;

	public AnimationCurve curve;

	[SerializeField]
	private bool m_Loop;

	[SerializeField]
	private float m_ZeroValue;

	[SerializeField]
	private float m_Range;

	private AnimationCurve m_InternalLoopingCurve;

	private int frameCount;

	public float[] cachedData;

	public Spline(AnimationCurve curve, float zeroValue, bool loop, Vector2 bounds)
	{
	}

	public void Cache(int frame)
	{
	}

	public float Evaluate(float t, int length)
	{
		return 0f;
	}

	public float Evaluate(float t)
	{
		return 0f;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
