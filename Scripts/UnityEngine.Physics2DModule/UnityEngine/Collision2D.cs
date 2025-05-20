using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine;

[StructLayout((LayoutKind)0)]
[RequiredByNativeCode]
public class Collision2D
{
	internal int m_Collider;

	internal int m_OtherCollider;

	internal int m_Rigidbody;

	internal int m_OtherRigidbody;

	internal Vector2 m_RelativeVelocity;

	internal int m_Enabled;

	internal int m_ContactCount;

	internal ContactPoint2D[] m_ReusedContacts;

	internal ContactPoint2D[] m_LegacyContacts;

	public Collider2D collider => null;

	public Rigidbody2D rigidbody => null;

	public GameObject gameObject => null;

	public Vector2 relativeVelocity => default(Vector2);
}
