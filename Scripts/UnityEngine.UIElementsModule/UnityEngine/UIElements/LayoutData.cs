using System;

namespace UnityEngine.UIElements;

internal struct LayoutData : IStyleDataGroup<LayoutData>, IEquatable<LayoutData>
{
	public Align alignContent;

	public Align alignItems;

	public Align alignSelf;

	public float borderBottomWidth;

	public float borderLeftWidth;

	public float borderRightWidth;

	public float borderTopWidth;

	public Length bottom;

	public DisplayStyle display;

	public Length flexBasis;

	public FlexDirection flexDirection;

	public float flexGrow;

	public float flexShrink;

	public Wrap flexWrap;

	public Length height;

	public Justify justifyContent;

	public Length left;

	public Length marginBottom;

	public Length marginLeft;

	public Length marginRight;

	public Length marginTop;

	public Length maxHeight;

	public Length maxWidth;

	public Length minHeight;

	public Length minWidth;

	public Length paddingBottom;

	public Length paddingLeft;

	public Length paddingRight;

	public Length paddingTop;

	public Position position;

	public Length right;

	public Length top;

	public Length width;

	public LayoutData Copy()
	{
		return default(LayoutData);
	}

	public void CopyFrom(ref LayoutData other)
	{
	}

	public static bool operator ==(LayoutData lhs, LayoutData rhs)
	{
		return false;
	}

	public bool Equals(LayoutData other)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
