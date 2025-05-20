using UnityEngine.UI;

namespace UnityEngine.Rendering.UI;

public class DebugUIHandlerProgressBar : DebugUIHandlerWidget
{
	public Text nameLabel;

	public Text valueLabel;

	public RectTransform progressBarRect;

	private DebugUI.ProgressBarValue m_Value;

	private float m_Timer;

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

	private void UpdateValue()
	{
	}
}
