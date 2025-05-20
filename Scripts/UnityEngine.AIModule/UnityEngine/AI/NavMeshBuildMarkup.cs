using UnityEngine.Bindings;

namespace UnityEngine.AI;

[NativeHeader("Modules/AI/Public/NavMeshBindingTypes.h")]
public struct NavMeshBuildMarkup
{
	private int m_OverrideArea;

	private int m_Area;

	private int m_InheritIgnoreFromBuild;

	private int m_IgnoreFromBuild;

	private int m_OverrideGenerateLinks;

	private int m_GenerateLinks;

	private int m_InstanceID;

	private int m_IgnoreChildren;

	public bool overrideArea
	{
		set
		{
		}
	}

	public int area
	{
		set
		{
		}
	}

	public bool ignoreFromBuild
	{
		set
		{
		}
	}

	public bool overrideGenerateLinks
	{
		set
		{
		}
	}

	public bool generateLinks
	{
		set
		{
		}
	}

	public bool applyToChildren
	{
		set
		{
		}
	}

	public Transform root
	{
		set
		{
		}
	}
}
