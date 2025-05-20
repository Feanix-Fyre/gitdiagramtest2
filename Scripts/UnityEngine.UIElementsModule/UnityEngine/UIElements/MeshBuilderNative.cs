using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[NativeHeader("ModuleOverrides/com.unity.ui/Core/Native/Renderer/UIRMeshBuilder.bindings.h")]
internal static class MeshBuilderNative
{
	public struct NativeColorPage
	{
		public int isValid;

		public Color32 pageAndID;
	}

	public struct NativeBorderParams
	{
		public Rect rect;

		public Color leftColor;

		public Color topColor;

		public Color rightColor;

		public Color bottomColor;

		public float leftWidth;

		public float topWidth;

		public float rightWidth;

		public float bottomWidth;

		public Vector2 topLeftRadius;

		public Vector2 topRightRadius;

		public Vector2 bottomRightRadius;

		public Vector2 bottomLeftRadius;

		internal NativeColorPage leftColorPage;

		internal NativeColorPage topColorPage;

		internal NativeColorPage rightColorPage;

		internal NativeColorPage bottomColorPage;
	}

	public struct NativeRectParams
	{
		public Rect rect;

		public Rect subRect;

		public Rect uv;

		public Rect uvRegion;

		public Color color;

		public ScaleMode scaleMode;

		public Vector2 topLeftRadius;

		public Vector2 topRightRadius;

		public Vector2 bottomRightRadius;

		public Vector2 bottomLeftRadius;

		public Vector2 contentSize;

		public Vector2 textureSize;

		public float texturePixelsPerPoint;

		public int leftSlice;

		public int topSlice;

		public int rightSlice;

		public int bottomSlice;

		public float sliceScale;

		public Vector4 rectInset;

		public NativeColorPage colorPage;
	}

	public static MeshWriteDataInterface MakeBorder(NativeBorderParams borderParams, float posZ)
	{
		return default(MeshWriteDataInterface);
	}

	public static MeshWriteDataInterface MakeSolidRect(NativeRectParams rectParams, float posZ)
	{
		return default(MeshWriteDataInterface);
	}

	public static MeshWriteDataInterface MakeTexturedRect(NativeRectParams rectParams, float posZ)
	{
		return default(MeshWriteDataInterface);
	}

	public static MeshWriteDataInterface MakeVectorGraphicsStretchBackground(Vertex[] svgVertices, ushort[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Rect sourceUV, ScaleMode scaleMode, Color tint, NativeColorPage colorPage, int settingIndexOffset, ref int finalVertexCount, ref int finalIndexCount)
	{
		return default(MeshWriteDataInterface);
	}

	public static MeshWriteDataInterface MakeVectorGraphics9SliceBackground(Vertex[] svgVertices, ushort[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Vector4 sliceLTRB, Color tint, NativeColorPage colorPage, int settingIndexOffset)
	{
		return default(MeshWriteDataInterface);
	}

	private static void MakeBorder_Injected(ref NativeBorderParams borderParams, float posZ, out MeshWriteDataInterface ret)
	{
		ret = default(MeshWriteDataInterface);
	}

	private static void MakeSolidRect_Injected(ref NativeRectParams rectParams, float posZ, out MeshWriteDataInterface ret)
	{
		ret = default(MeshWriteDataInterface);
	}

	private static void MakeTexturedRect_Injected(ref NativeRectParams rectParams, float posZ, out MeshWriteDataInterface ret)
	{
		ret = default(MeshWriteDataInterface);
	}

	private static void MakeVectorGraphicsStretchBackground_Injected(Vertex[] svgVertices, ushort[] svgIndices, float svgWidth, float svgHeight, ref Rect targetRect, ref Rect sourceUV, ScaleMode scaleMode, ref Color tint, ref NativeColorPage colorPage, int settingIndexOffset, ref int finalVertexCount, ref int finalIndexCount, out MeshWriteDataInterface ret)
	{
		ret = default(MeshWriteDataInterface);
	}

	private static void MakeVectorGraphics9SliceBackground_Injected(Vertex[] svgVertices, ushort[] svgIndices, float svgWidth, float svgHeight, ref Rect targetRect, ref Vector4 sliceLTRB, ref Color tint, ref NativeColorPage colorPage, int settingIndexOffset, out MeshWriteDataInterface ret)
	{
		ret = default(MeshWriteDataInterface);
	}
}
