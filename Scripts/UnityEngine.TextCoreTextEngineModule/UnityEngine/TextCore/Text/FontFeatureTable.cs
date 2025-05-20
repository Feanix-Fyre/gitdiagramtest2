using System;
using System.Collections.Generic;
using UnityEngine.TextCore.LowLevel;

namespace UnityEngine.TextCore.Text;

[Serializable]
public class FontFeatureTable
{
	[SerializeField]
	internal List<MultipleSubstitutionRecord> m_MultipleSubstitutionRecords;

	[SerializeField]
	internal List<LigatureSubstitutionRecord> m_LigatureSubstitutionRecords;

	[SerializeField]
	internal List<GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords;

	[SerializeField]
	internal List<MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecords;

	[SerializeField]
	internal List<MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecords;

	internal Dictionary<uint, List<LigatureSubstitutionRecord>> m_LigatureSubstitutionRecordLookup;

	internal Dictionary<uint, GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookup;

	internal Dictionary<uint, MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecordLookup;

	internal Dictionary<uint, MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecordLookup;

	internal FontFeatureTable()
	{
	}

	public void SortGlyphPairAdjustmentRecords()
	{
	}

	public void SortMarkToBaseAdjustmentRecords()
	{
	}

	public void SortMarkToMarkAdjustmentRecords()
	{
	}
}
