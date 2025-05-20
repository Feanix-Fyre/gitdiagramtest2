using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

internal class TexturePool : RenderGraphResourcePool<RTHandle>
{
	protected override void ReleaseInternalResource(RTHandle res)
	{
	}

	protected override string GetResourceName(RTHandle res)
	{
		return null;
	}

	protected override long GetResourceSize(RTHandle res)
	{
		return 0L;
	}

	protected override string GetResourceTypeName()
	{
		return null;
	}

	protected override int GetSortIndex(RTHandle res)
	{
		return 0;
	}

	public override void PurgeUnusedResources(int currentFrameIndex)
	{
	}
}
