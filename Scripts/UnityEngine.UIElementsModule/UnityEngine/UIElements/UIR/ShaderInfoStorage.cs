using System;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR;

internal class ShaderInfoStorage<T> : BaseShaderInfoStorage where T : struct
{
	private readonly int m_InitialSize;

	private readonly int m_MaxSize;

	private readonly TextureFormat m_Format;

	private readonly Func<Color, T> m_Convert;

	private UIRAtlasAllocator m_Allocator;

	private Texture2D m_Texture;

	private NativeArray<T> m_Texels;

	public override Texture2D texture => null;

	public ShaderInfoStorage(TextureFormat format, Func<Color, T> convert, int initialSize = 64, int maxSize = 4096)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}

	public override bool AllocateRect(int width, int height, out RectInt uvs)
	{
		uvs = default(RectInt);
		return false;
	}

	public override void SetTexel(int x, int y, Color color)
	{
	}

	public override void UpdateTexture()
	{
	}

	private void CreateOrExpandTexture()
	{
	}

	private static void CpuBlit(NativeArray<T> src, int srcWidth, int srcHeight, NativeArray<T> dst, int dstWidth, int dstHeight)
	{
	}
}
