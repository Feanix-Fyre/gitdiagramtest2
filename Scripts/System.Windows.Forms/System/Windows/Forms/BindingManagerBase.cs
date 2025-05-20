using System.ComponentModel;

namespace System.Windows.Forms;

/// <summary>Manages all <see cref="T:System.Windows.Forms.Binding" /> objects that are bound to the same data source and data member. This class is abstract.</summary>
public abstract class BindingManagerBase
{
	private BindingsCollection bindings;

	internal bool transfering_data;

	/// <summary>Specifies the event handler for the <see cref="E:System.Windows.Forms.BindingManagerBase.CurrentChanged" /> event.</summary>
	protected EventHandler onCurrentChangedHandler;

	/// <summary>Specifies the event handler for the <see cref="E:System.Windows.Forms.BindingManagerBase.PositionChanged" /> event.</summary>
	protected EventHandler onPositionChangedHandler;

	internal EventHandler onCurrentItemChangedHandler;

	/// <summary>Gets the collection of bindings being managed.</summary>
	/// <returns>A <see cref="T:System.Windows.Forms.BindingsCollection" /> that contains the <see cref="T:System.Windows.Forms.Binding" /> objects managed by this <see cref="T:System.Windows.Forms.BindingManagerBase" />.</returns>
	public BindingsCollection Bindings => null;

	/// <summary>When overridden in a derived class, gets the number of rows managed by the <see cref="T:System.Windows.Forms.BindingManagerBase" />.</summary>
	/// <returns>The number of rows managed by the <see cref="T:System.Windows.Forms.BindingManagerBase" />.</returns>
	public abstract int Count { get; }

	/// <summary>When overridden in a derived class, gets the current object.</summary>
	/// <returns>An <see cref="T:System.Object" /> that represents the current object.</returns>
	public abstract object Current { get; }

	/// <summary>When overridden in a derived class, gets or sets the position in the underlying list that controls bound to this data source point to.</summary>
	/// <returns>A zero-based index that specifies a position in the underlying list.</returns>
	public abstract int Position { get; set; }

	internal virtual bool IsSuspended => false;

	/// <summary>Occurs after the value of the <see cref="P:System.Windows.Forms.BindingManagerBase.Position" /> property has changed.</summary>
	public event EventHandler PositionChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.BindingManagerBase" /> class.</summary>
	public BindingManagerBase()
	{
	}

	/// <summary>When overridden in a derived class, ends the current edit.</summary>
	public abstract void EndCurrentEdit();

	/// <summary>When overridden in a derived class, gets the collection of property descriptors for the binding.</summary>
	/// <returns>A <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> that represents the property descriptors for the binding.</returns>
	public virtual PropertyDescriptorCollection GetItemProperties()
	{
		return null;
	}

	internal virtual PropertyDescriptorCollection GetItemPropertiesInternal()
	{
		return null;
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.BindingManagerBase.CurrentChanged" /> event.</summary>
	/// <param name="e">The <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected internal abstract void OnCurrentChanged(EventArgs e);

	/// <summary>Pulls data from the data-bound control into the data source, returning no information.</summary>
	protected void PullData()
	{
	}

	/// <summary>Pushes data from the data source into the data-bound control, returning no information.</summary>
	protected void PushData()
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.BindingManagerBase.CurrentItemChanged" /> event.</summary>
	/// <param name="e">The <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected abstract void OnCurrentItemChanged(EventArgs e);

	/// <summary>When overridden in a derived class, updates the binding.</summary>
	protected abstract void UpdateIsBinding();

	internal void AddBinding(Binding binding)
	{
	}
}
