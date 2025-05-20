namespace Unity.Collections.LowLevel.Unsafe;

[BurstCompatible]
internal struct RingControl
{
	internal readonly int Capacity;

	internal int Current;

	internal int Write;

	internal int Read;

	internal int Length => 0;

	internal RingControl(int capacity)
	{
		Capacity = 0;
		Current = 0;
		Write = 0;
		Read = 0;
	}

	internal void Reset()
	{
	}

	internal int Distance(int from, int to)
	{
		return 0;
	}

	internal int Available()
	{
		return 0;
	}

	internal int Reserve(int count)
	{
		return 0;
	}

	internal int Commit(int count)
	{
		return 0;
	}

	internal int Consume(int count)
	{
		return 0;
	}
}
