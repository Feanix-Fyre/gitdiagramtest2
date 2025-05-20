using UnityEngine.Scripting;

namespace UnityEngine;

internal class ScrollViewState
{
	public Rect position;

	public Rect visibleRect;

	public Rect viewRect;

	public Vector2 scrollPosition;

	public bool apply;

	public bool isDuringTouchScroll;

	public Vector2 touchScrollStartMousePosition;

	public Vector2 touchScrollStartPosition;

	public Vector2 velocity;

	public float previousTimeSinceStartup;

	[RequiredByNativeCode]
	public ScrollViewState()
	{
	}
}
