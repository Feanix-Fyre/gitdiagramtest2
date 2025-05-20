using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[StructLayout((LayoutKind)0)]
[NativeHeader("Runtime/Export/Camera/CullingGroup.bindings.h")]
public class CullingGroup : IDisposable
{
	public delegate void StateChanged(CullingGroupEvent sphere);

	internal IntPtr m_Ptr;

	private StateChanged m_OnStateChanged;

	public Camera targetCamera
	{
		set
		{
		}
	}

	~CullingGroup()
	{
	}

	[FreeFunction("CullingGroup_Bindings::Dispose", HasExplicitThis = true)]
	private void DisposeInternal()
	{
	}

	public void Dispose()
	{
	}

	public void SetBoundingSpheres([Unmarshalled] BoundingSphere[] array)
	{
	}

	public void SetBoundingSphereCount(int count)
	{
	}

	public int QueryIndices(bool visible, int[] result, int firstIndex)
	{
		return 0;
	}

	[FreeFunction("CullingGroup_Bindings::QueryIndices", HasExplicitThis = true)]
	[NativeThrows]
	private int QueryIndices(bool visible, int distanceIndex, CullingQueryOptions options, [Unmarshalled] int[] result, int firstIndex)
	{
		return 0;
	}

	[FreeFunction("CullingGroup_Bindings::SetBoundingDistances", HasExplicitThis = true)]
	public void SetBoundingDistances([Unmarshalled] float[] distances)
	{
	}

	[FreeFunction("CullingGroup_Bindings::SetDistanceReferencePoint", HasExplicitThis = true)]
	private void SetDistanceReferencePoint_InternalVector3(Vector3 point)
	{
	}

	public void SetDistanceReferencePoint(Vector3 point)
	{
	}

	[RequiredByNativeCode]
	private static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count)
	{
	}

	[FreeFunction("CullingGroup_Bindings::Init")]
	private static IntPtr Init(object scripting)
	{
		return (IntPtr)0;
	}

	[FreeFunction("CullingGroup_Bindings::FinalizerFailure", HasExplicitThis = true, IsThreadSafe = true)]
	private void FinalizerFailure()
	{
	}

	private void SetDistanceReferencePoint_InternalVector3_Injected(ref Vector3 point)
	{
	}
}
