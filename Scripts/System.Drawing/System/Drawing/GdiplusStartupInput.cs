namespace System.Drawing;

internal struct GdiplusStartupInput
{
	internal uint GdiplusVersion;

	internal IntPtr DebugEventCallback;

	internal int SuppressBackgroundThread;

	internal int SuppressExternalCodecs;

	internal static GdiplusStartupInput MakeGdiplusStartupInput()
	{
		return default(GdiplusStartupInput);
	}
}
