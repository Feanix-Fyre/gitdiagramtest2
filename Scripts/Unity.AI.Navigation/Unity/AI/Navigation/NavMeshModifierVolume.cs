using System.Collections.Generic;
using UnityEngine;

namespace Unity.AI.Navigation;

[AddComponentMenu("Navigation/NavMeshModifierVolume", 31)]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ai.navigation@1.1/manual/NavMeshModifierVolume.html")]
public class NavMeshModifierVolume : MonoBehaviour
{
	[SerializeField]
	private Vector3 m_Size;

	[SerializeField]
	private Vector3 m_Center;

	[SerializeField]
	private int m_Area;

	[SerializeField]
	private List<int> m_AffectedAgents;

	private static readonly List<NavMeshModifierVolume> s_NavMeshModifiers;

	public Vector3 size
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 center
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public int area
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static List<NavMeshModifierVolume> activeModifiers => null;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public bool AffectsAgentType(int agentTypeID)
	{
		return false;
	}
}
