using System;
using System.Collections.Generic;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements;

[Serializable]
[HelpURL("UIE-USS")]
public class StyleSheet : ScriptableObject
{
	[Serializable]
	internal struct ImportStruct
	{
		public StyleSheet styleSheet;

		public string[] mediaQueries;
	}

	[SerializeField]
	private bool m_ImportedWithErrors;

	[SerializeField]
	private bool m_ImportedWithWarnings;

	[SerializeField]
	private StyleRule[] m_Rules;

	[SerializeField]
	private StyleComplexSelector[] m_ComplexSelectors;

	[SerializeField]
	internal float[] floats;

	[SerializeField]
	internal Dimension[] dimensions;

	[SerializeField]
	internal Color[] colors;

	[SerializeField]
	internal string[] strings;

	[SerializeField]
	internal Object[] assets;

	[SerializeField]
	internal ImportStruct[] imports;

	[SerializeField]
	private List<StyleSheet> m_FlattenedImportedStyleSheets;

	[SerializeField]
	private int m_ContentHash;

	[SerializeField]
	internal ScalableImage[] scalableImages;

	[NonSerialized]
	internal Dictionary<string, StyleComplexSelector> orderedNameSelectors;

	[NonSerialized]
	internal Dictionary<string, StyleComplexSelector> orderedTypeSelectors;

	[NonSerialized]
	internal Dictionary<string, StyleComplexSelector> orderedClassSelectors;

	[NonSerialized]
	private bool m_IsDefaultStyleSheet;

	private static string kCustomPropertyMarker;

	public bool importedWithErrors
	{
		get
		{
			return false;
		}
		internal set
		{
		}
	}

	public bool importedWithWarnings
	{
		get
		{
			return false;
		}
		internal set
		{
		}
	}

	internal StyleRule[] rules
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal StyleComplexSelector[] complexSelectors
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal List<StyleSheet> flattenedRecursiveImports => null;

	public int contentHash
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal bool isDefaultStyleSheet
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private bool TryCheckAccess<T>(T[] list, StyleValueType type, StyleValueHandle handle, out T value)
	{
		value = default(T);
		return false;
	}

	private T CheckAccess<T>(T[] list, StyleValueType type, StyleValueHandle handle)
	{
		return default(T);
	}

	internal virtual void OnEnable()
	{
	}

	internal void FlattenImportedStyleSheetsRecursive()
	{
	}

	private void FlattenImportedStyleSheetsRecursive(StyleSheet sheet)
	{
	}

	private void SetupReferences()
	{
	}

	internal StyleValueKeyword ReadKeyword(StyleValueHandle handle)
	{
		return default(StyleValueKeyword);
	}

	internal float ReadFloat(StyleValueHandle handle)
	{
		return 0f;
	}

	internal bool TryReadFloat(StyleValueHandle handle, out float value)
	{
		value = default(float);
		return false;
	}

	internal Dimension ReadDimension(StyleValueHandle handle)
	{
		return default(Dimension);
	}

	internal bool TryReadDimension(StyleValueHandle handle, out Dimension value)
	{
		value = default(Dimension);
		return false;
	}

	internal Color ReadColor(StyleValueHandle handle)
	{
		return default(Color);
	}

	internal bool TryReadColor(StyleValueHandle handle, out Color value)
	{
		value = default(Color);
		return false;
	}

	internal string ReadString(StyleValueHandle handle)
	{
		return null;
	}

	internal bool TryReadString(StyleValueHandle handle, out string value)
	{
		value = null;
		return false;
	}

	internal string ReadEnum(StyleValueHandle handle)
	{
		return null;
	}

	internal bool TryReadEnum(StyleValueHandle handle, out string value)
	{
		value = null;
		return false;
	}

	internal string ReadVariable(StyleValueHandle handle)
	{
		return null;
	}

	internal bool TryReadVariable(StyleValueHandle handle, out string value)
	{
		value = null;
		return false;
	}

	internal string ReadResourcePath(StyleValueHandle handle)
	{
		return null;
	}

	internal bool TryReadResourcePath(StyleValueHandle handle, out string value)
	{
		value = null;
		return false;
	}

	internal Object ReadAssetReference(StyleValueHandle handle)
	{
		return null;
	}

	internal string ReadMissingAssetReferenceUrl(StyleValueHandle handle)
	{
		return null;
	}

	internal bool TryReadAssetReference(StyleValueHandle handle, out Object value)
	{
		value = null;
		return false;
	}

	internal StyleValueFunction ReadFunction(StyleValueHandle handle)
	{
		return default(StyleValueFunction);
	}

	internal string ReadFunctionName(StyleValueHandle handle)
	{
		return null;
	}

	internal ScalableImage ReadScalableImage(StyleValueHandle handle)
	{
		return default(ScalableImage);
	}

	private static bool CustomStartsWith(string originalString, string pattern)
	{
		return false;
	}
}
