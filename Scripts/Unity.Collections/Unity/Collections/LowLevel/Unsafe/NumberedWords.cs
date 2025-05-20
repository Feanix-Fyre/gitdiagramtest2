using System;

namespace Unity.Collections.LowLevel.Unsafe;

[Obsolete("This storage will no longer be used. (RemovedAfter 2021-06-01)")]
public struct NumberedWords
{
	private int Index;

	private int Suffix;

	private const int kPositiveNumericSuffixShift = 0;

	private const int kPositiveNumericSuffixBits = 29;

	private const int kMaxPositiveNumericSuffix = 536870911;

	private const int kPositiveNumericSuffixMask = 536870911;

	private const int kLeadingZeroesShift = 29;

	private const int kLeadingZeroesBits = 3;

	private const int kMaxLeadingZeroes = 7;

	private const int kLeadingZeroesMask = 7;

	private int LeadingZeroes
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private int PositiveNumericSuffix
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private bool HasPositiveNumericSuffix => false;

	[NotBurstCompatible]
	private string NewString(char c, int count)
	{
		return null;
	}

	[NotBurstCompatible]
	public int ToFixedString<T>(ref T result) where T : IUTF8Bytes, INativeList<byte>
	{
		return 0;
	}

	[NotBurstCompatible]
	public override string ToString()
	{
		return null;
	}

	private bool IsDigit(byte b)
	{
		return false;
	}

	[NotBurstCompatible]
	public void SetString<T>(ref T value) where T : IUTF8Bytes, INativeList<byte>
	{
	}

	[NotBurstCompatible]
	public void SetString(string value)
	{
	}
}
