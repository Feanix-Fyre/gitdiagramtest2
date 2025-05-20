using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/Rigidbody2D.h")]
[RequireComponent(typeof(Transform))]
public sealed class Rigidbody2D : Component
{
	public Vector2 position => default(Vector2);

	public float rotation => 0f;

	public Vector2 velocity
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	public float angularVelocity
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float mass => 0f;

	public float gravityScale
	{
		set
		{
		}
	}

	public RigidbodyType2D bodyType
	{
		get
		{
			return default(RigidbodyType2D);
		}
		[NativeMethod("SetBodyType_Binding")]
		set
		{
		}
	}

	public bool isKinematic
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public RigidbodyConstraints2D constraints => default(RigidbodyConstraints2D);

	public bool simulated
	{
		get
		{
			return false;
		}
		[NativeMethod("SetSimulated_Binding")]
		set
		{
		}
	}

	public RigidbodyInterpolation2D interpolation
	{
		set
		{
		}
	}

	public CollisionDetectionMode2D collisionDetectionMode
	{
		set
		{
		}
	}

	public void MovePosition(Vector2 position)
	{
	}

	public void MoveRotation(float angle)
	{
	}

	[NativeMethod("MoveRotation")]
	private void MoveRotation_Angle(float angle)
	{
	}

	public void MoveRotation(Quaternion rotation)
	{
	}

	[NativeMethod("MoveRotation")]
	private void MoveRotation_Quaternion(Quaternion rotation)
	{
	}

	[SpecialName]
	private void get_position_Injected(out Vector2 ret)
	{
		ret = default(Vector2);
	}

	private void MovePosition_Injected(ref Vector2 position)
	{
	}

	private void MoveRotation_Quaternion_Injected(ref Quaternion rotation)
	{
	}

	[SpecialName]
	private void get_velocity_Injected(out Vector2 ret)
	{
		ret = default(Vector2);
	}

	[SpecialName]
	private void set_velocity_Injected(ref Vector2 value)
	{
	}
}
