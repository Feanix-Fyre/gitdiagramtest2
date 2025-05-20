using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace UnityEngine.Rendering.Universal.Internal;

public class ForwardLights
{
	private static class LightConstantBuffer
	{
		public static int _MainLightPosition;

		public static int _MainLightColor;

		public static int _MainLightOcclusionProbesChannel;

		public static int _MainLightLayerMask;

		public static int _AdditionalLightsCount;

		public static int _AdditionalLightsPosition;

		public static int _AdditionalLightsColor;

		public static int _AdditionalLightsAttenuation;

		public static int _AdditionalLightsSpotDir;

		public static int _AdditionalLightOcclusionProbeChannel;

		public static int _AdditionalLightsLayerMasks;
	}

	internal struct InitParams
	{
		public LightCookieManager lightCookieManager;

		public bool forwardPlus;

		internal static InitParams Create()
		{
			return default(InitParams);
		}
	}

	private int m_AdditionalLightsBufferId;

	private int m_AdditionalLightsIndicesId;

	private const string k_SetupLightConstants = "Setup Light Constants";

	private static readonly ProfilingSampler m_ProfilingSampler;

	private static readonly ProfilingSampler m_ProfilingSamplerFPSetup;

	private static readonly ProfilingSampler m_ProfilingSamplerFPComplete;

	private static readonly ProfilingSampler m_ProfilingSamplerFPUpload;

	private MixedLightingSetup m_MixedLightingSetup;

	private Vector4[] m_AdditionalLightPositions;

	private Vector4[] m_AdditionalLightColors;

	private Vector4[] m_AdditionalLightAttenuations;

	private Vector4[] m_AdditionalLightSpotDirections;

	private Vector4[] m_AdditionalLightOcclusionProbeChannels;

	private float[] m_AdditionalLightsLayerMasks;

	private bool m_UseStructuredBuffer;

	private bool m_UseForwardPlus;

	private int m_DirectionalLightCount;

	private int m_ActualTileWidth;

	private int2 m_TileResolution;

	private JobHandle m_CullingHandle;

	private NativeArray<uint> m_ZBins;

	private GraphicsBuffer m_ZBinsBuffer;

	private NativeArray<uint> m_TileMasks;

	private GraphicsBuffer m_TileMasksBuffer;

	private LightCookieManager m_LightCookieManager;

	private ReflectionProbeManager m_ReflectionProbeManager;

	private int m_WordsPerTile;

	private float m_ZBinScale;

	private float m_ZBinOffset;

	private int m_LightCount;

	private int m_BinCount;

	internal ReflectionProbeManager reflectionProbeManager => default(ReflectionProbeManager);

	public ForwardLights()
	{
	}

	internal ForwardLights(InitParams initParams)
	{
	}

	private void CreateForwardPlusBuffers()
	{
	}

	private static int AlignByteCount(int count, int align)
	{
		return 0;
	}

	private void GetViewParams(Camera camera, float4x4 viewToClip, out float viewPlaneBot, out float viewPlaneTop, out float4 viewToViewportScaleBias)
	{
		viewPlaneBot = default(float);
		viewPlaneTop = default(float);
		viewToViewportScaleBias = default(float4);
	}

	internal void PreSetup(ref RenderingData renderingData)
	{
	}

	public void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	internal void Cleanup()
	{
	}

	private void InitializeLightConstants(NativeArray<VisibleLight> lights, int lightIndex, out Vector4 lightPos, out Vector4 lightColor, out Vector4 lightAttenuation, out Vector4 lightSpotDir, out Vector4 lightOcclusionProbeChannel, out uint lightLayerMask, out bool isSubtractive)
	{
		lightPos = default(Vector4);
		lightColor = default(Vector4);
		lightAttenuation = default(Vector4);
		lightSpotDir = default(Vector4);
		lightOcclusionProbeChannel = default(Vector4);
		lightLayerMask = default(uint);
		isSubtractive = default(bool);
	}

	private void SetupShaderLightConstants(CommandBuffer cmd, ref RenderingData renderingData)
	{
	}

	private void SetupMainLightConstants(CommandBuffer cmd, ref LightData lightData)
	{
	}

	private void SetupAdditionalLightConstants(CommandBuffer cmd, ref RenderingData renderingData)
	{
	}

	private int SetupPerObjectLightIndices(CullingResults cullResults, ref LightData lightData)
	{
		return 0;
	}
}
