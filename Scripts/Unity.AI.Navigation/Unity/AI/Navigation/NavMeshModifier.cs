using System.Collections.Generic;
using UnityEngine;

namespace Unity.AI.Navigation;

[HelpURL("https://docs.unity3d.com/Packages/com.unity.ai.navigation@1.1/manual/NavMeshModifier.html")]
[AddComponentMenu("Navigation/NavMeshModifier", 32)]
[ExecuteAlways]
public class NavMeshModifier : MonoBehaviour
{
	[SerializeField]
	private bool m_OverrideArea;

	[SerializeField]
	private int m_Area;

	[SerializeField]
	private bool m_OverrideGenerateLinks;

	[SerializeField]
	private bool m_GenerateLinks;

	[SerializeField]
	private bool m_IgnoreFromBuild;

	[SerializeField]
	private bool m_ApplyToChildren;

	[SerializeField]
	private List<int> m_AffectedAgents;

	private static readonly List<NavMeshModifier> s_NavMeshModifiers;

	public bool overrideArea
	{
		get
		{
			return false;
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

	public bool overrideGenerateLinks
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool generateLinks
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ignoreFromBuild
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool applyToChildren
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static List<NavMeshModifier> activeModifiers => null;

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
