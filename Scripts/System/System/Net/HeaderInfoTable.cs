using System.Collections;

namespace System.Net;

internal class HeaderInfoTable
{
	private static Hashtable HeaderHashTable;

	private static HeaderInfo UnknownHeaderInfo;

	private static HeaderParser SingleParser;

	private static HeaderParser MultiParser;

	internal HeaderInfo this[string name] => null;

	private static string[] ParseSingleValue(string value)
	{
		return null;
	}

	private static string[] ParseMultiValue(string value)
	{
		return null;
	}

	static HeaderInfoTable()
	{
	}
}
