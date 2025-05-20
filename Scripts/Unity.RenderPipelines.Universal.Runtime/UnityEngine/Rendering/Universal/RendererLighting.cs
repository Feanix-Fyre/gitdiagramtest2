using System.Collections.Generic;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal;

internal static class RendererLighting
{
	private static readonly ProfilingSampler m_ProfilingSampler;

	private static readonly ShaderTagId k_NormalsRenderingPassName;

	private static readonly Color k_NormalClearColor;

	private static readonly string k_SpriteLightKeyword;

	private static readonly string k_UsePointLightCookiesKeyword;

	private static readonly string k_LightQualityFastKeyword;

	private static readonly string k_UseNormalMap;

	private static readonly string k_UseAdditiveBlendingKeyword;

	private static readonly string[] k_UseBlendStyleKeywords;

	private static readonly int[] k_BlendFactorsPropIDs;

	private static readonly int[] k_MaskFilterPropIDs;

	private static readonly int[] k_InvertedFilterPropIDs;

	private static GraphicsFormat s_RenderTextureFormatToUse;

	private static bool s_HasSetupRenderTextureFormatToUse;

	private static readonly int k_SrcBlendID;

	private static readonly int k_DstBlendID;

	private static readonly int k_FalloffIntensityID;

	private static readonly int k_FalloffDistanceID;

	private static readonly int k_LightColorID;

	private static readonly int k_VolumeOpacityID;

	private static readonly int k_CookieTexID;

	private static readonly int k_FalloffLookupID;

	private static readonly int k_LightPositionID;

	private static readonly int k_LightInvMatrixID;

	private static readonly int k_InnerRadiusMultID;

	private static readonly int k_OuterAngleID;

	private static readonly int k_InnerAngleMultID;

	private static readonly int k_LightLookupID;

	private static readonly int k_IsFullSpotlightID;

	private static readonly int k_LightZDistanceID;

	private static readonly int k_PointLightCookieTexID;

	private static GraphicsFormat GetRenderTextureFormat()
	{
		return default(GraphicsFormat);
	}

	public static void CreateNormalMapRenderTexture(this IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmd, float renderScale)
	{
	}

	public static RenderTextureDescriptor GetBlendStyleRenderTextureDesc(this IRenderPass2D pass, RenderingData renderingData)
	{
		return default(RenderTextureDescriptor);
	}

	public static void CreateCameraSortingLayerRenderTexture(this IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmd, Downsampling downsamplingMethod)
	{
	}

	public static void EnableBlendStyle(CommandBuffer cmd, int blendStyleIndex, bool enabled)
	{
	}

	public static void DisableAllKeywords(this IRenderPass2D pass, CommandBuffer cmd)
	{
	}

	public static void ReleaseRenderTextures(this IRenderPass2D pass, CommandBuffer cmd)
	{
	}

	public static void DrawPointLight(CommandBuffer cmd, Light2D light, Mesh lightMesh, Material material)
	{
	}

	private static bool CanCastShadows(Light2D light, int layerToRender)
	{
		return false;
	}

	private static bool CanCastVolumetricShadows(Light2D light, int endLayerValue)
	{
		return false;
	}

	private static bool ShouldRenderLight(Light2D light, int blendStyleIndex, int layerToRender)
	{
		return false;
	}

	private static void RenderLightSet(IRenderPass2D pass, RenderingData renderingData, int blendStyleIndex, CommandBuffer cmd, int layerToRender, RenderTargetIdentifier renderTexture, List<Light2D> lights)
	{
	}

	public static void RenderLightVolumes(this IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmd, int layerToRender, int endLayerValue, RenderTargetIdentifier renderTexture, RenderTargetIdentifier depthTexture, RenderBufferStoreAction intermediateStoreAction, RenderBufferStoreAction finalStoreAction, bool requiresRTInit, List<Light2D> lights)
	{
	}

	public static void SetShapeLightShaderGlobals(this IRenderPass2D pass, CommandBuffer cmd)
	{
	}

	private static float GetNormalizedInnerRadius(Light2D light)
	{
		return 0f;
	}

	private static float GetNormalizedAngle(float angle)
	{
		return 0f;
	}

	private static void GetScaledLightInvMatrix(Light2D light, out Matrix4x4 retMatrix)
	{
		retMatrix = default(Matrix4x4);
	}

	private static void SetGeneralLightShaderGlobals(IRenderPass2D pass, CommandBuffer cmd, Light2D light)
	{
	}

	private static void SetPointLightShaderGlobals(IRenderPass2D pass, CommandBuffer cmd, Light2D light)
	{
	}

	public static void ClearDirtyLighting(this IRenderPass2D pass, CommandBuffer cmd, uint blendStylesUsed)
	{
	}

	internal static void RenderNormals(this IRenderPass2D pass, ScriptableRenderContext context, RenderingData renderingData, DrawingSettings drawSettings, FilteringSettings filterSettings, RenderTargetIdentifier depthTarget, ref bool bFirstClear)
	{
	}

	public static void RenderLights(this IRenderPass2D pass, RenderingData renderingData, CommandBuffer cmd, int layerToRender, ref LayerBatch layerBatch, ref RenderTextureDescriptor rtDesc)
	{
	}

	private static void SetBlendModes(Material material, BlendMode src, BlendMode dst)
	{
	}

	private static uint GetLightMaterialIndex(Light2D light, bool isVolume)
	{
		return 0u;
	}

	private static Material CreateLightMaterial(Renderer2DData rendererData, Light2D light, bool isVolume)
	{
		return null;
	}

	private static Material GetLightMaterial(this Renderer2DData rendererData, Light2D light, bool isVolume)
	{
		return null;
	}
}
