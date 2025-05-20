using UnityEngine;

namespace VolumetricFogAndMist2;

public static class Tools
{
	public static Color ColorBlack;

	private static Mesh _fullScreenMesh;

	public static Mesh fullscreenMesh => null;

	public static void CheckCamera(ref Camera cam)
	{
	}

	public static VolumetricFogManager CheckMainManager()
	{
		return null;
	}

	public static void CheckManager<T>(ref T manager) where T : Component
	{
	}
}
