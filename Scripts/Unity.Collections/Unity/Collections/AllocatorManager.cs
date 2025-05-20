using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AOT;
using Unity.Burst;

namespace Unity.Collections;

public static class AllocatorManager
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate int TryFunction(IntPtr allocatorState, ref Block block);

	public struct AllocatorHandle : IAllocator, IDisposable
	{
		public ushort Index;

		public ushort Version;

		internal ref TableEntry TableEntry
		{
			get
			{
				throw null;
			}
		}

		internal bool IsInstalled => false;

		public int Value => 0;

		public TryFunction Function => null;

		public AllocatorHandle Handle
		{
			get
			{
				return default(AllocatorHandle);
			}
			set
			{
			}
		}

		public Allocator ToAllocator => default(Allocator);

		public bool IsCustomAllocator => false;

		internal void IncrementVersion()
		{
		}

		internal void Rewind()
		{
		}

		internal void Install(TableEntry tableEntry)
		{
		}

		public static implicit operator AllocatorHandle(Allocator a)
		{
			return default(AllocatorHandle);
		}

		public int TryAllocateBlock<T>(out Block block, int items) where T : struct
		{
			block = default(Block);
			return 0;
		}

		public Block AllocateBlock<T>(int items) where T : struct
		{
			return default(Block);
		}

		[Conditional("ENABLE_UNITY_ALLOCATION_CHECKS")]
		private static void CheckAllocatedSuccessfully(int error)
		{
		}

		public int Try(ref Block block)
		{
			return 0;
		}

		public void Dispose()
		{
		}
	}

	public struct BlockHandle
	{
		public ushort Value;
	}

	public struct Range : IDisposable
	{
		public IntPtr Pointer;

		public int Items;

		public AllocatorHandle Allocator;

		public void Dispose()
		{
		}
	}

	public struct Block : IDisposable
	{
		public Range Range;

		public int BytesPerItem;

		public int AllocatedItems;

		public byte Log2Alignment;

		public byte Padding0;

		public ushort Padding1;

		public uint Padding2;

		public long Bytes => 0L;

		public long AllocatedBytes => 0L;

		public int Alignment
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public void Dispose()
		{
		}

		public int TryAllocate()
		{
			return 0;
		}

		public int TryFree()
		{
			return 0;
		}

		public void Allocate()
		{
		}

		public void Free()
		{
		}

		[Conditional("ENABLE_UNITY_ALLOCATION_CHECKS")]
		private void CheckFailedToAllocate(int error)
		{
		}

		[Conditional("ENABLE_UNITY_ALLOCATION_CHECKS")]
		private void CheckFailedToFree(int error)
		{
		}
	}

	public interface IAllocator : IDisposable
	{
		TryFunction Function { get; }

		AllocatorHandle Handle { get; set; }

		Allocator ToAllocator { get; }

		bool IsCustomAllocator { get; }

		int Try(ref Block block);
	}

	[BurstCompile(CompileSynchronously = true)]
	internal struct StackAllocator : IAllocator, IDisposable
	{
		public delegate int Try_000000A2_0024PostfixBurstDelegate(IntPtr allocatorState, ref Block block);

		internal static class Try_000000A2_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			private static IntPtr DeferredCompilation;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static void Constructor()
			{
			}

			public static void Initialize()
			{
			}

			public static int Invoke(IntPtr allocatorState, ref Block block)
			{
				return 0;
			}
		}

		internal AllocatorHandle m_handle;

		internal Block m_storage;

		internal long m_top;

		public AllocatorHandle Handle
		{
			get
			{
				return default(AllocatorHandle);
			}
			set
			{
			}
		}

		public Allocator ToAllocator => default(Allocator);

		public bool IsCustomAllocator => false;

		public TryFunction Function => null;

		public void Initialize(Block storage)
		{
		}

		public int Try(ref Block block)
		{
			return 0;
		}

		[BurstCompile(CompileSynchronously = true)]
		[MonoPInvokeCallback(typeof(TryFunction))]
		public static int Try(IntPtr allocatorState, ref Block block)
		{
			return 0;
		}

		public void Dispose()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile(CompileSynchronously = true)]
		[MonoPInvokeCallback(typeof(TryFunction))]
		public static int Try_0024BurstManaged(IntPtr allocatorState, ref Block block)
		{
			return 0;
		}
	}

	[BurstCompile(CompileSynchronously = true)]
	internal struct SlabAllocator : IAllocator, IDisposable
	{
		public delegate int Try_000000B0_0024PostfixBurstDelegate(IntPtr allocatorState, ref Block block);

		internal static class Try_000000B0_0024BurstDirectCall
		{
			private static IntPtr Pointer;

			private static IntPtr DeferredCompilation;

			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr P_0)
			{
			}

			private static IntPtr GetFunctionPointer()
			{
				return (IntPtr)0;
			}

			public static void Constructor()
			{
			}

			public static void Initialize()
			{
			}

			public static int Invoke(IntPtr allocatorState, ref Block block)
			{
				return 0;
			}
		}

		internal AllocatorHandle m_handle;

		internal Block Storage;

		internal int Log2SlabSizeInBytes;

		internal FixedList4096Bytes<int> Occupied;

		internal long budgetInBytes;

		internal long allocatedBytes;

		public AllocatorHandle Handle
		{
			get
			{
				return default(AllocatorHandle);
			}
			set
			{
			}
		}

		public Allocator ToAllocator => default(Allocator);

		public bool IsCustomAllocator => false;

		public long BudgetInBytes => 0L;

		public long AllocatedBytes => 0L;

		internal int SlabSizeInBytes
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal int Slabs => 0;

		public TryFunction Function => null;

		internal void Initialize(Block storage, int slabSizeInBytes, long budget)
		{
		}

		public int Try(ref Block block)
		{
			return 0;
		}

		[MonoPInvokeCallback(typeof(TryFunction))]
		[BurstCompile(CompileSynchronously = true)]
		public static int Try(IntPtr allocatorState, ref Block block)
		{
			return 0;
		}

		public void Dispose()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[BurstCompile(CompileSynchronously = true)]
		[MonoPInvokeCallback(typeof(TryFunction))]
		public static int Try_0024BurstManaged(IntPtr allocatorState, ref Block block)
		{
			return 0;
		}
	}

	internal struct TableEntry
	{
		internal IntPtr function;

		internal IntPtr state;
	}

	internal struct Array16<T> where T : struct
	{
		internal T f0;

		internal T f1;

		internal T f2;

		internal T f3;

		internal T f4;

		internal T f5;

		internal T f6;

		internal T f7;

		internal T f8;

		internal T f9;

		internal T f10;

		internal T f11;

		internal T f12;

		internal T f13;

		internal T f14;

		internal T f15;
	}

	internal struct Array256<T> where T : struct
	{
		internal Array16<T> f0;

		internal Array16<T> f1;

		internal Array16<T> f2;

		internal Array16<T> f3;

		internal Array16<T> f4;

		internal Array16<T> f5;

		internal Array16<T> f6;

		internal Array16<T> f7;

		internal Array16<T> f8;

		internal Array16<T> f9;

		internal Array16<T> f10;

		internal Array16<T> f11;

		internal Array16<T> f12;

		internal Array16<T> f13;

		internal Array16<T> f14;

		internal Array16<T> f15;
	}

	internal struct Array4096<T> where T : struct
	{
		internal Array256<T> f0;

		internal Array256<T> f1;

		internal Array256<T> f2;

		internal Array256<T> f3;

		internal Array256<T> f4;

		internal Array256<T> f5;

		internal Array256<T> f6;

		internal Array256<T> f7;

		internal Array256<T> f8;

		internal Array256<T> f9;

		internal Array256<T> f10;

		internal Array256<T> f11;

		internal Array256<T> f12;

		internal Array256<T> f13;

		internal Array256<T> f14;

		internal Array256<T> f15;
	}

	internal struct Array32768<T> : IIndexable<T> where T : struct
	{
		internal Array4096<T> f0;

		internal Array4096<T> f1;

		internal Array4096<T> f2;

		internal Array4096<T> f3;

		internal Array4096<T> f4;

		internal Array4096<T> f5;

		internal Array4096<T> f6;

		internal Array4096<T> f7;

		public int Length
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public ref T ElementAt(int index)
		{
			throw null;
		}
	}

	internal sealed class SharedStatics
	{
		internal sealed class IsInstalled
		{
			internal static readonly SharedStatic<Long1024> Ref;
		}

		internal sealed class TableEntry
		{
			internal static readonly SharedStatic<Array32768<AllocatorManager.TableEntry>> Ref;
		}
	}

	internal static class Managed
	{
		internal const int kMaxNumCustomAllocator = 32768;

		internal static TryFunction[] TryFunctionDelegates;

		[NotBurstCompatible]
		public static void RegisterDelegate(int index, TryFunction function)
		{
		}

		[NotBurstCompatible]
		public static void UnregisterDelegate(int index)
		{
		}
	}

	public static readonly AllocatorHandle Invalid;

	public static readonly AllocatorHandle None;

	public static readonly AllocatorHandle Temp;

	public static readonly AllocatorHandle TempJob;

	public static readonly AllocatorHandle Persistent;

	public static readonly AllocatorHandle AudioKernel;

	public const int kErrorNone = 0;

	public const int kErrorBufferOverflow = -1;

	public const ushort FirstUserIndex = 64;

	internal static Block AllocateBlock<T>(this ref T t, int sizeOf, int alignOf, int items) where T : struct, IAllocator
	{
		return default(Block);
	}

	internal static Block AllocateBlock<T, U>(this ref T t, U u, int items) where T : struct, IAllocator where U : struct
	{
		return default(Block);
	}

	internal unsafe static void* Allocate<T>(this ref T t, int sizeOf, int alignOf, int items) where T : struct, IAllocator
	{
		return null;
	}

	internal unsafe static U* Allocate<T, U>(this ref T t, U u, int items) where T : struct, IAllocator where U : unmanaged
	{
		return null;
	}

	internal unsafe static void* AllocateStruct<T, U>(this ref T t, U u, int items) where T : struct, IAllocator where U : struct
	{
		return null;
	}

	internal static void FreeBlock<T>(this ref T t, ref Block block) where T : struct, IAllocator
	{
	}

	internal unsafe static void Free<T>(this ref T t, void* pointer, int sizeOf, int alignOf, int items) where T : struct, IAllocator
	{
	}

	internal unsafe static void Free<T, U>(this ref T t, U* pointer, int items) where T : struct, IAllocator where U : unmanaged
	{
	}

	public unsafe static void* Allocate(AllocatorHandle handle, int itemSizeInBytes, int alignmentInBytes, int items = 1)
	{
		return null;
	}

	public unsafe static T* Allocate<T>(AllocatorHandle handle, int items = 1) where T : unmanaged
	{
		return null;
	}

	public unsafe static void Free(AllocatorHandle handle, void* pointer, int itemSizeInBytes, int alignmentInBytes, int items = 1)
	{
	}

	public unsafe static void Free(AllocatorHandle handle, void* pointer)
	{
	}

	public unsafe static void Free<T>(AllocatorHandle handle, T* pointer, int items = 1) where T : unmanaged
	{
	}

	[BurstDiscard]
	private static void CheckDelegate(ref bool useDelegate)
	{
	}

	private static bool UseDelegate()
	{
		return false;
	}

	private static int allocate_block(ref Block block)
	{
		return 0;
	}

	[BurstDiscard]
	private static void forward_mono_allocate_block(ref Block block, ref int error)
	{
	}

	internal static Allocator LegacyOf(AllocatorHandle handle)
	{
		return default(Allocator);
	}

	private static int TryLegacy(ref Block block)
	{
		return 0;
	}

	public static int Try(ref Block block)
	{
		return 0;
	}

	public static void Initialize()
	{
	}

	internal static void Install(AllocatorHandle handle, IntPtr allocatorState, FunctionPointer<TryFunction> functionPointer, TryFunction function)
	{
	}

	internal static void Install(AllocatorHandle handle, IntPtr allocatorState, TryFunction function)
	{
	}

	internal static AllocatorHandle Register(IntPtr allocatorState, FunctionPointer<TryFunction> functionPointer)
	{
		return default(AllocatorHandle);
	}

	[NotBurstCompatible]
	public static void Register<T>(this ref T t) where T : struct, IAllocator
	{
	}

	public static void UnmanagedUnregister<T>(this ref T t) where T : struct, IAllocator
	{
	}

	[NotBurstCompatible]
	public static void Unregister<T>(this ref T t) where T : struct, IAllocator
	{
	}

	[NotBurstCompatible]
	internal static ref T CreateAllocator<T>(AllocatorHandle backingAllocator) where T : struct, IAllocator
	{
		throw null;
	}

	[NotBurstCompatible]
	internal static void DestroyAllocator<T>(this ref T t, AllocatorHandle backingAllocator) where T : struct, IAllocator
	{
	}

	public static void Shutdown()
	{
	}

	internal static bool IsCustomAllocator(AllocatorHandle allocator)
	{
		return false;
	}

	[Conditional("ENABLE_UNITY_ALLOCATION_CHECKS")]
	internal static void CheckFailedToAllocate(int error)
	{
	}

	[Conditional("ENABLE_UNITY_ALLOCATION_CHECKS")]
	internal static void CheckFailedToFree(int error)
	{
	}

	[Conditional("ENABLE_UNITY_ALLOCATION_CHECKS")]
	internal static void CheckValid(AllocatorHandle handle)
	{
	}

	public static void Initialize_0024StackAllocator_Try_000000A2_0024BurstDirectCall()
	{
	}

	public static void Initialize_0024SlabAllocator_Try_000000B0_0024BurstDirectCall()
	{
	}
}
