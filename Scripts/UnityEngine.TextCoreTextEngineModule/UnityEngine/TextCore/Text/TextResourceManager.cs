using System.Collections.Generic;

namespace UnityEngine.TextCore.Text;

internal class TextResourceManager
{
	private struct FontAssetRef
	{
		public int nameHashCode;

		public int familyNameHashCode;

		public int styleNameHashCode;

		public long familyNameAndStyleHashCode;

		public readonly FontAsset fontAsset;

		public FontAssetRef(int nameHashCode, int familyNameHashCode, int styleNameHashCode, FontAsset fontAsset)
		{
			this.nameHashCode = 0;
			this.familyNameHashCode = 0;
			this.styleNameHashCode = 0;
			familyNameAndStyleHashCode = 0L;
			this.fontAsset = null;
		}
	}

	private static readonly Dictionary<int, FontAssetRef> s_FontAssetReferences;

	private static readonly Dictionary<int, FontAsset> s_FontAssetNameReferenceLookup;

	private static readonly Dictionary<long, FontAsset> s_FontAssetFamilyNameAndStyleReferenceLookup;

	private static readonly List<int> s_FontAssetRemovalList;

	private static readonly int k_RegularStyleHashCode;

	internal static void AddFontAsset(FontAsset fontAsset)
	{
	}
}
