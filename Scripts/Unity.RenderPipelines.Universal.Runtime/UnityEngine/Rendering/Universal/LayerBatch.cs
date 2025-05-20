namespace UnityEngine.Rendering.Universal;

internal struct LayerBatch
{
	public int startLayerID;

	public int endLayerValue;

	public SortingLayerRange layerRange;

	public LightStats lightStats;

	private unsafe fixed int renderTargetIds[4];

	private unsafe fixed bool renderTargetUsed[4];

	public void InitRTIds(int index)
	{
	}

	public RenderTargetIdentifier GetRTId(CommandBuffer cmd, RenderTextureDescriptor desc, int index)
	{
		return default(RenderTargetIdentifier);
	}

	public void ReleaseRT(CommandBuffer cmd)
	{
	}
}
