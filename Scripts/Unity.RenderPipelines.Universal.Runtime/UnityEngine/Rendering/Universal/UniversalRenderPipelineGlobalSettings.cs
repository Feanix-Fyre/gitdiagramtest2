using System;

namespace UnityEngine.Rendering.Universal;

internal class UniversalRenderPipelineGlobalSettings : RenderPipelineGlobalSettings, ISerializationCallbackReceiver, IShaderVariantSettings
{
	[SerializeField]
	private int k_AssetVersion;

	private static UniversalRenderPipelineGlobalSettings cachedInstance;

	public static readonly string defaultAssetName;

	[SerializeField]
	private string[] m_RenderingLayerNames;

	[NonSerialized]
	private string[] m_PrefixedRenderingLayerNames;

	[SerializeField]
	private uint m_ValidRenderingLayers;

	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", false)]
	public string lightLayerName0;

	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", false)]
	public string lightLayerName1;

	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", false)]
	public string lightLayerName2;

	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", false)]
	public string lightLayerName3;

	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", false)]
	public string lightLayerName4;

	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", false)]
	public string lightLayerName5;

	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", false)]
	public string lightLayerName6;

	[Obsolete("This is obsolete, please use renderingLayerNames instead.", false)]
	public string lightLayerName7;

	[SerializeField]
	private bool m_StripDebugVariants;

	[SerializeField]
	private bool m_StripUnusedPostProcessingVariants;

	[SerializeField]
	private bool m_StripUnusedVariants;

	[SerializeField]
	private bool m_StripUnusedLODCrossFadeVariants;

	[SerializeField]
	private bool m_StripScreenCoordOverrideVariants;

	[Obsolete("Please use stripRuntimeDebugShaders instead.", false)]
	public bool supportRuntimeDebugDisplay;

	[SerializeField]
	internal UnityEngine.Rendering.ShaderVariantLogLevel m_ShaderVariantLogLevel;

	[SerializeField]
	internal bool m_ExportShaderVariants;

	public static UniversalRenderPipelineGlobalSettings instance => null;

	private string[] renderingLayerNames => null;

	private string[] prefixedRenderingLayerNames => null;

	public string[] renderingLayerMaskNames => null;

	public string[] prefixedRenderingLayerMaskNames => null;

	public uint validRenderingLayers => 0u;

	[Obsolete("This is obsolete, please use prefixedRenderingLayerMaskNames instead.", false)]
	public string[] prefixedLightLayerNames => null;

	[Obsolete("This is obsolete, please use renderingLayerMaskNames instead.", false)]
	public string[] lightLayerNames => null;

	public bool stripDebugVariants
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool stripUnusedPostProcessingVariants
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool stripUnusedVariants
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[Obsolete("No longer used as Shader Prefiltering automatically strips out unused LOD Crossfade variants. Please use the LOD Crossfade setting in the URP Asset to disable the feature if not used.", false)]
	public bool stripUnusedLODCrossFadeVariants
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool stripScreenCoordOverrideVariants
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public UnityEngine.Rendering.ShaderVariantLogLevel shaderVariantLogLevel
	{
		get
		{
			return default(UnityEngine.Rendering.ShaderVariantLogLevel);
		}
		set
		{
		}
	}

	public bool exportShaderVariants
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void OnBeforeSerialize()
	{
	}

	public void OnAfterDeserialize()
	{
	}

	internal static void UpdateGraphicsSettings(UniversalRenderPipelineGlobalSettings newSettings)
	{
	}

	private void Reset()
	{
	}

	internal void UpdateRenderingLayerNames()
	{
	}

	internal void ResetRenderingLayerNames()
	{
	}
}
