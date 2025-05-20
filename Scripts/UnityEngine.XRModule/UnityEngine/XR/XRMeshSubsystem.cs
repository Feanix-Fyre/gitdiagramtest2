using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR;

[NativeConditional("ENABLE_XR")]
[UsedByNativeCode]
[NativeHeader("Modules/XR/XRPrefix.h")]
[NativeHeader("Modules/XR/Subsystems/Meshing/XRMeshingSubsystem.h")]
public class XRMeshSubsystem : IntegratedSubsystem<XRMeshSubsystemDescriptor>
{
	[NativeConditional("ENABLE_XR")]
	private readonly struct MeshTransformList : IDisposable
	{
		private readonly IntPtr m_Self;

		public void Dispose()
		{
		}

		[FreeFunction("UnityXRMeshTransformList_Dispose")]
		private static void Dispose(IntPtr self)
		{
		}
	}

	[RequiredByNativeCode]
	private void InvokeMeshReadyDelegate(MeshGenerationResult result, Action<MeshGenerationResult> onMeshGenerationComplete)
	{
	}
}
