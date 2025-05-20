namespace System.ComponentModel.Design;

/// <summary>Provides an interface to retrieve an assembly or type by name.</summary>
public interface ITypeResolutionService
{
	/// <summary>Loads a type with the specified name.</summary>
	/// <param name="name">The name of the type. If the type name is not a fully qualified name that indicates an assembly, this service will search its internal set of referenced assemblies.</param>
	/// <returns>An instance of <see cref="T:System.Type" /> that corresponds to the specified name, or <see langword="null" /> if no type can be found.</returns>
	Type GetType(string name);
}
