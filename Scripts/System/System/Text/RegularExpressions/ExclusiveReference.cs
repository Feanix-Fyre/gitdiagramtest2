namespace System.Text.RegularExpressions;

internal sealed class ExclusiveReference
{
	private RegexRunner _ref;

	private RegexRunner _obj;

	private int _locked;

	public RegexRunner Get()
	{
		return null;
	}

	public void Release(RegexRunner obj)
	{
	}
}
