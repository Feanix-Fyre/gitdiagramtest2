using System.Collections.Generic;

namespace TMPro;

internal class TMP_DynamicFontAssetUtilities
{
	public struct FontReference
	{
		public string familyName;

		public string styleName;

		public int faceIndex;

		public string filePath;

		public ulong hashCode;

		public FontReference(string fontFilePath, string faceNameAndStyle, int index)
		{
			familyName = null;
			styleName = null;
			faceIndex = 0;
			filePath = null;
			hashCode = 0uL;
		}
	}

	private static TMP_DynamicFontAssetUtilities s_Instance;

	private Dictionary<ulong, FontReference> s_SystemFontLookup;

	private string[] s_SystemFontPaths;

	private uint s_RegularStyleNameHashCode;

	private void InitializeSystemFontReferenceCache()
	{
	}

	public static bool TryGetSystemFontReference(string familyName, out FontReference fontRef)
	{
		fontRef = default(FontReference);
		return false;
	}

	public static bool TryGetSystemFontReference(string familyName, string styleName, out FontReference fontRef)
	{
		fontRef = default(FontReference);
		return false;
	}

	private bool TryGetSystemFontReferenceInternal(string familyName, string styleName, out FontReference fontRef)
	{
		fontRef = default(FontReference);
		return false;
	}
}
