using UnityEngine.Scripting;

namespace UnityEngine.Rendering;

[RequiredByNativeCode]
public class OnDemandRendering
{
	private static int m_RenderFrameInterval;

	public static int renderFrameInterval => 0;

	[RequiredByNativeCode]
	internal static void GetRenderFrameInterval(out int frameInterval)
	{
		frameInterval = default(int);
	}
}
