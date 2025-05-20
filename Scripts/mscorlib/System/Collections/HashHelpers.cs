using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Collections;

internal static class HashHelpers
{
	public static readonly int[] primes;

	private static ConditionalWeakTable<object, SerializationInfo> s_serializationInfoTable;

	internal static ConditionalWeakTable<object, SerializationInfo> SerializationInfoTable => null;

	public static bool IsPrime(int candidate)
	{
		return false;
	}

	public static int GetPrime(int min)
	{
		return 0;
	}

	public static int ExpandPrime(int oldSize)
	{
		return 0;
	}
}
