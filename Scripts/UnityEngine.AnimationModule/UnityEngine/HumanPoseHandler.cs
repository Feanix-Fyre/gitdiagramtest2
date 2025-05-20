using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Modules/Animation/HumanPoseHandler.h")]
[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
public class HumanPoseHandler : IDisposable
{
	internal IntPtr m_Ptr;

	[FreeFunction("AnimationBindings::CreateHumanPoseHandler")]
	private static IntPtr Internal_CreateFromRoot(Avatar avatar, Transform root)
	{
		return (IntPtr)0;
	}

	[FreeFunction("AnimationBindings::DestroyHumanPoseHandler")]
	private static void Internal_Destroy(IntPtr ptr)
	{
	}

	private void GetHumanPose(out Vector3 bodyPosition, out Quaternion bodyRotation, [Out] float[] muscles)
	{
		bodyPosition = default(Vector3);
		bodyRotation = default(Quaternion);
	}

	public void Dispose()
	{
	}

	public HumanPoseHandler(Avatar avatar, Transform root)
	{
	}

	public void GetHumanPose(ref HumanPose humanPose)
	{
	}
}
