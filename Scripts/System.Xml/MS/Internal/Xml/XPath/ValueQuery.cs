using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal abstract class ValueQuery : Query
{
	public sealed override XPathNavigator Current => null;

	public sealed override int CurrentPosition => 0;

	public sealed override int Count => 0;

	public ValueQuery()
	{
	}

	protected ValueQuery(ValueQuery other)
	{
	}

	public sealed override void Reset()
	{
	}

	public sealed override XPathNavigator Advance()
	{
		return null;
	}
}
