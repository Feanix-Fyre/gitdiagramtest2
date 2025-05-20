using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace Unity.Collections;

[Obsolete("HeapString has been removed and replaced with NativeText (RemovedAfter 2021-07-21) (UnityUpgradable) -> NativeText", false)]
[BurstCompatible]
public struct HeapString : INativeList<byte>, IIndexable<byte>, IDisposable, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<HeapString>, IEquatable<HeapString>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes>
{
	public struct Enumerator : IEnumerator<Unicode.Rune>, IEnumerator, IDisposable
	{
		private HeapString target;

		private int offset;

		private Unicode.Rune current;

		object IEnumerator.Current => null;

		public Unicode.Rune Current => default(Unicode.Rune);

		public Enumerator(HeapString source)
		{
			target = default(HeapString);
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

	private NativeList<byte> m_Data;

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

	[CreateProperty]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[NotBurstCompatible]
	public string Value => null;

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

	public int CompareTo(HeapString other)
	{
		return 0;
	}

	public bool Equals(HeapString other)
	{
		return false;
	}

	public void Dispose()
	{
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

	[NotBurstCompatible]
	public HeapString(string source, Allocator allocator)
	{
		m_Data = default(NativeList<byte>);
	}

	public HeapString(int capacity, Allocator allocator)
	{
		m_Data = default(NativeList<byte>);
	}

	public HeapString(Allocator allocator)
	{
		m_Data = default(NativeList<byte>);
	}

	public int CompareTo(FixedString32Bytes other)
	{
		return 0;
	}

	public HeapString(in FixedString32Bytes source, Allocator allocator)
	{
		m_Data = default(NativeList<byte>);
	}

	public static bool operator ==(in HeapString a, in FixedString32Bytes b)
	{
		return false;
	}

	public static bool operator !=(in HeapString a, in FixedString32Bytes b)
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

	public HeapString(in FixedString64Bytes source, Allocator allocator)
	{
		m_Data = default(NativeList<byte>);
	}

	public static bool operator ==(in HeapString a, in FixedString64Bytes b)
	{
		return false;
	}

	public static bool operator !=(in HeapString a, in FixedString64Bytes b)
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

	public HeapString(in FixedString128Bytes source, Allocator allocator)
	{
		m_Data = default(NativeList<byte>);
	}

	public static bool operator ==(in HeapString a, in FixedString128Bytes b)
	{
		return false;
	}

	public static bool operator !=(in HeapString a, in FixedString128Bytes b)
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

	public HeapString(in FixedString512Bytes source, Allocator allocator)
	{
		m_Data = default(NativeList<byte>);
	}

	public static bool operator ==(in HeapString a, in FixedString512Bytes b)
	{
		return false;
	}

	public static bool operator !=(in HeapString a, in FixedString512Bytes b)
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

	public HeapString(in FixedString4096Bytes source, Allocator allocator)
	{
		m_Data = default(NativeList<byte>);
	}

	public static bool operator ==(in HeapString a, in FixedString4096Bytes b)
	{
		return false;
	}

	public static bool operator !=(in HeapString a, in FixedString4096Bytes b)
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
	private void CheckIndexInRange(int index)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void ThrowCopyError(CopyError error, string source)
	{
	}
}
