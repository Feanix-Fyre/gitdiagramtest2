namespace System.IO.Compression;

internal sealed class DeflateInput
{
	internal readonly struct InputState
	{
		internal readonly int _count;

		internal readonly int _startIndex;

		internal InputState(int count, int startIndex)
		{
			_count = 0;
			_startIndex = 0;
		}
	}

	internal byte[] Buffer { get; set; }

	internal int Count { get; set; }

	internal int StartIndex { get; set; }

	internal void ConsumeBytes(int n)
	{
	}

	internal InputState DumpState()
	{
		return default(InputState);
	}

	internal void RestoreState(InputState state)
	{
	}
}
