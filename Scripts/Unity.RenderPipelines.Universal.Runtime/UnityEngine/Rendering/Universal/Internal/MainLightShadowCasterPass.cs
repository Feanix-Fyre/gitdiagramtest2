using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal.Internal;

public class MainLightShadowCasterPass : ScriptableRenderPass
{
	private static class MainLightShadowConstantBuffer
	{
		public static int _WorldToShadow;

		public static int _ShadowParams;

		public static int _CascadeShadowSplitSpheres0;

		public static int _CascadeShadowSplitSpheres1;

		public static int _CascadeShadowSplitSpheres2;

		public static int _CascadeShadowSplitSpheres3;

		public static int _CascadeShadowSplitSphereRadii;

		public static int _ShadowOffset0;

		public static int _ShadowOffset1;

		public static int _ShadowmapSize;
	}

	private class PassData
	{
		internal MainLightShadowCasterPass pass;

		internal RenderGraph graph;

		internal TextureHandle shadowmapTexture;

		internal RenderingData renderingData;

		internal int shadowmapID;

		internal bool emptyShadowmap;
	}

	private const int k_MaxCascades = 4;

	private const int k_ShadowmapBufferBits = 16;

	private float m_CascadeBorder;

	private float m_MaxShadowDistanceSq;

	private int m_ShadowCasterCascadesCount;

	private int m_MainLightShadowmapID;

	internal RTHandle m_MainLightShadowmapTexture;

	private RTHandle m_EmptyMainLightShadowmapTexture;

	private const int k_EmptyShadowMapDimensions = 1;

	private const string k_MainLightShadowMapTextureName = "_MainLightShadowmapTexture";

	private const string k_EmptyMainLightShadowMapTextureName = "_EmptyMainLightShadowmapTexture";

	private static readonly Vector4 s_EmptyShadowParams;

	private static readonly Vector4 s_EmptyShadowmapSize;

	private Matrix4x4[] m_MainLightShadowMatrices;

	private ShadowSliceData[] m_CascadeSlices;

	private Vector4[] m_CascadeSplitDistances;

	private bool m_CreateEmptyShadowmap;

	private int renderTargetWidth;

	private int renderTargetHeight;

	private ProfilingSampler m_ProfilingSetupSampler;

	public MainLightShadowCasterPass(RenderPassEvent evt)
	{
	}

	public void Dispose()
	{
	}

	public bool Setup(ref RenderingData renderingData)
	{
		return false;
	}

	private bool SetupForEmptyRendering(ref RenderingData renderingData)
	{
		return false;
	}

	public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
	{
	}

	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	private void Clear()
	{
	}

	private void SetEmptyMainLightCascadeShadowmap(ref ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	internal static void SetEmptyMainLightShadowParams(CommandBuffer cmd)
	{
	}

	private void RenderMainLightCascadeShadowmap(ref ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	private void SetupMainLightShadowReceiverConstants(CommandBuffer cmd, ref VisibleLight shadowLight, ref ShadowData shadowData)
	{
	}

	internal TextureHandle Render(RenderGraph graph, ref RenderingData renderingData)
	{
		return default(TextureHandle);
	}

	private void InitPassData(ref PassData passData, ref RenderingData renderingData, ref RenderGraph graph)
	{
	}
}
