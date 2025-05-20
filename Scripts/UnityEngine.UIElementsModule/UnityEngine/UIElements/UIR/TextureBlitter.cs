using System;
using System.Collections.Generic;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR;

internal class TextureBlitter : IDisposable
{
	private struct BlitInfo
	{
		public Texture src;

		public RectInt srcRect;

		public Vector2Int dstPos;

		public int border;

		public Color tint;
	}

	private static readonly int[] k_TextureIds;

	private static ProfilerMarker s_CommitSampler;

	private BlitInfo[] m_SingleBlit;

	private Material m_BlitMaterial;

	private MaterialPropertyBlock m_Properties;

	private RectInt m_Viewport;

	private RenderTexture m_PrevRT;

	private List<BlitInfo> m_PendingBlits;

	protected bool disposed { get; private set; }

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	static TextureBlitter()
	{
	}

	public TextureBlitter(int capacity = 512)
	{
	}

	public void QueueBlit(Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, Color tint)
	{
	}

	public void BlitOneNow(RenderTexture dst, Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, Color tint)
	{
	}

	public void Commit(RenderTexture dst)
	{
	}

	private void BeginBlit(RenderTexture dst)
	{
	}

	private void DoBlit(IList<BlitInfo> blitInfos, int startIndex)
	{
	}

	private void EndBlit()
	{
	}
}
