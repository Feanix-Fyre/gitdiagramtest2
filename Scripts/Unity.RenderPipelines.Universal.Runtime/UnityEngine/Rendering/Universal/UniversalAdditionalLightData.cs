using System;

namespace UnityEngine.Rendering.Universal;

[RequireComponent(typeof(Light))]
[DisallowMultipleComponent]
public class UniversalAdditionalLightData : MonoBehaviour, ISerializationCallbackReceiver, IAdditionalData
{
	[SerializeField]
	private int m_Version;

	[Tooltip("Controls if light Shadow Bias parameters use pipeline settings.")]
	[SerializeField]
	private bool m_UsePipelineSettings;

	public static readonly int AdditionalLightsShadowResolutionTierCustom;

	public static readonly int AdditionalLightsShadowResolutionTierLow;

	public static readonly int AdditionalLightsShadowResolutionTierMedium;

	public static readonly int AdditionalLightsShadowResolutionTierHigh;

	public static readonly int AdditionalLightsShadowDefaultResolutionTier;

	public static readonly int AdditionalLightsShadowDefaultCustomResolution;

	[NonSerialized]
	private Light m_Light;

	public static readonly int AdditionalLightsShadowMinimumResolution;

	[Tooltip("Controls if light shadow resolution uses pipeline settings.")]
	[SerializeField]
	private int m_AdditionalLightsShadowResolutionTier;

	[SerializeField]
	[Obsolete("This is obsolete, please use m_RenderingLayerMask instead.", false)]
	private LightLayerEnum m_LightLayerMask;

	[SerializeField]
	private uint m_RenderingLayers;

	[SerializeField]
	private bool m_CustomShadowLayers;

	[SerializeField]
	private LightLayerEnum m_ShadowLayerMask;

	[SerializeField]
	private uint m_ShadowRenderingLayers;

	[SerializeField]
	private Vector2 m_LightCookieSize;

	[SerializeField]
	private Vector2 m_LightCookieOffset;

	[SerializeField]
	private SoftShadowQuality m_SoftShadowQuality;

	internal int version => 0;

	public bool usePipelineSettings
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal Light light => null;

	public int additionalLightsShadowResolutionTier => 0;

	[Obsolete("This is obsolete, please use renderingLayerMask instead.", false)]
	public LightLayerEnum lightLayerMask
	{
		get
		{
			return default(LightLayerEnum);
		}
		set
		{
		}
	}

	public uint renderingLayers
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public bool customShadowLayers
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[Obsolete("This is obsolete, please use shadowRenderingLayerMask instead.", false)]
	public LightLayerEnum shadowLayerMask
	{
		get
		{
			return default(LightLayerEnum);
		}
		set
		{
		}
	}

	public uint shadowRenderingLayers
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	[Tooltip("Controls the size of the cookie mask currently assigned to the light.")]
	public Vector2 lightCookieSize
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	[Tooltip("Controls the offset of the cookie mask currently assigned to the light.")]
	public Vector2 lightCookieOffset
	{
		get
		{
			return default(Vector2);
		}
		set
		{
		}
	}

	[Tooltip("Controls the filtering quality of soft shadows. Higher quality has lower performance.")]
	public SoftShadowQuality softShadowQuality
	{
		get
		{
			return default(SoftShadowQuality);
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

	private void SyncLightAndShadowLayers()
	{
	}
}
