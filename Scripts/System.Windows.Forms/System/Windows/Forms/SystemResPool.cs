using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace System.Windows.Forms;

internal class SystemResPool
{
	private Hashtable pens;

	private Hashtable dashpens;

	private Hashtable sizedpens;

	private Hashtable solidbrushes;

	private Hashtable hatchbrushes;

	private Hashtable uiImages;

	private Hashtable cpcolors;

	public Pen GetPen(Color color)
	{
		return null;
	}

	public Pen GetDashPen(Color color, DashStyle dashStyle)
	{
		return null;
	}

	public Pen GetSizedPen(Color color, int size)
	{
		return null;
	}

	public SolidBrush GetSolidBrush(Color color)
	{
		return null;
	}

	public HatchBrush GetHatchBrush(HatchStyle hatchStyle, Color foreColor, Color backColor)
	{
		return null;
	}

	public void AddUIImage(Image image, string name, int size)
	{
	}

	public Image GetUIImage(string name, int size)
	{
		return null;
	}

	public CPColor GetCPColor(Color color)
	{
		return default(CPColor);
	}
}
