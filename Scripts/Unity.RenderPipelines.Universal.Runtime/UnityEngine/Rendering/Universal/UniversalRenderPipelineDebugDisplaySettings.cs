namespace UnityEngine.Rendering.Universal;

public class UniversalRenderPipelineDebugDisplaySettings : DebugDisplaySettings<UniversalRenderPipelineDebugDisplaySettings>
{
	private DebugDisplaySettingsCommon commonSettings { get; set; }

	public DebugDisplaySettingsMaterial materialSettings { get; private set; }

	public DebugDisplaySettingsRendering renderingSettings { get; private set; }

	public DebugDisplaySettingsLighting lightingSettings { get; private set; }

	public DebugDisplaySettingsVolume volumeSettings { get; private set; }

	internal DebugDisplayStats displayStats { get; private set; }

	public override bool IsPostProcessingAllowed => false;

	public override void Reset()
	{
	}

	internal void UpdateFrameTiming()
	{
	}
}
