using System.ComponentModel;

namespace System.Windows.Forms;

/// <summary>Enables a non-control component to emulate the data-binding behavior of a Windows Forms control.</summary>
public interface IBindableComponent : IDisposable, IComponent
{
	/// <summary>Gets or sets the collection of currency managers for the <see cref="T:System.Windows.Forms.IBindableComponent" />.</summary>
	/// <returns>The collection of <see cref="T:System.Windows.Forms.BindingManagerBase" /> objects for this <see cref="T:System.Windows.Forms.IBindableComponent" />.</returns>
	BindingContext BindingContext { get; }
}
