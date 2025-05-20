using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Modules/Physics/CharacterController.h")]
public class CharacterController : Collider
{
	public Vector3 velocity => default(Vector3);

	public bool isGrounded
	{
		[NativeName("IsGrounded")]
		get
		{
			return false;
		}
	}

	public CollisionFlags collisionFlags => default(CollisionFlags);

	public float radius => 0f;

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

	public Vector3 center
	{
		set
		{
		}
	}

	public float slopeLimit
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float stepOffset => 0f;

	public bool detectCollisions
	{
		set
		{
		}
	}

	public bool SimpleMove(Vector3 speed)
	{
		return false;
	}

	public CollisionFlags Move(Vector3 motion)
	{
		return default(CollisionFlags);
	}

	private bool SimpleMove_Injected(ref Vector3 speed)
	{
		return false;
	}

	private CollisionFlags Move_Injected(ref Vector3 motion)
	{
		return default(CollisionFlags);
	}

	[SpecialName]
	private void get_velocity_Injected(out Vector3 ret)
	{
		ret = default(Vector3);
	}

	[SpecialName]
	private void set_center_Injected(ref Vector3 value)
	{
	}
}
