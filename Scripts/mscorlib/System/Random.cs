namespace System;

/// <summary>Represents a pseudo-random number generator, which is a device that produces a sequence of numbers that meet certain statistical requirements for randomness.</summary>
public class Random
{
	private const int MBIG = int.MaxValue;

	private const int MSEED = 161803398;

	private const int MZ = 0;

	private int _inext;

	private int _inextp;

	private int[] _seedArray;

	[ThreadStatic]
	private static Random t_threadRandom;

	private static readonly Random s_globalRandom;

	/// <summary>Initializes a new instance of the <see cref="T:System.Random" /> class, using a time-dependent default seed value.</summary>
	public Random()
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Random" /> class, using the specified seed value.</summary>
	/// <param name="Seed">A number used to calculate a starting value for the pseudo-random number sequence. If a negative number is specified, the absolute value of the number is used.</param>
	public Random(int Seed)
	{
	}

	/// <summary>Returns a random floating-point number between 0.0 and 1.0.</summary>
	/// <returns>A double-precision floating point number that is greater than or equal to 0.0, and less than 1.0.</returns>
	protected virtual double Sample()
	{
		return 0.0;
	}

	private int InternalSample()
	{
		return 0;
	}

	private static int GenerateSeed()
	{
		return 0;
	}

	private static int GenerateGlobalSeed()
	{
		return 0;
	}

	/// <summary>Returns a non-negative random integer.</summary>
	/// <returns>A 32-bit signed integer that is greater than or equal to 0 and less than <see cref="F:System.Int32.MaxValue" />.</returns>
	public virtual int Next()
	{
		return 0;
	}

	private double GetSampleForLargeRange()
	{
		return 0.0;
	}

	/// <summary>Returns a random integer that is within a specified range.</summary>
	/// <param name="minValue">The inclusive lower bound of the random number returned.</param>
	/// <param name="maxValue">The exclusive upper bound of the random number returned. <paramref name="maxValue" /> must be greater than or equal to <paramref name="minValue" />.</param>
	/// <returns>A 32-bit signed integer greater than or equal to <paramref name="minValue" /> and less than <paramref name="maxValue" />; that is, the range of return values includes <paramref name="minValue" /> but not <paramref name="maxValue" />. If <paramref name="minValue" /> equals <paramref name="maxValue" />, <paramref name="minValue" /> is returned.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="minValue" /> is greater than <paramref name="maxValue" />.</exception>
	public virtual int Next(int minValue, int maxValue)
	{
		return 0;
	}

	/// <summary>Returns a non-negative random integer that is less than the specified maximum.</summary>
	/// <param name="maxValue">The exclusive upper bound of the random number to be generated. <paramref name="maxValue" /> must be greater than or equal to 0.</param>
	/// <returns>A 32-bit signed integer that is greater than or equal to 0, and less than <paramref name="maxValue" />; that is, the range of return values ordinarily includes 0 but not <paramref name="maxValue" />. However, if <paramref name="maxValue" /> equals 0, <paramref name="maxValue" /> is returned.</returns>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="maxValue" /> is less than 0.</exception>
	public virtual int Next(int maxValue)
	{
		return 0;
	}

	/// <summary>Returns a random floating-point number that is greater than or equal to 0.0, and less than 1.0.</summary>
	/// <returns>A double-precision floating point number that is greater than or equal to 0.0, and less than 1.0.</returns>
	public virtual double NextDouble()
	{
		return 0.0;
	}

	/// <summary>Fills the elements of a specified array of bytes with random numbers.</summary>
	/// <param name="buffer">An array of bytes to contain random numbers.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="buffer" /> is <see langword="null" />.</exception>
	public virtual void NextBytes(byte[] buffer)
	{
	}
}
