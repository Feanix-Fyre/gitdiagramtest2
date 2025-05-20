using System.Collections.Generic;
using UnityEngine;

namespace VolumetricFogAndMist2;

[DefaultExecutionOrder(100)]
[ExecuteInEditMode]
public class PointLightManager : MonoBehaviour, IVolumetricFogManager
{
	public static bool usingPointLights;

	public const int MAX_POINT_LIGHTS = 16;

	[Tooltip("Point lights are sorted by distance to tracking center object")]
	[Header("Point Light Search Settings")]
	public Transform trackingCenter;

	[Tooltip("Point lights are sorted by camera distance every certain time interval to ensure the nearest 16 point lights are used.")]
	public float distanceSortTimeInterval;

	[Tooltip("Ignore point lights behind camera")]
	public bool excludeLightsBehind;

	[Header("Common Settings")]
	[Tooltip("Global inscattering multiplier for point lights")]
	public float inscattering;

	[Tooltip("Global intensity multiplier for point lights")]
	public float intensity;

	[Tooltip("Reduces light intensity near point lights")]
	public float insideAtten;

	private static readonly List<FogPointLight> pointLights;

	private static bool requireRefresh;

	private int lastPointLightsCount;

	private Vector4[] pointLightColorBuffer;

	private Vector4[] pointLightPositionBuffer;

	private float distanceSortLastTime;

	public string managerName => null;

	private void OnEnable()
	{
	}

	private void LateUpdate()
	{
	}

	private void SubmitPointLightData()
	{
	}

	public static void RegisterPointLight(FogPointLight fogPointLight)
	{
	}

	public static void UnregisterPointLight(FogPointLight fogPointLight)
	{
	}

	public void TrackPointLights(bool forceImmediateUpdate = false)
	{
	}

	private int pointLightsDistanceComparer(FogPointLight l1, FogPointLight l2)
	{
		return 0;
	}

	public void Refresh()
	{
	}
}
