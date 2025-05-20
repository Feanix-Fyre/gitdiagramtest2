namespace System.ComponentModel;

/// <summary>Provides data for the <see cref="E:System.Data.DataColumnCollection.CollectionChanged" /> event.</summary>
public class CollectionChangeEventArgs : EventArgs
{
	/// <summary>Gets an action that specifies how the collection changed.</summary>
	/// <returns>One of the <see cref="T:System.ComponentModel.CollectionChangeAction" /> values.</returns>
	public virtual CollectionChangeAction Action { get; }

	/// <summary>Gets the instance of the collection with the change.</summary>
	/// <returns>An <see cref="T:System.Object" /> that represents the instance of the collection with the change, or <see langword="null" /> if you refresh the collection.</returns>
	public virtual object Element { get; }

	/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.CollectionChangeEventArgs" /> class.</summary>
	/// <param name="action">One of the <see cref="T:System.ComponentModel.CollectionChangeAction" /> values that specifies how the collection changed.</param>
	/// <param name="element">An <see cref="T:System.Object" /> that specifies the instance of the collection where the change occurred.</param>
	public CollectionChangeEventArgs(CollectionChangeAction action, object element)
	{
	}
}
