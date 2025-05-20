using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace VolumetricFogAndMist2;

public class VolumetricFogRenderFeature : ScriptableRendererFeature
{
	public static class ShaderParams
	{
		public const string LightBufferName = "_LightBuffer";

		public static int LightBuffer;

		public static int LightBufferSize;

		public static int MainTex;

		public static int BlurRT;

		public static int BlurRT2;

		public static int MiscData;

		public static int ForcedInvisible;

		public static int DownsampledDepth;

		public static int BlueNoiseTexture;

		public static int BlurScale;

		public static int Downscaling;

		public static int ScatteringData;

		public static int ScatteringTint;

		public static int BlurredTex;

		public const string SKW_DITHER = "DITHER";

		public const string SKW_EDGE_PRESERVE = "EDGE_PRESERVE";

		public const string SKW_EDGE_PRESERVE_UPSCALING = "EDGE_PRESERVE_UPSCALING";

		public const string SKW_SCATTERING_HQ = "SCATTERING_HQ";
	}

	private class VolumetricFogRenderPass : ScriptableRenderPass
	{
		private const string m_ProfilerTag = "Volumetric Fog Light Buffer Rendering";

		private static FilteringSettings filteringSettings;

		private static readonly List<ShaderTagId> shaderTagIdList;

		private RTHandle m_LightBuffer;

		private VolumetricFogRenderFeature settings;

		public void CleanUp()
		{
		}

		public void Setup(VolumetricFogRenderFeature settings)
		{
		}

		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}

	private class BlurRenderPass : ScriptableRenderPass
	{
		private enum Pass
		{
			BlurHorizontal = 0,
			BlurVertical = 1,
			BlurVerticalAndBlend = 2,
			UpscalingBlend = 3,
			DownscaleDepth = 4,
			BlurVerticalFinal = 5,
			Resample = 6,
			ResampleAndCombine = 7,
			ScatteringPrefilter = 8,
			ScatteringBlend = 9
		}

		private class PassData
		{
			public RTHandle source;
		}

		private struct ScatteringMipData
		{
			public int rtDown;

			public int rtUp;

			public int width;

			public int height;
		}

		private const string m_ProfilerTag = "Volumetric Fog Render Feature";

		private ScriptableRenderer renderer;

		private static Material mat;

		private static RenderTextureDescriptor sourceDesc;

		private static VolumetricFogManager manager;

		private static readonly PassData passData;

		private static ScatteringMipData[] rt;

		private const int PYRAMID_MAX_LEVELS = 5;

		public void Setup(Shader shader, ScriptableRenderer renderer, VolumetricFogRenderFeature settings)
		{
		}

		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		private static void ExecutePass(PassData passData, CommandBuffer cmd)
		{
		}

		private static void ComputeScattering(CommandBuffer cmd, RTHandle source, Material mat)
		{
		}

		private static void FullScreenBlit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int passIndex)
		{
		}

		public static void Cleanup()
		{
		}
	}

	[SerializeField]
	[HideInInspector]
	private Shader blurShader;

	private VolumetricFogRenderPass fogRenderPass;

	private BlurRenderPass blurRenderPass;

	public static bool installed;

	public static bool isRenderingBeforeTransparents;

	public RenderPassEvent renderPassEvent;

	[Tooltip("Specify which fog volumes will be rendered by this feature.")]
	public LayerMask fogLayerMask;

	[Tooltip("Specify which cameras can execute this render feature. If you have several cameras in your scene, make sure only the correct cameras use this feature in order to optimize performance.")]
	public LayerMask cameraLayerMask;

	[Tooltip("Ignores reflection probes from executing this render feature")]
	public bool ignoreReflectionProbes;

	public static int GetScaledSize(int size, float factor)
	{
		return 0;
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public override void Create()
	{
	}

	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}
}
