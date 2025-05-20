namespace System;

internal sealed class LocalDataStoreHolder
{
	private LocalDataStore m_Store;

	public LocalDataStore Store => null;

	public LocalDataStoreHolder(LocalDataStore store)
	{
	}

	~LocalDataStoreHolder()
	{
	}
}
