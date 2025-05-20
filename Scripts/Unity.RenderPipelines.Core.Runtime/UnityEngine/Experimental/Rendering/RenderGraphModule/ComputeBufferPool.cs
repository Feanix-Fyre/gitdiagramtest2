namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

internal class ComputeBufferPool : RenderGraphResourcePool<ComputeBuffer>
{
	protected override void ReleaseInternalResource(ComputeBuffer res)
	{
	}

	protected override string GetResourceName(ComputeBuffer res)
	{
		return null;
	}

	protected override long GetResourceSize(ComputeBuffer res)
	{
		return 0L;
	}

	protected override string GetResourceTypeName()
	{
		return null;
	}

	protected override int GetSortIndex(ComputeBuffer res)
	{
		return 0;
	}

	public override void PurgeUnusedResources(int currentFrameIndex)
	{
	}
}
