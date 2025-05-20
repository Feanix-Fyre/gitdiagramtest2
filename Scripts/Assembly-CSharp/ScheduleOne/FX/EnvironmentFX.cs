using AtmosphericHeightFog;
using Funly.SkyStudio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Tools;
using UnityEngine;
using VolumetricFogAndMist2;

namespace ScheduleOne.FX;

[ExecuteInEditMode]
public class EnvironmentFX : Singleton<EnvironmentFX>
{
	[SerializeField]
	[Header("References")]
	protected WindZone windZone;

	[SerializeField]
	protected TimeOfDayController timeOfDayController;

	public HeightFogGlobal HeightFog;

	public VolumetricFog VolumetricFog;

	public Light SunLight;

	public Light MoonLight;

	[Header("Fog")]
	[SerializeField]
	protected Gradient fogColorGradient;

	[SerializeField]
	protected AnimationCurve fogEndDistanceCurve;

	[SerializeField]
	protected float fogEndDistanceMultiplier;

	[Header("Height Fog")]
	[SerializeField]
	protected Gradient HeightFogColor;

	[SerializeField]
	protected AnimationCurve HeightFogIntensityCurve;

	[SerializeField]
	protected float HeightFogIntensityMultiplier;

	[SerializeField]
	protected AnimationCurve HeightFogDirectionalIntensityCurve;

	[Header("Volumetric Fog")]
	[SerializeField]
	protected Gradient VolumetricFogColor;

	[SerializeField]
	protected AnimationCurve VolumetricFogIntensityCurve;

	[SerializeField]
	protected float VolumetricFogIntensityMultiplier;

	[SerializeField]
	[Header("God rays")]
	protected AnimationCurve godRayIntensityCurve;

	[Header("Contrast")]
	[SerializeField]
	protected AnimationCurve contrastCurve;

	[SerializeField]
	protected float contractMultiplier;

	[SerializeField]
	[Header("Saturation")]
	protected AnimationCurve saturationCurve;

	[SerializeField]
	protected float saturationMultiplier;

	[SerializeField]
	[Header("Grass")]
	protected Material grassMat;

	[SerializeField]
	protected Gradient grassColorGradient;

	[Header("Trees")]
	public Material distanceTreeMat;

	public AnimationCurve distanceTreeColorCurve;

	[Header("Stealth settings")]
	public AnimationCurve environmentalBrightnessCurve;

	[Header("Bloom")]
	public AnimationCurve bloomThreshholdCurve;

	private bool started;

	public FloatSmoother FogEndDistanceController;

	public float normalizedEnvironmentalBrightness => 0f;

	protected override void Start()
	{
	}

	private void Update()
	{
	}

	private void UpdateVisuals()
	{
	}

	protected override void OnDestroy()
	{
	}
}
