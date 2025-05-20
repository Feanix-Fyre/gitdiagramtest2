using UnityEngine;

namespace VolumetricFogAndMist2;

[ExecuteInEditMode]
public class FogVoid : MonoBehaviour
{
	[Range(0f, 1f)]
	public float roundness;

	[Range(0f, 1f)]
	public float falloff;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
