namespace System.Net.Http.Headers;

internal static class Parser
{
	public static class Token
	{
		public static void Check(string s)
		{
		}

		public static bool TryCheck(string s)
		{
			return false;
		}
	}

	public static class DateTime
	{
		public new static readonly Func<object, string> ToString;

		public static bool TryParse(string input, out DateTimeOffset result)
		{
			result = default(DateTimeOffset);
			return false;
		}
	}

	public static class EmailAddress
	{
		public static bool TryParse(string input, out string result)
		{
			result = null;
			return false;
		}
	}

	public static class Host
	{
		public static bool TryParse(string input, out string result)
		{
			result = null;
			return false;
		}
	}

	public static class Int
	{
		public static bool TryParse(string input, out int result)
		{
			result = default(int);
			return false;
		}
	}

	public static class Long
	{
		public static bool TryParse(string input, out long result)
		{
			result = default(long);
			return false;
		}
	}

	public static class MD5
	{
		public new static readonly Func<object, string> ToString;

		public static bool TryParse(string input, out byte[] result)
		{
			result = null;
			return false;
		}
	}

	public static class TimeSpanSeconds
	{
		public static bool TryParse(string input, out TimeSpan result)
		{
			result = default(TimeSpan);
			return false;
		}
	}

	public static class Uri
	{
		public static bool TryParse(string input, out System.Uri result)
		{
			result = null;
			return false;
		}
	}
}
