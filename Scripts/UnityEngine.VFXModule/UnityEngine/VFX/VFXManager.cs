using System;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine.VFX;

[StaticAccessor("GetVFXManager()", StaticAccessorType.Dot)]
[NativeHeader("Modules/VFX/Public/ScriptBindings/VFXManagerBindings.h")]
[NativeHeader("Modules/VFX/Public/VFXManager.h")]
[RequiredByNativeCode]
public static class VFXManager
{
	private static readonly VFXCameraXRSettings kDefaultCameraXRSettings;

	public static void ProcessCameraCommand(Camera cam, CommandBuffer cmd, VFXCameraXRSettings camXRSettings, CullingResults results)
	{
	}

	private static void Internal_ProcessCameraCommand([NotNull("NullExceptionObject")] Camera cam, CommandBuffer cmd, VFXCameraXRSettings camXRSettings, IntPtr cullResults)
	{
	}

	private static void Internal_ProcessCameraCommand_Injected(Camera cam, CommandBuffer cmd, ref VFXCameraXRSettings camXRSettings, IntPtr cullResults)
	{
	}
}
