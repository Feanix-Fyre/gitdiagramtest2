using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Serialization;

namespace Unity.AI.Navigation;

[DefaultExecutionOrder(-102)]
[AddComponentMenu("Navigation/NavMeshSurface", 30)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ai.navigation@1.1/manual/NavMeshSurface.html")]
[ExecuteAlways]
public class NavMeshSurface : MonoBehaviour
{
	[SerializeField]
	private int m_AgentTypeID;

	[SerializeField]
	private CollectObjects m_CollectObjects;

	[SerializeField]
	private Vector3 m_Size;

	[SerializeField]
	private Vector3 m_Center;

	[SerializeField]
	private LayerMask m_LayerMask;

	[SerializeField]
	private NavMeshCollectGeometry m_UseGeometry;

	[SerializeField]
	private int m_DefaultArea;

	[SerializeField]
	private bool m_GenerateLinks;

	[SerializeField]
	private bool m_IgnoreNavMeshAgent;

	[SerializeField]
	private bool m_IgnoreNavMeshObstacle;

	[SerializeField]
	private bool m_OverrideTileSize;

	[SerializeField]
	private int m_TileSize;

	[SerializeField]
	private bool m_OverrideVoxelSize;

	[SerializeField]
	private float m_VoxelSize;

	[SerializeField]
	private float m_MinRegionArea;

	[FormerlySerializedAs("m_BakedNavMeshData")]
	[SerializeField]
	private NavMeshData m_NavMeshData;

	[SerializeField]
	private bool m_BuildHeightMesh;

	private NavMeshDataInstance m_NavMeshDataInstance;

	private Vector3 m_LastPosition;

	private Quaternion m_LastRotation;

	private static readonly List<NavMeshSurface> s_NavMeshSurfaces;

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

	public CollectObjects collectObjects
	{
		get
		{
			return default(CollectObjects);
		}
		set
		{
		}
	}

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

	public LayerMask layerMask
	{
		get
		{
			return default(LayerMask);
		}
		set
		{
		}
	}

	public NavMeshCollectGeometry useGeometry
	{
		get
		{
			return default(NavMeshCollectGeometry);
		}
		set
		{
		}
	}

	public int defaultArea
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool ignoreNavMeshAgent
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ignoreNavMeshObstacle
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool overrideTileSize
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int tileSize
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool overrideVoxelSize
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float voxelSize
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float minRegionArea
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool buildHeightMesh
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public NavMeshData navMeshData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal NavMeshDataInstance navMeshDataInstance => default(NavMeshDataInstance);

	public static List<NavMeshSurface> activeSurfaces => null;

	private Bounds GetInflatedBounds()
	{
		return default(Bounds);
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void AddData()
	{
	}

	public void RemoveData()
	{
	}

	public NavMeshBuildSettings GetBuildSettings()
	{
		return default(NavMeshBuildSettings);
	}

	public void BuildNavMesh()
	{
	}

	public AsyncOperation UpdateNavMesh(NavMeshData data)
	{
		return null;
	}

	private static void Register(NavMeshSurface surface)
	{
	}

	private static void Unregister(NavMeshSurface surface)
	{
	}

	private static void UpdateActive()
	{
	}

	private void AppendModifierVolumes(ref List<NavMeshBuildSource> sources)
	{
	}

	private List<NavMeshBuildSource> CollectSources()
	{
		return null;
	}

	private static Vector3 Abs(Vector3 v)
	{
		return default(Vector3);
	}

	private static Bounds GetWorldBounds(Matrix4x4 mat, Bounds bounds)
	{
		return default(Bounds);
	}

	private Bounds CalculateWorldBounds(List<NavMeshBuildSource> sources)
	{
		return default(Bounds);
	}

	private bool HasTransformChanged()
	{
		return false;
	}

	private void UpdateDataIfTransformChanged()
	{
	}
}
