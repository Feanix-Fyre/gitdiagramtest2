using System.Runtime.CompilerServices;

namespace System.Numerics;

[Intrinsic]
public struct Vector<T> : IEquatable<Vector<T>>, IFormattable where T : struct
{
	private struct VectorSizeHelper
	{
		internal Vector<T> _placeholder;

		internal byte _byte;
	}

	private Register register;

	private static readonly int s_count;

	private static readonly Vector<T> s_zero;

	private static readonly Vector<T> s_one;

	private static readonly Vector<T> s_allOnes;

	public static int Count
	{
		[Intrinsic]
		get
		{
			return 0;
		}
	}

	public static Vector<T> Zero
	{
		[Intrinsic]
		get
		{
			return default(Vector<T>);
		}
	}

	public T this[int index]
	{
		[Intrinsic]
		get
		{
			return default(T);
		}
	}

	private static int InitializeCount()
	{
		return 0;
	}

	[Intrinsic]
	public Vector(T value)
	{
		register = default(Register);
	}

	internal unsafe Vector(void* dataPointer)
	{
		register = default(Register);
	}

	internal unsafe Vector(void* dataPointer, int offset)
	{
		register = default(Register);
	}

	private Vector(ref Register existingRegister)
	{
		register = default(Register);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override bool Equals(object obj)
	{
		return false;
	}

	[Intrinsic]
	public bool Equals(Vector<T> other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	public string ToString(string format, IFormatProvider formatProvider)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator ==(Vector<T> left, Vector<T> right)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator !=(Vector<T> left, Vector<T> right)
	{
		return false;
	}

	[Intrinsic]
	[CLSCompliant(false)]
	public static explicit operator Vector<ulong>(Vector<T> value)
	{
		return default(Vector<ulong>);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[Intrinsic]
	internal static Vector<T> Equals(Vector<T> left, Vector<T> right)
	{
		return default(Vector<T>);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool ScalarEquals(T left, T right)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static T GetOneValue()
	{
		return default(T);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static T GetAllBitsSetValue()
	{
		return default(T);
	}
}
[Intrinsic]
public static class Vector
{
	public static bool IsHardwareAccelerated
	{
		[Intrinsic]
		get
		{
			return false;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector<T> Equals<T>(Vector<T> left, Vector<T> right) where T : struct
	{
		return default(Vector<T>);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[CLSCompliant(false)]
	public static Vector<ulong> AsVectorUInt64<T>(Vector<T> value) where T : struct
	{
		return default(Vector<ulong>);
	}
}
