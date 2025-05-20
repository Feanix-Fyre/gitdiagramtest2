using System.Collections.Generic;

namespace UnityEngine.Rendering.Universal;

internal class PolyTree : PolyNode
{
	internal List<PolyNode> m_AllPolys;

	public int Total => 0;

	public void Clear()
	{
	}

	public PolyNode GetFirst()
	{
		return null;
	}
}
