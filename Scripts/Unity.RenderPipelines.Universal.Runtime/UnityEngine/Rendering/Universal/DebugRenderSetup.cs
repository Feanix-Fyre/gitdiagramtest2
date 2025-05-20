using System;

namespace UnityEngine.Rendering.Universal;

internal class DebugRenderSetup : IDisposable
{
	private readonly DebugHandler m_DebugHandler;

	private readonly ScriptableRenderContext m_Context;

	private readonly CommandBuffer m_CommandBuffer;

	private readonly int m_Index;

	private readonly FilteringSettings m_FilteringSettings;

	private DebugDisplaySettingsMaterial MaterialSettings => null;

	private DebugDisplaySettingsRendering RenderingSettings => null;

	private DebugDisplaySettingsLighting LightingSettings => null;

	private void Begin()
	{
	}

	private void End()
	{
	}

	internal DebugRenderSetup(DebugHandler debugHandler, ScriptableRenderContext context, CommandBuffer commandBuffer, int index, FilteringSettings filteringSettings)
	{
	}

	internal DrawingSettings CreateDrawingSettings(DrawingSettings drawingSettings)
	{
		return default(DrawingSettings);
	}

	internal RenderStateBlock GetRenderStateBlock(RenderStateBlock renderStateBlock)
	{
		return default(RenderStateBlock);
	}

	public void Dispose()
	{
	}
}
