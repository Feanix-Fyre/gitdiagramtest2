using UnityEngine.Bindings;

namespace UnityEngine;

[StaticAccessor("GetLODGroupManager()", StaticAccessorType.Dot)]
[NativeHeader("Runtime/Graphics/LOD/LODGroup.h")]
[NativeHeader("Runtime/Graphics/LOD/LODGroupManager.h")]
[NativeHeader("Runtime/Graphics/LOD/LODUtility.h")]
public class LODGroup : Component
{
	public LODFadeMode fadeMode
	{
		set
		{
		}
	}

	public bool animateCrossFading
	{
		set
		{
		}
	}

	[FreeFunction("UpdateLODGroupBoundingBox", HasExplicitThis = true)]
	public void RecalculateBounds()
	{
	}

	[FreeFunction("SetLODs_Binding", HasExplicitThis = true)]
	public void SetLODs([Unmarshalled] LOD[] lods)
	{
	}

	[FreeFunction("ForceLODLevel", HasExplicitThis = true)]
	public void ForceLOD(int index)
	{
	}
}
