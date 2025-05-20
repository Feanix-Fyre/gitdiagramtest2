namespace UnityEngine;

internal class GUILayoutEntry
{
	public float minWidth;

	public float maxWidth;

	public float minHeight;

	public float maxHeight;

	public Rect rect;

	public int stretchWidth;

	public int stretchHeight;

	public bool consideredForMargin;

	private GUIStyle m_Style;

	internal static Rect kDummyRect;

	protected static int indent;

	public GUIStyle style
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual int marginLeft => 0;

	public virtual int marginRight => 0;

	public virtual int marginTop => 0;

	public virtual int marginBottom => 0;

	public int marginHorizontal => 0;

	public int marginVertical => 0;

	public GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style)
	{
	}

	public GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, GUILayoutOption[] options)
	{
	}

	public virtual void CalcWidth()
	{
	}

	public virtual void CalcHeight()
	{
	}

	public virtual void SetHorizontal(float x, float width)
	{
	}

	public virtual void SetVertical(float y, float height)
	{
	}

	protected virtual void ApplyStyleSettings(GUIStyle style)
	{
	}

	public virtual void ApplyOptions(GUILayoutOption[] options)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
