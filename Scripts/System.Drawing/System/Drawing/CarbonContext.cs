namespace System.Drawing;

internal struct CarbonContext : IMacContext
{
	public IntPtr port;

	public IntPtr ctx;

	public int width;

	public int height;

	public CarbonContext(IntPtr port, IntPtr ctx, int width, int height)
	{
		this.port = (IntPtr)0;
		this.ctx = (IntPtr)0;
		this.width = 0;
		this.height = 0;
	}

	public void Synchronize()
	{
	}

	public void Release()
	{
	}
}
