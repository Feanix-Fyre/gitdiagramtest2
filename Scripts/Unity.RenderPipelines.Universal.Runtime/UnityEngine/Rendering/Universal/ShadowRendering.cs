namespace UnityEngine.Rendering.Universal;

internal static class ShadowRendering
{
	private static readonly int k_LightPosID;

	private static readonly int k_SelfShadowingID;

	private static readonly int k_ShadowStencilGroupID;

	private static readonly int k_ShadowIntensityID;

	private static readonly int k_ShadowVolumeIntensityID;

	private static readonly int k_ShadowRadiusID;

	private static readonly int k_ShadowColorMaskID;

	private static readonly int k_ShadowModelMatrixID;

	private static readonly int k_ShadowModelInvMatrixID;

	private static readonly int k_ShadowModelScaleID;

	private static readonly ProfilingSampler m_ProfilingSamplerShadows;

	private static readonly ProfilingSampler m_ProfilingSamplerShadowsA;

	private static readonly ProfilingSampler m_ProfilingSamplerShadowsR;

	private static readonly ProfilingSampler m_ProfilingSamplerShadowsG;

	private static readonly ProfilingSampler m_ProfilingSamplerShadowsB;

	private static RTHandle[] m_RenderTargets;

	private static int[] m_RenderTargetIds;

	private static RenderTargetIdentifier[] m_LightInputTextures;

	private static readonly Color[] k_ColorLookup;

	private static readonly ProfilingSampler[] m_ProfilingSamplerShadowColorsLookup;

	public static uint maxTextureCount { get; private set; }

	public static void InitializeBudget(uint maxTextureCount)
	{
	}

	private static Material[] CreateMaterials(Shader shader, int pass = 0)
	{
		return null;
	}

	private static Material GetProjectedShadowMaterial(this Renderer2DData rendererData, int colorIndex)
	{
		return null;
	}

	private static Material GetStencilOnlyShadowMaterial(this Renderer2DData rendererData, int colorIndex)
	{
		return null;
	}

	private static Material GetSpriteSelfShadowMaterial(this Renderer2DData rendererData, int colorIndex)
	{
		return null;
	}

	private static Material GetSpriteUnshadowMaterial(this Renderer2DData rendererData, int colorIndex)
	{
		return null;
	}

	private static Material GetGeometryUnshadowMaterial(this Renderer2DData rendererData, int colorIndex)
	{
		return null;
	}

	public static void CreateShadowRenderTexture(IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmdBuffer, int shadowIndex)
	{
	}

	public static bool PrerenderShadows(IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmdBuffer, int layerToRender, Light2D light, int shadowIndex, float shadowIntensity)
	{
		return false;
	}

	public static void SetGlobalShadowTexture(CommandBuffer cmdBuffer, Light2D light, int shadowIndex)
	{
	}

	public static void DisableGlobalShadowTexture(CommandBuffer cmdBuffer)
	{
	}

	private static void CreateShadowRenderTexture(IRenderPass2D pass, int handleId, RenderingData renderingData, CommandBuffer cmdBuffer)
	{
	}

	public static void ReleaseShadowRenderTexture(CommandBuffer cmdBuffer, int shadowIndex)
	{
	}

	public static void SetShadowProjectionGlobals(CommandBuffer cmdBuffer, ShadowCaster2D shadowCaster)
	{
	}

	public static bool RenderShadows(IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmdBuffer, int layerToRender, Light2D light, float shadowIntensity, RenderTargetIdentifier renderTexture, int colorBit)
	{
		return false;
	}
}
