using System.Collections.Generic;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RendererUtils;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

internal class RenderGraphResourceRegistry
{
	private delegate void ResourceCallback(RenderGraphContext rgContext, IRenderGraphResource res);

	private class RenderGraphResourcesData
	{
		public DynamicArray<IRenderGraphResource> resourceArray;

		public int sharedResourcesCount;

		public IRenderGraphResourcePool pool;

		public ResourceCallback createResourceCallback;

		public ResourceCallback releaseResourceCallback;

		public void Clear(bool onException, int frameIndex)
		{
		}

		public void Cleanup()
		{
		}

		public void PurgeUnusedGraphicsResources(int frameIndex)
		{
		}

		public int AddNewRenderGraphResource<ResType>(out ResType outRes, bool pooledResource = true) where ResType : IRenderGraphResource, new()
		{
			outRes = null;
			return 0;
		}
	}

	private const int kSharedResourceLifetime = 30;

	private static RenderGraphResourceRegistry m_CurrentRegistry;

	private RenderGraphResourcesData[] m_RenderGraphResources;

	private DynamicArray<RendererListResource> m_RendererListResources;

	private RenderGraphDebugParams m_RenderGraphDebug;

	private RenderGraphLogger m_ResourceLogger;

	private RenderGraphLogger m_FrameInformationLogger;

	private int m_CurrentFrameIndex;

	private int m_ExecutionCount;

	private RTHandle m_CurrentBackbuffer;

	private const int kInitialRendererListCount = 256;

	private List<RendererList> m_ActiveRendererLists;

	internal static RenderGraphResourceRegistry current
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal RTHandle GetTexture(in TextureHandle handle)
	{
		return null;
	}

	internal bool TextureNeedsFallback(in TextureHandle handle)
	{
		return false;
	}

	internal RendererList GetRendererList(in RendererListHandle handle)
	{
		return default(RendererList);
	}

	internal ComputeBuffer GetComputeBuffer(in ComputeBufferHandle handle)
	{
		return null;
	}

	private RenderGraphResourceRegistry()
	{
	}

	internal RenderGraphResourceRegistry(RenderGraphDebugParams renderGraphDebug, RenderGraphLogger frameInformationLogger)
	{
	}

	internal void BeginRenderGraph(int executionCount)
	{
	}

	internal void BeginExecute(int currentFrameIndex)
	{
	}

	internal void EndExecute()
	{
	}

	private void CheckHandleValidity(in ResourceHandle res)
	{
	}

	private void CheckHandleValidity(RenderGraphResourceType type, int index)
	{
	}

	internal void IncrementWriteCount(in ResourceHandle res)
	{
	}

	internal string GetRenderGraphResourceName(in ResourceHandle res)
	{
		return null;
	}

	internal string GetRenderGraphResourceName(RenderGraphResourceType type, int index)
	{
		return null;
	}

	internal bool IsRenderGraphResourceImported(in ResourceHandle res)
	{
		return false;
	}

	internal bool IsRenderGraphResourceShared(RenderGraphResourceType type, int index)
	{
		return false;
	}

	internal bool IsGraphicsResourceCreated(in ResourceHandle res)
	{
		return false;
	}

	internal bool IsRendererListCreated(in RendererListHandle res)
	{
		return false;
	}

	internal bool IsRenderGraphResourceImported(RenderGraphResourceType type, int index)
	{
		return false;
	}

	internal int GetRenderGraphResourceTransientIndex(in ResourceHandle res)
	{
		return 0;
	}

	internal TextureHandle ImportTexture(RTHandle rt)
	{
		return default(TextureHandle);
	}

	internal TextureHandle CreateSharedTexture(in TextureDesc desc, bool explicitRelease)
	{
		return default(TextureHandle);
	}

	internal void RefreshSharedTextureDesc(TextureHandle texture, in TextureDesc desc)
	{
	}

	internal void ReleaseSharedTexture(TextureHandle texture)
	{
	}

	internal TextureHandle ImportBackbuffer(RenderTargetIdentifier rt)
	{
		return default(TextureHandle);
	}

	internal TextureHandle CreateTexture(in TextureDesc desc, int transientPassIndex = -1)
	{
		return default(TextureHandle);
	}

	internal int GetResourceCount(RenderGraphResourceType type)
	{
		return 0;
	}

	internal int GetTextureResourceCount()
	{
		return 0;
	}

	internal TextureResource GetTextureResource(in ResourceHandle handle)
	{
		return null;
	}

	internal TextureDesc GetTextureResourceDesc(in ResourceHandle handle)
	{
		return default(TextureDesc);
	}

	internal RendererListHandle CreateRendererList(in RendererListDesc desc)
	{
		return default(RendererListHandle);
	}

	internal ComputeBufferHandle ImportComputeBuffer(ComputeBuffer computeBuffer)
	{
		return default(ComputeBufferHandle);
	}

	internal ComputeBufferHandle CreateComputeBuffer(in ComputeBufferDesc desc, int transientPassIndex = -1)
	{
		return default(ComputeBufferHandle);
	}

	internal ComputeBufferDesc GetComputeBufferResourceDesc(in ResourceHandle handle)
	{
		return default(ComputeBufferDesc);
	}

	internal int GetComputeBufferResourceCount()
	{
		return 0;
	}

	private ComputeBufferResource GetComputeBufferResource(in ResourceHandle handle)
	{
		return null;
	}

	internal void UpdateSharedResourceLastFrameIndex(int type, int index)
	{
	}

	private void ManageSharedRenderGraphResources()
	{
	}

	internal void CreatePooledResource(RenderGraphContext rgContext, int type, int index)
	{
	}

	internal void CreatePooledResource(RenderGraphContext rgContext, ResourceHandle handle)
	{
	}

	private void CreateTextureCallback(RenderGraphContext rgContext, IRenderGraphResource res)
	{
	}

	internal void ReleasePooledResource(RenderGraphContext rgContext, int type, int index)
	{
	}

	internal void ReleasePooledResource(RenderGraphContext rgContext, ResourceHandle handle)
	{
	}

	private void ReleaseTextureCallback(RenderGraphContext rgContext, IRenderGraphResource res)
	{
	}

	private void ValidateTextureDesc(in TextureDesc desc)
	{
	}

	private void ValidateRendererListDesc(in RendererListDesc desc)
	{
	}

	private void ValidateComputeBufferDesc(in ComputeBufferDesc desc)
	{
	}

	internal void CreateRendererLists(List<RendererListHandle> rendererLists, ScriptableRenderContext context, bool manualDispatch = false)
	{
	}

	internal void Clear(bool onException)
	{
	}

	internal void PurgeUnusedGraphicsResources()
	{
	}

	internal void Cleanup()
	{
	}

	internal void FlushLogs()
	{
	}

	private void LogResources()
	{
	}
}
