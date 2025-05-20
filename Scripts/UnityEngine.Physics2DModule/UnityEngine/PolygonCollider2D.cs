using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/PolygonCollider2D.h")]
public sealed class PolygonCollider2D : Collider2D
{
	public Vector2[] points
	{
		[NativeMethod("GetPoints_Binding")]
		get
		{
			return null;
		}
		[NativeMethod("SetPoints_Binding")]
		set
		{
		}
	}

	public int pathCount => 0;

	[NativeMethod("GetPointCount")]
	public int GetTotalPointCount()
	{
		return 0;
	}

	public Vector2[] GetPath(int index)
	{
		return null;
	}

	[NativeMethod("GetPath_Binding")]
	private Vector2[] GetPath_Internal(int index)
	{
		return null;
	}
}
