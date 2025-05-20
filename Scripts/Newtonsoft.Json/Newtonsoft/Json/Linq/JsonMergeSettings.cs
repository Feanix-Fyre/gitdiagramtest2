using System;

namespace Newtonsoft.Json.Linq;

public class JsonMergeSettings
{
	private MergeArrayHandling _mergeArrayHandling;

	private MergeNullValueHandling _mergeNullValueHandling;

	private StringComparison _propertyNameComparison;

	public MergeArrayHandling MergeArrayHandling
	{
		get
		{
			return default(MergeArrayHandling);
		}
		set
		{
		}
	}

	public MergeNullValueHandling MergeNullValueHandling
	{
		get
		{
			return default(MergeNullValueHandling);
		}
		set
		{
		}
	}

	public StringComparison PropertyNameComparison
	{
		get
		{
			return default(StringComparison);
		}
		set
		{
		}
	}
}
