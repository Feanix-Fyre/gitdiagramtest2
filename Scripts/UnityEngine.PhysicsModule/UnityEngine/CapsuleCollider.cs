using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[RequiredByNativeCode]
[NativeHeader("Modules/Physics/CapsuleCollider.h")]
public class CapsuleCollider : Collider
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

	public float height
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int direction
	{
		get
		{
			return 0;
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
