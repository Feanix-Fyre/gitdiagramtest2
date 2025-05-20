using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties;

[CreateAssetMenu(fileName = "Glowie", menuName = "Properties/Glowie Property")]
public class Glowie : Property
{
	[SerializeField]
	[ColorUsage(true, true)]
	public Color GlowColor;

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
