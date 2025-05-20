using UnityEngine.TextCore.LowLevel;

namespace UnityEngine.TextCore.Text;

internal struct MeshInfo
{
	private static readonly Color32 k_DefaultColor;

	private static readonly Vector3 k_DefaultNormal;

	private static readonly Vector4 k_DefaultTangent;

	public int vertexCount;

	public Vector3[] vertices;

	public Vector3[] normals;

	public Vector4[] tangents;

	public Vector4[] uvs0;

	public Vector2[] uvs2;

	public Color32[] colors32;

	public int[] triangles;

	public Material material;

	internal GlyphRenderMode glyphRenderMode;

	public MeshInfo(int size)
	{
		vertexCount = 0;
		vertices = null;
		normals = null;
		tangents = null;
		uvs0 = null;
		uvs2 = null;
		colors32 = null;
		triangles = null;
		material = null;
		glyphRenderMode = default(GlyphRenderMode);
	}

	internal void ResizeMeshInfo(int size)
	{
	}

	internal void Clear(bool uploadChanges)
	{
	}

	internal void ClearUnusedVertices()
	{
	}

	internal void SortGeometry(VertexSortingOrder order)
	{
	}

	internal void SwapVertexData(int src, int dst)
	{
	}
}
