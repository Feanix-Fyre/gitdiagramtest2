namespace UnityEngine.Rendering.Universal;

internal class DecalDrawScreenSpaceSystem : DecalDrawSystem
{
	public DecalDrawScreenSpaceSystem(DecalEntityManager entityManager)
		: base(null, null)
	{
	}

	protected override int GetPassIndex(DecalCachedChunk decalCachedChunk)
	{
		return 0;
	}
}
