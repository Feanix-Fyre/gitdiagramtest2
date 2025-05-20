using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements;

internal class DynamicAtlas : AtlasBase
{
	private class TextureInfo : LinkedPoolItem<TextureInfo>
	{
		public DynamicAtlasPage page;

		public int counter;

		public Allocator2D.Alloc2D alloc;

		public RectInt rect;

		public static readonly LinkedPool<TextureInfo> pool;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TextureInfo Create()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void Reset(TextureInfo info)
		{
		}
	}

	private Dictionary<Texture, TextureInfo> m_Database;

	private DynamicAtlasPage m_PointPage;

	private DynamicAtlasPage m_BilinearPage;

	private ColorSpace m_ColorSpace;

	private List<IPanel> m_Panels;

	private int m_MinAtlasSize;

	private int m_MaxAtlasSize;

	private int m_MaxSubTextureSize;

	private DynamicAtlasFilters m_ActiveFilters;

	private DynamicAtlasCustomFilter m_CustomFilter;

	internal bool isInitialized => false;

	public int minAtlasSize
	{
		set
		{
		}
	}

	public int maxAtlasSize
	{
		set
		{
		}
	}

	public static DynamicAtlasFilters defaultFilters => default(DynamicAtlasFilters);

	public DynamicAtlasFilters activeFilters
	{
		set
		{
		}
	}

	public int maxSubTextureSize
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public DynamicAtlasCustomFilter customFilter
	{
		set
		{
		}
	}

	protected override void OnAssignedToPanel(IPanel panel)
	{
	}

	protected override void OnRemovedFromPanel(IPanel panel)
	{
	}

	public override void Reset()
	{
	}

	private void InitPages()
	{
	}

	private void DestroyPages()
	{
	}

	public override bool TryGetAtlas(VisualElement ve, Texture2D src, out TextureId atlas, out RectInt atlasRect)
	{
		atlas = default(TextureId);
		atlasRect = default(RectInt);
		return false;
	}

	public override void ReturnAtlas(VisualElement ve, Texture2D src, TextureId atlas)
	{
	}

	protected override void OnUpdateDynamicTextures(IPanel panel)
	{
	}

	internal static bool IsTextureFormatSupported(TextureFormat format)
	{
		return false;
	}

	public virtual bool IsTextureValid(Texture2D texture, FilterMode atlasFilterMode)
	{
		return false;
	}
}
