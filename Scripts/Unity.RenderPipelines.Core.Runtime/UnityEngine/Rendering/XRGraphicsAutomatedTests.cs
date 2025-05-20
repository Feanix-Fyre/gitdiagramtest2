using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering;

public static class XRGraphicsAutomatedTests
{
	public static bool running;

	private static bool activatedFromCommandLine => false;

	public static bool enabled { get; }

	internal static void OverrideLayout(XRLayout layout, Camera camera)
	{
	}
}
