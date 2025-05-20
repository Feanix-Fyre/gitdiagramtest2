using UnityEngine.UI;

namespace UnityEngine.Rendering.UI;

public abstract class DebugUIHandlerField<T> : DebugUIHandlerWidget where T : DebugUI.Widget
{
	public Text nextButtonText;

	public Text previousButtonText;

	public Text nameLabel;

	public Text valueLabel;

	protected internal T m_Field;

	internal override void SetWidget(DebugUI.Widget widget)
	{
	}

	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
	{
		return false;
	}

	public override void OnDeselection()
	{
	}

	public override void OnAction()
	{
	}

	public abstract void UpdateValueLabel();

	protected void SetLabelText(string text)
	{
	}
}
