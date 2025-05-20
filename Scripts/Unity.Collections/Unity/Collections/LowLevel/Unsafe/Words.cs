using System;

namespace Unity.Collections.LowLevel.Unsafe;

[Obsolete("This storage will no longer be used. (RemovedAfter 2021-06-01)")]
public struct Words
{
	private int Index;

	public void ToFixedString<T>(ref T value) where T : IUTF8Bytes, INativeList<byte>
	{
	}

	public override string ToString()
	{
		return null;
	}

	public void SetFixedString<T>(ref T value) where T : IUTF8Bytes, INativeList<byte>
	{
	}

	public void SetString(string value)
	{
	}
}
