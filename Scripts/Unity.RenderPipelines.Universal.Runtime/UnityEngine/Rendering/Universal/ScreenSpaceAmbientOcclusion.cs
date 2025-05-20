namespace UnityEngine.Rendering.Universal;

[Tooltip("The Ambient Occlusion effect darkens creases, holes, intersections and surfaces that are close to each other.")]
[DisallowMultipleRendererFeature("Screen Space Ambient Occlusion")]
internal class ScreenSpaceAmbientOcclusion : ScriptableRendererFeature
{
	internal class ScreenSpaceAmbientOcclusionPass : ScriptableRenderPass
	{
		private enum BlurTypes
		{
			Bilateral = 0,
			Gaussian = 1,
			Kawase = 2
		}

		private enum ShaderPasses
		{
			AmbientOcclusion = 0,
			BilateralBlurHorizontal = 1,
			BilateralBlurVertical = 2,
			BilateralBlurFinal = 3,
			BilateralAfterOpaque = 4,
			GaussianBlurHorizontal = 5,
			GaussianBlurVertical = 6,
			GaussianAfterOpaque = 7,
			KawaseBlur = 8,
			KawaseAfterOpaque = 9
		}

		internal string profilerTag;

		private bool m_SupportsR8RenderTextureFormat;

		private int m_BlueNoiseTextureIndex;

		private float m_BlurRandomOffsetX;

		private float m_BlurRandomOffsetY;

		private Material m_Material;

		private Texture2D[] m_BlueNoiseTextures;

		private Vector4[] m_CameraTopLeftCorner;

		private Vector4[] m_CameraXExtent;

		private Vector4[] m_CameraYExtent;

		private Vector4[] m_CameraZExtent;

		private RTHandle[] m_SSAOTextures;

		private BlurTypes m_BlurType;

		private Matrix4x4[] m_CameraViewProjections;

		private ProfilingSampler m_ProfilingSampler;

		private ScriptableRenderer m_Renderer;

		private RenderTextureDescriptor m_AOPassDescriptor;

		private ScreenSpaceAmbientOcclusionSettings m_CurrentSettings;

		private const int k_FinalTexID = 3;

		private const string k_SSAOTextureName = "_ScreenSpaceOcclusionTexture";

		private const string k_AmbientOcclusionParamName = "_AmbientOcclusionParam";

		internal static readonly int s_AmbientOcclusionParamID;

		private static readonly int s_SSAOParamsID;

		private static readonly int s_SSAOBlueNoiseParamsID;

		private static readonly int s_LastKawasePass;

		private static readonly int s_BlueNoiseTextureID;

		private static readonly int s_CameraViewXExtentID;

		private static readonly int s_CameraViewYExtentID;

		private static readonly int s_CameraViewZExtentID;

		private static readonly int s_ProjectionParams2ID;

		private static readonly int s_KawaseBlurIterationID;

		private static readonly int s_CameraViewProjectionsID;

		private static readonly int s_CameraViewTopLeftCornerID;

		private static readonly int[] m_BilateralTexturesIndices;

		private static readonly ShaderPasses[] m_BilateralPasses;

		private static readonly ShaderPasses[] m_BilateralAfterOpaquePasses;

		private static readonly int[] m_GaussianTexturesIndices;

		private static readonly ShaderPasses[] m_GaussianPasses;

		private static readonly ShaderPasses[] m_GaussianAfterOpaquePasses;

		private static readonly int[] m_KawaseTexturesIndices;

		private static readonly ShaderPasses[] m_KawasePasses;

		private static readonly ShaderPasses[] m_KawaseAfterOpaquePasses;

		private bool isRendererDeferred => false;

		internal ScreenSpaceAmbientOcclusionPass()
		{
		}

		internal bool Setup(ref ScreenSpaceAmbientOcclusionSettings featureSettings, ref ScriptableRenderer renderer, ref Material material, ref Texture2D[] blueNoiseTextures)
		{
			return false;
		}

		public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
		}

		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		private static void RenderAndSetBaseMap(ref CommandBuffer cmd, ref RenderingData renderingData, ref ScriptableRenderer renderer, ref Material mat, ref RTHandle baseMap, ref RTHandle target, ShaderPasses pass)
		{
		}

		private static void GetPassOrder(BlurTypes blurType, bool isAfterOpaque, out int[] textureIndices, out ShaderPasses[] shaderPasses)
		{
			textureIndices = null;
			shaderPasses = null;
		}

		private static bool IsAfterOpaquePass(ref ShaderPasses pass)
		{
			return false;
		}

		public override void OnCameraCleanup(CommandBuffer cmd)
		{
		}

		public void Dispose()
		{
		}
	}

	[SerializeField]
	private ScreenSpaceAmbientOcclusionSettings m_Settings;

	[SerializeField]
	[Reload("Textures/BlueNoise256/LDR_LLL1_{0}.png", 0, 7, ReloadAttribute.Package.Root)]
	[HideInInspector]
	internal Texture2D[] m_BlueNoise256Textures;

	[SerializeField]
	[HideInInspector]
	[Reload("Shaders/Utils/ScreenSpaceAmbientOcclusion.shader", ReloadAttribute.Package.Root)]
	private Shader m_Shader;

	private Material m_Material;

	private ScreenSpaceAmbientOcclusionPass m_SSAOPass;

	internal const string k_AOInterleavedGradientKeyword = "_INTERLEAVED_GRADIENT";

	internal const string k_AOBlueNoiseKeyword = "_BLUE_NOISE";

	internal const string k_OrthographicCameraKeyword = "_ORTHOGRAPHIC";

	internal const string k_SourceDepthLowKeyword = "_SOURCE_DEPTH_LOW";

	internal const string k_SourceDepthMediumKeyword = "_SOURCE_DEPTH_MEDIUM";

	internal const string k_SourceDepthHighKeyword = "_SOURCE_DEPTH_HIGH";

	internal const string k_SourceDepthNormalsKeyword = "_SOURCE_DEPTH_NORMALS";

	internal const string k_SampleCountLowKeyword = "_SAMPLE_COUNT_LOW";

	internal const string k_SampleCountMediumKeyword = "_SAMPLE_COUNT_MEDIUM";

	internal const string k_SampleCountHighKeyword = "_SAMPLE_COUNT_HIGH";

	internal ref ScreenSpaceAmbientOcclusionSettings settings
	{
		get
		{
			throw null;
		}
	}

	public override void Create()
	{
	}

	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	private bool GetMaterials()
	{
		return false;
	}
}
