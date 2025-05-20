namespace System.Windows.Forms.RTF;

internal class Font
{
	private string name;

	private int num;

	private int family;

	private CharsetType charset;

	private int pitch;

	private int type;

	private int codepage;

	private Font next;

	private RTF rtf;

	public string Name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int Num
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Family
	{
		set
		{
		}
	}

	public CharsetType Charset
	{
		set
		{
		}
	}

	public int Pitch
	{
		set
		{
		}
	}

	public int Type
	{
		set
		{
		}
	}

	public int Codepage
	{
		set
		{
		}
	}

	public Font(RTF rtf)
	{
	}

	public static bool DeleteFont(RTF rtf, int font_number)
	{
		return false;
	}

	public static Font GetFont(RTF rtf, int font_number)
	{
		return null;
	}

	public static Font GetFont(Font start, int font_number)
	{
		return null;
	}
}
