using System.IO;
using System.Text;

namespace System.Xml;

internal class XmlUtf8RawTextWriter : XmlRawWriter
{
	private readonly bool useAsync;

	protected byte[] bufBytes;

	protected Stream stream;

	protected Encoding encoding;

	protected XmlCharType xmlCharType;

	protected int bufPos;

	protected int textPos;

	protected int contentPos;

	protected int cdataPos;

	protected int attrEndPos;

	protected int bufLen;

	protected bool writeToNull;

	protected bool hadDoubleBracket;

	protected bool inAttributeValue;

	protected NewLineHandling newLineHandling;

	protected bool closeOutput;

	protected bool omitXmlDeclaration;

	protected string newLineChars;

	protected bool checkCharacters;

	protected XmlStandalone standalone;

	protected XmlOutputMethod outputMethod;

	protected bool autoXmlDeclaration;

	protected bool mergeCDataSections;

	internal override bool SupportsNamespaceDeclarationInChunks => false;

	protected XmlUtf8RawTextWriter(XmlWriterSettings settings)
	{
	}

	public XmlUtf8RawTextWriter(Stream stream, XmlWriterSettings settings)
	{
	}

	internal override void WriteXmlDeclaration(XmlStandalone standalone)
	{
	}

	internal override void WriteXmlDeclaration(string xmldecl)
	{
	}

	public override void WriteDocType(string name, string pubid, string sysid, string subset)
	{
	}

	public override void WriteStartElement(string prefix, string localName, string ns)
	{
	}

	internal override void StartElementContent()
	{
	}

	internal override void WriteEndElement(string prefix, string localName, string ns)
	{
	}

	internal override void WriteFullEndElement(string prefix, string localName, string ns)
	{
	}

	public override void WriteStartAttribute(string prefix, string localName, string ns)
	{
	}

	public override void WriteEndAttribute()
	{
	}

	internal override void WriteNamespaceDeclaration(string prefix, string namespaceName)
	{
	}

	internal override void WriteStartNamespaceDeclaration(string prefix)
	{
	}

	internal override void WriteEndNamespaceDeclaration()
	{
	}

	public override void WriteCData(string text)
	{
	}

	public override void WriteComment(string text)
	{
	}

	public override void WriteProcessingInstruction(string name, string text)
	{
	}

	public override void WriteEntityRef(string name)
	{
	}

	public override void WriteCharEntity(char ch)
	{
	}

	public override void WriteWhitespace(string ws)
	{
	}

	public override void WriteString(string text)
	{
	}

	public override void WriteSurrogateCharEntity(char lowChar, char highChar)
	{
	}

	public override void WriteChars(char[] buffer, int index, int count)
	{
	}

	public override void WriteRaw(char[] buffer, int index, int count)
	{
	}

	public override void WriteRaw(string data)
	{
	}

	public override void Close()
	{
	}

	public override void Flush()
	{
	}

	protected virtual void FlushBuffer()
	{
	}

	private void FlushEncoder()
	{
	}

	protected unsafe void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd)
	{
	}

	protected unsafe void WriteElementTextBlock(char* pSrc, char* pSrcEnd)
	{
	}

	protected void RawText(string s)
	{
	}

	protected unsafe void RawText(char* pSrcBegin, char* pSrcEnd)
	{
	}

	protected unsafe void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd)
	{
	}

	protected void WriteCommentOrPi(string text, int stopChar)
	{
	}

	protected void WriteCDataSection(string text)
	{
	}

	private static bool IsSurrogateByte(byte b)
	{
		return false;
	}

	private unsafe static byte* EncodeSurrogate(char* pSrc, char* pSrcEnd, byte* pDst)
	{
		return null;
	}

	private unsafe byte* InvalidXmlChar(int ch, byte* pDst, bool entitize)
	{
		return null;
	}

	internal unsafe void EncodeChar(ref char* pSrc, char* pSrcEnd, ref byte* pDst)
	{
	}

	internal unsafe static byte* EncodeMultibyteUTF8(int ch, byte* pDst)
	{
		return null;
	}

	internal unsafe static void CharToUTF8(ref char* pSrc, char* pSrcEnd, ref byte* pDst)
	{
	}

	protected unsafe byte* WriteNewLine(byte* pDst)
	{
		return null;
	}

	protected unsafe static byte* LtEntity(byte* pDst)
	{
		return null;
	}

	protected unsafe static byte* GtEntity(byte* pDst)
	{
		return null;
	}

	protected unsafe static byte* AmpEntity(byte* pDst)
	{
		return null;
	}

	protected unsafe static byte* QuoteEntity(byte* pDst)
	{
		return null;
	}

	protected unsafe static byte* TabEntity(byte* pDst)
	{
		return null;
	}

	protected unsafe static byte* LineFeedEntity(byte* pDst)
	{
		return null;
	}

	protected unsafe static byte* CarriageReturnEntity(byte* pDst)
	{
		return null;
	}

	private unsafe static byte* CharEntity(byte* pDst, char ch)
	{
		return null;
	}

	protected unsafe static byte* RawStartCData(byte* pDst)
	{
		return null;
	}

	protected unsafe static byte* RawEndCData(byte* pDst)
	{
		return null;
	}

	protected void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace)
	{
	}
}
