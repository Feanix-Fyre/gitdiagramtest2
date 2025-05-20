namespace System.Globalization;

internal class HebrewNumber
{
	private enum HebrewToken : short
	{
		Invalid = -1,
		Digit400 = 0,
		Digit200_300 = 1,
		Digit100 = 2,
		Digit10 = 3,
		Digit1 = 4,
		Digit6_7 = 5,
		Digit7 = 6,
		Digit9 = 7,
		SingleQuote = 8,
		DoubleQuote = 9
	}

	private struct HebrewValue
	{
		internal HebrewToken token;

		internal short value;

		internal HebrewValue(HebrewToken token, short value)
		{
			this.token = default(HebrewToken);
			this.value = 0;
		}
	}

	internal enum HS : sbyte
	{
		_err = -1,
		Start = 0,
		S400 = 1,
		S400_400 = 2,
		S400_X00 = 3,
		S400_X0 = 4,
		X00_DQ = 5,
		S400_X00_X0 = 6,
		X0_DQ = 7,
		X = 8,
		X0 = 9,
		X00 = 10,
		S400_DQ = 11,
		S400_400_DQ = 12,
		S400_400_100 = 13,
		S9 = 14,
		X00_S9 = 15,
		S9_DQ = 16,
		END = 100
	}

	private static readonly HebrewValue[] s_hebrewValues;

	private static char s_maxHebrewNumberCh;

	private static readonly HS[] s_numberPasingState;

	internal static string ToString(int Number)
	{
		return null;
	}

	internal static HebrewNumberParsingState ParseByChar(char ch, ref HebrewNumberParsingContext context)
	{
		return default(HebrewNumberParsingState);
	}

	internal static bool IsDigit(char ch)
	{
		return false;
	}
}
