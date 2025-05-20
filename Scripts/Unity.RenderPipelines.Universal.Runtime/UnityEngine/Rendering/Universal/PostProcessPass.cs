using System.Runtime.CompilerServices;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal;

internal class PostProcessPass : ScriptableRenderPass
{
	private class MaterialLibrary
	{
		public readonly Material stopNaN;

		public readonly Material subpixelMorphologicalAntialiasing;

		public readonly Material gaussianDepthOfField;

		public readonly Material bokehDepthOfField;

		public readonly Material cameraMotionBlur;

		public readonly Material paniniProjection;

		public readonly Material bloom;

		public readonly Material temporalAntialiasing;

		public readonly Material scalingSetup;

		public readonly Material easu;

		public readonly Material uber;

		public readonly Material finalPass;

		public readonly Material lensFlareDataDriven;

		public MaterialLibrary(PostProcessData data)
		{
		}

		private Material Load(Shader shader)
		{
			return null;
		}

		internal void Cleanup()
		{
		}
	}

	private static class ShaderConstants
	{
		public static readonly int _TempTarget;

		public static readonly int _TempTarget2;

		public static readonly int _StencilRef;

		public static readonly int _StencilMask;

		public static readonly int _FullCoCTexture;

		public static readonly int _HalfCoCTexture;

		public static readonly int _DofTexture;

		public static readonly int _CoCParams;

		public static readonly int _BokehKernel;

		public static readonly int _BokehConstants;

		public static readonly int _PongTexture;

		public static readonly int _PingTexture;

		public static readonly int _Metrics;

		public static readonly int _AreaTexture;

		public static readonly int _SearchTexture;

		public static readonly int _EdgeTexture;

		public static readonly int _BlendTexture;

		public static readonly int _ColorTexture;

		public static readonly int _Params;

		public static readonly int _SourceTexLowMip;

		public static readonly int _Bloom_Params;

		public static readonly int _Bloom_RGBM;

		public static readonly int _Bloom_Texture;

		public static readonly int _LensDirt_Texture;

		public static readonly int _LensDirt_Params;

		public static readonly int _LensDirt_Intensity;

		public static readonly int _Distortion_Params1;

		public static readonly int _Distortion_Params2;

		public static readonly int _Chroma_Params;

		public static readonly int _Vignette_Params1;

		public static readonly int _Vignette_Params2;

		public static readonly int _Vignette_ParamsXR;

		public static readonly int _Lut_Params;

		public static readonly int _UserLut_Params;

		public static readonly int _InternalLut;

		public static readonly int _UserLut;

		public static readonly int _DownSampleScaleFactor;

		public static readonly int _FlareOcclusionRemapTex;

		public static readonly int _FlareOcclusionTex;

		public static readonly int _FlareOcclusionIndex;

		public static readonly int _FlareTex;

		public static readonly int _FlareColorValue;

		public static readonly int _FlareData0;

		public static readonly int _FlareData1;

		public static readonly int _FlareData2;

		public static readonly int _FlareData3;

		public static readonly int _FlareData4;

		public static readonly int _FlareData5;

		public static readonly int _FullscreenProjMat;

		public static int[] _BloomMipUp;

		public static int[] _BloomMipDown;
	}

	private RenderTextureDescriptor m_Descriptor;

	private RTHandle m_Source;

	private RTHandle m_Destination;

	private RTHandle m_Depth;

	private RTHandle m_InternalLut;

	private RTHandle m_MotionVectors;

	private RTHandle m_FullCoCTexture;

	private RTHandle m_HalfCoCTexture;

	private RTHandle m_PingTexture;

	private RTHandle m_PongTexture;

	private RTHandle[] m_BloomMipDown;

	private RTHandle[] m_BloomMipUp;

	private RTHandle m_BlendTexture;

	private RTHandle m_EdgeColorTexture;

	private RTHandle m_EdgeStencilTexture;

	private RTHandle m_TempTarget;

	private RTHandle m_TempTarget2;

	private const string k_RenderPostProcessingTag = "Render PostProcessing Effects";

	private const string k_RenderFinalPostProcessingTag = "Render Final PostProcessing Pass";

	private static readonly ProfilingSampler m_ProfilingRenderPostProcessing;

	private static readonly ProfilingSampler m_ProfilingRenderFinalPostProcessing;

	private MaterialLibrary m_Materials;

	private PostProcessData m_Data;

	private DepthOfField m_DepthOfField;

	private MotionBlur m_MotionBlur;

	private PaniniProjection m_PaniniProjection;

	private Bloom m_Bloom;

	private LensDistortion m_LensDistortion;

	private ChromaticAberration m_ChromaticAberration;

	private Vignette m_Vignette;

	private ColorLookup m_ColorLookup;

	private ColorAdjustments m_ColorAdjustments;

	private Tonemapping m_Tonemapping;

	private FilmGrain m_FilmGrain;

	private const int k_MaxPyramidSize = 16;

	private readonly GraphicsFormat m_DefaultHDRFormat;

	private bool m_UseRGBM;

	private readonly GraphicsFormat m_SMAAEdgeFormat;

	private readonly GraphicsFormat m_GaussianCoCFormat;

	private int m_DitheringTextureIndex;

	private RenderTargetIdentifier[] m_MRT2;

	private Vector4[] m_BokehKernel;

	private int m_BokehHash;

	private float m_BokehMaxRadius;

	private float m_BokehRCPAspect;

	private bool m_IsFinalPass;

	private bool m_HasFinalPass;

	private bool m_EnableColorEncodingIfNeeded;

	private bool m_UseFastSRGBLinearConversion;

	private bool m_SupportDataDrivenLensFlare;

	private bool m_ResolveToScreen;

	private bool m_UseSwapBuffer;

	private RTHandle m_ScalingSetupTarget;

	private RTHandle m_UpscaledTarget;

	private Material m_BlitMaterial;

	internal static readonly int k_ShaderPropertyId_ViewProjM;

	internal static readonly int k_ShaderPropertyId_PrevViewProjM;

	internal static readonly int k_ShaderPropertyId_ViewProjMStereo;

	internal static readonly int k_ShaderPropertyId_PrevViewProjMStereo;

	public PostProcessPass(RenderPassEvent evt, PostProcessData data, ref PostProcessParams postProcessParams)
	{
	}

	public void Cleanup()
	{
	}

	public void Dispose()
	{
	}

	public void Setup(in RenderTextureDescriptor baseDescriptor, in RTHandle source, bool resolveToScreen, in RTHandle depth, in RTHandle internalLut, in RTHandle motionVectors, bool hasFinalPass, bool enableColorEncoding)
	{
	}

	public void Setup(in RenderTextureDescriptor baseDescriptor, in RTHandle source, RTHandle destination, in RTHandle depth, in RTHandle internalLut, bool hasFinalPass, bool enableColorEncoding)
	{
	}

	public void SetupFinalPass(in RTHandle source, bool useSwapBuffer = false, bool enableColorEncoding = true)
	{
	}

	public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
	{
	}

	public bool CanRunOnTile()
	{
		return false;
	}

	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	private RenderTextureDescriptor GetCompatibleDescriptor()
	{
		return default(RenderTextureDescriptor);
	}

	private RenderTextureDescriptor GetCompatibleDescriptor(int width, int height, GraphicsFormat format, DepthBits depthBufferBits = DepthBits.None)
	{
		return default(RenderTextureDescriptor);
	}

	internal static RenderTextureDescriptor GetCompatibleDescriptor(RenderTextureDescriptor desc, int width, int height, GraphicsFormat format, DepthBits depthBufferBits = DepthBits.None)
	{
		return default(RenderTextureDescriptor);
	}

	private bool RequireSRGBConversionBlitToBackBuffer(ref CameraData cameraData)
	{
		return false;
	}

	private bool RequireHDROutput(ref CameraData cameraData)
	{
		return false;
	}

	private void Render(CommandBuffer cmd, ref RenderingData renderingData)
	{
	}

	private void DoSubpixelMorphologicalAntialiasing(ref CameraData cameraData, CommandBuffer cmd, RTHandle source, RTHandle destination)
	{
	}

	private void DoDepthOfField(Camera camera, CommandBuffer cmd, RTHandle source, RTHandle destination, Rect pixelRect)
	{
	}

	private void DoGaussianDepthOfField(Camera camera, CommandBuffer cmd, RTHandle source, RTHandle destination, Rect pixelRect)
	{
	}

	private void PrepareBokehKernel(float maxRadius, float rcpAspect)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static float GetMaxBokehRadiusInPixels(float viewportHeight)
	{
		return 0f;
	}

	private void DoBokehDepthOfField(CommandBuffer cmd, RTHandle source, RTHandle destination, Rect pixelRect)
	{
	}

	private static float GetLensFlareLightAttenuation(Light light, Camera cam, Vector3 wo)
	{
		return 0f;
	}

	private void LensFlareDataDrivenComputeOcclusion(Camera camera, CommandBuffer cmd, RenderTargetIdentifier source, bool usePanini, float paniniDistance, float paniniCropToFit)
	{
	}

	private void LensFlareDataDriven(Camera camera, CommandBuffer cmd, RenderTargetIdentifier source, bool usePanini, float paniniDistance, float paniniCropToFit)
	{
	}

	internal static void UpdateMotionBlurMatrices(ref Material material, Camera camera, XRPass xr)
	{
	}

	private void DoMotionBlur(CommandBuffer cmd, RTHandle source, RTHandle destination, ref CameraData cameraData)
	{
	}

	private void DoPaniniProjection(Camera camera, CommandBuffer cmd, RTHandle source, RTHandle destination)
	{
	}

	private Vector2 CalcViewExtents(Camera camera)
	{
		return default(Vector2);
	}

	private Vector2 CalcCropExtents(Camera camera, float d)
	{
		return default(Vector2);
	}

	private void SetupBloom(CommandBuffer cmd, RTHandle source, Material uberMaterial)
	{
	}

	private void SetupLensDistortion(Material material, bool isSceneView)
	{
	}

	private void SetupChromaticAberration(Material material)
	{
	}

	private void SetupVignette(Material material, XRPass xrPass)
	{
	}

	private void SetupColorGrading(CommandBuffer cmd, ref RenderingData renderingData, Material material)
	{
	}

	private void SetupGrain(ref CameraData cameraData, Material material)
	{
	}

	private void SetupDithering(ref CameraData cameraData, Material material)
	{
	}

	private void SetupHDROutput(HDROutputUtils.HDRDisplayInformation hdrDisplayInformation, ColorGamut hdrDisplayColorGamut, Material material, HDROutputUtils.Operation hdrOperations)
	{
	}

	private void RenderFinalPass(CommandBuffer cmd, ref RenderingData renderingData)
	{
	}
}
