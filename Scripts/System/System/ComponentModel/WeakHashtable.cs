using System.Collections;

namespace System.ComponentModel;

internal sealed class WeakHashtable : Hashtable
{
	private class WeakKeyComparer : IEqualityComparer
	{
		bool IEqualityComparer.Equals(object x, object y)
		{
			return false;
		}

		int IEqualityComparer.GetHashCode(object obj)
		{
			return 0;
		}
	}

	private sealed class EqualityWeakReference : WeakReference
	{
		private int _hashCode;

		internal EqualityWeakReference(object o)
		{
		}

		public override bool Equals(object o)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}

	private static IEqualityComparer _comparer;

	private long _lastGlobalMem;

	private int _lastHashCount;

	internal WeakHashtable()
	{
	}

	public override void Clear()
	{
	}

	public override void Remove(object key)
	{
	}

	public void SetWeak(object key, object value)
	{
	}

	private void ScavengeKeys()
	{
	}
}
