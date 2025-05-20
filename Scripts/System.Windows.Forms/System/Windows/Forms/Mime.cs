using System.Collections;
using System.Collections.Specialized;
using System.IO;

namespace System.Windows.Forms;

internal class Mime
{
	public static Mime Instance;

	private string current_file_name;

	private string global_result;

	private FileStream file_stream;

	private byte[] buffer;

	private StringDictionary mime_file_cache;

	private static object lock_object;

	private bool is_zero_file;

	private int bytes_read;

	private bool mime_available;

	public static NameValueCollection Aliases;

	public static NameValueCollection SubClasses;

	public static NameValueCollection GlobalPatternsShort;

	public static NameValueCollection GlobalPatternsLong;

	public static NameValueCollection GlobalLiterals;

	public static NameValueCollection GlobalSufPref;

	public static ArrayList Matches80Plus;

	public static ArrayList MatchesBelow80;

	public static bool MimeAvailable => false;

	private Mime()
	{
	}

	public static string GetMimeTypeForFile(string filename)
	{
		return null;
	}

	public static string GetMimeAlias(string mimetype)
	{
		return null;
	}

	public static void CleanFileCache()
	{
	}

	private void StartByFileName(string filename)
	{
	}

	private void GoByFileName()
	{
	}

	private bool CheckMatch80Plus()
	{
		return false;
	}

	private bool FastEndsWidth(string input, string value)
	{
		return false;
	}

	private bool FastStartsWith(string input, string value)
	{
		return false;
	}

	private int FastIndexOf(string input, char value)
	{
		return 0;
	}

	private int FastIndexOf(string input, string value)
	{
		return 0;
	}

	private void CheckGlobalResult()
	{
	}

	private bool CheckGlobalPatterns()
	{
		return false;
	}

	private bool CheckMatchBelow80()
	{
		return false;
	}

	private void CheckForBinaryOrText()
	{
	}

	private bool TestMatch(Match match)
	{
		return false;
	}

	private bool TestMatchlet(Matchlet matchlet)
	{
		return false;
	}

	private bool OpenFile()
	{
		return false;
	}
}
