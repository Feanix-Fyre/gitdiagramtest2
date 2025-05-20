namespace System.Runtime.CompilerServices;

/// <summary>Indicates that the use of a value tuple on a member is meant to be treated as a tuple with element names.</summary>
[CLSCompliant(false)]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
public sealed class TupleElementNamesAttribute : Attribute
{
	private readonly string[] _transformNames;

	/// <summary>Initializes a new instance of the <see cref="T:System.Runtime.CompilerServices.TupleElementNamesAttribute" /> class.</summary>
	/// <param name="transformNames">A string array that specifies, in a pre-order depth-first traversal of a type's construction, which value tuple occurrences are meant to carry element names.</param>
	public TupleElementNamesAttribute(string[] transformNames)
	{
	}
}
