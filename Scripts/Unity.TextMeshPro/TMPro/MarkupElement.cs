namespace TMPro;

internal struct MarkupElement
{
	private MarkupAttribute[] m_Attributes;

	public int NameHashCode
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int ValueHashCode
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int ValueStartIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int ValueLength
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public MarkupAttribute[] Attributes
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public MarkupElement(int nameHashCode, int startIndex, int length)
	{
		m_Attributes = null;
	}
}
