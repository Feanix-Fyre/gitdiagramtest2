namespace System.Collections.Generic;

/// <summary>Represents a node in a <see cref="T:System.Collections.Generic.LinkedList`1" />. This class cannot be inherited.</summary>
/// <typeparam name="T">Specifies the element type of the linked list.</typeparam>
public sealed class LinkedListNode<T>
{
	internal LinkedList<T> list;

	internal LinkedListNode<T> next;

	internal LinkedListNode<T> prev;

	internal T item;

	/// <summary>Gets the next node in the <see cref="T:System.Collections.Generic.LinkedList`1" />.</summary>
	/// <returns>A reference to the next node in the <see cref="T:System.Collections.Generic.LinkedList`1" />, or <see langword="null" /> if the current node is the last element (<see cref="P:System.Collections.Generic.LinkedList`1.Last" />) of the <see cref="T:System.Collections.Generic.LinkedList`1" />.</returns>
	public LinkedListNode<T> Next => null;

	/// <summary>Gets the value contained in the node.</summary>
	/// <returns>The value contained in the node.</returns>
	public T Value => default(T);

	internal LinkedListNode(LinkedList<T> list, T value)
	{
	}

	internal void Invalidate()
	{
	}
}
