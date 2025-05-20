namespace System.Windows.Forms.RTF;

internal class Charset
{
	private CharsetType id;

	private CharsetFlags flags;

	private Charcode code;

	private string file;

	public CharsetFlags Flags => default(CharsetFlags);

	public CharsetType ID
	{
		set
		{
		}
	}

	public StandardCharCode this[int c] => default(StandardCharCode);

	public bool ReadMap()
	{
		return false;
	}
}
