using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal class Axis : AstNode
{
	public enum AxisType
	{
		Ancestor = 0,
		AncestorOrSelf = 1,
		Attribute = 2,
		Child = 3,
		Descendant = 4,
		DescendantOrSelf = 5,
		Following = 6,
		FollowingSibling = 7,
		Namespace = 8,
		Parent = 9,
		Preceding = 10,
		PrecedingSibling = 11,
		Self = 12,
		None = 13
	}

	private AxisType _axisType;

	private AstNode _input;

	private string _prefix;

	private string _name;

	private XPathNodeType _nodeType;

	protected bool abbrAxis;

	private string _urn;

	public override AstType Type => default(AstType);

	public override XPathResultType ReturnType => default(XPathResultType);

	public AstNode Input
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string Prefix => null;

	public string Name => null;

	public XPathNodeType NodeType => default(XPathNodeType);

	public AxisType TypeOfAxis => default(AxisType);

	public bool AbbrAxis => false;

	public string Urn
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Axis(AxisType axisType, AstNode input, string prefix, string name, XPathNodeType nodetype)
	{
	}

	public Axis(AxisType axisType, AstNode input)
	{
	}
}
