namespace System.Net;

internal class WebRequestPrefixElement
{
	public string Prefix;

	internal IWebRequestCreate creator;

	internal Type creatorType;

	public IWebRequestCreate Creator
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public WebRequestPrefixElement(string P, IWebRequestCreate C)
	{
	}
}
