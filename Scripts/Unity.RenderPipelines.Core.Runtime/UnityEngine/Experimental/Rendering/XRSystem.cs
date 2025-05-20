using System;
using System.Collections.Generic;
using UnityEngine.Rendering;
using UnityEngine.XR;

namespace UnityEngine.Experimental.Rendering;

public static class XRSystem
{
	private static XRLayout s_Layout;

	private static Func<XRPassCreateInfo, XRPass> s_PassAllocator;

	private static List<XRDisplaySubsystem> s_DisplayList;

	private static XRDisplaySubsystem s_Display;

	private static MSAASamples s_MSAASamples;

	private static Material s_OcclusionMeshMaterial;

	private static Material s_MirrorViewMaterial;

	private static Action<XRLayout, Camera> s_LayoutOverride;

	public static readonly XRPass emptyPass;

	public static bool displayActive => false;

	public static bool isHDRDisplayOutputActive => false;

	public static bool singlePassAllowed { get; set; }

	public static FoveatedRenderingCaps foveatedRenderingCaps { get; set; }

	public static bool dumpDebugInfo { get; set; }

	public static XRDisplaySubsystem GetActiveDisplay()
	{
		return null;
	}

	public static void Initialize(Func<XRPassCreateInfo, XRPass> passAllocator, Shader occlusionMeshPS, Shader mirrorViewPS)
	{
	}

	public static void SetDisplayMSAASamples(MSAASamples msaaSamples)
	{
	}

	public static MSAASamples GetDisplayMSAASamples()
	{
		return default(MSAASamples);
	}

	public static void SetRenderScale(float renderScale)
	{
	}

	public static XRLayout NewLayout()
	{
		return null;
	}

	public static void EndLayout()
	{
	}

	public static void RenderMirrorView(CommandBuffer cmd, Camera camera)
	{
	}

	public static void Dispose()
	{
	}

	internal static void SetDisplayZRange(float zNear, float zFar)
	{
	}

	private static void SetLayoutOverride(Action<XRLayout, Camera> action)
	{
	}

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
	private static void XRSystemInit()
	{
	}

	private static void RefreshDeviceInfo()
	{
	}

	internal static void CreateDefaultLayout(Camera camera)
	{
	}

	internal static void ReconfigurePass(XRPass xrPass, Camera camera)
	{
	}

	private static bool CanUseSinglePass(Camera camera, XRDisplaySubsystem.XRRenderPass renderPass)
	{
		return false;
	}

	private static XRView BuildView(XRDisplaySubsystem.XRRenderPass renderPass, XRDisplaySubsystem.XRRenderParameter renderParameter)
	{
		return default(XRView);
	}

	private static XRPassCreateInfo BuildPass(XRDisplaySubsystem.XRRenderPass xrRenderPass, ScriptableCullingParameters cullingParameters)
	{
		return default(XRPassCreateInfo);
	}
}
