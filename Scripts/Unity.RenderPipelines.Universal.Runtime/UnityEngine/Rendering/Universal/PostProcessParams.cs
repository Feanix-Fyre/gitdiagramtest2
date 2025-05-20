using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal;

internal struct PostProcessParams
{
	public Material blitMaterial;

	public GraphicsFormat requestHDRFormat;

	public static PostProcessParams Create()
	{
		return default(PostProcessParams);
	}
}
