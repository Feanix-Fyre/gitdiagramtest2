using System.Diagnostics;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

[DebuggerDisplay("Resource ({GetType().Name}:{GetName()})")]
internal abstract class RenderGraphResource<DescType, ResType> : IRenderGraphResource where DescType : struct where ResType : class
{
	public DescType desc;

	public ResType graphicsResource;

	public override void Reset(IRenderGraphResourcePool pool)
	{
	}

	public override bool IsCreated()
	{
		return false;
	}

	public override void ReleaseGraphicsResource()
	{
	}
}
