using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.AI;

[StructLayout((LayoutKind)0)]
[NativeHeader("Modules/AI/NavMeshPath.bindings.h")]
[MovedFrom("UnityEngine")]
public sealed class NavMeshPath
{
	internal IntPtr m_Ptr;

	internal Vector3[] m_Corners;

	public Vector3[] corners => null;

	public NavMeshPathStatus status => default(NavMeshPathStatus);

	~NavMeshPath()
	{
	}

	[FreeFunction("NavMeshPathScriptBindings::InitializeNavMeshPath")]
	private static IntPtr InitializeNavMeshPath()
	{
		return (IntPtr)0;
	}

	[FreeFunction("NavMeshPathScriptBindings::DestroyNavMeshPath", IsThreadSafe = true)]
	private static void DestroyNavMeshPath(IntPtr ptr)
	{
	}

	[FreeFunction("NavMeshPathScriptBindings::CalculateCornersInternal", HasExplicitThis = true)]
	private Vector3[] CalculateCornersInternal()
	{
		return null;
	}

	[FreeFunction("NavMeshPathScriptBindings::ClearCornersInternal", HasExplicitThis = true)]
	private void ClearCornersInternal()
	{
	}

	public void ClearCorners()
	{
	}

	private void CalculateCorners()
	{
	}
}
