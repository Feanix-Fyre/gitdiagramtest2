using System;
using Unity.Profiling;

namespace UnityEngine.UIElements.UIR;

internal class GradientSettingsAtlas : IDisposable
{
	private struct RawTexture
	{
		public Color32[] rgba;

		public int width;

		public int height;

		public void WriteRawInt2Packed(int v0, int v1, int destX, int destY)
		{
		}

		public void WriteRawFloat4Packed(float f0, float f1, float f2, float f3, int destX, int destY)
		{
		}
	}

	private static ProfilerMarker s_MarkerWrite;

	private static ProfilerMarker s_MarkerCommit;

	private readonly int m_Length;

	private readonly int m_ElemWidth;

	private BestFitAllocator m_Allocator;

	private Texture2D m_Atlas;

	private RawTexture m_RawAtlas;

	private static int s_TextureCounter;

	internal int length => 0;

	protected bool disposed { get; private set; }

	public Texture2D atlas => null;

	public bool MustCommit { get; private set; }

	public void Dispose()
	{
	}

	protected virtual void Dispose(bool disposing)
	{
	}

	public GradientSettingsAtlas(int length = 4096)
	{
	}

	public void Reset()
	{
	}

	public Alloc Add(int count)
	{
		return default(Alloc);
	}

	public void Write(Alloc alloc, GradientSettings[] settings, GradientRemap remap)
	{
	}

	public void Commit()
	{
	}

	private void PrepareAtlas()
	{
	}
}
