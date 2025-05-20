using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[RequiredByNativeCode]
[NativeHeader("Modules/Physics/MeshCollider.h")]
[NativeHeader("Runtime/Graphics/Mesh/Mesh.h")]
public class MeshCollider : Collider
{
	public Mesh sharedMesh
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool convex
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public MeshColliderCookingOptions cookingOptions
	{
		set
		{
		}
	}
}
