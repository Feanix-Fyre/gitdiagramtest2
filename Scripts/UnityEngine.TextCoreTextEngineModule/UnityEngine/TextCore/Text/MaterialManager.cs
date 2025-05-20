using System.Collections.Generic;

namespace UnityEngine.TextCore.Text;

internal static class MaterialManager
{
	private static Dictionary<long, Material> s_FallbackMaterials;

	public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial)
	{
		return null;
	}

	public static Material GetFallbackMaterial(FontAsset fontAsset, Material sourceMaterial, int atlasIndex)
	{
		return null;
	}

	private static void CopyMaterialPresetProperties(Material source, Material destination)
	{
	}
}
