using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
[NativeType("Runtime/Graphics/SpriteFrame.h")]
[NativeHeader("Runtime/2D/Common/ScriptBindings/SpritesMarshalling.h")]
[NativeHeader("Runtime/Graphics/SpriteUtility.h")]
public sealed class Sprite : Object
{
	public Bounds bounds => default(Bounds);

	public Rect rect => default(Rect);

	public Vector4 border => default(Vector4);

	public Texture2D texture => null;

	public float pixelsPerUnit
	{
		[NativeMethod("GetPixelsToUnits")]
		get
		{
			return 0f;
		}
	}

	public Texture2D associatedAlphaSplitTexture
	{
		[NativeMethod("GetAlphaTexture")]
		get
		{
			return null;
		}
	}

	public Vector2 pivot
	{
		[NativeMethod("GetPivotInPixels")]
		get
		{
			return default(Vector2);
		}
	}

	public bool packed => false;

	public SpritePackingRotation packingRotation => default(SpritePackingRotation);

	public Vector2[] vertices
	{
		[FreeFunction("SpriteAccessLegacy::GetSpriteVertices", HasExplicitThis = true)]
		get
		{
			return null;
		}
	}

	public ushort[] triangles
	{
		[FreeFunction("SpriteAccessLegacy::GetSpriteIndices", HasExplicitThis = true)]
		get
		{
			return null;
		}
	}

	public Vector2[] uv
	{
		[FreeFunction("SpriteAccessLegacy::GetSpriteUVs", HasExplicitThis = true)]
		get
		{
			return null;
		}
	}

	[RequiredByNativeCode]
	private Sprite()
	{
	}

	internal int GetPackingRotation()
	{
		return 0;
	}

	internal int GetPacked()
	{
		return 0;
	}

	internal Vector4 GetInnerUVs()
	{
		return default(Vector4);
	}

	internal Vector4 GetOuterUVs()
	{
		return default(Vector4);
	}

	internal Vector4 GetPadding()
	{
		return default(Vector4);
	}

	[FreeFunction("SpritesBindings::CreateSprite", ThrowsException = true)]
	internal static Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, [Unmarshalled] SecondarySpriteTexture[] secondaryTexture)
	{
		return null;
	}

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape)
	{
		return null;
	}

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTextures)
	{
		return null;
	}

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border)
	{
		return null;
	}

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType)
	{
		return null;
	}

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude)
	{
		return null;
	}

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit)
	{
		return null;
	}

	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot)
	{
		return null;
	}

	private void GetInnerUVs_Injected(out Vector4 ret)
	{
		ret = default(Vector4);
	}

	private void GetOuterUVs_Injected(out Vector4 ret)
	{
		ret = default(Vector4);
	}

	private void GetPadding_Injected(out Vector4 ret)
	{
		ret = default(Vector4);
	}

	private static Sprite CreateSprite_Injected(Texture2D texture, ref Rect rect, ref Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, ref Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTexture)
	{
		return null;
	}

	[SpecialName]
	private void get_bounds_Injected(out Bounds ret)
	{
		ret = default(Bounds);
	}

	[SpecialName]
	private void get_rect_Injected(out Rect ret)
	{
		ret = default(Rect);
	}

	[SpecialName]
	private void get_border_Injected(out Vector4 ret)
	{
		ret = default(Vector4);
	}

	[SpecialName]
	private void get_pivot_Injected(out Vector2 ret)
	{
		ret = default(Vector2);
	}
}
