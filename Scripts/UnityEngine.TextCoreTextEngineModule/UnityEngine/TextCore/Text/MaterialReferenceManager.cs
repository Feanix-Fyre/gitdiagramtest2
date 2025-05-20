using System.Collections.Generic;

namespace UnityEngine.TextCore.Text;

internal class MaterialReferenceManager
{
	private static MaterialReferenceManager s_Instance;

	private Dictionary<int, Material> m_FontMaterialReferenceLookup;

	private Dictionary<int, FontAsset> m_FontAssetReferenceLookup;

	private Dictionary<int, SpriteAsset> m_SpriteAssetReferenceLookup;

	private Dictionary<int, TextColorGradient> m_ColorGradientReferenceLookup;

	public static MaterialReferenceManager instance => null;

	public static void AddFontAsset(FontAsset fontAsset)
	{
	}

	private void AddFontAssetInternal(FontAsset fontAsset)
	{
	}

	public static void AddSpriteAsset(int hashCode, SpriteAsset spriteAsset)
	{
	}

	private void AddSpriteAssetInternal(int hashCode, SpriteAsset spriteAsset)
	{
	}

	public static void AddFontMaterial(int hashCode, Material material)
	{
	}

	private void AddFontMaterialInternal(int hashCode, Material material)
	{
	}

	public static void AddColorGradientPreset(int hashCode, TextColorGradient spriteAsset)
	{
	}

	private void AddColorGradientPreset_Internal(int hashCode, TextColorGradient spriteAsset)
	{
	}

	public static bool TryGetFontAsset(int hashCode, out FontAsset fontAsset)
	{
		fontAsset = null;
		return false;
	}

	private bool TryGetFontAssetInternal(int hashCode, out FontAsset fontAsset)
	{
		fontAsset = null;
		return false;
	}

	public static bool TryGetSpriteAsset(int hashCode, out SpriteAsset spriteAsset)
	{
		spriteAsset = null;
		return false;
	}

	private bool TryGetSpriteAssetInternal(int hashCode, out SpriteAsset spriteAsset)
	{
		spriteAsset = null;
		return false;
	}

	public static bool TryGetColorGradientPreset(int hashCode, out TextColorGradient gradientPreset)
	{
		gradientPreset = null;
		return false;
	}

	private bool TryGetColorGradientPresetInternal(int hashCode, out TextColorGradient gradientPreset)
	{
		gradientPreset = null;
		return false;
	}

	public static bool TryGetMaterial(int hashCode, out Material material)
	{
		material = null;
		return false;
	}

	private bool TryGetMaterialInternal(int hashCode, out Material material)
	{
		material = null;
		return false;
	}
}
