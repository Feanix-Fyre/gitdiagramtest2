using System.Runtime.ConstrainedExecution;

namespace System.Runtime.CompilerServices;

/// <summary>Provides a set of static methods and properties that provide support for compilers. This class cannot be inherited.</summary>
public static class RuntimeHelpers
{
	/// <summary>Gets the offset, in bytes, to the data in the given string.</summary>
	/// <returns>The byte offset, from the start of the <see cref="T:System.String" /> object to the first character in the string.</returns>
	public static int OffsetToStringData => 0;

	private static void InitializeArray(Array array, IntPtr fldHandle)
	{
	}

	/// <summary>Provides a fast way to initialize an array from data that is stored in a module.</summary>
	/// <param name="array">The array to be initialized.</param>
	/// <param name="fldHandle">A field handle that specifies the location of the data used to initialize the array.</param>
	public static void InitializeArray(Array array, RuntimeFieldHandle fldHandle)
	{
	}

	/// <summary>Serves as a hash function for a particular object, and is suitable for use in algorithms and data structures that use hash codes, such as a hash table.</summary>
	/// <param name="o">An object to retrieve the hash code for.</param>
	/// <returns>A hash code for the object identified by the <paramref name="o" /> parameter.</returns>
	public static int GetHashCode(object o)
	{
		return 0;
	}

	/// <summary>Boxes a value type.</summary>
	/// <param name="obj">The value type to be boxed.</param>
	/// <returns>A boxed copy of <paramref name="obj" /> if it is a value class; otherwise, <paramref name="obj" /> itself.</returns>
	public static object GetObjectValue(object obj)
	{
		return null;
	}

	private static void RunClassConstructor(IntPtr type)
	{
	}

	/// <summary>Runs a specified class constructor method.</summary>
	/// <param name="type">A type handle that specifies the class constructor method to run.</param>
	/// <exception cref="T:System.TypeInitializationException">The class initializer throws an exception.</exception>
	public static void RunClassConstructor(RuntimeTypeHandle type)
	{
	}

	private static bool SufficientExecutionStack()
	{
		return false;
	}

	public static bool TryEnsureSufficientExecutionStack()
	{
		return false;
	}

	/// <summary>Designates a body of code as a constrained execution region (CER).</summary>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public static void PrepareConstrainedRegions()
	{
	}

	public static bool IsReferenceOrContainsReferences<T>()
	{
		return false;
	}
}
