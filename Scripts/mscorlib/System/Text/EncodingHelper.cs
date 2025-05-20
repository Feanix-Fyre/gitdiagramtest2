using System.Reflection;

namespace System.Text;

internal static class EncodingHelper
{
	private static Encoding utf8EncodingWithoutMarkers;

	private static readonly object lockobj;

	private static Assembly i18nAssembly;

	private static bool i18nDisabled;

	internal static Encoding UTF8Unmarked => null;

	internal static string InternalCodePage(ref int code_page)
	{
		return null;
	}

	internal static Encoding GetDefaultEncoding()
	{
		return null;
	}

	internal static object InvokeI18N(string name, params object[] args)
	{
		return null;
	}
}
