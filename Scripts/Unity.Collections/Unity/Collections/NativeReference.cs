using System;
using System.Diagnostics;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace Unity.Collections;

[NativeContainer]
[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
public struct NativeReference<T> : INativeDisposable, IDisposable, IEquatable<NativeReference<T>> where T : struct
{
	[NativeContainer]
	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	[NativeContainerIsReadOnly]
	public struct ReadOnly
	{
		[NativeDisableUnsafePtrRestriction]
		private unsafe readonly void* m_Data;

		public T Value => default(T);

		internal unsafe ReadOnly(void* data)
		{
			m_Data = null;
		}
	}

	[NativeDisableUnsafePtrRestriction]
	internal unsafe void* m_Data;

	internal AllocatorManager.AllocatorHandle m_AllocatorLabel;

	public T Value
	{
		get
		{
			return default(T);
		}
		set
		{
		}
	}

	public bool IsCreated => false;

	public unsafe NativeReference(AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.ClearMemory)
	{
		m_Data = null;
		m_AllocatorLabel = default(AllocatorManager.AllocatorHandle);
	}

	public unsafe NativeReference(T value, AllocatorManager.AllocatorHandle allocator)
	{
		m_Data = null;
		m_AllocatorLabel = default(AllocatorManager.AllocatorHandle);
	}

	private static void Allocate(AllocatorManager.AllocatorHandle allocator, out NativeReference<T> reference)
	{
		reference = default(NativeReference<T>);
	}

	public void Dispose()
	{
	}

	[NotBurstCompatible]
	public JobHandle Dispose(JobHandle inputDeps)
	{
		return default(JobHandle);
	}

	public void CopyFrom(NativeReference<T> reference)
	{
	}

	public void CopyTo(NativeReference<T> reference)
	{
	}

	[NotBurstCompatible]
	public bool Equals(NativeReference<T> other)
	{
		return false;
	}

	[NotBurstCompatible]
	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(NativeReference<T> left, NativeReference<T> right)
	{
		return false;
	}

	public static bool operator !=(NativeReference<T> left, NativeReference<T> right)
	{
		return false;
	}

	public static void Copy(NativeReference<T> dst, NativeReference<T> src)
	{
	}

	public ReadOnly AsReadOnly()
	{
		return default(ReadOnly);
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CheckNotDisposed()
	{
	}
}
