using System.Collections.Generic;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering;

internal class Texture2DAtlasDynamic
{
	private RTHandle m_AtlasTexture;

	private bool isAtlasTextureOwner;

	private int m_Width;

	private int m_Height;

	private GraphicsFormat m_Format;

	private AtlasAllocatorDynamic m_AtlasAllocator;

	private Dictionary<int, Vector4> m_AllocationCache;

	public RTHandle AtlasTexture => null;

	public Texture2DAtlasDynamic(int width, int height, int capacity, GraphicsFormat format)
	{
	}

	public Texture2DAtlasDynamic(int width, int height, int capacity, RTHandle atlasTexture)
	{
	}

	public void Release()
	{
	}

	public void ResetAllocator()
	{
	}

	public bool AddTexture(CommandBuffer cmd, out Vector4 scaleOffset, Texture texture)
	{
		scaleOffset = default(Vector4);
		return false;
	}

	public bool IsCached(out Vector4 scaleOffset, int key)
	{
		scaleOffset = default(Vector4);
		return false;
	}

	public bool EnsureTextureSlot(out bool isUploadNeeded, out Vector4 scaleOffset, int key, int width, int height)
	{
		isUploadNeeded = default(bool);
		scaleOffset = default(Vector4);
		return false;
	}

	public void ReleaseTextureSlot(int key)
	{
	}
}
