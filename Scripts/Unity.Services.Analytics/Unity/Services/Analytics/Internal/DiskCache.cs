using System.Collections.Generic;
using System.IO;

namespace Unity.Services.Analytics.Internal;

internal class DiskCache : IDiskCache
{
	internal const string k_FileHeaderString = "UGSEventCache";

	internal const int k_CacheFileVersionOne = 1;

	internal const int k_CacheFileVersionTwo = 2;

	private readonly string k_CacheFilePath;

	private readonly IFileSystemCalls k_SystemCalls;

	private readonly long k_CacheFileMaximumSize;

	internal DiskCache(IFileSystemCalls systemCalls)
	{
	}

	internal DiskCache(string cacheFilePath, IFileSystemCalls systemCalls, long maximumFileSize)
	{
	}

	public void Write(List<EventSummary> eventSummaries, Stream payload)
	{
	}

	public void Clear()
	{
	}

	public bool Read(List<EventSummary> eventSummaries, Stream buffer)
	{
		return false;
	}

	private void ReadVersionOneCacheFile(in List<EventSummary> eventEndIndices, BinaryReader reader, in Stream buffer)
	{
	}

	private void ReadVersionTwoCacheFile(in List<EventSummary> eventSummaries, BinaryReader reader, in Stream buffer)
	{
	}
}
