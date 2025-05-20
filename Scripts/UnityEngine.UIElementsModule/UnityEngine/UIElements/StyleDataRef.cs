using System;

namespace UnityEngine.UIElements;

internal struct StyleDataRef<T> : IEquatable<StyleDataRef<T>> where T : struct, IEquatable<T>, IStyleDataGroup<T>
{
	private class RefCounted
	{
		private static uint m_NextId;

		private int m_RefCount;

		private readonly uint m_Id;

		public T value;

		public int refCount => 0;

		public void Acquire()
		{
		}

		public void Release()
		{
		}

		public RefCounted Copy()
		{
			return null;
		}
	}

	private RefCounted m_Ref;

	public StyleDataRef<T> Acquire()
	{
		return default(StyleDataRef<T>);
	}

	public void Release()
	{
	}

	public void CopyFrom(StyleDataRef<T> other)
	{
	}

	public ref T Read()
	{
		throw null;
	}

	public ref T Write()
	{
		throw null;
	}

	public static StyleDataRef<T> Create()
	{
		return default(StyleDataRef<T>);
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public static bool operator ==(StyleDataRef<T> lhs, StyleDataRef<T> rhs)
	{
		return false;
	}

	public bool Equals(StyleDataRef<T> other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public bool ReferenceEquals(StyleDataRef<T> other)
	{
		return false;
	}
}
