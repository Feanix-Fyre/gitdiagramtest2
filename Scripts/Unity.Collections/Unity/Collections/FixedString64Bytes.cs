using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Unity.Collections;

[Serializable]
[StructLayout((LayoutKind)0, Size = 64)]
[BurstCompatible]
public struct FixedString64Bytes : INativeList<byte>, IIndexable<byte>, IUTF8Bytes, IComparable<string>, IEquatable<string>, IComparable<FixedString32Bytes>, IEquatable<FixedString32Bytes>, IComparable<FixedString64Bytes>, IEquatable<FixedString64Bytes>, IComparable<FixedString128Bytes>, IEquatable<FixedString128Bytes>, IComparable<FixedString512Bytes>, IEquatable<FixedString512Bytes>, IComparable<FixedString4096Bytes>, IEquatable<FixedString4096Bytes>
{
	public struct Enumerator : IEnumerator
	{
		private FixedString64Bytes target;

		private int offset;

		private Unicode.Rune current;

		public Unicode.Rune Current => default(Unicode.Rune);

		object IEnumerator.Current => null;

		public Enumerator(FixedString64Bytes other)
		{
			target = default(FixedString64Bytes);
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

	internal const ushort utf8MaxLengthInBytes = 61;

	[SerializeField]
	internal ushort utf8LengthInBytes;

	[SerializeField]
	internal FixedBytes62 bytes;

	public static int UTF8MaxLengthInBytes => 0;

	[CreateProperty]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[NotBurstCompatible]
	public string Value => null;

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

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public unsafe byte* GetUnsafePtr()
	{
		return null;
	}

	public bool TryResize(int newLength, NativeArrayOptions clearOptions = NativeArrayOptions.ClearMemory)
	{
		return false;
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

	public ref FixedList64Bytes<byte> AsFixedList()
	{
		throw null;
	}

	[NotBurstCompatible]
	public FixedString64Bytes(string source)
	{
		utf8LengthInBytes = 0;
		bytes = default(FixedBytes62);
	}

	[NotBurstCompatible]
	internal int Initialize(string source)
	{
		return 0;
	}

	public FixedString64Bytes(Unicode.Rune rune, int count = 1)
	{
		utf8LengthInBytes = 0;
		bytes = default(FixedBytes62);
	}

	internal int Initialize(Unicode.Rune rune, int count = 1)
	{
		return 0;
	}

	public int CompareTo(FixedString32Bytes other)
	{
		return 0;
	}

	public FixedString64Bytes(in FixedString32Bytes other)
	{
		utf8LengthInBytes = 0;
		bytes = default(FixedBytes62);
	}

	internal int Initialize(in FixedString32Bytes other)
	{
		return 0;
	}

	public static bool operator ==(in FixedString64Bytes a, in FixedString32Bytes b)
	{
		return false;
	}

	public static bool operator !=(in FixedString64Bytes a, in FixedString32Bytes b)
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

	public FixedString64Bytes(in FixedString64Bytes other)
	{
		utf8LengthInBytes = 0;
		bytes = default(FixedBytes62);
	}

	internal int Initialize(in FixedString64Bytes other)
	{
		return 0;
	}

	public static bool operator ==(in FixedString64Bytes a, in FixedString64Bytes b)
	{
		return false;
	}

	public static bool operator !=(in FixedString64Bytes a, in FixedString64Bytes b)
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

	public FixedString64Bytes(in FixedString128Bytes other)
	{
		utf8LengthInBytes = 0;
		bytes = default(FixedBytes62);
	}

	internal int Initialize(in FixedString128Bytes other)
	{
		return 0;
	}

	public static bool operator ==(in FixedString64Bytes a, in FixedString128Bytes b)
	{
		return false;
	}

	public static bool operator !=(in FixedString64Bytes a, in FixedString128Bytes b)
	{
		return false;
	}

	public bool Equals(FixedString128Bytes other)
	{
		return false;
	}

	public static implicit operator FixedString128Bytes(in FixedString64Bytes fs)
	{
		return default(FixedString128Bytes);
	}

	public int CompareTo(FixedString512Bytes other)
	{
		return 0;
	}

	public FixedString64Bytes(in FixedString512Bytes other)
	{
		utf8LengthInBytes = 0;
		bytes = default(FixedBytes62);
	}

	internal int Initialize(in FixedString512Bytes other)
	{
		return 0;
	}

	public static bool operator ==(in FixedString64Bytes a, in FixedString512Bytes b)
	{
		return false;
	}

	public static bool operator !=(in FixedString64Bytes a, in FixedString512Bytes b)
	{
		return false;
	}

	public bool Equals(FixedString512Bytes other)
	{
		return false;
	}

	public static implicit operator FixedString512Bytes(in FixedString64Bytes fs)
	{
		return default(FixedString512Bytes);
	}

	public int CompareTo(FixedString4096Bytes other)
	{
		return 0;
	}

	public FixedString64Bytes(in FixedString4096Bytes other)
	{
		utf8LengthInBytes = 0;
		bytes = default(FixedBytes62);
	}

	internal int Initialize(in FixedString4096Bytes other)
	{
		return 0;
	}

	public static bool operator ==(in FixedString64Bytes a, in FixedString4096Bytes b)
	{
		return false;
	}

	public static bool operator !=(in FixedString64Bytes a, in FixedString4096Bytes b)
	{
		return false;
	}

	public bool Equals(FixedString4096Bytes other)
	{
		return false;
	}

	public static implicit operator FixedString4096Bytes(in FixedString64Bytes fs)
	{
		return default(FixedString4096Bytes);
	}

	[NotBurstCompatible]
	public static implicit operator FixedString64Bytes(string b)
	{
		return default(FixedString64Bytes);
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
	public override bool Equals(object obj)
	{
		return false;
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CheckIndexInRange(int index)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CheckLengthInRange(int length)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void CheckCapacityInRange(int capacity)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CheckCopyError(CopyError error, string source)
	{
	}

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void CheckFormatError(FormatError error)
	{
	}
}
