using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace System;

/// <summary>Provides constants and static methods for trigonometric, logarithmic, and other common mathematical functions.</summary>
public static class Math
{
	private static double doubleRoundLimit;

	private static double[] roundPower10Double;

	/// <summary>Returns the absolute value of a 32-bit signed integer.</summary>
	/// <param name="value">A number that is greater than <see cref="F:System.Int32.MinValue" />, but less than or equal to <see cref="F:System.Int32.MaxValue" />.</param>
	/// <returns>A 32-bit signed integer, x, such that 0 ≤ x ≤<see cref="F:System.Int32.MaxValue" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> equals <see cref="F:System.Int32.MinValue" />.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Abs(int value)
	{
		return 0;
	}

	/// <summary>Returns the absolute value of a 64-bit signed integer.</summary>
	/// <param name="value">A number that is greater than <see cref="F:System.Int64.MinValue" />, but less than or equal to <see cref="F:System.Int64.MaxValue" />.</param>
	/// <returns>A 64-bit signed integer, x, such that 0 ≤ x ≤<see cref="F:System.Int64.MaxValue" />.</returns>
	/// <exception cref="T:System.OverflowException">
	///   <paramref name="value" /> equals <see cref="F:System.Int64.MinValue" />.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static long Abs(long value)
	{
		return 0L;
	}

	/// <summary>Returns the absolute value of a <see cref="T:System.Decimal" /> number.</summary>
	/// <param name="value">A number that is greater than or equal to <see cref="F:System.Decimal.MinValue" />, but less than or equal to <see cref="F:System.Decimal.MaxValue" />.</param>
	/// <returns>A decimal number, x, such that 0 ≤ x ≤<see cref="F:System.Decimal.MaxValue" />.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static decimal Abs(decimal value)
	{
		return default(decimal);
	}

	[StackTraceHidden]
	private static void ThrowAbsOverflow()
	{
	}

	/// <summary>Calculates the quotient of two 32-bit signed integers and also returns the remainder in an output parameter.</summary>
	/// <param name="a">The dividend.</param>
	/// <param name="b">The divisor.</param>
	/// <param name="result">The remainder.</param>
	/// <returns>The quotient of the specified numbers.</returns>
	/// <exception cref="T:System.DivideByZeroException">
	///   <paramref name="b" /> is zero.</exception>
	public static int DivRem(int a, int b, out int result)
	{
		result = default(int);
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Clamp(int value, int min, int max)
	{
		return 0;
	}

	/// <summary>Returns the logarithm of a specified number in a specified base.</summary>
	/// <param name="a">The number whose logarithm is to be found.</param>
	/// <param name="newBase">The base of the logarithm.</param>
	/// <returns>One of the values in the following table. (+Infinity denotes <see cref="F:System.Double.PositiveInfinity" />, -Infinity denotes <see cref="F:System.Double.NegativeInfinity" />, and NaN denotes <see cref="F:System.Double.NaN" />.)  
	///  <paramref name="a" /><paramref name="newBase" /> Return value  
	///
	///  <paramref name="a" />&gt; 0  
	///
	///   (0 &lt;<paramref name="newBase" />&lt; 1) -or-(<paramref name="newBase" />&gt; 1)  
	///
	///   lognewBase(a)  
	///
	///  <paramref name="a" />&lt; 0  
	///
	///   (any value)  
	///
	///   NaN  
	///
	///   (any value)  
	///
	///  <paramref name="newBase" />&lt; 0  
	///
	///   NaN  
	///
	///  <paramref name="a" /> != 1  
	///
	///  <paramref name="newBase" /> = 0  
	///
	///   NaN  
	///
	///  <paramref name="a" /> != 1  
	///
	///  <paramref name="newBase" /> = +Infinity  
	///
	///   NaN  
	///
	///  <paramref name="a" /> = NaN  
	///
	///   (any value)  
	///
	///   NaN  
	///
	///   (any value)  
	///
	///  <paramref name="newBase" /> = NaN  
	///
	///   NaN  
	///
	///   (any value)  
	///
	///  <paramref name="newBase" /> = 1  
	///
	///   NaN  
	///
	///  <paramref name="a" /> = 0  
	///
	///   0 &lt;<paramref name="newBase" />&lt; 1  
	///
	///   +Infinity  
	///
	///  <paramref name="a" /> = 0  
	///
	///  <paramref name="newBase" />&gt; 1  
	///
	///   -Infinity  
	///
	///  <paramref name="a" /> =  +Infinity  
	///
	///   0 &lt;<paramref name="newBase" />&lt; 1  
	///
	///   -Infinity  
	///
	///  <paramref name="a" /> =  +Infinity  
	///
	///  <paramref name="newBase" />&gt; 1  
	///
	///   +Infinity  
	///
	///  <paramref name="a" /> = 1  
	///
	///  <paramref name="newBase" /> = 0  
	///
	///   0  
	///
	///  <paramref name="a" /> = 1  
	///
	///  <paramref name="newBase" /> = +Infinity  
	///
	///   0</returns>
	public static double Log(double a, double newBase)
	{
		return 0.0;
	}

	/// <summary>Returns the larger of two 8-bit unsigned integers.</summary>
	/// <param name="val1">The first of two 8-bit unsigned integers to compare.</param>
	/// <param name="val2">The second of two 8-bit unsigned integers to compare.</param>
	/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns>
	[NonVersionable]
	public static byte Max(byte val1, byte val2)
	{
		return 0;
	}

	/// <summary>Returns the larger of two decimal numbers.</summary>
	/// <param name="val1">The first of two decimal numbers to compare.</param>
	/// <param name="val2">The second of two decimal numbers to compare.</param>
	/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static decimal Max(decimal val1, decimal val2)
	{
		return default(decimal);
	}

	/// <summary>Returns the larger of two double-precision floating-point numbers.</summary>
	/// <param name="val1">The first of two double-precision floating-point numbers to compare.</param>
	/// <param name="val2">The second of two double-precision floating-point numbers to compare.</param>
	/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger. If <paramref name="val1" />, <paramref name="val2" />, or both <paramref name="val1" /> and <paramref name="val2" /> are equal to <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NaN" /> is returned.</returns>
	public static double Max(double val1, double val2)
	{
		return 0.0;
	}

	/// <summary>Returns the larger of two 16-bit signed integers.</summary>
	/// <param name="val1">The first of two 16-bit signed integers to compare.</param>
	/// <param name="val2">The second of two 16-bit signed integers to compare.</param>
	/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns>
	[NonVersionable]
	public static short Max(short val1, short val2)
	{
		return 0;
	}

	/// <summary>Returns the larger of two 32-bit signed integers.</summary>
	/// <param name="val1">The first of two 32-bit signed integers to compare.</param>
	/// <param name="val2">The second of two 32-bit signed integers to compare.</param>
	/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns>
	[NonVersionable]
	public static int Max(int val1, int val2)
	{
		return 0;
	}

	/// <summary>Returns the larger of two 64-bit signed integers.</summary>
	/// <param name="val1">The first of two 64-bit signed integers to compare.</param>
	/// <param name="val2">The second of two 64-bit signed integers to compare.</param>
	/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns>
	[NonVersionable]
	public static long Max(long val1, long val2)
	{
		return 0L;
	}

	/// <summary>Returns the larger of two 8-bit signed integers.</summary>
	/// <param name="val1">The first of two 8-bit signed integers to compare.</param>
	/// <param name="val2">The second of two 8-bit signed integers to compare.</param>
	/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns>
	[NonVersionable]
	[CLSCompliant(false)]
	public static sbyte Max(sbyte val1, sbyte val2)
	{
		return 0;
	}

	/// <summary>Returns the larger of two single-precision floating-point numbers.</summary>
	/// <param name="val1">The first of two single-precision floating-point numbers to compare.</param>
	/// <param name="val2">The second of two single-precision floating-point numbers to compare.</param>
	/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger. If <paramref name="val1" />, or <paramref name="val2" />, or both <paramref name="val1" /> and <paramref name="val2" /> are equal to <see cref="F:System.Single.NaN" />, <see cref="F:System.Single.NaN" /> is returned.</returns>
	public static float Max(float val1, float val2)
	{
		return 0f;
	}

	/// <summary>Returns the larger of two 16-bit unsigned integers.</summary>
	/// <param name="val1">The first of two 16-bit unsigned integers to compare.</param>
	/// <param name="val2">The second of two 16-bit unsigned integers to compare.</param>
	/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns>
	[CLSCompliant(false)]
	[NonVersionable]
	public static ushort Max(ushort val1, ushort val2)
	{
		return 0;
	}

	/// <summary>Returns the larger of two 32-bit unsigned integers.</summary>
	/// <param name="val1">The first of two 32-bit unsigned integers to compare.</param>
	/// <param name="val2">The second of two 32-bit unsigned integers to compare.</param>
	/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns>
	[NonVersionable]
	[CLSCompliant(false)]
	public static uint Max(uint val1, uint val2)
	{
		return 0u;
	}

	/// <summary>Returns the larger of two 64-bit unsigned integers.</summary>
	/// <param name="val1">The first of two 64-bit unsigned integers to compare.</param>
	/// <param name="val2">The second of two 64-bit unsigned integers to compare.</param>
	/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is larger.</returns>
	[CLSCompliant(false)]
	[NonVersionable]
	public static ulong Max(ulong val1, ulong val2)
	{
		return 0uL;
	}

	/// <summary>Returns the smaller of two 8-bit unsigned integers.</summary>
	/// <param name="val1">The first of two 8-bit unsigned integers to compare.</param>
	/// <param name="val2">The second of two 8-bit unsigned integers to compare.</param>
	/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns>
	[NonVersionable]
	public static byte Min(byte val1, byte val2)
	{
		return 0;
	}

	/// <summary>Returns the smaller of two decimal numbers.</summary>
	/// <param name="val1">The first of two decimal numbers to compare.</param>
	/// <param name="val2">The second of two decimal numbers to compare.</param>
	/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static decimal Min(decimal val1, decimal val2)
	{
		return default(decimal);
	}

	/// <summary>Returns the smaller of two double-precision floating-point numbers.</summary>
	/// <param name="val1">The first of two double-precision floating-point numbers to compare.</param>
	/// <param name="val2">The second of two double-precision floating-point numbers to compare.</param>
	/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller. If <paramref name="val1" />, <paramref name="val2" />, or both <paramref name="val1" /> and <paramref name="val2" /> are equal to <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NaN" /> is returned.</returns>
	public static double Min(double val1, double val2)
	{
		return 0.0;
	}

	/// <summary>Returns the smaller of two 16-bit signed integers.</summary>
	/// <param name="val1">The first of two 16-bit signed integers to compare.</param>
	/// <param name="val2">The second of two 16-bit signed integers to compare.</param>
	/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns>
	[NonVersionable]
	public static short Min(short val1, short val2)
	{
		return 0;
	}

	/// <summary>Returns the smaller of two 32-bit signed integers.</summary>
	/// <param name="val1">The first of two 32-bit signed integers to compare.</param>
	/// <param name="val2">The second of two 32-bit signed integers to compare.</param>
	/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns>
	[NonVersionable]
	public static int Min(int val1, int val2)
	{
		return 0;
	}

	/// <summary>Returns the smaller of two 64-bit signed integers.</summary>
	/// <param name="val1">The first of two 64-bit signed integers to compare.</param>
	/// <param name="val2">The second of two 64-bit signed integers to compare.</param>
	/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns>
	[NonVersionable]
	public static long Min(long val1, long val2)
	{
		return 0L;
	}

	/// <summary>Returns the smaller of two 8-bit signed integers.</summary>
	/// <param name="val1">The first of two 8-bit signed integers to compare.</param>
	/// <param name="val2">The second of two 8-bit signed integers to compare.</param>
	/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns>
	[NonVersionable]
	[CLSCompliant(false)]
	public static sbyte Min(sbyte val1, sbyte val2)
	{
		return 0;
	}

	/// <summary>Returns the smaller of two single-precision floating-point numbers.</summary>
	/// <param name="val1">The first of two single-precision floating-point numbers to compare.</param>
	/// <param name="val2">The second of two single-precision floating-point numbers to compare.</param>
	/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller. If <paramref name="val1" />, <paramref name="val2" />, or both <paramref name="val1" /> and <paramref name="val2" /> are equal to <see cref="F:System.Single.NaN" />, <see cref="F:System.Single.NaN" /> is returned.</returns>
	public static float Min(float val1, float val2)
	{
		return 0f;
	}

	/// <summary>Returns the smaller of two 16-bit unsigned integers.</summary>
	/// <param name="val1">The first of two 16-bit unsigned integers to compare.</param>
	/// <param name="val2">The second of two 16-bit unsigned integers to compare.</param>
	/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns>
	[CLSCompliant(false)]
	[NonVersionable]
	public static ushort Min(ushort val1, ushort val2)
	{
		return 0;
	}

	/// <summary>Returns the smaller of two 32-bit unsigned integers.</summary>
	/// <param name="val1">The first of two 32-bit unsigned integers to compare.</param>
	/// <param name="val2">The second of two 32-bit unsigned integers to compare.</param>
	/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns>
	[CLSCompliant(false)]
	[NonVersionable]
	public static uint Min(uint val1, uint val2)
	{
		return 0u;
	}

	/// <summary>Returns the smaller of two 64-bit unsigned integers.</summary>
	/// <param name="val1">The first of two 64-bit unsigned integers to compare.</param>
	/// <param name="val2">The second of two 64-bit unsigned integers to compare.</param>
	/// <returns>Parameter <paramref name="val1" /> or <paramref name="val2" />, whichever is smaller.</returns>
	[CLSCompliant(false)]
	[NonVersionable]
	public static ulong Min(ulong val1, ulong val2)
	{
		return 0uL;
	}

	/// <summary>Rounds a decimal value to the nearest integral value, and rounds midpoint values to the nearest even number.</summary>
	/// <param name="d">A decimal number to be rounded.</param>
	/// <returns>The integer nearest the <paramref name="d" /> parameter. If the fractional component of <paramref name="d" /> is halfway between two integers, one of which is even and the other odd, the even number is returned. Note that this method returns a <see cref="T:System.Decimal" /> instead of an integral type.</returns>
	/// <exception cref="T:System.OverflowException">The result is outside the range of a <see cref="T:System.Decimal" />.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static decimal Round(decimal d)
	{
		return default(decimal);
	}

	/// <summary>Rounds a decimal value to a specified number of fractional digits, and rounds midpoint values to the nearest even number.</summary>
	/// <param name="d">A decimal number to be rounded.</param>
	/// <param name="decimals">The number of decimal places in the return value.</param>
	/// <returns>The number nearest to <paramref name="d" /> that contains a number of fractional digits equal to <paramref name="decimals" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="decimals" /> is less than 0 or greater than 28.</exception>
	/// <exception cref="T:System.OverflowException">The result is outside the range of a <see cref="T:System.Decimal" />.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static decimal Round(decimal d, int decimals)
	{
		return default(decimal);
	}

	/// <summary>Rounds a double-precision floating-point value to the nearest integral value, and rounds midpoint values to the nearest even number.</summary>
	/// <param name="a">A double-precision floating-point number to be rounded.</param>
	/// <returns>The integer nearest <paramref name="a" />. If the fractional component of <paramref name="a" /> is halfway between two integers, one of which is even and the other odd, then the even number is returned. Note that this method returns a <see cref="T:System.Double" /> instead of an integral type.</returns>
	public static double Round(double a)
	{
		return 0.0;
	}

	/// <summary>Rounds a double-precision floating-point value to a specified number of fractional digits, and rounds midpoint values to the nearest even number.</summary>
	/// <param name="value">A double-precision floating-point number to be rounded.</param>
	/// <param name="digits">The number of fractional digits in the return value.</param>
	/// <returns>The number nearest to <paramref name="value" /> that contains a number of fractional digits equal to <paramref name="digits" />.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="digits" /> is less than 0 or greater than 15.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double Round(double value, int digits)
	{
		return 0.0;
	}

	/// <summary>Rounds a double-precision floating-point value to the nearest integer, and uses the specified rounding convention for midpoint values.</summary>
	/// <param name="value">A double-precision floating-point number to be rounded.</param>
	/// <param name="mode">Specification for how to round <paramref name="value" /> if it is midway between two other numbers.</param>
	/// <returns>The integer nearest <paramref name="value" />. If <paramref name="value" /> is halfway between two integers, one of which is even and the other odd, then <paramref name="mode" /> determines which of the two is returned. Note that this method returns a <see cref="T:System.Double" /> instead of an integral type.</returns>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="mode" /> is not a valid value of <see cref="T:System.MidpointRounding" />.</exception>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double Round(double value, MidpointRounding mode)
	{
		return 0.0;
	}

	/// <summary>Rounds a double-precision floating-point value to a specified number of fractional digits, and uses the specified rounding convention for midpoint values.</summary>
	/// <param name="value">A double-precision floating-point number to be rounded.</param>
	/// <param name="digits">The number of fractional digits in the return value.</param>
	/// <param name="mode">Specification for how to round <paramref name="value" /> if it is midway between two other numbers.</param>
	/// <returns>The number nearest to <paramref name="value" /> that has a number of fractional digits equal to <paramref name="digits" />. If <paramref name="value" /> has fewer fractional digits than <paramref name="digits" />, <paramref name="value" /> is returned unchanged.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="digits" /> is less than 0 or greater than 15.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="mode" /> is not a valid value of <see cref="T:System.MidpointRounding" />.</exception>
	public static double Round(double value, int digits, MidpointRounding mode)
	{
		return 0.0;
	}

	/// <summary>Returns an integer that indicates the sign of a double-precision floating-point number.</summary>
	/// <param name="value">A signed number.</param>
	/// <returns>A number that indicates the sign of <paramref name="value" />, as shown in the following table.  
	///   Return value  
	///
	///   Meaning  
	///
	///   -1  
	///
	///  <paramref name="value" /> is less than zero.  
	///
	///   0  
	///
	///  <paramref name="value" /> is equal to zero.  
	///
	///   1  
	///
	///  <paramref name="value" /> is greater than zero.</returns>
	/// <exception cref="T:System.ArithmeticException">
	///   <paramref name="value" /> is equal to <see cref="F:System.Double.NaN" />.</exception>
	public static int Sign(double value)
	{
		return 0;
	}

	/// <summary>Returns an integer that indicates the sign of a 32-bit signed integer.</summary>
	/// <param name="value">A signed number.</param>
	/// <returns>A number that indicates the sign of <paramref name="value" />, as shown in the following table.  
	///   Return value  
	///
	///   Meaning  
	///
	///   -1  
	///
	///  <paramref name="value" /> is less than zero.  
	///
	///   0  
	///
	///  <paramref name="value" /> is equal to zero.  
	///
	///   1  
	///
	///  <paramref name="value" /> is greater than zero.</returns>
	public static int Sign(int value)
	{
		return 0;
	}

	/// <summary>Returns an integer that indicates the sign of a 64-bit signed integer.</summary>
	/// <param name="value">A signed number.</param>
	/// <returns>A number that indicates the sign of <paramref name="value" />, as shown in the following table.  
	///   Return value  
	///
	///   Meaning  
	///
	///   -1  
	///
	///  <paramref name="value" /> is less than zero.  
	///
	///   0  
	///
	///  <paramref name="value" /> is equal to zero.  
	///
	///   1  
	///
	///  <paramref name="value" /> is greater than zero.</returns>
	public static int Sign(long value)
	{
		return 0;
	}

	/// <summary>Calculates the integral part of a specified decimal number.</summary>
	/// <param name="d">A number to truncate.</param>
	/// <returns>The integral part of <paramref name="d" />; that is, the number that remains after any fractional digits have been discarded.</returns>
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static decimal Truncate(decimal d)
	{
		return default(decimal);
	}

	/// <summary>Calculates the integral part of a specified double-precision floating-point number.</summary>
	/// <param name="d">A number to truncate.</param>
	/// <returns>The integral part of <paramref name="d" />; that is, the number that remains after any fractional digits have been discarded, or one of the values listed in the following table.  
	///  <paramref name="d" /> Return value  
	///
	///  <see cref="F:System.Double.NaN" /><see cref="F:System.Double.NaN" /><see cref="F:System.Double.NegativeInfinity" /><see cref="F:System.Double.NegativeInfinity" /><see cref="F:System.Double.PositiveInfinity" /><see cref="F:System.Double.PositiveInfinity" /></returns>
	public static double Truncate(double d)
	{
		return 0.0;
	}

	private static void ThrowMinMaxException<T>(T min, T max)
	{
	}

	/// <summary>Returns the absolute value of a double-precision floating-point number.</summary>
	/// <param name="value">A number that is greater than or equal to <see cref="F:System.Double.MinValue" />, but less than or equal to <see cref="F:System.Double.MaxValue" />.</param>
	/// <returns>A double-precision floating-point number, x, such that 0 ≤ x ≤<see cref="F:System.Double.MaxValue" />.</returns>
	public static double Abs(double value)
	{
		return 0.0;
	}

	/// <summary>Returns the absolute value of a single-precision floating-point number.</summary>
	/// <param name="value">A number that is greater than or equal to <see cref="F:System.Single.MinValue" />, but less than or equal to <see cref="F:System.Single.MaxValue" />.</param>
	/// <returns>A single-precision floating-point number, x, such that 0 ≤ x ≤<see cref="F:System.Single.MaxValue" />.</returns>
	public static float Abs(float value)
	{
		return 0f;
	}

	/// <summary>Returns the angle whose cosine is the specified number.</summary>
	/// <param name="d">A number representing a cosine, where <paramref name="d" /> must be greater than or equal to -1, but less than or equal to 1.</param>
	/// <returns>An angle, θ, measured in radians, such that 0 ≤θ≤π  
	///  -or-  
	///  <see cref="F:System.Double.NaN" /> if <paramref name="d" /> &lt; -1 or <paramref name="d" /> &gt; 1 or <paramref name="d" /> equals <see cref="F:System.Double.NaN" />.</returns>
	public static double Acos(double d)
	{
		return 0.0;
	}

	/// <summary>Returns the angle whose sine is the specified number.</summary>
	/// <param name="d">A number representing a sine, where <paramref name="d" /> must be greater than or equal to -1, but less than or equal to 1.</param>
	/// <returns>An angle, θ, measured in radians, such that -π/2 ≤θ≤π/2  
	///  -or-  
	///  <see cref="F:System.Double.NaN" /> if <paramref name="d" /> &lt; -1 or <paramref name="d" /> &gt; 1 or <paramref name="d" /> equals <see cref="F:System.Double.NaN" />.</returns>
	public static double Asin(double d)
	{
		return 0.0;
	}

	/// <summary>Returns the angle whose tangent is the specified number.</summary>
	/// <param name="d">A number representing a tangent.</param>
	/// <returns>An angle, θ, measured in radians, such that -π/2 ≤θ≤π/2.  
	///  -or-  
	///  <see cref="F:System.Double.NaN" /> if <paramref name="d" /> equals <see cref="F:System.Double.NaN" />, -π/2 rounded to double precision (-1.5707963267949) if <paramref name="d" /> equals <see cref="F:System.Double.NegativeInfinity" />, or π/2 rounded to double precision (1.5707963267949) if <paramref name="d" /> equals <see cref="F:System.Double.PositiveInfinity" />.</returns>
	public static double Atan(double d)
	{
		return 0.0;
	}

	/// <summary>Returns the angle whose tangent is the quotient of two specified numbers.</summary>
	/// <param name="y">The y coordinate of a point.</param>
	/// <param name="x">The x coordinate of a point.</param>
	/// <returns>An angle, θ, measured in radians, such that -π≤θ≤π, and tan(θ) = <paramref name="y" /> / <paramref name="x" />, where (<paramref name="x" />, <paramref name="y" />) is a point in the Cartesian plane. Observe the following:  
	///
	/// For (<paramref name="x" />, <paramref name="y" />) in quadrant 1, 0 &lt; θ &lt; π/2.  
	///
	/// For (<paramref name="x" />, <paramref name="y" />) in quadrant 2, π/2 &lt; θ≤π.  
	///
	/// For (<paramref name="x" />, <paramref name="y" />) in quadrant 3, -π &lt; θ &lt; -π/2.  
	///
	/// For (<paramref name="x" />, <paramref name="y" />) in quadrant 4, -π/2 &lt; θ &lt; 0.  
	///
	///
	///  For points on the boundaries of the quadrants, the return value is the following:  
	///
	/// If y is 0 and x is not negative, θ = 0.  
	///
	/// If y is 0 and x is negative, θ = π.  
	///
	/// If y is positive and x is 0, θ = π/2.  
	///
	/// If y is negative and x is 0, θ = -π/2.  
	///
	/// If y is 0 and x is 0, θ = 0.  
	///
	///
	///  If <paramref name="x" /> or <paramref name="y" /> is <see cref="F:System.Double.NaN" />, or if <paramref name="x" /> and <paramref name="y" /> are either <see cref="F:System.Double.PositiveInfinity" /> or <see cref="F:System.Double.NegativeInfinity" />, the method returns <see cref="F:System.Double.NaN" />.</returns>
	public static double Atan2(double y, double x)
	{
		return 0.0;
	}

	/// <summary>Returns the smallest integral value that is greater than or equal to the specified double-precision floating-point number.</summary>
	/// <param name="a">A double-precision floating-point number.</param>
	/// <returns>The smallest integral value that is greater than or equal to <paramref name="a" />. If <paramref name="a" /> is equal to <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NegativeInfinity" />, or <see cref="F:System.Double.PositiveInfinity" />, that value is returned. Note that this method returns a <see cref="T:System.Double" /> instead of an integral type.</returns>
	public static double Ceiling(double a)
	{
		return 0.0;
	}

	/// <summary>Returns the cosine of the specified angle.</summary>
	/// <param name="d">An angle, measured in radians.</param>
	/// <returns>The cosine of <paramref name="d" />. If <paramref name="d" /> is equal to <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NegativeInfinity" />, or <see cref="F:System.Double.PositiveInfinity" />, this method returns <see cref="F:System.Double.NaN" />.</returns>
	public static double Cos(double d)
	{
		return 0.0;
	}

	/// <summary>Returns the hyperbolic cosine of the specified angle.</summary>
	/// <param name="value">An angle, measured in radians.</param>
	/// <returns>The hyperbolic cosine of <paramref name="value" />. If <paramref name="value" /> is equal to <see cref="F:System.Double.NegativeInfinity" /> or <see cref="F:System.Double.PositiveInfinity" />, <see cref="F:System.Double.PositiveInfinity" /> is returned. If <paramref name="value" /> is equal to <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NaN" /> is returned.</returns>
	public static double Cosh(double value)
	{
		return 0.0;
	}

	/// <summary>Returns <see langword="e" /> raised to the specified power.</summary>
	/// <param name="d">A number specifying a power.</param>
	/// <returns>The number <see langword="e" /> raised to the power <paramref name="d" />. If <paramref name="d" /> equals <see cref="F:System.Double.NaN" /> or <see cref="F:System.Double.PositiveInfinity" />, that value is returned. If <paramref name="d" /> equals <see cref="F:System.Double.NegativeInfinity" />, 0 is returned.</returns>
	public static double Exp(double d)
	{
		return 0.0;
	}

	/// <summary>Returns the largest integral value less than or equal to the specified double-precision floating-point number.</summary>
	/// <param name="d">A double-precision floating-point number.</param>
	/// <returns>The largest integral value less than or equal to <paramref name="d" />. If <paramref name="d" /> is equal to <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NegativeInfinity" />, or <see cref="F:System.Double.PositiveInfinity" />, that value is returned.</returns>
	public static double Floor(double d)
	{
		return 0.0;
	}

	/// <summary>Returns the natural (base <see langword="e" />) logarithm of a specified number.</summary>
	/// <param name="d">The number whose logarithm is to be found.</param>
	/// <returns>One of the values in the following table.  
	///  <paramref name="d" /> parameter  
	///
	///   Return value  
	///
	///   Positive  
	///
	///   The natural logarithm of <paramref name="d" />; that is, ln <paramref name="d" />, or log e <paramref name="d" /> Zero  
	///
	///  <see cref="F:System.Double.NegativeInfinity" /> Negative  
	///
	///  <see cref="F:System.Double.NaN" /> Equal to <see cref="F:System.Double.NaN" /><see cref="F:System.Double.NaN" /> Equal to <see cref="F:System.Double.PositiveInfinity" /><see cref="F:System.Double.PositiveInfinity" /></returns>
	public static double Log(double d)
	{
		return 0.0;
	}

	/// <summary>Returns the base 10 logarithm of a specified number.</summary>
	/// <param name="d">A number whose logarithm is to be found.</param>
	/// <returns>One of the values in the following table.  
	///  <paramref name="d" /> parameter  
	///
	///   Return value  
	///
	///   Positive  
	///
	///   The base 10 log of <paramref name="d" />; that is, log 10<paramref name="d" />.  
	///
	///   Zero  
	///
	///  <see cref="F:System.Double.NegativeInfinity" /> Negative  
	///
	///  <see cref="F:System.Double.NaN" /> Equal to <see cref="F:System.Double.NaN" /><see cref="F:System.Double.NaN" /> Equal to <see cref="F:System.Double.PositiveInfinity" /><see cref="F:System.Double.PositiveInfinity" /></returns>
	public static double Log10(double d)
	{
		return 0.0;
	}

	/// <summary>Returns a specified number raised to the specified power.</summary>
	/// <param name="x">A double-precision floating-point number to be raised to a power.</param>
	/// <param name="y">A double-precision floating-point number that specifies a power.</param>
	/// <returns>The number <paramref name="x" /> raised to the power <paramref name="y" />.</returns>
	public static double Pow(double x, double y)
	{
		return 0.0;
	}

	/// <summary>Returns the sine of the specified angle.</summary>
	/// <param name="a">An angle, measured in radians.</param>
	/// <returns>The sine of <paramref name="a" />. If <paramref name="a" /> is equal to <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NegativeInfinity" />, or <see cref="F:System.Double.PositiveInfinity" />, this method returns <see cref="F:System.Double.NaN" />.</returns>
	public static double Sin(double a)
	{
		return 0.0;
	}

	/// <summary>Returns the hyperbolic sine of the specified angle.</summary>
	/// <param name="value">An angle, measured in radians.</param>
	/// <returns>The hyperbolic sine of <paramref name="value" />. If <paramref name="value" /> is equal to <see cref="F:System.Double.NegativeInfinity" />, <see cref="F:System.Double.PositiveInfinity" />, or <see cref="F:System.Double.NaN" />, this method returns a <see cref="T:System.Double" /> equal to <paramref name="value" />.</returns>
	public static double Sinh(double value)
	{
		return 0.0;
	}

	/// <summary>Returns the square root of a specified number.</summary>
	/// <param name="d">The number whose square root is to be found.</param>
	/// <returns>One of the values in the following table.  
	///  <paramref name="d" /> parameter  
	///
	///   Return value  
	///
	///   Zero or positive  
	///
	///   The positive square root of <paramref name="d" />.  
	///
	///   Negative  
	///
	///  <see cref="F:System.Double.NaN" /> Equals <see cref="F:System.Double.NaN" /><see cref="F:System.Double.NaN" /> Equals <see cref="F:System.Double.PositiveInfinity" /><see cref="F:System.Double.PositiveInfinity" /></returns>
	public static double Sqrt(double d)
	{
		return 0.0;
	}

	/// <summary>Returns the tangent of the specified angle.</summary>
	/// <param name="a">An angle, measured in radians.</param>
	/// <returns>The tangent of <paramref name="a" />. If <paramref name="a" /> is equal to <see cref="F:System.Double.NaN" />, <see cref="F:System.Double.NegativeInfinity" />, or <see cref="F:System.Double.PositiveInfinity" />, this method returns <see cref="F:System.Double.NaN" />.</returns>
	public static double Tan(double a)
	{
		return 0.0;
	}

	/// <summary>Returns the hyperbolic tangent of the specified angle.</summary>
	/// <param name="value">An angle, measured in radians.</param>
	/// <returns>The hyperbolic tangent of <paramref name="value" />. If <paramref name="value" /> is equal to <see cref="F:System.Double.NegativeInfinity" />, this method returns -1. If value is equal to <see cref="F:System.Double.PositiveInfinity" />, this method returns 1. If <paramref name="value" /> is equal to <see cref="F:System.Double.NaN" />, this method returns <see cref="F:System.Double.NaN" />.</returns>
	public static double Tanh(double value)
	{
		return 0.0;
	}

	private unsafe static double ModF(double x, double* intptr)
	{
		return 0.0;
	}
}
