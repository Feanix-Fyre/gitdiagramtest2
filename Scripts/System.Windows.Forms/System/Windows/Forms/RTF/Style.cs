namespace System.Windows.Forms.RTF;

internal class Style
{
	private string name;

	private StyleType type;

	private bool additive;

	private int num;

	private int based_on;

	private int next_par;

	private StyleElement elements;

	private Style next;

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

	public StyleType Type
	{
		set
		{
		}
	}

	public bool Additive
	{
		set
		{
		}
	}

	public int BasedOn
	{
		set
		{
		}
	}

	public StyleElement Elements
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int NextPar
	{
		get
		{
			return 0;
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

	public Style(RTF rtf)
	{
	}
}
