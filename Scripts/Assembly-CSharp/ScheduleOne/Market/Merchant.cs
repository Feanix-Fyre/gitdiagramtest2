using ScheduleOne.Interaction;
using UnityEngine;

namespace ScheduleOne.Market;

public class Merchant : MonoBehaviour
{
	[SerializeField]
	[Header("Settings")]
	protected string shopName;

	[SerializeField]
	protected int openTime;

	[SerializeField]
	protected int closeTime;

	[SerializeField]
	[Header("References")]
	protected InteractableObject intObj;

	protected virtual void Start()
	{
	}

	public void Hovered()
	{
	}

	public virtual void Interacted()
	{
	}
}
