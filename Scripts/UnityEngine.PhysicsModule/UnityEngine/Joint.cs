using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeClass("Unity::Joint")]
[RequireComponent(typeof(Rigidbody))]
[NativeHeader("Modules/Physics/Joint.h")]
public class Joint : Component
{
	public Rigidbody connectedBody
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Vector3 connectedAnchor
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
	private void get_connectedAnchor_Injected(out Vector3 ret)
	{
		ret = default(Vector3);
	}

	[SpecialName]
	private void set_connectedAnchor_Injected(ref Vector3 value)
	{
	}
}
