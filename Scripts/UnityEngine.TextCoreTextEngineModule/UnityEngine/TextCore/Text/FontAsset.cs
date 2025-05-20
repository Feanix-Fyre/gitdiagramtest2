using System;
using System.Collections.Generic;
using Unity.Profiling;
using UnityEngine.Serialization;
using UnityEngine.TextCore.LowLevel;

namespace UnityEngine.TextCore.Text;

[Serializable]
[ExcludeFromPreset]
public class FontAsset : TextAsset
{
	[SerializeField]
	internal string m_SourceFontFileGUID;

	[SerializeField]
	internal FontAssetCreationEditorSettings m_fontAssetCreationEditorSettings;

	[SerializeField]
	private Font m_SourceFontFile;

	[SerializeField]
	private string m_SourceFontFilePath;

	[SerializeField]
	private AtlasPopulationMode m_AtlasPopulationMode;

	[SerializeField]
	internal bool InternalDynamicOS;

	[SerializeField]
	internal FaceInfo m_FaceInfo;

	private int m_FamilyNameHashCode;

	private int m_StyleNameHashCode;

	[SerializeField]
	internal List<Glyph> m_GlyphTable;

	internal Dictionary<uint, Glyph> m_GlyphLookupDictionary;

	[SerializeField]
	internal List<Character> m_CharacterTable;

	internal Dictionary<uint, Character> m_CharacterLookupDictionary;

	internal Texture2D m_AtlasTexture;

	[SerializeField]
	internal Texture2D[] m_AtlasTextures;

	[SerializeField]
	internal int m_AtlasTextureIndex;

	[SerializeField]
	private bool m_IsMultiAtlasTexturesEnabled;

	[SerializeField]
	private bool m_ClearDynamicDataOnBuild;

	[SerializeField]
	internal int m_AtlasWidth;

	[SerializeField]
	internal int m_AtlasHeight;

	[SerializeField]
	internal int m_AtlasPadding;

	[SerializeField]
	internal GlyphRenderMode m_AtlasRenderMode;

	[SerializeField]
	private List<GlyphRect> m_UsedGlyphRects;

	[SerializeField]
	private List<GlyphRect> m_FreeGlyphRects;

	[SerializeField]
	internal FontFeatureTable m_FontFeatureTable;

	[SerializeField]
	internal List<FontAsset> m_FallbackFontAssetTable;

	[SerializeField]
	private FontWeightPair[] m_FontWeightTable;

	[FormerlySerializedAs("normalStyle")]
	[SerializeField]
	internal float m_RegularStyleWeight;

	[SerializeField]
	[FormerlySerializedAs("normalSpacingOffset")]
	internal float m_RegularStyleSpacing;

	[SerializeField]
	[FormerlySerializedAs("boldStyle")]
	internal float m_BoldStyleWeight;

	[FormerlySerializedAs("boldSpacing")]
	[SerializeField]
	internal float m_BoldStyleSpacing;

	[SerializeField]
	[FormerlySerializedAs("italicStyle")]
	internal byte m_ItalicStyleSlant;

	[FormerlySerializedAs("tabSize")]
	[SerializeField]
	internal byte m_TabMultiple;

	internal bool IsFontAssetLookupTablesDirty;

	private static ProfilerMarker k_ReadFontAssetDefinitionMarker;

	private static ProfilerMarker k_AddSynthesizedCharactersMarker;

	private static ProfilerMarker k_TryAddCharacterMarker;

	private static ProfilerMarker k_TryAddCharactersMarker;

	private static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker;

	private static ProfilerMarker k_UpdateDiacriticalMarkAdjustmentRecordsMarker;

	private static ProfilerMarker k_ClearFontAssetDataMarker;

	private static ProfilerMarker k_UpdateFontAssetDataMarker;

	private static ProfilerMarker k_TryAddGlyphMarker;

	private static string s_DefaultMaterialSuffix;

	private static HashSet<int> k_SearchedFontAssetLookup;

	private static List<FontAsset> k_FontAssets_FontFeaturesUpdateQueue;

	private static HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup;

	private static List<Texture2D> k_FontAssets_AtlasTexturesUpdateQueue;

	private static HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup;

	private List<Glyph> m_GlyphsToRender;

	private List<Glyph> m_GlyphsRendered;

	private List<uint> m_GlyphIndexList;

	private List<uint> m_GlyphIndexListNewlyAdded;

	internal List<uint> m_GlyphsToAdd;

	internal HashSet<uint> m_GlyphsToAddLookup;

	internal List<Character> m_CharactersToAdd;

	internal HashSet<uint> m_CharactersToAddLookup;

	internal List<uint> s_MissingCharacterList;

	internal HashSet<uint> m_MissingUnicodesFromFontFile;

	internal static uint[] k_GlyphIndexArray;

	public FontAssetCreationEditorSettings fontAssetCreationEditorSettings
	{
		get
		{
			return default(FontAssetCreationEditorSettings);
		}
		set
		{
		}
	}

	public Font sourceFontFile
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	public AtlasPopulationMode atlasPopulationMode
	{
		get
		{
			return default(AtlasPopulationMode);
		}
		set
		{
		}
	}

	public FaceInfo faceInfo
	{
		get
		{
			return default(FaceInfo);
		}
		set
		{
		}
	}

	internal int familyNameHashCode
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal int styleNameHashCode
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public List<Glyph> glyphTable
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	public Dictionary<uint, Glyph> glyphLookupTable => null;

	public List<Character> characterTable
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	public Dictionary<uint, Character> characterLookupTable => null;

	public Texture2D atlasTexture => null;

	public Texture2D[] atlasTextures
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int atlasTextureCount => 0;

	public bool isMultiAtlasTexturesEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	internal bool clearDynamicDataOnBuild
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int atlasWidth
	{
		get
		{
			return 0;
		}
		internal set
		{
		}
	}

	public int atlasHeight
	{
		get
		{
			return 0;
		}
		internal set
		{
		}
	}

	public int atlasPadding
	{
		get
		{
			return 0;
		}
		internal set
		{
		}
	}

	public GlyphRenderMode atlasRenderMode
	{
		get
		{
			return default(GlyphRenderMode);
		}
		internal set
		{
		}
	}

	internal List<GlyphRect> usedGlyphRects
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal List<GlyphRect> freeGlyphRects
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public FontFeatureTable fontFeatureTable
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	public List<FontAsset> fallbackFontAssetTable
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public FontWeightPair[] fontWeightTable
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	public float regularStyleWeight
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float regularStyleSpacing
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float boldStyleWeight
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float boldStyleSpacing
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public byte italicStyleSlant
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public byte tabMultiple
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static FontAsset CreateFontAsset(string familyName, string styleName, int pointSize = 90)
	{
		return null;
	}

	public static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight)
	{
		return null;
	}

	private static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.DynamicOS, bool enableMultiAtlasSupport = true)
	{
		return null;
	}

	public static FontAsset CreateFontAsset(Font font)
	{
		return null;
	}

	public static FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic, bool enableMultiAtlasSupport = true)
	{
		return null;
	}

	private static FontAsset CreateFontAsset(Font font, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic, bool enableMultiAtlasSupport = true)
	{
		return null;
	}

	private static FontAsset CreateFontAssetInstance(Font font, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport)
	{
		return null;
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void ReadFontAssetDefinition()
	{
	}

	internal void InitializeDictionaryLookupTables()
	{
	}

	internal void InitializeGlyphLookupDictionary()
	{
	}

	internal void InitializeCharacterLookupDictionary()
	{
	}

	internal void InitializeLigatureSubstitutionLookupDictionary()
	{
	}

	internal void InitializeGlyphPaidAdjustmentRecordsLookupDictionary()
	{
	}

	internal void InitializeMarkToBaseAdjustmentRecordsLookupDictionary()
	{
	}

	internal void InitializeMarkToMarkAdjustmentRecordsLookupDictionary()
	{
	}

	internal void AddSynthesizedCharactersAndFaceMetrics()
	{
	}

	private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = false)
	{
	}

	internal void AddCharacterToLookupCache(uint unicode, Character character)
	{
	}

	private FontEngineError LoadFontFace()
	{
		return default(FontEngineError);
	}

	internal void SortCharacterTable()
	{
	}

	internal void SortGlyphTable()
	{
	}

	internal void SortFontFeatureTable()
	{
	}

	internal void SortAllTables()
	{
	}

	public bool HasCharacter(int character)
	{
		return false;
	}

	public bool HasCharacter(char character, bool searchFallbacks = false, bool tryAddCharacter = false)
	{
		return false;
	}

	public bool HasCharacter(uint character, bool searchFallbacks = false, bool tryAddCharacter = false)
	{
		return false;
	}

	private bool HasCharacter_Internal(uint character, bool searchFallbacks = false, bool tryAddCharacter = false)
	{
		return false;
	}

	public bool HasCharacters(string text, out List<char> missingCharacters)
	{
		missingCharacters = null;
		return false;
	}

	public bool HasCharacters(string text, out uint[] missingCharacters, bool searchFallbacks = false, bool tryAddCharacter = false)
	{
		missingCharacters = null;
		return false;
	}

	public bool HasCharacters(string text)
	{
		return false;
	}

	public static string GetCharacters(FontAsset fontAsset)
	{
		return null;
	}

	public static int[] GetCharactersArray(FontAsset fontAsset)
	{
		return null;
	}

	internal uint GetGlyphIndex(uint unicode)
	{
		return 0u;
	}

	internal static void RegisterFontAssetForFontFeatureUpdate(FontAsset fontAsset)
	{
	}

	internal static void UpdateFontFeaturesForFontAssetsInQueue()
	{
	}

	internal static void RegisterAtlasTextureForApply(Texture2D texture)
	{
	}

	internal static void UpdateAtlasTexturesInQueue()
	{
	}

	internal static void UpdateFontAssetsInUpdateQueue()
	{
	}

	public bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures = false)
	{
		return false;
	}

	public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes, bool includeFontFeatures = false)
	{
		missingUnicodes = null;
		return false;
	}

	public bool TryAddCharacters(string characters, bool includeFontFeatures = false)
	{
		return false;
	}

	public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = false)
	{
		missingCharacters = null;
		return false;
	}

	internal bool TryAddGlyphInternal(uint glyphIndex, out Glyph glyph)
	{
		glyph = null;
		return false;
	}

	internal bool TryAddCharacterInternal(uint unicode, out Character character, bool shouldGetFontFeatures = false)
	{
		character = null;
		return false;
	}

	internal bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out Character character, bool shouldGetFontFeatures = false)
	{
		character = null;
		return false;
	}

	internal void TryAddGlyphsToAtlasTextures()
	{
	}

	private bool TryAddGlyphsToNewAtlasTexture()
	{
		return false;
	}

	private void SetupNewAtlasTexture()
	{
	}

	private void UpdateAllFontFeatures()
	{
	}

	internal void UpdateGlyphAdjustmentRecords()
	{
	}

	internal void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes)
	{
	}

	internal void UpdateGlyphAdjustmentRecords(List<uint> glyphIndexes)
	{
	}

	internal void UpdateGlyphAdjustmentRecords(List<uint> newGlyphIndexes, List<uint> allGlyphIndexes)
	{
	}

	private void CopyListDataToArray<T>(List<T> srcList, ref T[] dstArray)
	{
	}

	public void ClearFontAssetData(bool setAtlasSizeToZero = false)
	{
	}

	internal void ClearFontAssetDataInternal(bool clearFontFeatures = false)
	{
	}

	internal void UpdateFontAssetData()
	{
	}

	internal void ClearFontAssetTables(bool clearFontFeatures)
	{
	}

	internal void ClearAtlasTextures(bool setAtlasSizeToZero = false)
	{
	}

	private void DestroyAtlasTextures()
	{
	}
}
