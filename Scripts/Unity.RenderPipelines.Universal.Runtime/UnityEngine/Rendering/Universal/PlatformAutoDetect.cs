namespace UnityEngine.Rendering.Universal;

internal static class PlatformAutoDetect
{
	internal static bool isXRMobile { get; private set; }

	internal static bool isShaderAPIMobileDefined { get; private set; }

	internal static bool isSwitch { get; private set; }

	internal static void Initialize()
	{
	}

	internal static ShEvalMode ShAutoDetect(ShEvalMode mode)
	{
		return default(ShEvalMode);
	}
}
