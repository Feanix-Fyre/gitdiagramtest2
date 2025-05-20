using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties;

[CreateAssetMenu(fileName = "Spicy", menuName = "Properties/Spicy Property")]
public class Spicy : Property
{
	[SerializeField]
	[ColorUsage(true, true)]
	public Color TintColor;

	public override void ApplyToNPC(NPC npc)
	{
	}

	public override void ApplyToPlayer(Player player)
	{
	}

	public override void ClearFromNPC(NPC npc)
	{
	}

	public override void ClearFromPlayer(Player player)
	{
	}
}
