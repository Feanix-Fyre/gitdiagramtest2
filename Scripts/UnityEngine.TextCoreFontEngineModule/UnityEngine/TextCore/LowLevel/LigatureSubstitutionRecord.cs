using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore.LowLevel;

[Serializable]
[UsedByNativeCode]
internal struct LigatureSubstitutionRecord
{
	[NativeName("componentGlyphs")]
	[SerializeField]
	private uint[] m_ComponentGlyphIDs;

	[NativeName("ligatureGlyph")]
	[SerializeField]
	private uint m_LigatureGlyphID;

	public uint[] componentGlyphIDs => null;

	public uint ligatureGlyphID => 0u;
}
