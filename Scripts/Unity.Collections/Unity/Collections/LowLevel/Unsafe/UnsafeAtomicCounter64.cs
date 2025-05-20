namespace Unity.Collections.LowLevel.Unsafe;

[BurstCompatible]
public struct UnsafeAtomicCounter64
{
	public unsafe long* Counter;

	public unsafe UnsafeAtomicCounter64(void* ptr)
	{
		Counter = null;
	}

	public void Reset(long value = 0L)
	{
	}

	public long Add(long value)
	{
		return 0L;
	}

	public long Sub(long value)
	{
		return 0L;
	}

	public long AddSat(long value, long max = long.MaxValue)
	{
		return 0L;
	}

	public long SubSat(long value, long min = long.MinValue)
	{
		return 0L;
	}
}
