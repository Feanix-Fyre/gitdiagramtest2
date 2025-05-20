using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Collections.Concurrent;

/// <summary>Represents a thread-safe first in-first out (FIFO) collection.</summary>
/// <typeparam name="T">The type of the elements contained in the queue.</typeparam>
[Serializable]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IProducerConsumerCollectionDebugView<>))]
public class ConcurrentQueue<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
{
	[DebuggerDisplay("Capacity = {Capacity}")]
	internal sealed class Segment
	{
		[StructLayout((LayoutKind)3)]
		[DebuggerDisplay("Item = {Item}, SequenceNumber = {SequenceNumber}")]
		internal struct Slot
		{
			public T Item;

			public int SequenceNumber;
		}

		internal readonly Slot[] _slots;

		internal readonly int _slotsMask;

		internal PaddedHeadAndTail _headAndTail;

		internal bool _preservedForObservation;

		internal bool _frozenForEnqueues;

		internal Segment _nextSegment;

		internal int Capacity => 0;

		internal int FreezeOffset => 0;

		public Segment(int boundedLength)
		{
		}

		internal void EnsureFrozenForEnqueues()
		{
		}

		public bool TryDequeue(out T item)
		{
			item = default(T);
			return false;
		}

		public bool TryPeek(out T result, bool resultUsed)
		{
			result = default(T);
			return false;
		}

		public bool TryEnqueue(T item)
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003CEnumerate_003Ed__28 : IEnumerator<T>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private T _003C_003E2__current;

		public Segment head;

		public Segment tail;

		public int tailTail;

		public int headHead;

		public ConcurrentQueue<T> _003C_003E4__this;

		private int _003CheadTail_003E5__2;

		private int _003Ci_003E5__3;

		private Segment _003Cs_003E5__4;

		private int _003Ci_003E5__5;

		T IEnumerator<T>.Current
		{
			[DebuggerHidden]
			get
			{
				return default(T);
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CEnumerate_003Ed__28(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private const int InitialSegmentLength = 32;

	private const int MaxSegmentLength = 1048576;

	private object _crossSegmentLock;

	private Segment _tail;

	private Segment _head;

	/// <summary>Gets a value indicating whether access to the <see cref="T:System.Collections.ICollection" /> is synchronized with the SyncRoot.</summary>
	/// <returns>Always returns <see langword="false" /> to indicate access is not synchronized.</returns>
	bool ICollection.IsSynchronized => false;

	/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Collections.ICollection" />. This property is not supported.</summary>
	/// <returns>Returns null  (Nothing in Visual Basic).</returns>
	/// <exception cref="T:System.NotSupportedException">The SyncRoot property is not supported.</exception>
	object ICollection.SyncRoot => null;

	/// <summary>Gets a value that indicates whether the <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" /> is empty.</summary>
	/// <returns>
	///   <see langword="true" /> if the <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" /> is empty; otherwise, <see langword="false" />.</returns>
	public bool IsEmpty => false;

	/// <summary>Gets the number of elements contained in the <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" />.</summary>
	/// <returns>The number of elements contained in the <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" />.</returns>
	public int Count => 0;

	/// <summary>Initializes a new instance of the <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" /> class.</summary>
	public ConcurrentQueue()
	{
	}

	/// <summary>Copies the elements of the <see cref="T:System.Collections.ICollection" /> to an <see cref="T:System.Array" />, starting at a particular <see cref="T:System.Array" /> index.</summary>
	/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from the <see cref="T:System.Collections.Concurrent.ConcurrentBag`1" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
	/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is a null reference (Nothing in Visual Basic).</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="array" /> is multidimensional. -or- <paramref name="array" /> does not have zero-based indexing. -or- <paramref name="index" /> is equal to or greater than the length of the <paramref name="array" /> -or- The number of elements in the source <see cref="T:System.Collections.ICollection" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />. -or- The type of the source <see cref="T:System.Collections.ICollection" /> cannot be cast automatically to the type of the destination <paramref name="array" />.</exception>
	void ICollection.CopyTo(Array array, int index)
	{
	}

	/// <summary>Returns an enumerator that iterates through a collection.</summary>
	/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that can be used to iterate through the collection.</returns>
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	/// <summary>Copies the elements stored in the <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" /> to a new array.</summary>
	/// <returns>A new array containing a snapshot of elements copied from the <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" />.</returns>
	public T[] ToArray()
	{
		return null;
	}

	private static int GetCount(Segment s, int head, int tail)
	{
		return 0;
	}

	private static long GetCount(Segment head, int headHead, Segment tail, int tailTail)
	{
		return 0L;
	}

	/// <summary>Copies the <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" /> elements to an existing one-dimensional <see cref="T:System.Array" />, starting at the specified array index.</summary>
	/// <param name="array">The one-dimensional <see cref="T:System.Array" /> that is the destination of the elements copied from the <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" />. The <see cref="T:System.Array" /> must have zero-based indexing.</param>
	/// <param name="index">The zero-based index in <paramref name="array" /> at which copying begins.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="array" /> is a null reference (Nothing in Visual Basic).</exception>
	/// <exception cref="T:System.ArgumentOutOfRangeException">
	///   <paramref name="index" /> is less than zero.</exception>
	/// <exception cref="T:System.ArgumentException">
	///   <paramref name="index" /> is equal to or greater than the length of the <paramref name="array" /> -or- The number of elements in the source <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" /> is greater than the available space from <paramref name="index" /> to the end of the destination <paramref name="array" />.</exception>
	public void CopyTo(T[] array, int index)
	{
	}

	/// <summary>Returns an enumerator that iterates through the <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" />.</summary>
	/// <returns>An enumerator for the contents of the <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" />.</returns>
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	private void SnapForObservation(out Segment head, out int headHead, out Segment tail, out int tailTail)
	{
		head = null;
		headHead = default(int);
		tail = null;
		tailTail = default(int);
	}

	private T GetItemWhenAvailable(Segment segment, int i)
	{
		return default(T);
	}

	[IteratorStateMachine(typeof(ConcurrentQueue<>._003CEnumerate_003Ed__28))]
	private IEnumerator<T> Enumerate(Segment head, int headHead, Segment tail, int tailTail)
	{
		return null;
	}

	/// <summary>Adds an object to the end of the <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" />.</summary>
	/// <param name="item">The object to add to the end of the <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" />. The value can be a null reference (Nothing in Visual Basic) for reference types.</param>
	public void Enqueue(T item)
	{
	}

	private void EnqueueSlow(T item)
	{
	}

	/// <summary>Tries to remove and return the object at the beginning of the concurrent queue.</summary>
	/// <param name="result">When this method returns, if the operation was successful, <paramref name="result" /> contains the object removed. If no object was available to be removed, the value is unspecified.</param>
	/// <returns>
	///   <see langword="true" /> if an element was removed and returned from the beginning of the <see cref="T:System.Collections.Concurrent.ConcurrentQueue`1" /> successfully; otherwise, <see langword="false" />.</returns>
	public bool TryDequeue(out T result)
	{
		result = default(T);
		return false;
	}

	private bool TryDequeueSlow(out T item)
	{
		item = default(T);
		return false;
	}

	private bool TryPeek(out T result, bool resultUsed)
	{
		result = default(T);
		return false;
	}
}
