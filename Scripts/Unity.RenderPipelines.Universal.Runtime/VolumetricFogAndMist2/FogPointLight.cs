using System;
using UnityEngine;

namespace VolumetricFogAndMist2;

[ExecuteInEditMode]
public class FogPointLight : MonoBehaviour
{
	[NonSerialized]
	public Light pointLight;

	[Tooltip("Inscattering multiplier for this point light")]
	public float inscattering;

	[Tooltip("Intensity multiplier for this point light")]
	public float intensity;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnValidate()
	{
	}
}
