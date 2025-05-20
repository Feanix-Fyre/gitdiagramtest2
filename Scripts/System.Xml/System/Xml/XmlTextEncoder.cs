using System.IO;
using System.Text;

namespace System.Xml;

internal class XmlTextEncoder
{
	private TextWriter textWriter;

	private bool inAttribute;

	private char quoteChar;

	private StringBuilder attrValue;

	private bool cacheAttrValue;

	private XmlCharType xmlCharType;

	internal char QuoteChar
	{
		set
		{
		}
	}

	internal string AttributeValue => null;

	internal XmlTextEncoder(TextWriter textWriter)
	{
	}

	internal void StartAttribute(bool cacheAttrValue)
	{
	}

	internal void EndAttribute()
	{
	}

	internal void WriteSurrogateChar(char lowChar, char highChar)
	{
	}

	internal void Write(char[] array, int offset, int count)
	{
	}

	internal void WriteSurrogateCharEntity(char lowChar, char highChar)
	{
	}

	internal void Write(string text)
	{
	}

	internal void WriteRawWithSurrogateChecking(string text)
	{
	}

	internal void WriteRaw(char[] array, int offset, int count)
	{
	}

	internal void WriteCharEntity(char ch)
	{
	}

	internal void WriteEntityRef(string name)
	{
	}

	private void WriteStringFragment(string str, int offset, int count, char[] helperBuffer)
	{
	}

	private void WriteCharEntityImpl(char ch)
	{
	}

	private void WriteCharEntityImpl(string strVal)
	{
	}

	private void WriteEntityRefImpl(string name)
	{
	}
}
