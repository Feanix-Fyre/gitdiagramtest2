using System.Collections;
using System.ComponentModel;

namespace System.Data;

/// <summary>Contains a read-only collection of <see cref="T:System.Data.DataViewSetting" /> objects for each <see cref="T:System.Data.DataTable" /> in a <see cref="T:System.Data.DataSet" />.</summary>
public class DataViewSettingCollection : ICollection, IEnumerable
{
	private sealed class DataViewSettingsEnumerator : IEnumerator
	{
		private DataViewSettingCollection _dataViewSettings;

		private IEnumerator _tableEnumerator;

		public object Current => null;

		public DataViewSettingsEnumerator(DataViewManager dvm)
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

	private readonly DataViewManager _dataViewManager;

	private readonly Hashtable _list;

	/// <summary>Gets the <see cref="T:System.Data.DataViewSetting" /> objects of the specified <see cref="T:System.Data.DataTable" /> from the collection.</summary>
	/// <param name="table">The <see cref="T:System.Data.DataTable" /> to find.</param>
	/// <returns>A collection of <see cref="T:System.Data.DataViewSetting" /> objects.</returns>
	public virtual DataViewSetting this[DataTable table]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets the number of <see cref="T:System.Data.DataViewSetting" /> objects in the <see cref="T:System.Data.DataViewSettingCollection" />.</summary>
	/// <returns>The number of <see cref="T:System.Data.DataViewSetting" /> objects in the collection.</returns>
	[Browsable(false)]
	public virtual int Count => 0;

	/// <summary>Gets a value that indicates whether access to the <see cref="T:System.Data.DataViewSettingCollection" /> is synchronized (thread-safe).</summary>
	/// <returns>This property is always <see langword="false" />, unless overridden by a derived class.</returns>
	[Browsable(false)]
	public bool IsSynchronized => false;

	/// <summary>Gets an object that can be used to synchronize access to the <see cref="T:System.Data.DataViewSettingCollection" />.</summary>
	/// <returns>An object that can be used to synchronize access to the <see cref="T:System.Data.DataViewSettingCollection" />.</returns>
	[Browsable(false)]
	public object SyncRoot => null;

	internal DataViewSettingCollection(DataViewManager dataViewManager)
	{
	}

	/// <summary>Copies the collection objects to a one-dimensional <see cref="T:System.Array" /> instance starting at the specified index.</summary>
	/// <param name="ar">The one-dimensional <see cref="T:System.Array" /> that is the destination of the values copied from the collection.</param>
	/// <param name="index">The index of the array at which to start inserting.</param>
	public void CopyTo(Array ar, int index)
	{
	}

	/// <summary>Gets an <see cref="T:System.Collections.IEnumerator" /> for the collection.</summary>
	/// <returns>An <see cref="T:System.Collections.IEnumerator" /> object.</returns>
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	internal void Remove(DataTable table)
	{
	}
}
