using Boxophobic.StyledGUI;
using UnityEngine;
using UnityEngine.Serialization;

namespace AtmosphericHeightFog;

[HelpURL("https://docs.google.com/document/d/1pIzIHIZ-cSh2ykODSZCbAPtScJ4Jpuu7lS3rNEHCLbc/edit#heading=h.hd5jt8lucuqq")]
[ExecuteInEditMode]
public class HeightFogOverride : StyledMonoBehaviour
{
	[StyledBanner(0.55f, 0.75f, 1f, "Height Fog Override", null, "https://docs.google.com/document/d/1pIzIHIZ-cSh2ykODSZCbAPtScJ4Jpuu7lS3rNEHCLbc/edit#heading=h.hd5jt8lucuqq")]
	public bool styledBanner;

	[StyledMessage("Info", "The Height Fog Global object is missing from your scene! Please add it before using the Height Fog Override component!", 5f, 0f)]
	public bool messageNoHeightFogGlobal;

	[StyledCategory("Volume Settings", 5f, 10f)]
	public bool categoryVolume;

	public float volumeDistanceFade;

	public Color volumeGizmoColor;

	[StyledCategory("Scene Settings")]
	public bool categoryScene;

	public Camera mainCamera;

	public Light mainDirectional;

	[StyledCategory("Preset Settings")]
	public bool categoryMode;

	public FogMode fogMode;

	[StyledMessage("Info", "The Preset feature requires a material using the BOXOPHOBIC > Atmospherics > Fog Preset shader.", 10f, 0f)]
	public bool messagePreset;

	[StyledMessage("Info", "The Time Of Day feature works by interpolating two Fog Preset materials using the BOXOPHOBIC > Atmospherics > Fog Preset shader. Please note that not all material properties can be interpolated properly!", 10f, 0f)]
	public bool messageTimeOfDay;

	[Space(10f)]
	public Material presetMaterial;

	[Space(10f)]
	public Material presetDay;

	public Material presetNight;

	[Range(0f, 1f)]
	[Space(10f)]
	public float timeOfDay;

	[StyledCategory("Fog Settings")]
	public bool categoryFog;

	[Range(0f, 1f)]
	public float fogIntensity;

	[Space(10f)]
	public FogAxisMode fogAxisMode;

	public FogLayersMode fogLayersMode;

	public FogCameraMode fogCameraMode;

	[Space(10f)]
	[ColorUsage(false, true)]
	[FormerlySerializedAs("fogColor")]
	public Color fogColorStart;

	[ColorUsage(false, true)]
	public Color fogColorEnd;

	[Range(0f, 1f)]
	public float fogColorDuo;

	[Space(10f)]
	public float fogDistanceStart;

	public float fogDistanceEnd;

	[Range(1f, 8f)]
	public float fogDistanceFalloff;

	[Space(10f)]
	public float fogHeightStart;

	public float fogHeightEnd;

	[Range(1f, 8f)]
	public float fogHeightFalloff;

	[Space(10f)]
	public float farDistanceHeight;

	public float farDistanceOffset;

	[StyledCategory("Skybox Settings")]
	public bool categorySkybox;

	[Range(0f, 1f)]
	public float skyboxFogIntensity;

	[Range(0f, 1f)]
	public float skyboxFogHeight;

	[Range(1f, 8f)]
	public float skyboxFogFalloff;

	[Range(-1f, 1f)]
	public float skyboxFogOffset;

	[Range(0f, 1f)]
	public float skyboxFogBottom;

	[Range(0f, 1f)]
	public float skyboxFogFill;

	[StyledCategory("Directional Settings")]
	public bool categoryDirectional;

	[Range(0f, 1f)]
	public float directionalIntensity;

	[Range(1f, 8f)]
	public float directionalFalloff;

	[ColorUsage(false, true)]
	public Color directionalColor;

	[StyledCategory("Noise Settings")]
	public bool categoryNoise;

	[Range(0f, 1f)]
	public float noiseIntensity;

	[Range(0f, 1f)]
	public float noiseMin;

	[Range(0f, 1f)]
	public float noiseMax;

	public float noiseScale;

	public Vector3 noiseSpeed;

	[Space(10f)]
	public float noiseDistanceEnd;

	[StyledCategory("Advanced Settings")]
	public bool categoryAdvanced;

	public float jitterIntensity;

	[StyledSpace(5)]
	public bool styledSpace0;

	private Material localMaterial;

	private Material missingMaterial;

	private Material currentMaterial;

	private Collider volumeCollider;

	private HeightFogGlobal globalFog;

	private bool distanceSent;

	[HideInInspector]
	public int version;

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void OnDrawGizmos()
	{
	}

	private void GetCamera()
	{
	}

	private void GetDirectional()
	{
	}

	private void SetLocalMaterial()
	{
	}
}
