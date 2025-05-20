using System.Collections.Generic;

namespace UnityEngine.Rendering.Universal;

internal class DecalPreviewPass : ScriptableRenderPass
{
	private FilteringSettings m_FilteringSettings;

	private List<ShaderTagId> m_ShaderTagIdList;

	private ProfilingSampler m_ProfilingSampler;

	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}
}
