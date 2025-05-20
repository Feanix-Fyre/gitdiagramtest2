using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[RequiredByNativeCode]
[NativeHeader("Modules/Physics/BoxCollider.h")]
public class BoxCollider : Collider
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

	public Vector3 size
	{
		get
		{
			return default(Vector3);
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

	[SpecialName]
	private void get_size_Injected(out Vector3 ret)
	{
		ret = default(Vector3);
	}

	[SpecialName]
	private void set_size_Injected(ref Vector3 value)
	{
	}
}
