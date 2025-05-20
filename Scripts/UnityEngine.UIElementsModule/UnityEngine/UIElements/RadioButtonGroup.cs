using System.Collections.Generic;

namespace UnityEngine.UIElements;

public class RadioButtonGroup : BaseField<int>, IGroupBox
{
	public new class UxmlFactory : UxmlFactory<RadioButtonGroup, UxmlTraits>
	{
	}

	public new class UxmlTraits : BaseFieldTraits<int, UxmlIntAttributeDescription>
	{
		private UxmlStringAttributeDescription m_Choices;

		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}

	public new static readonly string ussClassName;

	public static readonly string containerUssClassName;

	private List<RadioButton> m_RadioButtons;

	private EventCallback<ChangeEvent<bool>> m_RadioButtonValueChangedCallback;

	private VisualElement m_RadioButtonContainer;

	public IEnumerable<string> choices
	{
		set
		{
		}
	}

	public override VisualElement contentContainer => null;

	public RadioButtonGroup()
		: base((string)null)
	{
	}

	public RadioButtonGroup(string label, List<string> radioButtonChoices = null)
		: base((string)null)
	{
	}

	private void RadioButtonValueChangedCallback(ChangeEvent<bool> evt)
	{
	}

	public override void SetValueWithoutNotify(int newValue)
	{
	}

	private void UpdateRadioButtons()
	{
	}

	void IGroupBox.OnOptionAdded(IGroupBoxOption option)
	{
	}

	void IGroupBox.OnOptionRemoved(IGroupBoxOption option)
	{
	}
}
