using System.Collections.Generic;

namespace System.Net.Http.Headers;

/// <summary>Represents the value of the Cache-Control header.</summary>
public class CacheControlHeaderValue : ICloneable
{
	private List<NameValueHeaderValue> extensions;

	private List<string> no_cache_headers;

	private List<string> private_headers;

	/// <summary>Cache-extension tokens, each with an optional assigned value.</summary>
	/// <returns>A collection of cache-extension tokens each with an optional assigned value.</returns>
	public ICollection<NameValueHeaderValue> Extensions => null;

	/// <summary>The maximum age, specified in seconds, that the HTTP client is willing to accept a response.</summary>
	/// <returns>The time in seconds.</returns>
	public TimeSpan? MaxAge { get; set; }

	/// <summary>Whether an HTTP client is willing to accept a response that has exceeded its expiration time.</summary>
	/// <returns>
	///   <see langword="true" /> if the HTTP client is willing to accept a response that has exceed the expiration time; otherwise, <see langword="false" />.</returns>
	public bool MaxStale { get; set; }

	/// <summary>The maximum time, in seconds, an HTTP client is willing to accept a response that has exceeded its expiration time.</summary>
	/// <returns>The time in seconds.</returns>
	public TimeSpan? MaxStaleLimit { get; set; }

	/// <summary>The freshness lifetime, in seconds, that an HTTP client is willing to accept a response.</summary>
	/// <returns>The time in seconds.</returns>
	public TimeSpan? MinFresh { get; set; }

	/// <summary>Whether the origin server require revalidation of a cache entry on any subsequent use when the cache entry becomes stale.</summary>
	/// <returns>
	///   <see langword="true" /> if the origin server requires revalidation of a cache entry on any subsequent use when the entry becomes stale; otherwise, <see langword="false" />.</returns>
	public bool MustRevalidate { get; set; }

	/// <summary>Whether an HTTP client is willing to accept a cached response.</summary>
	/// <returns>
	///   <see langword="true" /> if the HTTP client is willing to accept a cached response; otherwise, <see langword="false" />.</returns>
	public bool NoCache { get; set; }

	/// <summary>A collection of fieldnames in the "no-cache" directive in a cache-control header field on an HTTP response.</summary>
	/// <returns>A collection of fieldnames.</returns>
	public ICollection<string> NoCacheHeaders => null;

	/// <summary>Whether a cache must not store any part of either the HTTP request mressage or any response.</summary>
	/// <returns>
	///   <see langword="true" /> if a cache must not store any part of either the HTTP request mressage or any response; otherwise, <see langword="false" />.</returns>
	public bool NoStore { get; set; }

	/// <summary>Whether a cache or proxy must not change any aspect of the entity-body.</summary>
	/// <returns>
	///   <see langword="true" /> if a cache or proxy must not change any aspect of the entity-body; otherwise, <see langword="false" />.</returns>
	public bool NoTransform { get; set; }

	/// <summary>Whether a cache should either respond using a cached entry that is consistent with the other constraints of the HTTP request, or respond with a 504 (Gateway Timeout) status.</summary>
	/// <returns>
	///   <see langword="true" /> if a cache should either respond using a cached entry that is consistent with the other constraints of the HTTP request, or respond with a 504 (Gateway Timeout) status; otherwise, <see langword="false" />.</returns>
	public bool OnlyIfCached { get; set; }

	/// <summary>Whether all or part of the HTTP response message is intended for a single user and must not be cached by a shared cache.</summary>
	/// <returns>
	///   <see langword="true" /> if the HTTP response message is intended for a single user and must not be cached by a shared cache; otherwise, <see langword="false" />.</returns>
	public bool Private { get; set; }

	/// <summary>A collection fieldnames in the "private" directive in a cache-control header field on an HTTP response.</summary>
	/// <returns>A collection of fieldnames.</returns>
	public ICollection<string> PrivateHeaders => null;

	/// <summary>Whether the origin server require revalidation of a cache entry on any subsequent use when the cache entry becomes stale for shared user agent caches.</summary>
	/// <returns>
	///   <see langword="true" /> if the origin server requires revalidation of a cache entry on any subsequent use when the entry becomes stale for shared user agent caches; otherwise, <see langword="false" />.</returns>
	public bool ProxyRevalidate { get; set; }

	/// <summary>Whether an HTTP response may be cached by any cache, even if it would normally be non-cacheable or cacheable only within a non- shared cache.</summary>
	/// <returns>
	///   <see langword="true" /> if the HTTP response may be cached by any cache, even if it would normally be non-cacheable or cacheable only within a non- shared cache; otherwise, <see langword="false" />.</returns>
	public bool Public { get; set; }

	/// <summary>The shared maximum age, specified in seconds, in an HTTP response that overrides the "max-age" directive in a cache-control header or an Expires header for a shared cache.</summary>
	/// <returns>The time in seconds.</returns>
	public TimeSpan? SharedMaxAge { get; set; }

	/// <summary>Creates a new object that is a copy of the current <see cref="T:System.Net.Http.Headers.CacheControlHeaderValue" /> instance.</summary>
	/// <returns>A copy of the current instance.</returns>
	object ICloneable.Clone()
	{
		return null;
	}

	/// <summary>Determines whether the specified <see cref="T:System.Object" /> is equal to the current <see cref="T:System.Net.Http.Headers.CacheControlHeaderValue" /> object.</summary>
	/// <param name="obj">The object to compare with the current object.</param>
	/// <returns>
	///   <see langword="true" /> if the specified <see cref="T:System.Object" /> is equal to the current object; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		return false;
	}

	/// <summary>Serves as a hash function for a  <see cref="T:System.Net.Http.Headers.CacheControlHeaderValue" /> object.</summary>
	/// <returns>A hash code for the current object.</returns>
	public override int GetHashCode()
	{
		return 0;
	}

	/// <summary>Determines whether a string is valid <see cref="T:System.Net.Http.Headers.CacheControlHeaderValue" /> information.</summary>
	/// <param name="input">The string to validate.</param>
	/// <param name="parsedValue">The <see cref="T:System.Net.Http.Headers.CacheControlHeaderValue" /> version of the string.</param>
	/// <returns>
	///   <see langword="true" /> if <paramref name="input" /> is valid <see cref="T:System.Net.Http.Headers.CacheControlHeaderValue" /> information; otherwise, <see langword="false" />.</returns>
	public static bool TryParse(string input, out CacheControlHeaderValue parsedValue)
	{
		parsedValue = null;
		return false;
	}

	/// <summary>Returns a string that represents the current <see cref="T:System.Net.Http.Headers.CacheControlHeaderValue" /> object.</summary>
	/// <returns>A string that represents the current object.</returns>
	public override string ToString()
	{
		return null;
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Net.Http.Headers.CacheControlHeaderValue" /> class.</summary>
	public CacheControlHeaderValue()
	{
	}
}
