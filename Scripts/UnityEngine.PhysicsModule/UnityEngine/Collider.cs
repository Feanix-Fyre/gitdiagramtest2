using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[RequireComponent(typeof(Transform))]
[NativeHeader("Modules/Physics/Collider.h")]
[RequiredByNativeCode]
public class Collider : Component
{
	public bool enabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Rigidbody attachedRigidbody
	{
		[NativeMethod("GetRigidbody")]
		get
		{
			return null;
		}
	}

	public bool isTrigger
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Bounds bounds => default(Bounds);

	public PhysicMaterial material
	{
		[NativeMethod("SetMaterial")]
		set
		{
		}
	}

	public Vector3 ClosestPoint(Vector3 position)
	{
		return default(Vector3);
	}

	private RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit)
	{
		return default(RaycastHit);
	}

	public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance)
	{
		hitInfo = default(RaycastHit);
		return false;
	}

	private void ClosestPoint_Injected(ref Vector3 position, out Vector3 ret)
	{
		ret = default(Vector3);
	}

	[SpecialName]
	private void get_bounds_Injected(out Bounds ret)
	{
		ret = default(Bounds);
	}

	private void Raycast_Injected(ref Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret)
	{
		ret = default(RaycastHit);
	}
}
