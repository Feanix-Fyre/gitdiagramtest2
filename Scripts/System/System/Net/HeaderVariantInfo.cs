namespace System.Net;

internal struct HeaderVariantInfo
{
	private string m_name;

	private CookieVariant m_variant;

	internal string Name => null;

	internal CookieVariant Variant => default(CookieVariant);

	internal HeaderVariantInfo(string name, CookieVariant variant)
	{
		m_name = null;
		m_variant = default(CookieVariant);
	}
}
