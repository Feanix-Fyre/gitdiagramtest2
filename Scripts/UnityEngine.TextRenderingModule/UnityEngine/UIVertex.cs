using UnityEngine.Scripting;

namespace UnityEngine;

[UsedByNativeCode]
public struct UIVertex
{
	public Vector3 position;

	public Vector3 normal;

	public Vector4 tangent;

	public Color32 color;

	public Vector4 uv0;

	public Vector4 uv1;

	public Vector4 uv2;

	public Vector4 uv3;

	private static readonly Color32 s_DefaultColor;

	private static readonly Vector4 s_DefaultTangent;

	public static UIVertex simpleVert;
}
