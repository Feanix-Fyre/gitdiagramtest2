using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.InputSystem.Utilities;

internal struct InlinedArray<TValue> : IEnumerable<TValue>, IEnumerable
{
	private struct Enumerator : IEnumerator<TValue>, IEnumerator, IDisposable
	{
		public InlinedArray<TValue> array;

		public int index;

		public TValue Current => default(TValue);

		object IEnumerator.Current => null;

		public bool MoveNext()
		{
			return false;
		}

		public void Reset()
		{
		}

		public void Dispose()
		{
		}
	}

	public int length;

	public TValue firstValue;

	public TValue[] additionalValues;

	public int Capacity => 0;

	public TValue this[int index]
	{
		get
		{
			return default(TValue);
		}
		set
		{
		}
	}

	public InlinedArray(TValue value)
	{
		length = 0;
		firstValue = default(TValue);
		additionalValues = null;
	}

	public InlinedArray(TValue firstValue, params TValue[] additionalValues)
	{
		length = 0;
		this.firstValue = default(TValue);
		this.additionalValues = null;
	}

	public InlinedArray(IEnumerable<TValue> values)
	{
		length = 0;
		firstValue = default(TValue);
		additionalValues = null;
	}

	public void Clear()
	{
	}

	public void ClearWithCapacity()
	{
	}

	public InlinedArray<TValue> Clone()
	{
		return default(InlinedArray<TValue>);
	}

	public void SetLength(int size)
	{
	}

	public TValue[] ToArray()
	{
		return null;
	}

	public TOther[] ToArray<TOther>(Func<TValue, TOther> mapFunction)
	{
		return null;
	}

	public int IndexOf(TValue value)
	{
		return 0;
	}

	public int Append(TValue value)
	{
		return 0;
	}

	public int AppendWithCapacity(TValue value, int capacityIncrement = 10)
	{
		return 0;
	}

	public void AssignWithCapacity(InlinedArray<TValue> values)
	{
	}

	public void Append(IEnumerable<TValue> values)
	{
	}

	public void Remove(TValue value)
	{
	}

	public void RemoveAtWithCapacity(int index)
	{
	}

	public void RemoveAt(int index)
	{
	}

	public void RemoveAtByMovingTailWithCapacity(int index)
	{
	}

	public bool RemoveByMovingTailWithCapacity(TValue value)
	{
		return false;
	}

	public bool Contains(TValue value, IEqualityComparer<TValue> comparer)
	{
		return false;
	}

	public void Merge(InlinedArray<TValue> other)
	{
	}

	public IEnumerator<TValue> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
