using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Internal;

namespace Unity.Collections;

[DebuggerTypeProxy(typeof(NativeSliceDebugView<>))]
[NativeContainer]
[NativeContainerSupportsMinMaxWriteRestriction]
[DebuggerDisplay("Length = {Length}")]
public struct NativeSlice<T> : IEnumerable<T>, IEnumerable, IEquatable<NativeSlice<T>> where T : struct
{
	[ExcludeFromDocs]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		private NativeSlice<T> m_Array;

		private int m_Index;

		public T Current => default(T);

		object IEnumerator.Current => null;

		public Enumerator(ref NativeSlice<T> array)
		{
			m_Array = default(NativeSlice<T>);
			m_Index = 0;
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

	public unsafe NativeSlice(NativeSlice<T> slice, int start, int length)
	{
		m_Buffer = null;
		m_Stride = 0;
		m_Length = 0;
	}

	public unsafe NativeSlice(NativeArray<T> array)
	{
		m_Buffer = null;
		m_Stride = 0;
		m_Length = 0;
	}

	public static implicit operator NativeSlice<T>(NativeArray<T> array)
	{
		return default(NativeSlice<T>);
	}

	public unsafe NativeSlice(NativeArray<T> array, int start, int length)
	{
		m_Buffer = null;
		m_Stride = 0;
		m_Length = 0;
	}

	[WriteAccessRequired]
	public void CopyFrom(NativeSlice<T> slice)
	{
	}

	[WriteAccessRequired]
	public void CopyFrom(T[] array)
	{
	}

	public void CopyTo(T[] array)
	{
	}

	public T[] ToArray()
	{
		return null;
	}

	public Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public bool Equals(NativeSlice<T> other)
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
}
