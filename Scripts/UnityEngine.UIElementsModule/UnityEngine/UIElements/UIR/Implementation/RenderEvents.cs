namespace UnityEngine.UIElements.UIR.Implementation;

internal static class RenderEvents
{
	private static readonly float VisibilityTreshold;

	internal static void ProcessOnClippingChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats)
	{
	}

	internal static void ProcessOnOpacityChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats)
	{
	}

	internal static void ProcessOnColorChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats)
	{
	}

	internal static void ProcessOnTransformOrSizeChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats)
	{
	}

	internal static void ProcessOnVisualsChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats)
	{
	}

	private static Matrix4x4 GetTransformIDTransformInfo(VisualElement ve)
	{
		return default(Matrix4x4);
	}

	private static Vector4 GetClipRectIDClipInfo(VisualElement ve)
	{
		return default(Vector4);
	}

	internal static uint DepthFirstOnChildAdded(RenderChain renderChain, VisualElement parent, VisualElement ve, int index, bool resetState)
	{
		return 0u;
	}

	internal static uint DepthFirstOnChildRemoving(RenderChain renderChain, VisualElement ve)
	{
		return 0u;
	}

	private static void DepthFirstOnClippingChanged(RenderChain renderChain, VisualElement parent, VisualElement ve, uint dirtyID, bool hierarchical, bool isRootOfChange, bool isPendingHierarchicalRepaint, bool inheritedClipRectIDChanged, bool inheritedMaskingChanged, UIRenderDevice device, ref ChainBuilderStats stats)
	{
	}

	private static void DepthFirstOnOpacityChanged(RenderChain renderChain, float parentCompositeOpacity, VisualElement ve, uint dirtyID, bool hierarchical, ref ChainBuilderStats stats, bool isDoingFullVertexRegeneration = false)
	{
	}

	private static void OnColorChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats)
	{
	}

	private static void DepthFirstOnTransformOrSizeChanged(RenderChain renderChain, VisualElement parent, VisualElement ve, uint dirtyID, UIRenderDevice device, bool isAncestorOfChangeSkinned, bool transformChanged, ref ChainBuilderStats stats)
	{
	}

	private static void DepthFirstOnVisualsChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, bool parentHierarchyHidden, bool hierarchical, ref ChainBuilderStats stats)
	{
	}

	private static bool UpdateTextCoreSettings(RenderChain renderChain, VisualElement ve)
	{
		return false;
	}

	private static bool IsElementHierarchyHidden(VisualElement ve)
	{
		return false;
	}

	private static VisualElement GetLastDeepestChild(VisualElement ve)
	{
		return null;
	}

	private static ClipMethod DetermineSelfClipMethod(RenderChain renderChain, VisualElement ve)
	{
		return default(ClipMethod);
	}

	private static bool UpdateLocalFlipsWinding(VisualElement ve)
	{
		return false;
	}

	private static void UpdateWorldFlipsWinding(VisualElement ve)
	{
	}

	private static void UpdateZeroScaling(VisualElement ve)
	{
	}

	private static bool NeedsTransformID(VisualElement ve)
	{
		return false;
	}

	internal static bool NeedsColorID(VisualElement ve)
	{
		return false;
	}

	internal static bool NeedsTextCoreSettings(VisualElement ve)
	{
		return false;
	}

	private static bool InitColorIDs(RenderChain renderChain, VisualElement ve)
	{
		return false;
	}

	private static void SetColorValues(RenderChain renderChain, VisualElement ve)
	{
	}
}
