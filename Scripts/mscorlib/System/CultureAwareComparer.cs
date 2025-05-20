using System.Globalization;
using System.Runtime.Serialization;

namespace System;

[Serializable]
public sealed class CultureAwareComparer : StringComparer, ISerializable
{
	private readonly CompareInfo _compareInfo;

	private CompareOptions _options;

	internal CultureAwareComparer(CultureInfo culture, CompareOptions options)
	{
	}

	internal CultureAwareComparer(CompareInfo compareInfo, CompareOptions options)
	{
	}

	private CultureAwareComparer(SerializationInfo info, StreamingContext context)
	{
	}

	public override int Compare(string x, string y)
	{
		return 0;
	}

	public override bool Equals(string x, string y)
	{
		return false;
	}

	public override int GetHashCode(string obj)
	{
		return 0;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}
}
