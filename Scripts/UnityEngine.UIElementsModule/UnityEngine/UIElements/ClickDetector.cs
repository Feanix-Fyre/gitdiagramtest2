using System.Collections.Generic;

namespace UnityEngine.UIElements;

internal class ClickDetector
{
	private class ButtonClickStatus
	{
		public VisualElement m_Target;

		public Vector3 m_PointerDownPosition;

		public long m_LastPointerDownTime;

		public int m_ClickCount;

		public void Reset()
		{
		}
	}

	private List<ButtonClickStatus> m_ClickStatus;

	internal static int s_DoubleClickTime { get; set; }

	private void StartClickTracking(EventBase evt)
	{
	}

	private void SendClickEvent(EventBase evt)
	{
	}

	private void CancelClickTracking(EventBase evt)
	{
	}

	public void ProcessEvent(EventBase evt)
	{
	}

	private static bool ContainsPointer(VisualElement element, Vector2 position)
	{
		return false;
	}

	internal void Cleanup(List<VisualElement> elements)
	{
	}
}
