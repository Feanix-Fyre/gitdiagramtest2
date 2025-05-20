using System.Collections.Generic;

namespace UnityEngine.Rendering.Universal;

internal class DBufferRenderPass : ScriptableRenderPass
{
	private static string[] s_DBufferNames;

	private static string s_DBufferDepthName;

	private DecalDrawDBufferSystem m_DrawSystem;

	private DBufferSettings m_Settings;

	private Material m_DBufferClear;

	private FilteringSettings m_FilteringSettings;

	private List<ShaderTagId> m_ShaderTagIdList;

	private ProfilingSampler m_ProfilingSampler;

	private ProfilingSampler m_DBufferClearSampler;

	private bool m_DecalLayers;

	private RTHandle m_DBufferDepth;

	internal RTHandle[] dBufferColorHandles { get; private set; }

	internal RTHandle depthHandle { get; private set; }

	internal RTHandle dBufferDepth => null;

	public DBufferRenderPass(Material dBufferClear, DBufferSettings settings, DecalDrawDBufferSystem drawSystem, bool decalLayers)
	{
	}

	public void Dispose()
	{
	}

	public void Setup(in CameraData cameraData)
	{
	}

	public void Setup(in CameraData cameraData, RTHandle depthTextureHandle)
	{
	}

	public override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
	{
	}

	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	public override void OnCameraCleanup(CommandBuffer cmd)
	{
	}
}
