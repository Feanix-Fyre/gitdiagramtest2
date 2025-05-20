using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering.Universal;

internal class DecalEntityManager : IDisposable
{
	private struct CombinedChunks
	{
		public DecalEntityChunk entityChunk;

		public DecalCachedChunk cachedChunk;

		public DecalCulledChunk culledChunk;

		public DecalDrawCallChunk drawCallChunk;

		public int previousChunkIndex;

		public bool valid;
	}

	public List<DecalEntityChunk> entityChunks;

	public List<DecalCachedChunk> cachedChunks;

	public List<DecalCulledChunk> culledChunks;

	public List<DecalDrawCallChunk> drawCallChunks;

	public int chunkCount;

	private ProfilingSampler m_AddDecalSampler;

	private ProfilingSampler m_ResizeChunks;

	private ProfilingSampler m_SortChunks;

	private DecalEntityIndexer m_DecalEntityIndexer;

	private Dictionary<Material, int> m_MaterialToChunkIndex;

	private List<CombinedChunks> m_CombinedChunks;

	private List<int> m_CombinedChunkRemmap;

	private Material m_ErrorMaterial;

	private Mesh m_DecalProjectorMesh;

	public Material errorMaterial => null;

	public Mesh decalProjectorMesh => null;

	public bool IsValid(DecalEntity decalEntity)
	{
		return false;
	}

	public DecalEntity CreateDecalEntity(DecalProjector decalProjector)
	{
		return default(DecalEntity);
	}

	private int CreateChunkIndex(Material material)
	{
		return 0;
	}

	public void UpdateAllDecalEntitiesData()
	{
	}

	public void UpdateDecalEntityData(DecalEntity decalEntity, DecalProjector decalProjector)
	{
	}

	public void DestroyDecalEntity(DecalEntity decalEntity)
	{
	}

	public void Update()
	{
	}

	public void Dispose()
	{
	}
}
