using System.ComponentModel;
using System.Drawing.Design;
using System.Reflection;

namespace System.Windows.Forms;

/// <summary>Represents the collection of data bindings for a control.</summary>
[Editor("System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
[TypeConverter("System.Windows.Forms.Design.ControlBindingsConverter, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[DefaultMember("Item")]
[DefaultEvent("CollectionChanged")]
public class ControlBindingsCollection : BindingsCollection
{
	private IBindableComponent bindable_component;

	private DataSourceUpdateMode default_datasource_update_mode;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.ControlBindingsCollection" /> class with the specified bindable control.</summary>
	/// <param name="control">The <see cref="T:System.Windows.Forms.IBindableComponent" /> the binding collection belongs to.</param>
	public ControlBindingsCollection(IBindableComponent control)
	{
	}

	/// <summary>Adds a binding to the collection.</summary>
	/// <param name="dataBinding">The <see cref="T:System.Windows.Forms.Binding" /> to add.</param>
	protected override void AddCore(Binding dataBinding)
	{
	}
}
