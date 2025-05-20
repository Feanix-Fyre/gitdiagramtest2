using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace System.Diagnostics.Contracts;

/// <summary>Contains static methods for representing program contracts such as preconditions, postconditions, and object invariants.</summary>
public static class Contract
{
	/// <summary>Determines whether all the elements in a collection exist within a function.</summary>
	/// <param name="collection">The collection from which elements of type T will be drawn to pass to <paramref name="predicate" />.</param>
	/// <param name="predicate">The function to evaluate for the existence of all the elements in <paramref name="collection" />.</param>
	/// <typeparam name="T">The type that is contained in <paramref name="collection" />.</typeparam>
	/// <returns>
	///   <see langword="true" /> if and only if <paramref name="predicate" /> returns <see langword="true" /> for all elements of type <paramref name="T" /> in <paramref name="collection" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="collection" /> or <paramref name="predicate" /> is <see langword="null" />.</exception>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public static bool ForAll<T>(IEnumerable<T> collection, Predicate<T> predicate)
	{
		return false;
	}
}
