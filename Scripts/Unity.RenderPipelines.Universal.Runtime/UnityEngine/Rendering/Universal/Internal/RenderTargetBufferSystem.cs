namespace UnityEngine.Rendering.Universal.Internal;

internal sealed class RenderTargetBufferSystem
{
	private struct SwapBuffer
	{
		public RTHandle rtMSAA;

		public RTHandle rtResolve;

		public string name;

		public int msaa;
	}

	private SwapBuffer m_A;

	private SwapBuffer m_B;

	private static bool m_AisBackBuffer;

	private static RenderTextureDescriptor m_Desc;

	private FilterMode m_FilterMode;

	private bool m_AllowMSAA;

	private ref SwapBuffer backBuffer
	{
		get
		{
			throw null;
		}
	}

	private ref SwapBuffer frontBuffer
	{
		get
		{
			throw null;
		}
	}

	public RenderTargetBufferSystem(string name)
	{
	}

	public void Dispose()
	{
	}

	public RTHandle PeekBackBuffer()
	{
		return null;
	}

	public RTHandle GetBackBuffer(CommandBuffer cmd)
	{
		return null;
	}

	public RTHandle GetFrontBuffer(CommandBuffer cmd)
	{
		return null;
	}

	public void Swap()
	{
	}

	private void ReAllocate(CommandBuffer cmd)
	{
	}

	public void Clear()
	{
	}

	public void SetCameraSettings(RenderTextureDescriptor desc, FilterMode filterMode)
	{
	}

	public RTHandle GetBufferA()
	{
		return null;
	}

	public void EnableMSAA(bool enable)
	{
	}
}
