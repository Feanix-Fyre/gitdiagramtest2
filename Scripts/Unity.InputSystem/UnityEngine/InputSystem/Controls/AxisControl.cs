using System.Runtime.CompilerServices;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Controls;

public class AxisControl : InputControl<float>
{
	public enum Clamp
	{
		None = 0,
		BeforeNormalize = 1,
		AfterNormalize = 2,
		ToConstantBeforeNormalize = 3
	}

	public Clamp clamp;

	public float clampMin;

	public float clampMax;

	public float clampConstant;

	public bool invert;

	public bool normalize;

	public float normalizeMin;

	public float normalizeMax;

	public float normalizeZero;

	public bool scale;

	public float scaleFactor;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	protected float Preprocess(float value)
	{
		return 0f;
	}

	private float Unpreprocess(float value)
	{
		return 0f;
	}

	protected override void FinishSetup()
	{
	}

	public unsafe override float ReadUnprocessedValueFromState(void* statePtr)
	{
		return 0f;
	}

	public unsafe override void WriteValueIntoState(float value, void* statePtr)
	{
	}

	public unsafe override bool CompareValue(void* firstStatePtr, void* secondStatePtr)
	{
		return false;
	}

	public unsafe override float EvaluateMagnitude(void* statePtr)
	{
		return 0f;
	}

	private float EvaluateMagnitude(float value)
	{
		return 0f;
	}

	protected override FourCC CalculateOptimizedControlDataType()
	{
		return default(FourCC);
	}
}
