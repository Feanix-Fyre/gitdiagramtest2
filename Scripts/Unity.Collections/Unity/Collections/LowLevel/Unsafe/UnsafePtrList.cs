using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.Jobs;

namespace Unity.Collections.LowLevel.Unsafe;

[Obsolete("Untyped UnsafePtrList is deprecated, please use UnsafePtrList<T> instead. (RemovedAfter 2021-05-18)", false)]
[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
[DebuggerTypeProxy(typeof(UnsafePtrListDebugView))]
public struct UnsafePtrList : INativeDisposable, IDisposable, INativeList<IntPtr>, IIndexable<IntPtr>, IEnumerable<IntPtr>, IEnumerable
{
	public struct ParallelReader
	{
		[NativeDisableUnsafePtrRestriction]
		public unsafe readonly void** Ptr;

		public readonly int Length;

		internal unsafe ParallelReader(void** ptr, int length)
		{
			Ptr = null;
			Length = 0;
		}

		public unsafe int IndexOf(void* value)
		{
			return 0;
		}

		public unsafe bool Contains(void* value)
		{
			return false;
		}
	}

	public struct ParallelWriter
	{
		[NativeDisableUnsafePtrRestriction]
		public unsafe readonly void* Ptr;

		[NativeDisableUnsafePtrRestriction]
		public unsafe UnsafeList* ListData;

		internal unsafe ParallelWriter(void* ptr, UnsafeList* listData)
		{
			Ptr = null;
			ListData = null;
		}

		public unsafe void AddNoResize(void* value)
		{
		}

		public unsafe void AddRangeNoResize(void** ptr, int length)
		{
		}

		public void AddRangeNoResize(UnsafePtrList list)
		{
		}
	}

	[NativeDisableUnsafePtrRestriction]
	public unsafe readonly void** Ptr;

	public readonly int length;

	public readonly int unused;

	public readonly int capacity;

	public readonly AllocatorManager.AllocatorHandle Allocator;

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

	public int Capacity
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public IntPtr this[int index]
	{
		get
		{
			return (IntPtr)0;
		}
		set
		{
		}
	}

	public bool IsEmpty => false;

	public bool IsCreated => false;

	public ref IntPtr ElementAt(int index)
	{
		throw null;
	}

	public unsafe UnsafePtrList(void** ptr, int length)
	{
		Ptr = null;
		this.length = 0;
		unused = 0;
		capacity = 0;
		Allocator = default(AllocatorManager.AllocatorHandle);
	}

	public unsafe UnsafePtrList(int initialCapacity, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory)
	{
		Ptr = null;
		length = 0;
		unused = 0;
		capacity = 0;
		Allocator = default(AllocatorManager.AllocatorHandle);
	}

	public unsafe UnsafePtrList(int initialCapacity, Allocator allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory)
	{
		Ptr = null;
		length = 0;
		unused = 0;
		capacity = 0;
		Allocator = default(AllocatorManager.AllocatorHandle);
	}

	public unsafe static UnsafePtrList* Create(void** ptr, int length)
	{
		return null;
	}

	public unsafe static UnsafePtrList* Create(int initialCapacity, Allocator allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory)
	{
		return null;
	}

	public unsafe static void Destroy(UnsafePtrList* listData)
	{
	}

	public void Dispose()
	{
	}

	[NotBurstCompatible]
	public JobHandle Dispose(JobHandle inputDeps)
	{
		return default(JobHandle);
	}

	public void Clear()
	{
	}

	public void Resize(int length, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory)
	{
	}

	public void SetCapacity(int capacity)
	{
	}

	public void TrimExcess()
	{
	}

	public unsafe int IndexOf(void* value)
	{
		return 0;
	}

	public unsafe bool Contains(void* value)
	{
		return false;
	}

	public unsafe void AddNoResize(void* value)
	{
	}

	public unsafe void AddRangeNoResize(void** ptr, int length)
	{
	}

	public void AddRangeNoResize(UnsafePtrList list)
	{
	}

	public void Add(in IntPtr value)
	{
	}

	public unsafe void Add(void* value)
	{
	}

	public unsafe void AddRange(void* ptr, int length)
	{
	}

	public void AddRange(UnsafePtrList list)
	{
	}

	public void InsertRangeWithBeginEnd(int begin, int end)
	{
	}

	public void RemoveAtSwapBack(int index)
	{
	}

	public void RemoveRangeSwapBackWithBeginEnd(int begin, int end)
	{
	}

	public void RemoveAt(int index)
	{
	}

	public void RemoveRangeWithBeginEnd(int begin, int end)
	{
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	IEnumerator<IntPtr> IEnumerable<IntPtr>.GetEnumerator()
	{
		return null;
	}

	public ParallelReader AsParallelReader()
	{
		return default(ParallelReader);
	}

	public ParallelWriter AsParallelWriter()
	{
		return default(ParallelWriter);
	}
}
[DebuggerTypeProxy(typeof(UnsafePtrListTDebugView<>))]
[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
public struct UnsafePtrList<T> : INativeDisposable, IDisposable, IEnumerable<IntPtr>, IEnumerable where T : unmanaged
{
	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public struct ParallelReader
	{
		[NativeDisableUnsafePtrRestriction]
		public unsafe readonly T** Ptr;

		public readonly int Length;

		internal unsafe ParallelReader(T** ptr, int length)
		{
			Ptr = null;
			Length = 0;
		}

		public unsafe int IndexOf(void* ptr)
		{
			return 0;
		}

		public unsafe bool Contains(void* ptr)
		{
			return false;
		}
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public struct ParallelWriter
	{
		[NativeDisableUnsafePtrRestriction]
		public unsafe readonly T** Ptr;

		[NativeDisableUnsafePtrRestriction]
		public unsafe UnsafeList<IntPtr>* ListData;

		internal unsafe ParallelWriter(T** ptr, UnsafeList<IntPtr>* listData)
		{
			Ptr = null;
			ListData = null;
		}

		public unsafe void AddNoResize(T* value)
		{
		}

		public unsafe void AddRangeNoResize(T** ptr, int count)
		{
		}

		public void AddRangeNoResize(UnsafePtrList<T> list)
		{
		}
	}

	[NativeDisableUnsafePtrRestriction]
	public unsafe readonly T** Ptr;

	public readonly int m_length;

	public readonly int m_capacity;

	public readonly AllocatorManager.AllocatorHandle Allocator;

	[Obsolete("Use Length property (UnityUpgradable) -> Length", true)]
	public int length;

	[Obsolete("Use Capacity property (UnityUpgradable) -> Capacity", true)]
	public int capacity;

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

	public int Capacity
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public unsafe T* this[int index]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool IsEmpty => false;

	public bool IsCreated => false;

	public unsafe ref T* ElementAt(int index)
	{
		throw null;
	}

	public unsafe UnsafePtrList(T** ptr, int length)
	{
		Ptr = null;
		m_length = 0;
		m_capacity = 0;
		Allocator = default(AllocatorManager.AllocatorHandle);
		this.length = 0;
		capacity = 0;
	}

	public unsafe UnsafePtrList(int initialCapacity, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory)
	{
		Ptr = null;
		m_length = 0;
		m_capacity = 0;
		Allocator = default(AllocatorManager.AllocatorHandle);
		length = 0;
		capacity = 0;
	}

	public unsafe static UnsafePtrList<T>* Create(T** ptr, int length)
	{
		return null;
	}

	public unsafe static UnsafePtrList<T>* Create(int initialCapacity, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory)
	{
		return null;
	}

	public unsafe static void Destroy(UnsafePtrList<T>* listData)
	{
	}

	public void Dispose()
	{
	}

	[NotBurstCompatible]
	public JobHandle Dispose(JobHandle inputDeps)
	{
		return default(JobHandle);
	}

	public void Clear()
	{
	}

	public void Resize(int length, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory)
	{
	}

	public void SetCapacity(int capacity)
	{
	}

	public void TrimExcess()
	{
	}

	public unsafe int IndexOf(void* ptr)
	{
		return 0;
	}

	public unsafe bool Contains(void* ptr)
	{
		return false;
	}

	public unsafe void AddNoResize(void* value)
	{
	}

	public unsafe void AddRangeNoResize(void** ptr, int count)
	{
	}

	public void AddRangeNoResize(UnsafePtrList<T> list)
	{
	}

	public void Add(in IntPtr value)
	{
	}

	public unsafe void Add(void* value)
	{
	}

	public unsafe void AddRange(void* ptr, int length)
	{
	}

	public void AddRange(UnsafePtrList<T> list)
	{
	}

	public void InsertRangeWithBeginEnd(int begin, int end)
	{
	}

	public void RemoveAtSwapBack(int index)
	{
	}

	public void RemoveRangeSwapBack(int index, int count)
	{
	}

	[Obsolete("RemoveRangeSwapBackWithBeginEnd(begin, end) is deprecated, use RemoveRangeSwapBack(index, count) instead. (RemovedAfter 2021-06-02)", false)]
	public void RemoveRangeSwapBackWithBeginEnd(int begin, int end)
	{
	}

	public void RemoveAt(int index)
	{
	}

	public void RemoveRange(int index, int count)
	{
	}

	[Obsolete("RemoveRangeWithBeginEnd(begin, end) is deprecated, use RemoveRange(index, count) instead. (RemovedAfter 2021-06-02)", false)]
	public void RemoveRangeWithBeginEnd(int begin, int end)
	{
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	IEnumerator<IntPtr> IEnumerable<IntPtr>.GetEnumerator()
	{
		return null;
	}

	public ParallelReader AsParallelReader()
	{
		return default(ParallelReader);
	}

	public ParallelWriter AsParallelWriter()
	{
		return default(ParallelWriter);
	}
}
