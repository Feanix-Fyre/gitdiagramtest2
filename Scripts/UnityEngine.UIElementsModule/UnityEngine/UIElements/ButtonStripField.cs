using System.Collections.Generic;

namespace UnityEngine.UIElements;

internal class ButtonStripField : BaseField<int>
{
	public new class UxmlFactory : UxmlFactory<ButtonStripField, UxmlTraits>
	{
	}

	public new class UxmlTraits : BaseField<int>.UxmlTraits
	{
	}

	private List<Button> m_Buttons;

	public ButtonStripField()
		: base((string)null)
	{
	}

	public override void SetValueWithoutNotify(int newValue)
	{
	}

	private void RefreshButtonsState()
	{
	}
}
