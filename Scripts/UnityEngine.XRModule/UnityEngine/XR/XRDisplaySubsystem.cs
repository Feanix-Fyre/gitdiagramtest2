using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine.XR;

[NativeConditional("ENABLE_XR")]
[NativeHeader("Modules/XR/XRPrefix.h")]
[UsedByNativeCode]
[NativeType(Header = "Modules/XR/Subsystems/Display/XRDisplaySubsystem.h")]
public class XRDisplaySubsystem : IntegratedSubsystem<XRDisplaySubsystemDescriptor>
{
	[Flags]
	public enum TextureLayout
	{
		Texture2DArray = 1,
		SingleTexture2D = 2,
		SeparateTexture2Ds = 4
	}

	[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
	public struct XRRenderParameter
	{
		public Matrix4x4 view;

		public Matrix4x4 projection;

		public Rect viewport;

		public Mesh occlusionMesh;

		public int textureArraySlice;

		public Matrix4x4 previousView;

		public bool isPreviousViewValid;
	}

	[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
	[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
	[NativeHeader("Runtime/Graphics/RenderTextureDesc.h")]
	public struct XRRenderPass
	{
		private IntPtr displaySubsystemInstance;

		public int renderPassIndex;

		public RenderTargetIdentifier renderTarget;

		public RenderTextureDescriptor renderTargetDesc;

		public bool hasMotionVectorPass;

		public RenderTargetIdentifier motionVectorRenderTarget;

		public RenderTextureDescriptor motionVectorRenderTargetDesc;

		public bool shouldFillOutDepth;

		public int cullingPassIndex;

		public IntPtr foveatedRenderingInfo;

		[NativeConditional("ENABLE_XR")]
		[NativeMethod(Name = "XRRenderPassScriptApi::GetRenderParameter", IsFreeFunction = true, HasExplicitThis = true, ThrowsException = true)]
		public void GetRenderParameter(Camera camera, int renderParameterIndex, out XRRenderParameter renderParameter)
		{
			renderParameter = default(XRRenderParameter);
		}

		[NativeMethod(Name = "XRRenderPassScriptApi::GetRenderParameterCount", IsFreeFunction = true, HasExplicitThis = true)]
		[NativeConditional("ENABLE_XR")]
		public int GetRenderParameterCount()
		{
			return 0;
		}

		private static void GetRenderParameter_Injected(ref XRRenderPass _unity_self, Camera camera, int renderParameterIndex, out XRRenderParameter renderParameter)
		{
			renderParameter = default(XRRenderParameter);
		}

		private static int GetRenderParameterCount_Injected(ref XRRenderPass _unity_self)
		{
			return 0;
		}
	}

	[NativeHeader("Runtime/Graphics/RenderTexture.h")]
	[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
	public struct XRBlitParams
	{
		public RenderTexture srcTex;

		public int srcTexArraySlice;

		public Rect srcRect;

		public Rect destRect;

		public IntPtr foveatedRenderingInfo;

		public bool srcHdrEncoded;

		public ColorGamut srcHdrColorGamut;

		public int srcHdrMaxLuminance;
	}

	[NativeHeader("Modules/XR/Subsystems/Display/XRDisplaySubsystem.bindings.h")]
	public struct XRMirrorViewBlitDesc
	{
		private IntPtr displaySubsystemInstance;

		public bool nativeBlitAvailable;

		public bool nativeBlitInvalidStates;

		public int blitParamsCount;

		[NativeConditional("ENABLE_XR")]
		[NativeMethod(Name = "XRMirrorViewBlitDescScriptApi::GetBlitParameter", IsFreeFunction = true, HasExplicitThis = true)]
		public void GetBlitParameter(int blitParameterIndex, out XRBlitParams blitParameter)
		{
			blitParameter = default(XRBlitParams);
		}

		private static void GetBlitParameter_Injected(ref XRMirrorViewBlitDesc _unity_self, int blitParameterIndex, out XRBlitParams blitParameter)
		{
			blitParameter = default(XRBlitParams);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Action<bool> displayFocusChanged;

	private HDROutputSettings m_HDROutputSettings;

	public float scaleOfAllRenderTargets
	{
		set
		{
		}
	}

	public float zNear
	{
		set
		{
		}
	}

	public float zFar
	{
		set
		{
		}
	}

	public bool sRGB
	{
		set
		{
		}
	}

	public TextureLayout textureLayout
	{
		set
		{
		}
	}

	public bool disableLegacyRenderer
	{
		set
		{
		}
	}

	public HDROutputSettings hdrOutputSettings => null;

	[RequiredByNativeCode]
	private void InvokeDisplayFocusChanged(bool focus)
	{
	}

	public void SetMSAALevel(int level)
	{
	}

	public int GetRenderPassCount()
	{
		return 0;
	}

	public void GetRenderPass(int renderPassIndex, out XRRenderPass renderPass)
	{
		renderPass = default(XRRenderPass);
	}

	[NativeMethod("TryGetRenderPass")]
	private bool Internal_TryGetRenderPass(int renderPassIndex, out XRRenderPass renderPass)
	{
		renderPass = default(XRRenderPass);
		return false;
	}

	public void EndRecordingIfLateLatched(Camera camera)
	{
	}

	[NativeMethod("TryEndRecordingIfLateLatched")]
	private bool Internal_TryEndRecordingIfLateLatched(Camera camera)
	{
		return false;
	}

	public void BeginRecordingIfLateLatched(Camera camera)
	{
	}

	[NativeMethod("TryBeginRecordingIfLateLatched")]
	private bool Internal_TryBeginRecordingIfLateLatched(Camera camera)
	{
		return false;
	}

	public void GetCullingParameters(Camera camera, int cullingPassIndex, out ScriptableCullingParameters scriptableCullingParameters)
	{
		scriptableCullingParameters = default(ScriptableCullingParameters);
	}

	[NativeHeader("Runtime/Graphics/ScriptableRenderLoop/ScriptableCulling.h")]
	[NativeMethod("TryGetCullingParams")]
	private bool Internal_TryGetCullingParams(Camera camera, int cullingPassIndex, out ScriptableCullingParameters scriptableCullingParameters)
	{
		scriptableCullingParameters = default(ScriptableCullingParameters);
		return false;
	}

	[NativeMethod(Name = "GetPreferredMirrorViewBlitMode", IsThreadSafe = false)]
	[NativeConditional("ENABLE_XR")]
	public int GetPreferredMirrorBlitMode()
	{
		return 0;
	}

	[NativeMethod(Name = "QueryMirrorViewBlitDesc", IsThreadSafe = false)]
	[NativeConditional("ENABLE_XR")]
	public bool GetMirrorViewBlitDesc(RenderTexture mirrorRt, out XRMirrorViewBlitDesc outDesc, int mode)
	{
		outDesc = default(XRMirrorViewBlitDesc);
		return false;
	}

	[NativeMethod(Name = "AddGraphicsThreadMirrorViewBlit", IsThreadSafe = false)]
	[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
	[NativeConditional("ENABLE_XR")]
	public bool AddGraphicsThreadMirrorViewBlit(CommandBuffer cmd, bool allowGraphicsStateInvalidate, int mode)
	{
		return false;
	}
}
