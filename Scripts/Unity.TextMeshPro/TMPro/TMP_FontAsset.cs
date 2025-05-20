using System;
using System.Collections.Generic;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.TextCore;
using UnityEngine.TextCore.LowLevel;

namespace TMPro;

[Serializable]
[ExcludeFromPreset]
public class TMP_FontAsset : TMP_Asset
{
	[SerializeField]
	internal string m_SourceFontFileGUID;

	[SerializeField]
	internal FontAssetCreationSettings m_CreationSettings;

	[SerializeField]
	private Font m_SourceFontFile;

	[SerializeField]
	private string m_SourceFontFilePath;

	[SerializeField]
	private AtlasPopulationMode m_AtlasPopulationMode;

	[SerializeField]
	internal bool InternalDynamicOS;

	private int m_FamilyNameHashCode;

	private int m_StyleNameHashCode;

	[SerializeField]
	internal List<Glyph> m_GlyphTable;

	internal Dictionary<uint, Glyph> m_GlyphLookupDictionary;

	[SerializeField]
	internal List<TMP_Character> m_CharacterTable;

	internal Dictionary<uint, TMP_Character> m_CharacterLookupDictionary;

	internal Texture2D m_AtlasTexture;

	[SerializeField]
	internal Texture2D[] m_AtlasTextures;

	[SerializeField]
	internal int m_AtlasTextureIndex;

	[SerializeField]
	private bool m_IsMultiAtlasTexturesEnabled;

	[SerializeField]
	private bool m_GetFontFeatures;

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
	internal TMP_FontFeatureTable m_FontFeatureTable;

	[SerializeField]
	internal bool m_ShouldReimportFontFeatures;

	[SerializeField]
	internal List<TMP_FontAsset> m_FallbackFontAssetTable;

	[SerializeField]
	private TMP_FontWeightPair[] m_FontWeightTable;

	[SerializeField]
	private TMP_FontWeightPair[] fontWeights;

	public float normalStyle;

	public float normalSpacingOffset;

	public float boldStyle;

	public float boldSpacing;

	public byte italicStyle;

	public byte tabSize;

	internal bool IsFontAssetLookupTablesDirty;

	[SerializeField]
	private FaceInfo_Legacy m_fontInfo;

	[SerializeField]
	internal List<TMP_Glyph> m_glyphInfoList;

	[FormerlySerializedAs("m_kerningInfo")]
	[SerializeField]
	internal KerningTable m_KerningTable;

	[SerializeField]
	private List<TMP_FontAsset> fallbackFontAssets;

	[SerializeField]
	public Texture2D atlas;

	private static ProfilerMarker k_ReadFontAssetDefinitionMarker;

	private static ProfilerMarker k_AddSynthesizedCharactersMarker;

	private static ProfilerMarker k_TryAddGlyphMarker;

	private static ProfilerMarker k_TryAddCharacterMarker;

	private static ProfilerMarker k_TryAddCharactersMarker;

	private static ProfilerMarker k_UpdateLigatureSubstitutionRecordsMarker;

	private static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker;

	private static ProfilerMarker k_UpdateDiacriticalMarkAdjustmentRecordsMarker;

	private static ProfilerMarker k_ClearFontAssetDataMarker;

	private static ProfilerMarker k_UpdateFontAssetDataMarker;

	private static string s_DefaultMaterialSuffix;

	private static HashSet<int> k_SearchedFontAssetLookup;

	private static List<TMP_FontAsset> k_FontAssets_FontFeaturesUpdateQueue;

	private static HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup;

	private static List<Texture2D> k_FontAssets_AtlasTexturesUpdateQueue;

	private static HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup;

	private List<Glyph> m_GlyphsToRender;

	private List<Glyph> m_GlyphsRendered;

	private List<uint> m_GlyphIndexList;

	private List<uint> m_GlyphIndexListNewlyAdded;

	internal List<uint> m_GlyphsToAdd;

	internal HashSet<uint> m_GlyphsToAddLookup;

	internal List<TMP_Character> m_CharactersToAdd;

	internal HashSet<uint> m_CharactersToAddLookup;

	internal List<uint> s_MissingCharacterList;

	internal HashSet<uint> m_MissingUnicodesFromFontFile;

	internal static uint[] k_GlyphIndexArray;

	public FontAssetCreationSettings creationSettings
	{
		get
		{
			return default(FontAssetCreationSettings);
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

	public List<TMP_Character> characterTable
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	public Dictionary<uint, TMP_Character> characterLookupTable => null;

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

	public bool getFontFeatures
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

	public TMP_FontFeatureTable fontFeatureTable
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	public List<TMP_FontAsset> fallbackFontAssetTable
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public TMP_FontWeightPair[] fontWeightTable
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	[Obsolete("The fontInfo property and underlying type is now obsolete. Please use the faceInfo property and FaceInfo type instead.")]
	public FaceInfo_Legacy fontInfo => null;

	public static TMP_FontAsset CreateFontAsset(string familyName, string styleName, int pointSize = 90)
	{
		return null;
	}

	public static TMP_FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight)
	{
		return null;
	}

	private static TMP_FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport = true)
	{
		return null;
	}

	public static TMP_FontAsset CreateFontAsset(Font font)
	{
		return null;
	}

	public static TMP_FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic, bool enableMultiAtlasSupport = true)
	{
		return null;
	}

	private static TMP_FontAsset CreateFontAsset(Font font, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = AtlasPopulationMode.Dynamic, bool enableMultiAtlasSupport = true)
	{
		return null;
	}

	private static TMP_FontAsset CreateFontAssetInstance(Font font, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport)
	{
		return null;
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

	internal void AddCharacterToLookupCache(uint unicode, TMP_Character character)
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

	public static string GetCharacters(TMP_FontAsset fontAsset)
	{
		return null;
	}

	public static int[] GetCharactersArray(TMP_FontAsset fontAsset)
	{
		return null;
	}

	internal uint GetGlyphIndex(uint unicode)
	{
		return 0u;
	}

	internal uint GetGlyphVariantIndex(uint unicode, uint variantSelectorUnicode)
	{
		return 0u;
	}

	internal static void RegisterFontAssetForFontFeatureUpdate(TMP_FontAsset fontAsset)
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

	internal bool AddGlyphInternal(uint glyphIndex)
	{
		return false;
	}

	internal bool TryAddGlyphInternal(uint glyphIndex, out Glyph glyph)
	{
		glyph = null;
		return false;
	}

	internal bool TryAddCharacterInternal(uint unicode, out TMP_Character character)
	{
		character = null;
		return false;
	}

	internal bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out TMP_Character character)
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

	internal void UpdateAtlasTexture()
	{
	}

	private void UpdateFontFeaturesForNewlyAddedGlyphs()
	{
	}

	private void UpdateGPOSFontFeaturesForNewlyAddedGlyphs()
	{
	}

	internal void ImportFontFeatures()
	{
	}

	private void UpdateGSUBFontFeaturesForNewGlyphIndex(uint glyphIndex)
	{
	}

	internal void UpdateLigatureSubstitutionRecords()
	{
	}

	private void AddLigatureSubstitutionRecords(UnityEngine.TextCore.LowLevel.LigatureSubstitutionRecord[] records)
	{
	}

	internal void UpdateGlyphAdjustmentRecords()
	{
	}

	private void AddPairAdjustmentRecords(GlyphPairAdjustmentRecord[] records)
	{
	}

	internal void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes)
	{
	}

	internal void UpdateDiacriticalMarkAdjustmentRecords()
	{
	}

	private void AddMarkToBaseAdjustmentRecords(UnityEngine.TextCore.LowLevel.MarkToBaseAdjustmentRecord[] records)
	{
	}

	private void AddMarkToMarkAdjustmentRecords(UnityEngine.TextCore.LowLevel.MarkToMarkAdjustmentRecord[] records)
	{
	}

	private void CopyListDataToArray<T>(List<T> srcList, ref T[] dstArray)
	{
	}

	internal void UpdateFontAssetData()
	{
	}

	public void ClearFontAssetData(bool setAtlasSizeToZero = false)
	{
	}

	internal void ClearCharacterAndGlyphTablesInternal()
	{
	}

	internal void ClearFontFeaturesInternal()
	{
	}

	private void ClearCharacterAndGlyphTables()
	{
	}

	private void ClearFontFeaturesTables()
	{
	}

	internal void ClearAtlasTextures(bool setAtlasSizeToZero = false)
	{
	}

	private void DestroyAtlasTextures()
	{
	}

	private void UpgradeGlyphAdjustmentTableToFontFeatureTable()
	{
	}
}
