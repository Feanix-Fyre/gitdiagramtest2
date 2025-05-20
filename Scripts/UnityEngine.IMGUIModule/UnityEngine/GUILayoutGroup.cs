using System.Collections.Generic;
using UnityEngine.Bindings;

namespace UnityEngine;

[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule", "Unity.UIElements" })]
internal class GUILayoutGroup : GUILayoutEntry
{
	public List<GUILayoutEntry> entries;

	public bool isVertical;

	public bool resetCoords;

	public float spacing;

	public bool sameSize;

	public bool isWindow;

	public int windowID;

	private int m_Cursor;

	protected int m_StretchableCountX;

	protected int m_StretchableCountY;

	protected bool m_UserSpecifiedWidth;

	protected bool m_UserSpecifiedHeight;

	protected float m_ChildMinWidth;

	protected float m_ChildMaxWidth;

	protected float m_ChildMinHeight;

	protected float m_ChildMaxHeight;

	protected int m_MarginLeft;

	protected int m_MarginRight;

	protected int m_MarginTop;

	protected int m_MarginBottom;

	private static readonly GUILayoutEntry none;

	public override int marginLeft => 0;

	public override int marginRight => 0;

	public override int marginTop => 0;

	public override int marginBottom => 0;

	public GUILayoutGroup()
		: base(0f, 0f, 0f, 0f, null)
	{
	}

	public override void ApplyOptions(GUILayoutOption[] options)
	{
	}

	protected override void ApplyStyleSettings(GUIStyle style)
	{
	}

	public void ResetCursor()
	{
	}

	public GUILayoutEntry GetNext()
	{
		return null;
	}

	public void Add(GUILayoutEntry e)
	{
	}

	public override void CalcWidth()
	{
	}

	public override void SetHorizontal(float x, float width)
	{
	}

	public override void CalcHeight()
	{
	}

	public override void SetVertical(float y, float height)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
