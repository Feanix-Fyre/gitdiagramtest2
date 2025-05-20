namespace UnityEngine.Rendering.Universal;

internal class DecalSkipCulledSystem
{
	private DecalEntityManager m_EntityManager;

	private ProfilingSampler m_Sampler;

	private Camera m_Camera;

	public DecalSkipCulledSystem(DecalEntityManager entityManager)
	{
	}

	public void Execute(Camera camera)
	{
	}

	private void Execute(DecalCulledChunk culledChunk, int count)
	{
	}

	internal static ulong GetSceneCullingMaskFromCamera(Camera camera)
	{
		return 0uL;
	}
}
