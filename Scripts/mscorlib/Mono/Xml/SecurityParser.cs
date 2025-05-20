using System.Collections;
using System.Security;

namespace Mono.Xml;

internal class SecurityParser : SmallXmlParser, SmallXmlParser.IContentHandler
{
	private SecurityElement root;

	private SecurityElement current;

	private Stack stack;

	public void LoadXml(string xml)
	{
	}

	public SecurityElement ToXml()
	{
		return null;
	}

	public void OnStartParsing(SmallXmlParser parser)
	{
	}

	public void OnProcessingInstruction(string name, string text)
	{
	}

	public void OnIgnorableWhitespace(string s)
	{
	}

	public void OnStartElement(string name, IAttrList attrs)
	{
	}

	public void OnEndElement(string name)
	{
	}

	public void OnChars(string ch)
	{
	}

	public void OnEndParsing(SmallXmlParser parser)
	{
	}
}
