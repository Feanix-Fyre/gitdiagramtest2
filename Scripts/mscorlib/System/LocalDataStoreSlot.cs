using System.Runtime.InteropServices;

namespace System;

/// <summary>Encapsulates a memory slot to store local data. This class cannot be inherited.</summary>
[ComVisible(true)]
public sealed class LocalDataStoreSlot
{
	private LocalDataStoreMgr m_mgr;

	private int m_slot;

	private long m_cookie;

	internal LocalDataStoreMgr Manager => null;

	internal int Slot => 0;

	internal long Cookie => 0L;

	internal LocalDataStoreSlot(LocalDataStoreMgr mgr, int slot, long cookie)
	{
	}

	/// <summary>Ensures that resources are freed and other cleanup operations are performed when the garbage collector reclaims the <see cref="T:System.LocalDataStoreSlot" /> object.</summary>
	~LocalDataStoreSlot()
	{
	}
}
