namespace System.Net.Cache;

internal class RequestCacheBinding
{
	private RequestCache m_RequestCache;

	private RequestCacheValidator m_CacheValidator;

	private RequestCachePolicy m_Policy;

	internal RequestCache Cache => null;

	internal RequestCacheValidator Validator => null;

	internal RequestCachePolicy Policy => null;

	internal RequestCacheBinding(RequestCache requestCache, RequestCacheValidator cacheValidator, RequestCachePolicy policy)
	{
	}
}
