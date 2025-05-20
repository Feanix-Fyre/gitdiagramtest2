using UnityEngine.EventSystems;

namespace UnityEngine.UI;

internal static class MultipleDisplayUtilities
{
	public static bool GetRelativeMousePositionForDrag(PointerEventData eventData, ref Vector2 position)
	{
		return false;
	}

	internal static Vector3 GetRelativeMousePositionForRaycast(PointerEventData eventData)
	{
		return default(Vector3);
	}

	public static Vector3 RelativeMouseAtScaled(Vector2 position)
	{
		return default(Vector3);
	}
}
