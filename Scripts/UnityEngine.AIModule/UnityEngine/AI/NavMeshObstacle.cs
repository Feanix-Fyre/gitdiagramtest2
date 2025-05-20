using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.AI;

[MovedFrom("UnityEngine")]
[NativeHeader("Modules/AI/Components/NavMeshObstacle.bindings.h")]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ai.navigation@1.1/manual/NavMeshObstacle.html")]
public sealed class NavMeshObstacle : Behaviour
{
	public float height
	{
		set
		{
		}
	}

	public float radius
	{
		set
		{
		}
	}

	public bool carving
	{
		set
		{
		}
	}

	public bool carveOnlyStationary
	{
		set
		{
		}
	}

	public NavMeshObstacleShape shape
	{
		set
		{
		}
	}

	public Vector3 center
	{
		set
		{
		}
	}

	public Vector3 size
	{
		[FreeFunction("NavMeshObstacleScriptBindings::SetSize", HasExplicitThis = true)]
		set
		{
		}
	}

	[SpecialName]
	private void set_center_Injected(ref Vector3 value)
	{
	}

	[SpecialName]
	private void set_size_Injected(ref Vector3 value)
	{
	}
}
