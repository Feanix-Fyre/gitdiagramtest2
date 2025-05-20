using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal sealed class AbsoluteQuery : ContextQuery
{
	public AbsoluteQuery()
	{
	}

	private AbsoluteQuery(AbsoluteQuery other)
	{
	}

	public override object Evaluate(XPathNodeIterator context)
	{
		return null;
	}

	public override XPathNodeIterator Clone()
	{
		return null;
	}
}
