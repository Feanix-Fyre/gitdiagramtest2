using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.U2D;

[MovedFrom("UnityEngine.Experimental.U2D")]
[NativeHeader("Runtime/2D/Common/PixelSnapping.h")]
public static class PixelPerfectRendering
{
	public static float pixelSnapSpacing
	{
		[FreeFunction("SetPixelSnapSpacing")]
		set
		{
		}
	}
}
