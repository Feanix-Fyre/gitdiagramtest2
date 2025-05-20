using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal;

internal sealed class TaaPersistentData
{
	private static GraphicsFormat[] formatList;

	private RenderTextureDescriptor m_RtDesc;

	private RTHandle m_AccumulationTexture;

	private RTHandle m_AccumulationTexture2;

	private int m_LastAccumUpdateFrameIndex;

	private int m_LastAccumUpdateFrameIndex2;

	public RenderTextureDescriptor rtd => default(RenderTextureDescriptor);

	public RTHandle accumulationTexture(int index)
	{
		return null;
	}

	public int GetLastAccumFrameIndex(int index)
	{
		return 0;
	}

	public void SetLastAccumFrameIndex(int index, int value)
	{
	}

	public void Init(int sizeX, int sizeY, int volumeDepth, GraphicsFormat format, VRTextureUsage vrUsage, TextureDimension texDim)
	{
	}

	public bool AllocateTargets(bool xrMultipassEnabled = false)
	{
		return false;
	}

	public void DeallocateTargets()
	{
	}
}
