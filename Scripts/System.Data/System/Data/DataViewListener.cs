using System.ComponentModel;

namespace System.Data;

internal sealed class DataViewListener
{
	private readonly WeakReference _dvWeak;

	private DataTable _table;

	private Index _index;

	internal readonly int _objectID;

	internal DataViewListener(DataView dv)
	{
	}

	private void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e)
	{
	}

	private void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e)
	{
	}

	private void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e)
	{
	}

	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove)
	{
	}

	internal void IndexListChanged(ListChangedEventArgs e)
	{
	}

	internal void RegisterMetaDataEvents(DataTable table)
	{
	}

	internal void UnregisterMetaDataEvents()
	{
	}

	private void UnregisterMetaDataEvents(bool updateListeners)
	{
	}

	internal void RegisterListChangedEvent(Index index)
	{
	}

	internal void UnregisterListChangedEvent()
	{
	}

	private void CleanUp(bool updateListeners)
	{
	}

	private void RegisterListener(DataTable table)
	{
	}
}
