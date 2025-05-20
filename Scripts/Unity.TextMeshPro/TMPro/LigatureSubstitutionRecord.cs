using System;
using UnityEngine;

namespace TMPro;

[Serializable]
public struct LigatureSubstitutionRecord
{
	[SerializeField]
	private uint[] m_ComponentGlyphIDs;

	[SerializeField]
	private uint m_LigatureGlyphID;

	public uint[] componentGlyphIDs
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public uint ligatureGlyphID
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public static bool operator ==(LigatureSubstitutionRecord lhs, LigatureSubstitutionRecord rhs)
	{
		return false;
	}

	public static bool operator !=(LigatureSubstitutionRecord lhs, LigatureSubstitutionRecord rhs)
	{
		return false;
	}
}
