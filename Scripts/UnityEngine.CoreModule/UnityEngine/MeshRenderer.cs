using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Mesh/MeshRenderer.h")]
public class MeshRenderer : Renderer
{
	public int subMeshStartIndex
	{
		[NativeName("GetSubMeshStartIndex")]
		get
		{
			return 0;
		}
	}

	[RequiredByNativeCode]
	private void DontStripMeshRenderer()
	{
	}
}
