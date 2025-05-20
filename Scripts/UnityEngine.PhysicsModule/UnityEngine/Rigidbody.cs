using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine;

[NativeHeader("Modules/Physics/Rigidbody.h")]
[RequireComponent(typeof(Transform))]
public class Rigidbody : Component
{
	public Vector3 velocity
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 angularVelocity
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public float drag
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float angularDrag
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float mass
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool useGravity
	{
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

	public bool freezeRotation
	{
		set
		{
		}
	}

	public RigidbodyConstraints constraints
	{
		get
		{
			return default(RigidbodyConstraints);
		}
		set
		{
		}
	}

	public CollisionDetectionMode collisionDetectionMode
	{
		set
		{
		}
	}

	public Vector3 centerOfMass
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 worldCenterOfMass => default(Vector3);

	public bool automaticInertiaTensor
	{
		set
		{
		}
	}

	public bool detectCollisions
	{
		set
		{
		}
	}

	public Vector3 position
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Quaternion rotation
	{
		get
		{
			return default(Quaternion);
		}
		set
		{
		}
	}

	public RigidbodyInterpolation interpolation
	{
		get
		{
			return default(RigidbodyInterpolation);
		}
		set
		{
		}
	}

	public float sleepThreshold
	{
		set
		{
		}
	}

	public float maxAngularVelocity
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public void MovePosition(Vector3 position)
	{
	}

	public void MoveRotation(Quaternion rot)
	{
	}

	public void WakeUp()
	{
	}

	public Vector3 GetPointVelocity(Vector3 worldPoint)
	{
		return default(Vector3);
	}

	public void AddForce(Vector3 force, [DefaultValue("ForceMode.Force")] ForceMode mode)
	{
	}

	[ExcludeFromDocs]
	public void AddForce(Vector3 force)
	{
	}

	public void AddRelativeForce(Vector3 force, [DefaultValue("ForceMode.Force")] ForceMode mode)
	{
	}

	public void AddTorque(Vector3 torque, [DefaultValue("ForceMode.Force")] ForceMode mode)
	{
	}

	public void AddRelativeTorque(Vector3 torque, [DefaultValue("ForceMode.Force")] ForceMode mode)
	{
	}

	public void AddForceAtPosition(Vector3 force, Vector3 position, [DefaultValue("ForceMode.Force")] ForceMode mode)
	{
	}

	[SpecialName]
	private void get_velocity_Injected(out Vector3 ret)
	{
		ret = default(Vector3);
	}

	[SpecialName]
	private void set_velocity_Injected(ref Vector3 value)
	{
	}

	[SpecialName]
	private void get_angularVelocity_Injected(out Vector3 ret)
	{
		ret = default(Vector3);
	}

	[SpecialName]
	private void set_angularVelocity_Injected(ref Vector3 value)
	{
	}

	[SpecialName]
	private void get_centerOfMass_Injected(out Vector3 ret)
	{
		ret = default(Vector3);
	}

	[SpecialName]
	private void set_centerOfMass_Injected(ref Vector3 value)
	{
	}

	[SpecialName]
	private void get_worldCenterOfMass_Injected(out Vector3 ret)
	{
		ret = default(Vector3);
	}

	[SpecialName]
	private void get_position_Injected(out Vector3 ret)
	{
		ret = default(Vector3);
	}

	[SpecialName]
	private void set_position_Injected(ref Vector3 value)
	{
	}

	[SpecialName]
	private void get_rotation_Injected(out Quaternion ret)
	{
		ret = default(Quaternion);
	}

	[SpecialName]
	private void set_rotation_Injected(ref Quaternion value)
	{
	}

	private void MovePosition_Injected(ref Vector3 position)
	{
	}

	private void MoveRotation_Injected(ref Quaternion rot)
	{
	}

	private void GetPointVelocity_Injected(ref Vector3 worldPoint, out Vector3 ret)
	{
		ret = default(Vector3);
	}

	private void AddForce_Injected(ref Vector3 force, [DefaultValue("ForceMode.Force")] ForceMode mode)
	{
	}

	private void AddRelativeForce_Injected(ref Vector3 force, [DefaultValue("ForceMode.Force")] ForceMode mode)
	{
	}

	private void AddTorque_Injected(ref Vector3 torque, [DefaultValue("ForceMode.Force")] ForceMode mode)
	{
	}

	private void AddRelativeTorque_Injected(ref Vector3 torque, [DefaultValue("ForceMode.Force")] ForceMode mode)
	{
	}

	private void AddForceAtPosition_Injected(ref Vector3 force, ref Vector3 position, [DefaultValue("ForceMode.Force")] ForceMode mode)
	{
	}
}
