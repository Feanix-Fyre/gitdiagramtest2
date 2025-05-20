using System;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine.Jobs;

namespace UnityEngine.Rendering.Universal;

internal abstract class DecalChunk : IDisposable
{
	public int count { get; protected set; }

	public int capacity { get; protected set; }

	public JobHandle currentJobHandle { get; set; }

	public virtual void Push()
	{
	}

	public abstract void RemoveAtSwapBack(int index);

	public abstract void SetCapacity(int capacity);

	public virtual void Dispose()
	{
	}

	protected void ResizeNativeArray(ref TransformAccessArray array, DecalProjector[] decalProjectors, int capacity)
	{
	}

	protected void RemoveAtSwapBack<T>(ref NativeArray<T> array, int index, int count) where T : struct
	{
	}

	protected void RemoveAtSwapBack<T>(ref T[] array, int index, int count)
	{
	}
}
