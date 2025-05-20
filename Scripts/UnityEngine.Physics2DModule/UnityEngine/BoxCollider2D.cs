using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/BoxCollider2D.h")]
public sealed class BoxCollider2D : Collider2D
{
	public Vector2 size => default(Vector2);

	[SpecialName]
	private void get_size_Injected(out Vector2 ret)
	{
		ret = default(Vector2);
	}
}
