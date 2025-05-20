using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.AI;

[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
[NativeHeader("Modules/AI/Components/NavMeshAgent.bindings.h")]
[MovedFrom("UnityEngine")]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ai.navigation@1.1/manual/NavMeshAgent.html")]
public sealed class NavMeshAgent : Behaviour
{
	public Vector3 velocity
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 desiredVelocity => default(Vector3);

	public float remainingDistance => 0f;

	public bool hasPath
	{
		[NativeName("HasPath")]
		get
		{
			return false;
		}
	}

	public bool pathPending
	{
		[NativeName("PathPending")]
		get
		{
			return false;
		}
	}

	public bool isStopped
	{
		[FreeFunction("NavMeshAgentScriptBindings::SetIsStopped", HasExplicitThis = true)]
		set
		{
		}
	}

	public NavMeshPath path => null;

	public int agentTypeID
	{
		set
		{
		}
	}

	public int areaMask => 0;

	public float speed
	{
		set
		{
		}
	}

	public ObstacleAvoidanceType obstacleAvoidanceType
	{
		set
		{
		}
	}

	public int avoidancePriority
	{
		set
		{
		}
	}

	public bool isOnNavMesh
	{
		[NativeName("InCrowdSystem")]
		get
		{
			return false;
		}
	}

	public bool SetDestination(Vector3 target)
	{
		return false;
	}

	public bool Warp(Vector3 newPosition)
	{
		return false;
	}

	public void Move(Vector3 offset)
	{
	}

	public void ResetPath()
	{
	}

	public bool SetPath([NotNull("ArgumentNullException")] NavMeshPath path)
	{
		return false;
	}

	[NativeMethod("CopyPath")]
	internal void CopyPathTo([NotNull("ArgumentNullException")] NavMeshPath path)
	{
	}

	public bool CalculatePath(Vector3 targetPosition, NavMeshPath path)
	{
		return false;
	}

	[FreeFunction("NavMeshAgentScriptBindings::CalculatePathInternal", HasExplicitThis = true)]
	private bool CalculatePathInternal(Vector3 targetPosition, [NotNull("ArgumentNullException")] NavMeshPath path)
	{
		return false;
	}

	private bool SetDestination_Injected(ref Vector3 target)
	{
		return false;
	}

	[SpecialName]
	private void get_velocity_Injected(out Vector3 ret)
	{
		ret = default(Vector3);
	}

	[SpecialName]
	private void set_velocity_Injected(ref Vector3 value)
	{
	}

	[SpecialName]
	private void get_desiredVelocity_Injected(out Vector3 ret)
	{
		ret = default(Vector3);
	}

	private bool Warp_Injected(ref Vector3 newPosition)
	{
		return false;
	}

	private void Move_Injected(ref Vector3 offset)
	{
	}

	private bool CalculatePathInternal_Injected(ref Vector3 targetPosition, NavMeshPath path)
	{
		return false;
	}
}
