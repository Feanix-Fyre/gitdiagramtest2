using System.Runtime.CompilerServices;
using Unity.Collections;

namespace UnityEngine.UIElements;

public class MeshWriteData
{
	internal NativeSlice<Vertex> m_Vertices;

	internal NativeSlice<ushort> m_Indices;

	internal Rect m_UVRegion;

	internal int currentIndex;

	internal int currentVertex;

	public int vertexCount => 0;

	public int indexCount => 0;

	public Rect uvRegion => default(Rect);

	internal MeshWriteData()
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetNextVertex(Vertex vertex)
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void SetNextIndex(ushort index)
	{
	}

	public void SetAllVertices(Vertex[] vertices)
	{
	}

	public void SetAllIndices(ushort[] indices)
	{
	}

	internal void Reset(NativeSlice<Vertex> vertices, NativeSlice<ushort> indices)
	{
	}

	internal void Reset(NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, Rect uvRegion)
	{
	}
}
