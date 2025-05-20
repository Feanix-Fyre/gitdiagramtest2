using System.Drawing;
using System.Windows.Forms.RTF;

namespace System.Windows.Forms;

internal class PictureTag : LineTag
{
	internal Picture picture;

	public override bool IsTextTag => false;

	internal PictureTag(Line line, int start, Picture picture)
		: base(null, 0)
	{
	}

	public override SizeF SizeOfPosition(Graphics dc, int pos)
	{
		return default(SizeF);
	}

	internal override int MaxHeight()
	{
		return 0;
	}

	public override string Text()
	{
		return null;
	}
}
