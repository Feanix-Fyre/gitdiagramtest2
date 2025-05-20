using System;
using Unity.Jobs;

namespace Unity.Collections;

[BurstCompatible(GenericTypeArguments = new Type[]
{
	typeof(int),
	typeof(int)
})]
public struct NativeKeyValueArrays<TKey, TValue> : INativeDisposable, IDisposable where TKey : struct where TValue : struct
{
	public NativeArray<TKey> Keys;

	public NativeArray<TValue> Values;

	public int Length => 0;

	public NativeKeyValueArrays(int length, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options)
	{
		Keys = default(NativeArray<TKey>);
		Values = default(NativeArray<TValue>);
	}

	public void Dispose()
	{
	}

	[NotBurstCompatible]
	public JobHandle Dispose(JobHandle inputDeps)
	{
		return default(JobHandle);
	}
}
