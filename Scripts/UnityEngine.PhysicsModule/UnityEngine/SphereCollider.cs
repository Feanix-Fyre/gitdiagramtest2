using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Modules/Physics/SphereCollider.h")]
[RequiredByNativeCode]
public class SphereCollider : Collider
{
	public Vector3 center
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public float radius
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[SpecialName]
	private void get_center_Injected(out Vector3 ret)
	{
		ret = default(Vector3);
	}

	[SpecialName]
	private void set_center_Injected(ref Vector3 value)
	{
	}
}
