using System;
using UnityEngine;

namespace TMPro;

[Serializable]
public struct MarkToBaseAdjustmentRecord
{
	[SerializeField]
	private uint m_BaseGlyphID;

	[SerializeField]
	private GlyphAnchorPoint m_BaseGlyphAnchorPoint;

	[SerializeField]
	private uint m_MarkGlyphID;

	[SerializeField]
	private MarkPositionAdjustment m_MarkPositionAdjustment;

	public uint baseGlyphID
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public GlyphAnchorPoint baseGlyphAnchorPoint
	{
		get
		{
			return default(GlyphAnchorPoint);
		}
		set
		{
		}
	}

	public uint markGlyphID
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public MarkPositionAdjustment markPositionAdjustment
	{
		get
		{
			return default(MarkPositionAdjustment);
		}
		set
		{
		}
	}
}
