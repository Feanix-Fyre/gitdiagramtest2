using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace MS.Internal.Xml.XPath;

[DebuggerDisplay("{ToString()}")]
internal abstract class Query : ResetableIterator
{
	public override int Count => 0;

	public abstract XPathResultType StaticType { get; }

	public virtual QueryProps Properties => default(QueryProps);

	public Query()
	{
	}

	protected Query(Query other)
	{
	}

	public override bool MoveNext()
	{
		return false;
	}

	public virtual void SetXsltContext(XsltContext context)
	{
	}

	public abstract object Evaluate(XPathNodeIterator nodeIterator);

	public abstract XPathNavigator Advance();

	public static Query Clone(Query input)
	{
		return null;
	}

	protected static XPathNodeIterator Clone(XPathNodeIterator input)
	{
		return null;
	}

	protected static XPathNavigator Clone(XPathNavigator input)
	{
		return null;
	}

	public static bool Insert(List<XPathNavigator> buffer, XPathNavigator nav)
	{
		return false;
	}

	private static int GetMedian(int l, int r)
	{
		return 0;
	}

	public static XmlNodeOrder CompareNodes(XPathNavigator l, XPathNavigator r)
	{
		return default(XmlNodeOrder);
	}

	protected XPathResultType GetXPathType(object value)
	{
		return default(XPathResultType);
	}
}
