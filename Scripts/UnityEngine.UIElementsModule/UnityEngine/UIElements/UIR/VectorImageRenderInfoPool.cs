using System;

namespace UnityEngine.UIElements.UIR;

internal class VectorImageRenderInfoPool : LinkedPool<VectorImageRenderInfo>
{
	public VectorImageRenderInfoPool()
		: base((Func<VectorImageRenderInfo>)null, (Action<VectorImageRenderInfo>)null, 0)
	{
	}
}
