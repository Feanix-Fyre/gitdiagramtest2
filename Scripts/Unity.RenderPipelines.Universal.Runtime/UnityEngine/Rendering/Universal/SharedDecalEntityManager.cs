using System;

namespace UnityEngine.Rendering.Universal;

internal class SharedDecalEntityManager : IDisposable
{
	private DecalEntityManager m_DecalEntityManager;

	private int m_ReferenceCounter;

	public DecalEntityManager Get()
	{
		return null;
	}

	public void Release(DecalEntityManager decalEntityManager)
	{
	}

	public void Dispose()
	{
	}

	private void OnDecalAdd(DecalProjector decalProjector)
	{
	}

	private void OnDecalRemove(DecalProjector decalProjector)
	{
	}

	private void OnDecalPropertyChange(DecalProjector decalProjector)
	{
	}

	private void OnAllDecalPropertyChange()
	{
	}

	private void OnDecalMaterialChange(DecalProjector decalProjector)
	{
	}
}
