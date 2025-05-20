using System.Collections.Generic;

namespace UnityEngine.UIElements.UIR;

internal struct BitmapAllocator32
{
	private struct Page
	{
		public ushort x;

		public ushort y;

		public int freeSlots;
	}

	private int m_PageHeight;

	private List<Page> m_Pages;

	private List<uint> m_AllocMap;

	private int m_EntryWidth;

	private int m_EntryHeight;

	public int entryWidth => 0;

	public int entryHeight => 0;

	public void Construct(int pageHeight, int entryWidth = 1, int entryHeight = 1)
	{
	}

	public void ForceFirstAlloc(ushort firstPageX, ushort firstPageY)
	{
	}

	public BMPAlloc Allocate(BaseShaderInfoStorage storage)
	{
		return default(BMPAlloc);
	}

	public void Free(BMPAlloc alloc)
	{
	}

	internal void GetAllocPageAtlasLocation(int page, out ushort x, out ushort y)
	{
		x = default(ushort);
		y = default(ushort);
	}

	private static byte CountTrailingZeroes(uint val)
	{
		return 0;
	}
}
