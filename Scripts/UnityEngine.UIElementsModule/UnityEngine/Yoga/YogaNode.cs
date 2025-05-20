using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace UnityEngine.Yoga;

[DefaultMember("Item")]
internal class YogaNode : IEnumerable<YogaNode>, IEnumerable
{
	internal IntPtr _ygNode;

	private YogaConfig _config;

	private WeakReference _parent;

	private List<YogaNode> _children;

	private MeasureFunction _measureFunction;

	private BaselineFunction _baselineFunction;

	private object _data;

	internal YogaConfig Config
	{
		set
		{
		}
	}

	public bool IsDirty => false;

	public bool HasNewLayout => false;

	public bool IsMeasureDefined => false;

	public bool IsBaselineDefined => false;

	public YogaFlexDirection FlexDirection
	{
		set
		{
		}
	}

	public YogaJustify JustifyContent
	{
		set
		{
		}
	}

	public YogaDisplay Display
	{
		set
		{
		}
	}

	public YogaAlign AlignItems
	{
		set
		{
		}
	}

	public YogaAlign AlignSelf
	{
		set
		{
		}
	}

	public YogaAlign AlignContent
	{
		set
		{
		}
	}

	public YogaPositionType PositionType
	{
		set
		{
		}
	}

	public YogaWrap Wrap
	{
		set
		{
		}
	}

	public float Flex
	{
		set
		{
		}
	}

	public float FlexGrow
	{
		set
		{
		}
	}

	public float FlexShrink
	{
		set
		{
		}
	}

	public YogaValue FlexBasis
	{
		set
		{
		}
	}

	public YogaValue Width
	{
		set
		{
		}
	}

	public YogaValue Height
	{
		set
		{
		}
	}

	public YogaValue MaxWidth
	{
		set
		{
		}
	}

	public YogaValue MaxHeight
	{
		set
		{
		}
	}

	public YogaValue MinWidth
	{
		set
		{
		}
	}

	public YogaValue MinHeight
	{
		set
		{
		}
	}

	public float LayoutX => 0f;

	public float LayoutY => 0f;

	public float LayoutRight => 0f;

	public float LayoutBottom => 0f;

	public float LayoutWidth => 0f;

	public float LayoutHeight => 0f;

	public YogaOverflow Overflow
	{
		set
		{
		}
	}

	public int Count => 0;

	public YogaValue Left
	{
		set
		{
		}
	}

	public YogaValue Top
	{
		set
		{
		}
	}

	public YogaValue Right
	{
		set
		{
		}
	}

	public YogaValue Bottom
	{
		set
		{
		}
	}

	public YogaValue MarginLeft
	{
		set
		{
		}
	}

	public YogaValue MarginTop
	{
		set
		{
		}
	}

	public YogaValue MarginRight
	{
		set
		{
		}
	}

	public YogaValue MarginBottom
	{
		set
		{
		}
	}

	public YogaValue PaddingLeft
	{
		set
		{
		}
	}

	public YogaValue PaddingTop
	{
		set
		{
		}
	}

	public YogaValue PaddingRight
	{
		set
		{
		}
	}

	public YogaValue PaddingBottom
	{
		set
		{
		}
	}

	public float BorderLeftWidth
	{
		set
		{
		}
	}

	public float BorderTopWidth
	{
		set
		{
		}
	}

	public float BorderRightWidth
	{
		set
		{
		}
	}

	public float BorderBottomWidth
	{
		set
		{
		}
	}

	public float LayoutMarginLeft => 0f;

	public float LayoutMarginTop => 0f;

	public float LayoutMarginRight => 0f;

	public float LayoutMarginBottom => 0f;

	public float LayoutPaddingLeft => 0f;

	public float LayoutPaddingTop => 0f;

	public float LayoutPaddingRight => 0f;

	public float LayoutPaddingBottom => 0f;

	public float LayoutBorderLeft => 0f;

	public float LayoutBorderTop => 0f;

	public float LayoutBorderRight => 0f;

	public float LayoutBorderBottom => 0f;

	public YogaNode(YogaConfig config = null)
	{
	}

	~YogaNode()
	{
	}

	public virtual void MarkDirty()
	{
	}

	public void CopyStyle(YogaNode srcNode)
	{
	}

	public void MarkLayoutSeen()
	{
	}

	public void Insert(int index, YogaNode node)
	{
	}

	public void RemoveAt(int index)
	{
	}

	public void Clear()
	{
	}

	public void SetMeasureFunction(MeasureFunction measureFunction)
	{
	}

	public void CalculateLayout(float width = float.NaN, float height = float.NaN)
	{
	}

	public static YogaSize MeasureInternal(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode)
	{
		return default(YogaSize);
	}

	public static float BaselineInternal(YogaNode node, float width, float height)
	{
		return 0f;
	}

	public IEnumerator<YogaNode> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	private void SetStylePosition(YogaEdge edge, YogaValue value)
	{
	}

	private void SetStyleMargin(YogaEdge edge, YogaValue value)
	{
	}

	private void SetStylePadding(YogaEdge edge, YogaValue value)
	{
	}
}
