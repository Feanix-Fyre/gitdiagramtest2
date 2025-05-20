namespace System.Globalization;

internal class Bootstring
{
	private readonly char delimiter;

	private readonly int base_num;

	private readonly int tmin;

	private readonly int tmax;

	private readonly int skew;

	private readonly int damp;

	private readonly int initial_bias;

	private readonly int initial_n;

	public Bootstring(char delimiter, int baseNum, int tmin, int tmax, int skew, int damp, int initialBias, int initialN)
	{
	}

	public string Encode(string s, int offset)
	{
		return null;
	}

	private char EncodeDigit(int d)
	{
		return '\0';
	}

	private int DecodeDigit(char c)
	{
		return 0;
	}

	private int Adapt(int delta, int numPoints, bool firstTime)
	{
		return 0;
	}

	public string Decode(string s, int offset)
	{
		return null;
	}
}
