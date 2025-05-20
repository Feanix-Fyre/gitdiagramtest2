using Unity.Collections;

namespace UnityEngine.UIElements.UIR;

internal struct UIRVEShaderInfoAllocator
{
	private BaseShaderInfoStorage m_Storage;

	private BitmapAllocator32 m_TransformAllocator;

	private BitmapAllocator32 m_ClipRectAllocator;

	private BitmapAllocator32 m_OpacityAllocator;

	private BitmapAllocator32 m_ColorAllocator;

	private BitmapAllocator32 m_TextSettingsAllocator;

	private bool m_StorageReallyCreated;

	private bool m_VertexTexturingEnabled;

	private NativeArray<Transform3x4> m_Transforms;

	private NativeArray<Vector4> m_ClipRects;

	internal static readonly Vector2Int identityTransformTexel;

	internal static readonly Vector2Int infiniteClipRectTexel;

	internal static readonly Vector2Int fullOpacityTexel;

	internal static readonly Vector2Int clearColorTexel;

	internal static readonly Vector2Int defaultTextCoreSettingsTexel;

	internal static readonly Matrix4x4 identityTransformValue;

	internal static readonly Vector4 identityTransformRow0Value;

	internal static readonly Vector4 identityTransformRow1Value;

	internal static readonly Vector4 identityTransformRow2Value;

	internal static readonly Vector4 infiniteClipRectValue;

	internal static readonly Vector4 fullOpacityValue;

	internal static readonly Vector4 clearColorValue;

	internal static readonly TextCoreSettings defaultTextCoreSettingsValue;

	public static readonly BMPAlloc identityTransform;

	public static readonly BMPAlloc infiniteClipRect;

	public static readonly BMPAlloc fullOpacity;

	public static readonly BMPAlloc clearColor;

	public static readonly BMPAlloc defaultTextCoreSettings;

	private static int pageWidth => 0;

	private static int pageHeight => 0;

	public NativeSlice<Transform3x4> transformConstants => default(NativeSlice<Transform3x4>);

	public NativeSlice<Vector4> clipRectConstants => default(NativeSlice<Vector4>);

	public Texture atlas => null;

	private static Vector2Int AllocToTexelCoord(ref BitmapAllocator32 allocator, BMPAlloc alloc)
	{
		return default(Vector2Int);
	}

	private static int AllocToConstantBufferIndex(BMPAlloc alloc)
	{
		return 0;
	}

	private static bool AtlasRectMatchesPage(ref BitmapAllocator32 allocator, BMPAlloc defAlloc, RectInt atlasRect)
	{
		return false;
	}

	public void Construct()
	{
	}

	private void ReallyCreateStorage()
	{
	}

	public void Dispose()
	{
	}

	public void IssuePendingStorageChanges()
	{
	}

	public BMPAlloc AllocTransform()
	{
		return default(BMPAlloc);
	}

	public BMPAlloc AllocClipRect()
	{
		return default(BMPAlloc);
	}

	public BMPAlloc AllocOpacity()
	{
		return default(BMPAlloc);
	}

	public BMPAlloc AllocColor()
	{
		return default(BMPAlloc);
	}

	public BMPAlloc AllocTextCoreSettings(TextCoreSettings settings)
	{
		return default(BMPAlloc);
	}

	public void SetTransformValue(BMPAlloc alloc, Matrix4x4 xform)
	{
	}

	public void SetClipRectValue(BMPAlloc alloc, Vector4 clipRect)
	{
	}

	public void SetOpacityValue(BMPAlloc alloc, float opacity)
	{
	}

	public void SetColorValue(BMPAlloc alloc, Color color, bool isEditorContext)
	{
	}

	public void SetTextCoreSettingValue(BMPAlloc alloc, TextCoreSettings settings, bool isEditorContext)
	{
	}

	public void FreeTransform(BMPAlloc alloc)
	{
	}

	public void FreeClipRect(BMPAlloc alloc)
	{
	}

	public void FreeOpacity(BMPAlloc alloc)
	{
	}

	public void FreeColor(BMPAlloc alloc)
	{
	}

	public void FreeTextCoreSettings(BMPAlloc alloc)
	{
	}

	public Color32 TransformAllocToVertexData(BMPAlloc alloc)
	{
		return default(Color32);
	}

	public Color32 ClipRectAllocToVertexData(BMPAlloc alloc)
	{
		return default(Color32);
	}

	public Color32 OpacityAllocToVertexData(BMPAlloc alloc)
	{
		return default(Color32);
	}

	public Color32 ColorAllocToVertexData(BMPAlloc alloc)
	{
		return default(Color32);
	}

	public Color32 TextCoreSettingsToVertexData(BMPAlloc alloc)
	{
		return default(Color32);
	}
}
