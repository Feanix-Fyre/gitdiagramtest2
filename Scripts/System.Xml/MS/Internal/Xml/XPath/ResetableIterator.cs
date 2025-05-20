using System.Xml.XPath;

namespace MS.Internal.Xml.XPath;

internal abstract class ResetableIterator : XPathNodeIterator
{
	public abstract override int CurrentPosition { get; }

	public ResetableIterator()
	{
	}

	protected ResetableIterator(ResetableIterator other)
	{
	}

	protected void ResetCount()
	{
	}

	public abstract void Reset();
}
