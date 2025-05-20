namespace UnityEngine.Rendering;

public static class FSRUtils
{
	private static class ShaderConstants
	{
		public static readonly int _FsrEasuConstants0;

		public static readonly int _FsrEasuConstants1;

		public static readonly int _FsrEasuConstants2;

		public static readonly int _FsrEasuConstants3;

		public static readonly int _FsrRcasConstants;
	}

	internal const float kMaxSharpnessStops = 2.5f;

	public const float kDefaultSharpnessStops = 0.2f;

	public const float kDefaultSharpnessLinear = 0.92f;

	public static void SetEasuConstants(CommandBuffer cmd, Vector2 inputViewportSizeInPixels, Vector2 inputImageSizeInPixels, Vector2 outputImageSizeInPixels)
	{
	}

	public static void SetRcasConstants(CommandBuffer cmd, float sharpnessStops = 0.2f)
	{
	}

	public static void SetRcasConstantsLinear(CommandBuffer cmd, float sharpnessLinear = 0.92f)
	{
	}

	public static bool IsSupported()
	{
		return false;
	}
}
