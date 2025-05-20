using System.Runtime.CompilerServices;

namespace System.Buffers;

internal sealed class TlsOverPerCoreLockedStacksArrayPool<T> : ArrayPool<T>
{
	private enum MemoryPressure
	{
		Low = 0,
		Medium = 1,
		High = 2
	}

	private sealed class PerCoreLockedStacks
	{
		private readonly LockedStack[] _perCoreStacks;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void TryPush(T[] array)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T[] TryPop()
		{
			return null;
		}

		public bool Trim(uint tickCount, int id, MemoryPressure pressure, int[] bucketSizes)
		{
			return false;
		}
	}

	private sealed class LockedStack
	{
		private readonly T[][] _arrays;

		private int _count;

		private uint _firstStackItemMS;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryPush(T[] array)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public T[] TryPop()
		{
			return null;
		}

		public void Trim(uint tickCount, int id, MemoryPressure pressure, int bucketSize)
		{
		}
	}

	private readonly int[] _bucketArraySizes;

	private readonly PerCoreLockedStacks[] _buckets;

	[ThreadStatic]
	private static T[][] t_tlsBuckets;

	private int _callbackCreated;

	private static readonly bool s_trimBuffers;

	private static readonly ConditionalWeakTable<T[][], object> s_allTlsBuckets;

	private int Id => 0;

	private PerCoreLockedStacks CreatePerCoreLockedStacks(int bucketIndex)
	{
		return null;
	}

	public override T[] Rent(int minimumLength)
	{
		return null;
	}

	public override void Return(T[] array, bool clearArray = false)
	{
	}

	public bool Trim()
	{
		return false;
	}

	private static bool Gen2GcCallbackFunc(object target)
	{
		return false;
	}

	private static MemoryPressure GetMemoryPressure()
	{
		return default(MemoryPressure);
	}

	private static bool GetTrimBuffers()
	{
		return false;
	}
}
