using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeClass("UI::CanvasRenderer")]
[NativeHeader("Modules/UI/CanvasRenderer.h")]
public sealed class CanvasRenderer : Component
{
	public bool hasPopInstruction
	{
		set
		{
		}
	}

	public int materialCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int popMaterialCount
	{
		set
		{
		}
	}

	public int absoluteDepth => 0;

	public bool hasMoved => false;

	public bool cullTransparentMesh
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[NativeProperty("ShouldCull", false, TargetType.Function)]
	public bool cull
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Vector2 clippingSoftness
	{
		set
		{
		}
	}

	public void SetColor(Color color)
	{
	}

	public Color GetColor()
	{
		return default(Color);
	}

	public void EnableRectClipping(Rect rect)
	{
	}

	public void DisableRectClipping()
	{
	}

	public void SetMaterial(Material material, int index)
	{
	}

	public Material GetMaterial(int index)
	{
		return null;
	}

	public void SetPopMaterial(Material material, int index)
	{
	}

	public void SetTexture(Texture texture)
	{
	}

	public void SetAlphaTexture(Texture texture)
	{
	}

	public void SetMesh(Mesh mesh)
	{
	}

	public void Clear()
	{
	}

	public void SetMaterial(Material material, Texture texture)
	{
	}

	public Material GetMaterial()
	{
		return null;
	}

	public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices)
	{
	}

	public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices)
	{
	}

	public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents)
	{
	}

	[StaticAccessor("UI", StaticAccessorType.DoubleColon)]
	private static void SplitIndicesStreamsInternal(object verts, object indices)
	{
	}

	[StaticAccessor("UI", StaticAccessorType.DoubleColon)]
	private static void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents)
	{
	}

	[StaticAccessor("UI", StaticAccessorType.DoubleColon)]
	private static void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices)
	{
	}

	private void SetColor_Injected(ref Color color)
	{
	}

	private void GetColor_Injected(out Color ret)
	{
		ret = default(Color);
	}

	private void EnableRectClipping_Injected(ref Rect rect)
	{
	}

	[SpecialName]
	private void set_clippingSoftness_Injected(ref Vector2 value)
	{
	}
}
