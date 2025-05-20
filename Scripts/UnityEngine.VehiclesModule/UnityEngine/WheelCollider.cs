using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("PhysicsScriptingClasses.h")]
[NativeHeader("Modules/Vehicles/WheelCollider.h")]
public class WheelCollider : Collider
{
	public float radius => 0f;

	public float suspensionDistance => 0f;

	public JointSpring suspensionSpring => default(JointSpring);

	public WheelFrictionCurve forwardFriction
	{
		get
		{
			return default(WheelFrictionCurve);
		}
		set
		{
		}
	}

	public WheelFrictionCurve sidewaysFriction
	{
		get
		{
			return default(WheelFrictionCurve);
		}
		set
		{
		}
	}

	public float motorTorque
	{
		set
		{
		}
	}

	public float brakeTorque
	{
		set
		{
		}
	}

	public float steerAngle
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public void ConfigureVehicleSubsteps(float speedThreshold, int stepsBelowThreshold, int stepsAboveThreshold)
	{
	}

	public void GetWorldPose(out Vector3 pos, out Quaternion quat)
	{
		pos = default(Vector3);
		quat = default(Quaternion);
	}

	public bool GetGroundHit(out WheelHit hit)
	{
		hit = default(WheelHit);
		return false;
	}

	[SpecialName]
	private void get_suspensionSpring_Injected(out JointSpring ret)
	{
		ret = default(JointSpring);
	}

	[SpecialName]
	private void get_forwardFriction_Injected(out WheelFrictionCurve ret)
	{
		ret = default(WheelFrictionCurve);
	}

	[SpecialName]
	private void set_forwardFriction_Injected(ref WheelFrictionCurve value)
	{
	}

	[SpecialName]
	private void get_sidewaysFriction_Injected(out WheelFrictionCurve ret)
	{
		ret = default(WheelFrictionCurve);
	}

	[SpecialName]
	private void set_sidewaysFriction_Injected(ref WheelFrictionCurve value)
	{
	}
}
