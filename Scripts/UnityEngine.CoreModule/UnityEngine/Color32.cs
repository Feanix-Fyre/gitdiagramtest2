using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[StructLayout((LayoutKind)2)]
[UsedByNativeCode]
[DefaultMember("Item")]
public struct Color32 : IFormattable
{
	[FieldOffset(0)]
	[Ignore(DoesNotContributeToSize = true)]
	private int rgba;

	[FieldOffset(0)]
	public byte r;

	[FieldOffset(1)]
	public byte g;

	[FieldOffset(2)]
	public byte b;

	[FieldOffset(3)]
	public byte a;

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public Color32(byte r, byte g, byte b, byte a)
	{
		rgba = 0;
		this.r = 0;
		this.g = 0;
		this.b = 0;
		this.a = 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator Color32(Color c)
	{
		return default(Color32);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static implicit operator Color(Color32 c)
	{
		return default(Color);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Color32 Lerp(Color32 a, Color32 b, float t)
	{
		return default(Color32);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override string ToString()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public string ToString(string format, IFormatProvider formatProvider)
	{
		return null;
	}
}
