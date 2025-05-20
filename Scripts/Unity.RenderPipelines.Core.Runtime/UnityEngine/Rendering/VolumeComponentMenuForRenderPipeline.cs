using System;

namespace UnityEngine.Rendering;

public class VolumeComponentMenuForRenderPipeline : VolumeComponentMenu
{
	public Type[] pipelineTypes { get; }

	public VolumeComponentMenuForRenderPipeline(string menu, params Type[] pipelineTypes)
		: base(null)
	{
	}
}
