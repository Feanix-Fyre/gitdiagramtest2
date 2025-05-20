using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Modules/Vehicles/WheelCollider.h")]
public struct WheelHit
{
	[NativeName("point")]
	private Vector3 m_Point;

	[NativeName("normal")]
	private Vector3 m_Normal;

	[NativeName("forwardDir")]
	private Vector3 m_ForwardDir;

	[NativeName("sidewaysDir")]
	private Vector3 m_SidewaysDir;

	[NativeName("force")]
	private float m_Force;

	[NativeName("forwardSlip")]
	private float m_ForwardSlip;

	[NativeName("sidewaysSlip")]
	private float m_SidewaysSlip;

	[NativeName("collider")]
	private Collider m_Collider;

	public float forwardSlip => 0f;

	public float sidewaysSlip => 0f;
}
