using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements.UIR.Implementation;

internal class UIRStylePainter : IStylePainter
{
	internal struct Entry
	{
		public NativeSlice<Vertex> vertices;

		public NativeSlice<ushort> indices;

		public Material material;

		public float fontTexSDFScale;

		public TextureId texture;

		public RenderChainCommand customCommand;

		public BMPAlloc clipRectID;

		public VertexFlags addFlags;

		public bool uvIsDisplacement;

		public bool isTextEntry;

		public bool isClipRegisterEntry;

		public int stencilRef;

		public int maskDepth;
	}

	internal struct ClosingInfo
	{
		public bool needsClosing;

		public bool popViewMatrix;

		public bool popScissorClip;

		public bool blitAndPopRenderTexture;

		public bool PopDefaultMaterial;

		public RenderChainCommand clipUnregisterDrawCommand;

		public NativeSlice<Vertex> clipperRegisterVertices;

		public NativeSlice<ushort> clipperRegisterIndices;

		public int clipperRegisterIndexOffset;

		public int maskStencilRef;
	}

	private struct RepeatRectUV
	{
		public Rect rect;

		public Rect uv;
	}

	private RenderChain m_Owner;

	private List<Entry> m_Entries;

	private AtlasBase m_Atlas;

	private VectorImageManager m_VectorImageManager;

	private Entry m_CurrentEntry;

	private ClosingInfo m_ClosingInfo;

	private int m_MaskDepth;

	private int m_StencilRef;

	private BMPAlloc m_ClipRectID;

	private int m_SVGBackgroundEntryIndex;

	private TempAllocator<Vertex> m_VertsPool;

	private TempAllocator<ushort> m_IndicesPool;

	private List<MeshWriteData> m_MeshWriteDataPool;

	private int m_NextMeshWriteDataPoolItem;

	private List<RepeatRectUV>[] m_RepeatRectUVList;

	private MeshBuilder.AllocMeshData.Allocator m_AllocRawVertsIndicesDelegate;

	private MeshBuilder.AllocMeshData.Allocator m_AllocThroughDrawMeshDelegate;

	private TextInfo m_TextInfo;

	public MeshGenerationContext meshGenerationContext { get; }

	public VisualElement currentElement { get; private set; }

	public List<Entry> entries => null;

	public ClosingInfo closingInfo => default(ClosingInfo);

	public int totalVertices { get; private set; }

	public int totalIndices { get; private set; }

	public VisualElement visualElement => null;

	private MeshWriteData GetPooledMeshWriteData()
	{
		return null;
	}

	private MeshWriteData AllocRawVertsIndices(uint vertexCount, uint indexCount, ref MeshBuilder.AllocMeshData allocatorData)
	{
		return null;
	}

	private MeshWriteData AllocThroughDrawMesh(uint vertexCount, uint indexCount, ref MeshBuilder.AllocMeshData allocatorData)
	{
		return null;
	}

	public UIRStylePainter(RenderChain renderChain)
	{
	}

	public void Begin(VisualElement ve)
	{
	}

	public void LandClipUnregisterMeshDrawCommand(RenderChainCommand cmd)
	{
	}

	public void LandClipRegisterMesh(NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, int indexOffset)
	{
	}

	public MeshWriteData DrawMesh(int vertexCount, int indexCount, Texture texture, Material material, MeshGenerationContext.MeshFlags flags)
	{
		return null;
	}

	internal void TryAtlasTexture(Texture texture, MeshGenerationContext.MeshFlags flags, out Rect outUVRegion, out bool outIsAtlas, out TextureId outTextureId, out VertexFlags outAddFlags)
	{
		outUVRegion = default(Rect);
		outIsAtlas = default(bool);
		outTextureId = default(TextureId);
		outAddFlags = default(VertexFlags);
	}

	internal void BuildEntryFromNativeMesh(MeshWriteDataInterface meshData, Texture texture, TextureId textureId, bool isAtlas, Material material, MeshGenerationContext.MeshFlags flags, Rect uvRegion, VertexFlags addFlags)
	{
	}

	internal void BuildGradientEntryFromNativeMesh(MeshWriteDataInterface meshData, TextureId svgTextureId)
	{
	}

	public void BuildRawEntryFromNativeMesh(MeshWriteDataInterface meshData)
	{
	}

	public void DrawText(TextElement te)
	{
	}

	private void DrawTextInfo(TextInfo textInfo, Vector2 offset, bool useHints)
	{
	}

	public void DrawRectangle(MeshGenerationContextUtils.RectangleParams rectParams)
	{
	}

	public void DrawBorder(MeshGenerationContextUtils.BorderParams borderParams)
	{
	}

	public void DrawImmediate(Action callback, bool cullingEnabled)
	{
	}

	public void DrawVisualElementBackground()
	{
	}

	private void DrawRectangleRepeat(MeshGenerationContextUtils.RectangleParams rectParams, Rect totalRect, float scaledPixelsPerPoint)
	{
	}

	private void StampRectangleWithSubRect(MeshGenerationContextUtils.RectangleParams rectParams, Rect targetRect, Rect targetUV)
	{
	}

	public void DrawVisualElementBorder()
	{
	}

	public void ApplyVisualElementClipping()
	{
	}

	private ushort[] AdjustSpriteWinding(Vector2[] vertices, ushort[] indices)
	{
		return null;
	}

	public void DrawSprite(MeshGenerationContextUtils.RectangleParams rectParams)
	{
	}

	private void ApplyInset(ref MeshBuilderNative.NativeRectParams rectParams, Texture tex)
	{
	}

	public void DrawVectorImage(MeshGenerationContextUtils.RectangleParams rectParams)
	{
	}

	private void MakeVectorGraphics(MeshGenerationContextUtils.RectangleParams rectParams, bool isUsingGradients, TextureId svgTexture, int settingIndexOffset, out int finalVertexCount, out int finalIndexCount)
	{
		finalVertexCount = default(int);
		finalIndexCount = default(int);
	}

	internal void Reset()
	{
	}

	private void ValidateMeshWriteData()
	{
	}

	private void GenerateStencilClipEntryForRoundedRectBackground()
	{
	}

	private void GenerateStencilClipEntryForSVGBackground()
	{
	}
}
