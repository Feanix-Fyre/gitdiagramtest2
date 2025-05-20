using System.Collections.Generic;
using UnityEngine.Serialization;

namespace UnityEngine.TextCore.Text;

[HelpURL("https://docs.unity3d.com/2022.3/Documentation/Manual/UIE-sprite.html")]
[ExcludeFromPreset]
public class SpriteAsset : TextAsset
{
	internal Dictionary<int, int> m_NameLookup;

	internal Dictionary<uint, int> m_GlyphIndexLookup;

	[SerializeField]
	internal FaceInfo m_FaceInfo;

	[FormerlySerializedAs("spriteSheet")]
	[SerializeField]
	internal Texture m_SpriteAtlasTexture;

	[SerializeField]
	private List<SpriteCharacter> m_SpriteCharacterTable;

	internal Dictionary<uint, SpriteCharacter> m_SpriteCharacterLookup;

	[SerializeField]
	private List<SpriteGlyph> m_SpriteGlyphTable;

	internal Dictionary<uint, SpriteGlyph> m_SpriteGlyphLookup;

	[SerializeField]
	public List<SpriteAsset> fallbackSpriteAssets;

	internal bool m_IsSpriteAssetLookupTablesDirty;

	private static HashSet<int> k_searchedSpriteAssets;

	public FaceInfo faceInfo
	{
		get
		{
			return default(FaceInfo);
		}
		internal set
		{
		}
	}

	public Texture spriteSheet
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	public List<SpriteCharacter> spriteCharacterTable
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	public Dictionary<uint, SpriteCharacter> spriteCharacterLookupTable
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	public List<SpriteGlyph> spriteGlyphTable
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	private void Awake()
	{
	}

	public void UpdateLookupTables()
	{
	}

	public int GetSpriteIndexFromHashcode(int hashCode)
	{
		return 0;
	}

	public int GetSpriteIndexFromUnicode(uint unicode)
	{
		return 0;
	}

	public int GetSpriteIndexFromName(string name)
	{
		return 0;
	}

	public static SpriteAsset SearchForSpriteByUnicode(SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex)
	{
		spriteIndex = default(int);
		return null;
	}

	private static SpriteAsset SearchForSpriteByUnicodeInternal(List<SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex)
	{
		spriteIndex = default(int);
		return null;
	}

	private static SpriteAsset SearchForSpriteByUnicodeInternal(SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex)
	{
		spriteIndex = default(int);
		return null;
	}

	public static SpriteAsset SearchForSpriteByHashCode(SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex, TextSettings textSettings = null)
	{
		spriteIndex = default(int);
		return null;
	}

	private static SpriteAsset SearchForSpriteByHashCodeInternal(List<SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex)
	{
		spriteIndex = default(int);
		return null;
	}

	private static SpriteAsset SearchForSpriteByHashCodeInternal(SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex)
	{
		spriteIndex = default(int);
		return null;
	}

	public void SortGlyphTable()
	{
	}

	internal void SortCharacterTable()
	{
	}

	internal void SortGlyphAndCharacterTables()
	{
	}
}
