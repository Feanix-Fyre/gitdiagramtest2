using System;
using UnityEngine;

namespace TMPro;

[Serializable]
public struct MarkToMarkAdjustmentRecord
{
	[SerializeField]
	private uint m_BaseMarkGlyphID;

	[SerializeField]
	private GlyphAnchorPoint m_BaseMarkGlyphAnchorPoint;

	[SerializeField]
	private uint m_CombiningMarkGlyphID;

	[SerializeField]
	private MarkPositionAdjustment m_CombiningMarkPositionAdjustment;

	public uint baseMarkGlyphID
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public GlyphAnchorPoint baseMarkGlyphAnchorPoint
	{
		get
		{
			return default(GlyphAnchorPoint);
		}
		set
		{
		}
	}

	public uint combiningMarkGlyphID
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public MarkPositionAdjustment combiningMarkPositionAdjustment
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
