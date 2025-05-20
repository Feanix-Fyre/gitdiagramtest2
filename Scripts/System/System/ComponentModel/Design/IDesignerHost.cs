namespace System.ComponentModel.Design;

/// <summary>Provides an interface for managing designer transactions and components.</summary>
public interface IDesignerHost : IServiceProvider
{
	/// <summary>Gets the instance of the base class used as the root component for the current design.</summary>
	/// <returns>The instance of the root component class.</returns>
	IComponent RootComponent { get; }

	/// <summary>Gets the designer instance that contains the specified component.</summary>
	/// <param name="component">The <see cref="T:System.ComponentModel.IComponent" /> to retrieve the designer for.</param>
	/// <returns>An <see cref="T:System.ComponentModel.Design.IDesigner" />, or <see langword="null" /> if there is no designer for the specified component.</returns>
	IDesigner GetDesigner(IComponent component);
}
