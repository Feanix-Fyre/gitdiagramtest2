using System;
using System.Diagnostics;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.Rendering.Universal.UTess;

[DebuggerTypeProxy(typeof(ArraySliceDebugView<>))]
[DebuggerDisplay("Length = {Length}")]
internal struct ArraySlice<T> : IEquatable<ArraySlice<T>> where T : struct
{
	[NativeDisableUnsafePtrRestriction]
	internal unsafe byte* m_Buffer;

	internal int m_Stride;

	internal int m_Length;

	public T this[int index]
	{
		get
		{
			return default(T);
		}
		[WriteAccessRequired]
		set
		{
		}
	}

	public int Stride => 0;

	public int Length => 0;

	public unsafe ArraySlice(NativeArray<T> array, int start, int length)
	{
		m_Buffer = null;
		m_Stride = 0;
		m_Length = 0;
	}

	public bool Equals(ArraySlice<T> other)
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

	public static bool operator ==(ArraySlice<T> left, ArraySlice<T> right)
	{
		return false;
	}

	public static bool operator !=(ArraySlice<T> left, ArraySlice<T> right)
	{
		return false;
	}

	public unsafe static ArraySlice<T> ConvertExistingDataToArraySlice(void* dataPointer, int stride, int length)
	{
		return default(ArraySlice<T>);
	}

	internal unsafe void* GetUnsafeReadOnlyPtr()
	{
		return null;
	}

	internal void CopyTo(T[] array)
	{
	}

	internal T[] ToArray()
	{
		return null;
	}
}
