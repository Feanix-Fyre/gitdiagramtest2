using System.Collections.Generic;
using UnityEngine;

namespace VolumetricFogAndMist2;

public class VolumetricFogSubVolume : MonoBehaviour
{
	public VolumetricFogProfile profile;

	public float fadeDistance;

	public static List<VolumetricFogSubVolume> subVolumes;

	private void OnDrawGizmos()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public Bounds GetBounds()
	{
		return default(Bounds);
	}

	public void SetBounds(Bounds bounds)
	{
	}
}
