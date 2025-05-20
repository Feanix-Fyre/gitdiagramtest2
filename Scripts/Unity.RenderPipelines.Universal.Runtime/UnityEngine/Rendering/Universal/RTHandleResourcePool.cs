using System.Collections.Generic;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal;

internal class RTHandleResourcePool
{
	protected Dictionary<int, SortedList<int, (RTHandle resource, int frameIndex)>> m_ResourcePool;

	protected List<int> m_RemoveList;

	protected static int s_CurrentStaleResourceCount;

	protected static int s_StaleResourceLifetime;

	protected static int s_StaleResourceMaxCapacity;

	internal int staleResourceCapacity
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal bool AddResourceToPool(in TextureDesc texDesc, RTHandle resource, int currentFrameIndex)
	{
		return false;
	}

	internal bool TryGetResource(in TextureDesc texDesc, out RTHandle resource, bool usepool = true)
	{
		resource = null;
		return false;
	}

	internal void Cleanup()
	{
	}

	protected static bool ShouldReleaseResource(int lastUsedFrameIndex, int currentFrameIndex)
	{
		return false;
	}

	internal void PurgeUnusedResources(int currentFrameIndex)
	{
	}

	internal void LogDebugInfo()
	{
	}

	internal int GetHashCodeWithNameHash(in TextureDesc texDesc)
	{
		return 0;
	}

	internal static TextureDesc CreateTextureDesc(RenderTextureDescriptor desc, TextureSizeMode textureSizeMode = TextureSizeMode.Explicit, int anisoLevel = 1, float mipMapBias = 0f, FilterMode filterMode = FilterMode.Point, TextureWrapMode wrapMode = TextureWrapMode.Clamp, string name = "")
	{
		return default(TextureDesc);
	}
}
