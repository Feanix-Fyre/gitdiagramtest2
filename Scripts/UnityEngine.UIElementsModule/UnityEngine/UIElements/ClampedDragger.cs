using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements;

internal class ClampedDragger<T> : Clickable where T : IComparable<T>
{
	[Flags]
	public enum DragDirection
	{
		None = 0,
		LowToHigh = 1,
		HighToLow = 2,
		Free = 4
	}

	public DragDirection dragDirection { get; set; }

	private BaseSlider<T> slider
	{
		[CompilerGenerated]
		set
		{
			_003Cslider_003Ek__BackingField = value;
		}
	}

	public Vector2 startMousePosition { get; private set; }

	public Vector2 delta => default(Vector2);

	public event Action dragging
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action draggingEnded
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public ClampedDragger(BaseSlider<T> slider, Action clickHandler, Action dragHandler)
		: base(null, 0L, 0L)
	{
	}

	protected override void ProcessDownEvent(EventBase evt, Vector2 localPosition, int pointerId)
	{
	}

	protected override void ProcessUpEvent(EventBase evt, Vector2 localPosition, int pointerId)
	{
	}

	protected override void ProcessMoveEvent(EventBase evt, Vector2 localPosition)
	{
	}
}
