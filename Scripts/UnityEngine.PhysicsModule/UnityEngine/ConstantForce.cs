using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[NativeHeader("Modules/Physics/ConstantForce.h")]
public class ConstantForce : Behaviour
{
	public Vector3 force
	{
		set
		{
		}
	}

	[SpecialName]
	private void set_force_Injected(ref Vector3 value)
	{
	}
}
