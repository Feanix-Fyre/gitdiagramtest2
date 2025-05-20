using System;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace UnityEngine.Experimental.Rendering.Universal;

[Tooltip("Render Objects simplifies the injection of additional render passes by exposing a selection of commonly used settings.")]
[ExcludeFromPreset]
public class RenderObjects : ScriptableRendererFeature
{
	[Serializable]
	public class RenderObjectsSettings
	{
		public enum OverrideMaterialMode
		{
			None = 0,
			Material = 1,
			Shader = 2
		}

		public string passTag;

		public RenderPassEvent Event;

		public FilterSettings filterSettings;

		public Material overrideMaterial;

		public int overrideMaterialPassIndex;

		public Shader overrideShader;

		public int overrideShaderPassIndex;

		public OverrideMaterialMode overrideMode;

		public bool overrideDepthState;

		public CompareFunction depthCompareFunction;

		public bool enableWrite;

		public StencilStateData stencilSettings;

		public CustomCameraSettings cameraSettings;
	}

	[Serializable]
	public class FilterSettings
	{
		public RenderQueueType RenderQueueType;

		public LayerMask LayerMask;

		public string[] PassNames;
	}

	[Serializable]
	public class CustomCameraSettings
	{
		public bool overrideCamera;

		public bool restoreCamera;

		public Vector4 offset;

		public float cameraFieldOfView;
	}

	public RenderObjectsSettings settings;

	private RenderObjectsPass renderObjectsPass;

	public override void Create()
	{
	}

	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}

	internal override bool SupportsNativeRenderPass()
	{
		return false;
	}
}
