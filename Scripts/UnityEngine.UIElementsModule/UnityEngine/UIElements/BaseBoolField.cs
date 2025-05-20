namespace UnityEngine.UIElements;

public abstract class BaseBoolField : BaseField<bool>
{
	protected Label m_Label;

	protected readonly VisualElement m_CheckMark;

	internal Clickable m_Clickable;

	private string m_OriginalText;

	public string text
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public BaseBoolField(string label)
		: base((string)null)
	{
	}

	private void OnNavigationSubmit(NavigationSubmitEvent evt)
	{
	}

	protected virtual void InitLabel()
	{
	}

	public override void SetValueWithoutNotify(bool newValue)
	{
	}

	private void OnClickEvent(EventBase evt)
	{
	}

	protected virtual void ToggleValue()
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
