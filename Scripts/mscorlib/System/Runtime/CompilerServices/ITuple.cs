using System.Reflection;

namespace System.Runtime.CompilerServices;

/// <summary>Defines a general-purpose Tuple implementation that allows acccess to Tuple instance members without knowing the underlying Tuple type.</summary>
[DefaultMember("Item")]
public interface ITuple
{
	/// <summary>Gets the number of elements in this <see langword="Tuple" /> instance.</summary>
	/// <returns>The number of elements in this <see langword="Tuple" /> instance.</returns>
	int Length { get; }
}
