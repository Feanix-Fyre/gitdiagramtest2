using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Property.Utilities.Water;

public class WaterManager : Singleton<WaterManager>
{
	[SerializeField]
	[Header("Prefabs")]
	protected GameObject waterPipePrefab;

	public static float pricePerL;

	private Dictionary<int, float> usageAtTime;

	private float usageThisMinute;

	protected override void Start()
	{
	}

	private void MinPass()
	{
	}

	private void DayPass()
	{
	}

	public float GetTotalUsage()
	{
		return 0f;
	}

	public void ConsumeWater(float litres)
	{
	}
}
