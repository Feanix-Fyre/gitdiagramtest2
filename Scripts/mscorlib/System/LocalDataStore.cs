namespace System;

internal sealed class LocalDataStore
{
	private LocalDataStoreElement[] m_DataTable;

	private LocalDataStoreMgr m_Manager;

	public LocalDataStore(LocalDataStoreMgr mgr, int InitialCapacity)
	{
	}

	internal void Dispose()
	{
	}

	public object GetData(LocalDataStoreSlot slot)
	{
		return null;
	}

	public void SetData(LocalDataStoreSlot slot, object data)
	{
	}

	internal void FreeData(int slot, long cookie)
	{
	}

	private LocalDataStoreElement PopulateElement(LocalDataStoreSlot slot)
	{
		return null;
	}
}
