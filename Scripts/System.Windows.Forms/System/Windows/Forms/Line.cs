using System.Drawing;
using System.Text;

namespace System.Windows.Forms;

internal class Line : ICloneable, IComparable
{
	internal Document document;

	internal StringBuilder text;

	internal float[] widths;

	internal int space;

	internal int line_no;

	internal LineTag tags;

	internal int offset;

	internal int height;

	internal int ascent;

	internal HorizontalAlignment alignment;

	internal int align_shift;

	internal int indent;

	internal int hanging_indent;

	internal int right_indent;

	internal LineEnding ending;

	internal Line parent;

	internal Line left;

	internal Line right;

	internal LineColor color;

	private static int DEFAULT_TEXT_LEN;

	internal bool recalc;

	internal HorizontalAlignment Alignment
	{
		set
		{
		}
	}

	internal int Height => 0;

	internal int LineNo => 0;

	internal int Width => 0;

	internal string Text
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal int X => 0;

	internal int Y => 0;

	internal Line(Document document, LineEnding ending)
	{
	}

	internal Line(Document document, int LineNo, string Text, HorizontalAlignment align, Font font, Color color, LineEnding ending)
	{
	}

	internal void LinkRecord(StringBuilder linkRecord)
	{
	}

	internal void ClearLinks()
	{
	}

	public void DeleteCharacters(int pos, int count)
	{
	}

	internal void DrawEnding(Graphics dc, float y)
	{
	}

	internal LineTag FindTag(int pos)
	{
		return null;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public LineTag GetTag(int x)
	{
		return null;
	}

	internal void Grow(int minimum)
	{
	}

	public void InsertString(int pos, string s)
	{
	}

	public void InsertString(int pos, string s, LineTag tag)
	{
	}

	internal bool RecalculateLine(Graphics g, Document doc)
	{
		return false;
	}

	internal bool RecalculatePasswordLine(Graphics g, Document doc)
	{
		return false;
	}

	internal void Streamline(int lines)
	{
	}

	internal int TextLengthWithoutEnding()
	{
		return 0;
	}

	internal string TextWithoutEnding()
	{
		return null;
	}

	public object Clone()
	{
		return null;
	}

	public int CompareTo(object obj)
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}
}
