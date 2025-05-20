using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore.LowLevel;

[Serializable]
[UsedByNativeCode]
internal struct MultipleSubstitutionRecord
{
	[SerializeField]
	[NativeName("targetGlyphID")]
	private uint m_TargetGlyphID;

	[SerializeField]
	[NativeName("substituteGlyphIDs")]
	private uint[] m_SubstituteGlyphIDs;
}
