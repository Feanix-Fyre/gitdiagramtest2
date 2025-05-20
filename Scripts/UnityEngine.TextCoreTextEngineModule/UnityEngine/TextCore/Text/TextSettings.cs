using System;
using System.Collections.Generic;
using UnityEngine.Serialization;

namespace UnityEngine.TextCore.Text;

[Serializable]
[ExcludeFromPreset]
[ExcludeFromObjectFactory]
public class TextSettings : ScriptableObject
{
	[Serializable]
	private struct FontReferenceMap
	{
		public Font font;

		public FontAsset fontAsset;

		public FontReferenceMap(Font font, FontAsset fontAsset)
		{
			this.font = null;
			this.fontAsset = null;
		}
	}

	[SerializeField]
	protected string m_Version;

	[FormerlySerializedAs("m_defaultFontAsset")]
	[SerializeField]
	protected FontAsset m_DefaultFontAsset;

	[SerializeField]
	[FormerlySerializedAs("m_defaultFontAssetPath")]
	protected string m_DefaultFontAssetPath;

	[FormerlySerializedAs("m_fallbackFontAssets")]
	[SerializeField]
	protected List<FontAsset> m_FallbackFontAssets;

	[FormerlySerializedAs("m_matchMaterialPreset")]
	[SerializeField]
	protected bool m_MatchMaterialPreset;

	[FormerlySerializedAs("m_missingGlyphCharacter")]
	[SerializeField]
	protected int m_MissingCharacterUnicode;

	[SerializeField]
	protected bool m_ClearDynamicDataOnBuild;

	[SerializeField]
	[FormerlySerializedAs("m_defaultSpriteAsset")]
	protected SpriteAsset m_DefaultSpriteAsset;

	[SerializeField]
	[FormerlySerializedAs("m_defaultSpriteAssetPath")]
	protected string m_DefaultSpriteAssetPath;

	[SerializeField]
	protected List<SpriteAsset> m_FallbackSpriteAssets;

	[SerializeField]
	protected uint m_MissingSpriteCharacterUnicode;

	[SerializeField]
	[FormerlySerializedAs("m_defaultStyleSheet")]
	protected TextStyleSheet m_DefaultStyleSheet;

	[SerializeField]
	protected string m_StyleSheetsResourcePath;

	[SerializeField]
	[FormerlySerializedAs("m_defaultColorGradientPresetsPath")]
	protected string m_DefaultColorGradientPresetsPath;

	[SerializeField]
	protected UnicodeLineBreakingRules m_UnicodeLineBreakingRules;

	[SerializeField]
	private bool m_UseModernHangulLineBreakingRules;

	[FormerlySerializedAs("m_warningsDisabled")]
	[SerializeField]
	protected bool m_DisplayWarnings;

	internal Dictionary<int, FontAsset> m_FontLookup;

	private List<FontReferenceMap> m_FontReferences;

	public string version
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	public FontAsset defaultFontAsset
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string defaultFontAssetPath
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<FontAsset> fallbackFontAssets
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool matchMaterialPreset
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int missingCharacterUnicode
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool clearDynamicDataOnBuild
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public SpriteAsset defaultSpriteAsset
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string defaultSpriteAssetPath
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<SpriteAsset> fallbackSpriteAssets
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public uint missingSpriteCharacterUnicode
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public TextStyleSheet defaultStyleSheet
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string styleSheetsResourcePath
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string defaultColorGradientPresetsPath
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UnicodeLineBreakingRules lineBreakingRules
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool useModernHangulLineBreakingRules
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool displayWarnings
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void OnEnable()
	{
	}

	protected void InitializeFontReferenceLookup()
	{
	}

	protected FontAsset GetCachedFontAssetInternal(Font font)
	{
		return null;
	}
}
