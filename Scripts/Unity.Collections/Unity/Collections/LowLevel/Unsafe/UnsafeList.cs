using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.Jobs;

namespace Unity.Collections.LowLevel.Unsafe;

[Obsolete("Untyped UnsafeList is deprecated, please use UnsafeList<T> instead. (RemovedAfter 2021-05-18)", false)]
[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
public struct UnsafeList : INativeDisposable, IDisposable
{
	public struct ParallelReader
	{
		[NativeDisableUnsafePtrRestriction]
		public unsafe readonly void* Ptr;

		public readonly int Length;

		internal unsafe ParallelReader(void* ptr, int length)
		{
			Ptr = null;
			Length = 0;
		}

		public int IndexOf<T>(T value) where T : struct, IEquatable<T>
		{
			return 0;
		}

		public bool Contains<T>(T value) where T : struct, IEquatable<T>
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

		public void AddNoResize<T>(T value) where T : struct
		{
		}

		private unsafe void AddRangeNoResize(int sizeOf, int alignOf, void* ptr, int length)
		{
		}

		public unsafe void AddRangeNoResize<T>(void* ptr, int length) where T : struct
		{
		}

		public void AddRangeNoResize<T>(UnsafeList list) where T : struct
		{
		}
	}

	[NativeDisableUnsafePtrRestriction]
	public unsafe void* Ptr;

	public int Length;

	public readonly int unused;

	public int Capacity;

	public AllocatorManager.AllocatorHandle Allocator;

	public bool IsEmpty => false;

	public bool IsCreated => false;

	public unsafe UnsafeList(Allocator allocator)
	{
		Ptr = null;
		Length = 0;
		unused = 0;
		Capacity = 0;
		Allocator = default(AllocatorManager.AllocatorHandle);
	}

	public unsafe UnsafeList(void* ptr, int length)
	{
		Ptr = null;
		Length = 0;
		unused = 0;
		Capacity = 0;
		Allocator = default(AllocatorManager.AllocatorHandle);
	}

	internal void Initialize<U>(int sizeOf, int alignOf, int initialCapacity, ref U allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory) where U : struct, AllocatorManager.IAllocator
	{
	}

	internal static UnsafeList New<U>(int sizeOf, int alignOf, int initialCapacity, ref U allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory) where U : struct, AllocatorManager.IAllocator
	{
		return default(UnsafeList);
	}

	public unsafe UnsafeList(int sizeOf, int alignOf, int initialCapacity, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory)
	{
		Ptr = null;
		Length = 0;
		unused = 0;
		Capacity = 0;
		Allocator = default(AllocatorManager.AllocatorHandle);
	}

	public unsafe UnsafeList(int sizeOf, int alignOf, int initialCapacity, Allocator allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory)
	{
		Ptr = null;
		Length = 0;
		unused = 0;
		Capacity = 0;
		Allocator = default(AllocatorManager.AllocatorHandle);
	}

	public unsafe static UnsafeList* Create(int sizeOf, int alignOf, int initialCapacity, Allocator allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory)
	{
		return null;
	}

	internal unsafe static UnsafeList* Create<U>(int sizeOf, int alignOf, int initialCapacity, ref U allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory) where U : struct, AllocatorManager.IAllocator
	{
		return null;
	}

	internal unsafe static void Destroy<U>(UnsafeList* listData, ref U allocator, int sizeOf, int alignOf) where U : struct, AllocatorManager.IAllocator
	{
	}

	public unsafe static void Destroy(UnsafeList* listData)
	{
	}

	public void Dispose()
	{
	}

	internal void Dispose<U>(ref U allocator, int sizeOf, int alignOf) where U : struct, AllocatorManager.IAllocator
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

	public void Resize(int sizeOf, int alignOf, int length, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory)
	{
	}

	public void Resize<T>(int length, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory) where T : struct
	{
	}

	private void Realloc<U>(ref U allocator, int sizeOf, int alignOf, int capacity) where U : struct, AllocatorManager.IAllocator
	{
	}

	private void Realloc(int sizeOf, int alignOf, int capacity)
	{
	}

	private void SetCapacity<U>(ref U allocator, int sizeOf, int alignOf, int capacity) where U : struct, AllocatorManager.IAllocator
	{
	}

	private void SetCapacity(int sizeOf, int alignOf, int capacity)
	{
	}

	public void SetCapacity<T>(int capacity) where T : struct
	{
	}

	public void TrimExcess<T>() where T : struct
	{
	}

	public int IndexOf<T>(T value) where T : struct, IEquatable<T>
	{
		return 0;
	}

	public bool Contains<T>(T value) where T : struct, IEquatable<T>
	{
		return false;
	}

	public void AddNoResize<T>(T value) where T : struct
	{
	}

	private unsafe void AddRangeNoResize(int sizeOf, void* ptr, int length)
	{
	}

	public unsafe void AddRangeNoResize<T>(void* ptr, int length) where T : struct
	{
	}

	public void AddRangeNoResize<T>(UnsafeList list) where T : struct
	{
	}

	public void Add<T>(T value) where T : struct
	{
	}

	private unsafe void AddRange(int sizeOf, int alignOf, void* ptr, int length)
	{
	}

	public unsafe void AddRange<T>(void* ptr, int length) where T : struct
	{
	}

	public void AddRange<T>(UnsafeList list) where T : struct
	{
	}

	private void InsertRangeWithBeginEnd(int sizeOf, int alignOf, int begin, int end)
	{
	}

	public void InsertRangeWithBeginEnd<T>(int begin, int end) where T : struct
	{
	}

	private void RemoveRangeSwapBackWithBeginEnd(int sizeOf, int begin, int end)
	{
	}

	public void RemoveAtSwapBack<T>(int index) where T : struct
	{
	}

	public void RemoveRangeSwapBackWithBeginEnd<T>(int begin, int end) where T : struct
	{
	}

	private void RemoveRangeWithBeginEnd(int sizeOf, int begin, int end)
	{
	}

	public void RemoveAt<T>(int index) where T : struct
	{
	}

	public void RemoveRangeWithBeginEnd<T>(int begin, int end) where T : struct
	{
	}

	public ParallelReader AsParallelReader()
	{
		return default(ParallelReader);
	}

	public ParallelWriter AsParallelWriter()
	{
		return default(ParallelWriter);
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	internal unsafe static void CheckNull(void* listData)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CheckAllocator(Allocator a)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CheckAllocator(AllocatorManager.AllocatorHandle a)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CheckBeginEnd(int begin, int end)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CheckNoResizeHasEnoughCapacity(int length)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CheckNoResizeHasEnoughCapacity(int length, int index)
	{
	}
}
[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
[DebuggerTypeProxy(typeof(UnsafeListTDebugView<>))]
[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
public struct UnsafeList<T> : INativeDisposable, IDisposable, INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable where T : unmanaged
{
	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public struct ParallelReader
	{
		[NativeDisableUnsafePtrRestriction]
		public unsafe readonly T* Ptr;

		public readonly int Length;

		internal unsafe ParallelReader(T* ptr, int length)
		{
			Ptr = null;
			Length = 0;
		}
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public struct ParallelWriter
	{
		[NativeDisableUnsafePtrRestriction]
		public unsafe UnsafeList<T>* ListData;

		public unsafe readonly void* Ptr => null;

		internal unsafe ParallelWriter(UnsafeList<T>* listData)
		{
			ListData = null;
		}

		[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
		public void AddNoResize(T value)
		{
		}

		[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
		public unsafe void AddRangeNoResize(void* ptr, int count)
		{
		}

		[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
		public void AddRangeNoResize(UnsafeList<T> list)
		{
		}
	}

	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		internal unsafe T* m_Ptr;

		internal int m_Length;

		internal int m_Index;

		public T Current => default(T);

		object IEnumerator.Current => null;

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}
	}

	[NativeDisableUnsafePtrRestriction]
	public unsafe T* Ptr;

	public int m_length;

	public int m_capacity;

	public AllocatorManager.AllocatorHandle Allocator;

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

	public T this[int index]
	{
		get
		{
			return default(T);
		}
		set
		{
		}
	}

	public bool IsEmpty => false;

	public bool IsCreated => false;

	public ref T ElementAt(int index)
	{
		throw null;
	}

	public unsafe UnsafeList(T* ptr, int length)
	{
		Ptr = null;
		m_length = 0;
		m_capacity = 0;
		Allocator = default(AllocatorManager.AllocatorHandle);
		this.length = 0;
		capacity = 0;
	}

	public unsafe UnsafeList(int initialCapacity, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory)
	{
		Ptr = null;
		m_length = 0;
		m_capacity = 0;
		Allocator = default(AllocatorManager.AllocatorHandle);
		length = 0;
		capacity = 0;
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(AllocatorManager.AllocatorHandle) })]
	internal void Initialize<U>(int initialCapacity, ref U allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory) where U : struct, AllocatorManager.IAllocator
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(AllocatorManager.AllocatorHandle) })]
	internal static UnsafeList<T> New<U>(int initialCapacity, ref U allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory) where U : struct, AllocatorManager.IAllocator
	{
		return default(UnsafeList<T>);
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(AllocatorManager.AllocatorHandle) })]
	internal unsafe static UnsafeList<T>* Create<U>(int initialCapacity, ref U allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory) where U : struct, AllocatorManager.IAllocator
	{
		return null;
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(AllocatorManager.AllocatorHandle) })]
	internal unsafe static void Destroy<U>(UnsafeList<T>* listData, ref U allocator) where U : struct, AllocatorManager.IAllocator
	{
	}

	public unsafe static UnsafeList<T>* Create(int initialCapacity, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory)
	{
		return null;
	}

	public unsafe static void Destroy(UnsafeList<T>* listData)
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(AllocatorManager.AllocatorHandle) })]
	internal void Dispose<U>(ref U allocator) where U : struct, AllocatorManager.IAllocator
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

	private void Realloc<U>(ref U allocator, int newCapacity) where U : struct, AllocatorManager.IAllocator
	{
	}

	private void Realloc(int capacity)
	{
	}

	private void SetCapacity<U>(ref U allocator, int capacity) where U : struct, AllocatorManager.IAllocator
	{
	}

	public void SetCapacity(int capacity)
	{
	}

	public void TrimExcess()
	{
	}

	public void AddNoResize(T value)
	{
	}

	public unsafe void AddRangeNoResize(void* ptr, int count)
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public void AddRangeNoResize(UnsafeList<T> list)
	{
	}

	public void Add(in T value)
	{
	}

	public unsafe void AddRange(void* ptr, int count)
	{
	}

	[BurstCompatible(GenericTypeArguments = new Type[] { typeof(int) })]
	public void AddRange(UnsafeList<T> list)
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

	public ParallelReader AsParallelReader()
	{
		return default(ParallelReader);
	}

	public ParallelWriter AsParallelWriter()
	{
		return default(ParallelWriter);
	}

	public void CopyFrom(UnsafeList<T> array)
	{
	}

	public Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	internal unsafe static void CheckNull(void* listData)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CheckIndexCount(int index, int count)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CheckBeginEnd(int begin, int end)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CheckNoResizeHasEnoughCapacity(int length)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CheckNoResizeHasEnoughCapacity(int length, int index)
	{
	}
}
