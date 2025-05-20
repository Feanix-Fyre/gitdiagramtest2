using UnityEngine;
using UnityEngine.AI;

namespace ScheduleOne.Misc;

public class CarStopper : MonoBehaviour
{
	public bool isActive;

	[SerializeField]
	[Header("References")]
	protected Transform blocker;

	public NavMeshObstacle Obstacle;

	private float moveTime;

	protected virtual void Update()
	{
	}
}
