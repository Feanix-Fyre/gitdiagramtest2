namespace UnityEngine.Rendering.Universal;

internal class DecalDrawDBufferSystem : DecalDrawSystem
{
	public DecalDrawDBufferSystem(DecalEntityManager entityManager)
		: base(null, null)
	{
	}

	protected override int GetPassIndex(DecalCachedChunk decalCachedChunk)
	{
		return 0;
	}
}
