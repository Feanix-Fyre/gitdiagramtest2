namespace UnityEngine.Rendering.PostProcessing;

public abstract class Monitor
{
	internal bool requested;

	public RenderTexture output { get; protected set; }

	public bool IsRequestedAndSupported(PostProcessRenderContext context)
	{
		return false;
	}

	internal abstract bool ShaderResourcesAvailable(PostProcessRenderContext context);

	internal virtual bool NeedsHalfRes()
	{
		return false;
	}

	protected void CheckOutput(int width, int height)
	{
	}

	internal virtual void OnEnable()
	{
	}

	internal virtual void OnDisable()
	{
	}

	internal abstract void Render(PostProcessRenderContext context);
}
