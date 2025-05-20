using System;
using Unity.Collections;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR.Implementation;

internal static class CommandGenerator
{
	private static readonly ProfilerMarker k_GenerateEntries;

	private static readonly ProfilerMarker k_ConvertEntriesToCommandsMarker;

	private static readonly ProfilerMarker k_GenerateClosingCommandsMarker;

	private static readonly ProfilerMarker k_NudgeVerticesMarker;

	private static readonly ProfilerMarker k_UpdateOpacityIdMarker;

	private static readonly ProfilerMarker k_ComputeTransformMatrixMarker;

	private static Material s_blitMaterial_LinearToGamma;

	private static Material s_blitMaterial_GammaToLinear;

	private static Material s_blitMaterial_NoChange;

	private static Shader s_blitShader;

	private static void GetVerticesTransformInfo(VisualElement ve, out Matrix4x4 transform)
	{
		transform = default(Matrix4x4);
	}

	internal static void ComputeTransformMatrix(VisualElement ve, VisualElement ancestor, out Matrix4x4 result)
	{
		result = default(Matrix4x4);
	}

	private static bool IsParentOrAncestorOf(this VisualElement ve, VisualElement child)
	{
		return false;
	}

	public static UIRStylePainter.ClosingInfo PaintElement(RenderChain renderChain, VisualElement ve, ref ChainBuilderStats stats)
	{
		return default(UIRStylePainter.ClosingInfo);
	}

	private static void InvokeGenerateVisualContent(VisualElement ve, MeshGenerationContext ctx)
	{
	}

	private static Material CreateBlitShader(float colorConversion)
	{
		return null;
	}

	private static Material GetBlitMaterial(VisualElement.RenderTargetMode mode)
	{
		return null;
	}

	public static void ClosePaintElement(VisualElement ve, UIRStylePainter.ClosingInfo closingInfo, RenderChain renderChain, ref ChainBuilderStats stats)
	{
	}

	private static void UpdateOrAllocate(ref MeshHandle data, int vertexCount, int indexCount, UIRenderDevice device, out NativeSlice<Vertex> verts, out NativeSlice<ushort> indices, out ushort indexOffset, ref ChainBuilderStats stats)
	{
		verts = default(NativeSlice<Vertex>);
		indices = default(NativeSlice<ushort>);
		indexOffset = default(ushort);
	}

	public static void UpdateOpacityId(VisualElement ve, RenderChain renderChain)
	{
	}

	private static void DoUpdateOpacityId(VisualElement ve, RenderChain renderChain, MeshHandle mesh)
	{
	}

	public static bool NudgeVerticesToNewSpace(VisualElement ve, RenderChain renderChain, UIRenderDevice device)
	{
		return false;
	}

	private static void PrepareNudgeVertices(VisualElement ve, UIRenderDevice device, MeshHandle mesh, out IntPtr src, out IntPtr dst, out int count)
	{
		src = default(IntPtr);
		dst = default(IntPtr);
		count = default(int);
	}

	private static RenderChainCommand InjectMeshDrawCommand(RenderChain renderChain, VisualElement ve, ref RenderChainCommand cmdPrev, ref RenderChainCommand cmdNext, MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture, int stencilRef)
	{
		return null;
	}

	private static RenderChainCommand InjectClosingMeshDrawCommand(RenderChain renderChain, VisualElement ve, ref RenderChainCommand cmdPrev, ref RenderChainCommand cmdNext, MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture, int stencilRef)
	{
		return null;
	}

	private static void FindCommandInsertionPoint(VisualElement ve, out RenderChainCommand prev, out RenderChainCommand next)
	{
		prev = null;
		next = null;
	}

	private static void FindClosingCommandInsertionPoint(VisualElement ve, out RenderChainCommand prev, out RenderChainCommand next)
	{
		prev = null;
		next = null;
	}

	private static void InjectCommandInBetween(RenderChain renderChain, RenderChainCommand cmd, ref RenderChainCommand prev, ref RenderChainCommand next)
	{
	}

	private static void InjectClosingCommandInBetween(RenderChain renderChain, RenderChainCommand cmd, ref RenderChainCommand prev, ref RenderChainCommand next)
	{
	}

	public static void ResetCommands(RenderChain renderChain, VisualElement ve)
	{
	}
}
