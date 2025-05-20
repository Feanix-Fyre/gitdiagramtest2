using System.ComponentModel;

namespace System.Windows.Forms;

/// <summary>Maintains a <see cref="T:System.Windows.Forms.Binding" /> between an object's property and a data-bound control property.</summary>
public class PropertyManager : BindingManagerBase
{
	internal string property_name;

	private PropertyDescriptor prop_desc;

	private object data_source;

	private EventDescriptor changed_event;

	private EventHandler property_value_changed_handler;

	/// <summary>Gets the object to which the data-bound property belongs.</summary>
	/// <returns>An <see cref="T:System.Object" /> that represents the object to which the property belongs.</returns>
	public override object Current => null;

	/// <summary>When overridden in a derived class, gets or sets the position in the underlying list that controls bound to this data source point to.</summary>
	/// <returns>A zero-based index that specifies a position in the underlying list.</returns>
	public override int Position
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	/// <summary>When overridden in a derived class, gets the number of rows managed by the <see cref="T:System.Windows.Forms.BindingManagerBase" />.</summary>
	/// <returns>The number of rows managed by the <see cref="T:System.Windows.Forms.BindingManagerBase" />.</returns>
	public override int Count => 0;

	internal override bool IsSuspended => false;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.PropertyManager" /> class.</summary>
	public PropertyManager()
	{
	}

	internal PropertyManager(object data_source)
	{
	}

	internal void SetDataSource(object new_data_source)
	{
	}

	private void PropertyValueChanged(object sender, EventArgs args)
	{
	}

	/// <summary>When overridden in a derived class, ends the current edit.</summary>
	public override void EndCurrentEdit()
	{
	}

	internal override PropertyDescriptorCollection GetItemPropertiesInternal()
	{
		return null;
	}

	/// <summary>Updates the current <see cref="T:System.Windows.Forms.Binding" /> between a data binding and a data-bound property.</summary>
	[System.MonoTODO("Stub, does nothing")]
	protected override void UpdateIsBinding()
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.BindingManagerBase.CurrentChanged" /> event.</summary>
	/// <param name="ea">The <see cref="T:System.EventArgs" /> that contains the event data.</param>
	protected internal override void OnCurrentChanged(EventArgs ea)
	{
	}

	/// <summary>Raises the <see cref="E:System.Windows.Forms.BindingManagerBase.CurrentItemChanged" /> event.</summary>
	/// <param name="ea">An <see cref="T:System.EventArgs" /> containing the event data.</param>
	protected override void OnCurrentItemChanged(EventArgs ea)
	{
	}
}
