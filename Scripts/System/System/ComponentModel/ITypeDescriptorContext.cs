namespace System.ComponentModel;

/// <summary>Provides contextual information about a component, such as its container and property descriptor.</summary>
public interface ITypeDescriptorContext : IServiceProvider
{
	/// <summary>Gets the container representing this <see cref="T:System.ComponentModel.TypeDescriptor" /> request.</summary>
	/// <returns>An <see cref="T:System.ComponentModel.IContainer" /> with the set of objects for this <see cref="T:System.ComponentModel.TypeDescriptor" />; otherwise, <see langword="null" /> if there is no container or if the <see cref="T:System.ComponentModel.TypeDescriptor" /> does not use outside objects.</returns>
	IContainer Container { get; }

	/// <summary>Gets the object that is connected with this type descriptor request.</summary>
	/// <returns>The object that invokes the method on the <see cref="T:System.ComponentModel.TypeDescriptor" />; otherwise, <see langword="null" /> if there is no object responsible for the call.</returns>
	object Instance { get; }

	/// <summary>Gets the <see cref="T:System.ComponentModel.PropertyDescriptor" /> that is associated with the given context item.</summary>
	/// <returns>The <see cref="T:System.ComponentModel.PropertyDescriptor" /> that describes the given context item; otherwise, <see langword="null" /> if there is no <see cref="T:System.ComponentModel.PropertyDescriptor" /> responsible for the call.</returns>
	PropertyDescriptor PropertyDescriptor { get; }
}
