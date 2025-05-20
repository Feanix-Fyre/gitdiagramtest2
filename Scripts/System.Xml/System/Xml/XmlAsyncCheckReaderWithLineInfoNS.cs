using System.Collections.Generic;

namespace System.Xml;

internal class XmlAsyncCheckReaderWithLineInfoNS : XmlAsyncCheckReaderWithLineInfo, IXmlNamespaceResolver
{
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver;

	public XmlAsyncCheckReaderWithLineInfoNS(XmlReader reader)
		: base(null)
	{
	}

	IDictionary<string, string> IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope)
	{
		return null;
	}

	string IXmlNamespaceResolver.LookupNamespace(string prefix)
	{
		return null;
	}

	string IXmlNamespaceResolver.LookupPrefix(string namespaceName)
	{
		return null;
	}
}
