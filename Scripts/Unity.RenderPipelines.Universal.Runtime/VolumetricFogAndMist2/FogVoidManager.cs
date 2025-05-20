using System.Collections.Generic;
using UnityEngine;

namespace VolumetricFogAndMist2;

[ExecuteInEditMode]
[DefaultExecutionOrder(100)]
public class FogVoidManager : MonoBehaviour, IVolumetricFogManager
{
	public static bool usingVoids;

	public const int MAX_FOG_VOID = 8;

	[Header("Void Search Settings")]
	public Transform trackingCenter;

	[Tooltip("Fog voids are sorted by camera distance every certain time interval to ensure the nearest 8 voids are used.")]
	public float distanceSortTimeInterval;

	private static readonly List<FogVoid> fogVoids;

	private Vector4[] fogVoidPositions;

	private Vector4[] fogVoidSizes;

	private Matrix4x4[] fogVoidMatrices;

	private float distanceSortLastTime;

	private static bool requireRefresh;

	private int lastFogVoidCount;

	public string managerName => null;

	private void OnEnable()
	{
	}

	private void LateUpdate()
	{
	}

	private void SubmitFogVoidData()
	{
	}

	public static void RegisterFogVoid(FogVoid fogVoid)
	{
	}

	public static void UnregisterFogVoid(FogVoid fogVoid)
	{
	}

	public void TrackFogVoids(bool forceImmediateUpdate = false)
	{
	}

	private int fogVoidDistanceComparer(FogVoid v1, FogVoid v2)
	{
		return 0;
	}

	public void Refresh()
	{
	}
}
