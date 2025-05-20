namespace System.Windows.Forms.CarbonInternal;

internal struct HIRect
{
	public CGPoint origin;

	public CGSize size;

	public HIRect(int x, int y, int w, int h)
	{
		origin = default(CGPoint);
		size = default(CGSize);
	}
}
