using System;

namespace UnityEngine.Rendering.Universal;

[ExcludeFromPreset]
public abstract class ScriptableRendererFeature : ScriptableObject, IDisposable
{
	[SerializeField]
	[HideInInspector]
	private bool m_Active;

	public bool isActive => false;

	public abstract void Create();

	public virtual void OnCameraPreCull(ScriptableRenderer renderer, in CameraData cameraData)
	{
	}

	public abstract void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData);

	public virtual void SetupRenderPasses(ScriptableRenderer renderer, in RenderingData renderingData)
	{
	}

	private void OnEnable()
	{
	}

	private void OnValidate()
	{
	}

	internal virtual bool SupportsNativeRenderPass()
	{
		return false;
	}

	internal virtual bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, out RenderingLayerUtils.Event atEvent, out RenderingLayerUtils.MaskSize maskSize)
	{
		atEvent = default(RenderingLayerUtils.Event);
		maskSize = default(RenderingLayerUtils.MaskSize);
		return false;
	}

	public void SetActive(bool active)
	{
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}
}
