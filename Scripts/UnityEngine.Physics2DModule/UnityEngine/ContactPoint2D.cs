using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/PhysicsScripting2D.h")]
[NativeClass("ScriptingContactPoint2D", "struct ScriptingContactPoint2D;")]
[RequiredByNativeCode(Optional = false, GenerateProxy = true)]
public struct ContactPoint2D
{
	[NativeName("point")]
	private Vector2 m_Point;

	[NativeName("normal")]
	private Vector2 m_Normal;

	[NativeName("relativeVelocity")]
	private Vector2 m_RelativeVelocity;

	[NativeName("separation")]
	private float m_Separation;

	[NativeName("normalImpulse")]
	private float m_NormalImpulse;

	[NativeName("tangentImpulse")]
	private float m_TangentImpulse;

	[NativeName("collider")]
	private int m_Collider;

	[NativeName("otherCollider")]
	private int m_OtherCollider;

	[NativeName("rigidbody")]
	private int m_Rigidbody;

	[NativeName("otherRigidbody")]
	private int m_OtherRigidbody;

	[NativeName("enabled")]
	private int m_Enabled;
}
