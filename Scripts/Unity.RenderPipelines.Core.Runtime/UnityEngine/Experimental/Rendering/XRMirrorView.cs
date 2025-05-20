using UnityEngine.Rendering;
using UnityEngine.XR;

namespace UnityEngine.Experimental.Rendering;

internal static class XRMirrorView
{
	private static readonly MaterialPropertyBlock s_MirrorViewMaterialProperty;

	private static readonly ProfilingSampler k_MirrorViewProfilingSampler;

	private static readonly int k_SourceTex;

	private static readonly int k_SourceTexArraySlice;

	private static readonly int k_ScaleBias;

	private static readonly int k_ScaleBiasRt;

	private static readonly int k_SRGBRead;

	private static readonly int k_SRGBWrite;

	private static readonly int k_MaxNits;

	private static readonly int k_SourceMaxNits;

	private static readonly int k_SourceHDREncoding;

	private static readonly int k_ColorTransform;

	internal static void RenderMirrorView(CommandBuffer cmd, Camera camera, Material mat, XRDisplaySubsystem display)
	{
	}
}
