using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System.Threading;

/// <summary>Provides atomic operations for variables that are shared by multiple threads.</summary>
public static class Interlocked
{
	/// <summary>Compares two 32-bit signed integers for equality and, if they are equal, replaces the first value.</summary>
	/// <param name="location1">The destination, whose value is compared with <paramref name="comparand" /> and possibly replaced.</param>
	/// <param name="value">The value that replaces the destination value if the comparison results in equality.</param>
	/// <param name="comparand">The value that is compared to the value at <paramref name="location1" />.</param>
	/// <returns>The original value in <paramref name="location1" />.</returns>
	/// <exception cref="T:System.NullReferenceException">The address of <paramref name="location1" /> is a null pointer.</exception>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static int CompareExchange(ref int location1, int value, int comparand)
	{
		return 0;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal static int CompareExchange(ref int location1, int value, int comparand, ref bool succeeded)
	{
		return 0;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private static void CompareExchange(ref object location1, ref object value, ref object comparand, ref object result)
	{
	}

	/// <summary>Compares two objects for reference equality and, if they are equal, replaces the first object.</summary>
	/// <param name="location1">The destination object that is compared by reference with <paramref name="comparand" /> and possibly replaced.</param>
	/// <param name="value">The object that replaces the destination object if the reference comparison results in equality.</param>
	/// <param name="comparand">The object that is compared by reference to the object at <paramref name="location1" />.</param>
	/// <returns>The original value in <paramref name="location1" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The address of <paramref name="location1" /> is a null pointer.</exception>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static object CompareExchange(ref object location1, object value, object comparand)
	{
		return null;
	}

	/// <summary>Compares two single-precision floating point numbers for equality and, if they are equal, replaces the first value.</summary>
	/// <param name="location1">The destination, whose value is compared with <paramref name="comparand" /> and possibly replaced.</param>
	/// <param name="value">The value that replaces the destination value if the comparison results in equality.</param>
	/// <param name="comparand">The value that is compared to the value at <paramref name="location1" />.</param>
	/// <returns>The original value in <paramref name="location1" />.</returns>
	/// <exception cref="T:System.NullReferenceException">The address of <paramref name="location1" /> is a null pointer.</exception>
	public static float CompareExchange(ref float location1, float value, float comparand)
	{
		return 0f;
	}

	/// <summary>Decrements a specified variable and stores the result, as an atomic operation.</summary>
	/// <param name="location">The variable whose value is to be decremented.</param>
	/// <returns>The decremented value.</returns>
	/// <exception cref="T:System.ArgumentNullException">The address of <paramref name="location" /> is a null pointer.</exception>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static int Decrement(ref int location)
	{
		return 0;
	}

	/// <summary>Decrements the specified variable and stores the result, as an atomic operation.</summary>
	/// <param name="location">The variable whose value is to be decremented.</param>
	/// <returns>The decremented value.</returns>
	/// <exception cref="T:System.ArgumentNullException">The address of <paramref name="location" /> is a null pointer.</exception>
	public static long Decrement(ref long location)
	{
		return 0L;
	}

	/// <summary>Increments a specified variable and stores the result, as an atomic operation.</summary>
	/// <param name="location">The variable whose value is to be incremented.</param>
	/// <returns>The incremented value.</returns>
	/// <exception cref="T:System.NullReferenceException">The address of <paramref name="location" /> is a null pointer.</exception>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static int Increment(ref int location)
	{
		return 0;
	}

	/// <summary>Increments a specified variable and stores the result, as an atomic operation.</summary>
	/// <param name="location">The variable whose value is to be incremented.</param>
	/// <returns>The incremented value.</returns>
	/// <exception cref="T:System.NullReferenceException">The address of <paramref name="location" /> is a null pointer.</exception>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static long Increment(ref long location)
	{
		return 0L;
	}

	/// <summary>Sets a 32-bit signed integer to a specified value and returns the original value, as an atomic operation.</summary>
	/// <param name="location1">The variable to set to the specified value.</param>
	/// <param name="value">The value to which the <paramref name="location1" /> parameter is set.</param>
	/// <returns>The original value of <paramref name="location1" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The address of <paramref name="location1" /> is a null pointer.</exception>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static int Exchange(ref int location1, int value)
	{
		return 0;
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private static void Exchange(ref object location1, ref object value, ref object result)
	{
	}

	/// <summary>Sets an object to a specified value and returns a reference to the original object, as an atomic operation.</summary>
	/// <param name="location1">The variable to set to the specified value.</param>
	/// <param name="value">The value to which the <paramref name="location1" /> parameter is set.</param>
	/// <returns>The original value of <paramref name="location1" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">The address of <paramref name="location1" /> is a null pointer.</exception>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static object Exchange(ref object location1, object value)
	{
		return null;
	}

	/// <summary>Sets a single-precision floating point number to a specified value and returns the original value, as an atomic operation.</summary>
	/// <param name="location1">The variable to set to the specified value.</param>
	/// <param name="value">The value to which the <paramref name="location1" /> parameter is set.</param>
	/// <returns>The original value of <paramref name="location1" />.</returns>
	/// <exception cref="T:System.NullReferenceException">The address of <paramref name="location1" /> is a null pointer.</exception>
	public static float Exchange(ref float location1, float value)
	{
		return 0f;
	}

	/// <summary>Compares two 64-bit signed integers for equality and, if they are equal, replaces the first value.</summary>
	/// <param name="location1">The destination, whose value is compared with <paramref name="comparand" /> and possibly replaced.</param>
	/// <param name="value">The value that replaces the destination value if the comparison results in equality.</param>
	/// <param name="comparand">The value that is compared to the value at <paramref name="location1" />.</param>
	/// <returns>The original value in <paramref name="location1" />.</returns>
	/// <exception cref="T:System.NullReferenceException">The address of <paramref name="location1" /> is a null pointer.</exception>
	public static long CompareExchange(ref long location1, long value, long comparand)
	{
		return 0L;
	}

	/// <summary>Compares two platform-specific handles or pointers for equality and, if they are equal, replaces the first one.</summary>
	/// <param name="location1">The destination <see cref="T:System.IntPtr" />, whose value is compared with the value of <paramref name="comparand" /> and possibly replaced by <paramref name="value" />.</param>
	/// <param name="value">The <see cref="T:System.IntPtr" /> that replaces the destination value if the comparison results in equality.</param>
	/// <param name="comparand">The <see cref="T:System.IntPtr" /> that is compared to the value at <paramref name="location1" />.</param>
	/// <returns>The original value in <paramref name="location1" />.</returns>
	/// <exception cref="T:System.NullReferenceException">The address of <paramref name="location1" /> is a null pointer.</exception>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand)
	{
		return (IntPtr)0;
	}

	/// <summary>Compares two double-precision floating point numbers for equality and, if they are equal, replaces the first value.</summary>
	/// <param name="location1">The destination, whose value is compared with <paramref name="comparand" /> and possibly replaced.</param>
	/// <param name="value">The value that replaces the destination value if the comparison results in equality.</param>
	/// <param name="comparand">The value that is compared to the value at <paramref name="location1" />.</param>
	/// <returns>The original value in <paramref name="location1" />.</returns>
	/// <exception cref="T:System.NullReferenceException">The address of <paramref name="location1" /> is a null pointer.</exception>
	public static double CompareExchange(ref double location1, double value, double comparand)
	{
		return 0.0;
	}

	/// <summary>Compares two instances of the specified reference type <paramref name="T" /> for reference equality and, if they are equal, replaces the first one.</summary>
	/// <param name="location1">The destination, whose value is compared by reference with <paramref name="comparand" /> and possibly replaced. This is a reference parameter (<see langword="ref" /> in C#, <see langword="ByRef" /> in Visual Basic).</param>
	/// <param name="value">The value that replaces the destination value if the comparison by reference results in equality.</param>
	/// <param name="comparand">The value that is compared by reference to the value at <paramref name="location1" />.</param>
	/// <typeparam name="T">The type to be used for <paramref name="location1" />, <paramref name="value" />, and <paramref name="comparand" />. This type must be a reference type.</typeparam>
	/// <returns>The original value in <paramref name="location1" />.</returns>
	/// <exception cref="T:System.NullReferenceException">The address of <paramref name="location1" /> is a null pointer.</exception>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[Intrinsic]
	[ComVisible(false)]
	public static T CompareExchange<T>(ref T location1, T value, T comparand) where T : class
	{
		return null;
	}

	/// <summary>Sets a 64-bit signed integer to a specified value and returns the original value, as an atomic operation.</summary>
	/// <param name="location1">The variable to set to the specified value.</param>
	/// <param name="value">The value to which the <paramref name="location1" /> parameter is set.</param>
	/// <returns>The original value of <paramref name="location1" />.</returns>
	/// <exception cref="T:System.NullReferenceException">The address of <paramref name="location1" /> is a null pointer.</exception>
	public static long Exchange(ref long location1, long value)
	{
		return 0L;
	}

	/// <summary>Sets a platform-specific handle or pointer to a specified value and returns the original value, as an atomic operation.</summary>
	/// <param name="location1">The variable to set to the specified value.</param>
	/// <param name="value">The value to which the <paramref name="location1" /> parameter is set.</param>
	/// <returns>The original value of <paramref name="location1" />.</returns>
	/// <exception cref="T:System.NullReferenceException">The address of <paramref name="location1" /> is a null pointer.</exception>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static IntPtr Exchange(ref IntPtr location1, IntPtr value)
	{
		return (IntPtr)0;
	}

	/// <summary>Sets a double-precision floating point number to a specified value and returns the original value, as an atomic operation.</summary>
	/// <param name="location1">The variable to set to the specified value.</param>
	/// <param name="value">The value to which the <paramref name="location1" /> parameter is set.</param>
	/// <returns>The original value of <paramref name="location1" />.</returns>
	/// <exception cref="T:System.NullReferenceException">The address of <paramref name="location1" /> is a null pointer.</exception>
	public static double Exchange(ref double location1, double value)
	{
		return 0.0;
	}

	/// <summary>Sets a variable of the specified type <paramref name="T" /> to a specified value and returns the original value, as an atomic operation.</summary>
	/// <param name="location1">The variable to set to the specified value. This is a reference parameter (<see langword="ref" /> in C#, <see langword="ByRef" /> in Visual Basic).</param>
	/// <param name="value">The value to which the <paramref name="location1" /> parameter is set.</param>
	/// <typeparam name="T">The type to be used for <paramref name="location1" /> and <paramref name="value" />. This type must be a reference type.</typeparam>
	/// <returns>The original value of <paramref name="location1" />.</returns>
	/// <exception cref="T:System.NullReferenceException">The address of <paramref name="location1" /> is a null pointer.</exception>
	[ComVisible(false)]
	[Intrinsic]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static T Exchange<T>(ref T location1, T value) where T : class
	{
		return null;
	}

	/// <summary>Returns a 64-bit value, loaded as an atomic operation.</summary>
	/// <param name="location">The 64-bit value to be loaded.</param>
	/// <returns>The loaded value.</returns>
	public static long Read(ref long location)
	{
		return 0L;
	}

	/// <summary>Adds two 32-bit integers and replaces the first integer with the sum, as an atomic operation.</summary>
	/// <param name="location1">A variable containing the first value to be added. The sum of the two values is stored in <paramref name="location1" />.</param>
	/// <param name="value">The value to be added to the integer at <paramref name="location1" />.</param>
	/// <returns>The new value stored at <paramref name="location1" />.</returns>
	/// <exception cref="T:System.NullReferenceException">The address of <paramref name="location1" /> is a null pointer.</exception>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static int Add(ref int location1, int value)
	{
		return 0;
	}

	/// <summary>Adds two 64-bit integers and replaces the first integer with the sum, as an atomic operation.</summary>
	/// <param name="location1">A variable containing the first value to be added. The sum of the two values is stored in <paramref name="location1" />.</param>
	/// <param name="value">The value to be added to the integer at <paramref name="location1" />.</param>
	/// <returns>The new value stored at <paramref name="location1" />.</returns>
	/// <exception cref="T:System.NullReferenceException">The address of <paramref name="location1" /> is a null pointer.</exception>
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static long Add(ref long location1, long value)
	{
		return 0L;
	}

	/// <summary>Synchronizes memory access as follows: The processor that executes the current thread cannot reorder instructions in such a way that memory accesses before the call to <see cref="M:System.Threading.Interlocked.MemoryBarrier" /> execute after memory accesses that follow the call to <see cref="M:System.Threading.Interlocked.MemoryBarrier" />.</summary>
	public static void MemoryBarrier()
	{
	}
}
