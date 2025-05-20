namespace System.Windows.Forms.RTF;

internal class StyleElement
{
	private TokenClass token_class;

	private Major major;

	private Minor minor;

	private int param;

	private string text;

	private StyleElement next;

	public StyleElement(Style s, TokenClass token_class, Major major, Minor minor, int param, string text)
	{
	}
}
