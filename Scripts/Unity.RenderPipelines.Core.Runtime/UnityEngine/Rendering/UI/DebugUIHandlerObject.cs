using UnityEngine.UI;

namespace UnityEngine.Rendering.UI;

public class DebugUIHandlerObject : DebugUIHandlerWidget
{
	public Text nameLabel;

	public Text valueLabel;

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
}
