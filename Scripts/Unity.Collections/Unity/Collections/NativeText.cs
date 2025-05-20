using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace Unity.Collections;

[BurstCompatible]
[NativeContainer]
[DebuggerDisplay("Length = {Length}")]
public struct NativeText : INativeList<byte>, IIndexable<byte>, INativeDisposable, IDisposable, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<NativeText>, IEquatable<NativeText>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes>
{
	public struct Enumerator : IEnumerator<Unicode.Rune>, IEnumerator, IDisposable
	{
		private ReadOnly target;

		private int offset;

		private Unicode.Rune current;

		object IEnumerator.Current => null;

		public Unicode.Rune Current => default(Unicode.Rune);

		public Enumerator(NativeText source)
		{
			target = default(ReadOnly);
			offset = 0;
			current = default(Unicode.Rune);
		}

		public Enumerator(ReadOnly source)
		{
			target = default(ReadOnly);
			offset = 0;
			current = default(Unicode.Rune);
		}

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

	[NativeContainerIsReadOnly]
	[NativeContainer]
	public struct ReadOnly : INativeList<byte>, IIndexable<byte>, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<NativeText>, IEquatable<NativeText>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes>
	{
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeText* m_Data;

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

		public bool IsEmpty
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

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

		public byte this[int index]
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[CreateProperty]
		[NotBurstCompatible]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string Value => null;

		internal unsafe ReadOnly(UnsafeText* text)
		{
			m_Data = null;
		}

		public void Clear()
		{
		}

		public ref byte ElementAt(int index)
		{
			throw null;
		}

		public unsafe byte* GetUnsafePtr()
		{
			return null;
		}

		public bool TryResize(int newLength, NativeArrayOptions clearOptions = NativeArrayOptions.ClearMemory)
		{
			return false;
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		internal unsafe static void CheckNull(void* dataPtr)
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private void CheckRead()
		{
		}

		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private void ErrorWrite()
		{
		}

		[NotBurstCompatible]
		public int CompareTo(string other)
		{
			return 0;
		}

		[NotBurstCompatible]
		public bool Equals(string other)
		{
			return false;
		}

		public int CompareTo(ReadOnly other)
		{
			return 0;
		}

		public bool Equals(ReadOnly other)
		{
			return false;
		}

		public int CompareTo(NativeText other)
		{
			return 0;
		}

		public bool Equals(NativeText other)
		{
			return false;
		}

		public int CompareTo(FixedString32Bytes other)
		{
			return 0;
		}

		public static bool operator ==(in ReadOnly a, in FixedString32Bytes b)
		{
			return false;
		}

		public static bool operator !=(in ReadOnly a, in FixedString32Bytes b)
		{
			return false;
		}

		public bool Equals(FixedString32Bytes other)
		{
			return false;
		}

		public int CompareTo(FixedString64Bytes other)
		{
			return 0;
		}

		public static bool operator ==(in ReadOnly a, in FixedString64Bytes b)
		{
			return false;
		}

		public static bool operator !=(in ReadOnly a, in FixedString64Bytes b)
		{
			return false;
		}

		public bool Equals(FixedString64Bytes other)
		{
			return false;
		}

		public int CompareTo(FixedString128Bytes other)
		{
			return 0;
		}

		public static bool operator ==(in ReadOnly a, in FixedString128Bytes b)
		{
			return false;
		}

		public static bool operator !=(in ReadOnly a, in FixedString128Bytes b)
		{
			return false;
		}

		public bool Equals(FixedString128Bytes other)
		{
			return false;
		}

		public int CompareTo(FixedString512Bytes other)
		{
			return 0;
		}

		public static bool operator ==(in ReadOnly a, in FixedString512Bytes b)
		{
			return false;
		}

		public static bool operator !=(in ReadOnly a, in FixedString512Bytes b)
		{
			return false;
		}

		public bool Equals(FixedString512Bytes other)
		{
			return false;
		}

		public int CompareTo(FixedString4096Bytes other)
		{
			return 0;
		}

		public static bool operator ==(in ReadOnly a, in FixedString4096Bytes b)
		{
			return false;
		}

		public static bool operator !=(in ReadOnly a, in FixedString4096Bytes b)
		{
			return false;
		}

		public bool Equals(FixedString4096Bytes other)
		{
			return false;
		}

		[NotBurstCompatible]
		public override string ToString()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		[NotBurstCompatible]
		public override bool Equals(object other)
		{
			return false;
		}

		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}
	}

	[NativeDisableUnsafePtrRestriction]
	private unsafe UnsafeText* m_Data;

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

	public bool IsEmpty => false;

	public bool IsCreated => false;

	public byte this[int index]
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[CreateProperty]
	[NotBurstCompatible]
	public string Value => null;

	[NotBurstCompatible]
	public unsafe NativeText(string source, Allocator allocator)
	{
		m_Data = null;
	}

	[NotBurstCompatible]
	public unsafe NativeText(string source, AllocatorManager.AllocatorHandle allocator)
	{
		m_Data = null;
	}

	private unsafe NativeText(int capacity, AllocatorManager.AllocatorHandle allocator, int disposeSentinelStackDepth)
	{
		m_Data = null;
	}

	public unsafe NativeText(int capacity, Allocator allocator)
	{
		m_Data = null;
	}

	public unsafe NativeText(int capacity, AllocatorManager.AllocatorHandle allocator)
	{
		m_Data = null;
	}

	public unsafe NativeText(Allocator allocator)
	{
		m_Data = null;
	}

	public unsafe NativeText(AllocatorManager.AllocatorHandle allocator)
	{
		m_Data = null;
	}

	public unsafe NativeText(in FixedString32Bytes source, AllocatorManager.AllocatorHandle allocator)
	{
		m_Data = null;
	}

	public unsafe NativeText(in FixedString32Bytes source, Allocator allocator)
	{
		m_Data = null;
	}

	public unsafe NativeText(in FixedString64Bytes source, AllocatorManager.AllocatorHandle allocator)
	{
		m_Data = null;
	}

	public unsafe NativeText(in FixedString64Bytes source, Allocator allocator)
	{
		m_Data = null;
	}

	public unsafe NativeText(in FixedString128Bytes source, AllocatorManager.AllocatorHandle allocator)
	{
		m_Data = null;
	}

	public unsafe NativeText(in FixedString128Bytes source, Allocator allocator)
	{
		m_Data = null;
	}

	public unsafe NativeText(in FixedString512Bytes source, AllocatorManager.AllocatorHandle allocator)
	{
		m_Data = null;
	}

	public unsafe NativeText(in FixedString512Bytes source, Allocator allocator)
	{
		m_Data = null;
	}

	public unsafe NativeText(in FixedString4096Bytes source, AllocatorManager.AllocatorHandle allocator)
	{
		m_Data = null;
	}

	public unsafe NativeText(in FixedString4096Bytes source, Allocator allocator)
	{
		m_Data = null;
	}

	public bool TryResize(int newLength, NativeArrayOptions clearOptions = NativeArrayOptions.ClearMemory)
	{
		return false;
	}

	public unsafe byte* GetUnsafePtr()
	{
		return null;
	}

	public ref byte ElementAt(int index)
	{
		throw null;
	}

	public void Clear()
	{
	}

	public void Add(in byte value)
	{
	}

	public int CompareTo(NativeText other)
	{
		return 0;
	}

	public bool Equals(NativeText other)
	{
		return false;
	}

	public int CompareTo(ReadOnly other)
	{
		return 0;
	}

	public bool Equals(ReadOnly other)
	{
		return false;
	}

	public void Dispose()
	{
	}

	[NotBurstCompatible]
	public JobHandle Dispose(JobHandle inputDeps)
	{
		return default(JobHandle);
	}

	public Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	[NotBurstCompatible]
	public int CompareTo(string other)
	{
		return 0;
	}

	[NotBurstCompatible]
	public bool Equals(string other)
	{
		return false;
	}

	public int CompareTo(FixedString32Bytes other)
	{
		return 0;
	}

	public static bool operator ==(in NativeText a, in FixedString32Bytes b)
	{
		return false;
	}

	public static bool operator !=(in NativeText a, in FixedString32Bytes b)
	{
		return false;
	}

	public bool Equals(FixedString32Bytes other)
	{
		return false;
	}

	public int CompareTo(FixedString64Bytes other)
	{
		return 0;
	}

	public static bool operator ==(in NativeText a, in FixedString64Bytes b)
	{
		return false;
	}

	public static bool operator !=(in NativeText a, in FixedString64Bytes b)
	{
		return false;
	}

	public bool Equals(FixedString64Bytes other)
	{
		return false;
	}

	public int CompareTo(FixedString128Bytes other)
	{
		return 0;
	}

	public static bool operator ==(in NativeText a, in FixedString128Bytes b)
	{
		return false;
	}

	public static bool operator !=(in NativeText a, in FixedString128Bytes b)
	{
		return false;
	}

	public bool Equals(FixedString128Bytes other)
	{
		return false;
	}

	public int CompareTo(FixedString512Bytes other)
	{
		return 0;
	}

	public static bool operator ==(in NativeText a, in FixedString512Bytes b)
	{
		return false;
	}

	public static bool operator !=(in NativeText a, in FixedString512Bytes b)
	{
		return false;
	}

	public bool Equals(FixedString512Bytes other)
	{
		return false;
	}

	public int CompareTo(FixedString4096Bytes other)
	{
		return 0;
	}

	public static bool operator ==(in NativeText a, in FixedString4096Bytes b)
	{
		return false;
	}

	public static bool operator !=(in NativeText a, in FixedString4096Bytes b)
	{
		return false;
	}

	public bool Equals(FixedString4096Bytes other)
	{
		return false;
	}

	[NotBurstCompatible]
	public override string ToString()
	{
		return null;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	[NotBurstCompatible]
	public override bool Equals(object other)
	{
		return false;
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	internal unsafe static void CheckNull(void* dataPtr)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CheckRead()
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CheckWrite()
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CheckWriteAndBumpSecondaryVersion()
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CheckIndexInRange(int index)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void ThrowCopyError(CopyError error, string source)
	{
	}

	public ReadOnly AsReadOnly()
	{
		return default(ReadOnly);
	}
}
