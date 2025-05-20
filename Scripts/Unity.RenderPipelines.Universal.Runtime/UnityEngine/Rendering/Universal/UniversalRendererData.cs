using System;

namespace UnityEngine.Rendering.Universal;

[Serializable]
[ReloadGroup]
[ExcludeFromPreset]
public class UniversalRendererData : ScriptableRendererData, ISerializationCallbackReceiver
{
	[Serializable]
	[ReloadGroup]
	public sealed class ShaderResources
	{
		[Reload("Shaders/Utils/Blit.shader", ReloadAttribute.Package.Root)]
		public Shader blitPS;

		[Reload("Shaders/Utils/CopyDepth.shader", ReloadAttribute.Package.Root)]
		public Shader copyDepthPS;

		[Obsolete("Obsolete, this feature will be supported by new 'ScreenSpaceShadows' renderer feature")]
		public Shader screenSpaceShadowPS;

		[Reload("Shaders/Utils/Sampling.shader", ReloadAttribute.Package.Root)]
		public Shader samplingPS;

		[Reload("Shaders/Utils/StencilDeferred.shader", ReloadAttribute.Package.Root)]
		public Shader stencilDeferredPS;

		[Reload("Shaders/Utils/FallbackError.shader", ReloadAttribute.Package.Root)]
		public Shader fallbackErrorPS;

		[Reload("Shaders/Utils/FallbackLoading.shader", ReloadAttribute.Package.Root)]
		public Shader fallbackLoadingPS;

		[Obsolete("Use fallbackErrorPS instead")]
		[Reload("Shaders/Utils/MaterialError.shader", ReloadAttribute.Package.Root)]
		public Shader materialErrorPS;

		[Reload("Shaders/Utils/CoreBlit.shader", ReloadAttribute.Package.Root)]
		[SerializeField]
		internal Shader coreBlitPS;

		[SerializeField]
		[Reload("Shaders/Utils/CoreBlitColorAndDepth.shader", ReloadAttribute.Package.Root)]
		internal Shader coreBlitColorAndDepthPS;

		[Reload("Shaders/Utils/BlitHDROverlay.shader", ReloadAttribute.Package.Root)]
		[SerializeField]
		internal Shader blitHDROverlay;

		[Reload("Shaders/CameraMotionVectors.shader", ReloadAttribute.Package.Root)]
		public Shader cameraMotionVector;

		[Reload("Shaders/ObjectMotionVectors.shader", ReloadAttribute.Package.Root)]
		public Shader objectMotionVector;

		[Reload("Shaders/PostProcessing/LensFlareDataDriven.shader", ReloadAttribute.Package.Root)]
		public Shader dataDrivenLensFlare;
	}

	public PostProcessData postProcessData;

	[Reload("Runtime/Data/XRSystemData.asset", ReloadAttribute.Package.Root)]
	public XRSystemData xrSystemData;

	public ShaderResources shaders;

	private const int k_LatestAssetVersion = 2;

	[SerializeField]
	private int m_AssetVersion;

	[SerializeField]
	private LayerMask m_OpaqueLayerMask;

	[SerializeField]
	private LayerMask m_TransparentLayerMask;

	[SerializeField]
	private StencilStateData m_DefaultStencilState;

	[SerializeField]
	private bool m_ShadowTransparentReceive;

	[SerializeField]
	private RenderingMode m_RenderingMode;

	[SerializeField]
	private DepthPrimingMode m_DepthPrimingMode;

	[SerializeField]
	private CopyDepthMode m_CopyDepthMode;

	[SerializeField]
	private bool m_AccurateGbufferNormals;

	[SerializeField]
	private IntermediateTextureMode m_IntermediateTextureMode;

	public LayerMask opaqueLayerMask
	{
		get
		{
			return default(LayerMask);
		}
		set
		{
		}
	}

	public LayerMask transparentLayerMask
	{
		get
		{
			return default(LayerMask);
		}
		set
		{
		}
	}

	public StencilStateData defaultStencilState
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool shadowTransparentReceive
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public RenderingMode renderingMode
	{
		get
		{
			return default(RenderingMode);
		}
		set
		{
		}
	}

	public DepthPrimingMode depthPrimingMode
	{
		get
		{
			return default(DepthPrimingMode);
		}
		set
		{
		}
	}

	public CopyDepthMode copyDepthMode
	{
		get
		{
			return default(CopyDepthMode);
		}
		set
		{
		}
	}

	public bool accurateGbufferNormals
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public IntermediateTextureMode intermediateTextureMode
	{
		get
		{
			return default(IntermediateTextureMode);
		}
		set
		{
		}
	}

	protected override ScriptableRenderer Create()
	{
		return null;
	}

	protected override void OnEnable()
	{
	}

	private void ReloadAllNullProperties()
	{
	}

	void ISerializationCallbackReceiver.OnBeforeSerialize()
	{
	}

	void ISerializationCallbackReceiver.OnAfterDeserialize()
	{
	}
}
