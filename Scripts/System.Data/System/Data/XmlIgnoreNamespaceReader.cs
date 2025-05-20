using System.Collections.Generic;
using System.Xml;

namespace System.Data;

internal sealed class XmlIgnoreNamespaceReader : XmlNodeReader
{
	private List<string> _namespacesToIgnore;

	internal XmlIgnoreNamespaceReader(XmlDocument xdoc, string[] namespacesToIgnore)
		: base(null)
	{
	}

	public override bool MoveToFirstAttribute()
	{
		return false;
	}

	public override bool MoveToNextAttribute()
	{
		return false;
	}
}
