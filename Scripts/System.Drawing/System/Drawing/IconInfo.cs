namespace System.Drawing;

internal struct IconInfo
{
	private int fIcon;

	public int xHotspot;

	public int yHotspot;

	public IntPtr hbmMask;

	public IntPtr hbmColor;

	public bool IsIcon
	{
		get
		{
			return false;
		}
		set
		{
		}
	}
}
