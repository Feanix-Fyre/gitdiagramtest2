using ScheduleOne.DevUtilities;
using UnityEngine;
using VLB;

namespace ScheduleOne.Lighting;

[ExecuteInEditMode]
[RequireComponent(typeof(VolumetricLightBeamSD))]
[RequireComponent(typeof(Light))]
public class VolumetricLightTracker : MonoBehaviour
{
	public bool Override;

	public bool Enabled;

	public Light light;

	public OptimizedLight optimizedLight;

	public VolumetricLightBeamSD beam;

	public VolumetricDustParticles dust;

	private void OnValidate()
	{
	}

	private void LateUpdate()
	{
	}
}
