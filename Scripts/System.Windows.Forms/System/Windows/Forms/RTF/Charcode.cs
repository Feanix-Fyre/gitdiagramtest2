using System.Collections;

namespace System.Windows.Forms.RTF;

internal class Charcode
{
	private StandardCharCode[] codes;

	private Hashtable reverse;

	private int size;

	private static Charcode ansi_generic;

	public StandardCharCode this[int c]
	{
		get
		{
			return default(StandardCharCode);
		}
		private set
		{
		}
	}

	public static Charcode AnsiGeneric => null;

	public static Charcode AnsiSymbol => null;

	private Charcode(int size)
	{
	}
}
