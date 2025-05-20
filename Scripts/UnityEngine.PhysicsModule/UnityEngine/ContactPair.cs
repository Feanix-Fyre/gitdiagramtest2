using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[UsedByNativeCode]
public readonly struct ContactPair
{
	private const uint c_InvalidFaceIndex = uint.MaxValue;

	internal readonly int m_ColliderID;

	internal readonly int m_OtherColliderID;

	internal readonly IntPtr m_StartPtr;

	internal readonly uint m_NbPoints;

	internal readonly CollisionPairFlags m_Flags;

	internal readonly CollisionPairEventFlags m_Events;

	internal readonly Vector3 m_ImpulseSum;

	public Collider Collider => null;

	public Collider OtherCollider => null;

	public bool IsCollisionEnter => false;

	public bool IsCollisionExit => false;

	public bool IsCollisionStay => false;

	internal bool HasRemovedCollider => false;

	internal int ExtractContactsArray([Unmarshalled] ContactPoint[] managedContainer, bool flipped)
	{
		return 0;
	}

	private static int ExtractContactsArray_Injected(ref ContactPair _unity_self, ContactPoint[] managedContainer, bool flipped)
	{
		return 0;
	}
}
