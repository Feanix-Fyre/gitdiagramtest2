using System;

namespace UnityEngine.UIElements;

public class MinMaxSlider : BaseField<Vector2>
{
	public new class UxmlFactory : UxmlFactory<MinMaxSlider, UxmlTraits>
	{
	}

	public new class UxmlTraits : BaseField<Vector2>.UxmlTraits
	{
		private UxmlFloatAttributeDescription m_MinValue;

		private UxmlFloatAttributeDescription m_MaxValue;

		private UxmlFloatAttributeDescription m_LowLimit;

		private UxmlFloatAttributeDescription m_HighLimit;

		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}

	private enum DragState
	{
		NoThumb = 0,
		MinThumb = 1,
		MiddleThumb = 2,
		MaxThumb = 3
	}

	private Vector2 m_DragElementStartPos;

	private Vector2 m_ValueStartPos;

	private Rect m_DragMinThumbRect;

	private Rect m_DragMaxThumbRect;

	private DragState m_DragState;

	private float m_MinLimit;

	private float m_MaxLimit;

	public new static readonly string ussClassName;

	public new static readonly string labelUssClassName;

	public new static readonly string inputUssClassName;

	public static readonly string trackerUssClassName;

	public static readonly string draggerUssClassName;

	public static readonly string minThumbUssClassName;

	public static readonly string maxThumbUssClassName;

	internal VisualElement dragElement { get; private set; }

	internal VisualElement dragMinThumb { get; private set; }

	internal VisualElement dragMaxThumb { get; private set; }

	internal ClampedDragger<float> clampedDragger { get; private set; }

	public float minValue
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float maxValue
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public override Vector2 value
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public float lowLimit
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float highLimit
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public override void SetValueWithoutNotify(Vector2 newValue)
	{
	}

	public MinMaxSlider()
		: base((string)null)
	{
	}

	public MinMaxSlider(string label, float minValue = 0f, float maxValue = 10f, float minLimit = float.MinValue, float maxLimit = float.MaxValue)
		: base((string)null)
	{
	}

	private Vector2 ClampValues(Vector2 valueToClamp)
	{
		return default(Vector2);
	}

	private void UpdateDragElementPosition(GeometryChangedEvent evt)
	{
	}

	private void UpdateDragElementPosition()
	{
	}

	private void UpdateDragThumbsRect()
	{
	}

	internal float SliderLerpUnclamped(float a, float b, float interpolant)
	{
		return 0f;
	}

	internal float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue)
	{
		return 0f;
	}

	private float ComputeValueFromPosition(float positionToConvert)
	{
		return 0f;
	}

	[EventInterest(new Type[] { typeof(GeometryChangedEvent) })]
	protected override void ExecuteDefaultAction(EventBase evt)
	{
	}

	private void SetSliderValueFromDrag()
	{
	}

	private void SetSliderValueFromClick()
	{
	}

	private void ComputeValueDragStateNoThumb(float lowLimitPosition, float highLimitPosition, float dragElementPos)
	{
	}

	private void ComputeValueFromDraggingThumb(float dragElementStartPos, float dragElementEndPos)
	{
	}

	protected override void UpdateMixedValueContent()
	{
	}

	internal override void RegisterEditingCallbacks()
	{
	}

	internal override void UnregisterEditingCallbacks()
	{
	}
}
