using System;
using System.Diagnostics;

namespace Unity.Collections.LowLevel.Unsafe;

[Obsolete("This storage will no longer be used. (RemovedAfter 2021-06-01)")]
[DebuggerTypeProxy(typeof(WordStorageDebugView))]
public struct WordStorage
{
	private struct Entry
	{
		public int offset;

		public int length;
	}

	private NativeArray<byte> buffer;

	private NativeArray<Entry> entry;

	private NativeParallelMultiHashMap<int, int> hash;

	private int chars;

	private int entries;

	private const int kMaxEntries = 16384;

	private const int kMaxChars = 2097152;

	public const int kMaxCharsPerEntry = 4096;

	[NotBurstCompatible]
	public static ref WordStorage Instance
	{
		get
		{
			throw null;
		}
	}

	public int Entries => 0;

	[NotBurstCompatible]
	public static void Initialize()
	{
	}

	[NotBurstCompatible]
	public static void Shutdown()
	{
	}

	[NotBurstCompatible]
	public static void Clear()
	{
	}

	[NotBurstCompatible]
	public static void Setup()
	{
	}

	public void GetFixedString<T>(int index, ref T temp) where T : IUTF8Bytes, INativeList<byte>
	{
	}

	public int GetIndexFromHashAndFixedString<T>(int h, ref T temp) where T : IUTF8Bytes, INativeList<byte>
	{
		return 0;
	}

	public bool Contains<T>(ref T value) where T : IUTF8Bytes, INativeList<byte>
	{
		return false;
	}

	[NotBurstCompatible]
	public bool Contains(string value)
	{
		return false;
	}

	public int GetOrCreateIndex<T>(ref T value) where T : IUTF8Bytes, INativeList<byte>
	{
		return 0;
	}
}
