using System.Collections.Generic;

namespace UnityEngine.UIElements.UIR;

internal class DetachedAllocator
{
	private TempAllocator<Vertex> m_VertsPool;

	private TempAllocator<ushort> m_IndexPool;

	private List<MeshWriteData> m_MeshWriteDataPool;

	private int m_MeshWriteDataCount;

	private bool m_Disposed;

	public void Dispose()
	{
	}

	protected void Dispose(bool disposing)
	{
	}
}
