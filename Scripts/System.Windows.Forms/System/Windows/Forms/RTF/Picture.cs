using System.Drawing;
using System.IO;

namespace System.Windows.Forms.RTF;

internal class Picture
{
	private Minor image_type;

	private Image image;

	private MemoryStream data;

	private float width;

	private float height;

	private static readonly float dpix;

	public Minor ImageType
	{
		get
		{
			return default(Minor);
		}
		set
		{
		}
	}

	public MemoryStream Data => null;

	public float Width => 0f;

	public float Height => 0f;

	public SizeF Size => default(SizeF);

	static Picture()
	{
	}

	public void SetWidthFromTwips(int twips)
	{
	}

	public void SetHeightFromTwips(int twips)
	{
	}

	public bool IsValid()
	{
		return false;
	}

	public Image ToImage()
	{
		return null;
	}
}
