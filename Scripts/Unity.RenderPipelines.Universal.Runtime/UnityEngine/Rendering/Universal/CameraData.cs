using System;
using System.Collections.Generic;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal;

public struct CameraData
{
	private Matrix4x4 m_ViewMatrix;

	private Matrix4x4 m_ProjectionMatrix;

	private Matrix4x4 m_JitterMatrix;

	public Camera camera;

	public CameraRenderType renderType;

	public RenderTexture targetTexture;

	public RenderTextureDescriptor cameraTargetDescriptor;

	internal Rect pixelRect;

	internal bool useScreenCoordOverride;

	internal Vector4 screenSizeOverride;

	internal Vector4 screenCoordScaleBias;

	internal int pixelWidth;

	internal int pixelHeight;

	internal float aspectRatio;

	public float renderScale;

	internal ImageScalingMode imageScalingMode;

	internal ImageUpscalingFilter upscalingFilter;

	internal bool fsrOverrideSharpness;

	internal float fsrSharpness;

	internal HDRColorBufferPrecision hdrColorBufferPrecision;

	public bool clearDepth;

	public CameraType cameraType;

	public bool isDefaultViewport;

	public bool isHdrEnabled;

	public bool allowHDROutput;

	public bool requiresDepthTexture;

	public bool requiresOpaqueTexture;

	public bool postProcessingRequiresDepthTexture;

	public bool xrRendering;

	internal bool stackLastCameraOutputToHDR;

	public SortingCriteria defaultOpaqueSortFlags;

	[Obsolete("Please use xr.enabled instead.", true)]
	public bool isStereoEnabled;

	public float maxShadowDistance;

	public bool postProcessEnabled;

	internal bool stackAnyPostProcessingEnabled;

	public IEnumerator<Action<RenderTargetIdentifier, CommandBuffer>> captureActions;

	public LayerMask volumeLayerMask;

	public Transform volumeTrigger;

	public bool isStopNaNEnabled;

	public bool isDitheringEnabled;

	public AntialiasingMode antialiasing;

	public AntialiasingQuality antialiasingQuality;

	public ScriptableRenderer renderer;

	public bool resolveFinalTarget;

	public Vector3 worldSpaceCameraPos;

	public Color backgroundColor;

	internal TaaPersistentData taaPersistentData;

	internal TemporalAA.Settings taaSettings;

	public Camera baseCamera;

	public int scaledWidth => 0;

	public int scaledHeight => 0;

	internal bool requireSrgbConversion => false;

	public bool isSceneViewCamera => false;

	public bool isPreviewCamera => false;

	internal bool isRenderPassSupportedCamera => false;

	internal bool resolveToScreen => false;

	public bool isHDROutputActive => false;

	public HDROutputUtils.HDRDisplayInformation hdrDisplayInformation => default(HDROutputUtils.HDRDisplayInformation);

	public ColorGamut hdrDisplayColorGamut => default(ColorGamut);

	public bool rendersOverlayUI => false;

	public XRPass xr { get; internal set; }

	internal XRPassUniversal xrUniversal => null;

	internal bool resetHistory => false;

	internal void SetViewAndProjectionMatrix(Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix)
	{
	}

	internal void SetViewProjectionAndJitterMatrix(Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix, Matrix4x4 jitterMatrix)
	{
	}

	internal void PushBuiltinShaderConstantsXR(CommandBuffer cmd, bool renderIntoTexture)
	{
	}

	public Matrix4x4 GetViewMatrix(int viewIndex = 0)
	{
		return default(Matrix4x4);
	}

	public Matrix4x4 GetProjectionMatrix(int viewIndex = 0)
	{
		return default(Matrix4x4);
	}

	internal Matrix4x4 GetProjectionMatrixNoJitter(int viewIndex = 0)
	{
		return default(Matrix4x4);
	}

	public Matrix4x4 GetGPUProjectionMatrix(int viewIndex = 0)
	{
		return default(Matrix4x4);
	}

	public Matrix4x4 GetGPUProjectionMatrixNoJitter(int viewIndex = 0)
	{
		return default(Matrix4x4);
	}

	internal Matrix4x4 GetGPUProjectionMatrix(bool renderIntoTexture, int viewIndex = 0)
	{
		return default(Matrix4x4);
	}

	public bool IsHandleYFlipped(RTHandle handle)
	{
		return false;
	}

	public bool IsCameraProjectionMatrixFlipped()
	{
		return false;
	}

	public bool IsRenderTargetProjectionMatrixFlipped(RTHandle color, RTHandle depth = null)
	{
		return false;
	}

	internal bool IsTemporalAAEnabled()
	{
		return false;
	}
}
