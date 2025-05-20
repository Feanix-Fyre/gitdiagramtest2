namespace UnityEngine.Experimental.Rendering;

internal readonly struct XRView
{
	internal readonly Matrix4x4 projMatrix;

	internal readonly Matrix4x4 viewMatrix;

	internal readonly Rect viewport;

	internal readonly Mesh occlusionMesh;

	internal readonly int textureArraySlice;

	internal readonly Vector2 eyeCenterUV;

	internal XRView(Matrix4x4 projMatrix, Matrix4x4 viewMatrix, Rect viewport, Mesh occlusionMesh, int textureArraySlice)
	{
		this.projMatrix = default(Matrix4x4);
		this.viewMatrix = default(Matrix4x4);
		this.viewport = default(Rect);
		this.occlusionMesh = null;
		this.textureArraySlice = 0;
		eyeCenterUV = default(Vector2);
	}

	private static Vector2 ComputeEyeCenterUV(Matrix4x4 proj)
	{
		return default(Vector2);
	}
}
