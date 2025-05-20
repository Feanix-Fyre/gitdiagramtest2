namespace UnityEngine.Rendering.Universal;

internal class DecalDrawGBufferSystem : DecalDrawSystem
{
	public DecalDrawGBufferSystem(DecalEntityManager entityManager)
		: base(null, null)
	{
	}

	protected override int GetPassIndex(DecalCachedChunk decalCachedChunk)
	{
		return 0;
	}
}
