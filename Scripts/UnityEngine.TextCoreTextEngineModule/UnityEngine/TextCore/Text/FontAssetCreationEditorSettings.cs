using System;
using UnityEngine.Internal;

namespace UnityEngine.TextCore.Text;

[Serializable]
[ExcludeFromDocs]
public struct FontAssetCreationEditorSettings
{
	public string sourceFontFileGUID;

	public int faceIndex;

	public int pointSizeSamplingMode;

	public int pointSize;

	public int padding;

	public int paddingMode;

	public int packingMode;

	public int atlasWidth;

	public int atlasHeight;

	public int characterSetSelectionMode;

	public string characterSequence;

	public string referencedFontAssetGUID;

	public string referencedTextAssetGUID;

	public int fontStyle;

	public float fontStyleModifier;

	public int renderMode;

	public bool includeFontFeatures;
}
