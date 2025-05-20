using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.XR;

[NativeHeader("Runtime/Interfaces/IVRDevice.h")]
[NativeHeader("Modules/VR/VRModule.h")]
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/VR/ScriptBindings/XR.bindings.h")]
public static class XRSettings
{
	public enum StereoRenderingMode
	{
		MultiPass = 0,
		SinglePass = 1,
		SinglePassInstanced = 2,
		SinglePassMultiview = 3
	}

	public static bool enabled
	{
		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
		get
		{
			return false;
		}
	}

	[NativeName("Active")]
	[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
	public static bool isDeviceActive => false;

	[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
	[NativeName("RenderScale")]
	public static float eyeTextureResolutionScale
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
	public static int eyeTextureWidth => 0;

	[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
	public static int eyeTextureHeight => 0;

	[NativeConditional("ENABLE_VR", "RenderTextureDesc()")]
	[NativeName("IntermediateEyeTextureDesc")]
	[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
	public static RenderTextureDescriptor eyeTextureDesc => default(RenderTextureDescriptor);

	public static float renderViewportScale => 0f;

	[NativeName("RenderViewportScale")]
	[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
	internal static float renderViewportScaleInternal => 0f;

	[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
	[NativeName("DeviceName")]
	public static string loadedDeviceName => null;

	public static string[] supportedDevices => null;

	[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType.ArrowWithDefaultReturnIfNull)]
	public static StereoRenderingMode stereoRenderingMode => default(StereoRenderingMode);

	[SpecialName]
	private static void get_eyeTextureDesc_Injected(out RenderTextureDescriptor ret)
	{
		ret = default(RenderTextureDescriptor);
	}
}
