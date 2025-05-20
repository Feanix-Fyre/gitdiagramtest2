using System.Collections.Generic;

namespace UnityEngine.Rendering.Universal;

internal class DecalForwardEmissivePass : ScriptableRenderPass
{
	private FilteringSettings m_FilteringSettings;

	private ProfilingSampler m_ProfilingSampler;

	private List<ShaderTagId> m_ShaderTagIdList;

	private DecalDrawFowardEmissiveSystem m_DrawSystem;

	public DecalForwardEmissivePass(DecalDrawFowardEmissiveSystem drawSystem)
	{
	}

	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
	{
	}
}
