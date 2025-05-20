using System.Collections;
using System.IO;
using System.Text;

namespace System.Windows.Forms.RTF;

internal class RTF
{
	private TokenClass rtf_class;

	private Major major;

	private Minor minor;

	private int param;

	private string encoded_text;

	private Encoding encoding;

	private int encoding_code_page;

	private StringBuilder text_buffer;

	private Picture picture;

	private int line_num;

	private int line_pos;

	private char pushed_char;

	private TokenClass pushed_class;

	private Major pushed_major;

	private Minor pushed_minor;

	private int pushed_param;

	private char prev_char;

	private bool bump_line;

	private Font font_list;

	private Charset cur_charset;

	private Stack charset_stack;

	private Style styles;

	private Color colors;

	private Font fonts;

	private StreamReader source;

	private static Hashtable key_table;

	private static KeyStruct[] Keys;

	private DestinationCallback destination_callbacks;

	private ClassCallback class_callbacks;

	public TokenClass TokenClass => default(TokenClass);

	public Major Major => default(Major);

	public Minor Minor => default(Minor);

	public int Param => 0;

	public string Text => null;

	public string EncodedText => null;

	public Picture Picture
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Color Colors
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Style Styles
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Font Fonts
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ClassCallback ClassCallback => null;

	public int LineNumber => 0;

	public int LinePos => 0;

	public RTF(Stream stream)
	{
	}

	static RTF()
	{
	}

	public void DefaultFont(string name)
	{
	}

	private char GetChar()
	{
		return '\0';
	}

	private char GetChar(bool skipCrLf)
	{
		return '\0';
	}

	public void Read()
	{
	}

	public void RouteToken()
	{
	}

	public void SkipGroup()
	{
	}

	public TokenClass GetToken()
	{
		return default(TokenClass);
	}

	private void GetToken2()
	{
	}

	public void SetToken(TokenClass cl, Major maj, Minor min, int par, string text)
	{
	}

	public void UngetToken()
	{
	}

	public void Lookup(string token)
	{
	}

	public bool CheckCM(TokenClass rtf_class, Major major)
	{
		return false;
	}

	public bool CheckCMM(TokenClass rtf_class, Major major, Minor minor)
	{
		return false;
	}

	public bool CheckMM(Major major, Minor minor)
	{
		return false;
	}

	private void HandleOptDest(RTF rtf)
	{
	}

	private void ReadFontTbl(RTF rtf)
	{
	}

	private void ReadColorTbl(RTF rtf)
	{
	}

	private void ReadStyleSheet(RTF rtf)
	{
	}

	private void ReadInfoGroup(RTF rtf)
	{
	}

	private void ReadPictGroup(RTF rtf)
	{
	}

	private void ReadObjGroup(RTF rtf)
	{
	}
}
