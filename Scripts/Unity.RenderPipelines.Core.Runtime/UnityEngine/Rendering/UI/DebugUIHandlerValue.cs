using UnityEngine.UI;

namespace UnityEngine.Rendering.UI;

public class DebugUIHandlerValue : DebugUIHandlerWidget
{
	public Text nameLabel;

	public Text valueLabel;

	private DebugUI.Value m_Field;

	protected internal float m_Timer;

	private static readonly Color k_ZeroColor;

	protected override void OnEnable()
	{
	}

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

	private void Update()
	{
	}
}
