using System.Collections;
using System.ComponentModel;

namespace System.Windows.Forms;

/// <summary>Represents a collection of <see cref="T:System.Windows.Forms.Binding" /> objects for a control.</summary>
[DefaultEvent("CollectionChanged")]
public class BindingsCollection : BaseCollection
{
	private CollectionChangeEventHandler CollectionChanged;

	private CollectionChangeEventHandler CollectionChanging;

	/// <summary>Gets the total number of bindings in the collection.</summary>
	/// <returns>The total number of bindings in the collection.</returns>
	public override int Count => 0;

	/// <summary>Gets the <see cref="T:System.Windows.Forms.Binding" /> at the specified index.</summary>
	/// <param name="index">The index of the <see cref="T:System.Windows.Forms.Binding" /> to find.</param>
	/// <returns>The <see cref="T:System.Windows.Forms.Binding" /> at the specified index.</returns>
	/// <exception cref="T:System.IndexOutOfRangeException">The collection doesn't contain an item at the specified index.</exception>
	public Binding this[int index] => null;

	/// <summary>Gets the bindings in the collection as an object.</summary>
	/// <returns>An <see cref="T:System.Collections.ArrayList" /> containing all of the collection members.</returns>
	protected override ArrayList List => null;

	internal BindingsCollection()
	{
	}

	/// <summary>Adds the specified binding to the collection.</summary>
	/// <param name="binding">The <see cref="T:System.Windows.Forms.Binding" /> to add to the collection.</param>
	protected internal void Add(Binding binding)
	{
	}

	/// <summary>Adds a <see cref="T:System.Windows.Forms.Binding" /> to the collection.</summary>
	/// <param name="dataBinding">The <see cref="T:System.Windows.Forms.Binding" /> to add to the collection.</param>
	/// <exception cref="T:System.ArgumentNullException">The <paramref name="dataBinding" /> argument was <see langword="null" />.</exception>
	protected virtual void AddCore(Binding dataBinding)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.BindingsCollection.CollectionChanged" /> event.</summary>
	/// <param name="ccevent">A <see cref="T:System.ComponentModel.CollectionChangeEventArgs" /> that contains the event data.</param>
	protected virtual void OnCollectionChanged(CollectionChangeEventArgs ccevent)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.BindingsCollection.CollectionChanging" /> event.</summary>
	/// <param name="e">A <see cref="T:System.ComponentModel.CollectionChangeEventArgs" /> that contains event data.</param>
	protected virtual void OnCollectionChanging(CollectionChangeEventArgs e)
	{
	}

	internal bool Contains(Binding binding)
	{
		return false;
	}
}
