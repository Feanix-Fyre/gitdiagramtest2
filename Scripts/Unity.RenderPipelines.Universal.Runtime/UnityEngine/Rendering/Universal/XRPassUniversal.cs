using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal;

internal class XRPassUniversal : XRPass
{
	internal bool isLateLatchEnabled { get; set; }

	internal bool canMarkLateLatch { get; set; }

	internal bool hasMarkedLateLatch { get; set; }

	public static XRPass Create(XRPassCreateInfo createInfo)
	{
		return null;
	}

	public override void Release()
	{
	}
}
