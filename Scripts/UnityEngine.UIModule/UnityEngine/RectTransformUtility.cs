using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Modules/UI/RectTransformUtil.h")]
[NativeHeader("Runtime/Transform/RectTransform.h")]
[NativeHeader("Runtime/Camera/Camera.h")]
[NativeHeader("Modules/UI/Canvas.h")]
[StaticAccessor("UI", StaticAccessorType.DoubleColon)]
public sealed class RectTransformUtility
{
	private static readonly Vector3[] s_Corners;

	public static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas)
	{
		return default(Vector2);
	}

	public static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas)
	{
		return default(Rect);
	}

	private static bool PointInRectangle(Vector2 screenPoint, RectTransform rect, Camera cam, Vector4 offset)
	{
		return false;
	}

	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint)
	{
		return false;
	}

	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam)
	{
		return false;
	}

	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam, Vector4 offset)
	{
		return false;
	}

	public static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector3 worldPoint)
	{
		worldPoint = default(Vector3);
		return false;
	}

	public static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector2 localPoint)
	{
		localPoint = default(Vector2);
		return false;
	}

	public static Ray ScreenPointToRay(Camera cam, Vector2 screenPos)
	{
		return default(Ray);
	}

	public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint)
	{
		return default(Vector2);
	}

	public static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive)
	{
	}

	public static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive)
	{
	}

	private static Vector2 GetTransposed(Vector2 input)
	{
		return default(Vector2);
	}

	private static void PixelAdjustPoint_Injected(ref Vector2 point, Transform elementTransform, Canvas canvas, out Vector2 ret)
	{
		ret = default(Vector2);
	}

	private static void PixelAdjustRect_Injected(RectTransform rectTransform, Canvas canvas, out Rect ret)
	{
		ret = default(Rect);
	}

	private static bool PointInRectangle_Injected(ref Vector2 screenPoint, RectTransform rect, Camera cam, ref Vector4 offset)
	{
		return false;
	}
}
