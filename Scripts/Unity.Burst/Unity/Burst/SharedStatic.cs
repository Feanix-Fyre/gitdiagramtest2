using System;
using System.Diagnostics;

namespace Unity.Burst;

public readonly struct SharedStatic<T> where T : struct
{
	private unsafe readonly void* _buffer;

	private const uint DefaultAlignment = 16u;

	public ref T Data
	{
		get
		{
			throw null;
		}
	}

	public unsafe void* UnsafeDataPointer => null;

	private unsafe SharedStatic(void* buffer)
	{
		_buffer = null;
	}

	public static SharedStatic<T> GetOrCreate<TContext>(uint alignment = 0u)
	{
		return default(SharedStatic<T>);
	}

	public static SharedStatic<T> GetOrCreate<TContext, TSubContext>(uint alignment = 0u)
	{
		return default(SharedStatic<T>);
	}

	public static SharedStatic<T> GetOrCreateUnsafe(uint alignment, long hashCode, long subHashCode)
	{
		return default(SharedStatic<T>);
	}

	public static SharedStatic<T> GetOrCreatePartiallyUnsafeWithHashCode<TSubContext>(uint alignment, long hashCode)
	{
		return default(SharedStatic<T>);
	}

	public static SharedStatic<T> GetOrCreatePartiallyUnsafeWithSubHashCode<TContext>(uint alignment, long subHashCode)
	{
		return default(SharedStatic<T>);
	}

	public static SharedStatic<T> GetOrCreate(Type contextType, uint alignment = 0u)
	{
		return default(SharedStatic<T>);
	}

	public static SharedStatic<T> GetOrCreate(Type contextType, Type subContextType, uint alignment = 0u)
	{
		return default(SharedStatic<T>);
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CheckIf_T_IsUnmanagedOrThrow()
	{
	}
}
internal static class SharedStatic
{
	internal class PreserveAttribute : Attribute
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CheckSizeOf(uint sizeOf)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private unsafe static void CheckResult(void* result)
	{
	}

	[Preserve]
	public unsafe static void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment)
	{
		return null;
	}
}
