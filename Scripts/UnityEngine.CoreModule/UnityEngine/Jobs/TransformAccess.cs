using System;
using UnityEngine.Bindings;

namespace UnityEngine.Jobs;

[NativeHeader("Runtime/Transform/ScriptBindings/TransformAccess.bindings.h")]
public struct TransformAccess
{
	private IntPtr hierarchy;

	private int index;

	public Vector3 position => default(Vector3);

	public Quaternion rotation => default(Quaternion);

	public Vector3 localScale => default(Vector3);

	public Matrix4x4 localToWorldMatrix => default(Matrix4x4);

	[NativeMethod(Name = "TransformAccessBindings::GetPosition", IsThreadSafe = true, IsFreeFunction = true, ThrowsException = true)]
	private static void GetPosition(ref TransformAccess access, out Vector3 p)
	{
		p = default(Vector3);
	}

	[NativeMethod(Name = "TransformAccessBindings::GetRotation", IsThreadSafe = true, IsFreeFunction = true, ThrowsException = true)]
	private static void GetRotation(ref TransformAccess access, out Quaternion r)
	{
		r = default(Quaternion);
	}

	[NativeMethod(Name = "TransformAccessBindings::GetLocalScale", IsThreadSafe = true, IsFreeFunction = true, ThrowsException = true)]
	private static void GetLocalScale(ref TransformAccess access, out Vector3 r)
	{
		r = default(Vector3);
	}

	[NativeMethod(Name = "TransformAccessBindings::GetLocalToWorldMatrix", IsThreadSafe = true, IsFreeFunction = true, ThrowsException = true)]
	private static void GetLocalToWorldMatrix(ref TransformAccess access, out Matrix4x4 m)
	{
		m = default(Matrix4x4);
	}
}
