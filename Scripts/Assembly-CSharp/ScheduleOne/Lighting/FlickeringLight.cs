using UnityEngine;

namespace ScheduleOne.Lighting;

[RequireComponent(typeof(Light))]
public class FlickeringLight : MonoBehaviour
{
	[Tooltip("The minimum light intensity.")]
	[Header("Intensity Settings")]
	public float minIntensity;

	[Tooltip("The maximum light intensity.")]
	public float maxIntensity;

	[Tooltip("Enable slight color shifts to simulate a warm flame.")]
	[Header("Color Settings")]
	public bool enableColorShift;

	public Color minColor;

	public Color maxColor;

	[Header("Flicker Speed")]
	[Tooltip("How quickly the light flickers (lower is faster).")]
	public float flickerSpeed;

	private Light lightSource;

	private float targetIntensity;

	private Color targetColor;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void UpdateTargetValues()
	{
	}
}
