namespace UnityEngine.Rendering.Universal;

[Tooltip("Screen Space Shadows")]
[DisallowMultipleRendererFeature("Screen Space Shadows")]
internal class ScreenSpaceShadows : ScriptableRendererFeature
{
	private class ScreenSpaceShadowsPass : ScriptableRenderPass
	{
		private static string m_ProfilerTag;

		private static ProfilingSampler m_ProfilingSampler;

		private Material m_Material;

		private ScreenSpaceShadowsSettings m_CurrentSettings;

		private RTHandle m_RenderTarget;

		internal ScreenSpaceShadowsPass()
		{
		}

		public void Dispose()
		{
		}

		internal bool Setup(ScreenSpaceShadowsSettings featureSettings, Material material)
		{
			return false;
		}

		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}

	private class ScreenSpaceShadowsPostPass : ScriptableRenderPass
	{
		private static string m_ProfilerTag;

		private static ProfilingSampler m_ProfilingSampler;

		private static readonly RTHandle k_CurrentActive;

		public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
		{
		}

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}
	}

	[HideInInspector]
	[SerializeField]
	private Shader m_Shader;

	[SerializeField]
	private ScreenSpaceShadowsSettings m_Settings;

	private Material m_Material;

	private ScreenSpaceShadowsPass m_SSShadowsPass;

	private ScreenSpaceShadowsPostPass m_SSShadowsPostPass;

	private const string k_ShaderName = "Hidden/Universal Render Pipeline/ScreenSpaceShadows";

	public override void Create()
	{
	}

	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	private bool LoadMaterial()
	{
		return false;
	}
}
