using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Unity.Collections;

[StructLayout((LayoutKind)0, Size = 1)]
[BurstCompatible]
internal struct Memory
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[BurstCompatible]
	internal struct Unmanaged
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[BurstCompatible]
		internal struct Array
		{
			private static bool IsCustom(AllocatorManager.AllocatorHandle allocator)
			{
				return false;
			}

			private unsafe static void* CustomResize(void* oldPointer, long oldCount, long newCount, AllocatorManager.AllocatorHandle allocator, long size, int align)
			{
				return null;
			}

			internal unsafe static void* Resize(void* oldPointer, long oldCount, long newCount, AllocatorManager.AllocatorHandle allocator, long size, int align)
			{
				return null;
			}

			[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
			internal unsafe static T* Resize<T>(T* oldPointer, long oldCount, long newCount, AllocatorManager.AllocatorHandle allocator) where T : unmanaged
			{
				return null;
			}

			[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
			internal unsafe static T* Allocate<T>(long count, AllocatorManager.AllocatorHandle allocator) where T : unmanaged
			{
				return null;
			}

			[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
			internal unsafe static void Free<T>(T* pointer, long count, AllocatorManager.AllocatorHandle allocator) where T : unmanaged
			{
			}
		}

		internal unsafe static void* Allocate(long size, int align, AllocatorManager.AllocatorHandle allocator)
		{
			return null;
		}

		internal unsafe static void Free(void* pointer, AllocatorManager.AllocatorHandle allocator)
		{
		}

		[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
		internal unsafe static T* Allocate<T>(AllocatorManager.AllocatorHandle allocator) where T : unmanaged
		{
			return null;
		}

		[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
		internal unsafe static void Free<T>(T* pointer, AllocatorManager.AllocatorHandle allocator) where T : unmanaged
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[BurstCompatible]
	internal struct Array
	{
		[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
		internal unsafe static void Set<T>(T* pointer, long count, T t = default(T)) where T : unmanaged
		{
		}

		[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
		internal unsafe static void Clear<T>(T* pointer, long count) where T : unmanaged
		{
		}

		[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
		internal unsafe static void Copy<T>(T* dest, T* src, long count) where T : unmanaged
		{
		}
	}

	internal const long k_MaximumRamSizeInBytes = 1099511627776L;

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	internal static void CheckByteCountIsReasonable(long size)
	{
	}
}
