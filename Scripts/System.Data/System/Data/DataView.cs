using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace System.Data;

/// <summary>Represents a databindable, customized view of a <see cref="T:System.Data.DataTable" /> for sorting, filtering, searching, editing, and navigation. The <see cref="T:System.Data.DataView" /> does not store data, but instead represents a connected view of its corresponding <see cref="T:System.Data.DataTable" />. Changes to the <see cref="T:System.Data.DataView" />'s data will affect the <see cref="T:System.Data.DataTable" />. Changes to the <see cref="T:System.Data.DataTable" />'s data will affect all <see cref="T:System.Data.DataView" />s associated with it.</summary>
[DefaultProperty("Table")]
[DefaultEvent("PositionChanged")]
public class DataView : MarshalByValueComponent, IBindingList, IList, ICollection, IEnumerable, ITypedList
{
	private sealed class DataRowReferenceComparer : IEqualityComparer<DataRow>
	{
		internal static readonly DataRowReferenceComparer s_default;

		private DataRowReferenceComparer()
		{
		}

		public bool Equals(DataRow x, DataRow y)
		{
			return false;
		}

		public int GetHashCode(DataRow obj)
		{
			return 0;
		}
	}

	private DataViewManager _dataViewManager;

	private DataTable _table;

	private bool _locked;

	private Index _index;

	private Dictionary<string, Index> _findIndexes;

	private string _sort;

	private Comparison<DataRow> _comparison;

	private IFilter _rowFilter;

	private DataViewRowState _recordStates;

	private bool _shouldOpen;

	private bool _open;

	private bool _allowNew;

	private bool _allowEdit;

	private bool _allowDelete;

	private bool _applyDefaultSort;

	internal DataRow _addNewRow;

	private ListChangedEventArgs _addNewMoved;

	private ListChangedEventHandler _onListChanged;

	internal static ListChangedEventArgs s_resetEventArgs;

	private string _delayedSort;

	private DataViewRowState _delayedRecordStates;

	private bool _fInitInProgress;

	private bool _fEndInitInProgress;

	private Dictionary<DataRow, DataRowView> _rowViewCache;

	private readonly Dictionary<DataRow, DataRowView> _rowViewBuffer;

	private DataViewListener _dvListener;

	private static int s_objectTypeCount;

	private readonly int _objectID;

	/// <summary>Sets or gets a value that indicates whether deletes are allowed.</summary>
	/// <returns>
	///   <see langword="true" />, if deletes are allowed; otherwise, <see langword="false" />.</returns>
	[DefaultValue(true)]
	public bool AllowDelete => false;

	/// <summary>Gets or sets a value that indicates whether edits are allowed.</summary>
	/// <returns>
	///   <see langword="true" />, if edits are allowed; otherwise, <see langword="false" />.</returns>
	[DefaultValue(true)]
	public bool AllowEdit => false;

	/// <summary>Gets or sets a value that indicates whether the new rows can be added by using the <see cref="M:System.Data.DataView.AddNew" /> method.</summary>
	/// <returns>
	///   <see langword="true" />, if new rows can be added; otherwise, <see langword="false" />.</returns>
	[DefaultValue(true)]
	public bool AllowNew => false;

	/// <summary>Gets the number of records in the <see cref="T:System.Data.DataView" /> after <see cref="P:System.Data.DataView.RowFilter" /> and <see cref="P:System.Data.DataView.RowStateFilter" /> have been applied.</summary>
	/// <returns>The number of records in the <see cref="T:System.Data.DataView" />.</returns>
	[Browsable(false)]
	public int Count => 0;

	private int CountFromIndex => 0;

	/// <summary>Gets the <see cref="T:System.Data.DataViewManager" /> associated with this view.</summary>
	/// <returns>The <see langword="DataViewManager" /> that created this view. If this is the default <see cref="T:System.Data.DataView" /> for a <see cref="T:System.Data.DataTable" />, the <see langword="DataViewManager" /> property returns the default <see langword="DataViewManager" /> for the <see langword="DataSet" />. Otherwise, if the <see langword="DataView" /> was created without a <see langword="DataViewManager" />, this property is <see langword="null" />.</returns>
	[Browsable(false)]
	public DataViewManager DataViewManager => null;

	/// <summary>Gets a value that indicates whether the data source is currently open and projecting views of data on the <see cref="T:System.Data.DataTable" />.</summary>
	/// <returns>
	///   <see langword="true" />, if the source is open; otherwise, <see langword="false" />.</returns>
	[Browsable(false)]
	protected bool IsOpen => false;

	/// <summary>For a description of this member, see <see cref="P:System.Collections.ICollection.IsSynchronized" />.</summary>
	/// <returns>For a description of this member, see <see cref="P:System.Collections.ICollection.IsSynchronized" />.</returns>
	bool ICollection.IsSynchronized => false;

	/// <summary>Gets or sets the row state filter used in the <see cref="T:System.Data.DataView" />.</summary>
	/// <returns>One of the <see cref="T:System.Data.DataViewRowState" /> values.</returns>
	[DefaultValue(DataViewRowState.CurrentRows)]
	public DataViewRowState RowStateFilter => default(DataViewRowState);

	/// <summary>Gets or sets the sort column or columns, and sort order for the <see cref="T:System.Data.DataView" />.</summary>
	/// <returns>A string that contains the column name followed by "ASC" (ascending) or "DESC" (descending). Columns are sorted ascending by default. Multiple columns can be separated by commas.</returns>
	[DefaultValue(null)]
	public string Sort
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal Comparison<DataRow> SortComparison => null;

	/// <summary>For a description of this member, see <see cref="P:System.Collections.ICollection.SyncRoot" />.</summary>
	/// <returns>For a description of this member, see <see cref="P:System.Collections.ICollection.SyncRoot" />.</returns>
	object ICollection.SyncRoot => null;

	/// <summary>Gets or sets the source <see cref="T:System.Data.DataTable" />.</summary>
	/// <returns>A <see cref="T:System.Data.DataTable" /> that provides the data for this view.</returns>
	[DefaultValue(null)]
	[RefreshProperties(RefreshProperties.All)]
	[TypeConverter(typeof(DataTableTypeConverter))]
	public DataTable Table => null;

	/// <summary>For a description of this member, see <see cref="P:System.Collections.IList.Item(System.Int32)" />.</summary>
	/// <param name="recordIndex">An <see cref="T:System.Int32" /> value.</param>
	/// <returns>For a description of this member, see <see cref="P:System.Collections.IList.Item(System.Int32)" />.</returns>
	object IList.this[int recordIndex]
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	/// <summary>Gets a row of data from a specified table.</summary>
	/// <param name="recordIndex">The index of a record in the <see cref="T:System.Data.DataTable" />.</param>
	/// <returns>A <see cref="T:System.Data.DataRowView" /> of the row that you want.</returns>
	public DataRowView this[int recordIndex] => null;

	/// <summary>For a description of this member, see <see cref="P:System.Collections.IList.IsReadOnly" />.</summary>
	/// <returns>For a description of this member, see <see cref="P:System.Collections.IList.IsReadOnly" />.</returns>
	bool IList.IsReadOnly => false;

	/// <summary>For a description of this member, see <see cref="P:System.Collections.IList.IsFixedSize" />.</summary>
	/// <returns>For a description of this member, see <see cref="P:System.Collections.IList.IsFixedSize" />.</returns>
	bool IList.IsFixedSize => false;

	/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.AllowNew" />.</summary>
	/// <returns>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.AllowNew" />.</returns>
	bool IBindingList.AllowNew => false;

	/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.AllowEdit" />.</summary>
	/// <returns>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.AllowEdit" />.</returns>
	bool IBindingList.AllowEdit => false;

	/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.AllowRemove" />.</summary>
	/// <returns>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.AllowRemove" />.</returns>
	bool IBindingList.AllowRemove => false;

	/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SupportsChangeNotification" />.</summary>
	/// <returns>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SupportsChangeNotification" />.</returns>
	bool IBindingList.SupportsChangeNotification => false;

	/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SupportsSearching" />.</summary>
	/// <returns>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SupportsSearching" />.</returns>
	bool IBindingList.SupportsSearching => false;

	/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SupportsSorting" />.</summary>
	/// <returns>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SupportsSorting" />.</returns>
	bool IBindingList.SupportsSorting => false;

	/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.IsSorted" />.</summary>
	/// <returns>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.IsSorted" />.</returns>
	bool IBindingList.IsSorted => false;

	/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SortProperty" />.</summary>
	/// <returns>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SortProperty" />.</returns>
	PropertyDescriptor IBindingList.SortProperty => null;

	/// <summary>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SortDirection" />.</summary>
	/// <returns>For a description of this member, see <see cref="P:System.ComponentModel.IBindingList.SortDirection" />.</returns>
	ListSortDirection IBindingList.SortDirection => default(ListSortDirection);

	internal int ObjectID => 0;

	/// <summary>Occurs when the list managed by the <see cref="T:System.Data.DataView" /> changes.</summary>
	public event ListChangedEventHandler ListChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	internal DataView(DataTable table, bool locked)
	{
	}

	/// <summary>Initializes a new instance of the <see cref="T:System.Data.DataView" /> class with the specified <see cref="T:System.Data.DataTable" />.</summary>
	/// <param name="table">A <see cref="T:System.Data.DataTable" /> to add to the <see cref="T:System.Data.DataView" />.</param>
	public DataView(DataTable table)
	{
	}

	/// <summary>Adds a new row to the <see cref="T:System.Data.DataView" />.</summary>
	/// <returns>A new <see cref="T:System.Data.DataRowView" /> object.</returns>
	public virtual DataRowView AddNew()
	{
		return null;
	}

	private void CheckOpen()
	{
	}

	private void CheckSort(string sort)
	{
	}

	/// <summary>Closes the <see cref="T:System.Data.DataView" />.</summary>
	protected void Close()
	{
	}

	/// <summary>Copies items into an array. Only for Web Forms Interfaces.</summary>
	/// <param name="array">array to copy into.</param>
	/// <param name="index">index to start at.</param>
	public void CopyTo(Array array, int index)
	{
	}

	private void CopyTo(DataRowView[] array, int index)
	{
	}

	/// <summary>Deletes a row at the specified index.</summary>
	/// <param name="index">The index of the row to delete.</param>
	public void Delete(int index)
	{
	}

	internal void Delete(DataRow row)
	{
	}

	/// <summary>Disposes of the resources (other than memory) used by the <see cref="T:System.Data.DataView" /> object.</summary>
	/// <param name="disposing">
	///   <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
	}

	internal void FinishAddNew(bool success)
	{
	}

	/// <summary>Gets an enumerator for this <see cref="T:System.Data.DataView" />.</summary>
	/// <returns>An <see cref="T:System.Collections.IEnumerator" /> for navigating through the list.</returns>
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	/// <summary>For a description of this member, see <see cref="M:System.Collections.IList.Add(System.Object)" />.</summary>
	/// <param name="value">An <see cref="T:System.Object" /> value.</param>
	/// <returns>For a description of this member, see <see cref="M:System.Collections.IList.Add(System.Object)" />.</returns>
	int IList.Add(object value)
	{
		return 0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.Collections.IList.Clear" />.</summary>
	void IList.Clear()
	{
	}

	/// <summary>For a description of this member, see <see cref="M:System.Collections.IList.Contains(System.Object)" />.</summary>
	/// <param name="value">An <see cref="T:System.Object" /> value.</param>
	/// <returns>For a description of this member, see <see cref="M:System.Collections.IList.Contains(System.Object)" />.</returns>
	bool IList.Contains(object value)
	{
		return false;
	}

	/// <summary>For a description of this member, see <see cref="M:System.Collections.IList.IndexOf(System.Object)" />.</summary>
	/// <param name="value">An <see cref="T:System.Object" /> value.</param>
	/// <returns>For a description of this member, see <see cref="M:System.Collections.IList.IndexOf(System.Object)" />.</returns>
	int IList.IndexOf(object value)
	{
		return 0;
	}

	internal int IndexOf(DataRowView rowview)
	{
		return 0;
	}

	private int IndexOfDataRowView(DataRowView rowview)
	{
		return 0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.Collections.IList.Insert(System.Int32,System.Object)" />.</summary>
	/// <param name="index">An <see cref="T:System.Int32" /> value.</param>
	/// <param name="value">An <see cref="T:System.Object" /> value to be inserted.</param>
	void IList.Insert(int index, object value)
	{
	}

	/// <summary>For a description of this member, see <see cref="M:System.Collections.IList.Remove(System.Object)" />.</summary>
	/// <param name="value">An <see cref="T:System.Object" /> value.</param>
	void IList.Remove(object value)
	{
	}

	/// <summary>For a description of this member, see <see cref="M:System.Collections.IList.RemoveAt(System.Int32)" />.</summary>
	/// <param name="index">An <see cref="T:System.Int32" /> value.</param>
	void IList.RemoveAt(int index)
	{
	}

	internal Index GetFindIndex(string column, bool keepIndex)
	{
		return null;
	}

	/// <summary>For a description of this member, see <see cref="M:System.ComponentModel.IBindingList.AddNew" />.</summary>
	/// <returns>The item added to the list.</returns>
	object IBindingList.AddNew()
	{
		return null;
	}

	internal PropertyDescriptor GetSortProperty()
	{
		return null;
	}

	/// <summary>For a description of this member, see <see cref="M:System.ComponentModel.IBindingList.AddIndex(System.ComponentModel.PropertyDescriptor)" />.</summary>
	/// <param name="property">A <see cref="T:System.ComponentModel.PropertyDescriptor" /> object.</param>
	void IBindingList.AddIndex(PropertyDescriptor property)
	{
	}

	/// <summary>For a description of this member, see <see cref="M:System.ComponentModel.IBindingList.ApplySort(System.ComponentModel.PropertyDescriptor,System.ComponentModel.ListSortDirection)" />.</summary>
	/// <param name="property">A <see cref="T:System.ComponentModel.PropertyDescriptor" /> object.</param>
	/// <param name="direction">A <see cref="T:System.ComponentModel.ListSortDirection" /> object.</param>
	void IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction)
	{
	}

	/// <summary>For a description of this member, see <see cref="M:System.ComponentModel.IBindingList.Find(System.ComponentModel.PropertyDescriptor,System.Object)" />.</summary>
	/// <param name="property">A <see cref="T:System.ComponentModel.PropertyDescriptor" /> object.</param>
	/// <param name="key">An <see cref="T:System.Object" /> value.</param>
	/// <returns>For a description of this member, see <see cref="M:System.ComponentModel.IBindingList.Find(System.ComponentModel.PropertyDescriptor,System.Object)" />.</returns>
	int IBindingList.Find(PropertyDescriptor property, object key)
	{
		return 0;
	}

	/// <summary>For a description of this member, see <see cref="M:System.ComponentModel.IBindingList.RemoveIndex(System.ComponentModel.PropertyDescriptor)" />.</summary>
	/// <param name="property">A <see cref="T:System.ComponentModel.PropertyDescriptor" /> object.</param>
	void IBindingList.RemoveIndex(PropertyDescriptor property)
	{
	}

	/// <summary>For a description of this member, see <see cref="M:System.ComponentModel.IBindingList.RemoveSort" />.</summary>
	void IBindingList.RemoveSort()
	{
	}

	private string CreateSortString(PropertyDescriptor property, ListSortDirection direction)
	{
		return null;
	}

	/// <summary>For a description of this member, see <see cref="M:System.ComponentModel.ITypedList.GetListName(System.ComponentModel.PropertyDescriptor[])" />.</summary>
	/// <param name="listAccessors">An array of <see cref="T:System.ComponentModel.PropertyDescriptor" /> objects.</param>
	/// <returns>For a description of this member, see <see cref="M:System.ComponentModel.ITypedList.GetListName(System.ComponentModel.PropertyDescriptor[])" />.</returns>
	string ITypedList.GetListName(PropertyDescriptor[] listAccessors)
	{
		return null;
	}

	/// <summary>For a description of this member, see <see cref="M:System.ComponentModel.ITypedList.GetItemProperties(System.ComponentModel.PropertyDescriptor[])" />.</summary>
	/// <param name="listAccessors">An array of <see cref="T:System.ComponentModel.PropertyDescriptor" /> objects to find in the collection as bindable. This can be <see langword="null" />.</param>
	PropertyDescriptorCollection ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors)
	{
		return null;
	}

	internal virtual IFilter GetFilter()
	{
		return null;
	}

	private int GetRecord(int recordIndex)
	{
		return 0;
	}

	internal DataRow GetRow(int index)
	{
		return null;
	}

	private DataRowView GetRowView(int record)
	{
		return null;
	}

	private DataRowView GetRowView(DataRow dr)
	{
		return null;
	}

	/// <summary>Occurs after a <see cref="T:System.Data.DataView" /> has been changed successfully.</summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">A <see cref="T:System.ComponentModel.ListChangedEventArgs" /> that contains the event data.</param>
	protected virtual void IndexListChanged(object sender, ListChangedEventArgs e)
	{
	}

	internal void IndexListChangedInternal(ListChangedEventArgs e)
	{
	}

	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove)
	{
	}

	/// <summary>Raises the <see cref="E:System.Data.DataView.ListChanged" /> event.</summary>
	/// <param name="e">A <see cref="T:System.ComponentModel.ListChangedEventArgs" /> that contains the event data.</param>
	protected virtual void OnListChanged(ListChangedEventArgs e)
	{
	}

	/// <summary>Reserved for internal use only.</summary>
	protected void Reset()
	{
	}

	internal void ResetRowViewCache()
	{
	}

	internal void SetDataViewManager(DataViewManager dataViewManager)
	{
	}

	internal virtual void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter)
	{
	}

	internal void SetIndex2(string newSort, DataViewRowState newRowStates, IFilter newRowFilter, bool fireEvent)
	{
	}

	/// <summary>Reserved for internal use only.</summary>
	protected void UpdateIndex()
	{
	}

	/// <summary>Reserved for internal use only.</summary>
	/// <param name="force">Reserved for internal use only.</param>
	protected virtual void UpdateIndex(bool force)
	{
	}

	internal void UpdateIndex(bool force, bool fireEvent)
	{
	}

	internal void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e)
	{
	}

	internal void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e)
	{
	}

	/// <summary>Occurs after a <see cref="T:System.Data.DataColumnCollection" /> has been changed successfully.</summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">A <see cref="T:System.ComponentModel.ListChangedEventArgs" /> that contains the event data.</param>
	protected virtual void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e)
	{
	}

	internal void ColumnCollectionChangedInternal(object sender, CollectionChangeEventArgs e)
	{
	}
}
