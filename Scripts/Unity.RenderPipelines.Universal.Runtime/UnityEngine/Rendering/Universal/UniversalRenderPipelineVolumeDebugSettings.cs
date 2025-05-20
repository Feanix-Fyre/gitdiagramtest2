using System;

namespace UnityEngine.Rendering.Universal;

public class UniversalRenderPipelineVolumeDebugSettings : VolumeDebugSettings<UniversalAdditionalCameraData>
{
	public override Type targetRenderPipeline => null;

	public override VolumeStack selectedCameraVolumeStack => null;

	public override LayerMask selectedCameraLayerMask => default(LayerMask);

	public override Vector3 selectedCameraPosition => default(Vector3);
}
