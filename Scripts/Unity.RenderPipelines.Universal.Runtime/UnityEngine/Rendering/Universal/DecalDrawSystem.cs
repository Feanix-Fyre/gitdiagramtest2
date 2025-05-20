namespace UnityEngine.Rendering.Universal;

internal abstract class DecalDrawSystem
{
	protected DecalEntityManager m_EntityManager;

	private Matrix4x4[] m_WorldToDecals;

	private Matrix4x4[] m_NormalToDecals;

	private float[] m_DecalLayerMasks;

	private ProfilingSampler m_Sampler;

	public Material overrideMaterial { get; set; }

	public DecalDrawSystem(string sampler, DecalEntityManager entityManager)
	{
	}

	public void Execute(CommandBuffer cmd)
	{
	}

	protected virtual Material GetMaterial(DecalEntityChunk decalEntityChunk)
	{
		return null;
	}

	protected abstract int GetPassIndex(DecalCachedChunk decalCachedChunk);

	private void Execute(CommandBuffer cmd, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk, int count)
	{
	}

	private void Draw(CommandBuffer cmd, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk, int passIndex)
	{
	}

	private void DrawInstanced(CommandBuffer cmd, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk, int passIndex)
	{
	}

	public void Execute(in CameraData cameraData)
	{
	}

	private void Execute(in CameraData cameraData, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk, int count)
	{
	}

	private void Draw(in CameraData cameraData, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk)
	{
	}

	private void DrawInstanced(in CameraData cameraData, DecalEntityChunk decalEntityChunk, DecalCachedChunk decalCachedChunk, DecalDrawCallChunk decalDrawCallChunk)
	{
	}
}
