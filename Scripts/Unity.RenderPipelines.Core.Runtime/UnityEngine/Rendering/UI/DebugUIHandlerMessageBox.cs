using UnityEngine.UI;

namespace UnityEngine.Rendering.UI;

public class DebugUIHandlerMessageBox : DebugUIHandlerWidget
{
	public Text nameLabel;

	private DebugUI.MessageBox m_Field;

	private static Color32 k_WarningBackgroundColor;

	private static Color32 k_WarningTextColor;

	private static Color32 k_ErrorBackgroundColor;

	private static Color32 k_ErrorTextColor;

	internal override void SetWidget(DebugUI.Widget widget)
	{
	}

	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
	{
		return false;
	}
}
