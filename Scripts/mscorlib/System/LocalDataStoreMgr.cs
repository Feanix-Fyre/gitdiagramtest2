using System.Collections.Generic;

namespace System;

internal sealed class LocalDataStoreMgr
{
	private const int InitialSlotTableSize = 64;

	private const int SlotTableDoubleThreshold = 512;

	private const int LargeSlotTableSizeIncrease = 128;

	private bool[] m_SlotInfoTable;

	private int m_FirstAvailableSlot;

	private List<LocalDataStore> m_ManagedLocalDataStores;

	private Dictionary<string, LocalDataStoreSlot> m_KeyToSlotMap;

	private long m_CookieGenerator;

	public LocalDataStoreHolder CreateLocalDataStore()
	{
		return null;
	}

	public void DeleteLocalDataStore(LocalDataStore store)
	{
	}

	public LocalDataStoreSlot AllocateDataSlot()
	{
		return null;
	}

	public LocalDataStoreSlot AllocateNamedDataSlot(string name)
	{
		return null;
	}

	public LocalDataStoreSlot GetNamedDataSlot(string name)
	{
		return null;
	}

	public void FreeNamedDataSlot(string name)
	{
	}

	internal void FreeDataSlot(int slot, long cookie)
	{
	}

	public void ValidateSlot(LocalDataStoreSlot slot)
	{
	}

	internal int GetSlotTableLength()
	{
		return 0;
	}
}
