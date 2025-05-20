using System.Collections.Generic;
using UnityEngine.Rendering.Universal.Internal;

namespace UnityEngine.Rendering.Universal;

internal class DecalGBufferRenderPass : ScriptableRenderPass
{
	private FilteringSettings m_FilteringSettings;

	private ProfilingSampler m_ProfilingSampler;

	private List<ShaderTagId> m_ShaderTagIdList;

	private DecalDrawGBufferSystem m_DrawSystem;

	private DecalScreenSpaceSettings m_Settings;

	private DeferredLights m_DeferredLights;

	private RTHandle[] m_GbufferAttachments;

	private bool m_DecalLayers;

	public DecalGBufferRenderPass(DecalScreenSpaceSettings settings, DecalDrawGBufferSystem drawSystem, bool decalLayers)
	{
	}

	internal void Setup(DeferredLights deferredLights)
	{
	}

	public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
	{
	}

	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}

	public override void OnCameraCleanup(CommandBuffer cmd)
	{
	}
}
