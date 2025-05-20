namespace UnityEngine.UIElements;

public abstract class AbstractProgressBar : BindableElement, INotifyValueChanged<float>
{
	public new class UxmlTraits : BindableElement.UxmlTraits
	{
		private UxmlFloatAttributeDescription m_LowValue;

		private UxmlFloatAttributeDescription m_HighValue;

		private UxmlFloatAttributeDescription m_Value;

		private UxmlStringAttributeDescription m_Title;

		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}

	public static readonly string ussClassName;

	public static readonly string containerUssClassName;

	public static readonly string titleUssClassName;

	public static readonly string titleContainerUssClassName;

	public static readonly string progressUssClassName;

	public static readonly string backgroundUssClassName;

	private readonly VisualElement m_Background;

	private readonly VisualElement m_Progress;

	private readonly Label m_Title;

	private float m_LowValue;

	private float m_HighValue;

	private float m_Value;

	public string title
	{
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

	public virtual float value
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public AbstractProgressBar()
	{
	}

	private void OnGeometryChanged(GeometryChangedEvent e)
	{
	}

	public void SetValueWithoutNotify(float newValue)
	{
	}

	private void SetProgress(float p)
	{
	}

	private float CalculateProgressWidth(float width)
	{
		return 0f;
	}
}
