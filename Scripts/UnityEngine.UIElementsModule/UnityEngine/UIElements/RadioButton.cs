namespace UnityEngine.UIElements;

public class RadioButton : BaseBoolField, IGroupBoxOption
{
	public new class UxmlFactory : UxmlFactory<RadioButton, UxmlTraits>
	{
	}

	public new class UxmlTraits : BaseFieldTraits<bool, UxmlBoolAttributeDescription>
	{
		private UxmlStringAttributeDescription m_Text;

		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}

	public new static readonly string ussClassName;

	public new static readonly string labelUssClassName;

	public new static readonly string inputUssClassName;

	public static readonly string checkmarkBackgroundUssClassName;

	public static readonly string checkmarkUssClassName;

	public static readonly string textUssClassName;

	private VisualElement m_CheckmarkBackground;

	public override bool value
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public RadioButton()
		: base(null)
	{
	}

	public RadioButton(string label)
		: base(null)
	{
	}

	private void OnOptionAttachToPanel(AttachToPanelEvent evt)
	{
	}

	private void OnOptionDetachFromPanel(DetachFromPanelEvent evt)
	{
	}

	protected override void InitLabel()
	{
	}

	protected override void ToggleValue()
	{
	}

	void IGroupBoxOption.SetSelected(bool selected)
	{
	}

	public override void SetValueWithoutNotify(bool newValue)
	{
	}

	private void UpdateCheckmark()
	{
	}

	protected override void UpdateMixedValueContent()
	{
	}
}
