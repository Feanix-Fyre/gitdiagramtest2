using System;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[Preserve]
public sealed class Fog
{
	[Tooltip("Enables the internal deferred fog pass. Actual fog settings should be set in the Lighting panel.")]
	public bool enabled;

	[Tooltip("Mark true for the fog to ignore the skybox")]
	public bool excludeSkybox;

	internal DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	internal bool IsEnabledAndSupported(PostProcessRenderContext context)
	{
		return false;
	}

	internal void Render(PostProcessRenderContext context)
	{
	}
}
