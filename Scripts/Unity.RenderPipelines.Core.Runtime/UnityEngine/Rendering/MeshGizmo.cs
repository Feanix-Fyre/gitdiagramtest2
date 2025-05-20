using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering;

internal class MeshGizmo : IDisposable
{
	public static readonly int vertexCountPerCube;

	public Mesh mesh;

	private List<Vector3> vertices;

	private List<int> indices;

	private List<Color> colors;

	private Material wireMaterial;

	private Material dottedWireMaterial;

	private Material solidMaterial;

	public MeshGizmo(int capacity = 0)
	{
	}

	public void Clear()
	{
	}

	public void AddWireCube(Vector3 center, Vector3 size, Color color)
	{
	}

	private void DrawMesh(Matrix4x4 trs, Material mat, MeshTopology topology, CompareFunction depthTest, string gizmoName)
	{
	}

	public void RenderWireframe(Matrix4x4 trs, CompareFunction depthTest = CompareFunction.LessEqual, string gizmoName = null)
	{
	}

	public void Dispose()
	{
	}
}
