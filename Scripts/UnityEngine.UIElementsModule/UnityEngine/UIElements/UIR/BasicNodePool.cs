using System;

namespace UnityEngine.UIElements.UIR;

internal class BasicNodePool<T> : LinkedPool<BasicNode<T>>
{
	private static void Reset(BasicNode<T> node)
	{
	}

	private static BasicNode<T> Create()
	{
		return null;
	}

	public BasicNodePool()
		: base((Func<BasicNode<T>>)null, (Action<BasicNode<T>>)null, 0)
	{
	}
}
