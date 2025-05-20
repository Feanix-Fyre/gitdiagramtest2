using System;
using System.Collections.Generic;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing;

[RequireComponent(typeof(Camera))]
[AddComponentMenu("Rendering/Post-process Layer", 1000)]
[ImageEffectAllowedInSceneView]
[DisallowMultipleComponent]
[ExecuteAlways]
public sealed class PostProcessLayer : MonoBehaviour
{
	public enum Antialiasing
	{
		None = 0,
		FastApproximateAntialiasing = 1,
		SubpixelMorphologicalAntialiasing = 2,
		TemporalAntialiasing = 3
	}

	[Serializable]
	public sealed class SerializedBundleRef
	{
		public string assemblyQualifiedName;

		public PostProcessBundle bundle;
	}

	public Transform volumeTrigger;

	public LayerMask volumeLayer;

	public bool stopNaNPropagation;

	public bool finalBlitToCameraTarget;

	public Antialiasing antialiasingMode;

	public TemporalAntialiasing temporalAntialiasing;

	public SubpixelMorphologicalAntialiasing subpixelMorphologicalAntialiasing;

	public FastApproximateAntialiasing fastApproximateAntialiasing;

	public Fog fog;

	private Dithering dithering;

	public PostProcessDebugLayer debugLayer;

	[SerializeField]
	private PostProcessResources m_Resources;

	[NonSerialized]
	private PostProcessResources m_OldResources;

	[SerializeField]
	[Preserve]
	private bool m_ShowToolkit;

	[SerializeField]
	[Preserve]
	private bool m_ShowCustomSorter;

	public bool breakBeforeColorGrading;

	[SerializeField]
	private List<SerializedBundleRef> m_BeforeTransparentBundles;

	[SerializeField]
	private List<SerializedBundleRef> m_BeforeStackBundles;

	[SerializeField]
	private List<SerializedBundleRef> m_AfterStackBundles;

	private Dictionary<Type, PostProcessBundle> m_Bundles;

	private PropertySheetFactory m_PropertySheetFactory;

	private CommandBuffer m_LegacyCmdBufferBeforeReflections;

	private CommandBuffer m_LegacyCmdBufferBeforeLighting;

	private CommandBuffer m_LegacyCmdBufferOpaque;

	private CommandBuffer m_LegacyCmdBuffer;

	private Camera m_Camera;

	private PostProcessRenderContext m_CurrentContext;

	private LogHistogram m_LogHistogram;

	private bool m_SettingsUpdateNeeded;

	private bool m_IsRenderingInSceneView;

	private TargetPool m_TargetPool;

	private bool m_NaNKilled;

	private readonly List<PostProcessEffectRenderer> m_ActiveEffects;

	private readonly List<RenderTargetIdentifier> m_Targets;

	public Dictionary<PostProcessEvent, List<SerializedBundleRef>> sortedBundles { get; private set; }

	public DepthTextureMode cameraDepthFlags { get; private set; }

	public bool haveBundlesBeenInited { get; private set; }

	private void OnEnable()
	{
	}

	private void InitLegacy()
	{
	}

	private bool DynamicResolutionAllowsFinalBlitToCameraTarget()
	{
		return false;
	}

	[ImageEffectUsesCommandBuffer]
	private void OnRenderImage(RenderTexture src, RenderTexture dst)
	{
	}

	public void Init(PostProcessResources resources)
	{
	}

	public void InitBundles()
	{
	}

	private void UpdateBundleSortList(List<SerializedBundleRef> sortedList, PostProcessEvent evt)
	{
	}

	private void OnDisable()
	{
	}

	private void Reset()
	{
	}

	private void OnPreCull()
	{
	}

	private void OnPreRender()
	{
	}

	private static bool RequiresInitialBlit(Camera camera, PostProcessRenderContext context)
	{
		return false;
	}

	private void UpdateSrcDstForOpaqueOnly(ref int src, ref int dst, PostProcessRenderContext context, RenderTargetIdentifier cameraTarget, int opaqueOnlyEffectsRemaining)
	{
	}

	private void BuildCommandBuffers()
	{
	}

	private void OnPostRender()
	{
	}

	public PostProcessBundle GetBundle<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	public PostProcessBundle GetBundle(Type settingsType)
	{
		return null;
	}

	public T GetSettings<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	public void BakeMSVOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, RenderTargetIdentifier? depthMap, bool invert, bool isMSAA = false)
	{
	}

	internal void OverrideSettings(List<PostProcessEffectSettings> baseSettings, float interpFactor)
	{
	}

	private void SetLegacyCameraFlags(PostProcessRenderContext context)
	{
	}

	public void ResetHistory()
	{
	}

	public bool HasOpaqueOnlyEffects(PostProcessRenderContext context)
	{
		return false;
	}

	public bool HasActiveEffects(PostProcessEvent evt, PostProcessRenderContext context)
	{
		return false;
	}

	private void SetupContext(PostProcessRenderContext context)
	{
	}

	public void UpdateVolumeSystem(Camera cam, CommandBuffer cmd)
	{
	}

	public void RenderOpaqueOnly(PostProcessRenderContext context)
	{
	}

	public void Render(PostProcessRenderContext context)
	{
	}

	private int RenderInjectionPoint(PostProcessEvent evt, PostProcessRenderContext context, string marker, int releaseTargetAfterUse = -1)
	{
		return 0;
	}

	private void RenderList(List<SerializedBundleRef> list, PostProcessRenderContext context, string marker)
	{
	}

	private void ApplyFlip(PostProcessRenderContext context, MaterialPropertyBlock properties)
	{
	}

	private void ApplyDefaultFlip(MaterialPropertyBlock properties)
	{
	}

	private int RenderBuiltins(PostProcessRenderContext context, bool isFinalPass, int releaseTargetAfterUse = -1, int eye = -1)
	{
		return 0;
	}

	private void RenderFinalPass(PostProcessRenderContext context, int releaseTargetAfterUse = -1, int eye = -1)
	{
	}

	private int RenderEffect<T>(PostProcessRenderContext context, bool useTempTarget = false) where T : PostProcessEffectSettings
	{
		return 0;
	}

	private bool ShouldGenerateLogHistogram(PostProcessRenderContext context)
	{
		return false;
	}
}
