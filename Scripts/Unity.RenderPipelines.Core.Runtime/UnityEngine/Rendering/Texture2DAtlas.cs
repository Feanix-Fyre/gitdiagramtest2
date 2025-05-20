using System.Collections.Generic;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering;

public class Texture2DAtlas
{
	private enum BlitType
	{
		Default = 0,
		CubeTo2DOctahedral = 1,
		SingleChannel = 2,
		CubeTo2DOctahedralSingleChannel = 3
	}

	private protected const int kGPUTexInvalid = 0;

	private protected const int kGPUTexValidMip0 = 1;

	private protected const int kGPUTexValidMipAll = 2;

	private protected RTHandle m_AtlasTexture;

	private protected int m_Width;

	private protected int m_Height;

	private protected GraphicsFormat m_Format;

	private protected bool m_UseMipMaps;

	private bool m_IsAtlasTextureOwner;

	private AtlasAllocator m_AtlasAllocator;

	private Dictionary<int, (Vector4 scaleOffset, Vector2Int size)> m_AllocationCache;

	private Dictionary<int, int> m_IsGPUTextureUpToDate;

	private Dictionary<int, int> m_TextureHashes;

	private static readonly Vector4 fullScaleOffset;

	private static readonly int s_MaxMipLevelPadding;

	public static int maxMipLevelPadding => 0;

	public RTHandle AtlasTexture => null;

	public Texture2DAtlas(int width, int height, GraphicsFormat format, FilterMode filterMode = FilterMode.Point, bool powerOfTwoPadding = false, string name = "", bool useMipMap = true)
	{
	}

	public void Release()
	{
	}

	public void ResetAllocator()
	{
	}

	public void ClearTarget(CommandBuffer cmd)
	{
	}

	private protected int GetTextureMipmapCount(int width, int height)
	{
		return 0;
	}

	private protected bool Is2D(Texture texture)
	{
		return false;
	}

	private protected bool IsSingleChannelBlit(Texture source, Texture destination)
	{
		return false;
	}

	private void Blit2DTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips, BlitType blitType)
	{
	}

	private protected void MarkGPUTextureValid(int instanceId, bool mipAreValid = false)
	{
	}

	private protected void MarkGPUTextureInvalid(int instanceId)
	{
	}

	public virtual void BlitTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true, int overrideInstanceID = -1)
	{
	}

	public virtual void BlitOctahedralTexture(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, Vector4 sourceScaleOffset, bool blitMips = true, int overrideInstanceID = -1)
	{
	}

	public virtual void BlitCubeTexture2D(CommandBuffer cmd, Vector4 scaleOffset, Texture texture, bool blitMips = true, int overrideInstanceID = -1)
	{
	}

	public virtual bool AllocateTexture(CommandBuffer cmd, ref Vector4 scaleOffset, Texture texture, int width, int height, int overrideInstanceID = -1)
	{
		return false;
	}

	public bool AllocateTextureWithoutBlit(Texture texture, int width, int height, ref Vector4 scaleOffset)
	{
		return false;
	}

	public virtual bool AllocateTextureWithoutBlit(int instanceId, int width, int height, ref Vector4 scaleOffset)
	{
		return false;
	}

	private protected int GetTextureHash(Texture textureA, Texture textureB)
	{
		return 0;
	}

	public int GetTextureID(Texture texture)
	{
		return 0;
	}

	public int GetTextureID(Texture textureA, Texture textureB)
	{
		return 0;
	}

	public bool IsCached(out Vector4 scaleOffset, Texture textureA, Texture textureB)
	{
		scaleOffset = default(Vector4);
		return false;
	}

	public bool IsCached(out Vector4 scaleOffset, Texture texture)
	{
		scaleOffset = default(Vector4);
		return false;
	}

	public bool IsCached(out Vector4 scaleOffset, int id)
	{
		scaleOffset = default(Vector4);
		return false;
	}

	internal Vector2Int GetCachedTextureSize(int id)
	{
		return default(Vector2Int);
	}

	public virtual bool NeedsUpdate(Texture texture, bool needMips = false)
	{
		return false;
	}

	public virtual bool NeedsUpdate(Texture textureA, Texture textureB, bool needMips = false)
	{
		return false;
	}

	public virtual bool AddTexture(CommandBuffer cmd, ref Vector4 scaleOffset, Texture texture)
	{
		return false;
	}

	public virtual bool UpdateTexture(CommandBuffer cmd, Texture oldTexture, Texture newTexture, ref Vector4 scaleOffset, Vector4 sourceScaleOffset, bool updateIfNeeded = true, bool blitMips = true)
	{
		return false;
	}

	public virtual bool UpdateTexture(CommandBuffer cmd, Texture texture, ref Vector4 scaleOffset, bool updateIfNeeded = true, bool blitMips = true)
	{
		return false;
	}

	internal bool EnsureTextureSlot(out bool isUploadNeeded, ref Vector4 scaleBias, int key, int width, int height)
	{
		isUploadNeeded = default(bool);
		return false;
	}
}
