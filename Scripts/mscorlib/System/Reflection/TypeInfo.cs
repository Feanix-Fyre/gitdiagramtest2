using System.Collections.Generic;

namespace System.Reflection;

/// <summary>Represents type declarations for class types, interface types, array types, value types, enumeration types, type parameters, generic type definitions, and open or closed constructed generic types.</summary>
public abstract class TypeInfo : Type, IReflectableType
{
	private const BindingFlags DeclaredOnlyLookup = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;

	/// <summary>Gets a collection of the interfaces implemented by the current type.</summary>
	/// <returns>A collection of the interfaces implemented by the current type.</returns>
	public virtual IEnumerable<Type> ImplementedInterfaces => null;

	/// <summary>Returns a representation of the current type as a <see cref="T:System.Reflection.TypeInfo" /> object.</summary>
	/// <returns>A reference to the current type.</returns>
	TypeInfo IReflectableType.GetTypeInfo()
	{
		return null;
	}
}
