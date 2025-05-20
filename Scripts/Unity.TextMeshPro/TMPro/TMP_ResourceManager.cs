using System.Collections.Generic;

namespace TMPro;

public class TMP_ResourceManager
{
	private struct FontAssetRef
	{
		public int nameHashCode;

		public int familyNameHashCode;

		public int styleNameHashCode;

		public long familyNameAndStyleHashCode;

		public readonly TMP_FontAsset fontAsset;

		public FontAssetRef(int nameHashCode, int familyNameHashCode, int styleNameHashCode, TMP_FontAsset fontAsset)
		{
			this.nameHashCode = 0;
			this.familyNameHashCode = 0;
			this.styleNameHashCode = 0;
			familyNameAndStyleHashCode = 0L;
			this.fontAsset = null;
		}
	}

	private static TMP_Settings s_TextSettings;

	private static readonly Dictionary<int, FontAssetRef> s_FontAssetReferences;

	private static readonly Dictionary<int, TMP_FontAsset> s_FontAssetNameReferenceLookup;

	private static readonly Dictionary<long, TMP_FontAsset> s_FontAssetFamilyNameAndStyleReferenceLookup;

	private static readonly List<int> s_FontAssetRemovalList;

	private static readonly int k_RegularStyleHashCode;

	internal static TMP_Settings GetTextSettings()
	{
		return null;
	}

	public static void AddFontAsset(TMP_FontAsset fontAsset)
	{
	}

	public static void RemoveFontAsset(TMP_FontAsset fontAsset)
	{
	}

	internal static bool TryGetFontAssetByName(int nameHashcode, out TMP_FontAsset fontAsset)
	{
		fontAsset = null;
		return false;
	}

	internal static bool TryGetFontAssetByFamilyName(int familyNameHashCode, int styleNameHashCode, out TMP_FontAsset fontAsset)
	{
		fontAsset = null;
		return false;
	}

	public static void ClearFontAssetGlyphCache()
	{
	}

	internal static void RebuildFontAssetCache()
	{
	}
}
