using System.Collections.Generic;

namespace UnityEngine.TextCore.Text;

internal struct MaterialReference
{
	public int index;

	public FontAsset fontAsset;

	public SpriteAsset spriteAsset;

	public Material material;

	public bool isDefaultMaterial;

	public bool isFallbackMaterial;

	public Material fallbackMaterial;

	public float padding;

	public int referenceCount;

	public MaterialReference(int index, FontAsset fontAsset, SpriteAsset spriteAsset, Material material, float padding)
	{
		this.index = 0;
		this.fontAsset = null;
		this.spriteAsset = null;
		this.material = null;
		isDefaultMaterial = false;
		isFallbackMaterial = false;
		fallbackMaterial = null;
		this.padding = 0f;
		referenceCount = 0;
	}

	public static int AddMaterialReference(Material material, FontAsset fontAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup)
	{
		return 0;
	}

	public static int AddMaterialReference(Material material, SpriteAsset spriteAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup)
	{
		return 0;
	}
}
