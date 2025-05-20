using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore.LowLevel;

[Serializable]
[UsedByNativeCode]
internal struct MarkToBaseAdjustmentRecord
{
	[NativeName("baseGlyphID")]
	[SerializeField]
	private uint m_BaseGlyphID;

	[NativeName("baseAnchor")]
	[SerializeField]
	private GlyphAnchorPoint m_BaseGlyphAnchorPoint;

	[SerializeField]
	[NativeName("markGlyphID")]
	private uint m_MarkGlyphID;

	[NativeName("markPositionAdjustment")]
	[SerializeField]
	private MarkPositionAdjustment m_MarkPositionAdjustment;

	public uint baseGlyphID => 0u;

	public GlyphAnchorPoint baseGlyphAnchorPoint => default(GlyphAnchorPoint);

	public uint markGlyphID => 0u;

	public MarkPositionAdjustment markPositionAdjustment => default(MarkPositionAdjustment);
}
