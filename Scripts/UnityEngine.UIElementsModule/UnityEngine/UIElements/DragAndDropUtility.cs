using System;

namespace UnityEngine.UIElements;

internal static class DragAndDropUtility
{
	private static Func<IDragAndDrop> s_MakeDragAndDropClientFunc;

	private static IDragAndDrop s_DragAndDropEditor;

	private static IDragAndDrop s_DragAndDropPlayMode;

	internal static IDragAndDrop GetDragAndDrop(IPanel panel)
	{
		return null;
	}
}
