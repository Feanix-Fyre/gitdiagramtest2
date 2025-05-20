namespace UnityEngine.UIElements.UIR;

internal class GPUBufferAllocator
{
	private BestFitAllocator m_Low;

	private BestFitAllocator m_High;

	public bool isEmpty => false;

	public GPUBufferAllocator(uint maxSize)
	{
	}

	public Alloc Allocate(uint size, bool shortLived)
	{
		return default(Alloc);
	}

	public void Free(Alloc alloc)
	{
	}

	private bool HighLowCollide()
	{
		return false;
	}
}
