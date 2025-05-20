namespace UnityEngine.UIElements;

internal static class MeshGenerationContextUtils
{
	public struct BorderParams
	{
		public Rect rect;

		public Color playmodeTintColor;

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

		public Material material;

		internal ColorPage leftColorPage;

		internal ColorPage topColorPage;

		internal ColorPage rightColorPage;

		internal ColorPage bottomColorPage;

		internal MeshBuilderNative.NativeBorderParams ToNativeParams()
		{
			return default(MeshBuilderNative.NativeBorderParams);
		}
	}

	public struct RectangleParams
	{
		public Rect rect;

		public Rect uv;

		public Color color;

		public Rect subRect;

		public BackgroundPosition backgroundPositionX;

		public BackgroundPosition backgroundPositionY;

		public BackgroundRepeat backgroundRepeat;

		public BackgroundSize backgroundSize;

		public Texture texture;

		public Sprite sprite;

		public VectorImage vectorImage;

		public Material material;

		public ScaleMode scaleMode;

		public Color playmodeTintColor;

		public Vector2 topLeftRadius;

		public Vector2 topRightRadius;

		public Vector2 bottomRightRadius;

		public Vector2 bottomLeftRadius;

		public Vector2 contentSize;

		public Vector2 textureSize;

		public int leftSlice;

		public int topSlice;

		public int rightSlice;

		public int bottomSlice;

		public float sliceScale;

		internal Rect spriteGeomRect;

		public Vector4 rectInset;

		internal ColorPage colorPage;

		internal MeshGenerationContext.MeshFlags meshFlags;

		private static void AdjustUVsForScaleMode(Rect rect, Rect uv, Texture texture, ScaleMode scaleMode, out Rect rectOut, out Rect uvOut)
		{
			rectOut = default(Rect);
			uvOut = default(Rect);
		}

		private static void AdjustSpriteUVsForScaleMode(Rect containerRect, Rect srcRect, Rect spriteGeomRect, Sprite sprite, ScaleMode scaleMode, out Rect rectOut, out Rect uvOut)
		{
			rectOut = default(Rect);
			uvOut = default(Rect);
		}

		internal static Rect RectIntersection(Rect a, Rect b)
		{
			return default(Rect);
		}

		private static Rect ComputeGeomRect(Sprite sprite)
		{
			return default(Rect);
		}

		private static Rect ComputeUVRect(Sprite sprite)
		{
			return default(Rect);
		}

		private static Rect ApplyPackingRotation(Rect uv, SpritePackingRotation rotation)
		{
			return default(Rect);
		}

		public static RectangleParams MakeTextured(Rect rect, Rect uv, Texture texture, ScaleMode scaleMode, ContextType panelContext)
		{
			return default(RectangleParams);
		}

		public static RectangleParams MakeSprite(Rect containerRect, Rect subRect, Sprite sprite, ScaleMode scaleMode, ContextType panelContext, bool hasRadius, ref Vector4 slices, bool useForRepeat = false)
		{
			return default(RectangleParams);
		}

		public static RectangleParams MakeVectorTextured(Rect rect, Rect uv, VectorImage vectorImage, ScaleMode scaleMode, ContextType panelContext)
		{
			return default(RectangleParams);
		}

		internal bool HasRadius(float epsilon)
		{
			return false;
		}

		internal bool HasSlices(float epsilon)
		{
			return false;
		}

		internal MeshBuilderNative.NativeRectParams ToNativeParams(Rect uvRegion)
		{
			return default(MeshBuilderNative.NativeRectParams);
		}
	}

	public static void Rectangle(this MeshGenerationContext mgc, RectangleParams rectParams)
	{
	}

	public static void Text(this MeshGenerationContext mgc, TextElement te)
	{
	}

	private static Vector2 ConvertBorderRadiusPercentToPoints(Vector2 borderRectSize, Length length)
	{
		return default(Vector2);
	}

	public static void GetVisualElementRadii(VisualElement ve, out Vector2 topLeft, out Vector2 bottomLeft, out Vector2 topRight, out Vector2 bottomRight)
	{
		topLeft = default(Vector2);
		bottomLeft = default(Vector2);
		topRight = default(Vector2);
		bottomRight = default(Vector2);
	}

	public static void AdjustBackgroundSizeForBorders(VisualElement visualElement, ref RectangleParams rectParams)
	{
	}
}
