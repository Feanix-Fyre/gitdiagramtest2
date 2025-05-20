using UnityEngine.Bindings;

namespace UnityEngine.AI;

[NativeHeader("Modules/AI/Public/NavMeshBuildSettings.h")]
public struct NavMeshBuildSettings
{
	private int m_AgentTypeID;

	private float m_AgentRadius;

	private float m_AgentHeight;

	private float m_AgentSlope;

	private float m_AgentClimb;

	private float m_LedgeDropHeight;

	private float m_MaxJumpAcrossDistance;

	private float m_MinRegionArea;

	private int m_OverrideVoxelSize;

	private float m_VoxelSize;

	private int m_OverrideTileSize;

	private int m_TileSize;

	private int m_BuildHeightMesh;

	private uint m_MaxJobWorkers;

	private int m_PreserveTilesOutsideBounds;

	private NavMeshBuildDebugSettings m_Debug;

	public int agentTypeID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float agentRadius => 0f;

	public float minRegionArea
	{
		set
		{
		}
	}

	public bool overrideVoxelSize
	{
		set
		{
		}
	}

	public float voxelSize
	{
		set
		{
		}
	}

	public bool overrideTileSize
	{
		set
		{
		}
	}

	public int tileSize
	{
		set
		{
		}
	}

	public bool buildHeightMesh
	{
		set
		{
		}
	}
}
