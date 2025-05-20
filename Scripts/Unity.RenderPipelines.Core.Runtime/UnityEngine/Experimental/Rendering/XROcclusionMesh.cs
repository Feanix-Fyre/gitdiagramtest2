using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering;

internal class XROcclusionMesh
{
	private XRPass m_Pass;

	private Mesh m_CombinedMesh;

	private Material m_Material;

	private int m_CombinedMeshHashCode;

	private static readonly ProfilingSampler k_OcclusionMeshProfilingSampler;

	internal bool hasValidOcclusionMesh => false;

	internal XROcclusionMesh(XRPass xrPass)
	{
	}

	internal void SetMaterial(Material mat)
	{
	}

	internal void RenderOcclusionMesh(CommandBuffer cmd)
	{
	}

	internal void UpdateCombinedMesh()
	{
	}

	private bool IsOcclusionMeshSupported()
	{
		return false;
	}

	private bool TryGetOcclusionMeshCombinedHashCode(out int hashCode)
	{
		hashCode = default(int);
		return false;
	}

	private void CreateOcclusionMeshCombined()
	{
	}
}
