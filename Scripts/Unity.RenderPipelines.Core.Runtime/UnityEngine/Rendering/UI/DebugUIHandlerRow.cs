namespace UnityEngine.Rendering.UI;

public class DebugUIHandlerRow : DebugUIHandlerFoldout
{
	private float m_Timer;

	protected override void OnEnable()
	{
	}

	private GameObject GetChild(int index)
	{
		return null;
	}

	private bool TryGetChild(int index, out GameObject child)
	{
		child = null;
		return false;
	}

	private bool IsActive(DebugUI.Table table, int index, GameObject child)
	{
		return false;
	}

	protected void Update()
	{
	}
}
