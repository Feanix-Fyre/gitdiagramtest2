namespace UnityEngine.UIElements.UIR;

internal class BasicNode<T> : LinkedPoolItem<BasicNode<T>>
{
	public BasicNode<T> next;

	public T data;

	public void AppendTo(ref BasicNode<T> first)
	{
	}
}
