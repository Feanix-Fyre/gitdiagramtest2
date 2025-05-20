using System.Xml.Linq;

namespace Newtonsoft.Json.Converters;

internal class XTextWrapper : XObjectWrapper
{
	private XText Text => null;

	public override string? Value
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override IXmlNode? ParentNode => null;

	public XTextWrapper(XText text)
		: base(null)
	{
	}
}
