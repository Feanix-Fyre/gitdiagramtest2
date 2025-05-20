using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.AI;

[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
public sealed class NavMeshData : Object
{
	public Vector3 position
	{
		set
		{
		}
	}

	public Quaternion rotation
	{
		set
		{
		}
	}

	public NavMeshData(int agentTypeID)
	{
	}

	[StaticAccessor("NavMeshDataBindings", StaticAccessorType.DoubleColon)]
	private static void Internal_Create([Writable] NavMeshData mono, int agentTypeID)
	{
	}

	[SpecialName]
	private void set_position_Injected(ref Vector3 value)
	{
	}

	[SpecialName]
	private void set_rotation_Injected(ref Quaternion value)
	{
	}
}
