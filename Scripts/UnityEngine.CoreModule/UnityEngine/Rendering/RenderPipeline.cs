using System.Collections.Generic;

namespace UnityEngine.Rendering;

public abstract class RenderPipeline
{
	public class StandardRequest
	{
		public RenderTexture destination;

		public int mipLevel;

		public CubemapFace face;

		public int slice;
	}

	public bool disposed { get; private set; }

	public virtual RenderPipelineGlobalSettings defaultSettings => null;

	protected abstract void Render(ScriptableRenderContext context, Camera[] cameras);

	protected virtual void ProcessRenderRequests<RequestData>(ScriptableRenderContext context, Camera camera, RequestData renderRequest)
	{
	}

	protected internal virtual bool IsRenderRequestSupported<RequestData>(Camera camera, RequestData data)
	{
		return false;
	}

	protected static void BeginContextRendering(ScriptableRenderContext context, List<Camera> cameras)
	{
	}

	protected static void BeginCameraRendering(ScriptableRenderContext context, Camera camera)
	{
	}

	protected static void EndContextRendering(ScriptableRenderContext context, List<Camera> cameras)
	{
	}

	protected static void EndCameraRendering(ScriptableRenderContext context, Camera camera)
	{
	}

	protected virtual void Render(ScriptableRenderContext context, List<Camera> cameras)
	{
	}

	internal void InternalRender(ScriptableRenderContext context, List<Camera> cameras)
	{
	}

	internal void InternalProcessRenderRequests<RequestData>(ScriptableRenderContext context, Camera camera, RequestData renderRequest)
	{
	}

	internal void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}
}
