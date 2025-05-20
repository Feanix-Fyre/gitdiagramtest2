using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Yoga;

[NativeHeader("ModuleOverrides/com.unity.ui/Core/Native/YogaNative.bindings.h")]
internal static class Native
{
	[FreeFunction]
	public static IntPtr YGNodeNewWithConfig(IntPtr config)
	{
		return (IntPtr)0;
	}

	public static void YGNodeFree(IntPtr ygNode)
	{
	}

	[FreeFunction(Name = "YGNodeFree", IsThreadSafe = true)]
	private static void YGNodeFreeInternal(IntPtr ygNode)
	{
	}

	[FreeFunction]
	public static void YGSetManagedObject(IntPtr ygNode, YogaNode node)
	{
	}

	[FreeFunction]
	public static void YGNodeSetConfig(IntPtr ygNode, IntPtr config)
	{
	}

	[FreeFunction(IsThreadSafe = true)]
	public static IntPtr YGConfigGetDefault()
	{
		return (IntPtr)0;
	}

	[FreeFunction]
	public static IntPtr YGConfigNew()
	{
		return (IntPtr)0;
	}

	public static void YGConfigFree(IntPtr config)
	{
	}

	[FreeFunction(Name = "YGConfigFree", IsThreadSafe = true)]
	private static void YGConfigFreeInternal(IntPtr config)
	{
	}

	[FreeFunction]
	public static void YGConfigSetUseWebDefaults(IntPtr config, bool useWebDefaults)
	{
	}

	[FreeFunction]
	public static bool YGConfigGetUseWebDefaults(IntPtr config)
	{
		return false;
	}

	[FreeFunction]
	public static void YGConfigSetPointScaleFactor(IntPtr config, float pixelsInPoint)
	{
	}

	[FreeFunction]
	public static void YGNodeInsertChild(IntPtr node, IntPtr child, uint index)
	{
	}

	[FreeFunction]
	public static void YGNodeRemoveChild(IntPtr node, IntPtr child)
	{
	}

	[FreeFunction]
	public static void YGNodeCalculateLayout(IntPtr node, float availableWidth, float availableHeight, YogaDirection parentDirection)
	{
	}

	[FreeFunction]
	public static void YGNodeMarkDirty(IntPtr node)
	{
	}

	[FreeFunction]
	public static bool YGNodeIsDirty(IntPtr node)
	{
		return false;
	}

	[FreeFunction]
	public static void YGNodeCopyStyle(IntPtr dstNode, IntPtr srcNode)
	{
	}

	[FreeFunction(Name = "YogaCallback::SetMeasureFunc")]
	public static void YGNodeSetMeasureFunc(IntPtr node)
	{
	}

	[FreeFunction(Name = "YogaCallback::RemoveMeasureFunc")]
	public static void YGNodeRemoveMeasureFunc(IntPtr node)
	{
	}

	[RequiredByNativeCode]
	public static void YGNodeMeasureInvoke(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode, IntPtr returnValueAddress)
	{
	}

	[RequiredByNativeCode]
	public static void YGNodeBaselineInvoke(YogaNode node, float width, float height, IntPtr returnValueAddress)
	{
	}

	[FreeFunction]
	public static void YGNodeSetHasNewLayout(IntPtr node, bool hasNewLayout)
	{
	}

	[FreeFunction]
	public static bool YGNodeGetHasNewLayout(IntPtr node)
	{
		return false;
	}

	[FreeFunction]
	public static YogaDirection YGNodeStyleGetDirection(IntPtr node)
	{
		return default(YogaDirection);
	}

	[FreeFunction]
	public static void YGNodeStyleSetFlexDirection(IntPtr node, YogaFlexDirection flexDirection)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetJustifyContent(IntPtr node, YogaJustify justifyContent)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetAlignContent(IntPtr node, YogaAlign alignContent)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetAlignItems(IntPtr node, YogaAlign alignItems)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetAlignSelf(IntPtr node, YogaAlign alignSelf)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetPositionType(IntPtr node, YogaPositionType positionType)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetFlexWrap(IntPtr node, YogaWrap flexWrap)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetOverflow(IntPtr node, YogaOverflow flexWrap)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetDisplay(IntPtr node, YogaDisplay display)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetFlex(IntPtr node, float flex)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetFlexGrow(IntPtr node, float flexGrow)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetFlexShrink(IntPtr node, float flexShrink)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetFlexBasis(IntPtr node, float flexBasis)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetFlexBasisPercent(IntPtr node, float flexBasis)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetFlexBasisAuto(IntPtr node)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetWidth(IntPtr node, float width)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetWidthPercent(IntPtr node, float width)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetWidthAuto(IntPtr node)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetHeight(IntPtr node, float height)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetHeightPercent(IntPtr node, float height)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetHeightAuto(IntPtr node)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetMinWidth(IntPtr node, float minWidth)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetMinWidthPercent(IntPtr node, float minWidth)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetMinHeight(IntPtr node, float minHeight)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetMinHeightPercent(IntPtr node, float minHeight)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetMaxWidth(IntPtr node, float maxWidth)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetMaxWidthPercent(IntPtr node, float maxWidth)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetMaxHeight(IntPtr node, float maxHeight)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetMaxHeightPercent(IntPtr node, float maxHeight)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetPosition(IntPtr node, YogaEdge edge, float position)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetPositionPercent(IntPtr node, YogaEdge edge, float position)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetMargin(IntPtr node, YogaEdge edge, float margin)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetMarginPercent(IntPtr node, YogaEdge edge, float margin)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetMarginAuto(IntPtr node, YogaEdge edge)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetPadding(IntPtr node, YogaEdge edge, float padding)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetPaddingPercent(IntPtr node, YogaEdge edge, float padding)
	{
	}

	[FreeFunction]
	public static void YGNodeStyleSetBorder(IntPtr node, YogaEdge edge, float border)
	{
	}

	[FreeFunction]
	public static float YGNodeLayoutGetLeft(IntPtr node)
	{
		return 0f;
	}

	[FreeFunction]
	public static float YGNodeLayoutGetTop(IntPtr node)
	{
		return 0f;
	}

	[FreeFunction]
	public static float YGNodeLayoutGetRight(IntPtr node)
	{
		return 0f;
	}

	[FreeFunction]
	public static float YGNodeLayoutGetBottom(IntPtr node)
	{
		return 0f;
	}

	[FreeFunction]
	public static float YGNodeLayoutGetWidth(IntPtr node)
	{
		return 0f;
	}

	[FreeFunction]
	public static float YGNodeLayoutGetHeight(IntPtr node)
	{
		return 0f;
	}

	[FreeFunction]
	public static float YGNodeLayoutGetMargin(IntPtr node, YogaEdge edge)
	{
		return 0f;
	}

	[FreeFunction]
	public static float YGNodeLayoutGetPadding(IntPtr node, YogaEdge edge)
	{
		return 0f;
	}

	[FreeFunction]
	public static float YGNodeLayoutGetBorder(IntPtr node, YogaEdge edge)
	{
		return 0f;
	}
}
