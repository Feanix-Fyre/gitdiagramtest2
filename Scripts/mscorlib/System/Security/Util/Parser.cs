namespace System.Security.Util;

internal sealed class Parser
{
	private SecurityDocument _doc;

	private Tokenizer _t;

	internal SecurityElement GetTopElement()
	{
		return null;
	}

	private void GetRequiredSizes(TokenizerStream stream, ref int index)
	{
	}

	private int DetermineFormat(TokenizerStream stream)
	{
		return 0;
	}

	private void ParseContents()
	{
	}

	private Parser(Tokenizer t)
	{
	}

	internal Parser(string input)
	{
	}
}
