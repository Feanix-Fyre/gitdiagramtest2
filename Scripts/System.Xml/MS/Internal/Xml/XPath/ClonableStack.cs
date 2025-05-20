using System.Collections.Generic;

namespace MS.Internal.Xml.XPath;

internal sealed class ClonableStack<T> : List<T>
{
	public ClonableStack()
	{
	}

	private ClonableStack(IEnumerable<T> collection)
	{
	}

	public void Push(T value)
	{
	}

	public T Pop()
	{
		return default(T);
	}

	public T Peek()
	{
		return default(T);
	}

	public ClonableStack<T> Clone()
	{
		return null;
	}
}
