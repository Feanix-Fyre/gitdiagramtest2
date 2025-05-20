using System.Collections.Generic;

namespace UnityEngine.Rendering.PostProcessing;

public sealed class PostProcessRenderContext
{
	public enum StereoRenderingMode
	{
		MultiPass = 0,
		SinglePass = 1,
		SinglePassInstanced = 2,
		SinglePassMultiview = 3
	}

	private Camera m_Camera;

	internal PropertySheet uberSheet;

	internal Texture autoExposureTexture;

	internal LogHistogram logHistogram;

	internal Texture logLut;

	internal AutoExposure autoExposure;

	internal int bloomBufferNameID;

	internal bool physicalCamera;

	private RenderTextureDescriptor m_sourceDescriptor;

	public Camera camera
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public CommandBuffer command { get; set; }

	public RenderTargetIdentifier source { get; set; }

	public RenderTargetIdentifier destination { get; set; }

	public RenderTextureFormat sourceFormat { get; set; }

	public bool flip { get; set; }

	public PostProcessResources resources { get; internal set; }

	public PropertySheetFactory propertySheets { get; internal set; }

	public Dictionary<string, object> userData { get; private set; }

	public PostProcessDebugLayer debugLayer { get; internal set; }

	public int width { get; private set; }

	public int height { get; private set; }

	public bool stereoActive { get; private set; }

	public int xrActiveEye { get; set; }

	public int numberOfEyes { get; private set; }

	public StereoRenderingMode stereoRenderingMode { get; private set; }

	public int screenWidth { get; private set; }

	public int screenHeight { get; private set; }

	public bool isSceneView { get; internal set; }

	public PostProcessLayer.Antialiasing antialiasing { get; internal set; }

	public TemporalAntialiasing temporalAntialiasing { get; internal set; }

	public void Reset()
	{
	}

	public bool IsTemporalAntialiasingActive()
	{
		return false;
	}

	public bool IsDebugOverlayEnabled(DebugOverlay overlay)
	{
		return false;
	}

	public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass)
	{
	}

	internal RenderTextureDescriptor GetDescriptor(int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default)
	{
		return default(RenderTextureDescriptor);
	}

	public void GetScreenSpaceTemporaryRT(CommandBuffer cmd, int nameID, int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default, FilterMode filter = FilterMode.Bilinear, int widthOverride = 0, int heightOverride = 0)
	{
	}

	public RenderTexture GetScreenSpaceTemporaryRT(int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default, int widthOverride = 0, int heightOverride = 0)
	{
		return null;
	}

	public void UpdateSinglePassStereoState(bool isTAAEnabled, bool isAOEnabled, bool isSSREnabled)
	{
	}
}
