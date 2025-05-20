using System.Collections.Generic;

namespace UnityEngine.Rendering.Universal;

internal class DecalEntityIndexer
{
	public struct DecalEntityItem
	{
		public int chunkIndex;

		public int arrayIndex;

		public int version;
	}

	private List<DecalEntityItem> m_Entities;

	private Queue<int> m_FreeIndices;

	public bool IsValid(DecalEntity decalEntity)
	{
		return false;
	}

	public DecalEntity CreateDecalEntity(int arrayIndex, int chunkIndex)
	{
		return default(DecalEntity);
	}

	public void DestroyDecalEntity(DecalEntity decalEntity)
	{
	}

	public DecalEntityItem GetItem(DecalEntity decalEntity)
	{
		return default(DecalEntityItem);
	}

	public void UpdateIndex(DecalEntity decalEntity, int newArrayIndex)
	{
	}

	public void RemapChunkIndices(List<int> remaper)
	{
	}

	public void Clear()
	{
	}
}
