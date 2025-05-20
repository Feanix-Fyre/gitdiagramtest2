using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeClass("UI::RectTransform")]
[NativeHeader("Runtime/Transform/RectTransform.h")]
public sealed class RectTransform : Transform
{
	public enum Axis
	{
		Horizontal = 0,
		Vertical = 1
	}

	public delegate void ReapplyDrivenProperties(RectTransform driven);

	public Rect rect => default(Rect);

	public Vector2 anchorMin
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public Vector2 anchorMax
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public Vector2 anchoredPosition
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public Vector2 sizeDelta
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public Vector2 pivot
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public Vector3 anchoredPosition3D
	{
		set
		{
		}
	}

	public Vector2 offsetMin
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public Vector2 offsetMax
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public static event ReapplyDrivenProperties reapplyDrivenProperties
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

	[NativeMethod("UpdateIfTransformDispatchIsDirty")]
	public void ForceUpdateRectTransforms()
	{
	}

	public void GetLocalCorners(Vector3[] fourCornersArray)
	{
	}

	public void GetWorldCorners(Vector3[] fourCornersArray)
	{
	}

	public void SetSizeWithCurrentAnchors(Axis axis, float size)
	{
	}

	[RequiredByNativeCode]
	internal static void SendReapplyDrivenProperties(RectTransform driven)
	{
	}

	private Vector2 GetParentSize()
	{
		return default(Vector2);
	}

	[SpecialName]
	private void get_rect_Injected(out Rect ret)
	{
		ret = default(Rect);
	}

	[SpecialName]
	private void get_anchorMin_Injected(out Vector2 ret)
	{
		ret = default(Vector2);
	}

	[SpecialName]
	private void set_anchorMin_Injected(ref Vector2 value)
	{
	}

	[SpecialName]
	private void get_anchorMax_Injected(out Vector2 ret)
	{
		ret = default(Vector2);
	}

	[SpecialName]
	private void set_anchorMax_Injected(ref Vector2 value)
	{
	}

	[SpecialName]
	private void get_anchoredPosition_Injected(out Vector2 ret)
	{
		ret = default(Vector2);
	}

	[SpecialName]
	private void set_anchoredPosition_Injected(ref Vector2 value)
	{
	}

	[SpecialName]
	private void get_sizeDelta_Injected(out Vector2 ret)
	{
		ret = default(Vector2);
	}

	[SpecialName]
	private void set_sizeDelta_Injected(ref Vector2 value)
	{
	}

	[SpecialName]
	private void get_pivot_Injected(out Vector2 ret)
	{
		ret = default(Vector2);
	}

	[SpecialName]
	private void set_pivot_Injected(ref Vector2 value)
	{
	}
}
