namespace UnityEngine.Rendering.Universal;

public static class CameraExtensions
{
	public static UniversalAdditionalCameraData GetUniversalAdditionalCameraData(this Camera camera)
	{
		return null;
	}

	public static VolumeFrameworkUpdateMode GetVolumeFrameworkUpdateMode(this Camera camera)
	{
		return default(VolumeFrameworkUpdateMode);
	}

	public static void SetVolumeFrameworkUpdateMode(this Camera camera, VolumeFrameworkUpdateMode mode)
	{
	}

	public static void UpdateVolumeStack(this Camera camera)
	{
	}

	public static void UpdateVolumeStack(this Camera camera, UniversalAdditionalCameraData cameraData)
	{
	}

	public static void DestroyVolumeStack(this Camera camera)
	{
	}

	public static void DestroyVolumeStack(this Camera camera, UniversalAdditionalCameraData cameraData)
	{
	}

	internal static void GetVolumeLayerMaskAndTrigger(this Camera camera, UniversalAdditionalCameraData cameraData, out LayerMask layerMask, out Transform trigger)
	{
		layerMask = default(LayerMask);
		trigger = null;
	}
}
