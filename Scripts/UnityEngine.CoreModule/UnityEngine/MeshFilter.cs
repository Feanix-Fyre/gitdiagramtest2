using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Mesh/MeshFilter.h")]
[RequireComponent(typeof(Transform))]
public sealed class MeshFilter : Component
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

	public Mesh mesh
	{
		[NativeName("SetInstantiatedMesh")]
		set
		{
		}
	}

	[RequiredByNativeCode]
	private void DontStripMeshFilter()
	{
	}
}
