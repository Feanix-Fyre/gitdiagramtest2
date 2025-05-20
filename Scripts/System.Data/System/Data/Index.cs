using System.Collections.Generic;
using System.ComponentModel;

namespace System.Data;

internal sealed class Index
{
	private sealed class IndexTree : RBTree<int>
	{
		private readonly Index _index;

		internal IndexTree(Index index)
			: base(default(TreeAccessMethod))
		{
		}

		protected override int CompareNode(int record1, int record2)
		{
			return 0;
		}

		protected override int CompareSateliteTreeNode(int record1, int record2)
		{
			return 0;
		}
	}

	private readonly DataTable _table;

	internal readonly IndexField[] _indexFields;

	private readonly Comparison<DataRow> _comparison;

	private readonly DataViewRowState _recordStates;

	private WeakReference _rowFilter;

	private IndexTree _records;

	private int _recordCount;

	private int _refCount;

	private Listeners<DataViewListener> _listeners;

	private bool _suspendEvents;

	private readonly bool _isSharable;

	private readonly bool _hasRemoteAggregate;

	private static int s_objectTypeCount;

	private readonly int _objectID;

	internal bool HasRemoteAggregate => false;

	internal int ObjectID => 0;

	public DataViewRowState RecordStates => default(DataViewRowState);

	public IFilter RowFilter => null;

	public bool HasDuplicates => false;

	public int RecordCount => 0;

	public int RefCount => 0;

	private bool DoListChanged => false;

	internal DataTable Table => null;

	public Index(DataTable table, IndexField[] indexFields, DataViewRowState recordStates, IFilter rowFilter)
	{
	}

	public Index(DataTable table, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter)
	{
	}

	private static IndexField[] GetAllFields(DataColumnCollection columns)
	{
		return null;
	}

	private Index(DataTable table, IndexField[] indexFields, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter)
	{
	}

	public bool Equal(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter)
	{
		return false;
	}

	public int GetRecord(int recordIndex)
	{
		return 0;
	}

	private bool AcceptRecord(int record)
	{
		return false;
	}

	private bool AcceptRecord(int record, IFilter filter)
	{
		return false;
	}

	internal void ListChangedAdd(DataViewListener listener)
	{
	}

	internal void ListChangedRemove(DataViewListener listener)
	{
	}

	public void AddRef()
	{
	}

	public int RemoveRef()
	{
		return 0;
	}

	private void ApplyChangeAction(int record, int action, int changeRecord)
	{
	}

	public bool CheckUnique()
	{
		return false;
	}

	private int CompareRecords(int record1, int record2)
	{
		return 0;
	}

	private int CompareDataRows(int record1, int record2)
	{
		return 0;
	}

	private int CompareDuplicateRecords(int record1, int record2)
	{
		return 0;
	}

	private int CompareRecordToKey(int record1, object[] vals)
	{
		return 0;
	}

	public void DeleteRecordFromIndex(int recordIndex)
	{
	}

	private void DeleteRecord(int recordIndex)
	{
	}

	private void DeleteRecord(int recordIndex, bool fireEvent)
	{
	}

	public RBTree<int>.RBTreeEnumerator GetEnumerator(int startIndex)
	{
		return default(RBTree<int>.RBTreeEnumerator);
	}

	public int GetIndex(int record)
	{
		return 0;
	}

	private int GetIndex(int record, int changeRecord)
	{
		return 0;
	}

	public object[] GetUniqueKeyValues()
	{
		return null;
	}

	private int FindNodeByKey(object originalKey)
	{
		return 0;
	}

	private int FindNodeByKeys(object[] originalKey)
	{
		return 0;
	}

	private int FindNodeByKeyRecord(int record)
	{
		return 0;
	}

	private Range GetRangeFromNode(int nodeId)
	{
		return default(Range);
	}

	public Range FindRecords(object key)
	{
		return default(Range);
	}

	public Range FindRecords(object[] key)
	{
		return default(Range);
	}

	internal void FireResetEvent()
	{
	}

	private int GetChangeAction(DataViewRowState oldState, DataViewRowState newState)
	{
		return 0;
	}

	private static int GetReplaceAction(DataViewRowState oldState)
	{
		return 0;
	}

	public DataRow GetRow(int i)
	{
		return null;
	}

	public DataRow[] GetRows(object[] values)
	{
		return null;
	}

	public DataRow[] GetRows(Range range)
	{
		return null;
	}

	private void InitRecords(IFilter filter)
	{
	}

	public int InsertRecordToIndex(int record)
	{
		return 0;
	}

	private int InsertRecord(int record, bool fireEvent)
	{
		return 0;
	}

	public bool IsKeyInIndex(object key)
	{
		return false;
	}

	public bool IsKeyInIndex(object[] key)
	{
		return false;
	}

	public bool IsKeyRecordInIndex(int record)
	{
		return false;
	}

	private void OnListChanged(ListChangedType changedType, int newIndex, int oldIndex)
	{
	}

	private void OnListChanged(ListChangedType changedType, int index)
	{
	}

	private void OnListChanged(ListChangedEventArgs e)
	{
	}

	private void MaintainDataView(ListChangedType changedType, int record, bool trackAddRemove)
	{
	}

	public void Reset()
	{
	}

	public void RecordChanged(int record)
	{
	}

	public void RecordChanged(int oldIndex, int newIndex)
	{
	}

	public void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState)
	{
	}

	public void RecordStateChanged(int oldRecord, DataViewRowState oldOldState, DataViewRowState oldNewState, int newRecord, DataViewRowState newOldState, DataViewRowState newNewState)
	{
	}

	private void GetUniqueKeyValues(List<object[]> list, int curNodeId)
	{
	}

	internal static int IndexOfReference<T>(List<T> list, T item) where T : class
	{
		return 0;
	}
}
