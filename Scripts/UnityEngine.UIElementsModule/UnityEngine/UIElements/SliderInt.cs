namespace UnityEngine.UIElements;

public class SliderInt : BaseSlider<int>
{
	public new class UxmlFactory : UxmlFactory<SliderInt, UxmlTraits>
	{
	}

	public new class UxmlTraits : BaseSlider<int>.UxmlTraits
	{
		private UxmlIntAttributeDescription m_LowValue;

		private UxmlIntAttributeDescription m_HighValue;

		private UxmlIntAttributeDescription m_PageSize;

		private UxmlBoolAttributeDescription m_ShowInputField;

		private UxmlEnumAttributeDescription<SliderDirection> m_Direction;

		private UxmlBoolAttributeDescription m_Inverted;

		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}

	public new static readonly string ussClassName;

	public new static readonly string labelUssClassName;

	public new static readonly string inputUssClassName;

	public override float pageSize
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public SliderInt()
		: base((string)null, (int)default(_00210), (int)default(_00210), default(SliderDirection), 0f)
	{
	}//IL_0027: Expected I4, but got O
	//IL_0027: Expected I4, but got O


	public SliderInt(string label, int start = 0, int end = 10, SliderDirection direction = SliderDirection.Horizontal, float pageSize = 0f)
		: base((string)null, (int)default(_00210), (int)default(_00210), default(SliderDirection), 0f)
	{
	}//IL_0027: Expected I4, but got O
	//IL_0027: Expected I4, but got O


	public override void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, int startValue)
	{
	}

	internal override int SliderLerpUnclamped(int a, int b, float interpolant)
	{
		return 0;
	}

	internal override float SliderNormalizeValue(int currentValue, int lowerValue, int higherValue)
	{
		return 0f;
	}

	internal override int ParseStringToValue(string previousValue, string newValue)
	{
		return 0;
	}

	internal override void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos)
	{
	}

	internal override void ComputeValueFromKey(SliderKey sliderKey, bool isShift)
	{
	}
}
