using System;

namespace UnityEngine.Rendering.Universal;

[Serializable]
[ExcludeFromPreset]
[ReloadGroup]
[Obsolete("ForwardRendererData has been deprecated (UnityUpgradable) -> UniversalRendererData", true)]
public class ForwardRendererData : ScriptableRendererData
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

		[Reload("Shaders/Utils/MaterialError.shader", ReloadAttribute.Package.Root)]
		[Obsolete("Use fallbackErrorPS instead")]
		public Shader materialErrorPS;

		[SerializeField]
		[Reload("Shaders/Utils/CoreBlit.shader", ReloadAttribute.Package.Root)]
		internal Shader coreBlitPS;

		[Reload("Shaders/Utils/CoreBlitColorAndDepth.shader", ReloadAttribute.Package.Root)]
		[SerializeField]
		internal Shader coreBlitColorAndDepthPS;

		[Reload("Shaders/CameraMotionVectors.shader", ReloadAttribute.Package.Root)]
		public Shader cameraMotionVector;

		[Reload("Shaders/ObjectMotionVectors.shader", ReloadAttribute.Package.Root)]
		public Shader objectMotionVector;
	}

	private const string k_ErrorMessage = "ForwardRendererData has been deprecated. Use UniversalRendererData instead";

	public ShaderResources shaders;

	public PostProcessData postProcessData;

	[Reload("Runtime/Data/XRSystemData.asset", ReloadAttribute.Package.Root)]
	public XRSystemData xrSystemData;

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
	private bool m_AccurateGbufferNormals;

	[SerializeField]
	private bool m_ClusteredRendering;

	[SerializeField]
	private TileSize m_TileSize;

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

	protected override ScriptableRenderer Create()
	{
		return null;
	}
}
