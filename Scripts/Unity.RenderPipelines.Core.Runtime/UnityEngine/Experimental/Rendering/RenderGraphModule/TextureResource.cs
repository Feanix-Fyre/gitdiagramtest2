using System.Diagnostics;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

[DebuggerDisplay("TextureResource ({desc.name})")]
internal class TextureResource : RenderGraphResource<TextureDesc, RTHandle>
{
	private static int m_TextureCreationIndex;

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
