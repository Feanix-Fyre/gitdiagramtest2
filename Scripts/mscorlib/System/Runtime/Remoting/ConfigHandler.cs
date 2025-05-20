using System.Collections;
using Mono.Xml;

namespace System.Runtime.Remoting;

internal class ConfigHandler : SmallXmlParser.IContentHandler
{
	private ArrayList typeEntries;

	private ArrayList channelInstances;

	private ChannelData currentChannel;

	private Stack currentProviderData;

	private string currentClientUrl;

	private string appName;

	private string currentXmlPath;

	private bool onlyDelayedChannels;

	public ConfigHandler(bool onlyDelayedChannels)
	{
	}

	private void ValidatePath(string element, params string[] paths)
	{
	}

	private bool CheckPath(string path)
	{
		return false;
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

	public void OnStartElement(string name, SmallXmlParser.IAttrList attrs)
	{
	}

	public void ParseElement(string name, SmallXmlParser.IAttrList attrs)
	{
	}

	public void OnEndElement(string name)
	{
	}

	private void ReadCustomProviderData(string name, SmallXmlParser.IAttrList attrs)
	{
	}

	private void ReadLifetine(SmallXmlParser.IAttrList attrs)
	{
	}

	private TimeSpan ParseTime(string s)
	{
		return default(TimeSpan);
	}

	private void ReadChannel(SmallXmlParser.IAttrList attrs, bool isTemplate)
	{
	}

	private ProviderData ReadProvider(string name, SmallXmlParser.IAttrList attrs, bool isTemplate)
	{
		return null;
	}

	private void ReadClientActivated(SmallXmlParser.IAttrList attrs)
	{
	}

	private void ReadServiceActivated(SmallXmlParser.IAttrList attrs)
	{
	}

	private void ReadClientWellKnown(SmallXmlParser.IAttrList attrs)
	{
	}

	private void ReadServiceWellKnown(SmallXmlParser.IAttrList attrs)
	{
	}

	private void ReadInteropXml(SmallXmlParser.IAttrList attrs, bool isElement)
	{
	}

	private void ReadPreload(SmallXmlParser.IAttrList attrs)
	{
	}

	private string GetNotNull(SmallXmlParser.IAttrList attrs, string name)
	{
		return null;
	}

	private string ExtractAssembly(ref string type)
	{
		return null;
	}

	public void OnChars(string ch)
	{
	}

	public void OnEndParsing(SmallXmlParser parser)
	{
	}
}
