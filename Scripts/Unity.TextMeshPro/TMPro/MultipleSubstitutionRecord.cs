using System;
using UnityEngine;

namespace TMPro;

[Serializable]
public struct MultipleSubstitutionRecord
{
	[SerializeField]
	private uint m_TargetGlyphID;

	[SerializeField]
	private uint[] m_SubstituteGlyphIDs;

	public uint targetGlyphID
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public uint[] substituteGlyphIDs
	{
		get
		{
			return null;
		}
		set
		{
		}
	}
}
