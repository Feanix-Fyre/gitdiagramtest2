using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal sealed class OperandQuery : ValueQuery
{
	internal object val;

	public override XPathResultType StaticType => default(XPathResultType);

	public OperandQuery(object val)
	{
	}

	public override object Evaluate(XPathNodeIterator nodeIterator)
	{
		return null;
	}

	public override XPathNodeIterator Clone()
	{
		return null;
	}
}
