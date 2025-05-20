using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements;

public class Scroller : VisualElement
{
	private class ScrollerSlider : Slider
	{
		public ScrollerSlider(float start, float end, SliderDirection direction, float pageSize)
		{
		}

		internal override float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue)
		{
			return 0f;
		}
	}

	public new class UxmlFactory : UxmlFactory<Scroller, UxmlTraits>
	{
	}

	public new class UxmlTraits : VisualElement.UxmlTraits
	{
		private UxmlFloatAttributeDescription m_LowValue;

		private UxmlFloatAttributeDescription m_HighValue;

		private UxmlEnumAttributeDescription<SliderDirection> m_Direction;

		private UxmlFloatAttributeDescription m_Value;

		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}

	public static readonly string ussClassName;

	public static readonly string horizontalVariantUssClassName;

	public static readonly string verticalVariantUssClassName;

	public static readonly string sliderUssClassName;

	public static readonly string lowButtonUssClassName;

	public static readonly string highButtonUssClassName;

	public Slider slider { get; private set; }

	public RepeatButton lowButton { get; private set; }

	public RepeatButton highButton { get; private set; }

	public float value
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float lowValue
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float highValue
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public SliderDirection direction
	{
		set
		{
		}
	}

	public event Action<float> valueChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public Scroller()
	{
	}

	public Scroller(float lowValue, float highValue, Action<float> valueChanged, SliderDirection direction = SliderDirection.Vertical)
	{
	}

	public void Adjust(float factor)
	{
	}

	private void OnSliderValueChange(ChangeEvent<float> evt)
	{
	}

	public void ScrollPageUp()
	{
	}

	public void ScrollPageDown()
	{
	}

	public void ScrollPageUp(float factor)
	{
	}

	public void ScrollPageDown(float factor)
	{
	}
}
