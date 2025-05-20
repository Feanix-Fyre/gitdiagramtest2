using System.Diagnostics;

namespace TMPro;

[DebuggerDisplay("{DebuggerDisplay()}")]
internal struct TextProcessingElement
{
	private TextProcessingElementType m_ElementType;

	private int m_StartIndex;

	private int m_Length;

	private CharacterElement m_CharacterElement;

	private MarkupElement m_MarkupElement;

	public TextProcessingElementType ElementType
	{
		get
		{
			return default(TextProcessingElementType);
		}
		set
		{
		}
	}

	public int StartIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Length
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public CharacterElement CharacterElement => default(CharacterElement);

	public MarkupElement MarkupElement
	{
		get
		{
			return default(MarkupElement);
		}
		set
		{
		}
	}

	public static TextProcessingElement Undefined => default(TextProcessingElement);

	public TextProcessingElement(TextProcessingElementType elementType, int startIndex, int length)
	{
		m_ElementType = default(TextProcessingElementType);
		m_StartIndex = 0;
		m_Length = 0;
		m_CharacterElement = default(CharacterElement);
		m_MarkupElement = default(MarkupElement);
	}

	public TextProcessingElement(TMP_TextElement textElement, int startIndex, int length)
	{
		m_ElementType = default(TextProcessingElementType);
		m_StartIndex = 0;
		m_Length = 0;
		m_CharacterElement = default(CharacterElement);
		m_MarkupElement = default(MarkupElement);
	}

	public TextProcessingElement(CharacterElement characterElement, int startIndex, int length)
	{
		m_ElementType = default(TextProcessingElementType);
		m_StartIndex = 0;
		m_Length = 0;
		m_CharacterElement = default(CharacterElement);
		m_MarkupElement = default(MarkupElement);
	}

	public TextProcessingElement(MarkupElement markupElement)
	{
		m_ElementType = default(TextProcessingElementType);
		m_StartIndex = 0;
		m_Length = 0;
		m_CharacterElement = default(CharacterElement);
		m_MarkupElement = default(MarkupElement);
	}

	private string DebuggerDisplay()
	{
		return null;
	}
}
