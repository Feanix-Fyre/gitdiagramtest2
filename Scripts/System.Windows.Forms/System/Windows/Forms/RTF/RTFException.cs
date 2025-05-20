namespace System.Windows.Forms.RTF;

internal class RTFException : ApplicationException
{
	private int pos;

	private int line;

	private TokenClass token_class;

	private Major major;

	private Minor minor;

	private int param;

	private string text;

	private string error_message;

	public override string Message => null;

	public RTFException(RTF rtf, string error_message)
	{
	}
}
