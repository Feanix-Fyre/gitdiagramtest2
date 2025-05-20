using System;
using System.Collections.Generic;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.Serialization;

namespace UnityEngine.Rendering.Universal;

[Serializable]
[ReloadGroup]
[ExcludeFromPreset]
[MovedFrom("UnityEngine.Experimental.Rendering.Universal")]
public class Renderer2DData : ScriptableRendererData
{
	internal enum Renderer2DDefaultMaterialType
	{
		Lit = 0,
		Unlit = 1,
		Custom = 2
	}

	[SerializeField]
	private TransparencySortMode m_TransparencySortMode;

	[SerializeField]
	private Vector3 m_TransparencySortAxis;

	[SerializeField]
	private float m_HDREmulationScale;

	[SerializeField]
	[Range(0.01f, 1f)]
	private float m_LightRenderTextureScale;

	[SerializeField]
	[FormerlySerializedAs("m_LightOperations")]
	private Light2DBlendStyle[] m_LightBlendStyles;

	[SerializeField]
	private bool m_UseDepthStencilBuffer;

	[SerializeField]
	private bool m_UseCameraSortingLayersTexture;

	[SerializeField]
	private int m_CameraSortingLayersTextureBound;

	[SerializeField]
	private Downsampling m_CameraSortingLayerDownsamplingMethod;

	[SerializeField]
	private uint m_MaxLightRenderTextureCount;

	[SerializeField]
	private uint m_MaxShadowRenderTextureCount;

	[SerializeField]
	[Reload("Shaders/2D/Light2D-Shape.shader", ReloadAttribute.Package.Root)]
	private Shader m_ShapeLightShader;

	[SerializeField]
	[Reload("Shaders/2D/Light2D-Shape-Volumetric.shader", ReloadAttribute.Package.Root)]
	private Shader m_ShapeLightVolumeShader;

	[SerializeField]
	[Reload("Shaders/2D/Light2D-Point.shader", ReloadAttribute.Package.Root)]
	private Shader m_PointLightShader;

	[SerializeField]
	[Reload("Shaders/2D/Light2D-Point-Volumetric.shader", ReloadAttribute.Package.Root)]
	private Shader m_PointLightVolumeShader;

	[SerializeField]
	[Reload("Shaders/Utils/CoreBlit.shader", ReloadAttribute.Package.Root)]
	private Shader m_CoreBlitShader;

	[SerializeField]
	[Reload("Shaders/Utils/BlitHDROverlay.shader", ReloadAttribute.Package.Root)]
	private Shader m_BlitHDROverlay;

	[Reload("Shaders/Utils/CoreBlitColorAndDepth.shader", ReloadAttribute.Package.Root)]
	[SerializeField]
	private Shader m_CoreBlitColorAndDepthPS;

	[Reload("Shaders/Utils/Sampling.shader", ReloadAttribute.Package.Root)]
	[SerializeField]
	private Shader m_SamplingShader;

	[Reload("Shaders/2D/Shadow2D-Projected.shader", ReloadAttribute.Package.Root)]
	[SerializeField]
	private Shader m_ProjectedShadowShader;

	[SerializeField]
	[Reload("Shaders/2D/Shadow2D-Shadow-Sprite.shader", ReloadAttribute.Package.Root)]
	private Shader m_SpriteShadowShader;

	[SerializeField]
	[Reload("Shaders/2D/Shadow2D-Unshadow-Sprite.shader", ReloadAttribute.Package.Root)]
	private Shader m_SpriteUnshadowShader;

	[SerializeField]
	[Reload("Shaders/2D/Shadow2D-Unshadow-Geometry.shader", ReloadAttribute.Package.Root)]
	private Shader m_GeometryUnshadowShader;

	[SerializeField]
	[Reload("Shaders/Utils/FallbackError.shader", ReloadAttribute.Package.Root)]
	private Shader m_FallbackErrorShader;

	[SerializeField]
	private PostProcessData m_PostProcessData;

	[SerializeField]
	[HideInInspector]
	[Reload("Runtime/2D/Data/Textures/FalloffLookupTexture.png", ReloadAttribute.Package.Root)]
	private Texture2D m_FallOffLookup;

	internal RTHandle normalsRenderTarget;

	internal int normalsRenderTargetId;

	internal RTHandle shadowsRenderTarget;

	internal int shadowsRenderTargetId;

	internal RTHandle cameraSortingLayerRenderTarget;

	internal int cameraSortingLayerRenderTargetId;

	public float hdrEmulationScale => 0f;

	internal float lightRenderTextureScale => 0f;

	public Light2DBlendStyle[] lightBlendStyles => null;

	internal bool useDepthStencilBuffer => false;

	internal Texture2D fallOffLookup => null;

	internal Shader shapeLightShader => null;

	internal Shader shapeLightVolumeShader => null;

	internal Shader pointLightShader => null;

	internal Shader pointLightVolumeShader => null;

	internal Shader blitShader => null;

	internal Shader blitHDROverlay => null;

	internal Shader coreBlitPS => null;

	internal Shader coreBlitColorAndDepthPS => null;

	internal Shader samplingShader => null;

	internal PostProcessData postProcessData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal Shader spriteShadowShader => null;

	internal Shader spriteUnshadowShader => null;

	internal Shader geometryUnshadowShader => null;

	internal Shader projectedShadowShader => null;

	internal TransparencySortMode transparencySortMode => default(TransparencySortMode);

	internal Vector3 transparencySortAxis => default(Vector3);

	internal uint lightRenderTextureMemoryBudget => 0u;

	internal uint shadowRenderTextureMemoryBudget => 0u;

	internal bool useCameraSortingLayerTexture => false;

	internal int cameraSortingLayerTextureBound => 0;

	internal Downsampling cameraSortingLayerDownsamplingMethod => default(Downsampling);

	internal Dictionary<uint, Material> lightMaterials { get; }

	internal Material[] spriteSelfShadowMaterial { get; set; }

	internal Material[] spriteUnshadowMaterial { get; set; }

	internal Material[] geometryUnshadowMaterial { get; set; }

	internal Material[] projectedShadowMaterial { get; set; }

	internal Material[] stencilOnlyShadowMaterial { get; set; }

	internal bool isNormalsRenderTargetValid { get; set; }

	internal float normalsRenderTargetScale { get; set; }

	internal ILight2DCullResult lightCullResult { get; set; }

	protected override ScriptableRenderer Create()
	{
		return null;
	}

	internal void Dispose()
	{
	}

	protected override void OnEnable()
	{
	}
}
