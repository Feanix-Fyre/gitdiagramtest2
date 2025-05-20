using System.Xml.XPath;
using System.Xml.Xsl;

namespace MS.Internal.Xml.XPath;

internal abstract class BaseAxisQuery : Query
{
	internal Query qyInput;

	private bool _nameTest;

	private string _name;

	private string _prefix;

	private string _nsUri;

	private XPathNodeType _typeTest;

	protected XPathNavigator currentNode;

	protected int position;

	protected string Name => null;

	protected string Namespace => null;

	protected bool NameTest => false;

	protected XPathNodeType TypeTest => default(XPathNodeType);

	public override int CurrentPosition => 0;

	public override XPathNavigator Current => null;

	public override XPathResultType StaticType => default(XPathResultType);

	protected BaseAxisQuery(Query qyInput)
	{
	}

	protected BaseAxisQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest)
	{
	}

	protected BaseAxisQuery(BaseAxisQuery other)
	{
	}

	public override void Reset()
	{
	}

	public override void SetXsltContext(XsltContext context)
	{
	}

	public virtual bool matches(XPathNavigator e)
	{
		return false;
	}

	public override object Evaluate(XPathNodeIterator nodeIterator)
	{
		return null;
	}
}
