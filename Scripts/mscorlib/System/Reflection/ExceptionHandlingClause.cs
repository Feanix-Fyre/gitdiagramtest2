using System.Runtime.InteropServices;

namespace System.Reflection;

/// <summary>Represents a clause in a structured exception-handling block.</summary>
[StructLayout((LayoutKind)0)]
[ComVisible(true)]
public class ExceptionHandlingClause
{
	internal Type catch_type;

	internal int filter_offset;

	internal ExceptionHandlingClauseOptions flags;

	internal int try_offset;

	internal int try_length;

	internal int handler_offset;

	internal int handler_length;

	/// <summary>Initializes a new instance of the <see cref="T:System.Reflection.ExceptionHandlingClause" /> class.</summary>
	protected ExceptionHandlingClause()
	{
	}

	/// <summary>A string representation of the exception-handling clause.</summary>
	/// <returns>A string that lists appropriate property values for the filter clause type.</returns>
	public override string ToString()
	{
		return null;
	}
}
