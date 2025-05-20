using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace VolumetricFogAndMist2;

public class DepthRenderPrePassFeature : ScriptableRendererFeature
{
	public class DepthRenderPass : ScriptableRenderPass
	{
		private const string m_ProfilerTag = "CustomDepthPrePass";

		private const string m_DepthOnlyShader = "Hidden/VolumetricFog2/DepthOnly";

		public static readonly List<Renderer> cutOutRenderers;

		public static int transparentLayerMask;

		public static int alphaCutoutLayerMask;

		private static FilteringSettings filterSettings;

		private static int currentCutoutLayerMask;

		private static readonly List<ShaderTagId> shaderTagIdList;

		private RTHandle m_Depth;

		private static Material depthOnlyMaterial;

		private static Material depthOnlyMaterialCutOff;

		private static Material[] depthOverrideMaterials;

		private static Shader fogShader;

		private static DepthRenderPrePassFeature options;

		public void Setup(DepthRenderPrePassFeature options)
		{
		}

		private void SetupKeywords()
		{
		}

		public static void SetupLayerMasks(int transparentLayerMask, int alphaCutoutLayerMask)
		{
		}

		public static void FindAlphaClippingRenderers()
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

		public void CleanUp()
		{
		}
	}

	private DepthRenderPass m_ScriptablePass;

	public static bool installed;

	[Tooltip("Specify which cameras can execute this render feature. If you have several cameras in your scene, make sure only the correct cameras use this feature in order to optimize performance.")]
	public LayerMask cameraLayerMask;

	[Tooltip("Ignores reflection probes from executing this render feature")]
	public bool ignoreReflectionProbes;

	[Tooltip("Uses an optimized shader to compute depth for the objects included in the transparent pass. If this option is disabled, the original shader of the objects will be used instead (this can be useful if the original shaders include vertex transformations).")]
	public bool useOptimizedDepthOnlyShader;

	public override void Create()
	{
	}

	private void OnDestroy()
	{
	}

	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}
}
