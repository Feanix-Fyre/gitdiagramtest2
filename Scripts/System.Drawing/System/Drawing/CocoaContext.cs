namespace System.Drawing;

internal class CocoaContext : IMacContext
{
	public IntPtr focusHandle;

	public IntPtr ctx;

	public int width;

	public int height;

	public CocoaContext(IntPtr focusHandle, IntPtr ctx, int width, int height)
	{
	}

	public void Synchronize()
	{
	}

	public void Release()
	{
	}
}
