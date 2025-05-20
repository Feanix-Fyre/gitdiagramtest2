using System;

namespace UnityEngine;

public readonly struct ContactPairHeader
{
	internal readonly int m_BodyID;

	internal readonly int m_OtherBodyID;

	internal readonly IntPtr m_StartPtr;

	internal readonly uint m_NbPairs;

	internal readonly CollisionPairHeaderFlags m_Flags;

	internal readonly Vector3 m_RelativeVelocity;

	public Component Body => null;

	public Component OtherBody => null;

	internal bool HasRemovedBody => false;

	public ref ContactPair GetContactPair(int index)
	{
		throw null;
	}

	internal unsafe ContactPair* GetContactPair_Internal(int index)
	{
		return null;
	}
}
