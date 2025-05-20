namespace UnityEngine.UIElements;

internal struct CountingBloomFilter
{
	private unsafe fixed byte m_Counters[16384];

	private void AdjustSlot(uint index, bool increment)
	{
	}

	private uint Hash1(uint hash)
	{
		return 0u;
	}

	private uint Hash2(uint hash)
	{
		return 0u;
	}

	private bool IsSlotEmpty(uint index)
	{
		return false;
	}

	public void InsertHash(uint hash)
	{
	}

	public void RemoveHash(uint hash)
	{
	}

	public bool ContainsHash(uint hash)
	{
		return false;
	}
}
