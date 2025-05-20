namespace UnityEngine.Rendering.Universal;

internal class DecalDrawErrorSystem : DecalDrawSystem
{
	private DecalTechnique m_Technique;

	public DecalDrawErrorSystem(DecalEntityManager entityManager, DecalTechnique technique)
		: base(null, null)
	{
	}

	protected override int GetPassIndex(DecalCachedChunk decalCachedChunk)
	{
		return 0;
	}

	protected override Material GetMaterial(DecalEntityChunk decalEntityChunk)
	{
		return null;
	}
}
