using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[Serializable]
[NativeHeader("Runtime/Export/Hashing/Hash128.bindings.h")]
[NativeHeader("Runtime/Utilities/Hash128.h")]
[UsedByNativeCode]
public struct Hash128 : IComparable, IComparable<Hash128>, IEquatable<Hash128>
{
	internal ulong u64_0;

	internal ulong u64_1;

	private const ulong kConst = 16045690984833335023uL;

	public Hash128(uint u32_0, uint u32_1, uint u32_2, uint u32_3)
	{
		u64_0 = 0uL;
		u64_1 = 0uL;
	}

	public Hash128(ulong u64_0, ulong u64_1)
	{
		this.u64_0 = 0uL;
		this.u64_1 = 0uL;
	}

	public int CompareTo(Hash128 rhs)
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	[FreeFunction("StringToHash128", IsThreadSafe = true)]
	public static Hash128 Parse(string hashString)
	{
		return default(Hash128);
	}

	[FreeFunction("Hash128ToString", IsThreadSafe = true)]
	private static string Hash128ToStringImpl(Hash128 hash)
	{
		return null;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool Equals(Hash128 obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public int CompareTo(object obj)
	{
		return 0;
	}

	public static bool operator ==(Hash128 hash1, Hash128 hash2)
	{
		return false;
	}

	public static bool operator <(Hash128 x, Hash128 y)
	{
		return false;
	}

	public static bool operator >(Hash128 x, Hash128 y)
	{
		return false;
	}

	private static void Parse_Injected(string hashString, out Hash128 ret)
	{
		ret = default(Hash128);
	}

	private static string Hash128ToStringImpl_Injected(ref Hash128 hash)
	{
		return null;
	}
}
