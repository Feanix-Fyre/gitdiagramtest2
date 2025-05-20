namespace System;

internal sealed class LocalDataStoreElement
{
	private object m_value;

	private long m_cookie;

	public object Value
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public long Cookie => 0L;

	public LocalDataStoreElement(long cookie)
	{
	}
}
