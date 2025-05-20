using System;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements;

internal class DynamicAtlasPage : IDisposable
{
	private readonly int m_1Padding;

	private readonly int m_2Padding;

	private Allocator2D m_Allocator;

	private TextureBlitter m_Blitter;

	private Vector2Int m_CurrentSize;

	private static int s_TextureCounter;

	public TextureId textureId { get; private set; }

	public RenderTexture atlas { get; private set; }

	public RenderTextureFormat format { get; }

	public FilterMode filterMode { get; }

	protected bool disposed { get; private set; }

	public DynamicAtlasPage(RenderTextureFormat format, FilterMode filterMode, Vector2Int minSize, Vector2Int maxSize)
	{
	}

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	public bool TryAdd(Texture2D image, out Allocator2D.Alloc2D alloc, out RectInt rect)
	{
		alloc = default(Allocator2D.Alloc2D);
		rect = default(RectInt);
		return false;
	}

	public void Update(Texture2D image, RectInt rect)
	{
	}

	public void Remove(Allocator2D.Alloc2D alloc)
	{
	}

	public void Commit()
	{
	}

	private void UpdateAtlasTexture()
	{
	}

	private RenderTexture CreateAtlasTexture()
	{
		return null;
	}
}
