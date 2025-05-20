using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements.UIR;

internal class TextureSlotManager
{
	internal static readonly int k_SlotCount;

	internal static readonly int k_SlotSize;

	internal static readonly int[] slotIds;

	internal static readonly int textureTableId;

	private TextureId[] m_Textures;

	private int[] m_Tickets;

	private int m_CurrentTicket;

	private int m_FirstUsedTicket;

	private Vector4[] m_GpuTextures;

	internal TextureRegistry textureRegistry;

	public int FreeSlots { get; private set; }

	static TextureSlotManager()
	{
	}

	public void Reset()
	{
	}

	public void StartNewBatch()
	{
	}

	public int IndexOf(TextureId id)
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void MarkUsed(int slotIndex)
	{
	}

	public int FindOldestSlot()
	{
		return 0;
	}

	public void Bind(TextureId id, float sdfScale, int slot, MaterialPropertyBlock mat)
	{
	}

	public void SetGpuData(int slotIndex, TextureId id, int textureWidth, int textureHeight, float sdfScale)
	{
	}
}
