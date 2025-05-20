using System.Runtime.CompilerServices;

namespace System.Threading;

/// <summary>Contains methods for performing volatile memory operations.</summary>
public static class Volatile
{
	private struct VolatileBoolean
	{
		public bool Value;
	}

	private struct VolatileInt32
	{
		public int Value;
	}

	private struct VolatileObject
	{
		public object Value;
	}

	/// <summary>Reads the value of the specified field. On systems that require it, inserts a memory barrier that prevents the processor from reordering memory operations as follows: If a read or write appears after this method in the code, the processor cannot move it before this method.</summary>
	/// <param name="location">The field to read.</param>
	/// <returns>The value that was read. This value is the latest written by any processor in the computer, regardless of the number of processors or the state of processor cache.</returns>
	[Intrinsic]
	public static bool Read(ref bool location)
	{
		return false;
	}

	/// <summary>Writes the specified value to the specified field. On systems that require it, inserts a memory barrier that prevents the processor from reordering memory operations as follows: If a read or write appears before this method in the code, the processor cannot move it after this method.</summary>
	/// <param name="location">The field where the value is written.</param>
	/// <param name="value">The value to write. The value is written immediately so that it is visible to all processors in the computer.</param>
	[Intrinsic]
	public static void Write(ref bool location, bool value)
	{
	}

	/// <summary>Reads the value of the specified field. On systems that require it, inserts a memory barrier that prevents the processor from reordering memory operations as follows: If a read or write appears after this method in the code, the processor cannot move it before this method.</summary>
	/// <param name="location">The field to read.</param>
	/// <returns>The value that was read. This value is the latest written by any processor in the computer, regardless of the number of processors or the state of processor cache.</returns>
	[Intrinsic]
	public static int Read(ref int location)
	{
		return 0;
	}

	/// <summary>Writes the specified value to the specified field. On systems that require it, inserts a memory barrier that prevents the processor from reordering memory operations as follows: If a read or write appears before this method in the code, the processor cannot move it after this method.</summary>
	/// <param name="location">The field where the value is written.</param>
	/// <param name="value">The value to write. The value is written immediately so that it is visible to all processors in the computer.</param>
	[Intrinsic]
	public static void Write(ref int location, int value)
	{
	}

	/// <summary>Reads the object reference from the specified field. On systems that require it, inserts a memory barrier that prevents the processor from reordering memory operations as follows: If a read or write appears after this method in the code, the processor cannot move it before this method.</summary>
	/// <param name="location">The field to read.</param>
	/// <typeparam name="T">The type of field to read. This must be a reference type, not a value type.</typeparam>
	/// <returns>The reference to <paramref name="T" /> that was read. This reference is the latest written by any processor in the computer, regardless of the number of processors or the state of processor cache.</returns>
	[Intrinsic]
	public static T Read<T>(ref T location) where T : class
	{
		return null;
	}

	/// <summary>Writes the specified object reference to the specified field. On systems that require it, inserts a memory barrier that prevents the processor from reordering memory operations as follows: If a read or write appears before this method in the code, the processor cannot move it after this method.</summary>
	/// <param name="location">The field where the object reference is written.</param>
	/// <param name="value">The object reference to write. The reference is written immediately so that it is visible to all processors in the computer.</param>
	/// <typeparam name="T">The type of field to write. This must be a reference type, not a value type.</typeparam>
	[Intrinsic]
	public static void Write<T>(ref T location, T value) where T : class
	{
	}
}
