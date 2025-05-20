using UnityEngine.UI;

namespace UnityEngine.Rendering.UI;

public class DebugUIHandlerPanel : MonoBehaviour
{
	public Text nameLabel;

	public ScrollRect scrollRect;

	public RectTransform viewport;

	public DebugUIHandlerCanvas Canvas;

	private RectTransform m_ScrollTransform;

	private RectTransform m_ContentTransform;

	private RectTransform m_MaskTransform;

	private DebugUIHandlerWidget m_ScrollTarget;

	protected internal DebugUI.Panel m_Panel;

	private void OnEnable()
	{
	}

	internal void SetPanel(DebugUI.Panel panel)
	{
	}

	internal DebugUI.Panel GetPanel()
	{
		return null;
	}

	public void SelectNextItem()
	{
	}

	public void SelectPreviousItem()
	{
	}

	public void OnScrollbarClicked()
	{
	}

	internal void SetScrollTarget(DebugUIHandlerWidget target)
	{
	}

	internal void UpdateScroll()
	{
	}

	private float GetYPosInScroll(RectTransform target)
	{
		return 0f;
	}

	internal DebugUIHandlerWidget GetFirstItem()
	{
		return null;
	}

	public void ResetDebugManager()
	{
	}
}
