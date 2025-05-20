using System;

namespace UnityEngine.UIElements;

public class RepeatButton : TextElement
{
	public new class UxmlFactory : UxmlFactory<RepeatButton, UxmlTraits>
	{
	}

	public new class UxmlTraits : TextElement.UxmlTraits
	{
		private UxmlLongAttributeDescription m_Delay;

		private UxmlLongAttributeDescription m_Interval;

		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}

	private Clickable m_Clickable;

	public new static readonly string ussClassName;

	public RepeatButton()
	{
	}

	public RepeatButton(Action clickEvent, long delay, long interval)
	{
	}

	public void SetAction(Action clickEvent, long delay, long interval)
	{
	}

	internal void AddAction(Action clickEvent)
	{
	}
}
