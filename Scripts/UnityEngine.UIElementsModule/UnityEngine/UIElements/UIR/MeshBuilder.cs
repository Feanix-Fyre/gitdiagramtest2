using Unity.Profiling;
using UnityEngine.TextCore.Text;

namespace UnityEngine.UIElements.UIR;

internal static class MeshBuilder
{
	internal struct AllocMeshData
	{
		internal delegate MeshWriteData Allocator(uint vertexCount, uint indexCount, ref AllocMeshData allocatorData);

		internal Allocator alloc;

		internal Texture texture;

		internal TextureId svgTexture;

		internal Material material;

		internal MeshGenerationContext.MeshFlags flags;

		internal BMPAlloc colorAlloc;

		internal MeshWriteData Allocate(uint vertexCount, uint indexCount)
		{
			return null;
		}
	}

	private static ProfilerMarker s_VectorGraphics9Slice;

	private static ProfilerMarker s_VectorGraphicsSplitTriangle;

	private static ProfilerMarker s_VectorGraphicsScaleTriangle;

	private static ProfilerMarker s_VectorGraphicsStretch;

	internal static readonly int s_MaxTextMeshVertices;

	private static Vertex ConvertTextVertexToUIRVertex(MeshInfo info, int index, Vector2 offset, VertexFlags flags = VertexFlags.IsText, bool isDynamicColor = false)
	{
		return default(Vertex);
	}

	private static int LimitTextVertices(int vertexCount, bool logTruncation = true)
	{
		return 0;
	}

	internal static void MakeText(MeshInfo meshInfo, Vector2 offset, AllocMeshData meshAlloc, VertexFlags flags = VertexFlags.IsText, bool isDynamicColor = false)
	{
	}
}
