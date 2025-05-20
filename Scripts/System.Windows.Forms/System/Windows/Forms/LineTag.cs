using System.Drawing;

namespace System.Windows.Forms;

internal class LineTag
{
	private Font font;

	private Color color;

	private Color back_color;

	private Font link_font;

	private bool is_link;

	private string link_text;

	private int start;

	private int height;

	private int ascent;

	private int descent;

	private int shift;

	private Line line;

	private LineTag next;

	private LineTag previous;

	public int Ascent => 0;

	public Color BackColor => default(Color);

	public Color ColorToDisplay => default(Color);

	public Color Color
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public int End => 0;

	public Font FontToDisplay => null;

	public Font Font
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int Height
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual bool IsTextTag => false;

	public int Length => 0;

	public Line Line
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public LineTag Next
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public LineTag Previous
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int Shift
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Start
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float Width => 0f;

	public float X => 0f;

	public bool IsLink
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string LinkText
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public LineTag(Line line, int start)
	{
	}

	public LineTag Break(int pos)
	{
		return null;
	}

	public bool Combine(LineTag other)
	{
		return false;
	}

	public void CopyFormattingFrom(LineTag other)
	{
	}

	public virtual void Draw(Graphics dc, Color color, float xoff, float y, int drawStart, int drawEnd, string text, out Rectangle measuredText, bool measureText)
	{
		measuredText = default(Rectangle);
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public static LineTag FindTag(Line line, int pos)
	{
		return null;
	}

	public static bool FormatText(Line line, int formatStart, int length, Font font, Color color, Color backColor, FormatSpecified specified)
	{
		return false;
	}

	public int GetCharIndex(int x)
	{
		return 0;
	}

	public static LineTag GetFinalTag(LineTag tag)
	{
		return null;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	internal virtual int MaxHeight()
	{
		return 0;
	}

	private static void SetFormat(LineTag tag, Font font, Color color, Color back_color, FormatSpecified specified)
	{
	}

	public virtual SizeF SizeOfPosition(Graphics dc, int pos)
	{
		return default(SizeF);
	}

	public virtual string Text()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}
}
