using System.Diagnostics;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

[DebuggerDisplay("ComputeBufferResource ({desc.name})")]
internal class ComputeBufferResource : RenderGraphResource<ComputeBufferDesc, ComputeBuffer>
{
	public override string GetName()
	{
		return null;
	}

	public override void CreatePooledGraphicsResource()
	{
	}

	public override void ReleasePooledGraphicsResource(int frameIndex)
	{
	}

	public override void CreateGraphicsResource(string name = "")
	{
	}

	public override void ReleaseGraphicsResource()
	{
	}

	public override void LogCreation(RenderGraphLogger logger)
	{
	}

	public override void LogRelease(RenderGraphLogger logger)
	{
	}
}
