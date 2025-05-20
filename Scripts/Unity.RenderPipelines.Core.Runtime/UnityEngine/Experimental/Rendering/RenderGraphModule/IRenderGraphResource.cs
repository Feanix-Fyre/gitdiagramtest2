namespace UnityEngine.Experimental.Rendering.RenderGraphModule;

internal class IRenderGraphResource
{
	public bool imported;

	public bool shared;

	public bool sharedExplicitRelease;

	public bool requestFallBack;

	public uint writeCount;

	public int cachedHash;

	public int transientPassIndex;

	public int sharedResourceLastFrameUsed;

	protected IRenderGraphResourcePool m_Pool;

	public virtual void Reset(IRenderGraphResourcePool pool)
	{
	}

	public virtual string GetName()
	{
		return null;
	}

	public virtual bool IsCreated()
	{
		return false;
	}

	public virtual void IncrementWriteCount()
	{
	}

	public virtual bool NeedsFallBack()
	{
		return false;
	}

	public virtual void CreatePooledGraphicsResource()
	{
	}

	public virtual void CreateGraphicsResource(string name = "")
	{
	}

	public virtual void ReleasePooledGraphicsResource(int frameIndex)
	{
	}

	public virtual void ReleaseGraphicsResource()
	{
	}

	public virtual void LogCreation(RenderGraphLogger logger)
	{
	}

	public virtual void LogRelease(RenderGraphLogger logger)
	{
	}

	public virtual int GetSortIndex()
	{
		return 0;
	}
}
