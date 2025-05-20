using System.Xml.XPath;
using MS.Internal.Xml.XPath;

namespace System.Xml.Schema;

internal class DoubleLinkAxis : Axis
{
	internal Axis next;

	internal Axis Next
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal DoubleLinkAxis(Axis axis, DoubleLinkAxis inputaxis)
		: base(default(AxisType), null, null, null, default(XPathNodeType))
	{
	}

	internal static DoubleLinkAxis ConvertTree(Axis axis)
	{
		return null;
	}
}
