using System.Collections;
using System.ComponentModel;

namespace System.Windows.Forms;

/// <summary>Manages the collection of <see cref="T:System.Windows.Forms.BindingManagerBase" /> objects for any object that inherits from the <see cref="T:System.Windows.Forms.Control" /> class.</summary>
[DefaultEvent("CollectionChanged")]
public class BindingContext : ICollection, IEnumerable
{
	private class HashKey
	{
		public object source;

		public string member;

		public HashKey(object source, string member)
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object o)
		{
			return false;
		}
	}

	private Hashtable managers;

	private EventHandler onCollectionChangedHandler;

	/// <summary>Gets the total number of <see cref="T:System.Windows.Forms.CurrencyManager" /> objects managed by the <see cref="T:System.Windows.Forms.BindingContext" />.</summary>
	/// <returns>The number of data sources managed by the <see cref="T:System.Windows.Forms.BindingContext" />.</returns>
	int ICollection.Count => 0;

	/// <summary>Gets a value indicating whether the collection is synchronized.</summary>
	/// <returns>
	///   <see langword="true" /> if the collection is thread safe; otherwise, <see langword="false" />.</returns>
	bool ICollection.IsSynchronized => false;

	/// <summary>Gets an object to use for synchronization (thread safety).</summary>
	/// <returns>This property is derived from <see cref="T:System.Collections.ICollection" />, and is overridden to always return <see langword="null" />.</returns>
	object ICollection.SyncRoot => null;

	/// <summary>Gets the <see cref="T:System.Windows.Forms.BindingManagerBase" /> that is associated with the specified data source.</summary>
	/// <param name="dataSource">The data source associated with a particular <see cref="T:System.Windows.Forms.BindingManagerBase" />.</param>
	/// <returns>A <see cref="T:System.Windows.Forms.BindingManagerBase" /> for the specified data source.</returns>
	public BindingManagerBase this[object dataSource] => null;

	/// <summary>Gets a <see cref="T:System.Windows.Forms.BindingManagerBase" /> that is associated with the specified data source and data member.</summary>
	/// <param name="dataSource">The data source associated with a particular <see cref="T:System.Windows.Forms.BindingManagerBase" />.</param>
	/// <param name="dataMember">A navigation path containing the information that resolves to a specific <see cref="T:System.Windows.Forms.BindingManagerBase" />.</param>
	/// <returns>The <see cref="T:System.Windows.Forms.BindingManagerBase" /> for the specified data source and data member.</returns>
	/// <exception cref="T:System.Exception">The specified <paramref name="dataMember" /> does not exist within the data source.</exception>
	public BindingManagerBase this[object dataSource, string dataMember] => null;

	/// <summary>Initializes a new instance of the <see cref="T:System.Windows.Forms.BindingContext" /> class.</summary>
	public BindingContext()
	{
	}

	/// <summary>Copies the elements of the collection into a specified array, starting at the collection index.</summary>
	/// <param name="ar">An <see cref="T:System.Array" /> to copy into.</param>
	/// <param name="index">The collection index to begin copying from.</param>
	void ICollection.CopyTo(Array ar, int index)
	{
	}

	/// <summary>Gets an enumerator for the collection.</summary>
	/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for the collection.</returns>
	[MonoInternalNote("our enumerator is slightly different.  in MS's implementation the Values are WeakReferences to the managers.")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	private BindingManagerBase CreateBindingManager(object data_source, string data_member)
	{
		return null;
	}

	private bool IsListType(Type t)
	{
		return false;
	}
}
