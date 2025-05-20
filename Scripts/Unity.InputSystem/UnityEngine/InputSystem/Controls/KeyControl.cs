namespace UnityEngine.InputSystem.Controls;

public class KeyControl : ButtonControl
{
	private int m_ScanCode;

	public Key keyCode { get; set; }

	public int scanCode => 0;

	protected override void RefreshConfiguration()
	{
	}
}
