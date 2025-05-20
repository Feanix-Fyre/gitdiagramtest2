using System;

namespace UnityEngine;

public struct ModifiableContactPair
{
	private IntPtr actor;

	private IntPtr otherActor;

	private IntPtr shape;

	private IntPtr otherShape;

	public Quaternion rotation;

	public Vector3 position;

	public Quaternion otherRotation;

	public Vector3 otherPosition;

	private int numContacts;

	private IntPtr contacts;
}
