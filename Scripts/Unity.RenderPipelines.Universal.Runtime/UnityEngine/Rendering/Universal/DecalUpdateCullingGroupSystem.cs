namespace UnityEngine.Rendering.Universal;

internal class DecalUpdateCullingGroupSystem
{
	private float[] m_BoundingDistance;

	private Camera m_Camera;

	private DecalEntityManager m_EntityManager;

	private ProfilingSampler m_Sampler;

	public float boundingDistance
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public DecalUpdateCullingGroupSystem(DecalEntityManager entityManager, float drawDistance)
	{
	}

	public void Execute(Camera camera)
	{
	}

	public void Execute(DecalCachedChunk cachedChunk, DecalCulledChunk culledChunk, int count)
	{
	}

	internal static ulong GetSceneCullingMaskFromCamera(Camera camera)
	{
		return 0uL;
	}
}
