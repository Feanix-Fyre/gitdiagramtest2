using UnityEngine.UI;

namespace UnityEngine.Rendering.UI;

public class DebugUIHandlerValueTuple : DebugUIHandlerWidget
{
	public Text nameLabel;

	public Text valueLabel;

	protected internal DebugUI.ValueTuple m_Field;

	protected internal Text[] valueElements;

	private const float k_XOffset = 230f;

	private float m_Timer;

	private static readonly Color k_ZeroColor;

	protected override void OnEnable()
	{
	}

	public override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
	{
		return false;
	}

	public override void OnDeselection()
	{
	}

	internal override void SetWidget(DebugUI.Widget widget)
	{
	}

	internal virtual void UpdateValueLabels()
	{
	}

	private void Update()
	{
	}
}
