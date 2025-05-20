using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/CompositeCollider2D.h")]
[RequireComponent(typeof(Rigidbody2D))]
public sealed class CompositeCollider2D : Collider2D
{
	public int pathCount => 0;

	public int pointCount => 0;

	public int GetPath(int index, Vector2[] points)
	{
		return 0;
	}

	[NativeMethod("GetPathArray_Binding")]
	private int GetPathArray_Internal(int index, [NotNull("ArgumentNullException")][Unmarshalled] Vector2[] points)
	{
		return 0;
	}
}
