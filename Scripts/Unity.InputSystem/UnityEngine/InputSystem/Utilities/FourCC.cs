using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.InputSystem.Utilities;

public struct FourCC : IEquatable<FourCC>
{
	private int m_Code;

	public FourCC(int code)
	{
		m_Code = 0;
	}

	public FourCC(char a, char b = ' ', char c = ' ', char d = ' ')
	{
		m_Code = 0;
	}

	public FourCC(string str)
	{
		m_Code = 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator int(FourCC fourCC)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator FourCC(int i)
	{
		return default(FourCC);
	}

	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool Equals(FourCC other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator ==(FourCC left, FourCC right)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool operator !=(FourCC left, FourCC right)
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static FourCC FromInt32(int i)
	{
		return default(FourCC);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int ToInt32(FourCC fourCC)
	{
		return 0;
	}
}
