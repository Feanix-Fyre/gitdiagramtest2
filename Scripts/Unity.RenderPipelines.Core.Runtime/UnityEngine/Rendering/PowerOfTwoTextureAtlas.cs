using System.Collections.Generic;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering;

public class PowerOfTwoTextureAtlas : Texture2DAtlas
{
	private enum BlitType
	{
		Padding = 0,
		PaddingMultiply = 1,
		OctahedralPadding = 2,
		OctahedralPaddingMultiply = 3
	}

	private readonly int m_MipPadding;

	private const float k_MipmapFactorApprox = 1.33f;

	private Dictionary<int, Vector2Int> m_RequestedTextures;

	public int mipPadding => 0;

	public PowerOfTwoTextureAtlas(int size, int mipPadding, GraphicsFormat format, FilterMode filterMode = FilterMode.Point, string name = "", bool useMipMap = true)
		: base(0, 0, default(GraphicsFormat), default(FilterMode), powerOfTwoPadding: false, null, useMipMap: false)
	{
	}

	private int GetTexturePadding()
	{
		return 0;
	}

	public Vector4 GetPayloadScaleOffset(Texture texture, in Vector4 scaleOffset)
	{
		return default(Vector4);
	}

	public static Vector4 GetPayloadScaleOffset(in Vector2 textureSize, in Vector2 paddingSize, in Vector4 scaleOffset)
	{
		return default(Vector4);
	}

	private void Blit2DTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips, BlitType blitType)
	{
	}

	public override void BlitTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true, int overrideInstanceID = -1)
	{
	}

	public void BlitTextureMultiply(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true, int overrideInstanceID = -1)
	{
	}

	public override void BlitOctahedralTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true, int overrideInstanceID = -1)
	{
	}

	public void BlitOctahedralTextureMultiply(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true, int overrideInstanceID = -1)
	{
	}

	private void TextureSizeToPowerOfTwo(Texture texture, ref int width, ref int height)
	{
	}

	private Vector2 GetPowerOfTwoTextureSize(Texture texture)
	{
		return default(Vector2);
	}

	public override bool AllocateTexture(CommandBuffer cmd, ref Vector4 scaleOffset, Texture texture, int width, int height, int overrideInstanceID = -1)
	{
		return false;
	}

	public void ResetRequestedTexture()
	{
	}

	public bool ReserveSpace(Texture texture)
	{
		return false;
	}

	public bool ReserveSpace(Texture texture, int width, int height)
	{
		return false;
	}

	public bool ReserveSpace(Texture textureA, Texture textureB, int width, int height)
	{
		return false;
	}

	private bool ReserveSpace(int id, int width, int height)
	{
		return false;
	}

	public bool RelayoutEntries()
	{
		return false;
	}

	public static long GetApproxCacheSizeInByte(int nbElement, int resolution, bool hasMipmap, GraphicsFormat format)
	{
		return 0L;
	}

	public static int GetMaxCacheSizeForWeightInByte(int weight, bool hasMipmap, GraphicsFormat format)
	{
		return 0;
	}
}
