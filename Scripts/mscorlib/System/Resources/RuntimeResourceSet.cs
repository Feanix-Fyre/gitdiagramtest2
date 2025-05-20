using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace System.Resources;

internal sealed class RuntimeResourceSet : ResourceSet, IEnumerable
{
	internal const int Version = 2;

	private Dictionary<string, ResourceLocator> _resCache;

	private ResourceReader _defaultReader;

	private Dictionary<string, ResourceLocator> _caseInsensitiveTable;

	private bool _haveReadFromReader;

	internal RuntimeResourceSet(string fileName)
	{
	}

	internal RuntimeResourceSet(Stream stream)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	public override IDictionaryEnumerator GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	private IDictionaryEnumerator GetEnumeratorHelper()
	{
		return null;
	}

	public override string GetString(string key)
	{
		return null;
	}

	public override string GetString(string key, bool ignoreCase)
	{
		return null;
	}

	public override object GetObject(string key)
	{
		return null;
	}

	public override object GetObject(string key, bool ignoreCase)
	{
		return null;
	}

	private object GetObject(string key, bool ignoreCase, bool isString)
	{
		return null;
	}

	private object ResolveResourceLocator(ResourceLocator resLocation, string key, Dictionary<string, ResourceLocator> copyOfCache, bool keyInWrongCase)
	{
		return null;
	}
}
