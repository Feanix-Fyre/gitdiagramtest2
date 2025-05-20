using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Beautify.Universal;

public class BeautifyRendererFeature : ScriptableRendererFeature
{
	private static class ShaderParams
	{
		public static int mainTex;

		public static int inputTex;

		public static int sharpen;

		public static int colorParams;

		public static int colorBoost;

		public static int tintColor;

		public static int compareTex;

		public static int compareParams;

		public static int fxColor;

		public static int lutTex;

		public static int lut3DTexture;

		public static int lut3DParams;

		public static int colorTemp;

		public static int flipY;

		public static int blurScale;

		public static int tempBlurRT;

		public static int tempBloomCustomComposeRT;

		public static int tempBloomCustomComposeRTOriginal;

		public static int tempBlurOneDirRT;

		public static int tempBlurOneDirRTOriginal;

		public static int tempBlurDownscaling;

		public static int bloom;

		public static int bloomWeights;

		public static int bloomWeights2;

		public static int bloomDepthThreshold;

		public static int bloomNearThreshold;

		public static int bloomTex;

		public static int bloomTex1;

		public static int bloomTex2;

		public static int bloomTex3;

		public static int bloomTex4;

		public static int bloomTint;

		public static int bloomTint0;

		public static int bloomTint1;

		public static int bloomTint2;

		public static int bloomTint3;

		public static int bloomTint4;

		public static int bloomTint5;

		public static int bloomSpread;

		public static int bloomExclusionZBias;

		public static int dirt;

		public static int dirtTex;

		public static int screenLum;

		public static int afData;

		public static int afDepthThreshold;

		public static int afNearThreshold;

		public static int afTintColor;

		public static int afCombineTex;

		public static int sfSunData;

		public static int sfSunPos;

		public static int sfSunDir;

		public static int sfSunTintColor;

		public static int sfOcclusionThreshold;

		public static int sfCoronaRays1;

		public static int sfCoronaRays2;

		public static int sfGhosts1;

		public static int sfGhosts2;

		public static int sfGhosts3;

		public static int sfGhosts4;

		public static int sfHalo;

		public static int sfRT;

		public static int sfFlareTex;

		public static int sfAspectRatio;

		public static int sfOcclusionTex;

		public static int dofRT;

		public static int dofTempBlurDoFAlphaRT;

		public static int dofTempBlurDoFTemp1RT;

		public static int dofTempBlurDoFTemp2RT;

		public static int dofBokehData;

		public static int dofBokehData2;

		public static int dofBokehData3;

		public static int dofBokehRT;

		public static int vignette;

		public static int vignetteData;

		public static int vignetteData2;

		public static int vignetteMask;

		public static int purkinje;

		public static int eaLumSrc;

		public static int eaHist;

		public static int eaParams;

		public static int outline;

		public static int outlineIntensityMultiplier;

		public static int outlineDistanceFade;

		public static int outlineRT;

		public static int blurRT;

		public static int blurMaskedRT;

		public static int blurMask;

		public static int nightVision;

		public static int nightVisionDepth;

		public static int chromaticAberrationData;

		public static int chromaticTempTex;

		public static int lutPreview;

		public static int frameColor;

		public static int frameMask;

		public static int frameData;

		public static int CustomDepthAlphaCutoff;

		public static int CustomDepthBaseMap;

		public static int edgeAntialiasing;

		public static int miniViewTex;

		public static int miniViewRect;

		public static int miniViewBlend;
	}

	private class BeautifyRenderPass : ScriptableRenderPass
	{
		private enum Pass
		{
			CopyExact = 0,
			Compare = 1,
			Beautify = 2,
			BloomLuminance = 3,
			BloomDebug = 4,
			BlurHoriz = 5,
			BlurVert = 6,
			BloomCompose = 7,
			BloomResample = 8,
			BloomResampleAndCombine = 9,
			BloomLuminanceAntiflicker = 10,
			AnamorphicFlaresResample = 11,
			AnamorphicFlaresResampleAndCombine = 12,
			ComputeScreenLum = 13,
			DownsampleScreenLum = 14,
			BlendScreenLum = 15,
			SimpleBlendLum = 16,
			AnamorphicFlaresLuminance = 17,
			AnamorphicFlaresLuminanceAntiflicker = 18,
			SunFlares = 19,
			SunFlaresAdditive = 20,
			DoFCoC = 21,
			DoFCoCDebug = 22,
			DoFBlur = 23,
			DoFBlurWithoutBokeh = 24,
			DoFBlurHorizontally = 25,
			DoFBlurVertically = 26,
			CopyBilinear = 27,
			BloomExclusionLayerDebug = 28,
			DoFDebugTransparent = 29,
			ChromaticAberration = 30,
			OutlineDetect = 31,
			OutlineBlurH = 32,
			OutlineBlurV = 33,
			OutlineBlend = 34,
			BlurMask = 35,
			DoFBokeh = 36,
			DoFAdditive = 37,
			DoFBlurBokeh = 38,
			AnamorphicFlaresExclusionLayerDebug = 39,
			CopyWithMiniView = 40,
			SunFlaresOcclusionTest = 41
		}

		private struct BloomMipData
		{
			public int rtDown;

			public int rtUp;

			public int width;

			public int height;

			public int rtDownOriginal;

			public int rtUpOriginal;
		}

		private class PerCamData
		{
			public RenderTexture rtEAacum;

			public RenderTexture rtEAHist;

			public RTHandle rtSunFlaresOcclusion;

			public float sunFlareCurrentIntensity;

			public Vector4 sunLastScrPos;

			public float sunLastRot;

			public float sunFlareTime;
		}

		private Beautify beautify;

		private const int PYRAMID_COUNT_BLOOM = 5;

		private const int PYRAMID_COUNT_BLOOM_TURBO = 3;

		private const int PYRAMID_COUNT_EA = 9;

		private Material bMat;

		private ScriptableRenderer renderer;

		private RTHandle source;

		private CameraData cameraData;

		private RenderTextureDescriptor sourceDesc;

		private RenderTextureDescriptor sourceDescHP;

		private bool supportsFPTextures;

		private BloomMipData[] rt;

		private BloomMipData[] rtAF;

		private int[] rtEA;

		private Texture2D dirtTexture;

		private Texture2D flareTex;

		private float dofPrevDistance;

		private float dofLastAutofocusDistance;

		private Vector4 dofLastBokehData;

		private readonly Dictionary<Camera, PerCamData> perCamData;

		private PerCamData camData;

		private bool requiresSunFlaresOcclusionRTInit;

		private bool requiresLuminanceComputation;

		private bool usesBloomAndFlares;

		private bool usesDepthOfField;

		private bool usesVignetting;

		private bool usesSeparateOutline;

		private readonly List<string> keywords;

		private string[] keywordsArray;

		private bool setup;

		private static Matrix4x4 matrix4x4identity;

		private bool supportsR8Format;

		private bool supportsRGHalfFormat;

		private RenderTexture rtCapture;

		private static Mesh _fullScreenMesh;

		private Vector3 camPrevPos;

		private Quaternion camPrevRotation;

		private float currSens;

		private BeautifySettings sceneSettings;

		private Mesh fullscreenMesh => null;

		public bool Setup(Shader shader, ScriptableRenderer renderer, RenderingData renderingData, RenderPassEvent renderingPassEvent, bool ignorePostProcessingOption)
		{
			return false;
		}

		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		private void FullScreenBlit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int passIndex)
		{
		}

		private void FullScreenBlitToCamera(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int passIndex)
		{
		}

		public override void FrameCleanup(CommandBuffer cmd)
		{
		}

		public void Cleanup()
		{
		}

		private void RestoreRTBufferIds()
		{
		}

		private int ApplyFinalBlur(CommandBuffer cmd, RenderTargetIdentifier source)
		{
			return 0;
		}

		private void DoBloomAndFlares(CommandBuffer cmd)
		{
		}

		private void BlendOneOne(CommandBuffer cmd, int source, ref int destination, ref int tempBuffer)
		{
		}

		private void BlurThis(CommandBuffer cmd, RenderTextureDescriptor desc, int rt, int width, int height, Material blurMat, float blurScale = 1f)
		{
		}

		private void BlurThisDownsampling(CommandBuffer cmd, RenderTextureDescriptor desc, int rtSource, int rt, int width, int height, Material blurMat, float blurScale = 1f)
		{
		}

		private void BlurThisOneDirection(CommandBuffer cmd, RenderTextureDescriptor desc, ref int rt, int width, int height, bool vertical, float blurScale = 1f)
		{
		}

		private void BlurThisOneDirectionDownscaling(CommandBuffer cmd, RenderTextureDescriptor desc, int rtSource, int rt, int width, int height, bool vertical, float blurScale = 1f)
		{
		}

		private void DoDoF(CommandBuffer cmd)
		{
		}

		private void BlurThisDoF(CommandBuffer cmd, RenderTextureDescriptor dofDesc, int rt, int renderPass)
		{
		}

		private void BlurThisAlpha(CommandBuffer cmd, RenderTextureDescriptor dofDesc, int rt, float blurScale = 1f)
		{
		}

		private void UpdateDepthOfFieldBlurData(CommandBuffer cmd, Vector2 blurDir)
		{
		}

		private void DoVignette()
		{
		}

		private void DoEyeAdaptation(CommandBuffer cmd)
		{
		}

		private void DoSeparateOutline(CommandBuffer cmd)
		{
		}

		private void BlurThisOutline(CommandBuffer cmd, RenderTextureDescriptor desc, float blurScale, int downscale)
		{
		}

		private void UpdateMaterialProperties()
		{
		}

		private void UpdateMaterialBloomIntensityAndThreshold()
		{
		}

		private void UpdateDepthOfFieldData(CommandBuffer cmd)
		{
		}

		private void UpdateDoFAutofocusDistance(Camera cam)
		{
		}

		private void CheckSun()
		{
		}

		private bool CheckSceneSettings()
		{
			return false;
		}

		private void CheckCameraDepthTextureMode(Camera cam)
		{
		}
	}

	private class BeautifyBloomLumMaskPass : ScriptableRenderPass
	{
		private readonly List<ShaderTagId> m_ShaderTagIdList;

		private const string bloomSourceDepthRT = "_BloomSourceDepth";

		private static int bloomSourceDepthId;

		private RTHandle maskRT;

		private RTHandle depthRT;

		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public override void FrameCleanup(CommandBuffer cmd)
		{
		}
	}

	private class BeautifyAnamorphicFlaresLumMaskPass : ScriptableRenderPass
	{
		private readonly List<ShaderTagId> m_ShaderTagIdList;

		public const string afSourceDepthRT = "_AFSourceDepth";

		private static int afSourceDepthId;

		private RTHandle maskRT;

		private RTHandle depthRT;

		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public override void FrameCleanup(CommandBuffer cmd)
		{
		}
	}

	private class BeautifyDoFTransparentMaskPass : ScriptableRenderPass
	{
		private readonly List<ShaderTagId> m_ShaderTagIdList;

		private static readonly List<Renderer> cutOutRenderers;

		private const string dofTransparentDepthRT = "_DoFTransparentDepth";

		private static int dofTransparentDepthId;

		private static int m_CullPropertyId;

		private const string m_ProfilerTag = "CustomDepthPrePass";

		private const string m_DepthOnlyShader = "Hidden/Beautify2/DepthOnly";

		private RTHandle m_Depth;

		private Material depthOnlyMaterial;

		private Material depthOnlyMaterialCutOff;

		private int currentAlphaCutoutLayerMask;

		private Material[] depthOverrideMaterials;

		public void FindAlphaClippingRenderers()
		{
		}

		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		public override void FrameCleanup(CommandBuffer cmd)
		{
		}
	}

	private class BeautifyClearColorTarget : ScriptableRenderPass
	{
		private const string m_ProfilerTag = "Beautify Clear Color Target";

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}

	public const string SKW_SHARPEN = "BEAUTIFY_SHARPEN";

	public const string SKW_TONEMAP_ACES = "BEAUTIFY_ACES_TONEMAP";

	public const string SKW_LUT = "BEAUTIFY_LUT";

	public const string SKW_LUT3D = "BEAUTIFY_3DLUT";

	public const string SKW_BLOOM = "BEAUTIFY_BLOOM";

	public const string SKW_BLOOM_USE_DEPTH = "BEAUTIFY_BLOOM_USE_DEPTH";

	public const string SKW_BLOOM_USE_LAYER = "BEAUTIFY_BLOOM_USE_LAYER";

	public const string SKW_BLOOM_PROP_THRESHOLDING = "BEAUTIFY_BLOOM_PROP_THRESHOLDING";

	public const string SKW_DIRT = "BEAUTIFY_DIRT";

	public const string SKW_ANAMORPHIC_FLARES_USE_DEPTH = "BEAUTIFY_ANAMORPHIC_FLARES_USE_DEPTH";

	public const string SKW_ANAMORPHIC_FLARES_USE_LAYER = "BEAUTIFY_ANAMORPHIC_FLARES_USE_LAYER";

	public const string SKW_ANAMORPHIC_PROP_THRESHOLDING = "BEAUTIFY_ANAMORPHIC_PROP_THRESHOLDING";

	public const string SKW_DEPTH_OF_FIELD = "BEAUTIFY_DEPTH_OF_FIELD";

	public const string SKW_DEPTH_OF_FIELD_TRANSPARENT = "BEAUTIFY_DOF_TRANSPARENT";

	public const string SKW_VIGNETTING = "BEAUTIFY_VIGNETTING";

	public const string SKW_VIGNETTING_MASK = "BEAUTIFY_VIGNETTING_MASK";

	public const string SKW_PURKINJE = "BEAUTIFY_PURKINJE";

	public const string SKW_EYE_ADAPTATION = "BEAUTIFY_EYE_ADAPTATION";

	public const string SKW_OUTLINE = "BEAUTIFY_OUTLINE";

	public const string SKW_OUTLINE_DEPTH_FADE = "BEAUTIFY_DEPTH_FADE";

	public const string SKW_TURBO = "BEAUTIFY_TURBO";

	public const string SKW_COLOR_TWEAKS = "BEAUTIFY_COLOR_TWEAKS";

	public const string SKW_NIGHT_VISION = "BEAUTIFY_NIGHT_VISION";

	public const string SKW_THERMAL_VISION = "BEAUTIFY_THERMAL_VISION";

	public const string SKW_DITHER = "BEAUTIFY_DITHER";

	public const string SKW_CHROMATIC_ABERRATION = "BEAUTIFY_CABERRATION";

	public const string SKW_FRAME = "BEAUTIFY_FRAME";

	public const string SKW_FRAME_MASK = "BEAUTIFY_FRAME_MASK";

	public const string SKW_SUN_FLARES_USE_GHOSTS = "BEAUTIFY_SF_USE_GHOSTS";

	public const string SKW_SUN_FLARES_OCCLUSION_INIT = "BEAUTIFY_SF_OCCLUSION_INIT";

	public const string SKW_SUN_FLARES_OCCLUSION_SIMPLE = "BEAUTIFY_SF_OCCLUSION_SIMPLE";

	public const string SKW_SUN_FLARES_OCCLUSION_SMOOTH = "BEAUTIFY_SF_OCCLUSION_SMOOTH";

	public const string SKW_CUSTOM_DEPTH_ALPHA_TEST = "DEPTH_PREPASS_ALPHA_TEST";

	public const string SKW_EDGE_ANTIALIASING = "BEAUTIFY_EDGE_AA";

	[SerializeField]
	[HideInInspector]
	private Shader shader;

	private BeautifyRenderPass m_BeautifyRenderPass;

	private BeautifyDoFTransparentMaskPass m_BeautifyDoFTransparentMaskPass;

	private BeautifyBloomLumMaskPass m_BeautifyBloomLumMaskPass;

	private BeautifyAnamorphicFlaresLumMaskPass m_BeautifyAnamorphicFlaresLumMaskPass;

	private BeautifyClearColorTarget m_BeautifyClearColorTarget;

	[Tooltip("Note: this option is ignored if Direct Write To Camera option in Beautify volume inspector is enabled.")]
	public RenderPassEvent renderPassEvent;

	[Tooltip("Allows Beautify to be executed even if camera has Post Processing option disabled.")]
	public bool ignorePostProcessingOption;

	[Tooltip("Ensures color buffer is cleared before rendering in XR. This option solves an issue with OpenXR and occlusion mesh which causes color bleeding when bloom is enabled.")]
	public bool clearXRColorBuffer;

	[Tooltip("Specify which cameras can render Beautify effects")]
	public LayerMask cameraLayerMask;

	public static bool installed;

	public static bool ignoringPostProcessingOption;

	private void OnDisable()
	{
	}

	public override void Create()
	{
	}

	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}
}
